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

namespace Microsoft.Practices.CompositeUI.Services
{
	/// <summary>
	/// Service that stores and retrieves the <see cref="State"/> data to and from 
	/// a persistence storage.
	/// </summary>
	public interface IStatePersistenceService
	{
		/// <summary>
		/// Saves the state to the persistence storage.
		/// </summary>
		/// <param name="state">The <see cref="State"/> to store.</param>
		void Save(State state);

		/// <summary>
		/// Retrieves the saved state from the persistence storage.
		/// </summary>
		/// <param name="id">The id of the state to retrieve the state for.</param>
		/// <returns>The <see cref="State"/> instance created from the store.</returns>
		State Load(string id);

		/// <summary>
		/// Removes the state from the persistence storage.
		/// </summary>
		/// <param name="id">The id of the state to remove.</param>
		void Remove(string id);

		/// <summary>
		/// Checks if the persistence services has the state with the specified
		/// id in its storage.
		/// </summary>
		/// <param name="id">The id of the state to look for.</param>
		/// <returns>true if the state is persisted in the storage; otherwise, false.</returns>
		bool Contains(string id);
	}
}