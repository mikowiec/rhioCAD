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

using System.Collections.Specialized;

namespace Microsoft.Practices.CompositeUI
{
	/// <summary>
	/// Defines a method implemented by classes that can receive configuration through
	/// name/value pairs in the settings file.
	/// </summary>
	public interface IConfigurable
	{
		/// <summary>
		/// Configures the component with the received settings.
		/// </summary>
		void Configure(NameValueCollection settings);
	}
}