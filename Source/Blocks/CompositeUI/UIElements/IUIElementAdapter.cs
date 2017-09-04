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

namespace Microsoft.Practices.CompositeUI.UIElements
{
	/// <summary>
	/// Interface implemented by objects that provide UIElement support for named locations in a shell.
	/// </summary>
	public interface IUIElementAdapter
	{
		/// <summary>
		/// Adds a UI Element.
		/// </summary>
		/// <param name="uiElement">The UI element to add.</param>
		/// <returns>The added UI element.</returns>
		object Add(object uiElement);
		
		/// <summary>
		/// Removes a UI Element.
		/// </summary>
		/// <param name="uiElement">The UI element to remove.</param>
		void Remove(object uiElement);

	}
}
