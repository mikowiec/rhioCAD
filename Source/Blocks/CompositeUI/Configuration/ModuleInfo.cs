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
using Microsoft.Practices.CompositeUI.Utility;

namespace Microsoft.Practices.CompositeUI.Configuration
{
	/// <summary>
	/// This is the default implementation of <see cref="IModuleInfo"/>.
	/// </summary>
	public class ModuleInfo : IModuleInfo
	{
		private string assemblyFile;
		private string updateLocation;
		private List<string> allowedRoles = new List<string>();

		/// <summary>
		/// Initializes an instance of the <see cref="ModuleInfo"/> class.
		/// </summary>
		public ModuleInfo()
		{
		}

		/// <summary>
		/// Initializes an instance of the <see cref="ModuleInfo"/> class.
		/// </summary>
		/// <param name="assemblyFile">The filename of an assembly.</param>
		public ModuleInfo(string assemblyFile)
		{
			Guard.ArgumentNotNullOrEmptyString(assemblyFile, "assemblyFile");

			this.assemblyFile = assemblyFile;
		}

		/// <summary>
		/// Initializes an instance of the <see cref="ModuleInfo"/> class.
		/// </summary>
		/// <param name="assembly">The assembly.</param>
		public ModuleInfo(Assembly assembly)
		{
			Guard.ArgumentNotNull(assembly, "assembly");

			this.assemblyFile = assembly.CodeBase.Replace("file:///", "").Replace('/', '\\');
		}

		/// <summary>
		/// Gets the assembly file path to the module.
		/// </summary>
		public string AssemblyFile
		{
			get { return assemblyFile; }
		}

		/// <summary>
		/// Sets the assembly file path to the module.
		/// </summary>
		public void SetAssemblyFile(string assemblyFile)
		{
			this.assemblyFile = assemblyFile;
		}

		/// <summary>
		/// Gets the update location for the module.
		/// </summary>
		public string UpdateLocation
		{
			get { return updateLocation; }
		}

		/// <summary>
		/// Sets the update location for the module.
		/// </summary>
		public void SetUpdateLocation(string updateLocation)
		{
			this.updateLocation = updateLocation;
		}

		/// <summary>
		/// Gets the list of required roles to use the module.
		/// </summary>
		public IList<string> AllowedRoles
		{
			get { return allowedRoles.AsReadOnly(); }
		}

		/// <summary>
		/// Adds roles to the allowed roles for the module.
		/// </summary>
		/// <param name="roles">A string list of roles to be added.</param>
		public void AddRoles(params string[] roles)
		{
			Guard.ArgumentNotNull(roles, "roles");

			foreach (string role in roles)
				if (role != null && role.Length > 0)
					allowedRoles.Add(role);
		}

		/// <summary>
		/// Clears the list of allowed roles.
		/// </summary>
		public void ClearRoles()
		{
			allowedRoles.Clear();
		}
	}
}