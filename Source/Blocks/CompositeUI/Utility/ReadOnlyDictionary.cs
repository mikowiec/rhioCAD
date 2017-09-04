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
using System.Text;
using System.Collections;

namespace Microsoft.Practices.CompositeUI.Utility
{
	/// <summary>
	/// Provides a read-only implementation of <see cref="IDictionary{TKey,TValue}"/>.
	/// </summary>
	/// <typeparam name="TKey"></typeparam>
	/// <typeparam name="TValue"></typeparam>
	public class ReadOnlyDictionary<TKey, TValue> : IDictionary<TKey, TValue>
	{
		IDictionary<TKey, TValue> inner;

		/// <summary>
		/// Initializes a new instance of the <see cref="ReadOnlyDictionary{TKey,TValue}"/>
		/// class using the specified dictionary as the base.
		/// </summary>
		/// <param name="innerDictionary"></param>
		public ReadOnlyDictionary(IDictionary<TKey, TValue> innerDictionary)
		{
			Guard.ArgumentNotNull(innerDictionary, "innerDictionary");

			inner = innerDictionary;
		}

		#region IDictionary<TKey,TValue> Members

		/// <summary>
		/// This method is not implemented.
		/// </summary>
		/// <param name="key"></param>
		/// <param name="value"></param>
		void IDictionary<TKey,TValue>.Add(TKey key, TValue value)
		{
			throw new NotSupportedException( Properties.Resources.DictionaryIsReadOnly );
		}

		/// <summary>
		/// Determines whether the ReadOnlyDictionary{TKey,TValue} contains a specific key.
		/// </summary>
		/// <param name="key"></param>
		/// <returns></returns>
		public bool ContainsKey(TKey key)
		{
			return inner.ContainsKey(key);
		}

		/// <summary>
		/// Gets an <see cref="ICollection{TKey}"/> containing the keys of <see cref="IDictionary{TKey,TValue}"/>.
		/// </summary>
		public ICollection<TKey> Keys
		{
			get { return inner.Keys; }
		}

		/// <summary>
		/// This method is not implemented.
		/// </summary>
		/// <param name="key"></param>
		/// <returns></returns>
		bool IDictionary<TKey, TValue>.Remove(TKey key)
		{
			throw new NotSupportedException(Properties.Resources.DictionaryIsReadOnly);
		}

		/// <summary>
		/// Gets the value associated with the specified key.
		/// </summary>
		/// <param name="key"></param>
		/// <param name="value"></param>
		/// <returns></returns>
		public bool TryGetValue(TKey key, out TValue value)
		{
			return inner.TryGetValue(key, out value);
		}

		/// <summary>
		/// Gets an <see cref="ICollection{TValue}"/> containing the values in the 
		/// <see cref="IDictionary{TKey,TValue}"/>.
		/// </summary>
		public ICollection<TValue> Values
		{
			get { return inner.Values; }
		}

		/// <summary>
		/// Gets the value associated with the specified key
		/// </summary>
		/// <param name="key"></param>
		/// <returns></returns>
		public TValue this[TKey key]
		{
			get { return inner[key]; }
			set
			{
				throw new NotSupportedException(Properties.Resources.DictionaryIsReadOnly);
			}
		}

		#endregion

		#region ICollection<KeyValuePair<TKey,TValue>> Members

		/// <summary>
		/// See <see cref="ICollection{TValue}.Add"/> for more information.
		/// </summary>
		void ICollection<KeyValuePair<TKey, TValue>>.Add(KeyValuePair<TKey, TValue> item)
		{
			throw new NotSupportedException(Properties.Resources.DictionaryIsReadOnly);
		}

		/// <summary>
		/// See <see cref="ICollection{TValue}.Clear"/> for more information.
		/// </summary>
		void ICollection<KeyValuePair<TKey, TValue>>.Clear()
		{
			throw new NotSupportedException(Properties.Resources.DictionaryIsReadOnly);
		}

		/// <summary>
		/// See <see cref="ICollection{TValue}.Contains"/> for more information.
		/// </summary>
		bool ICollection<KeyValuePair<TKey, TValue>>.Contains(KeyValuePair<TKey, TValue> item)
		{
			return ((IDictionary<TKey, TValue>)inner).Contains(item);
		}

		/// <summary>
		/// See <see cref="ICollection{TValue}.CopyTo"/> for more information.
		/// </summary>
		void ICollection<KeyValuePair<TKey, TValue>>.CopyTo(KeyValuePair<TKey, TValue>[] array, int arrayIndex)
		{
			((IDictionary<TKey, TValue>)inner).CopyTo(array, arrayIndex);
		}

		/// <summary>
		/// Returns the number of elements in the <see cref="ReadOnlyDictionary{TKey,TValue}"/>
		/// </summary>
		public int Count
		{
			get { return inner.Count; }
		}

		/// <summary>
		/// See <see cref="ICollection{TValue}.IsReadOnly"/> for more information.
		/// </summary>
		bool ICollection<KeyValuePair<TKey, TValue>>.IsReadOnly
		{
			get { return true; }
		}

		/// <summary>
		/// See <see cref="ICollection{TValue}.Remove"/> for more information.
		/// </summary>
		bool ICollection<KeyValuePair<TKey, TValue>>.Remove(KeyValuePair<TKey, TValue> item)
		{
			throw new NotSupportedException(Properties.Resources.DictionaryIsReadOnly);
		}

		#endregion

		#region IEnumerable<KeyValuePair<TKey,TValue>> Members

		/// <summary>
		/// See <see cref="IEnumerable{TValue}.GetEnumerator"/> for more information.
		/// </summary>
		IEnumerator<KeyValuePair<TKey, TValue>> IEnumerable<KeyValuePair<TKey, TValue>>.GetEnumerator()
		{
			return inner.GetEnumerator();
		}

		#endregion

		#region IEnumerable Members

		/// <summary>
		/// See <see cref="IEnumerable.GetEnumerator"/> for more information.
		/// </summary>
		IEnumerator IEnumerable.GetEnumerator()
		{
			return ((IEnumerable)inner).GetEnumerator();
		}

		#endregion
	}
}
