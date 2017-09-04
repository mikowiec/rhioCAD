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

namespace Microsoft.Practices.CompositeUI
{
	/// <summary>
	/// Indicates that this assembly has a dependency on another named module.
	/// The other named module will be loaded before this module. Can be used
	/// multiple times to indicate multiple dependencies.
	/// </summary>
	[AttributeUsage(AttributeTargets.Assembly, AllowMultiple=true)]
	public sealed class ModuleDependencyAttribute : Attribute
	{
		private string name;

		/// <summary>
		/// Creates a new instance of the <see cref="ModuleDependencyAttribute"/> class
		/// using the provided module name as a dependency.
		/// </summary>
		/// <param name="name">The name of the module which this module depends on.</param>
		public ModuleDependencyAttribute(string name)
		{
			this.name = name;
		}

		/// <summary>
		/// The name of the module which this module depends on.
		/// </summary>
		public string Name
		{
			get { return name; }
			set { name = value; }
		}
	}
}