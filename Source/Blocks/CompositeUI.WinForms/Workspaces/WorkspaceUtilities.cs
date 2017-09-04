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
using System.Globalization;
using System.Windows.Forms;
using Microsoft.Practices.CompositeUI.SmartParts;
using Microsoft.Practices.CompositeUI.WinForms.Properties;

namespace Microsoft.Practices.CompositeUI.WinForms
{
	/// <summary>
	/// Provides common workspace utilities.
	/// </summary>
	public static class WorkspaceUtilities
	{
		#region Public

		/// <summary>
		/// Retrieve a smartpart as a control.
		/// </summary>
		/// <param name="smartPart"></param>
		/// <returns></returns>
		public static Control GetSmartPartControl(object smartPart)
		{
			if (smartPart == null)
			{
				throw new ArgumentNullException("smartPart");
			}

			Control spcontrol = smartPart as Control;
			ThrowUnSupportedException(spcontrol);

			return spcontrol;
		}

		/// <summary>
		/// Check if control is in parent control.
		/// </summary>
		/// <param name="parent"></param>
		/// <param name="spcontrol"></param>
		public static void ThrowIfNotInWorkspace(Control parent, Control spcontrol)
		{
			if (parent.Controls.Contains(spcontrol) == false)
			{
				throw new ArgumentException(Resources.SmartPartNotInManager);
			}
		}

		#endregion

		#region Private

		private static void ThrowUnSupportedException(Control spcontrol)
		{
			if (spcontrol == null)
			{
				throw new ArgumentException(String.Format(
					CultureInfo.CurrentCulture,
				    Resources.UnsupportedSmartPartType,
				    typeof (Control)));
			}
		}

		#endregion
	}
}