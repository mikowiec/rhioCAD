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
using System.Reflection;
using Microsoft.Practices.ObjectBuilder;
using Microsoft.Practices.CompositeUI.Utility;

namespace Microsoft.Practices.CompositeUI.Commands
{
	/// <summary>
	/// Defines a command adapter class, which provides the logic needed for an object to be able 
	/// to invoke a <see cref="Command"/>.
	/// </summary>
	public abstract class CommandAdapter : IDisposable
	{
		private Command boundCommand;

		/// <summary>
		/// Event to be fired by the <see cref="CommandAdapter"/> implementations
		/// to signal that the <see cref="Command"/> should execute.
		/// </summary>
		public event EventHandler ExecuteCommand;

		/// <summary>
		/// Called when the <see cref="CommandAdapter"/> is registered with a <see cref="Command"/>.
		/// </summary>
		/// <param name="command">The <see cref="Command"/> the adapter is being added to.</param>
		/// <remarks>The default implementation of this method adds the CommandChangedHandler method
		/// handler to the <see cref="Command.Changed"/> event.
		/// </remarks>
		public virtual void BindCommand(Command command)
		{
			Guard.ArgumentNotNull(command, "command");
			if (boundCommand != null)
			{
				throw new InvalidOperationException(Properties.Resources.AdapterAlreadyBoundToACommand);
			}
			command.Changed += CommandChangedHandler;
			boundCommand = command;
		}

		/// <summary>
		/// Called when <see cref="CommandAdapter"/> is removed from a <see cref="Command"/>.
		/// </summary>
		/// <param name="command">The <see cref="Command"/> the adapter is being removed from.</param>
		/// <remarks>The default implementation of this method removes the CommandChangedHandler method handler 
		/// from the <see cref="Command.Changed"/> event.
		/// </remarks>
		public virtual void UnbindCommand(Command command)
		{
			Guard.ArgumentNotNull(command, "command");
			if (boundCommand != command)
			{
				throw new InvalidOperationException(Properties.Resources.AdapterNotBoundToGivenCommand);
			}
			command.Changed -= CommandChangedHandler;
			boundCommand = null;
		}

		/// <summary>
		/// Adds an invoker to the <see cref="CommandAdapter"/>.
		/// </summary>
		public abstract void AddInvoker(object invoker, string eventName);

		/// <summary>
		/// Removes the invoker from the <see cref="CommandAdapter"/>.
		/// </summary>
		public abstract void RemoveInvoker(object invoker, string eventName);

		/// <summary>
		/// Gets the count of invokers in the <see cref="CommandAdapter"/>.
		/// </summary>
		public abstract int InvokerCount { get; }

		/// <summary>
		/// Used to unhook and dispose all the invokers.
		/// </summary>
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        /// <summary>
        /// Called to free resources.
        /// </summary>
        /// <param name="disposing">Should be true when calling from Dispose().</param>
        protected virtual void Dispose(bool disposing)
        {
        }

		/// <summary>
		/// Checks if the <see cref="CommandAdapter"/> contains the invoker.
		/// </summary>
		/// <param name="invoker">The invoker to check for.</param>
		/// <returns>true if the invoker is in the adapter; otherwise false.</returns>
		public abstract bool ContainsInvoker(object invoker);

		/// <summary>
		/// Handles the <see cref="Command.Changed"/> event.
		/// </summary>
		/// <param name="command">The <see cref="Command"/> that fired the Changed event.</param>
		protected virtual void OnCommandChanged(Command command)
		{
		}

		/// <summary>
		/// Causes the execution of the <see cref="Command"/>.
		/// </summary>
		protected virtual void FireCommand()
		{
			if (ExecuteCommand != null)
			{
				ExecuteCommand(this, EventArgs.Empty);
			}
		}

		private void CommandChangedHandler(object sender, EventArgs e)
		{
			OnCommandChanged((Command)sender);
		}

	}
}