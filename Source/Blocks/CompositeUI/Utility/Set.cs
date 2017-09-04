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
using System.Collections;
using System.Collections.Generic;

namespace Microsoft.Practices.CompositeUI.Utility
{
	/// <summary>
	/// Represents a set of items. Adding an item to a set twice will only yield one instance
	/// in the collection.
	/// </summary>
	/// <typeparam name="TItem">The type of items to be stored in the <see cref="Set{TItem}"/>.</typeparam>
	public class Set<TItem> : ICollection<TItem>
	{
		bool isReadOnly;
		Dictionary<TItem, object> dictionary;

		/// <summary>
		/// 
		/// </summary>
		public Set()
		{
			dictionary = new Dictionary<TItem, object>();
			isReadOnly = false;
		}

		private Set(Set<TItem> innerSet)
		{
			dictionary = innerSet.dictionary;
			isReadOnly = true;
		}

		/// <summary>
		/// See <see cref="ICollection{T}.Add"/> for more information.
		/// </summary>
		public void Add(TItem item)
		{
			if (IsReadOnly)
				throw new NotSupportedException();

			dictionary[item] = String.Empty;
		}

		/// <summary>
		/// Returns a read-only wrapper around the <see cref="Set{TItem}"/>.
		/// </summary>
		public Set<TItem> AsReadOnly()
		{
			return new Set<TItem>(this);
		}

		/// <summary>
		/// See <see cref="ICollection{T}.Clear"/> for more information.
		/// </summary>
		public void Clear()
		{
			if (IsReadOnly)
				throw new NotSupportedException();

			dictionary.Clear();
		}

		/// <summary>
		/// See <see cref="ICollection{T}.Contains"/> for more information.
		/// </summary>
		public bool Contains(TItem item)
		{
			return dictionary.ContainsKey(item);
		}

		/// <summary>
		/// See <see cref="ICollection{T}.CopyTo"/> for more information.
		/// </summary>
		public void CopyTo(TItem[] array, int arrayIndex)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// See <see cref="ICollection{T}.Count"/> for more information.
		/// </summary>
		public int Count
		{
			get { return dictionary.Count; }
		}

		/// <summary>
		/// See <see cref="ICollection{T}.IsReadOnly"/> for more information.
		/// </summary>
		public bool IsReadOnly
		{
			get { return isReadOnly; }
		}

		/// <summary>
		/// See <see cref="ICollection{T}.Remove"/> for more information.
		/// </summary>
		public bool Remove(TItem item)
		{
			if (IsReadOnly)
				throw new NotSupportedException();

			return dictionary.Remove(item);
		}

		/// <summary>
		/// See <see cref="IEnumerable{T}.GetEnumerator"/> for more information.
		/// </summary>
		public IEnumerator<TItem> GetEnumerator()
		{
			return dictionary.Keys.GetEnumerator();
		}

		/// <summary>
		/// See <see cref="IEnumerable.GetEnumerator"/> for more information.
		/// </summary>
		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}
	}
}
