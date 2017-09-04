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

using Microsoft.Practices.ObjectBuilder;

namespace Microsoft.Practices.CompositeUI
{
	/// <summary>
	/// A base class for controllers and presenters that provides access to the <see cref="WorkItem"/>
	/// and <see cref="State"/>.
	/// </summary>
	public class Controller
	{
		private WorkItem workItem;

		/// <summary>
		/// Initializes a new instance of the <see cref="Controller"/> class.
		/// </summary>
		public Controller()
		{
		}

		/// <summary>
		/// Gets the current work item where the controller lives.
		/// </summary>
		[Dependency(NotPresentBehavior = NotPresentBehavior.ReturnNull)]
		public WorkItem WorkItem
		{
			get { return workItem; }
			set { workItem = value; }
		}

		/// <summary>
		/// Gets the state associated with the current <see cref="WorkItem"/>.
		/// </summary>
		public State State
		{
			get
			{
				return WorkItem == null ? null : WorkItem.State;
			}
		}
	}
}