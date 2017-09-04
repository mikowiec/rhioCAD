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
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.CompositeUI.UIElements;

namespace Microsoft.Practices.CompositeUI
{
	/// <summary>
	/// Represents an extension site for UI elements.
	/// </summary>
	public class UIExtensionSite : IEnumerable<object>
	{
		IUIElementAdapter adapter;
		List<object> items = new List<object>();

		/// <summary>
		/// Initializes a new instance of the <see cref="UIExtensionSite"/> class with the provided
		/// adapter.
		/// </summary>
		public UIExtensionSite(IUIElementAdapter adapter)
		{
			this.adapter = adapter;
		}

		/// <summary>
		/// Returns the number of items added to the site.
		/// </summary>
		public int Count
		{
			get { return items.Count; }
		}

		/// <summary>
		/// Adds an element to the site.
		/// </summary>
		/// <typeparam name="TElement">The type of the element to be added.</typeparam>
		/// <param name="uiElement">The element to be added.</param>
		/// <returns>The added element. The adapter may return a different element than was
		/// passed; in this case, the returned element is the new element provided by the
		/// adapter.</returns>
		public TElement Add<TElement>(TElement uiElement)
		{
			TElement element = (TElement)adapter.Add(uiElement);
			items.Add(element);
			return element;
		}

		/// <summary>
		/// Removes all items from the site, and removes them from the UI.
		/// </summary>
		public void Clear()
		{
			foreach (object obj in items)
				adapter.Remove(obj);

			items.Clear();
		}

		/// <summary>
		/// Determines if the site contains a UI element.
		/// </summary>
		/// <param name="uiElement">The element to find.</param>
		/// <returns>true if the element is present; false otherwise.</returns>
		public bool Contains(object uiElement)
		{
			return items.Contains(uiElement);
		}

		/// <summary>
		/// Removes an item from the site, and removes it from the UI.
		/// </summary>
		/// <param name="uiElement">The element to be removed.</param>
		public void Remove(object uiElement)
		{
			if (items.Contains(uiElement))
			{
				adapter.Remove(uiElement);
				items.Remove(uiElement);
			}
		}

		internal UIExtensionSite Duplicate()
		{
			return new UIExtensionSite(this.adapter);
		}

		IEnumerator<object> IEnumerable<object>.GetEnumerator()
		{
			return items.GetEnumerator();
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return items.GetEnumerator();
		}
	}
}
