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

using Microsoft.Practices.CompositeUI.Configuration;

namespace Microsoft.Practices.CompositeUI.Services
{
	/// <summary>
	/// Defines a class that can process module information to enumerate a list of modules.
	/// </summary>
	public interface IModuleEnumerator
	{
		/// <summary>
		/// Gets an array of <see cref="IModuleInfo"/> enumerated from the source the
		/// enumerator is processing.
		/// </summary>
		/// <returns>An array of <see cref="IModuleInfo"/> instances.</returns>
		IModuleInfo[] EnumerateModules();
	}
}