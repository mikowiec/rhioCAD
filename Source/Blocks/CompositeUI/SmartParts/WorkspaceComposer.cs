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
using Microsoft.Practices.CompositeUI.Utility;

namespace Microsoft.Practices.CompositeUI.SmartParts
{
	/// <summary>
	/// Composer class that allows workspaces that cannot inherit from 
	/// <see cref="Workspace{TSmartPart, TSmartPartInfo}"/> to reuse its logic by 
	/// implementing <see cref="IComposableWorkspace{TSmartPart, TSmartPartInfo}"/> and 
	/// forwarding all its <see cref="IWorkspace"/> implementation methods to an instance 
	/// of the composer.
	/// </summary>
	/// <typeparam name="TSmartPart">Type of smart parts supported by the workspace being composed.</typeparam>
	/// <typeparam name="TSmartPartInfo">Type of the smart part information received by the workspace.</typeparam>
	/// <remarks>
	/// For an example on how to reuse the logic in <see cref="Workspace{TSmartPart, TSmartPartInfo}"/> on workspaces 
	/// that inherit from another class already, take a look at the TabWorkspace in the WinForms project.
	/// </remarks>
	public class WorkspaceComposer<TSmartPart, TSmartPartInfo> : Workspace<TSmartPart, TSmartPartInfo>
		where TSmartPartInfo : ISmartPartInfo, new()
	{
		IComposableWorkspace<TSmartPart, TSmartPartInfo> composedWorkspace;

		/// <summary>
		/// Initializes the composer with the composedWorkspace that will 
		/// be called when needed by the base <see cref="Workspace{TSmartPart, TSmartPartInfo}"/>.
		/// </summary>
		/// <param name="composedWorkspace">The workspace being composed with the behavior in this class.</param>
		public WorkspaceComposer(IComposableWorkspace<TSmartPart, TSmartPartInfo> composedWorkspace)
		{
			Guard.ArgumentNotNull(composedWorkspace, "composedWorkspace");
			this.composedWorkspace = composedWorkspace;

			base.SmartPartActivated += new EventHandler<WorkspaceEventArgs>(OnSmartPartActivatedEvent);
			base.SmartPartClosing += new EventHandler<WorkspaceCancelEventArgs>(OnSmartPartClosingEvent);
		}

		/// <summary>
		/// Sets the active smart part in the workspace.
		/// </summary>
		public void SetActiveSmartPart(TSmartPart smartPart)
		{
			base.SetActiveSmartPart((object)smartPart);
		}

		/// <summary>
		/// Forcedly closes the smart part, without raising the <see cref="IWorkspace.SmartPartClosing"/> event.
		/// </summary>
		/// <param name="smartPart"></param>
		public void ForceClose(TSmartPart smartPart)
		{
			base.CloseInternal(smartPart);
		}

		void OnSmartPartClosingEvent(object sender, WorkspaceCancelEventArgs e)
		{
			composedWorkspace.RaiseSmartPartClosing(e);
		}

		void OnSmartPartActivatedEvent(object sender, WorkspaceEventArgs e)
		{
			composedWorkspace.RaiseSmartPartActivated(e);
		}

		/// <summary>
		/// Calls <see cref="IComposableWorkspace{TSmartPart, TSmartPartInfo}.OnActivate"/> 
		/// on the composed workspace.
		/// </summary>
		protected override void OnActivate(TSmartPart smartPart)
		{
			composedWorkspace.OnActivate(smartPart);
		}

		/// <summary>
		/// Calls <see cref="IComposableWorkspace{TSmartPart, TSmartPartInfo}.OnApplySmartPartInfo"/> 
		/// on the composed workspace.
		/// </summary>
		protected override void OnApplySmartPartInfo(TSmartPart smartPart, TSmartPartInfo smartPartInfo)
		{
			composedWorkspace.OnApplySmartPartInfo(smartPart, smartPartInfo);
		}

		/// <summary>
		/// Calls <see cref="IComposableWorkspace{TSmartPart, TSmartPartInfo}.OnShow"/> 
		/// on the composed workspace.
		/// </summary>
		protected override void OnShow(TSmartPart smartPart, TSmartPartInfo smartPartInfo)
		{
			composedWorkspace.OnShow(smartPart, smartPartInfo);
		}

		/// <summary>
		/// Calls <see cref="IComposableWorkspace{TSmartPart, TSmartPartInfo}.OnHide"/> 
		/// on the composed workspace.
		/// </summary>
		protected override void OnHide(TSmartPart smartPart)
		{
			composedWorkspace.OnHide(smartPart);
		}

		/// <summary>
		/// Calls <see cref="IComposableWorkspace{TSmartPart, TSmartPartInfo}.OnClose"/> 
		/// on the composed workspace.
		/// </summary>
		protected override void OnClose(TSmartPart smartPart)
		{
			composedWorkspace.OnClose(smartPart);
		}

		/// <summary>
		/// Calls <see cref="IComposableWorkspace{TSmartPart, TSmartPartInfo}.ConvertFrom"/> 
		/// on the composed workspace.
		/// </summary>
		protected override TSmartPartInfo ConvertFrom(ISmartPartInfo source)
		{
			return composedWorkspace.ConvertFrom(source);
		}
	}
}
