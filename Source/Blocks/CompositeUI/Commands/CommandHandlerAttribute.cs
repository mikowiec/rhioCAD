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

namespace Microsoft.Practices.CompositeUI.Commands
{
	/// <summary>
	/// Declares a method as a <see cref="Command"/> handler.
	/// </summary>
	[AttributeUsage(AttributeTargets.Method, AllowMultiple=true)]
	public class CommandHandlerAttribute : Attribute
	{
		private string commandName;

		/// <summary>
		/// Declares a method as a handler for a <see cref="Command"/> with specified name.
		/// </summary>
		/// <param name="commandName">The name of the <see cref="Command"/> the method handles.</param>
		public CommandHandlerAttribute(string commandName)
		{
			this.commandName = commandName;
		}

		/// <summary>
		/// Gets the name of the <see cref="Command"/> that the decorated method handles.
		/// </summary>
		public string CommandName
		{
			get { return this.commandName; }
		}
	}
}