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

using System.Threading;

namespace Microsoft.Practices.CompositeUI.EventBroker
{
	/// <summary>
	/// Specifies on which <see cref="Thread"/> an <see cref="EventTopic"/> subscriber will be called.
	/// </summary>
	public enum ThreadOption
	{
		/// <summary>
		/// The call is done on the same <see cref="Thread"/> on which the <see cref="EventTopic"/> was fired.
		/// </summary>
		Publisher,
		/// <summary>
		/// The call is done asynchronously on a background <see cref="Thread"/>.
		/// </summary>
		Background,
		/// <summary>
		/// The call is done is done on the UI <see cref="Thread"/>.
		/// </summary>
		UserInterface,
	}
}