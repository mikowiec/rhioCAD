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
using Microsoft.Practices.CompositeUI.Services;
using Microsoft.Practices.CompositeUI.Utility;
using Microsoft.Practices.ObjectBuilder;
using System.Collections;
using System.Globalization;

namespace Microsoft.Practices.CompositeUI.Collections
{
	/// <summary>
	/// Collection of services that are contained in a <see cref="WorkItem"/>.
	/// </summary>
	public class ServiceCollection : ICollection, IEnumerable<KeyValuePair<Type, object>>
	{
		private IBuilder<BuilderStage> builder;
		private IReadWriteLocator locator;
		private ILifetimeContainer container;
		private ServiceCollection parent;

		/// <summary>
		/// Initializes an instance of the <see cref="ServiceCollection"/> class.
		/// </summary>
		/// <param name="container">The lifetime container the collection will use</param>
		/// <param name="locator">The locator the collection will use</param>
		/// <param name="builder">The builder the collection will use</param>
		/// <param name="parent">The parent collection</param>
		public ServiceCollection(ILifetimeContainer container, IReadWriteLocator locator, IBuilder<BuilderStage> builder, ServiceCollection parent)
		{
			this.builder = builder;
			this.container = container;
			this.locator = locator;
			this.parent = parent;
		}

		/// <summary>
		/// Fired whenever a new service is added to the container. For demand-add services, the event is
		/// fired when the service is eventually created.
		/// </summary>
		public event EventHandler<DataEventArgs<object>> Added;

		/// <summary>
		/// Fired whenever a service is removed from the container. When the services collection is disposed,
		/// the Removed event is not fired for the services in the container.
		/// </summary>
		public event EventHandler<DataEventArgs<object>> Removed;

		/// <summary>
		/// Adds a service.
		/// </summary>
		/// <typeparam name="TService">The type under which to register the service.</typeparam>
		/// <param name="serviceInstance">The service to register.</param>
		/// <exception cref="ArgumentNullException">serviceInstance is null.</exception>
		/// <exception cref="ArgumentException">A service of the given type is already registered.</exception>
		public void Add<TService>(TService serviceInstance)
		{
			Add(typeof(TService), serviceInstance);
		}

		/// <summary>
		/// Adds a service.
		/// </summary>
		/// <param name="serviceType">The type under which to register the service.</param>
		/// <param name="serviceInstance">The service to register.</param>
		/// <exception cref="ArgumentNullException">serviceInstance is null.</exception>
		/// <exception cref="ArgumentException">A service of the given type is already registered.</exception>
		public void Add(Type serviceType, object serviceInstance)
		{
			Guard.ArgumentNotNull(serviceType, "serviceType");
			Guard.ArgumentNotNull(serviceInstance, "serviceInstance");

			Build(serviceInstance.GetType(), serviceType, serviceInstance);
		}

		/// <summary>
		/// Adds a service that will not be created until the first time it is requested.
		/// </summary>
		/// <typeparam name="TService">The type of service</typeparam>
		public void AddOnDemand<TService>()
		{
			AddOnDemand(typeof(TService), null);
		}

		/// <summary>
		/// Adds a service that will not be created until the first time it is requested.
		/// </summary>
		/// <typeparam name="TService">The type of service</typeparam>
		/// <typeparam name="TRegisterAs">The type to register the service as</typeparam>
		public void AddOnDemand<TService, TRegisterAs>()
		{
			AddOnDemand(typeof(TService), typeof(TRegisterAs));
		}

		/// <summary>
		/// Adds a service that will not be created until the first time it is requested.
		/// </summary>
		/// <param name="serviceType">The type of service</param>
		public void AddOnDemand(Type serviceType)
		{
			AddOnDemand(serviceType, null);
		}

		/// <summary>
		/// Adds a service that will not be created until the first time it is requested.
		/// </summary>
		/// <param name="serviceType">The type of service</param>
		/// <param name="registerAs">The type to register the service as</param>
		public void AddOnDemand(Type serviceType, Type registerAs)
		{
			Guard.ArgumentNotNull(serviceType, "serviceType");

			if (registerAs == null)
				registerAs = serviceType;

			DependencyResolutionLocatorKey key = new DependencyResolutionLocatorKey(registerAs, null);
			if (locator.Contains(key, SearchMode.Local))
				throw new ArgumentException(String.Format(CultureInfo.CurrentCulture, Properties.Resources.DuplicateService, registerAs.FullName));

			DemandAddPlaceholder placeholder = new DemandAddPlaceholder(serviceType);
			locator.Add(key, placeholder);
			container.Add(placeholder);
		}

		/// <summary>
		/// Creates and adds a service.
		/// </summary>
		/// <typeparam name="TService">The type of the service to create. This type is also
		/// the type the service is registered under.</typeparam>
		/// <returns>The new service instance.</returns>
		/// <exception cref="ArgumentException">Object builder cannot find an appropriate
		/// constructor on the object.</exception>
		public TService AddNew<TService>()
		{
			return AddNew<TService, TService>();
		}

		/// <summary>
		/// Creates a service.
		/// </summary>
		/// <typeparam name="TService">The type of the service to create.</typeparam>
		/// <typeparam name="TRegisterAs">The type the service is registered under.</typeparam>
		/// <returns>The new service instance.</returns>
		/// <exception cref="ArgumentException">Object builder cannot find an appropriate
		/// constructor on the object.</exception>
		public TService AddNew<TService, TRegisterAs>()
			where TService : TRegisterAs
		{
			return (TService)AddNew(typeof(TService), typeof(TRegisterAs));
		}

		/// <summary>
		/// Creates a service.
		/// </summary>
		/// <param name="serviceType">The type of the service to create. This type is also
		/// the type the service is registered under.</param>
		/// <returns>The new service instance.</returns>
		/// <exception cref="ArgumentException">Object builder cannot find an appropriate
		/// constructor on the object.</exception>
		public object AddNew(Type serviceType)
		{
			return AddNew(serviceType, serviceType);
		}

		/// <summary>
		/// Creates a service.
		/// </summary>
		/// <param name="serviceType">The type of the service to create.</param>
		/// <param name="registerAs">The type the service is registered under.</param>
		/// <returns>The new service instance.</returns>
		/// <exception cref="ArgumentException">Object builder cannot find an appropriate
		/// constructor on the object.</exception>
		public object AddNew(Type serviceType, Type registerAs)
		{
			Guard.ArgumentNotNull(serviceType, "serviceType");
			Guard.ArgumentNotNull(registerAs, "registerAs");

			return Build(serviceType, registerAs, null);
		}

		/// <summary>
		/// Determines whether the given service type exists in the collection.
		/// </summary>
		/// <typeparam name="TService">Type of service to search for.</typeparam>
		/// <returns>
		/// true if the TService exists; 
		/// false otherwise.
		/// </returns>
		public bool Contains<TService>()
		{
			return Contains(typeof(TService));
		}

		/// <summary>
		/// Determines whether the given service type exists in the collection.
		/// </summary>
		/// <param name="serviceType">Type of service to search for.</param>
		/// <returns>
		/// true if the serviceType exists; 
		/// false otherwise.
		/// </returns>
		public bool Contains(Type serviceType)
		{
			return Contains(serviceType, SearchMode.Up);
		}

		private bool Contains(Type serviceType, SearchMode searchMode)
		{
			Guard.ArgumentNotNull(serviceType, "serviceType");

			return locator.Contains(new DependencyResolutionLocatorKey(serviceType, null), searchMode);
		}

		/// <summary>
		/// Determines whether the given service type exists directly in the local collection. The parent
		/// collections are not consulted.
		/// </summary>
		/// <param name="serviceType">Type of service to search for.</param>
		/// <returns>
		/// true if the serviceType exists; 
		/// false otherwise.
		/// </returns>
		public bool ContainsLocal(Type serviceType)
		{
			return Contains(serviceType, SearchMode.Local);
		}

		/// <summary>
		/// Gets a service.
		/// </summary>
		/// <typeparam name="TService">The type of the service to be found.</typeparam>
		/// <returns>The service instance, if present; null otherwise.</returns>
		public TService Get<TService>()
		{
			return (TService)Get(typeof(TService), false);
		}

		/// <summary>
		/// Gets a service.
		/// </summary>
		/// <typeparam name="TService">The type of the service to be found.</typeparam>
		/// <param name="ensureExists">If true, will throw an exception if the service is not found.</param>
		/// <returns>The service instance, if present; null if not (and ensureExists is false).</returns>
		/// <exception cref="ServiceMissingException">Thrown if ensureExists is true and the service is not found.</exception>
		public TService Get<TService>(bool ensureExists)
		{
			return (TService)Get(typeof(TService), ensureExists);
		}

		/// <summary>
		/// Gets a service.
		/// </summary>
		/// <param name="serviceType">The type of the service to be found.</param>
		/// <returns>The service instance, if present; null otherwise.</returns>
		public object Get(Type serviceType)
		{
			return Get(serviceType, false);
		}

		/// <summary>
		/// Gets a service.
		/// </summary>
		/// <param name="serviceType">The type of the service to be found.</param>
		/// <param name="ensureExists">If true, will throw an exception if the service is not found.</param>
		/// <returns>The service instance, if present; null if not (and ensureExists is false).</returns>
		/// <exception cref="ServiceMissingException">Thrown if ensureExists is true and the service is not found.</exception>
		public object Get(Type serviceType, bool ensureExists)
		{
			Guard.ArgumentNotNull(serviceType, "serviceType");

			if (Contains(serviceType, SearchMode.Local))
			{
				object result = locator.Get(new DependencyResolutionLocatorKey(serviceType, null));

				DemandAddPlaceholder placeholder = result as DemandAddPlaceholder;

				if (placeholder != null)
				{
					Remove(serviceType);
					result = Build(placeholder.TypeToCreate, serviceType, null);
				}

				return result;
			}

			if (parent != null)
				return parent.Get(serviceType, ensureExists);

			if (ensureExists)
				throw new ServiceMissingException(serviceType);

			return null;
		}

		/// <summary>
		/// Removes a service registration from the <see cref="WorkItem"/>.
		/// </summary>
		/// <typeparam name="TService">The service type to remove.</typeparam>
		public void Remove<TService>()
		{
			Remove(typeof(TService));
		}

		/// <summary>
		/// Removes a service registration from the <see cref="WorkItem"/>.
		/// </summary>
		/// <param name="serviceType">The service type to remove.</param>
		public void Remove(Type serviceType)
		{
			Guard.ArgumentNotNull(serviceType, "serviceType");
			DependencyResolutionLocatorKey key = new DependencyResolutionLocatorKey(serviceType, null);

			if (locator.Contains(key, SearchMode.Local))
			{
				object serviceInstance = locator.Get(key, SearchMode.Local);
				bool isLastInstance = true;

				locator.Remove(new DependencyResolutionLocatorKey(serviceType, null));

				foreach (KeyValuePair<object, object> kvp in locator)
				{
					if (ReferenceEquals(kvp.Value, serviceInstance))
					{
						isLastInstance = false;
						break;
					}
				}

				if (isLastInstance)
				{
					builder.TearDown(locator, serviceInstance);
					container.Remove(serviceInstance);

					if (!(serviceInstance is DemandAddPlaceholder))
						OnRemoved(serviceInstance);
				}
			}
		}

		/// <summary>
		/// Called when a new service is added to the collection.
		/// </summary>
		/// <param name="service">The service that was added.</param>
		protected virtual void OnAdded(object service)
		{
			if (Added != null)
			{
				Added(this, new DataEventArgs<object>(service));
			}
		}

		/// <summary>
		/// Called when a service is removed from the collection.
		/// </summary>
		/// <param name="service">The service that was removed.</param>
		protected virtual void OnRemoved(object service)
		{
			if (Removed != null)
			{
				Removed(this, new DataEventArgs<object>(service));
			}
		}

		private object Build(Type typeToBuild, Type typeToRegisterAs, object serviceInstance)
		{
			Guard.TypeIsAssignableFromType(typeToBuild, typeToRegisterAs, "typeToBuild");

			if (locator.Contains(new DependencyResolutionLocatorKey(typeToRegisterAs, null), SearchMode.Local))
				throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, Properties.Resources.DuplicateService, typeToRegisterAs.FullName));

			if (serviceInstance == null)
				serviceInstance = BuildFirstTimeItem(typeToBuild, typeToRegisterAs, null);
			else if (!container.Contains(serviceInstance))
				serviceInstance = BuildFirstTimeItem(typeToBuild, typeToRegisterAs, serviceInstance);
			else
				BuildRepeatedItem(typeToRegisterAs, serviceInstance);

			return serviceInstance;
		}

		/// <summary>
		/// Used to build a first time item (either an existing one or a new one). The Builder will
		/// end up locating it, and we add it to the container.
		/// </summary>
		private object BuildFirstTimeItem(Type typeToBuild, Type typeToRegisterAs, object item)
		{
			item = builder.BuildUp(locator, typeToBuild, null, item);

			if (typeToRegisterAs != typeToBuild)
			{
				locator.Add(new DependencyResolutionLocatorKey(typeToRegisterAs, null), item);
				locator.Remove(new DependencyResolutionLocatorKey(typeToBuild, null));
			}

			OnAdded(item);
			return item;
		}

		/// <summary>
		/// Used to "build" an item we've already seen once. We don't use the builder, because that
		/// would do double-injection. Since it's already in the lifetime container, all we need to
		/// do is add a second locator registration for it for the right name.
		/// </summary>
		private void BuildRepeatedItem(Type typeToRegisterAs, object item)
		{
			locator.Add(new DependencyResolutionLocatorKey(typeToRegisterAs, null), item);
		}

		private class DemandAddPlaceholder
		{
			Type typeToCreate;

			public DemandAddPlaceholder(Type typeToCreate)
			{
				this.typeToCreate = typeToCreate;
			}

			public Type TypeToCreate
			{
				get { return typeToCreate; }
			}
		}

		/// <summary>
		/// Enumerates through all seen types and retrieves a KeyValuePair for each. 
		/// </summary>
		/// <returns></returns>
		public IEnumerator<KeyValuePair<Type, object>> GetEnumerator()
		{
			IReadableLocator currentLocator = locator;
			Dictionary<Type, object> seenTypes = new Dictionary<Type, object>();

			do
			{
				foreach (KeyValuePair<object, object> pair in currentLocator)
					if (pair.Key is DependencyResolutionLocatorKey)
					{
						DependencyResolutionLocatorKey depKey = (DependencyResolutionLocatorKey)pair.Key;

						if (depKey.ID == null)
						{
							Type type = depKey.Type;

							if (!seenTypes.ContainsKey(type))
							{
								seenTypes[type] = String.Empty;
								yield return new KeyValuePair<Type, object>(type, pair.Value);
							}
						}
					}
			}
			while ((currentLocator = currentLocator.ParentLocator) != null);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		void ICollection.CopyTo(Array array, int index)
		{
			throw new NotImplementedException();
		}

		int ICollection.Count
		{
			get { throw new NotImplementedException(); }
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
