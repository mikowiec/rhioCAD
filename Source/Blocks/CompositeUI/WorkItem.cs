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
using System.Diagnostics;
using System.IO;
using System.Reflection;
using Microsoft.Practices.CompositeUI.BuilderStrategies;
using Microsoft.Practices.CompositeUI.Collections;
using Microsoft.Practices.CompositeUI.Commands;
using Microsoft.Practices.CompositeUI.EventBroker;
using Microsoft.Practices.CompositeUI.Properties;
using Microsoft.Practices.CompositeUI.Services;
using Microsoft.Practices.CompositeUI.SmartParts;
using Microsoft.Practices.CompositeUI.UIElements;
using Microsoft.Practices.CompositeUI.Utility;
using Microsoft.Practices.ObjectBuilder;
using System.ComponentModel;
using System.Globalization;
using System.Threading;

namespace Microsoft.Practices.CompositeUI
{
	/// <summary>
	/// Defines the work item into which smart parts run.
	/// </summary>
	public class WorkItem : IBuilderAware, IDisposable
	{
		#region Fields

		private Builder builder;
		private bool buildUpFinished = false;
		private ILifetimeContainer lifetime = new LifetimeContainer();
		private IReadWriteLocator locator;
		private WorkItem parent;
		private ListDictionary<object, ISmartPartInfo> smartPartInfos = new ListDictionary<object, ISmartPartInfo>();
		private State state;
		private WorkItemStatus status;

		private ManagedObjectCollection<Command> commandCollection;
		private ManagedObjectCollection<object> smartPartCollection;
		private ManagedObjectCollection<WorkItem> workItemCollection;
		private ManagedObjectCollection<IWorkspace> workspaceCollection;
		private ManagedObjectCollection<object> itemsCollection;
		private ManagedObjectCollection<EventTopic> eventTopicCollection;
		private ServiceCollection serviceCollection;
		private UIExtensionSiteCollection uiExtensionSiteCollection;

		private TraceSource traceSource = null;

		#endregion

		#region WorkItem Lifetime (ctor, Dispose, Initialize, etc.)

		/// <summary>
		/// Initializes a new instance of the <see cref="WorkItem"/> class.
		/// </summary>
		public WorkItem()
		{
		}

		/// <summary>
		/// Disposes the <see cref="WorkItem"/>.
		/// </summary>
		public void Dispose()
		{
			Dispose(true);
			GC.SuppressFinalize(this);
		}

		/// <summary>
		/// Runs the work item by calling the <see cref="OnRunStarted"/> method, 
		/// which will raise the <see cref="RunStarted"/> event and eventually 
		/// the custom starting business logic a derived class placed on it.
		/// </summary>
		public void Run()
		{
			OnRunStarted();
		}

		/// <summary>
		/// Initializes a root <see cref="WorkItem"/>. Intended to be called by the user who creates the
		/// first WorkItem using new. Subsequent child WorkItem classes are automatically initialized
		/// through dependency injection from their parent.
		/// </summary>
		/// <param name="builder">The <see cref="Builder"/> used to build objects.</param>
		protected internal void InitializeRootWorkItem(Builder builder)
		{
			this.builder = builder;
			this.locator = new Locator();

			InitializeFields();
			InitializeCollectionFacades();
			InitializeState();
		}

		/// <summary>
		/// Initializes the <see cref="WorkItem"/> after construction.
		/// This method is typically called by the parent <see cref="WorkItem"/> 
		/// during the process of building a new child <see cref="WorkItem"/>.
		/// </summary>
		[InjectionMethod]
		public void InitializeWorkItem()
		{
			if (buildUpFinished)
				throw new InvalidOperationException();

			InitializeFields();
			InitializeCollectionFacades();
			InitializeState();
			InitializeServices();
		}

		private void InitializeFields()
		{
			if (builder == null)
				builder = parent.builder;

			if (locator == null)
				locator = new Locator(parent.locator);

			if (!locator.Contains(typeof(ILifetimeContainer), SearchMode.Local))
				locator.Add(typeof(ILifetimeContainer), lifetime);

			ObjectBuiltNotificationPolicy policy = builder.Policies.Get<ObjectBuiltNotificationPolicy>(null, null);

			if (policy != null)
			{
				policy.AddedDelegates[this] = new ObjectBuiltNotificationPolicy.ItemNotification(OnObjectAdded);
				policy.RemovedDelegates[this] = new ObjectBuiltNotificationPolicy.ItemNotification(OnObjectRemoved);
			}

			LocateWorkItem(typeof(WorkItem));
			LocateWorkItem(GetType());

			status = WorkItemStatus.Inactive;
		}

		private void LocateWorkItem(Type workItemType)
		{
			DependencyResolutionLocatorKey key = new DependencyResolutionLocatorKey(workItemType, null);

			if (!locator.Contains(key, SearchMode.Local))
				locator.Add(key, this);
		}

		private void InitializeCollectionFacades()
		{
			if (serviceCollection == null)
			{
				serviceCollection = new ServiceCollection(lifetime, locator, builder,
					parent == null ? null : parent.serviceCollection);
			}

			if (commandCollection == null)
			{
				commandCollection = new ManagedObjectCollection<Command>(lifetime, locator, builder,
					SearchMode.Up, CreateCommand, null, parent == null ? null : parent.commandCollection);
			}

			if (workItemCollection == null)
			{
				workItemCollection = new ManagedObjectCollection<WorkItem>(lifetime, locator, builder,
					SearchMode.Local, null, null, parent == null ? null : parent.workItemCollection);
			}

			if (workspaceCollection == null)
			{
				workspaceCollection = new ManagedObjectCollection<IWorkspace>(lifetime, locator, builder,
					SearchMode.Up, null, null, parent == null ? null : parent.workspaceCollection);
			}

			if (itemsCollection == null)
			{
				itemsCollection = new ManagedObjectCollection<object>(lifetime, locator, builder,
					SearchMode.Local, null, null, parent == null ? null : parent.itemsCollection);
			}

			if (smartPartCollection == null)
			{
				smartPartCollection = new ManagedObjectCollection<object>(lifetime, locator, builder,
					SearchMode.Local, null, delegate(object obj)
						{
							return obj.GetType().GetCustomAttributes(typeof(SmartPartAttribute), true).Length > 0;
						},
					parent == null ? null : parent.smartPartCollection);
			}

			if (eventTopicCollection == null)
			{
				if (parent == null)
					eventTopicCollection = new ManagedObjectCollection<EventTopic>(lifetime, locator, builder,
						SearchMode.Local, CreateEventTopic, null, null);
				else
					eventTopicCollection = RootWorkItem.eventTopicCollection;
			}

			if (uiExtensionSiteCollection == null)
			{
				if (parent == null)
					uiExtensionSiteCollection = new UIExtensionSiteCollection(this);
				else
					uiExtensionSiteCollection = new UIExtensionSiteCollection(parent.uiExtensionSiteCollection);
			}
		}

		private void InitializeState()
		{
			ID = Guid.NewGuid().ToString();
		}

		/// <summary>
		/// Called to create a new <see cref="Command"/> instance to add to the <see cref="WorkItem.Commands"/> collection.
		/// </summary>
		/// <param name="t">The type of command to create.</param>
		/// <param name="name">The name of the command.</param>
		/// <returns>A new <see cref="Command"/> instance.</returns>
		/// <remarks>Override this method to create another type of command.</remarks>
		protected virtual Command CreateCommand(Type t, string name)
		{
			return new Command();
		}

		/// <summary>
		/// Called to create a new <see cref="EventTopic"/> instance to add to the <see cref="WorkItem.EventTopics"/> collection.
		/// </summary>
		/// <param name="t">The type of event topic to create.</param>
		/// <param name="topicName">The name of the event topic.</param>
		/// <returns>A new <see cref="EventTopic"/> instance.</returns>
		/// <remarks>Override this method to create another type of event topic.</remarks>
		protected virtual EventTopic CreateEventTopic(Type t, string topicName)
		{
			return new EventTopic();
		}

		/// <summary>
		/// Initializes the built-in services exposed by the <see cref="WorkItem"/>.
		/// </summary>
		protected virtual void InitializeServices()
		{
		}

		#endregion

		#region Events

		/// <summary>
		/// Occurs when the <see cref="WorkItem"/> is activated.
		/// </summary>
		public event EventHandler Activated;

		/// <summary>
		/// Occurs when the <see cref="WorkItem"/> is activating.
		/// </summary>
		public event CancelEventHandler Activating;

		/// <summary>
		/// Occurs when the <see cref="WorkItem"/> is deactivated.
		/// </summary>
		public event EventHandler Deactivated;

		/// <summary>
		/// Occurs when the <see cref="WorkItem"/> is deactivated.
		/// </summary>
		public event CancelEventHandler Deactivating;

		/// <summary>
		/// Occurs when the <see cref="WorkItem"/> is disposed.
		/// </summary>
		public event EventHandler Disposed;

		/// <summary>
		/// Occurs when the <see cref="ID"/> is changed.
		/// </summary>
		public event EventHandler<DataEventArgs<string>> IdChanged;

		/// <summary>
		/// Occurs when the <see cref="WorkItem"/> is initialized.
		/// </summary>
		public event EventHandler Initialized;

		/// <summary>
		/// Occurs when the <see cref="Run"/> method is executed.
		/// </summary>
		public event EventHandler RunStarted;

		/// <summary>
		/// Occurs when the <see cref="WorkItem"/> is terminated.
		/// </summary>
		public event EventHandler Terminated;

		/// <summary>
		/// Occurs before a <see cref="WorkItem"/> is terminated.
		/// </summary>
		public event EventHandler Terminating;

		internal event EventHandler<DataEventArgs<object>> ObjectAdded;
		internal event EventHandler<DataEventArgs<object>> ObjectRemoved;

		#endregion

		#region Properties

		/// <summary>
		/// List of commands registered with the <see cref="WorkItem"/>.
		/// </summary>
		public ManagedObjectCollection<Command> Commands
		{
			get { return commandCollection; }
		}

		/// <summary>
		/// Gets/sets the ID of this <see cref="WorkItem"/>. The ID is used for persistence of the
		/// WorkItem. By default, the ID will be a GUID. If you set a new ID, the old state data
		/// will be lost and replaced with new, empty state.
		/// </summary>
		public string ID
		{
			get
			{
				if (state == null)
					return null;
				return state.ID;
			}
			set
			{
				if (state != null)
					ReleaseState();

				AttachState(new State(value));
				OnIdChanged();
			}
		}

		/// <summary>
		/// Gets a list of all the objects and services contained in this <see cref="WorkItem"/>.
		/// </summary>
		public ManagedObjectCollection<object> Items
		{
			get { return itemsCollection; }
		}

		/// <summary>
		/// Gets the parent <see cref="WorkItem"/>.
		/// </summary>
		[Browsable(false)]
		[Dependency(NotPresentBehavior = NotPresentBehavior.ReturnNull)]
		public WorkItem Parent
		{
			get { return parent; }
			set
			{
				if (buildUpFinished)
					throw new InvalidOperationException();
				parent = value;
			}
		}

		/// <summary>
		/// Gets the root <see cref="WorkItem"/> (the one at the top of the hierarchy).
		/// </summary>
		[Browsable(false)]
		public WorkItem RootWorkItem
		{
			get
			{
				WorkItem result = this;

				while (result.Parent != null)
					result = result.Parent;

				return result;
			}
		}

		/// <summary>
		/// Returns the collection of services associated with this WorkItem.
		/// </summary>
		public ServiceCollection Services
		{
			get { return serviceCollection; }
		}

		/// <summary>
		/// Returns a collection describing the child smart parts (objects
		/// with the <see cref="SmartPartAttribute"/> applied to them) in this WorkItem.
		/// </summary>
		public ManagedObjectCollection<object> SmartParts
		{
			get { return smartPartCollection; }
		}

		/// <summary>
		/// Gets the <see cref="State"/> associated with this <see cref="WorkItem"/>.
		/// </summary>
		public State State
		{
			get { return state; }
		}

		/// <summary>
		/// Gets the current <see cref="WorkItemStatus"/> of the <see cref="WorkItem"/>.
		/// </summary>
		public WorkItemStatus Status
		{
			get { return status; }
		}

		/// <summary>
		/// Sets the <see cref="System.Diagnostics.TraceSource"/> used by the <see cref="WorkItem"/> to log messages. 
		/// </summary>
		[ClassNameTraceSource]
		public TraceSource TraceSource
		{
			set { traceSource = value; }
		}

		/// <summary>
		/// Returns a collection of <see cref="UIExtensionSite"/>s in the WorkItem.
		/// </summary>
		public UIExtensionSiteCollection UIExtensionSites
		{
			get { return uiExtensionSiteCollection; }
		}

		/// <summary>
		/// Returns a collection describing the child <see cref="WorkItem"/> objects in this WorkItem.
		/// </summary>
		public ManagedObjectCollection<WorkItem> WorkItems
		{
			get { return workItemCollection; }
		}

		/// <summary>
		/// Returns a collection describing the <see cref="IWorkspace"/> objects in this WorkItem.
		/// </summary>
		public ManagedObjectCollection<IWorkspace> Workspaces
		{
			get { return workspaceCollection; }
		}

		/// <summary>
		/// Returns a collection describing the <see cref="EventTopic"/> objects in this WorkItem.
		/// </summary>
		public ManagedObjectCollection<EventTopic> EventTopics
		{
			get { return eventTopicCollection; }
		}

		#endregion

		#region Work Item Status

		/// <summary>
		/// Activates the <see cref="WorkItem"/>.
		/// </summary>
		public void Activate()
		{
			ChangeStatus(WorkItemStatus.Active);
		}

		/// <summary>
		/// Deactivates the <see cref="WorkItem"/>.
		/// </summary>
		public void Deactivate()
		{
			ChangeStatus(WorkItemStatus.Inactive);
		}

		#endregion

		#region State Management

		/// <summary>
		/// Deletes the saved state of the <see cref="WorkItem"/>. The local copy of the state is not changed.
		/// </summary>
		/// <exception cref="ServiceMissingException">Thrown if the IStatePersistenceService is not
		/// registered in the WorkItem.</exception>
		public void DeleteState()
		{
			IStatePersistenceService service = Services.Get<IStatePersistenceService>();

			if (service == null)
			{
				throw new ServiceMissingException(typeof(IStatePersistenceService), this);
			}

			service.Remove(ID);
		}

		/// <summary>
		/// Loads the work item.
		/// </summary>
		public void Load()
		{
			IStatePersistenceService service = Services.Get<IStatePersistenceService>();

			if (service == null)
			{
				throw new ServiceMissingException(typeof(IStatePersistenceService), this);
			}

			using (new WriterLock(state.syncRoot))
			{
				State newState = service.Load(ID);
				newState.syncRoot = ReleaseState();
				AttachState(newState);
			}
		}

		#endregion

		#region Other Methods

		/// <summary>
		/// Returns smart part information for a control.
		/// </summary>
		/// <typeparam name="TSmartPartInfo">The type of the <see cref="ISmartPartInfo"/> instance to retrieve.</typeparam>
		/// <param name="smartPart">The smartPart which to retreive the smart part info for.</param>
		/// <returns>The <see cref="ISmartPartInfo"/> for the control and type requested, or null if no one is registered.</returns>
		public TSmartPartInfo GetSmartPartInfo<TSmartPartInfo>(object smartPart) where TSmartPartInfo : ISmartPartInfo
		{
			Guard.ArgumentNotNull(smartPart, "smartPart");

			return FindSmartPartInfo<TSmartPartInfo>(smartPart);
		}

		/// <summary>
		/// See <see cref="IBuilderAware.OnBuiltUp"/> for more information.
		/// </summary>
		public virtual void OnBuiltUp(string id)
		{
			// Prevent double build up notifications
			if (buildUpFinished)
				throw new InvalidOperationException();

			buildUpFinished = true;

			if (parent != null)
				FinishInitialization();
		}

		/// <summary>
		/// Finishes the initialization of <see cref="WorkItem"/> classes by calling the
		/// <see cref="IWorkItemExtensionService"/> and <see cref="OnInitialized()"/>. For
		/// root WorkItems, this will be called by the <see cref="CabApplication{TWorkItem}"/> after
		/// the modules are loaded (so root WorkItem extensions work). For child WorkItems,
		/// this will be called during <see cref="OnBuiltUp"/> automatically.
		/// </summary>
		protected internal void FinishInitialization()
		{
			IWorkItemExtensionService extensionsService = Services.Get<IWorkItemExtensionService>();
			if (extensionsService != null)
				extensionsService.InitializeExtensions(this);

			OnInitialized();
		}

		/// <summary>
		/// See <see cref="IBuilderAware.OnTearingDown"/> for more information.
		/// </summary>
		public virtual void OnTearingDown()
		{
			ObjectBuiltNotificationPolicy policy = builder.Policies.Get<ObjectBuiltNotificationPolicy>(null, null);

			if (policy != null)
			{
				policy.AddedDelegates.Remove(this);
				policy.RemovedDelegates.Remove(this);
			}
		}

		/// <summary>
		/// Registers a <see cref="ISmartPartInfo"/> view data for a given control.
		/// </summary>
		/// <param name="smartPart">The smartPart to which provide additional presentation information.</param>
		/// <param name="info">The additional presentation information for the control.</param>
		public void RegisterSmartPartInfo(object smartPart, ISmartPartInfo info)
		{
			Guard.ArgumentNotNull(smartPart, "smartPart");
			Guard.ArgumentNotNull(info, "info");

			Predicate<ISmartPartInfo> findSPI = delegate(ISmartPartInfo match)
			{
				return match.GetType() == info.GetType();
			};

			if (this != RootWorkItem)
			{
				RegisterSmartPartInfoInWorkItem(smartPart, info, findSPI, RootWorkItem);
			}
			RegisterSmartPartInfoInWorkItem(smartPart, info, findSPI, this);
		}

		private static void RegisterSmartPartInfoInWorkItem(object smartPart, ISmartPartInfo info, Predicate<ISmartPartInfo> findSPI, WorkItem workItem)
		{
			if (workItem.smartPartInfos.ContainsKey(smartPart) == false)
			{
				workItem.smartPartInfos.Add(smartPart);
				workItem.smartPartInfos[smartPart].Add(info);
			}
			else
			{
				ISmartPartInfo registered = workItem.smartPartInfos[smartPart].Find(findSPI);
				if (registered != null)
				{
					workItem.smartPartInfos[smartPart].Remove(registered);
				}
				workItem.smartPartInfos[smartPart].Add(info);
			}
		}

		/// <summary>
		/// Saves the state of this work item.
		/// </summary>
		public void Save()
		{
			IStatePersistenceService service = Services.Get<IStatePersistenceService>();

			if (service == null)
				throw new ServiceMissingException(typeof(IStatePersistenceService), this);

			using (new WriterLock(state.syncRoot))
			{
				service.Save(state);
				state.AcceptChanges();
			}
		}

		/// <summary>
		/// Terminates the work item.
		/// </summary>
		/// <remarks>
		/// Terminating the work item renders the work item invalid. Any calls to a work item
		/// after it has been terminated will result in undefined behavior.
		/// </remarks>
		public void Terminate()
		{
			ThrowIfWorkItemTerminated();
			Dispose();
		}

		#endregion

		#region Protected Members

		/// <summary>
		/// Used when the creator of a root <see cref="WorkItem"/> needs to ensure that the WorkItem
		/// has properly built itself (so its dependencies get injected properly).
		/// </summary>
		protected internal void BuildUp()
		{
			// We use Guid.NewGuid() to generate a dummy ID, so that the WorkItem buildup sequence can
			// run (the WorkItem is already located with the null ID, which marks it as a service, so
			// the SingletonStrategy would short circuit and not do the build-up).

			Type type = GetType();
			string temporaryID = Guid.NewGuid().ToString();
			PropertySetterPolicy propPolicy = new PropertySetterPolicy();
			propPolicy.Properties.Add("Parent", new PropertySetterInfo("Parent", new ValueParameter(typeof(WorkItem), null)));

			PolicyList policies = new PolicyList();
			policies.Set<ISingletonPolicy>(new SingletonPolicy(false), type, temporaryID);
			policies.Set<IPropertySetterPolicy>(propPolicy, type, temporaryID);

			builder.BuildUp(locator, type, temporaryID, this, policies);
		}

		/// <summary>
		/// Provides protected access to the builder contained within the workitem.
		/// </summary>
		protected Builder InnerBuilder
		{
			get { return builder; }
		}

		/// <summary>
		/// Provides protected access to the locator contained within the workitem.
		/// </summary>
		protected IReadWriteLocator InnerLocator
		{
			get { return locator; }
		}

		/// <summary>
		/// Internal dispose method.
		/// </summary>
		/// <param name="disposing">Set to true if called from Dispose;
		/// set to false if called from the finalizer.</param>
		protected virtual void Dispose(bool disposing)
		{
			if (disposing)
			{
				if (status == WorkItemStatus.Terminated)
					return;

				ChangeStatus(WorkItemStatus.Terminated);
				builder.TearDown(locator, this);
				uiExtensionSiteCollection.Dispose();

				ObjectBuiltNotificationPolicy policy = builder.Policies.Get<ObjectBuiltNotificationPolicy>(null, null);

				if (policy != null)
				{
					policy.AddedDelegates.Remove(this);
					policy.RemovedDelegates.Remove(this);
				}

				if (state != null)
					ReleaseState();

				if (parent != null)
				{
					List<object> ids = new List<object>();

					foreach (KeyValuePair<object, object> pair in parent.locator)
						if (pair.Value == this)
							ids.Add(pair.Key);

					foreach (object id in ids)
						parent.locator.Remove(id);

					parent.lifetime.Remove(this);

					foreach (object smartpart in smartPartInfos.Keys)
						RootWorkItem.smartPartInfos.Remove(smartpart);
				}

				lifetime.Remove(this);

				List<object> lifetimeObjects = new List<object>();
				lifetimeObjects.AddRange(lifetime);

				foreach (object obj in lifetimeObjects)
					if (lifetime.Contains(obj))
						builder.TearDown(locator, obj);

				lifetime.Dispose();
				OnDisposed();
			}
		}

		private void AttachState(State state)
		{
			this.state = state;
			this.state.StateChanged += new EventHandler<StateChangedEventArgs>(stateDataStateChanged);
			Items.Add(this.state);
		}

		private ReaderWriterLock ReleaseState()
		{
			ReaderWriterLock rwl = state.syncRoot;
			state.StateChanged -= new EventHandler<StateChangedEventArgs>(stateDataStateChanged);

			Items.Remove(state);
			state.Dispose();
			state = null;

			return rwl;
		}

		/// <summary>
		/// Fires the <see cref="Activated"/> event.
		/// </summary>
		protected virtual void OnActivated()
		{
			if (this.Activated != null)
			{
				this.Activated(this, EventArgs.Empty);
			}

			if (traceSource != null)
				traceSource.TraceInformation(String.Format(
					CultureInfo.CurrentCulture,
					Properties.Resources.TraceWorkItemStatusChangedToActivated, ID));
		}

		/// <summary>
		/// Fires the <see cref="Activating"/> event.
		/// </summary>
		protected virtual void OnActivating(CancelEventArgs args)
		{
			if (traceSource != null)
				traceSource.TraceInformation(String.Format(
					CultureInfo.CurrentCulture,
					Properties.Resources.TraceWorkItemStatusActivating, ID));

			if (this.Activating != null)
			{
				this.Activating(this, args);
			}
		}

		/// <summary>
		/// Fires the <see cref="Deactivated"/> event.
		/// </summary>
		protected virtual void OnDeactivated()
		{
			if (this.Deactivated != null)
			{
				this.Deactivated(this, EventArgs.Empty);
			}

			if (traceSource != null)
				traceSource.TraceInformation(String.Format(
					CultureInfo.CurrentCulture,
					Properties.Resources.TraceWorkItemStatusChangedToDeactivated, ID));
		}

		/// <summary>
		/// Fires the <see cref="Deactivating"/> event.
		/// </summary>
		protected virtual void OnDeactivating(CancelEventArgs args)
		{
			if (traceSource != null)
				traceSource.TraceInformation(String.Format(
					CultureInfo.CurrentCulture,
					Properties.Resources.TraceWorkItemStatusDeactivating, ID));

			if (this.Deactivating != null)
			{
				this.Deactivating(this, args);
			}
		}

		/// <summary>
		/// Fires the <see cref="Disposed"/> event.
		/// </summary>
		protected virtual void OnDisposed()
		{
			if (Disposed != null)
			{
				Disposed(this, EventArgs.Empty);
			}

			if (traceSource != null)
				traceSource.TraceInformation(String.Format(
					CultureInfo.CurrentCulture,
					Properties.Resources.TraceWorkItemStatusChangedToDisposed, ID));
		}

		/// <summary>
		/// Fires the <see cref="IdChanged"/> event.
		/// </summary>
		protected virtual void OnIdChanged()
		{
			if (IdChanged != null)
				IdChanged(this, new DataEventArgs<string>(ID));
		}

		/// <summary>
		/// Fires the <see cref="Initialized"/> event.
		/// </summary>
		protected virtual void OnInitialized()
		{
			if (this.Initialized != null)
			{
				this.Initialized(this, EventArgs.Empty);
			}

			if (traceSource != null)
				traceSource.TraceInformation(String.Format(
					CultureInfo.CurrentCulture,
					Properties.Resources.TraceWorkItemStatusChangedToInitialized, ID));
		}

		/// <summary>
		/// Fires the <see cref="ObjectRemoved"/> event.
		/// </summary>
		protected virtual void OnObjectAdded(object item)
		{
			if (ObjectAdded != null)
				ObjectAdded(this, new DataEventArgs<object>(item));
		}

		/// <summary>
		/// Fires the <see cref="ObjectRemoved"/> event.
		/// </summary>
		protected virtual void OnObjectRemoved(object item)
		{
			if (ObjectRemoved != null)
				ObjectRemoved(this, new DataEventArgs<object>(item));
		}

		/// <summary>
		/// Fires the <see cref="RunStarted"/> event. Derived classes can override this 
		/// method to place custom business logic to execute when the <see cref="Run"/> 
		/// method is called on the <see cref="WorkItem"/>.
		/// </summary>
		protected virtual void OnRunStarted()
		{
			if (this.RunStarted != null)
			{
				this.RunStarted(this, EventArgs.Empty);
			}

			if (traceSource != null)
				traceSource.TraceInformation(String.Format(
					CultureInfo.CurrentCulture,
						  Properties.Resources.TraceWorkItemRunStarted, ID));
		}

		/// <summary>
		/// Fires the <see cref="Terminated"/> event.
		/// </summary>
		protected virtual void OnTerminated()
		{
			if (this.Terminated != null)
			{
				this.Terminated(this, EventArgs.Empty);
			}

			if (traceSource != null)
				traceSource.TraceInformation(String.Format(
					CultureInfo.CurrentCulture,
					Properties.Resources.TraceWorkItemStatusChangedToTerminated, ID));
		}

		/// <summary>
		/// Fires the <see cref="Terminating"/> event.
		/// </summary>
		protected virtual void OnTerminating()
		{
			if (traceSource != null)
				traceSource.TraceInformation(String.Format(
					CultureInfo.CurrentCulture,
					Properties.Resources.TraceWorkItemStatusTerminating, ID));

			if (this.Terminating != null)
			{
				this.Terminating(this, EventArgs.Empty);
			}
		}

		#endregion

		#region Private Members

		private TSmartPartInfo FindSmartPartInfo<TSmartPartInfo>(object smartPart) where TSmartPartInfo : ISmartPartInfo
		{
			TSmartPartInfo result = default(TSmartPartInfo);
			if (RootWorkItem.smartPartInfos.ContainsKey(smartPart))
			{
				result = (TSmartPartInfo)RootWorkItem.smartPartInfos[smartPart].Find(delegate(ISmartPartInfo info)
					 {
						 return info.GetType() == typeof(TSmartPartInfo);
					 });
			}

			return result;
		}

		private IWorkItemActivationService ActivationService
		{
			get { return Services.Get<IWorkItemActivationService>(); }
		}

		private void stateDataStateChanged(object sender, StateChangedEventArgs e)
		{
			string topicKey = StateChangedTopic.BuildStateChangedTopicString(e.Key);
			EventTopic topic = EventTopics.Get(topicKey);
			if (topic != null)
			{
				topic.Fire(this, e, this, PublicationScope.WorkItem);
			}
		}

		private delegate void ExtensionCallback(WorkItem workItem);

		private delegate void ExtensionCallbackCancellable(WorkItem workItem, CancelEventArgs args);

		private void ChangeStatus(WorkItemStatus newStatus)
		{
			ThrowIfWorkItemTerminated();

			WorkItemStatus oldStatus = status;

			if (oldStatus != newStatus)
			{
				CancelEventArgs args = new CancelEventArgs();
				FireIfActivating(newStatus, args);
				FireIfDeactivating(newStatus, args);
				FireIfTerminating(newStatus);
				if (args.Cancel == false)
				{
					status = newStatus;
					if (ActivationService != null)
					{
						ActivationService.ChangeStatus(this);
					}
					FireStatusEvents();
				}
			}
		}

		private void FireIfActivating(WorkItemStatus newStatus, CancelEventArgs args)
		{
			if (newStatus == WorkItemStatus.Active)
			{
				OnActivating(args);
			}
		}

		private void FireIfDeactivating(WorkItemStatus newStatus, CancelEventArgs args)
		{
			if (newStatus == WorkItemStatus.Inactive)
			{
				OnDeactivating(args);
			}
		}

		private void FireIfTerminating(WorkItemStatus newStatus)
		{
			if (newStatus == WorkItemStatus.Terminated)
			{
				OnTerminating();
			}
		}

		private void FireStatusEvents()
		{
			if (this.status == WorkItemStatus.Active)
			{
				OnActivated();
			}
			else if (this.status == WorkItemStatus.Inactive)
			{
				OnDeactivated();
			}
			else if (this.status == WorkItemStatus.Terminated)
			{
				OnTerminated();
			}
		}

		private void ThrowIfActivationServiceNotPresent()
		{
			if (ActivationService == null)
			{
				throw new ServiceMissingException(typeof(IWorkItemActivationService), this);
			}
		}

		private void ThrowIfWorkItemTerminated()
		{
			if (this.Status == WorkItemStatus.Terminated)
			{
				throw new InvalidOperationException(Resources.WorkItemTerminated);
			}
		}

		#endregion

		#region Inner Classes

		private class ClassNameTraceSourceAttribute : TraceSourceAttribute
		{
			public ClassNameTraceSourceAttribute() : base(typeof(WorkItem).FullName) { }
		}

		#endregion
	}
}
