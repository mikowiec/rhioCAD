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
using System.Windows.Forms;
using Microsoft.Practices.CompositeUI.SmartParts;
using Microsoft.Practices.ObjectBuilder;

namespace Microsoft.Practices.CompositeUI.WinForms
{
	/// <summary>
	/// A <see cref="BuilderStrategy"/> that walks the control containment chain looking for child controls that are 
	/// either smart parts, placeholders or workspaces, so that they all get 
	/// added to the <see cref="WorkItem"/>.
	/// </summary>
	public class ControlSmartPartStrategy : BuilderStrategy
	{
		private WorkItem GetWorkItem(IReadableLocator locator)
		{
			return locator.Get<WorkItem>(new DependencyResolutionLocatorKey(typeof(WorkItem), null));
		}

		/// <summary>
		/// Walks the control hierarchy and adds the relevant elements to the <see cref="WorkItem"/>.
		/// </summary>
		public override object BuildUp(IBuilderContext context, Type t, object existing, string id)
		{
			if (existing is Control)
				AddControlHierarchy(GetWorkItem(context.Locator), existing as Control);

			return base.BuildUp(context, t, existing, id);
		}

		/// <summary>
		/// Walks the control hierarchy removing the relevant elements from the <see cref="WorkItem"/>.
		/// </summary>
		public override object TearDown(IBuilderContext context, object item)
		{
			if (item is Control)
				RemoveControlHierarchy(GetWorkItem(context.Locator), item as Control);

			return base.TearDown(context, item);
		}

		private void AddControlHierarchy(WorkItem workItem, Control control)
		{
			ReplaceIfPlaceHolder(workItem, control);

			foreach (Control child in control.Controls)
			{
				if (AddControlToWorkItem(workItem, child) == false)
					AddControlHierarchy(workItem, child);
			}
		}

		private void RemoveControlHierarchy(WorkItem workItem, Control control)
		{
			if (control != null)
				RemoveNestedControls(workItem, control);
		}

		private bool AddControlToWorkItem(WorkItem workItem, Control control)
		{
			if (ShouldAddControlToWorkItem(workItem, control))
			{
				if (control.Name.Length != 0)
					workItem.Items.Add(control, control.Name);
				else
					workItem.Items.Add(control);
				
				return true;
			}

			return false;
		}

		private bool ShouldAddControlToWorkItem(WorkItem workItem, Control control)
		{
			return !workItem.Items.ContainsObject(control) && (IsSmartPart(control) || IsWorkspace(control) || IsPlaceholder(control));
		}

		private bool IsPlaceholder(Control control)
		{
			return (control is ISmartPartPlaceholder);
		}

		private bool IsSmartPart(Control control)
		{
			return (control.GetType().GetCustomAttributes(typeof(SmartPartAttribute), true).Length > 0);
		}

		private bool IsWorkspace(Control control)
		{
			return (control is IWorkspace);
		}

		private void RemoveNestedControls(WorkItem workItem, Control control)
		{
			foreach (Control child in control.Controls)
			{
				workItem.Items.Remove(child);
				RemoveNestedControls(workItem, child);
			}
		}

		private void ReplaceIfPlaceHolder(WorkItem workItem, Control control)
		{
			ISmartPartPlaceholder placeholder = control as ISmartPartPlaceholder;

			if (placeholder != null)
			{
				Control replacement = workItem.Items.Get<Control>(placeholder.SmartPartName);

				if (replacement != null)
					placeholder.SmartPart = replacement;
			}
		}
	}
}