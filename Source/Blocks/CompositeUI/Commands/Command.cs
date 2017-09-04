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
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Microsoft.Practices.CompositeUI.Properties;
using Microsoft.Practices.CompositeUI.Utility;
using System.Globalization;
using System.Reflection;
using System.Diagnostics;
using Microsoft.Practices.ObjectBuilder;

namespace Microsoft.Practices.CompositeUI.Commands
{
	/// <summary>
	/// Represents a command that can be fired by several UI Elements.
	/// </summary>
	public class Command : IDisposable, IBuilderAware
	{
		private TraceSource traceSource;
		private CommandStatus status = CommandStatus.Enabled;
		private List<CommandAdapter> adapters = new List<CommandAdapter>();
		private List<CommandAdapter> ownedAdapters = new List<CommandAdapter>();
		private string name;
		private ICommandAdapterMapService mapService;

		/// <summary>
		/// This service is used by <see cref="Command"/> to create adapters for its invokers.
		/// </summary>
		[ServiceDependency]
		public ICommandAdapterMapService MapService
		{
			set { mapService = value; }
		}

		/// <summary>
		/// Used by injection to set the <see cref="TraceSource"/> to use for tracing.
		/// </summary>
		[ClassNameTraceSource]
		public TraceSource TraceSource
		{
			set { traceSource = value; }
			protected get { return traceSource; }
		}

		/// <summary>
		/// This event signals that some of the command's properties have changed.
		/// </summary>
		public event EventHandler Changed;

		/// <summary>
		/// This event signals that this <see cref="Command"/> is executed. Handle this event to implement the
		/// actions to be executed when the command is fired.
		/// </summary>
		public event EventHandler ExecuteAction;

		/// <summary>
		/// Initializes a new instance of the <see cref="Command"/> class.
		/// </summary>
		public Command() { }

		/// <summary>
		/// Gets the name of the command.
		/// </summary>
		public string Name
		{
			get { return name; }
		}

		/// <summary>
		/// Gets or sets the status of the <see cref="Command"/>, which controls the 
		/// visible/enabled behavior of both the <see cref="Command"/> and 
		/// its associated UI elements.
		/// </summary>
		public CommandStatus Status
		{
			get { return this.status; }
			set
			{
				CommandStatus oldValue = this.status;
				this.status = value;

				if (oldValue != value)
				{
					OnChanged();

					if (TraceSource != null)
						TraceSource.TraceInformation(Properties.Resources.TraceCommandStatusChanged, name, status);
				}
			}
		}

		/// <summary>
		/// Registers a <see cref="CommandAdapter"/> with this command.
		/// </summary>
		/// <param name="adapter">The <see cref="CommandAdapter"/> to register with this <see cref="Command"/>.</param>
		public virtual void AddCommandAdapter(CommandAdapter adapter)
		{
			adapter.ExecuteCommand += this.OnExecuteAction;
			adapter.BindCommand(this);
			adapters.Add(adapter);
		}

		/// <summary>
		/// Removes the <see cref="CommandAdapter"/> from this command.
		/// </summary>
		/// <param name="adapter">The <see cref="CommandAdapter"/> to remove from this <see cref="Command"/>.</param>
		public virtual void RemoveCommandAdapter(CommandAdapter adapter)
		{
			adapter.ExecuteCommand -= this.OnExecuteAction;
			adapter.UnbindCommand(this);

			adapters.Remove(adapter);
		}

		/// <summary>
		/// Executes this <see cref="Command"/> by firing the <see cref="ExecuteAction"/> event.
		/// </summary>
		/// <remarks>The event will only be fired when the command's status is enabled.</remarks>
		public virtual void Execute()
		{
			if (status == CommandStatus.Enabled)
			{
				OnExecuteAction(this, EventArgs.Empty);

				if (TraceSource != null)
					TraceSource.TraceInformation(Properties.Resources.TraceCommandExecuted, name);
			}
		}

		/// <summary>
		/// Returns a <see cref="ReadOnlyCollection{T}"/> with the registered <see cref="CommandAdapter"/>.
		/// </summary>
		public virtual ReadOnlyCollection<CommandAdapter> Adapters
		{
			get { return new ReadOnlyCollection<CommandAdapter>(adapters); }
		}

		/// <summary>
		/// Returns a <see cref="ReadOnlyCollection{T}"/> with the registered <see cref="CommandAdapter"/>
		/// which are of the type specified by TAdapter.
		/// </summary>
		/// <typeparam name="TAdapter">The type of adapter to search for.</typeparam>
		/// <returns>A new instance of a <see cref="ReadOnlyCollection{T}"/>.</returns>
		public virtual ReadOnlyCollection<TAdapter> FindAdapters<TAdapter>() where TAdapter : CommandAdapter
		{
			List<TAdapter> found = new List<TAdapter>();

			adapters.ForEach(delegate(CommandAdapter adapter)
				{
					if (adapter is TAdapter)
					{
						found.Add((TAdapter)adapter);
					}
				});
			return new ReadOnlyCollection<TAdapter>(found);
		}

		/// <summary>
		/// Adds a new invoker for this <see cref="Command"/>.
		/// </summary>
		/// <remarks>The command will use the <see cref="ICommandAdapterMapService"/> to create the 
		/// corresponding <see cref="CommandAdapter"/> for the specified invoker.</remarks>
		public virtual void AddInvoker(object invoker, string eventName)
		{
			if (mapService == null)
			{
				throw new CommandException(String.Format(CultureInfo.CurrentCulture,
					Resources.CannotGetMapService, name));
			}

			CommandAdapter adapter = mapService.CreateAdapter(invoker.GetType());
			if (adapter == null)
			{
				throw new CommandException(String.Format(CultureInfo.CurrentCulture,
					Resources.CannotGetCommandAdapter, invoker.GetType()));
			}
			adapter.AddInvoker(invoker, eventName);
			AddCommandAdapter(adapter);
			ownedAdapters.Add(adapter);
		}

		/// <summary>
		/// Removes the invoker from the <see cref="Command"/>.
		/// </summary>
		/// <param name="invoker">An invoker object for the command.</param>
		/// <param name="eventName">The name of the event on the invoker object that fires 
		/// this <see cref="Command"/>.</param>
		/// <remarks>This method removes the invoker from all the <see cref="CommandAdapter"/> 
		/// registered with this <see cref="Command"/>.</remarks>
		public virtual void RemoveInvoker(object invoker, string eventName)
		{
			foreach (CommandAdapter adapter in adapters.ToArray())
			{
				if (adapter.ContainsInvoker(invoker) == true)
				{
					adapter.RemoveInvoker(invoker, eventName);
					if (adapter.InvokerCount == 0)
					{
						RemoveCommandAdapter(adapter);
						if (ownedAdapters.Contains(adapter))
						{
							ownedAdapters.Remove(adapter);
							adapter.Dispose();
						}
					}
				}
			}
		}

		/// <summary>
		/// Handles the <see cref="CommandAdapter.ExecuteCommand"/> event and fires the <see cref="ExecuteAction"/>
		/// event accordingly.
		/// </summary>
		/// <param name="sender">The sender of the event.</param>
		/// <param name="e">The arguments of the event.</param>
		protected virtual void OnExecuteAction(object sender, EventArgs e)
		{
			if (Status == CommandStatus.Enabled && ExecuteAction != null)
			{
				ExecuteAction(this, e);
			}
		}

		/// <summary>
		/// Fires the <see cref="Changed"/> event for this command.
		/// </summary>
		protected virtual void OnChanged()
		{
			if (Changed != null)
			{
				Changed(this, EventArgs.Empty);
			}
		}

		internal bool IsHandlerRegistered(object target, MethodInfo methodInfo)
		{
			if (ExecuteAction != null)
			{
				foreach (Delegate dlg in ExecuteAction.GetInvocationList())
				{
					if (dlg.Target == target && dlg.Method == methodInfo)
					{
						return true;
					}
				}
			}
			return false;
		}

		/// <summary>
		/// Removes all the adapters from the command before disposing it.
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
			if (disposing)
			{
				RemoveCommandAdapters();
			}
		}

		private void RemoveCommandAdapters()
		{
			foreach (CommandAdapter adapter in adapters.ToArray())
			{
				RemoveCommandAdapter(adapter);
			}
			foreach (CommandAdapter adapter in ownedAdapters.ToArray())
			{
				adapter.Dispose();
			}
		}

		/// <summary>
		/// See <see cref="IBuilderAware.OnBuiltUp"/> for more information.
		/// </summary>
		public virtual void OnBuiltUp(string id)
		{
			this.name = id;
		}

		/// <summary>
		/// See <see cref="IBuilderAware.OnTearingDown"/> for more information.
		/// </summary>
		public virtual void OnTearingDown()
		{
		}

		class ClassNameTraceSourceAttribute : TraceSourceAttribute
		{
			public ClassNameTraceSourceAttribute() : base(typeof(Command).FullName) { }
		}
	}
}