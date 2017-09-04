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

using Microsoft.Practices.CompositeUI.EventBroker;

namespace Microsoft.Practices.CompositeUI
{
	/// <summary>
	/// Indicates a method that will handle state changed events.
	/// </summary>
	public class StateChangedAttribute : EventSubscriptionAttribute
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="StateChangedAttribute"/> using the provided
		/// topic and thread options.
		/// </summary>
		/// <param name="topic">The state topic.</param>
		/// <param name="option">The threading option.</param>
		public StateChangedAttribute(string topic, ThreadOption option)
			: base(StateChangedTopic.BuildStateChangedTopicString(topic))
		{
			this.Thread = option;
		}
	}
}