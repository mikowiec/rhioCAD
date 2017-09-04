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

namespace Microsoft.Practices.CompositeUI
{
	/// <summary>
	/// Extends <see cref="CabApplication{TWorkItem}"/> to support applications with a shell.
	/// </summary>
	/// <typeparam name="TWorkItem">The type of the root application work item.</typeparam>
	/// <typeparam name="TShell">The type of the shell the application uses.</typeparam>
	public abstract class CabShellApplication<TWorkItem, TShell> : CabApplication<TWorkItem>
		where TWorkItem : WorkItem, new()
	{
		private TShell shell;

		/// <summary>
		/// Creates the shell.
		/// </summary>
		protected sealed override void OnRootWorkItemInitialized()
		{
			BeforeShellCreated();
			shell = RootWorkItem.Items.AddNew<TShell>();
			AfterShellCreated();
		}

		/// <summary>
		/// May be overridden in derived classes to perform activities just before the shell
		/// is created.
		/// </summary>
		protected virtual void BeforeShellCreated()
		{
		}

		/// <summary>
		/// May be overridden in derived classes to perform activities just after the shell
		/// has been created.
		/// </summary>
		protected virtual void AfterShellCreated()
		{
		}

		/// <summary>
		/// Returns the shell that was created. Will not be valid until <see cref="AfterShellCreated"/>
		/// has been called.
		/// </summary>
		protected TShell Shell
		{
			get { return shell; }
		}
	}
}