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
using System.Collections.Generic;

namespace Microsoft.Practices.CompositeUI.UIElements
{
	/// <summary>
	/// Catalog that keeps track of what factories are available.
	/// </summary>
	public interface IUIElementAdapterFactoryCatalog
	{
		/// <summary>
		/// Dictionary of the availble factories.
		/// </summary>
		IList<IUIElementAdapterFactory> Factories { get; }
		
		/// <summary>
		/// Retrieves a factory for the given UI element.
		/// </summary>
		/// <param name="element">The UI element to lookup a factory for.</param>
		/// <returns>A factory to use to create <see cref="IUIElementAdapter"/> for the UI element.</returns>
		IUIElementAdapterFactory GetFactory(object element);
		
		/// <summary>
		/// Adds an entry in the factories dictionary.
		/// </summary>
		/// <param name="factory">The factory to register with the catalog.</param>
		void RegisterFactory(IUIElementAdapterFactory factory);
	}
}
