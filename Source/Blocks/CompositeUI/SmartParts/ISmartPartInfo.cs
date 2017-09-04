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
	/// Provides information about a SmartPart to an <see cref="IWorkspace"/>.
	/// </summary>
	public interface ISmartPartInfo
	{
		/// <summary>
		/// Description of this SmartPart.
		/// </summary>
		string Description { get; set; }

		/// <summary>
		/// Title of this SmartPart.
		/// </summary>
		string Title { get; set; }
	}
}