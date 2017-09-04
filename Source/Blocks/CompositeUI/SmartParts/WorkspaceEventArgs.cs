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

namespace Microsoft.Practices.CompositeUI.SmartParts
{
	/// <summary>
	/// Provides data for the non-cancellable events exposed by 
	/// <see cref="IWorkspace"/>.
	/// </summary>
	public class WorkspaceEventArgs : EventArgs
	{
		private object smartPart;

		/// <summary>
		/// Initializes a new instance of the <see cref="WorkspaceEventArgs"/> using
		/// the specified SmartPart.
		/// </summary>
		/// <param name="smartPart"></param>
		public WorkspaceEventArgs(object smartPart)
		{
			this.smartPart = smartPart;
		}

		/// <summary>
		/// Gets the SmartPart associated with this event.
		/// </summary>
		public object SmartPart
		{
			get { return smartPart; }
		}
	}
}