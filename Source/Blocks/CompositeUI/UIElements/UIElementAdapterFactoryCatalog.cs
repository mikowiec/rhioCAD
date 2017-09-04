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
using System.Text;
using Microsoft.Practices.CompositeUI.Utility;
using System.Globalization;

namespace Microsoft.Practices.CompositeUI.UIElements
{
	/// <summary>
	/// Catalog that keeps track of each <see cref="IUIElementAdapterFactory"/> that is available.
	/// </summary>
	public class UIElementAdapterFactoryCatalog : IUIElementAdapterFactoryCatalog
	{
		private List<IUIElementAdapterFactory> factories = new List<IUIElementAdapterFactory>();

		/// <summary>
		/// Gets the list that includes each registered <see cref="IUIElementAdapterFactory"/> in the catalog.
		/// </summary>
		public IList<IUIElementAdapterFactory> Factories
		{
			get { return factories.AsReadOnly(); }
		}

		/// <summary>
		/// Adds a <see cref="IUIElementAdapterFactory"/> to the catalog.
		/// </summary>
		/// <param name="adapterFactory">The factory to add.</param>
		public void RegisterFactory(IUIElementAdapterFactory adapterFactory)
		{
			Guard.ArgumentNotNull(adapterFactory, "adapterFactory");

			factories.Add(adapterFactory);
		}

		/// <summary>
		/// Retrieves a <see cref="IUIElementAdapterFactory"/> for the given UI Element.
		/// </summary>
		/// <param name="element">The UI Element a factory is to be retrieved for.</param>
		/// <returns>The factory for the UI Element.</returns>
		public IUIElementAdapterFactory GetFactory(object element)
		{
			foreach (IUIElementAdapterFactory factory in factories)
			{
				if (factory.Supports(element))
					return factory;
			}

			throw new ArgumentException(String.Format(CultureInfo.CurrentCulture,
									Properties.Resources.NoRegisteredUIElementFactory,
									element.GetType().ToString()));
		}
	}
}
