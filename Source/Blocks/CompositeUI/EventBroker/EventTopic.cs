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
using Microsoft.Practices.CompositeUI.Utility;
using System.ComponentModel;
using System.Collections.ObjectModel;
using System.Diagnostics;
using Microsoft.Practices.ObjectBuilder;

namespace Microsoft.Practices.CompositeUI.EventBroker
{
	/// <summary>
	/// Represents a point of communication on a certain topic between the topic publishers and the topic subscribers.
	/// </summary>
	public class EventTopic : IDisposable, IBuilderAware
	{
		private string name;
		private bool enabled = true;
		private List<Publication> publications = new List<Publication>();
		private List<WorkItemSubscriptions> workItemSubscriptions = new List<WorkItemSubscriptions>();
		private TraceSource traceSource = null;

		/// <summary>
		/// Sets the <see cref="TraceSource"/> to use for information tracing.
		/// </summary>
		[ClassNameTraceSource]
		public TraceSource TraceSource
		{
			set { traceSource = value; }
			protected get { return traceSource; }
		}

		/// <summary>
		/// Gets the topic name.
		/// </summary>
		public string Name
		{
			get { return name; }
		}

		/// <summary>
		/// Gets or sets the enabled state of the topic. A disable topic will not fire events.
		/// </summary>
		public bool Enabled
		{
			get { return enabled; }
			set { enabled = value; }
		}

		/// <summary>
		/// Adds a publication to the topic.
		/// </summary>
		/// <param name="publisher">The object that publishes the event that will fire the topic.</param>
		/// <param name="eventName">The name of the event.</param>
		/// <param name="workItem">The <see cref="WorkItem"/> where the publisher is.</param>
		/// <param name="scope">A <see cref="PublicationScope"/> value which states scope for the publication.</param>
		public virtual void AddPublication(object publisher, string eventName, WorkItem workItem, PublicationScope scope)
		{
			Guard.ArgumentNotNull(publisher, "publisher");
			Guard.ArgumentNotNullOrEmptyString(eventName, "eventName");
			Guard.ArgumentNotNull(workItem, "workItem");
			Guard.EnumValueIsDefined(typeof(PublicationScope), scope, "scope");
			Clean();
			ThrowIfRepeatedPublication(publisher, eventName);

			Publication publication = new Publication(this, publisher, eventName, workItem, scope);

			publications.Add(publication);

			if (traceSource != null)
				traceSource.TraceInformation(Properties.Resources.EventTopicTracePublicationAdded,
					name, eventName, publisher.GetType().ToString());
		}

		/// <summary>
		/// Checks if the specified publication has been registered with this <see cref="EventTopic"/>.
		/// </summary>
		/// <param name="publisher">The object that contains the publication.</param>
		/// <param name="eventName">The name of event on the publisher that fires the topic.</param>
		/// <returns>true if the topic contains the requested publication; otherwise false.</returns>
		public virtual bool ContainsPublication(object publisher, string eventName)
		{
			Guard.ArgumentNotNull(publisher, "publisher");
			Guard.ArgumentNotNull(eventName, "eventName");
			Clean();
			return FindPublication(publisher, eventName) != null;
		}

		/// <summary>
		/// Removes a publication from the topic.
		/// </summary>
		/// <param name="publisher">The object that contains the publication.</param>
		/// <param name="eventName">The name of event on the publisher that fires the topic.</param>
		public virtual void RemovePublication(object publisher, string eventName)
		{
			Guard.ArgumentNotNull(publisher, "publisher");
			Guard.ArgumentNotNull(eventName, "eventName");
			Clean();
			Publication publication = FindPublication(publisher, eventName);
			if (publication != null)
			{
				publications.Remove(publication);
				publication.Dispose();

				if (traceSource != null)
					traceSource.TraceInformation(Properties.Resources.EventTopicTracePublicationRemoved,
						name, eventName, publisher.GetType().ToString());
			}
		}

		/// <summary>
		/// Gets the count of registered publications with this <see cref="EventTopic"/>.
		/// </summary>
		public virtual int PublicationCount
		{
			get
			{
				Clean();
				return publications.Count;
			}
		}

		/// <summary>
		/// Fires the <see cref="EventTopic"/>.
		/// </summary>
		/// <param name="sender">The object that acts as the sender of the event to the subscribers.</param>
		/// <param name="e">An <see cref="EventArgs"/> instance to be passed to the subscribers.</param>
		/// <param name="workItem">The <see cref="WorkItem"/> where the object firing the event is.</param>
		/// <param name="scope">A <see cref="PublicationScope"/> value stating the scope of the firing behavior.</param>
		public virtual void Fire(object sender, EventArgs e, WorkItem workItem, PublicationScope scope)
		{
			Guard.EnumValueIsDefined(typeof(PublicationScope), scope, "scope");

			if (enabled)
			{
				if (traceSource != null)
					traceSource.TraceInformation(Properties.Resources.EventTopicTraceFireStarted, name);

				Clean();

				switch (scope)
				{
					case PublicationScope.WorkItem:
						CallSubscriptionHandlers(sender, e, GetWorkItemHandlers(workItem));
						break;
					case PublicationScope.Global:
						CallSubscriptionHandlers(sender, e, GetAllHandlers());
						break;
					case PublicationScope.Descendants:
						CallSubscriptionHandlers(sender, e, GetDescendantsHandlers(workItem));
						break;
					default:
						throw new ArgumentException(Properties.Resources.InvalidPublicationScope);
				}

				if (traceSource != null)
					traceSource.TraceInformation(Properties.Resources.EventTopicTraceFireCompleted, name);
			}
		}

		/// <summary>
		/// Adds a subcription to this <see cref="EventTopic"/>.
		/// </summary>
		/// <param name="subscriber">The object that contains the method that will handle the <see cref="EventTopic"/>.</param>
		/// <param name="handlerMethodName">The name of the method on the subscriber that will handle the <see cref="EventTopic"/>.</param>
		/// <param name="workItem">The <see cref="WorkItem"/> where the subscriber is.</param>
		/// <param name="threadOption">A <see cref="ThreadOption"/> value indicating how the handler method should be called.</param>
		public virtual void AddSubscription(object subscriber, string handlerMethodName, WorkItem workItem, ThreadOption threadOption)
		{
			AddSubscription(subscriber, handlerMethodName, null, workItem, threadOption);
		}

		/// <summary>
		/// Adds a subcription to this <see cref="EventTopic"/>.
		/// </summary>
		/// <param name="subscriber">The object that contains the method that will handle the <see cref="EventTopic"/>.</param>
		/// <param name="handlerMethodName">The name of the method on the subscriber that will handle the <see cref="EventTopic"/>.</param>
		/// <param name="workItem">The <see cref="WorkItem"/> where the subscriber is.</param>
		/// <param name="threadOption">A <see cref="ThreadOption"/> value indicating how the handler method should be called.</param>
		/// <param name="parameterTypes">Defines the types and order of the parameters for the subscriber. For none pass null.
		/// Use this overload when there are several methods with the same name on the subscriber.</param>
		public virtual void AddSubscription(object subscriber, string handlerMethodName, Type[] parameterTypes, WorkItem workItem, ThreadOption threadOption)
		{
			Guard.ArgumentNotNull(subscriber, "subscriber");
			Guard.ArgumentNotNullOrEmptyString(handlerMethodName, "handlerMethodName");
			Guard.EnumValueIsDefined(typeof(ThreadOption), threadOption, "threadOption");
			Clean();
			WorkItemSubscriptions wis = FindWorkItemSubscription(workItem);
			if (wis == null)
			{
				wis = new WorkItemSubscriptions(workItem);
				workItemSubscriptions.Add(wis);
			}
			wis.AddSubscription(subscriber, handlerMethodName, parameterTypes, threadOption);

			if (traceSource != null)
				traceSource.TraceInformation(Properties.Resources.EventTopicTraceSubscriptionAdded,
					name, handlerMethodName, subscriber.GetType().ToString());
		}


		/// <summary>
		/// Removes a subscription from this <see cref="EventTopic"/>.
		/// </summary>
		/// <param name="subscriber">The object that contains the method that will handle the <see cref="EventTopic"/>.</param>
		/// <param name="handlerMethodName">The name of the method on the subscriber that will handle the <see cref="EventTopic"/>.</param>
		public virtual void RemoveSubscription(object subscriber, string handlerMethodName)
		{
			Guard.ArgumentNotNull(subscriber, "subscriber");
			Guard.ArgumentNotNull(handlerMethodName, "handlerMethodName");
			Clean();
			foreach (WorkItemSubscriptions wis in workItemSubscriptions)
			{
				wis.RemoveSubscription(subscriber, handlerMethodName);
			}

			if (traceSource != null)
				traceSource.TraceInformation(Properties.Resources.EventTopicTraceSubscriptionRemoved,
					name, handlerMethodName, subscriber.GetType().ToString());
		}

		/// <summary>
		/// Checks if the specified subscription has been registered with this <see cref="EventTopic"/>.
		/// </summary>
		/// <param name="subscriber">The object that contains the method that will handle the <see cref="EventTopic"/>.</param>
		/// <param name="handlerMethodName">The name of the method on the subscriber that will handle the <see cref="EventTopic"/>.</param>
		/// <returns>true, if the topic contains the subscription; otherwise false.</returns>
		public virtual bool ContainsSubscription(object subscriber, string handlerMethodName)
		{
			Guard.ArgumentNotNull(subscriber, "subscriber");
			Guard.ArgumentNotNull(handlerMethodName, "handlerMethodName");
			Clean();
			return FindSubscription(subscriber, handlerMethodName) != null;
		}

		/// <summary>
		/// Gets the count of registered subscriptions to this <see cref="EventTopic"/>.
		/// </summary>
		public virtual int SubscriptionCount
		{
			get
			{
				Clean();
				int count = 0;

				foreach (WorkItemSubscriptions wis in workItemSubscriptions)
					count += wis.SubscriptionCount;

				return count;
			}
		}

		/// <summary>
		/// Perform a sanity cleaning of the dead references to publishers and subscribers
		/// </summary>
		/// <devdoc>As the topic maintains <see cref="WeakReference"/> to publishers and subscribers,
		/// those instances that are finished but hadn't been removed from the topic will leak. This method
		/// deals with that case.</devdoc>
        private void Clean()
        {
            foreach (WorkItemSubscriptions wis in workItemSubscriptions.ToArray())
            {
                wis.Clean();
                if (wis.SubscriptionCount == 0)
                {
                    workItemSubscriptions.Remove(wis);
                }
            }

            foreach (Publication publication in publications.ToArray())
            {
                if (publication.Publisher == null ||
                    publication.WorkItem == null ||
                    (publication.WorkItem != null && publication.WorkItem.Status == WorkItemStatus.Terminated))
                {
                    publications.Remove(publication);
                    publication.Dispose();
                }
            }
        }

		/// <summary>
		/// Called to free resources.
		/// </summary>
		public void Dispose()
		{
			Dispose(true);
			GC.SuppressFinalize(this);
		}

		/// <summary>
		/// Called to free resources.
		/// </summary>
		/// <param name="disposing">Should be true when calling from Dispose().</param>
		protected virtual void Dispose(bool disposing)
		{
			if (disposing)
			{
				foreach (Publication publication in publications)
				{
					publication.Dispose();
				}
				publications.Clear();
				workItemSubscriptions.Clear();
			}
		}

		private void CallSubscriptionHandlers(object sender, EventArgs e, EventTopicFireDelegate[] handlers)
		{
			List<Exception> exceptions = new List<Exception>();

			foreach (EventTopicFireDelegate handler in handlers)
			{
				handler(sender, e, exceptions, traceSource);
			}

			if (exceptions.Count > 0)
			{
				TraceExceptions(exceptions);
				throw new EventTopicException(this, new ReadOnlyCollection<Exception>(exceptions));
			}
		}

		private void TraceExceptions(List<Exception> exceptions)
		{
			if (traceSource != null)
			{
				traceSource.TraceInformation(Properties.Resources.EventTopicTraceFireExceptions, name);

				foreach (Exception ex in exceptions)
					traceSource.TraceInformation(ex.ToString());
			}
		}

		private EventTopicFireDelegate[] GetDescendantsHandlers(WorkItem workItem)
		{
			List<WorkItem> descendants = new List<WorkItem>();
			List<EventTopicFireDelegate> handlers = new List<EventTopicFireDelegate>();
			descendants.Add(workItem);
			for (int i = 0; i < descendants.Count; i++)
			{
				handlers.AddRange(GetWorkItemHandlers(descendants[i]));
				foreach (KeyValuePair<string, WorkItem> pair in descendants[i].WorkItems)
				{
					descendants.Add(pair.Value);
				}
			}
			return handlers.ToArray();
		}

		private EventTopicFireDelegate[] GetWorkItemHandlers(WorkItem workItem)
		{
			WorkItemSubscriptions wis = FindWorkItemSubscription(workItem);
			if (wis != null)
			{
				return wis.GetHandlers();
			}
			return new EventTopicFireDelegate[0];
		}

		private EventTopicFireDelegate[] GetAllHandlers()
		{
			List<EventTopicFireDelegate> handlers = new List<EventTopicFireDelegate>();

			foreach (WorkItemSubscriptions wis in workItemSubscriptions)
			{
				handlers.AddRange(wis.GetHandlers());
			}
			return handlers.ToArray();
		}

		internal void Fire(Publication publication, object sender, EventArgs e)
		{
			WorkItem workItem = publication.WorkItem;
			if (workItem == null || (workItem != null && workItem.Status == WorkItemStatus.Terminated))
			{
				publications.Remove(publication);
				publication.Dispose();
			}
			else
			{
				Fire(sender, e, publication.WorkItem, publication.Scope);
			}
		}


		private void ThrowIfRepeatedPublication(object publisher, string eventName)
		{
			if (FindPublication(publisher, eventName) != null)
			{
				throw new EventBrokerException(Properties.Resources.OnlyOnePublicationIsAllowed);
			}
		}

		private Publication FindPublication(object publisher, string eventName)
		{
			Publication publication = publications.Find(delegate(Publication match)
			{
				return match.Publisher == publisher && match.EventName == eventName;
			});
			return publication;
		}


		private WorkItemSubscriptions FindWorkItemSubscription(WorkItem workItem)
		{
			return workItemSubscriptions.Find(delegate(WorkItemSubscriptions match)
			{
				return match.WorkItem == workItem;
			});
		}

		private Subscription FindSubscription(object subscriber, string handlerMethodName)
		{
			foreach (WorkItemSubscriptions wis in workItemSubscriptions)
			{
				Subscription subscription = wis.FindSubscription(subscriber, handlerMethodName);
				if (subscription != null)
				{
					return subscription;
				}
			}
			return null;
		}

		class ClassNameTraceSourceAttribute : TraceSourceAttribute
		{
			public ClassNameTraceSourceAttribute() : base(typeof(EventTopic).FullName) { }
		}

		/// <summary>
		/// See <see cref="IBuilderAware.OnBuiltUp"/> for more information.
		/// </summary>
		public virtual void OnBuiltUp(string id)
		{
			this.name = id;
		}

		/// <summary>
		/// See <see cref="IBuilderAware.OnTearingDown"/> for more information.
		/// </summary>
		public virtual void OnTearingDown()
		{
		}
	}
}
