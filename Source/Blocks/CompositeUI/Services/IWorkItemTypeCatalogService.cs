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

namespace Microsoft.Practices.CompositeUI.Services
{
	/// <summary>
	/// The implemented service should register <see cref="WorkItem"/> types
	/// and create <see cref="WorkItem"/>s.
	/// </summary>
	public interface IWorkItemTypeCatalogService
	{
		/// <summary>
		/// Returns the list of registered <see cref="WorkItem"/> types.
		/// </summary>
		ICollection<Type> RegisteredWorkItemTypes { get; }

		/// <summary>
		/// Creates <see cref="WorkItem"/>s for the registered types that match the provided type.
		/// </summary>
		/// <typeparam name="TWorkItem">The type of <see cref="WorkItem"/>s to create.</typeparam>
		/// <param name="parentWorkItem">The parent <see cref="WorkItem"/> to create them in.</param>
		/// <param name="action">A callback for each created <see cref="WorkItem"/>.</param>
		void CreateEachWorkItem<TWorkItem>(WorkItem parentWorkItem, Action<TWorkItem> action);

		/// <summary>
		/// Creates <see cref="WorkItem"/>s for the registered types that match the provided type.
		/// </summary>
		/// <param name="workItemType">The type of <see cref="WorkItem"/>s to create.</param>
		/// <param name="parentWorkItem">The parent <see cref="WorkItem"/> to create them in.</param>
		/// <param name="action">A callback for each created <see cref="WorkItem"/>.</param>
		void CreateEachWorkItem(Type workItemType, WorkItem parentWorkItem, Action<WorkItem> action);

		/// <summary>
		/// Registers a <see cref="WorkItem"/> type with the catalog.
		/// </summary>
		/// <typeparam name="TWorkItem">The type of WorkItem to be registered.</typeparam>
		void RegisterWorkItem<TWorkItem>()
			where TWorkItem : WorkItem;

		/// <summary>
		/// Registers a <see cref="WorkItem"/> type with the catalog.
		/// </summary>
		/// <param name="workItemType">The type of WorkItem to be registered.</param>
		void RegisterWorkItem(Type workItemType);
	}
}