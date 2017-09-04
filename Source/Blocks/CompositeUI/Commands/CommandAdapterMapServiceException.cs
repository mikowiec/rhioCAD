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
using System.Runtime.Serialization;

namespace Microsoft.Practices.CompositeUI.Commands
{
	/// <summary>
	/// An <see cref="Exception"/> thrown by the <see cref="ICommandAdapterMapService"/> implementations.
	/// </summary>
	[Serializable]
	public class AdapterMapServiceException : Exception
	{
		/// <summary>
		/// Initializes a new instance.
		/// </summary>
		public AdapterMapServiceException() : base() { }

		/// <summary>
		/// Initializes a new instance ith a specified error message.
		/// </summary>
		/// <param name="message">The message that describes the error.</param>
		public AdapterMapServiceException(string message) : base(message) { }
		
		/// <summary>
		/// Initializes a new instance with a specified error message 
		/// and a reference to the inner exception that is the cause of this exception.
		/// </summary>
		/// <param name="message">The error message that explains the reason for the exception.</param>
		/// <param name="innerException">The exception that is the cause of the current exception, 
		/// or a null reference if no inner exception is specified.</param>
		public AdapterMapServiceException(string message, Exception innerException) : base(message, innerException) { }
		
		/// <summary>
		/// Initializes a new instance with serialized data.
		/// </summary>
		/// <param name="info">The <see cref="SerializationInfo"/> that holds the serialized object data about the exception being thrown.</param>
		/// <param name="context">The <see cref="StreamingContext"/> that contains contextual information about the source or destination.</param>
		protected AdapterMapServiceException(SerializationInfo info, StreamingContext context) : base(info, context) { }
	}
}