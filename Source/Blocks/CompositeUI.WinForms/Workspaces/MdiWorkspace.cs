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

using System.ComponentModel;
using System.Windows.Forms;
using Microsoft.Practices.CompositeUI.SmartParts;
using System.Drawing;

namespace Microsoft.Practices.CompositeUI.WinForms
{
	/// <summary>
	/// Implements a Workspace which shows the smarparts in MDI forms.
	/// </summary>
	public class MdiWorkspace : WindowWorkspace
	{
		private Form parentMdiForm;

		/// <summary>
		/// Constructor specifying the parent form of the MDI child.
		/// </summary>
		public MdiWorkspace(Form parentForm)
			: base()
		{
			this.parentMdiForm = parentForm;
			this.parentMdiForm.IsMdiContainer = true;
		}

		/// <summary>
		/// Gets the parent MDI form.
		/// </summary>
		public Form ParentMdiForm
		{
			get { return parentMdiForm; }
		}

		/// <summary>
		/// Shows the form as a child of the specified <see cref="ParentMdiForm"/>.
		/// </summary>
		/// <param name="smartPart">The <see cref="Control"/> to show in the workspace.</param>
		/// <param name="smartPartInfo">The information to use to show the smart part.</param>
		protected override void OnShow(Control smartPart, WindowSmartPartInfo smartPartInfo)
		{
			Form mdiChild = this.GetOrCreateForm(smartPart);
		    smartPart.Dock = DockStyle.Fill;
			mdiChild.MdiParent = parentMdiForm;

			this.SetWindowProperties(mdiChild, smartPartInfo);
			mdiChild.Show();
			this.SetWindowLocation(mdiChild, smartPartInfo);
			mdiChild.BringToFront();
		}
	}
}