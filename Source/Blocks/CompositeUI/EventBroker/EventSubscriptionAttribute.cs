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
using System.ComponentModel;

namespace Microsoft.Practices.CompositeUI.EventBroker
{
	/// <summary>
	/// Declares a method as an <see cref="EventTopic"/> subscription.
	/// </summary>
	[AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
	public class EventSubscriptionAttribute : Attribute
	{
		private string topic;
		private ThreadOption threadOption;

		/// <summary>
		/// Declares a method as an <see cref="EventTopic"/> subscription.
		/// </summary>
		/// <param name="topic">The name of the <see cref="EventTopic"/> to subscribe to.</param>
		public EventSubscriptionAttribute(string topic)
			: this(topic, ThreadOption.Publisher)
		{
		}

		/// <summary>
		/// Delcares a method as an <see cref="EventTopic"/> subscription using the specified <see cref="ThreadOption"/>.
		/// </summary>
		/// <param name="topic">The name of the <see cref="EventTopic"/> to subscribe to.</param>
		/// <param name="threadOption">The <see cref="ThreadOption"/> indicating how the method should be called.</param>
		public EventSubscriptionAttribute(string topic, ThreadOption threadOption)
		{
			this.topic = topic;
			this.threadOption = threadOption;
		}

		/// <summary>
		/// The name of the <see cref="EventTopic"/> the decorated method is subscribed to.
		/// </summary>
		public string Topic
		{
			get { return topic; }
		}

		/// <summary>
		/// Indicates the way the subscription method should be called, see
		/// <see cref="ThreadOption"/> enumeration for the supported modes.
		/// </summary>
		[DefaultValue(ThreadOption.Publisher)]
		public ThreadOption Thread
		{
			set { threadOption = value; }
			get { return threadOption; }
		}
	}
}