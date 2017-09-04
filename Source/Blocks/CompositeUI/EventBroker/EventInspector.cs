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
using System.Reflection;
using Microsoft.Practices.CompositeUI.Utility;

namespace Microsoft.Practices.CompositeUI.EventBroker
{
	/// <summary>
	/// Inspects objects for event publications and subscriptions,
	/// registering and unregistering the publishers and subscribers with the corresponding <see cref="EventTopic"/>.
	/// </summary>
	public static class EventInspector
	{
		/// <summary>
		/// Processes an object by scanning its members and registering publications 
		/// and subscriptions.
		/// </summary>
		/// <param name="item">The object to scan.</param>
		/// <param name="workItem">The <see cref="WorkItem"/> where the object is.</param>
		public static void Register(object item, WorkItem workItem)
		{
			Guard.ArgumentNotNull(item, "item");
			Guard.ArgumentNotNull(workItem, "workItem");

			ProcessPublishers(item, item.GetType(), workItem, true);
			ProcessSubscribers(item, item.GetType(), workItem, true);
		}

		/// <summary>
		/// Processes an object by scanning its members and unregistering publications 
		/// and subscriptions.
		/// </summary>
		/// <param name="item">The object to scan.</param>
		/// <param name="workItem">The <see cref="WorkItem"/> where the object is.</param>
		public static void Unregister(object item, WorkItem workItem)
		{
			Guard.ArgumentNotNull(item, "item");
			Guard.ArgumentNotNull(workItem, "workItem");

			ProcessPublishers(item, item.GetType(), workItem, false);
			ProcessSubscribers(item, item.GetType(), workItem, false);
		}

		private static void ProcessPublishers(object item, Type itemType, WorkItem workItem, bool register)
		{
			foreach (EventInfo info in itemType.GetEvents())
			{
				foreach (EventPublicationAttribute attr in info.GetCustomAttributes(typeof(EventPublicationAttribute), true))
				{
					HandlePublisher(item, register, info, attr, workItem);
				}
			}
		}

		private static void HandlePublisher(object item, bool register, EventInfo info,
											EventPublicationAttribute attr, WorkItem workItem)
		{
			EventTopic topic = workItem.EventTopics[attr.Topic];
			if (register)
			{
				topic.AddPublication(item, info.Name, workItem, attr.Scope);
			}
			else
			{
				topic.RemovePublication(item, info.Name);
			}
		}

		private static void ProcessSubscribers(object item, Type itemType, WorkItem workItem, bool register)
		{
			foreach (MethodInfo info in itemType.GetMethods())
			{
				foreach (EventSubscriptionAttribute attr in info.GetCustomAttributes(typeof(EventSubscriptionAttribute), true))
				{
					HandleSubscriber(item, register, info, attr, workItem);
				}
			}
		}

		private static void HandleSubscriber(object item, bool register, MethodInfo info,
														 EventSubscriptionAttribute attr, WorkItem workItem)
		{
			EventTopic topic = workItem.EventTopics[attr.Topic];
			if (register == true)
			{
				Type[] paramTypes = GetParamTypes(info);

				topic.AddSubscription(item, info.Name, paramTypes, workItem, attr.Thread);
			}
			else
			{
				topic.RemoveSubscription(item, info.Name);
			}
		}

		private static Type[] GetParamTypes(MethodInfo info)
		{
			ParameterInfo[] paramInfos = info.GetParameters();
			Type[] paramTypes = new Type[paramInfos.Length];
			for (int i = 0; i < paramTypes.Length; i++)
			{
				paramTypes[i] = paramInfos[i].ParameterType;
			}
			return paramTypes;
		}
	}
}