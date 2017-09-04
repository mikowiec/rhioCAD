//===============================================================================
// Microsoft patterns & practices
// CompositeUI Application Block
//===============================================================================
// Copyright © Microsoft Corporation.  All rights reserved.
// THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY
// OF ANY KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT
// LIMITED TO THE IMPLIED WARRANTIES OF MERCHANTABILITY AND
// FITNESS FOR A PARTICULAR PURPOSE.
//===============================================================================

using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;
using System.ComponentModel;
using System.Threading;
using Microsoft.Practices.CompositeUI.Utility;
using System.Globalization;
using System.Diagnostics;

namespace Microsoft.Practices.CompositeUI.EventBroker
{
	/// <summary>
	/// Represents a topic subscription.
	/// </summary>
	internal class Subscription
	{
		private WeakReference wrSubscriber;
		private string handlerMethodName;
		private RuntimeMethodHandle methodHandle;
		private ThreadOption threadOption;
		private SynchronizationContext syncContext;
		private WorkItemSubscriptions workItemSubscriptions;
		private Type handlerEventArgsType = null;
		private RuntimeTypeHandle typeHandle;

		/// <summary>
		/// Initializes a new instance of the <see cref="Subscription"/> class.
		/// </summary>
		internal Subscription(
			WorkItemSubscriptions workItemSubscriptions, object subscriber, string handlerMethodName, ThreadOption threadOption)
			: this(workItemSubscriptions, subscriber, handlerMethodName, null, threadOption)
		{
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="Subscription"/> class
		/// </summary>
		internal Subscription(
			WorkItemSubscriptions workItemSubscriptions,
			object subscriber,
			string handlerMethodName,
			Type[] parameterTypes,
			ThreadOption threadOption)
		{
			this.wrSubscriber = new WeakReference(subscriber);
			this.handlerMethodName = handlerMethodName;
			this.threadOption = threadOption;
			this.workItemSubscriptions = workItemSubscriptions;

			MethodInfo miHandler = GetMethodInfo(subscriber, handlerMethodName, parameterTypes);
			if (miHandler == null)
			{
				throw new EventBrokerException(String.Format(CultureInfo.CurrentCulture,
					Properties.Resources.SubscriberHandlerNotFound,
					handlerMethodName, subscriber.GetType().ToString()));
			}
			else if (miHandler.IsStatic)
			{
				throw new EventBrokerException(String.Format(CultureInfo.CurrentCulture,
					Properties.Resources.CannotRegisterStaticSubscriptionMethods,
					miHandler.DeclaringType.FullName, miHandler.Name));

			}

			this.typeHandle = subscriber.GetType().TypeHandle;
			this.methodHandle = miHandler.MethodHandle;
			ParameterInfo[] parameters = miHandler.GetParameters();
			if (IsValidEventHandler(parameters))
			{
				ParameterInfo pInfo = miHandler.GetParameters()[1];
				Type pType = pInfo.ParameterType;
				handlerEventArgsType = typeof(EventHandler<>).MakeGenericType(pType);
			}
			else
			{
				throw new EventBrokerException(String.Format(CultureInfo.CurrentCulture,
					Properties.Resources.InvalidSubscriptionSignature,
					miHandler.DeclaringType.FullName, miHandler.Name));
			}

			if (threadOption == ThreadOption.UserInterface)
			{
				// If there's a syncronization context (i.e. the WindowsFormsSynchronizationContext 
				// created to marshal back to the thread where a control was initially created 
				// in a particular thread), capture it to marshal back to it through the 
				// context, that basically goes through a Post/Send.
				if (SynchronizationContext.Current != null)
				{
					syncContext = SynchronizationContext.Current;
				}
			}
		}

		private static bool IsValidEventHandler(ParameterInfo[] parameters)
		{
			return parameters.Length == 2 &&
							typeof(EventArgs).IsAssignableFrom(parameters[1].ParameterType);
		}

		private MethodInfo GetMethodInfo(object subscriber, string handlerMethodName, Type[] parameterTypes)
		{
			if (parameterTypes != null)
			{
				return subscriber.GetType().GetMethod(handlerMethodName, parameterTypes);
			}
			else
			{
				return subscriber.GetType().GetMethod(handlerMethodName);
			}
		}

		/// <summary>
		/// The subscriber of the event.
		/// </summary>
		public object Subscriber
		{
			get { return wrSubscriber.Target; }
		}

		/// <summary>
		/// The handler method name that's subscribed to the event.
		/// </summary>
		public string HandlerMethodName
		{
			get { return handlerMethodName; }
		}

		/// <summary>
		/// The callback thread option for the event.
		/// </summary>
		public ThreadOption ThreadOption
		{
			get { return threadOption; }
		}

		internal EventTopicFireDelegate GetHandler()
		{
			return EventTopicFireHandler;
		}

		private void EventTopicFireHandler(object sender, EventArgs e,
			List<Exception> exceptions, TraceSource traceSource)
		{
			object subscriber = wrSubscriber.Target;
			if (subscriber == null)
			{
				return;
			}
			switch (threadOption)
			{
				case ThreadOption.Publisher:
					CallOnPublisher(sender, e, exceptions);
					break;
				case ThreadOption.Background:
					CallOnBackgroundWorker(sender, e, traceSource);
					break;
				case ThreadOption.UserInterface:
					CallOnUserInterface(sender, e, exceptions);
					break;
				default:
					break;
			}
		}

		private void CallOnPublisher(object sender, EventArgs e, List<Exception> exceptions)
		{
			try
			{
				Delegate handler = CreateSubscriptionDelegate();
				if (handler != null)
				{
					handler.DynamicInvoke(sender, e);
				}
			}
			catch (TargetInvocationException ex)
			{
				exceptions.Add(ex.InnerException);
			}
		}

		private void CallOnBackgroundWorker(object sender, EventArgs e, TraceSource traceSource)
		{
			Delegate handler = CreateSubscriptionDelegate();
			if (handler != null)
			{
				ThreadPool.QueueUserWorkItem(new WaitCallback(delegate(object state)
				{
					CallInBackgroundArguments args = (CallInBackgroundArguments)state;
					try
					{
						args.Handler.DynamicInvoke(args.Sender, args.EventArgs);
					}
					catch (Exception ex)
					{
						args.TraceSource.TraceInformation(Properties.Resources.BackgroundSubscriberException, ex.ToString());
						throw;
					}

				}), new CallInBackgroundArguments(sender, e, handler, traceSource));
			}
		}

		private void CallOnUserInterface(object sender, EventArgs e, List<Exception> exceptions)
		{
			Delegate handler = CreateSubscriptionDelegate();
			if (handler != null)
			{
				if (syncContext != null)
				{
					syncContext.Send(delegate(object data)
					{
						try
						{
							((Delegate)data).DynamicInvoke(sender, e);
						}
						catch (TargetInvocationException ex)
						{
							exceptions.Add(ex.InnerException);
						}
					}, handler);
				}
				else
				{
					try
					{
						handler.DynamicInvoke(sender, e);
					}
					catch (TargetInvocationException ex)
					{
						exceptions.Add(ex.InnerException);
					}
				}
			}
		}

		private Delegate CreateSubscriptionDelegate()
		{
			object subscriber = wrSubscriber.Target;
			if (subscriber != null)
			{
				return Delegate.CreateDelegate(this.handlerEventArgsType, subscriber,
					(MethodInfo)MethodInfo.GetMethodFromHandle(methodHandle, typeHandle));
			}
			return null;
		}

		private struct CallInBackgroundArguments
		{
			public Delegate Handler;
			public object Sender;
			public EventArgs EventArgs;
			public TraceSource TraceSource;

			public CallInBackgroundArguments(object sender, EventArgs eventArgs, Delegate handler, TraceSource traceSource)
			{
				Sender = sender;
				EventArgs = eventArgs;
				Handler = handler;
				TraceSource = traceSource;
			}
		}
	}
}
