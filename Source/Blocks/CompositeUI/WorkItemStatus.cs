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
	/// The status of the <see cref="WorkItem"/>.
	/// </summary>
	public enum WorkItemStatus
	{
		/// <summary>
		/// The <see cref="WorkItem"/> is inactive.
		/// </summary>
		Inactive,
		/// <summary>
		/// The <see cref="WorkItem"/> is active.
		/// </summary>
		Active,
		/// <summary>
		/// The <see cref="WorkItem"/> is terminated.
		/// </summary>
		Terminated,
	}
}