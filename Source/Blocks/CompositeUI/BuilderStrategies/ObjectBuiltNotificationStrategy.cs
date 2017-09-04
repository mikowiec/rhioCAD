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
using Microsoft.Practices.ObjectBuilder;

namespace Microsoft.Practices.CompositeUI.BuilderStrategies
{
	/// <summary>
	/// An ObjectBuilder strategy which notifies CAB when an object is fully built so that the
	/// <see cref="WorkItem"/> can be notified.
	/// </summary>
	public class ObjectBuiltNotificationStrategy : BuilderStrategy
	{
		ObjectBuiltNotificationPolicy policy;

		/// <summary>
		/// See <see cref="IBuilderStrategy.BuildUp"/> for more information.
		/// </summary>
		public override object BuildUp(IBuilderContext context, Type typeToBuild, object existing, string idToBuild)
		{
			WorkItem workItem = context.Locator.Get<WorkItem>(new DependencyResolutionLocatorKey(typeof(WorkItem), null));
			ObjectBuiltNotificationPolicy.ItemNotification notification;

			if (policy == null)
				policy = context.Policies.Get<ObjectBuiltNotificationPolicy>(null, null);

			if (workItem != null && !Object.ReferenceEquals(workItem, existing) && policy.AddedDelegates.TryGetValue(workItem, out notification))
				notification(existing);

			return base.BuildUp(context, typeToBuild, existing, idToBuild);
		}

		/// <summary>
		/// See <see cref="IBuilderStrategy.TearDown"/> for more information.
		/// </summary>
		public override object TearDown(IBuilderContext context, object item)
		{
			WorkItem workItem = context.Locator.Get<WorkItem>(new DependencyResolutionLocatorKey(typeof(WorkItem), null));
			ObjectBuiltNotificationPolicy.ItemNotification notification;

			if (workItem != null && policy.RemovedDelegates.TryGetValue(workItem, out notification))
				notification(item);

			return base.TearDown(context, item);
		}
	}
}
