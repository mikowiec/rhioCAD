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

namespace Microsoft.Practices.CompositeUI
{
	/// <summary>
	/// Base implementation with virtual methods for handling the 
	/// <see cref="WorkItem"/> events.
	/// </summary>
	public abstract class WorkItemExtension : IWorkItemExtension
	{
		private WorkItem workItem;

		/// <summary>
		/// Hooks to all events in the <see cref="WorkItem"/> to 
		/// the virtual event handlers.
		/// </summary>
		/// <param name="workItem">The <see cref="WorkItem"/> being extended.</param>
		public void Initialize(WorkItem workItem)
		{
			Guard.ArgumentNotNull(workItem, "workItem");

			this.workItem = workItem;

			workItem.Activated += new EventHandler(OnActivated);
			workItem.Deactivated += new EventHandler(OnDeactivated);
			workItem.Initialized += new EventHandler(OnInitialized);
			workItem.RunStarted += new EventHandler(OnRunStarted);
			workItem.Terminated += new EventHandler(OnTerminated);
		}

		void OnActivated(object sender, EventArgs e)
		{
			OnActivated();
		}

		void OnDeactivated(object sender, EventArgs e)
		{
			OnDeactivated();
		}

		void OnInitialized(object sender, EventArgs e)
		{
			OnInitialized();
		}

		void OnRunStarted(object sender, EventArgs e)
		{
			OnRunStarted();
		}

		void OnTerminated(object sender, EventArgs e)
		{
			OnTerminated();
		}

		/// <summary>
		/// The <see cref="WorkItem"/> being extended.
		/// </summary>
		public WorkItem WorkItem
		{
			get { return workItem; }
		}

		/// <summary>
		/// Method that handles the <see cref="Microsoft.Practices.CompositeUI.WorkItem.Activated"/> event on the 
		/// extended <see cref="WorkItem"/>.
		/// </summary>
		protected virtual void OnActivated()
		{
		}

		/// <summary>
		/// Method that handles the <see cref="Microsoft.Practices.CompositeUI.WorkItem.Deactivated"/> event on the 
		/// extended <see cref="WorkItem"/>.
		/// </summary>
		protected virtual void OnDeactivated()
		{
		}

		/// <summary>
		/// Method that handles the <see cref="Microsoft.Practices.CompositeUI.WorkItem.Initialized"/> event on the 
		/// extended <see cref="WorkItem"/>.
		/// </summary>
		protected virtual void OnInitialized()
		{
		}

		/// <summary>
		/// Method that handles the <see cref="Microsoft.Practices.CompositeUI.WorkItem.RunStarted"/> event on the 
		/// extended <see cref="WorkItem"/>.
		/// </summary>
		protected virtual void OnRunStarted()
		{
		}

		/// <summary>
		/// Method that handles the <see cref="Microsoft.Practices.CompositeUI.WorkItem.OnTerminated"/> event on the 
		/// extended <see cref="WorkItem"/>.
		/// </summary>
		protected virtual void OnTerminated()
		{
		}
	}
}