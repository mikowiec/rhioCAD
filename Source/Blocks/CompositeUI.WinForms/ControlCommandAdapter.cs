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
	/// An <see cref="EventCommandAdapter{Control}"/> that updates a <see cref="Control"/> based on the changes to 
	/// the <see cref="Command.Status"/> property value.
	/// </summary>
	public class ControlCommandAdapter : EventCommandAdapter<Control>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="ControlCommandAdapter"/> class.
		/// </summary>
		public ControlCommandAdapter()
			: base()
		{
		}

		/// <summary>
		/// Initializes the adapter with the given <see cref="Control"/>.
		/// </summary>
		public ControlCommandAdapter(Control control, string eventName) 
			: base(control, eventName)
		{
		}
		
		/// <summary>
		/// Handles the changes in the <see cref="Command"/> by refreshing 
		/// the controls properties.
		/// </summary>
		/// <param name="command"></param>
		protected override void OnCommandChanged(Command command)
		{
			base.OnCommandChanged(command);
			foreach (KeyValuePair<Control, List<string>> pair in Invokers)
			{
				pair.Key.Enabled = (command.Status == CommandStatus.Enabled);
				pair.Key.Visible = (command.Status != CommandStatus.Unavailable);
			}
		}

	}
}
