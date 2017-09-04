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
using System.ComponentModel;
using System.Globalization;
using Microsoft.Practices.CompositeUI.Properties;
using Microsoft.Practices.CompositeUI.Utility;
using System.Collections.Generic;
using System.Diagnostics;
using Microsoft.Practices.ObjectBuilder;

namespace Microsoft.Practices.CompositeUI.Services
{
	/// <summary>
	/// Default implementation of the <see cref="IWorkItemExtensionService"/>.
	/// </summary>
	public class WorkItemExtensionService : IWorkItemExtensionService
	{
		ListDictionary<Type, Type> extensions = new ListDictionary<Type, Type>();
		List<Type> rootExtensions = new List<Type>();
		TraceSource traceSource;

		/// <summary>
		/// Initializes a new instance of <see cref="WorkItemExtensionService"/>.
		/// </summary>
		public WorkItemExtensionService()
			: this(null)
		{
		}

		/// <summary>
		/// Initializes a new instance of <see cref="WorkItemExtensionService"/> with the given <see cref="TraceSource"/>.
		/// </summary>
		[InjectionConstructor]
		public WorkItemExtensionService([ClassNameTraceSource] TraceSource traceSource)
		{
			this.traceSource = traceSource;
		}

		/// <summary>
		/// See <see cref="IWorkItemExtensionService.RegisteredExtensions"/> for more information.
		/// </summary>
		public ReadOnlyDictionary<Type, IList<Type>> RegisteredExtensions
		{
			get
			{
				Dictionary<Type, IList<Type>> results = new Dictionary<Type, IList<Type>>();

				foreach (KeyValuePair<Type, List<Type>> pair in extensions)
					results[pair.Key] = pair.Value.AsReadOnly();

				return new ReadOnlyDictionary<Type, IList<Type>>(results);
			}
		}

		/// <summary>
		/// See <see cref="IWorkItemExtensionService.RegisteredRootExtensions"/> for more information.
		/// </summary>
		public IList<Type> RegisteredRootExtensions
		{
			get { return rootExtensions.AsReadOnly(); }
		}

		/// <summary>
		/// See <see cref="IWorkItemExtensionService.RegisterExtension"/> for more information.
		/// </summary>
		public void RegisterExtension(Type workItemType, Type extensionType)
		{
			Guard.ArgumentNotNull(workItemType, "workItemType");
			Guard.ArgumentNotNull(extensionType, "extensionType");
			Guard.TypeIsAssignableFromType(workItemType, typeof(WorkItem), "workItemType");
			Guard.TypeIsAssignableFromType(extensionType, typeof(IWorkItemExtension), "extensionType");
			ThrowIfAlreadyAdded(workItemType, extensionType);

			extensions.Add(workItemType, extensionType);

			if (traceSource != null)
				traceSource.TraceInformation(String.Format(
					CultureInfo.CurrentCulture,
					Properties.Resources.WorkItemExtensionRegistered,
					extensionType, workItemType));
		}

		private void ThrowIfAlreadyAdded(Type workItemType, Type extensionType)
		{
			if (extensions.ContainsKey(workItemType) && extensions[workItemType].Contains(extensionType))
			{
				throw new ArgumentException(
					string.Format(CultureInfo.CurrentCulture,
					Properties.Resources.WorkItemExtensionTypeAlreadyRegistered,
					extensionType.ToString(), workItemType.ToString()));
			}
		}

		/// <summary>
		/// See <see cref="IWorkItemExtensionService.RegisterRootExtension"/> for more information.
		/// </summary>
		public void RegisterRootExtension(Type extensionType)
		{
			Guard.ArgumentNotNull(extensionType, "extensionType");
			Guard.TypeIsAssignableFromType(extensionType, typeof(IWorkItemExtension), "extensionType");

			rootExtensions.Add(extensionType);

			if (traceSource != null)
				traceSource.TraceInformation(String.Format(
					CultureInfo.CurrentCulture,
					Properties.Resources.WorkItemExtensionRootRegistered,
					extensionType));
		}

		/// <summary>
		/// Creates and initializes the extensions for the given workItem.
		/// </summary>
		/// <param name="workItem">The <see cref="WorkItem"/> to add the extensions to and initialize 
		/// the extensions for.</param>
		public void InitializeExtensions(WorkItem workItem)
		{
			Guard.ArgumentNotNull(workItem, "workItem");

			InnerInitialize(workItem, GetRegisteredExtensions(workItem.GetType()));

			if (workItem.Parent == null)
				InnerInitialize(workItem, rootExtensions);
		}

		private void InnerInitialize(WorkItem workItem, IEnumerable<Type> extensions)
		{
			foreach (Type extensionType in extensions)
			{
				IWorkItemExtension extension = (IWorkItemExtension)workItem.Items.AddNew(extensionType);
				extension.Initialize(workItem);

				if (traceSource != null)
					traceSource.TraceInformation(String.Format(
						CultureInfo.CurrentCulture,
						Properties.Resources.WorkItemExtensionInitialized,
						extension, workItem));
			}
		}

		private IEnumerable<Type> GetRegisteredExtensions(Type workItemType)
		{
			return extensions.FindAllValuesByKey(
				delegate(Type key)
				{
					return key.IsAssignableFrom(workItemType);
				});
		}

		private class ClassNameTraceSourceAttribute : TraceSourceAttribute
		{
			public ClassNameTraceSourceAttribute()
				: base(typeof(WorkItemExtensionService).FullName)
			{
			}
		}
	}
}
