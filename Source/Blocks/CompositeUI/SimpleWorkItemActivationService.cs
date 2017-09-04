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
	/// An implementation of <see cref="IWorkItemActivationService"/> that ensures that only
	/// one <see cref="WorkItem"/> is active at one time.
	/// </summary>
	public class SimpleWorkItemActivationService : IWorkItemActivationService
	{
		private object syncroot = new object();
		private WorkItem activeWorkItem;

		/// <summary>
		/// Initializes a new instance of the <see cref="SimpleWorkItemActivationService"/> class.
		/// </summary>
		public SimpleWorkItemActivationService()
		{
		}

		/// <summary>
		/// See <see cref="IWorkItemActivationService.ChangeStatus"/> for more information.
		/// </summary>
		public void ChangeStatus(WorkItem item)
		{
			lock (syncroot)
			{
				if (item != activeWorkItem && item.Status == WorkItemStatus.Active)
				{
					if (activeWorkItem != null && activeWorkItem.Status != WorkItemStatus.Terminated)
						activeWorkItem.Deactivate();

					activeWorkItem = item;
				}
			}
		}
	}
}