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
using System.Reflection;

namespace Microsoft.Practices.CompositeUI.Services
{
	/// <summary>
	/// Represents the information about a loaded module
	/// </summary>
	public class LoadedModuleInfo
	{
		private Assembly assembly;
		private List<string> dependencies;
		private string name;
		private List<string> roles;

		/// <summary>
		/// Initializes a new instance of the <see cref="LoadedModuleInfo"/> class with the given
		/// assembly, name, roles and dependencies.
		/// </summary>
		public LoadedModuleInfo(Assembly assembly, string name, IEnumerable<string> roles, IEnumerable<string> dependencies)
		{
			this.assembly = assembly;
			this.name = name;

			this.roles = new List<string>();
			if (roles != null)
				this.roles.AddRange(roles);

			this.dependencies = new List<string>();
			if (dependencies != null)
				this.dependencies.AddRange(dependencies);
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="LoadedModuleInfo"/> class, copying the existing object.
		/// </summary>
		public LoadedModuleInfo(LoadedModuleInfo toCopy)
		{
			this.assembly = toCopy.assembly;
			this.name = toCopy.name;
			this.roles = new List<string>(toCopy.roles);
			this.dependencies = new List<string>(toCopy.dependencies);
		}

		/// <summary>
		/// The assembly the module was loaded from.
		/// </summary>
		public Assembly Assembly
		{
			get { return assembly; }
		}

		/// <summary>
		/// The name of the assembly, if provided.
		/// </summary>
		public string Name
		{
			get { return name; }
		}

		/// <summary>
		/// The dependencies this module has, if any.
		/// </summary>
		public IList<string> Dependencies
		{
			get { return dependencies.AsReadOnly(); }
		}

		/// <summary>
		/// The allowed roles this module has, if any. If empty, then all roles are allowed.
		/// </summary>
		public IList<string> Roles
		{
			get { return roles.AsReadOnly(); }
		}
	}
}
