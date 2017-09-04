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
using Microsoft.Practices.CompositeUI.Properties;
using Microsoft.Practices.CompositeUI.Utility;

namespace Microsoft.Practices.CompositeUI.Commands
{
	/// <summary>
	/// This is the <see cref="ICommandAdapterMapService"/> default implementation.
	/// </summary>
	public class CommandAdapterMapService : ICommandAdapterMapService
	{
		private Dictionary<Type, Type> map = new Dictionary<Type, Type>();

		/// <summary>
		/// Registers an adapter type to be created for the specified invoker type.
		/// </summary>
		/// <param name="invokerType">The invoker type to associate with the specified adapter type. 
		/// This type can be any type.</param>
		/// <param name="adapterType">Any type implementing the <see cref="CommandAdapter"/> interface.</param>
		public void Register(Type invokerType, Type adapterType)
		{
			Guard.ArgumentNotNull(invokerType, "invokerType");
			Guard.ArgumentNotNull(adapterType, "adapterType");

			if (!typeof (CommandAdapter).IsAssignableFrom(adapterType))
			{
				throw new AdapterMapServiceException(Resources.InvalidAdapter);
			}

			map[invokerType] = adapterType;
		}

		/// <summary>
		/// Creates a new <see cref="CommandAdapter"/> instance for the specified invoker type.
		/// </summary>
		/// <param name="invokerType">The invoker type to create an adapter for.</param>
		/// <returns>A new <see cref="CommandAdapter"/> instance for the registered invoker;
		/// null if there is no adapter registration for the required invoker type.</returns>
		public CommandAdapter CreateAdapter(Type invokerType)
		{
			Guard.ArgumentNotNull(invokerType, "invokerType");

			CommandAdapter adapter = null;
			if (map.ContainsKey(invokerType))
			{
				adapter = (CommandAdapter)Activator.CreateInstance(map[invokerType]);
			}
			else
			{
				adapter = FindAssignableAdapter(invokerType);
			}

			return adapter;
		}

		private CommandAdapter FindAssignableAdapter(Type type)
		{
			CommandAdapter adapter = null;
			foreach (KeyValuePair<Type, Type> pair in map)
			{
				if (pair.Key.IsAssignableFrom(type))
				{
					adapter = (CommandAdapter)Activator.CreateInstance(pair.Value);
					break;
				}
			}
			return adapter;
		}


		/// <summary>
		/// Removes the adapter registration for the specified invoker type.
		/// </summary>
		/// <param name="invokerType">The invoker type to remove.</param>
		public void UnRegister(Type invokerType)
		{
			map.Remove(invokerType);
		}

	}
}