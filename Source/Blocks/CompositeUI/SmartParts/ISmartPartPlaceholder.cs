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

namespace Microsoft.Practices.CompositeUI.SmartParts
{
	/// <summary>
	/// When implemented by a control, provides a simple placeholder to be filled with a SmartPart at runtime.
	/// </summary>
	public interface ISmartPartPlaceholder
	{
		/// <summary>
		/// Gets or sets the default name for the SmartPart contained in the <see cref="WorkItem"/>.
		/// </summary>
		string SmartPartName { get; set; }

		/// <summary>
		/// Gets or sets the SmartPart contained by this placeholder.
		/// </summary>
		object SmartPart { get; set; }
	}
}