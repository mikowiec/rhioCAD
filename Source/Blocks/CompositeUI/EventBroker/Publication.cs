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
using System.Globalization;

namespace Microsoft.Practices.CompositeUI.EventBroker
{
	/// <summary>
	/// Represents a publication for a topic and handles the publication event.
	/// </summary>
	internal class Publication : IDisposable
	{
		private EventTopic topic;
		private WeakReference wrPublisher;
		private WeakReference wrWorkItem;
		private PublicationScope scope;
		private string eventName;

		/// <summary>
		/// Initializes a new instance of the <see cref="Publication"/> class
		/// </summary>
		public Publication(EventTopic topic, object publisher, string eventName, WorkItem workItem, PublicationScope scope)
		{
			this.topic = topic;
			this.wrPublisher = new WeakReference(publisher);
			this.scope = scope;
			this.eventName = eventName;
			this.wrWorkItem = new WeakReference(workItem);

			EventInfo publishedEvent =
				publisher.GetType().GetEvent(eventName, BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static);

			if (publishedEvent == null)
			{
				throw new EventBrokerException(String.Format(CultureInfo.CurrentCulture,
					Properties.Resources.CannotFindPublishedEvent, eventName));
			}

			ThrowIfInvalidEventHandler(publishedEvent);
			ThrowIfEventIsStatic(publishedEvent);

			Delegate handler = Delegate.CreateDelegate(publishedEvent.EventHandlerType, this, this.GetType().GetMethod("PublicationHandler"));
			publishedEvent.AddEventHandler(publisher, handler);
		}

		private void ThrowIfEventIsStatic(EventInfo publishedEvent)
		{
			if (publishedEvent.GetAddMethod().IsStatic || publishedEvent.GetRemoveMethod().IsStatic)
			{
				throw new EventBrokerException(String.Format(CultureInfo.CurrentCulture,
					Properties.Resources.StaticPublisherNotAllowed, EventName));
			}
		}

		private void ThrowIfInvalidEventHandler(EventInfo info)
		{
			if (typeof(EventHandler).IsAssignableFrom(info.EventHandlerType) ||
				(info.EventHandlerType.IsGenericType &&
				typeof(EventHandler<>).IsAssignableFrom(info.EventHandlerType.GetGenericTypeDefinition())))
			{
				return;
			}

			throw new EventBrokerException(String.Format(CultureInfo.CurrentCulture,
				Properties.Resources.InvalidPublicationSignature,
				info.DeclaringType.FullName, info.Name));
		}

		/// <summary>
		/// Fires the event publication.
		/// </summary>
		public void PublicationHandler(object sender, EventArgs e)
		{
			topic.Fire(this, sender, e);
		}

		/// <summary>
		/// The publisher of the event.
		/// </summary>
		public object Publisher
		{
			get { return wrPublisher.Target; }
		}

		/// <summary>
		/// The <see cref="WorkItem"/> this Publication lives in.
		/// </summary>
		public WorkItem WorkItem
		{
			get { return (WorkItem)wrWorkItem.Target; }
		}

		/// <summary>
		/// The name of the event on the <see cref="Publication.Publisher"/>.
		/// </summary>
		public string EventName
		{
			get { return eventName; }
		}

		/// <summary>
		/// The <see cref="PublicationScope"/> of the event.
		/// </summary>
		public PublicationScope Scope
		{
			get { return scope; }
		}

		/// <summary>
		/// See <see cref="IDisposable.Dispose"/> for more information.
		/// </summary>
		public void Dispose()
		{
			Dispose(true);
			GC.SuppressFinalize(this);
		}

		/// <summary>
		/// Implementation of the disposable pattern.
		/// </summary>
		protected virtual void Dispose(bool disposing)
		{
			if (disposing)
			{
				object publisher = Publisher;
				if (publisher != null)
				{
					EventInfo publishedEvent = publisher.GetType().GetEvent(eventName);
					publishedEvent.RemoveEventHandler(publisher,
						Delegate.CreateDelegate(publishedEvent.EventHandlerType, this, this.GetType().GetMethod("PublicationHandler")));
				}
			}
		}
	}
}
