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
using System.Windows.Forms;
using Microsoft.Practices.CompositeUI.Commands;

namespace Microsoft.Practices.CompositeUI.WinForms
{
	/// <summary>
	/// An <see cref="EventCommandAdapter{T}"/> that updates a <see cref="ToolStripItem"/> based on the changes to 
	/// the <see cref="Command.Status"/> property value.
	/// </summary>
	public class ToolStripItemCommandAdapter : EventCommandAdapter<ToolStripItem>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="ToolStripItemCommandAdapter"/> class
		/// </summary>
		public ToolStripItemCommandAdapter() 
			: base()
		{
		}

		/// <summary>
		/// Initializes the adapter with the given <see cref="ToolStripItem"/>.
		/// </summary>
		public ToolStripItemCommandAdapter(ToolStripItem item, string eventName)
			: base(item, eventName)
		{
		}

		/// <summary>
		/// Handles the changes in the <see cref="Command"/> by refreshing 
		/// the <see cref="ToolStripItem.Enabled"/> property.
		/// </summary>
		protected override void OnCommandChanged(Command command)
		{
			base.OnCommandChanged(command);

			foreach (KeyValuePair<ToolStripItem, List<string>> pair in Invokers)
			{
				pair.Key.Enabled = (command.Status == CommandStatus.Enabled);
				pair.Key.Visible = (command.Status != CommandStatus.Unavailable);
			}
		}

	}
}
