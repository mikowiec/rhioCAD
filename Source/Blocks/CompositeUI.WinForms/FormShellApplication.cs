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
	/// Extends <see cref="WindowsFormsApplication{TWorkItem,TShell}"/> to support an application which
	/// uses a Windows Forms <see cref="Form"/> as its shell.
	/// </summary>
	/// <typeparam name="TWorkItem">The type of the root application work item.</typeparam>
	/// <typeparam name="TShell">The type for the shell to use.</typeparam>
	public abstract class FormShellApplication<TWorkItem, TShell> : WindowsFormsApplication<TWorkItem, TShell>
		where TWorkItem : WorkItem, new()
		where TShell : Form
	{
		/// <summary>
		/// Calls <see cref="Application.Run(Form)"/> to start the application.
		/// </summary>
		protected override void Start()
		{
			Application.Run(Shell);
		}
	}
}