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
using Microsoft.Practices.CompositeUI.EventBroker;
using Microsoft.Practices.ObjectBuilder;

namespace Microsoft.Practices.CompositeUI.BuilderStrategies
{
	/// <summary>
	/// A <see cref="BuilderStrategy"/>processes <see cref="EventTopic"/> publications and subscriptions
	/// declared in a component inspecting the <see cref="EventPublicationAttribute"/> and 
	/// <see cref="EventSubscriptionAttribute"/> attributes.
	/// </summary>
	public class EventBrokerStrategy : BuilderStrategy
	{
		/// <summary>
		/// Forwards the <see cref="EventTopic"/> related attributes processing to the <see cref="EventInspector"/>
		/// for registering publishers and/or subscribers.
		/// </summary>
		public override object BuildUp(IBuilderContext context, Type t, object existing, string id)
		{
			WorkItem workItem = GetWorkItem(context, existing);

			if (workItem != null)
				EventInspector.Register(existing, workItem);

			return base.BuildUp(context, t, existing, id);
		}

		/// <summary>
		/// Forwards the <see cref="EventTopic"/> related attributes processing to the <see cref="EventInspector"/>
		/// for unregistering publishers and/or subscribers.
		/// </summary>
		public override object TearDown(IBuilderContext context, object item)
		{
			WorkItem workItem = GetWorkItem(context, item);

			if (workItem != null)
				EventInspector.Unregister(item, workItem);

			return base.TearDown(context, item);
		}

		private static WorkItem GetWorkItem(IBuilderContext context, object item)
		{
			if (item is WorkItem)
				return item as WorkItem;

			return context.Locator.Get<WorkItem>(new DependencyResolutionLocatorKey(typeof(WorkItem), null));
		}
	}
}