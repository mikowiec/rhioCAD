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
	/// Services that implement this interface are used to associate an invoker type
	/// with a <see cref="CommandAdapter"/> type. 
	/// </summary>
	/// <remarks>
	/// This service is used by the <see cref="Command"/> to
	/// create the correct adapter for a given invoker.
	/// </remarks>
	public interface ICommandAdapterMapService
	{
		/// <summary>
		/// Registers an adapter type to be created for the specified invoker type.
		/// </summary>
		/// <param name="invokerType">The invoker type to associate with the specified adapter type. 
		/// This type can be any type.</param>
		/// <param name="adapterType">Any type implementing the <see cref="CommandAdapter"/> interface.</param>
		void Register(Type invokerType, Type adapterType);

		/// <summary>
		/// Creates a new <see cref="CommandAdapter"/> instance for the specified invoker type.
		/// </summary>
		/// <param name="invokerType">The invoker type to create an adapter for.</param>
		/// <returns>A new <see cref="CommandAdapter"/> instance for the registered invoker;
		/// null if there is no adapter registration for the required invoker type.</returns>
		CommandAdapter CreateAdapter(Type invokerType);

		/// <summary>
		/// Removes the adapter registration for the specified invoker type.
		/// </summary>
		/// <param name="invokerType">The invoker type to remove.</param>
		void UnRegister(Type invokerType);
	}
}