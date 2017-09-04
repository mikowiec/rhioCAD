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
using System.Text;
using Microsoft.Practices.ObjectBuilder;

namespace Microsoft.Practices.CompositeUI.WinForms
{
	/// <summary>
	/// A <see cref="BuilderStrategy"/> that adds services that are needed by Windows Forms 
	/// applications into the <see cref="WorkItem"/>.
	/// </summary>
	public class WinFormServiceStrategy : BuilderStrategy
	{
		/// <summary>
		/// Adds in the needed services for Windows Forms applications.
		/// </summary>
		public override object BuildUp(IBuilderContext context, Type t, object existing, string id)
		{
			WorkItem workItem = existing as WorkItem;

			if (workItem != null && 
				workItem.Services.ContainsLocal(typeof(IControlActivationService)) == false)
			{
				workItem.Services.Add<IControlActivationService>(new ControlActivationService());
			}

			return base.BuildUp(context, t, existing, id);
		}

	}
}
