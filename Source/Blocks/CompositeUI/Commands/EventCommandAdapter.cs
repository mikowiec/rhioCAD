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
using Microsoft.Practices.CompositeUI.Utility;
using System.Globalization;

namespace Microsoft.Practices.CompositeUI.Commands
{
	/// <summary>
	/// A <see cref="CommandAdapter"/> that fires a .NET event when the command is fired.
	/// </summary>
	/// <typeparam name="TInvoker">Type of the invoker(s)</typeparam>
	/// <remarks>This adapter allows a set of invokers of a given type TIvoker
	/// to fire a single <see cref="Command"/>.</remarks>
	public class EventCommandAdapter<TInvoker> : CommandAdapter
	{
		private ListDictionary<TInvoker, string> invokers = new ListDictionary<TInvoker, string>();

		/// <summary>
		/// Initializes a new instance of the <see cref="EventCommandAdapter{TInvoker}"/> class
		/// </summary>
		public EventCommandAdapter()
		{
		}

		/// <summary>
		/// Initializes a new instance and wires the specified invoker event to this adapter.
		/// </summary>
		/// <param name="invoker">The invoker that is to be adapted.</param>
		/// <param name="eventName">The event the adapter will listen on the invoker.</param>
		public EventCommandAdapter(TInvoker invoker, string eventName)
		{
			WireUpInvoker(invoker, eventName);
		}

		/// <summary>
		/// Gets the list of invokers in the adapter.
		/// </summary>
		public ReadOnlyDictionary<TInvoker, List<string>> Invokers
		{
			get { return new ReadOnlyDictionary<TInvoker, List<string>>(invokers); }
		}

		/// <summary>
		/// The handler for the invokers events.
		/// </summary>
		public void InvokerEventHandler(object sender, EventArgs e)
		{
			FireCommand();
		}

		/// <summary>
		/// Adds an invoker with the specified eventName.
		/// </summary>
		/// <param name="invoker">The invoker object to add.</param>
		/// <param name="eventName">The event on the invoker the adapter will listen to.</param>
		public override void AddInvoker(object invoker, string eventName)
		{
			Guard.ArgumentNotNull(invoker, "invoker");
			ThrowIfWrongType(invoker);
			WireUpInvoker((TInvoker)invoker, eventName);
		}

		/// <summary>
		/// Removes the invoker from the adapter.
		/// </summary>
		/// <param name="invoker">The invoker object to remove.</param>
		/// <param name="eventName">The name of the event on the invoker the adapter is listening to.</param>
		public override void RemoveInvoker(object invoker, string eventName)
		{
			UnwireInvoker(invoker, eventName);
			RemoveInvokerIfZeroEvents(invoker);
		}

		/// <summary>
		/// Overriden to unhook and dispose all the invokers.
		/// </summary>
		protected override void Dispose(bool disposing)
		{
            if (disposing)
            {
                foreach (KeyValuePair<TInvoker, List<string>> pair in invokers)
                {
                    List<string> events = pair.Value;
                    for (int i = events.Count - 1; i >= 0; i--)
                    {
                        UnwireInvoker(pair.Key, events[i]);
                    }
                }

                invokers.Clear();
            }
            base.Dispose(disposing);
        }

		/// <summary>
		/// Checks if the adapter contains the invoker.
		/// </summary>
		/// <param name="invoker">The invoker to check for</param>
		/// <returns>true if the adapter contains the invoker; otherwise false.</returns>
		public override bool ContainsInvoker(object invoker)
		{
			if (typeof(TInvoker).IsAssignableFrom(invoker.GetType()) == false)
			{
				return false;
			}
			else
			{
				return invokers.ContainsKey((TInvoker)invoker);
			}
		}

		/// <summary>
		/// Gets the count of invokers in the adapter
		/// </summary>
		public override int InvokerCount
		{
			get 
			{
				return invokers.Count;
			}
		}

		private void WireUpInvoker(TInvoker invoker, string eventName)
		{
			Guard.ArgumentNotNull(invoker, "invoker");
			Guard.ArgumentNotNull(eventName, "evenName");
			ThrowIfWrongType(invoker);

			if (invokers.ContainsKey(invoker) == false)
			{
				HookInvokerEvent(invoker, eventName);
				invokers.Add(invoker, eventName);
			}
			else if (invokers[invoker].Contains(eventName) == false)
			{
				invokers[invoker].Add(eventName);
				HookInvokerEvent(invoker, eventName);
			}
		}

		private void UnwireInvoker(object invoker, string eventName)
		{
			Guard.ArgumentNotNull(invoker, "invoker");
			Guard.ArgumentNotNullOrEmptyString(eventName, "eventName");
			ThrowIfWrongType(invoker);

			TInvoker typedInvoker = (TInvoker)invoker;
			if (invokers.ContainsKey(typedInvoker) == true)
			{
				UnhookInvokerEvent(invoker, eventName);
				invokers[typedInvoker].Remove(eventName);
			}
		}

		private void RemoveInvokerIfZeroEvents(object invoker)
		{
			Guard.ArgumentNotNull(invoker, "invoker");
			ThrowIfWrongType(invoker);

			TInvoker typedInvoker = (TInvoker)invoker;
			if (invokers.ContainsKey(typedInvoker) && invokers[typedInvoker].Count == 0)
			{
				invokers.Remove(typedInvoker);
			}
		}

		private void HookInvokerEvent(object invoker, string eventName)
		{
			EventInfo eventInfo = GetEventInfo(invoker, eventName);
			Delegate handlerDelegate = Delegate.CreateDelegate(eventInfo.EventHandlerType, this, InvokerEventHandle);
			eventInfo.AddEventHandler(invoker, handlerDelegate);
		}

		private void UnhookInvokerEvent(object invoker, string eventName)
		{
			EventInfo eventInfo = GetEventInfo(invoker, eventName);
			Delegate handlerDelegate = Delegate.CreateDelegate(eventInfo.EventHandlerType, this, InvokerEventHandle);
			eventInfo.RemoveEventHandler(invoker, handlerDelegate);
		}


		private EventInfo GetEventInfo(object invoker, string eventName)
		{
			Type invokerType = invoker.GetType();
			EventInfo eventInfo = invokerType.GetEvent(eventName, BindingFlags.Instance |BindingFlags.Static | BindingFlags.Public);

			if (eventInfo == null)
			{
				throw new CommandException(String.Format(CultureInfo.CurrentCulture,
					Properties.Resources.EventNotPresentOnInvoker, eventName, invokerType.FullName));
			}
			if (eventInfo.GetAddMethod().IsStatic ||
				eventInfo.GetRemoveMethod().IsStatic)
			{
				throw new CommandException(
					string.Format(CultureInfo.CurrentCulture,
					Properties.Resources.StaticCommandPublisherNotSupported, eventInfo.Name));
			}
			return eventInfo;
		}


		private MethodInfo InvokerEventHandle
		{
			get
			{
				return this.GetType().GetMethod("InvokerEventHandler", BindingFlags.Instance | BindingFlags.Public);
			}
		}

		private void ThrowIfWrongType(object invoker)
		{
			if (typeof(TInvoker).IsAssignableFrom(invoker.GetType()) == false)
			{
				throw new ArgumentException(
					string.Format(CultureInfo.CurrentCulture,
					Properties.Resources.EventCommandAdapterInvokerNotType,
					typeof(TInvoker)));
			}
		}
	}
}
