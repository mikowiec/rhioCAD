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
using Microsoft.Practices.ObjectBuilder;

namespace Microsoft.Practices.CompositeUI
{
	/// <summary>
	/// The interface to be implemented by a visualizer in CAB.
	/// </summary>
	public interface IVisualizer : IDisposable
	{
		/// <summary>
		/// Returns the <see cref="Builder"/> used by the CAB application.
		/// </summary>
		Builder CabBuilder { get; }

		/// <summary>
		/// Returns the <see cref="WorkItem"/> that is the root of the CAB application hierarchy.
		/// </summary>
		WorkItem CabRootWorkItem { get; }

		/// <summary>
		/// Initializes the visualizer.
		/// </summary>
		/// <param name="cabRootWorkItem">The root <see cref="WorkItem"/> of the <see cref="CabApplication{TWorkItem}"/>.</param>
		/// <param name="cabBuilder">The <see cref="Builder"/> used by the <see cref="CabApplication{TWorkItem}"/>.</param>
		void Initialize(WorkItem cabRootWorkItem, Builder cabBuilder);
	}
}
