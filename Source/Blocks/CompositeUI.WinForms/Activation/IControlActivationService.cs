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

using System.Windows.Forms;

namespace Microsoft.Practices.CompositeUI.WinForms
{
	/// <summary>
	/// Defines a service to deal with the <see cref="WorkItem"/> activation and deactivation based
	/// on its contained <see cref="Control"/> state.
	/// </summary>
	public interface IControlActivationService
	{
		/// <summary>
		/// Notifies that a <see cref="Control"/> has been added to the container.
		/// </summary>
		/// <param name="control">The control in which to monitor the OnEnter event.</param>
		void ControlAdded(Control control);

		/// <summary>
		/// Notifies that a control has been removed from the container.
		/// </summary>
		/// <param name="control">The control being monitored.</param>
		void ControlRemoved(Control control);
	}
}