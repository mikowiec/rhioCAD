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
using System.ComponentModel;
using System.Windows.Forms;

namespace Microsoft.Practices.CompositeUI.WinForms.Visualizer
{
	internal partial class VisualizerForm : Form
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="VisualizerForm"/> class
		/// </summary>
		public VisualizerForm()
		{
			InitializeComponent();
		}

		/// <summary>
		/// Handles the closing event.
		/// </summary>
		/// <param name="e"></param>
		protected override void OnClosing(CancelEventArgs e)
		{
			e.Cancel = true;
			this.WindowState = FormWindowState.Minimized;
			base.OnClosing(e);
		}
	}
}