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
using System.Globalization;
using Microsoft.Practices.CompositeUI.Utility;
using Microsoft.Practices.ObjectBuilder;
using Microsoft.Practices.CompositeUI.Commands;
using Microsoft.Practices.CompositeUI.EventBroker;

namespace Microsoft.Practices.CompositeUI.Collections
{
	/// <summary>
	/// Represents a filtered collection of objects, based on the locator used by the <see cref="WorkItem"/>.
	/// </summary>
	public class ManagedObjectCollection<TItem> : ICollection, IEnumerable<KeyValuePair<string, TItem>>
	{
		private ILifetimeContainer container;
		private IReadWriteLocator locator;
		private IBuilder<BuilderStage> builder;
		private SearchMode searchMode;
		private IndexerCreationDelegate indexerCreationDelegate;
		private Predicate<TItem> filter;
		private ManagedObjectCollection<TItem> parentCollection;
		private WorkItem workItem;

		/// <summary>
		/// The delegate used for auto-creation of an item when not present, but indexed.
		/// </summary>
		/// <param name="t">The type being asked for.</param>
		/// <param name="id">The ID being asked for.</param>
		/// <returns></returns>
		public delegate TItem IndexerCreationDelegate(Type t, string id);

		/// <summary>
		/// Initializes an instance of the <see cref="ManagedObjectCollection{TItem}"/> class.
		/// </summary>
		public ManagedObjectCollection(ILifetimeContainer container, IReadWriteLocator locator,
			IBuilder<BuilderStage> builder, SearchMode searchMode, IndexerCreationDelegate indexerCreationDelegate,
			Predicate<TItem> filter)
			: this(container, locator, builder, searchMode, indexerCreationDelegate, filter, null)
		{
		}

		/// <summary>
		/// Initializes an instance of the <see cref="ManagedObjectCollection{TItem}"/> class.
		/// </summary>
		public ManagedObjectCollection(ILifetimeContainer container, IReadWriteLocator locator,
			IBuilder<BuilderStage> builder, SearchMode searchMode, IndexerCreationDelegate indexerCreationDelegate,
			Predicate<TItem> filter, ManagedObjectCollection<TItem> parentCollection)
		{
			this.container = container;
			this.locator = locator;
			this.builder = builder;
			this.searchMode = searchMode;
			this.indexerCreationDelegate = indexerCreationDelegate;
			this.filter = filter;
			this.parentCollection = parentCollection;
			this.workItem = locator.Get<WorkItem>(new DependencyResolutionLocatorKey(typeof(WorkItem), null));

			if (this.workItem != null)
			{
				this.workItem.ObjectAdded += new EventHandler<DataEventArgs<object>>(WorkItem_ItemAdded);
				this.workItem.ObjectRemoved += new EventHandler<DataEventArgs<object>>(WorkItem_ItemRemoved);
			}
		}

		/// <summary>
		/// Event that's fired when an object is added to the collection.
		/// </summary>
		public event EventHandler<DataEventArgs<TItem>> Added;

		/// <summary>
		/// Event that's fired when an object is removed from the collection, or disposed when the
		/// collection is cleaning up.
		/// </summary>
		public event EventHandler<DataEventArgs<TItem>> Removed;

		/// <summary>
		/// Gets an item by ID.
		/// </summary>
		/// <param name="id">The ID of the item to get.</param>
		/// <returns>The item, if present; null otherwise. If the collection has been given an
		/// <see cref="IndexerCreationDelegate"/> and the item is not found, it will be created
		/// using the delegate.</returns>
		public TItem this[string id]
		{
			get
			{
				TItem result = Get(id);

				if ((object)result == null && indexerCreationDelegate != null && !Contains(id, searchMode, false))
				{
					result = indexerCreationDelegate(typeof(TItem), id);
					Add(result, id);
				}

				return result;
			}
		}

		/// <summary>
		/// Gets the number of items in the collection.
		/// </summary>
		public int Count
		{
			get
			{
				int result = 0;

				foreach (KeyValuePair<object, object> pair in locator)
				{
					DependencyResolutionLocatorKey key = pair.Key as DependencyResolutionLocatorKey;

					if (key != null && key.ID != null && pair.Value is TItem && PassesFilter(pair.Value))
						result++;
				}

				if (searchMode == SearchMode.Up && parentCollection != null)
					result += parentCollection.Count;

				return result;
			}
		}

		/// <summary>
		/// Adds an item to the collection, without an ID.
		/// </summary>
		/// <param name="item">The item to be added.</param>
		public void Add(TItem item)
		{
			Add(item, null);
		}

		/// <summary>
		/// Adds an item to the collection, with an ID.
		/// </summary>
		/// <param name="item">The item to be added.</param>
		/// <param name="id">The ID of the item.</param>
		public void Add(TItem item, string id)
		{
			Guard.ArgumentNotNull(item, "item");

			Build(item.GetType(), id, item);
		}

		/// <summary>
		/// Creates a new item and adds it to the collection, without an ID.
		/// </summary>
		/// <param name="typeToBuild">The type of item to be built.</param>
		/// <returns>The newly created item.</returns>
		public TItem AddNew(Type typeToBuild)
		{
			return AddNew(typeToBuild, null);
		}

		/// <summary>
		/// Creates a new item and adds it to the collection, with an ID.
		/// </summary>
		/// <param name="typeToBuild">The type of item to be built.</param>
		/// <param name="id">The ID of the item.</param>
		/// <returns>The newly created item.</returns>
		public TItem AddNew(Type typeToBuild, string id)
		{
			return Build(typeToBuild, id, null);
		}

		/// <summary>
		/// Creates a new item and adds it to the collection, without an ID.
		/// </summary>
		/// <typeparam name="TTypeToBuild">The type of item to be built.</typeparam>
		/// <returns>The newly created item.</returns>
		public TTypeToBuild AddNew<TTypeToBuild>()
			where TTypeToBuild : TItem
		{
			return (TTypeToBuild)AddNew(typeof(TTypeToBuild), null);
		}

		/// <summary>
		/// Creates a new item and adds it to the collection, with an ID.
		/// </summary>
		/// <typeparam name="TTypeToBuild">The type of item to be built.</typeparam>
		/// <param name="id">The ID of the item.</param>
		/// <returns>The newly created item.</returns>
		public TTypeToBuild AddNew<TTypeToBuild>(string id)
			where TTypeToBuild : TItem
		{
			return (TTypeToBuild)AddNew(typeof(TTypeToBuild), id);
		}

		/// <summary>
		/// Determines if the collection contains an object with the given ID.
		/// </summary>
		/// <param name="id">The ID of the object.</param>
		/// <returns>Returns true if the collection contains the object; false otherwise.</returns>
		public bool Contains(string id)
		{
			return Get(id) != null;
		}

		private bool Contains(string id, SearchMode searchMode, bool filtered)
		{
			return Get(id, searchMode, filtered) != null;
		}

		/// <summary>
		/// Determines if the collection contains an object.
		/// </summary>
		/// <param name="item">The object.</param>
		/// <returns>Returns true if the collection contains the object; false otherwise.</returns>
		public bool ContainsObject(TItem item)
		{
			return container.Contains(item);
		}

		/// <summary>
		/// Finds all objects that are type-compatible with the given type.
		/// </summary>
		/// <typeparam name="TSearchType">The type of item to find.</typeparam>
		/// <returns>A collection of the found items.</returns>
		public ICollection<TSearchType> FindByType<TSearchType>()
			where TSearchType : TItem
		{
			List<TSearchType> result = new List<TSearchType>();

			foreach (object obj in container)
				if (typeof(TSearchType).IsAssignableFrom(obj.GetType()))
					result.Add((TSearchType)obj);

			if (searchMode == SearchMode.Up && parentCollection != null)
				result.AddRange(parentCollection.FindByType<TSearchType>());

			return result;
		}

		/// <summary>
		/// Finds all objects that are type-compatible with the given type.
		/// </summary>
		/// <param name="searchType">The type of item to find.</param>
		/// <returns>A collection of the found items.</returns>
		public ICollection<TItem> FindByType(Type searchType)
		{
			List<TItem> result = new List<TItem>();

			foreach (object obj in container)
				if (searchType.IsAssignableFrom(obj.GetType()))
					result.Add((TItem)obj);

			if (searchMode == SearchMode.Up && parentCollection != null)
				result.AddRange(parentCollection.FindByType(searchType));

			return result;
		}

		/// <summary>
		/// Gets the object with the given ID.
		/// </summary>
		/// <param name="id">The ID to get.</param>
		/// <returns>The object, if present; null otherwise.</returns>
		public TItem Get(string id)
		{
			return Get(id, searchMode, true);
		}

		private TItem Get(string id, SearchMode searchMode, bool filtered)
		{
			Guard.ArgumentNotNull(id, "id");

			foreach (KeyValuePair<object, object> pair in locator)
			{
				if (pair.Key is DependencyResolutionLocatorKey)
				{
					DependencyResolutionLocatorKey depKey = (DependencyResolutionLocatorKey)pair.Key;

					if (object.Equals(depKey.ID, id))
					{
						TItem result = (TItem)pair.Value;
						if (!filtered || filter == null || filter(result))
							return result;
					}
				}
			}

			if (searchMode == SearchMode.Up && parentCollection != null)
				return parentCollection.Get(id);

			return default(TItem);
		}

		/// <summary>
		/// Gets the object with the given ID.
		/// </summary>
		/// <typeparam name="TTypeToGet">The type of the object to get.</typeparam>
		/// <param name="id">The ID to get.</param>
		/// <returns>The object, if present; null otherwise.</returns>
		public TTypeToGet Get<TTypeToGet>(string id)
			where TTypeToGet : TItem
		{
			return (TTypeToGet)Get(id);
		}

		/// <summary>
		/// Removes an object from the container.
		/// </summary>
		/// <param name="item">The item to be removed.</param>
		public void Remove(TItem item)
		{
			if (container.Contains(item))
			{
				ThrowIfItemRemovalIsNotPermitted(item);

				builder.TearDown(locator, item);
				container.Remove(item);

				List<object> keysToRemove = new List<object>();

				foreach (KeyValuePair<object, object> pair in locator)
					if (pair.Value.Equals(item))
						keysToRemove.Add(pair.Key);

				foreach (object key in keysToRemove)
					locator.Remove(key);
			}
		}

		private static void ThrowIfItemRemovalIsNotPermitted(TItem item)
		{
			if (item is WorkItem)
				throw new ArgumentException(Properties.Resources.NoRemoveWorkItemFromManagedObjectCollection, "item");

			if (item is Command)
			{
				Command cmd = item as Command;
				throw new ArgumentException(String.Format(CultureInfo.CurrentCulture,
						Properties.Resources.RemoveCommandFromWorkItemIsNotPermitted, cmd.Name), "item");
			}

			if (item is EventTopic)
			{
				EventTopic topic = item as EventTopic;
				throw new ArgumentException(String.Format(CultureInfo.CurrentCulture,
						Properties.Resources.RemoveEventTopicFromWorkItemIsNotPermitted, topic.Name), "item");
			}
		}

		private TItem Build(Type typeToBuild, string idToBuild, object item)
		{
			if (idToBuild != null && Contains(idToBuild, SearchMode.Local, true))
				throw new ArgumentException(String.Format(CultureInfo.CurrentCulture, Properties.Resources.DuplicateID, idToBuild));

			if (item != null && Object.ReferenceEquals(item, locator.Get(new DependencyResolutionLocatorKey(typeof(WorkItem), null))))
				throw new ArgumentException(Properties.Resources.CannotAddWorkItemToItself, "item");

			if (item == null)
				item = BuildFirstTimeItem(typeToBuild, idToBuild, null);
			else if (!container.Contains(item))
				item = BuildFirstTimeItem(typeToBuild, idToBuild, item);
			else
				BuildRepeatedItem(typeToBuild, idToBuild, item);

			return (TItem)item;
		}

		/// <summary>
		/// Used to build a first time item (either an existing one or a new one). The Builder will
		/// end up locating it, and we add it to the container.
		/// </summary>
		private object BuildFirstTimeItem(Type typeToBuild, string idToBuild, object item)
		{
			return builder.BuildUp(locator, typeToBuild, NormalizeID(idToBuild), item);
		}

		/// <summary>
		/// Used to "build" an item we've already seen once. We don't use the builder, because that
		/// would do double-injection. Since it's already in the lifetime container, all we need to
		/// do is add a second locator registration for it for the right name.
		/// </summary>
		private void BuildRepeatedItem(Type typeToBuild, string idToBuild, object item)
		{
			locator.Add(new DependencyResolutionLocatorKey(typeToBuild, NormalizeID(idToBuild)), item);
		}

		/// <summary>
		/// Gets an enumerator which returns all the objects in the container, along with their
		/// names.
		/// </summary>
		/// <returns>The enumerator.</returns>
		public IEnumerator<KeyValuePair<string, TItem>> GetEnumerator()
		{
			IReadableLocator currentLocator = locator;
			Dictionary<string, object> seenNames = new Dictionary<string, object>();

			do
			{
				foreach (KeyValuePair<object, object> pair in currentLocator)
					if (pair.Key is DependencyResolutionLocatorKey)
					{
						DependencyResolutionLocatorKey depKey = (DependencyResolutionLocatorKey)pair.Key;

						if (depKey.ID != null && pair.Value is TItem)
						{
							string id = depKey.ID;
							TItem value = (TItem)pair.Value;

							if (!seenNames.ContainsKey(id) && (filter == null || filter(value)))
							{
								seenNames[id] = String.Empty;
								yield return new KeyValuePair<string, TItem>(id, value);
							}
						}
					}
			}
			while (searchMode == SearchMode.Up && (currentLocator = currentLocator.ParentLocator) != null);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		private bool PassesFilter(object item)
		{
			if (filter != null)
				return filter((TItem)item);
			else
				return true;
		}

		private string NormalizeID(string idToBuild)
		{
			return idToBuild ?? Guid.NewGuid().ToString();
		}

		private void WorkItem_ItemAdded(object sender, DataEventArgs<object> e)
		{
			if (Added != null && e.Data is TItem)
			{
				TItem value = (TItem)e.Data;
				DependencyResolutionLocatorKey key = FindObjectInLocator(value);

				if (key != null && key.ID != null && PassesFilter(value))
					Added(this, new DataEventArgs<TItem>(value));
			}
		}

		private void WorkItem_ItemRemoved(object sender, DataEventArgs<object> e)
		{
			if (Removed != null && e.Data is TItem)
			{
				TItem value = (TItem)e.Data;
				DependencyResolutionLocatorKey key = FindObjectInLocator(value);

				if (key != null && key.ID != null && PassesFilter(value))
					Removed(this, new DataEventArgs<TItem>(value));
			}
		}

		private DependencyResolutionLocatorKey FindObjectInLocator(object value)
		{
			foreach (KeyValuePair<object, object> pair in locator)
				if (pair.Key is DependencyResolutionLocatorKey && pair.Value == value)
					return ((DependencyResolutionLocatorKey)pair.Key);

			return null;
		}

		void ICollection.CopyTo(Array array, int index)
		{
			throw new NotImplementedException();
		}

		int ICollection.Count
		{
			get { return Count; }
		}

		bool ICollection.IsSynchronized
		{
			get { return false; }
		}

		object ICollection.SyncRoot
		{
			get { throw new NotImplementedException(); }
		}
	}
}
