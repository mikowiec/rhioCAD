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
using Microsoft.Practices.CompositeUI.Services;
using Microsoft.Practices.CompositeUI.Utility;

namespace Microsoft.Practices.CompositeUI
{
	/// <summary>
	/// Indicates that a class extends <see cref="WorkItem"/> classes. The class
	/// must implement <see cref="IWorkItemExtension"/>.
	/// </summary>
	[AttributeUsage(AttributeTargets.Class, AllowMultiple=true, Inherited=true)]
	public class WorkItemExtensionAttribute : Attribute
	{
		private Type workItemType;

		/// <summary>
		/// Initializes the attribute with the type of the work item to extend.
		/// </summary>
		public WorkItemExtensionAttribute(Type workItemType)
		{
			Guard.ArgumentNotNull(workItemType, "workItemType");

			this.workItemType = workItemType;
		}

		/// <summary>
		/// The type of the <see cref="WorkItem"/> to extend.
		/// </summary>
		public Type WorkItemType
		{
			get { return workItemType; }
		}
	}
}
