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
using System.Collections;

namespace Microsoft.Practices.CompositeUI.EventBroker
{
	/// <summary>
	/// Maintains the subscriptions registered from a <see cref="WorkItem"/>
	/// </summary>
	internal class WorkItemSubscriptions : IEnumerable<Subscription>
	{
		private WeakReference wrWorkItem;
		private List<Subscription> subscriptions = new List<Subscription>();
		private object lockObject = new object();

		public WorkItemSubscriptions(WorkItem workItem)
		{
			this.wrWorkItem = new WeakReference(workItem);
		}

		public void AddSubscription(object subscriber, string handlerMethodName, ThreadOption threadOption)
		{
			AddSubscription(subscriber, handlerMethodName, null, threadOption);
		}

		public void AddSubscription(object subscriber, string handlerMethodName, Type[] parameterTypes, ThreadOption threadOption)
		{
			lock (lockObject)
			{
				if (FindSubscription(subscriber, handlerMethodName) == null)
				{
					subscriptions.Add(new Subscription(this, subscriber, handlerMethodName, parameterTypes, threadOption));
				}
			}
		}

		public void RemoveSubscription(object subscriber, string handlerMethodName)
		{
			lock (lockObject)
			{
				Subscription subscription = FindSubscription(subscriber, handlerMethodName);
				if (subscription != null)
				{
					RemoveSubscription(subscription);
				}
			}
		}

		public void RemoveSubscription(Subscription subscription)
		{
			lock (lockObject)
			{
				subscriptions.Remove(subscription);
			}
		}

		public WorkItem WorkItem
		{
			get { return (WorkItem)wrWorkItem.Target; }
		}

		public EventTopicFireDelegate[] GetHandlers()
		{
			List<EventTopicFireDelegate> result = new List<EventTopicFireDelegate>();

			lock (lockObject)
			{
				foreach (Subscription subscription in subscriptions.ToArray())
				{
					EventTopicFireDelegate handler = subscription.GetHandler();
					if (handler != null)
					{
						result.Add(handler);
					}
				}
				return result.ToArray();
			}
		}

		public int SubscriptionCount
		{
			get { return subscriptions.Count; }
		}

		public Subscription FindSubscription(object subscriber, string handlerMethodName)
		{
			lock (lockObject)
			{
				Clean();

				return subscriptions.Find(delegate(Subscription match)
				{
					return match.Subscriber == subscriber && match.HandlerMethodName == handlerMethodName;
				});
			}
		}

        public void Clean()
        {
            lock (lockObject)
            {
                if (WorkItem == null || (WorkItem != null && WorkItem.Status == WorkItemStatus.Terminated))
                {
                    subscriptions.Clear();
                }
                else
                {
                    foreach (Subscription subscription in subscriptions.ToArray())
                    {
                        if (subscription.Subscriber == null)
                        {
                            RemoveSubscription(subscription);
                        }
                    }
                }
            }
        }

		public IEnumerator<Subscription> GetEnumerator()
		{
			return subscriptions.GetEnumerator();
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}
	}
}
