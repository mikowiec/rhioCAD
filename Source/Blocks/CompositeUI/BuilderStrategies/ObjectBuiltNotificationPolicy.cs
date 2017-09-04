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
using Microsoft.Practices.ObjectBuilder;

namespace Microsoft.Practices.CompositeUI.BuilderStrategies
{
	/// <summary>
	/// 
	/// </summary>
	public class ObjectBuiltNotificationPolicy : IBuilderPolicy
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="item"></param>
		public delegate void ItemNotification(object item);

		/// <summary>
		/// 
		/// </summary>
		public Dictionary<WorkItem, ItemNotification> AddedDelegates = new Dictionary<WorkItem, ItemNotification>();

		/// <summary>
		/// 
		/// </summary>
		public Dictionary<WorkItem, ItemNotification> RemovedDelegates = new Dictionary<WorkItem, ItemNotification>();
	}
}
