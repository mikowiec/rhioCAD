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
using System.Collections.ObjectModel;

namespace Microsoft.Practices.CompositeUI.SmartParts
{
	/// <summary>
	/// Workspaces are used to provide a surface onto which display SmartParts.
	/// </summary>
	public interface IWorkspace
	{
		/// <summary>
		/// Fires when smart part is closing.
		/// </summary>
		event EventHandler<WorkspaceCancelEventArgs> SmartPartClosing;

		/// <summary>
		/// Fires when the smartpart is activated.
		/// </summary>
		event EventHandler<WorkspaceEventArgs> SmartPartActivated;

		/// <summary>
		/// A snapshot of the smart parts currently contained in the workspace.
		/// </summary>
		ReadOnlyCollection<object> SmartParts { get; }

		/// <summary>
		/// The currently active smart part.
		/// </summary>
		object ActiveSmartPart { get; }

		/// <summary>
		/// Activates the smartPart on the workspace.
		/// </summary>
		/// <param name="smartPart">The smart part to activate.</param>
		void Activate(object smartPart);

		/// <summary>
		/// Applies the smartPartInfo to the smartPart.
		/// </summary>
		void ApplySmartPartInfo(object smartPart, ISmartPartInfo smartPartInfo);

		/// <summary>
		/// Closes a smart part. Disposing the smart part is the responsibility of the caller.
		/// </summary>
		/// <param name="smartPart">Smart part to close.</param>
		void Close(object smartPart);

		/// <summary>
		/// Hides a smart part from the UI.
		/// </summary>
		/// <param name="smartPart">Smart part to hide.</param>
		void Hide(object smartPart);

		/// <summary>
		/// Shows SmartPart using the given SmartPartInfo
		/// </summary>
		/// <param name="smartPart">Smart part to show.</param>
		/// <param name="smartPartInfo"></param>
		void Show(object smartPart, ISmartPartInfo smartPartInfo);

		/// <summary>
		/// Shows a smart part in the UI.
		/// </summary>
		/// <param name="smartPart">Smart part to show.</param>
		void Show(object smartPart);
	}
}