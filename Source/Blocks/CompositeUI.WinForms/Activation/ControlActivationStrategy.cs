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
using Microsoft.Practices.ObjectBuilder;

namespace Microsoft.Practices.CompositeUI.WinForms
{
	/// <summary>
	/// A <see cref="BuilderStrategy"/> that hooks up a <see cref="Control"/> with the 
	/// <see cref="IControlActivationService"/>.
	/// </summary>
	public class ControlActivationStrategy : BuilderStrategy
	{
		/// <summary>
		/// Hooks the element if it is a <see cref="Control"/>.
		/// </summary>
		public override object BuildUp(IBuilderContext context, Type t, object existing, string id)
		{
			Control control = existing as Control;

			if (control != null)
			{
				WorkItem wi = context.Locator.Get<WorkItem>(new DependencyResolutionLocatorKey(typeof(WorkItem), null));
				wi.Services.Get<IControlActivationService>(true).ControlAdded(control);
			}

			return base.BuildUp(context, t, existing, id);
		}

		/// <summary>
		/// Notifies the <see cref="IControlActivationService"/> to remove the <see cref="Control"/>.
		/// </summary>
		public override object TearDown(IBuilderContext context, object item)
		{
			Control control = item as Control;
			if (control != null)
			{
				WorkItem wi = context.Locator.Get<WorkItem>(new DependencyResolutionLocatorKey(typeof(WorkItem), null));
				wi.Services.Get<IControlActivationService>(true).ControlRemoved(control);

			}
			return base.TearDown(context, item);
		}
	}
}