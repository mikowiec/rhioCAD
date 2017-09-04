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
using Microsoft.Practices.CompositeUI.Utility;

namespace Microsoft.Practices.CompositeUI.Utility
{
	/// <summary>
	/// A dictionary of lists.
	/// </summary>
	/// <typeparam name="TKey">The key to use for lists.</typeparam>
	/// <typeparam name="TValue">The type of the value held by lists.</typeparam>
	public class ListDictionary<TKey, TValue> : IDictionary<TKey, List<TValue>>
	{
		Dictionary<TKey, List<TValue>> innerValues = new Dictionary<TKey, List<TValue>>();

		#region Public Methods

		/// <summary>
		/// If a list does not already exist, it will be created automatically.
		/// </summary>
		/// <param name="key">The key of the list that will hold the value.</param>
		public void Add(TKey key)
		{
			Guard.ArgumentNotNull(key, "key");

			CreateNewList(key);
		}

		/// <summary>
		/// Adds a value to a list with the given key. If a list does not already exist, 
		/// it will be created automatically.
		/// </summary>
		/// <param name="key">The key of the list that will hold the value.</param>
		/// <param name="value">The value to add to the list under the given key.</param>
		public void Add(TKey key, TValue value)
		{
			Guard.ArgumentNotNull(key, "key");
			Guard.ArgumentNotNull(value, "value");

			if (innerValues.ContainsKey(key))
			{
				innerValues[key].Add(value);
			}
			else
			{
				List<TValue> values = CreateNewList(key);
				values.Add(value);
			}
		}

		private List<TValue> CreateNewList(TKey key)
		{
			List<TValue> values = new List<TValue>();
			innerValues.Add(key, values);

			return values;
		}

		/// <summary>
		/// Removes all entries in the dictionary.
		/// </summary>
		public void Clear()
		{
			innerValues.Clear();
		}

		/// <summary>
		/// Determines whether the dictionary contains the specified value.
		/// </summary>
		/// <param name="value">The value to locate.</param>
		/// <returns>true if the dictionary contains the value in any list; otherwise, false.</returns>
		public bool ContainsValue(TValue value)
		{
			foreach (KeyValuePair<TKey, List<TValue>> pair in innerValues)
			{
				if (pair.Value.Contains(value))
				{
					return true;
				}
			}

			return false;
		}

		/// <summary>
		/// Determines whether the dictionary contains the given key.
		/// </summary>
		/// <param name="key">The key to locate.</param>
		/// <returns>true if the dictionary contains the given key; otherwise, false.</returns>
		public bool ContainsKey(TKey key)
		{
			Guard.ArgumentNotNull(key, "key");
			return innerValues.ContainsKey(key);
		}

		/// <summary>
		/// Retrieves the all the elements from the list which have a key that matches the condition 
		/// defined by the specified predicate.
		/// </summary>
		/// <param name="keyFilter">The filter with the condition to use to filter lists by their key.</param>
		/// <returns></returns>
		public IEnumerable<TValue> FindAllValuesByKey(Predicate<TKey> keyFilter)
		{
			foreach (KeyValuePair<TKey, List<TValue>> pair in this)
			{
				if (keyFilter(pair.Key))
				{
					foreach (TValue value in pair.Value)
					{
						yield return value;
					}
				}
			}
		}

		/// <summary>
		/// Retrieves all the elements that match the condition defined by the specified predicate.
		/// </summary>
		/// <param name="valueFilter">The filter with the condition to use to filter values.</param>
		/// <returns></returns>
		public IEnumerable<TValue> FindAllValues(Predicate<TValue> valueFilter)
		{
			foreach (KeyValuePair<TKey, List<TValue>> pair in this)
			{
				foreach (TValue value in pair.Value)
				{
					if (valueFilter(value))
					{
						yield return value;
					}
				}
			}
		}

		/// <summary>
		/// Removes a list by key.
		/// </summary>
		/// <param name="key">The key of the list to remove.</param>
		/// <returns></returns>
		public bool Remove(TKey key)
		{
			Guard.ArgumentNotNull(key, "key");
			return innerValues.Remove(key);
		}

		/// <summary>
		/// Removes a value from the list with the given key.
		/// </summary>
		/// <param name="key">The key of the list where the value exists.</param>
		/// <param name="value">The value to remove.</param>
		public void Remove(TKey key, TValue value)
		{
			Guard.ArgumentNotNull(key, "key");
			Guard.ArgumentNotNull(value, "value");

			if (innerValues.ContainsKey(key))
			{
				innerValues[key].RemoveAll(delegate(TValue item)
				{
					return value.Equals(item);
				});
			}
		}

		/// <summary>
		/// Removes a value from all lists where it may be found.
		/// </summary>
		/// <param name="value">The value to remove.</param>
		public void Remove(TValue value)
		{
			foreach (KeyValuePair<TKey, List<TValue>> pair in innerValues)
			{
				Remove(pair.Key, value);
			}
		}

		#endregion

		#region Properties

		/// <summary>
		/// Gets a shallow copy of all values in all lists.
		/// </summary>
		public List<TValue> Values
		{
			get
			{
				List<TValue> values = new List<TValue>();
				foreach (IEnumerable<TValue> list in innerValues.Values)
				{
					values.AddRange(list);
				}

				return values;
			}
		}

		/// <summary>
		/// Gets the list of keys in the dictionary.
		/// </summary>
		public ICollection<TKey> Keys
		{
			get { return innerValues.Keys; }
		}

		/// <summary>
		/// Gets or sets the list associated with the given key. The 
		/// access always succeeds, eventually returning an empty list.
		/// </summary>
		/// <param name="key">The key of the list to access.</param>
		/// <returns>The list associated with the key.</returns>
		public List<TValue> this[TKey key]
		{
			get
			{
				if (innerValues.ContainsKey(key) == false)
				{
					innerValues.Add(key, new List<TValue>());
				}
				return innerValues[key];
			}
			set { innerValues[key] = value; }
		}

		/// <summary>
		/// Gets the number of lists in the dictionary.
		/// </summary>
		public int Count
		{
			get { return innerValues.Count; }
		}

		#endregion

		#region IDictionary<TKey,List<TValue>> Members

		/// <summary>
		/// See <see cref="IDictionary{TKey,TValue}.Add"/> for more information.
		/// </summary>
		void IDictionary<TKey, List<TValue>>.Add(TKey key, List<TValue> value)
		{
			Guard.ArgumentNotNull(key, "key");
			Guard.ArgumentNotNull(value, "value");
			innerValues.Add(key, value);
		}

		/// <summary>
		/// See <see cref="IDictionary{TKey,TValue}.TryGetValue"/> for more information.
		/// </summary>
		bool IDictionary<TKey, List<TValue>>.TryGetValue(TKey key, out List<TValue> value)
		{
			value = this[key];
			return true;
		}

		/// <summary>
		/// See <see cref="IDictionary{TKey,TValue}.Values"/> for more information.
		/// </summary>
		ICollection<List<TValue>> IDictionary<TKey, List<TValue>>.Values
		{
			get { return innerValues.Values; }
		}

		#endregion

		#region ICollection<KeyValuePair<TKey,List<TValue>>> Members

		/// <summary>
		/// See <see cref="ICollection{TValue}.Add"/> for more information.
		/// </summary>
		void ICollection<KeyValuePair<TKey, List<TValue>>>.Add(KeyValuePair<TKey, List<TValue>> item)
		{
			((ICollection<KeyValuePair<TKey, List<TValue>>>)innerValues).Add(item);
		}

		/// <summary>
		/// See <see cref="ICollection{TValue}.Contains"/> for more information.
		/// </summary>
		bool ICollection<KeyValuePair<TKey, List<TValue>>>.Contains(KeyValuePair<TKey, List<TValue>> item)
		{
			return ((ICollection<KeyValuePair<TKey, List<TValue>>>)innerValues).Contains(item);
		}

		/// <summary>
		/// See <see cref="ICollection{TValue}.CopyTo"/> for more information.
		/// </summary>
		void ICollection<KeyValuePair<TKey, List<TValue>>>.CopyTo(KeyValuePair<TKey, List<TValue>>[] array, int arrayIndex)
		{
			((ICollection<KeyValuePair<TKey, List<TValue>>>)innerValues).CopyTo(array, arrayIndex);
		}

		/// <summary>
		/// See <see cref="ICollection{TValue}.IsReadOnly"/> for more information.
		/// </summary>
		bool ICollection<KeyValuePair<TKey, List<TValue>>>.IsReadOnly
		{
			get { return ((ICollection<KeyValuePair<TKey, List<TValue>>>)innerValues).IsReadOnly; }
		}

		/// <summary>
		/// See <see cref="ICollection{TValue}.Remove"/> for more information.
		/// </summary>
		bool ICollection<KeyValuePair<TKey, List<TValue>>>.Remove(KeyValuePair<TKey, List<TValue>> item)
		{
			return ((ICollection<KeyValuePair<TKey, List<TValue>>>)innerValues).Remove(item);
		}

		#endregion

		#region IEnumerable<KeyValuePair<TKey,List<TValue>>> Members

		/// <summary>
		/// See <see cref="IEnumerable{TValue}.GetEnumerator"/> for more information.
		/// </summary>
		IEnumerator<KeyValuePair<TKey, List<TValue>>> IEnumerable<KeyValuePair<TKey, List<TValue>>>.GetEnumerator()
		{
			return innerValues.GetEnumerator();
		}

		#endregion

		#region IEnumerable Members

		/// <summary>
		/// See <see cref="System.Collections.IEnumerable.GetEnumerator"/> for more information.
		/// </summary>
		System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			return innerValues.GetEnumerator();
		}

		#endregion
	}
}
