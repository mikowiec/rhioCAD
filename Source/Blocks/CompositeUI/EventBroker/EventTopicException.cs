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
using System.Collections.ObjectModel;
using Microsoft.Practices.CompositeUI.Properties;
using System.Runtime.Serialization;
using System.Globalization;

namespace Microsoft.Practices.CompositeUI.EventBroker
{
	/// <summary>
	/// An <see cref="Exception"/> thrown by the <see cref="EventTopic"/> when exceptions occurs
	/// on its subscriptions during a firing sequence.
	/// </summary>
	[Serializable]
	public class EventTopicException : Exception
	{
		private ReadOnlyCollection<Exception> exceptions;

		private EventTopic topic;

		/// <summary>
		/// Initializes a new instance of the <see cref="EventTopicException"/> class.
		/// </summary>
		public EventTopicException() : base()
		{
		}

		/// <summary>
		/// Initializes a new instance with a specified error message.
		/// </summary>
		/// <param name="message">The message that describes the error.</param>
		public EventTopicException(string message)
			:
			base(message)
		{
		}

		/// <summary>
		/// Initializes a new instance with a specified error message 
		/// and a reference to the inner exception that is the cause of this exception.
		/// </summary>
		/// <param name="message">The error message that explains the reason for the exception.</param>
		/// <param name="innerException">The exception that is the cause of the current exception, 
		/// or a null reference if no inner exception is specified.</param>
		public EventTopicException(string message, Exception innerException)
			:
			base(message, innerException)
		{
		}

		/// <summary>
		/// Initializes a new instance with serialized data.
		/// </summary>
		/// <param name="info">The <see cref="SerializationInfo"/> that holds the serialized object data about the exception being thrown.</param>
		/// <param name="context">The <see cref="StreamingContext"/> that contains contextual information about the source or destination.</param>
		protected EventTopicException(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
		}

		/// <summary>
		/// Initializes a new instance with the specified list of exceptions.
		/// </summary>
		/// <param name="exceptions">The list of exceptions that occurred during the subscribers invocation.</param>
		/// <param name="topic">The <see cref="EventTopic"/> instance whose subscribers incurred into an exception.</param>
		public EventTopicException(EventTopic topic, ReadOnlyCollection<Exception> exceptions)
			: base(String.Format(CultureInfo.CurrentCulture, Resources.EventTopicFireException, topic.Name))
		{
			this.topic = topic;
			this.exceptions = exceptions;
		}

		/// <summary>
		/// Gets the list of exceptions that occurred during the subscribers invocation.
		/// </summary>
		public ReadOnlyCollection<Exception> Exceptions
		{
			get { return exceptions; }
		}

		/// <summary>
		/// Gets the <see cref="EventTopic"/> which incurred into errors.
		/// </summary>
		public EventTopic Topic
		{
			get { return topic; }
		}
	}
}