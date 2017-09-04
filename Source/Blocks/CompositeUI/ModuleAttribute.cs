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
	/// Indicates that the assembly should be considered a named module using the
	/// provided name.
	/// </summary>
	[AttributeUsage(AttributeTargets.Assembly, AllowMultiple = false)]
	public sealed class ModuleAttribute : Attribute
	{
		private string name;

		/// <summary>
		/// Creates a new instance of the <see cref="ModuleAttribute"/> class using the
		/// provided module name.
		/// </summary>
		/// <param name="name">The name of the module.</param>
		public ModuleAttribute(string name)
		{
			this.name = name;
		}

		/// <summary>
		/// The name of the module.
		/// </summary>
		public string Name
		{
			get { return name; }
		}
	}
}