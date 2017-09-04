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
using System.Globalization;
using System.Runtime.Serialization;
using Microsoft.Practices.CompositeUI.Properties;

namespace Microsoft.Practices.CompositeUI.Services
{
	/// <summary>
	/// Exception thrown when a required service doesn't exist in 
	/// the component container.
	/// </summary>
	[Serializable]
	public class ServiceMissingException : Exception
	{
		/// <summary>
		/// Initializes the exception.
		/// </summary>
		public ServiceMissingException() : base()
		{
		}

		/// <summary>
		/// Initializes a new instance with a specified error message.
		/// </summary>
		/// <param name="message">The message that describes the error.</param>
		public ServiceMissingException(string message)
			: base(message)
		{
		}

		/// <summary>
		/// Initializes a new instance with a specified error message 
		/// and a reference to the inner exception that is the cause of this exception.
		/// </summary>
		/// <param name="message">The error message that explains the reason for the exception.</param>
		/// <param name="exception">The exception that is the cause of the current exception, 
		/// or a null reference if no inner exception is specified.</param>
		public ServiceMissingException(string message, Exception exception)
			: base(message, exception)
		{
		}

		/// <summary>
		/// Initializes the exception for the given service type.
		/// </summary>
		public ServiceMissingException(Type serviceType)
			: base(String.Format(CultureInfo.CurrentCulture,
								 Resources.ServiceMissingExceptionSimpleMessage,
								 serviceType))
		{
		}

		/// <summary>
		/// Initializes the exception for the given service type and component.
		/// </summary>
		public ServiceMissingException(Type serviceType, object component)
			: base(String.Format(CultureInfo.CurrentCulture,
			                     Resources.ServiceMissingExceptionMessage,
			                     serviceType, component))
		{
		}

		/// <summary>
		/// Initializes the exception.
		/// </summary>
		public ServiceMissingException(Type serviceType, object component, Exception innerException)
			: base(String.Format(CultureInfo.CurrentCulture,
			                     Resources.ServiceMissingExceptionMessage,
			                     serviceType, component), innerException)
		{
		}

		/// <summary>
		/// Initializes a new instance with serialized data.
		/// </summary>
		/// <param name="info">The <see cref="SerializationInfo"/> that holds the serialized object data about the exception being thrown.</param>
		/// <param name="context">The <see cref="StreamingContext"/> that contains contextual information about the source or destination.</param>
		protected ServiceMissingException(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
		}
	}
}