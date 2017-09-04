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

using System.Collections.Generic;

namespace Microsoft.Practices.CompositeUI.Configuration
{
	/// <summary>
	/// Exposes metadata describing a module.
	/// </summary>
	public interface IModuleInfo
	{
		/// <summary>
		/// Gets the assembly file path to the module.
		/// </summary>
		string AssemblyFile { get; }

		/// <summary>
		/// Gets the update location string for the module.
		/// </summary>
		string UpdateLocation { get; }

		/// <summary>
		/// Gets a list of required roles to use the module.
		/// </summary>
		IList<string> AllowedRoles { get; }
	}
}