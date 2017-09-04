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
using System.Windows.Forms;

namespace Microsoft.Practices.CompositeUI.WinForms.UIElements
{
	/// <summary>
	/// Provides an adapter for ToolStripItems where new items will be added to the item's owner collection, 
	/// after the item to which the adapter is attached.
	/// </summary>
	public class ToolStripItemOwnerCollectionUIAdapter : ToolStripItemCollectionUIAdapter
	{
		ToolStripItem item;

		/// <summary>
		/// Initializes a new instance of the <see cref="ToolStripItemOwnerCollectionUIAdapter"/> using the
		/// specified item.
		/// </summary>
		/// <param name="item"></param>
		public ToolStripItemOwnerCollectionUIAdapter(ToolStripItem item)
			: base(item.Owner.Items)
		{
			this.item = item;
			item.OwnerChanged += new EventHandler(item_OwnerChanged);
		}

		/// <summary>
		/// Returns the index immediately after the <see cref="ToolStripItem"/> that
		/// was provided to the constructor.
		/// </summary>
		/// <param name="uiElement"></param>
		/// <returns></returns>
		protected override int GetInsertingIndex(object uiElement)
		{
			int index = InternalCollection.IndexOf(item);
			if (index < 0)
				throw new InvalidOperationException();

			return  index + 1;
		}

		private void item_OwnerChanged(object sender, EventArgs e)
		{
			if (item.Owner == null)
				InternalCollection = null;
			else
				InternalCollection = item.Owner.Items;
		}
	}
}
