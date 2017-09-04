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
using Microsoft.Practices.CompositeUI.Utility;
using System.Collections.Generic;

namespace Microsoft.Practices.CompositeUI.Services
{
	/// <summary>
	/// Keeps a catlog of <see cref="WorkItem"/>s that are registered at module initialization time.
	/// </summary>
	public class WorkItemTypeCatalogService : IWorkItemTypeCatalogService
	{
		private Set<Type> registeredTypes = new Set<Type>();

		/// <summary>
		/// See <see cref="IWorkItemTypeCatalogService.RegisteredWorkItemTypes"/> for more information.
		/// </summary>
		public ICollection<Type> RegisteredWorkItemTypes
		{
			get { return registeredTypes.AsReadOnly(); }
		}

		/// <summary>
		/// See <see cref="IWorkItemTypeCatalogService.CreateEachWorkItem{TWorkItem}"/> for more information.
		/// </summary>
		public void CreateEachWorkItem<TWorkItem>(WorkItem parentWorkItem, Action<TWorkItem> action)
		{
			Guard.ArgumentNotNull(parentWorkItem, "parentWorkItem");
			Guard.ArgumentNotNull(action, "action");

			foreach (Type type in registeredTypes)
				if (typeof(TWorkItem).IsAssignableFrom(type))
					action((TWorkItem)parentWorkItem.Items.AddNew(type));
		}

		/// <summary>
		/// See <see cref="IWorkItemTypeCatalogService.CreateEachWorkItem"/> for more information.
		/// </summary>
		public void CreateEachWorkItem(Type workItemType, WorkItem parentWorkItem, Action<WorkItem> action)
		{
			Guard.ArgumentNotNull(parentWorkItem, "parentWorkItem");
			Guard.ArgumentNotNull(action, "action");

			foreach (Type type in registeredTypes)
				if (workItemType.IsAssignableFrom(type))
					action((WorkItem)parentWorkItem.Items.AddNew(type));
		}

		/// <summary>
		/// See <see cref="IWorkItemTypeCatalogService.RegisterWorkItem{TWorkItem}"/> for more information.
		/// </summary>
		public void RegisterWorkItem<TWorkItem>()
			where TWorkItem : WorkItem
		{
			RegisterWorkItem(typeof(TWorkItem));
		}

		/// <summary>
		/// See <see cref="IWorkItemTypeCatalogService.RegisterWorkItem"/> for more information.
		/// </summary>
		public void RegisterWorkItem(Type workItemType)
		{
			Guard.TypeIsAssignableFromType(workItemType, typeof(WorkItem), "workItemType");

			registeredTypes.Add(workItemType);
		}
	}
}
