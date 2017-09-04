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
using Microsoft.Practices.ObjectBuilder;

namespace Microsoft.Practices.CompositeUI
{
	/// <summary>
	/// Indicates that the property or constructor/method parameter is a reference
	/// to a component that lives in the parent <see cref="WorkItem"/>s
	/// <see cref="WorkItem.Items"/> collection.
	/// </summary>
	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Parameter)]
	public sealed class ComponentDependencyAttribute : OptionalDependencyAttribute
	{
		private bool createIfNotFound = false;
		private string id;
		private Type type;

		/// <summary>
		/// Initializes a new instance of <see cref="ComponentDependencyAttribute"/> using the
		/// given component ID.
		/// </summary>
		/// <param name="id">The ID of the component. May not be null.</param>
		public ComponentDependencyAttribute(string id)
		{
			Guard.ArgumentNotNull(id, "id");

			this.id = id;
		}

		/// <summary>
		/// The ID of the component to inject.
		/// </summary>
		public string ID
		{
			get { return id; }
		}

		/// <summary>
		/// Optional type of the component to create if not <see cref="CreateIfNotFound"/> is 
		/// true and the component cannot be located in the current container.
		/// </summary>
		public Type Type
		{
			get { return type; }
			set { type = value; }
		}

		/// <summary>
		/// Whether the component should be created automatically if it is not found in the
		/// <see cref="WorkItem"/>. Defaults to false.
		/// </summary>
		public bool CreateIfNotFound
		{
			get { return createIfNotFound; }
			set { createIfNotFound = value; }
		}

		/// <summary>
		/// See <see cref="ParameterAttribute.CreateParameter"/> for more information.
		/// </summary>
		public override IParameter CreateParameter(Type memberType)
		{
			return new DependencyParameter(type ?? memberType, id, null, GetNotPresentBehavior(), SearchMode.Local);
		}

		private NotPresentBehavior GetNotPresentBehavior()
		{
			if (createIfNotFound)
				return NotPresentBehavior.CreateNew;
			if (Required)
				return NotPresentBehavior.Throw;
			return NotPresentBehavior.ReturnNull;
		}
	}
}