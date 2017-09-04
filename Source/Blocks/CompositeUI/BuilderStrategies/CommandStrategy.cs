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
using Microsoft.Practices.CompositeUI.Commands;
using Microsoft.Practices.ObjectBuilder;
using System.Globalization;

namespace Microsoft.Practices.CompositeUI.BuilderStrategies
{
	/// <summary>
	/// A <see cref="BuilderStrategy"/> that processes commands associated 
	/// with component members through the <see cref="CommandHandlerAttribute"/>.
	/// </summary>
	public class CommandStrategy : BuilderStrategy
	{
		/// <summary>
		/// Inspects the object for command handler declarations registering them with the 
		/// corresponding <see cref="Command"/>.
		/// </summary>
		public override object BuildUp(IBuilderContext context, Type t, object existing, string id)
		{
			WorkItem workItem = GetWorkItem(context, existing);

			if (workItem != null)
			{
				Type targetType = existing.GetType();

				foreach (MethodInfo methodInfo in targetType.GetMethods())
					RegisterCommandHandlers(context, workItem, existing, id, methodInfo);
			}

			return base.BuildUp(context, t, existing, id);
		}

		/// <summary>
		/// Inspects the object for command handler declarations unregistering them from the 
		/// corresponding command.
		/// </summary>
		public override object TearDown(IBuilderContext context, object item)
		{
			WorkItem workItem = GetWorkItem(context, item);

			if (workItem != null)
			{
				Type targetType = item.GetType();

				foreach (MethodInfo methodInfo in targetType.GetMethods())
					UnregisterCommandHandlers(context, workItem, item, methodInfo);
			}

			return base.TearDown(context, item);
		}

		private void RegisterCommandHandlers(IBuilderContext context, WorkItem workItem, object target,
			string targetID, MethodInfo methodInfo)
		{
			foreach (CommandHandlerAttribute attr in methodInfo.GetCustomAttributes(typeof(CommandHandlerAttribute), true))
			{
				Command cmd = workItem.Commands[attr.CommandName];

				if (!cmd.IsHandlerRegistered(target, methodInfo))
				{
					cmd.ExecuteAction += CreateCommandHandler(target, methodInfo);
					TraceBuildUp(context, target.GetType(), targetID, Properties.Resources.CommandInjectionBuildUp,
						methodInfo.Name, attr.CommandName);
				}
			}
		}

		private void UnregisterCommandHandlers(IBuilderContext context, WorkItem workItem, object target,
			MethodInfo methodInfo)
		{
			foreach (CommandHandlerAttribute attr in methodInfo.GetCustomAttributes(typeof(CommandHandlerAttribute), true))
			{
				if (workItem.Commands.Contains(attr.CommandName))
				{
					workItem.Commands[attr.CommandName].ExecuteAction -= CreateCommandHandler(target, methodInfo);
					TraceTearDown(context, target, Properties.Resources.CommandInjectionTearDown,
						methodInfo.Name, attr.CommandName);
				}
			}
		}

		private EventHandler CreateCommandHandler(object target, MethodInfo methodInfo)
		{
			Delegate handler = null;

			if (methodInfo.IsStatic == false)
			{
				handler = Delegate.CreateDelegate(typeof(EventHandler), target, (MethodInfo)methodInfo);
			}
			else
			{
				throw new CommandException(
					string.Format(CultureInfo.CurrentCulture,
					Properties.Resources.StaticCommandHandlerNotSupported, methodInfo.Name));
			}
			
			return (EventHandler)handler;
		}

		private static WorkItem GetWorkItem(IBuilderContext context, object item)
		{
			if (item is WorkItem)
				return item as WorkItem;

			return context.Locator.Get<WorkItem>(new DependencyResolutionLocatorKey(typeof(WorkItem), null));
		}
	}
}