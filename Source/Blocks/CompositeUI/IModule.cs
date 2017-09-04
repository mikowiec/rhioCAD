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

namespace Microsoft.Practices.CompositeUI
{
	/// <summary>
	/// Defines a set of methods to be implemented by modules deployed in the application.
	/// </summary>
	public interface IModule
	{
		/// <summary>
		/// Allows the module to add services to the root <see cref="WorkItem"/> on startup.
		/// </summary>
		void AddServices();

		/// <summary>
		/// Allows the module to be notified that it has been loaded.
		/// </summary>
		void Load();
	}
}