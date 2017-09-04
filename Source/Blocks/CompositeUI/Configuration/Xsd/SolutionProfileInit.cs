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

namespace Microsoft.Practices.CompositeUI.Configuration.Xsd
{
	/// <summary>
	/// Partial class to initialize solution profile.
	/// </summary>
	public partial class SolutionProfileElement
	{
		/// <summary>
		/// Constructor used to initialize empty moduleinfo.
		/// </summary>
		public SolutionProfileElement()
		{
			modulesField = new ModuleInfoElement[0];
		}
	}
}