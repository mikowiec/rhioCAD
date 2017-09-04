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
using System.Configuration;
using System.Diagnostics;
using System.Globalization;
using System.Reflection;
using System.Security.Permissions;
using Microsoft.Practices.CompositeUI.BuilderStrategies;
using Microsoft.Practices.CompositeUI.Commands;
using Microsoft.Practices.CompositeUI.Configuration;
using Microsoft.Practices.CompositeUI.EventBroker;
using Microsoft.Practices.CompositeUI.Services;
using Microsoft.Practices.CompositeUI.UIElements;
using Microsoft.Practices.ObjectBuilder;
using Microsoft.Practices.CompositeUI.Utility;

namespace Microsoft.Practices.CompositeUI
{
	/// <summary>
	/// Defines the <see cref="CabApplication{TWorkItem}"/> as an application having a well known lifecycle
	/// and a root <see cref="WorkItem"/> instance providing the scope for the application.
	/// </summary>
	/// <typeparam name="TWorkItem">The type of the root application work item.</typeparam>
	public abstract class CabApplication<TWorkItem>
		where TWorkItem : WorkItem, new()
	{
		TWorkItem rootWorkItem;
		SettingsSection configuration;
		Type visualizerType = null;

		/// <summary>
		/// Sets the visualizer type to be used for the application; if set to null, will turn
		/// off visualizer support (even if visualizations are configured in App.config).
		/// </summary>
		protected Type VisualizerType
		{
			get { return visualizerType; }
			set
			{
				if (value != null)
					Guard.TypeIsAssignableFromType(value, typeof(IVisualizer), "VisualizerType");

				visualizerType = value;
			}
		}

		/// <summary>
		/// Starts the application.
		/// </summary>
		public void Run()
		{
			//RegisterUnhandledExceptionHandler();
			Builder builder = CreateBuilder();
			AddBuilderStrategies(builder);
			CreateRootWorkItem(builder);

			IVisualizer visualizer = CreateVisualizer();
			if (visualizer != null)
				visualizer.Initialize(rootWorkItem, builder);

			AddRequiredServices();
			AddConfiguredServices();
			AddServices();
			AuthenticateUser();
			ProcessShellAssembly();
			rootWorkItem.BuildUp();
			LoadModules();
			rootWorkItem.FinishInitialization();

			rootWorkItem.Run();
			Start();

			rootWorkItem.Dispose();
			if (visualizer != null)
				visualizer.Dispose();
		}

		/// <summary>
		/// May be overridden in a derived class to add specific services required by the application
		/// </summary>
		protected virtual void AddServices()
		{
		}

		/// <summary>
		/// May be overriden in a derived class to provide a visualizer
		/// </summary>
		/// <returns></returns>
		protected IVisualizer CreateVisualizer()
		{
			if (visualizerType == null || Configuration.Visualizer.Count == 0)
				return null;

			return (IVisualizer)Activator.CreateInstance(visualizerType);
		}

		private void LoadModules()
		{
			IModuleLoaderService loader = rootWorkItem.Services.Get<IModuleLoaderService>(true);
			IModuleEnumerator modEnumerator = rootWorkItem.Services.Get<IModuleEnumerator>(true);

			if (modEnumerator != null)
				loader.Load(rootWorkItem, modEnumerator.EnumerateModules());
		}

		private void ProcessShellAssembly()
		{
			IModuleLoaderService loader = rootWorkItem.Services.Get<IModuleLoaderService>(true);
			Assembly assembly = Assembly.GetEntryAssembly();

			if (assembly != null)
				loader.Load(rootWorkItem, assembly);
		}

		private void AuthenticateUser()
		{
			IAuthenticationService auth = rootWorkItem.Services.Get<IAuthenticationService>(true);
			auth.Authenticate();
		}

		private void AddConfiguredServices()
		{
			foreach (ServiceElement service in Configuration.Services)
			{
				Type registerAs = service.ServiceType ?? service.InstanceType;

				if (rootWorkItem.Services.Get(registerAs) != null)
					rootWorkItem.Services.Remove(registerAs);

				object serviceinstance = rootWorkItem.Services.AddNew(service.InstanceType, registerAs);

				IConfigurable tmpConfigurable = serviceinstance as IConfigurable;

				if (tmpConfigurable != null)
					tmpConfigurable.Configure(service.Parameters);
			}
		}

		/// <summary>
		/// Returns the <see cref="SettingsSection"/> that controls the configuration for this <see cref="CabApplication{TWorkItem}"/>.
		/// </summary>
		protected virtual SettingsSection Configuration
		{
			get
			{
				if (configuration == null)
					configuration = LoadConfiguration();
				return configuration;
			}
		}

		private static SettingsSection LoadConfiguration()
		{
			object section = ConfigurationManager.GetSection(SettingsSection.SectionName);
			SettingsSection configSection = section as SettingsSection;

			if (section != null && configSection == null)
			{
				throw new ConfigurationErrorsException(String.Format(
					CultureInfo.CurrentCulture,
					Properties.Resources.InvalidConfigurationSectionType,
					SettingsSection.SectionName, typeof(SettingsSection)));
			}

			if (configSection == null)
				configSection = new SettingsSection();
			return configSection;
		}

		private void AddRequiredServices()
		{
			rootWorkItem.Services.AddNew<TraceSourceCatalogService, ITraceSourceCatalogService>();
			rootWorkItem.Services.AddNew<WorkItemExtensionService, IWorkItemExtensionService>();
			rootWorkItem.Services.AddNew<WorkItemTypeCatalogService, IWorkItemTypeCatalogService>();
			rootWorkItem.Services.AddNew<SimpleWorkItemActivationService, IWorkItemActivationService>();
			rootWorkItem.Services.AddNew<WindowsPrincipalAuthenticationService, IAuthenticationService>();
			rootWorkItem.Services.AddNew<ModuleLoaderService, IModuleLoaderService>();
			rootWorkItem.Services.AddNew<FileCatalogModuleEnumerator, IModuleEnumerator>();
			rootWorkItem.Services.AddOnDemand<DataProtectionCryptographyService, ICryptographyService>();
			rootWorkItem.Services.AddNew<CommandAdapterMapService, ICommandAdapterMapService>();
			rootWorkItem.Services.AddNew<UIElementAdapterFactoryCatalog, IUIElementAdapterFactoryCatalog>();
		}

		private void CreateRootWorkItem(Builder builder)
		{
			rootWorkItem = new TWorkItem();
			rootWorkItem.InitializeRootWorkItem(builder);
		}

		[SecurityPermission(SecurityAction.Demand, ControlAppDomain = true)]
		private void RegisterUnhandledExceptionHandler()
		{
			if (!Debugger.IsAttached && IsOnUnhandledExceptionOverridden())
				AppDomain.CurrentDomain.UnhandledException += new UnhandledExceptionEventHandler(OnUnhandledException); ;
		}

		private bool IsOnUnhandledExceptionOverridden()
		{
			return GetType().GetMethod("OnUnhandledException").DeclaringType != typeof(CabApplication<TWorkItem>);
		}

		private Builder CreateBuilder()
		{
			Builder builder = new Builder();

			builder.Strategies.AddNew<EventBrokerStrategy>(BuilderStage.Initialization);
			builder.Strategies.AddNew<CommandStrategy>(BuilderStage.Initialization);
			builder.Strategies.Add(new RootWorkItemInitializationStrategy(this.OnRootWorkItemInitialized), BuilderStage.Initialization);
			builder.Strategies.AddNew<ObjectBuiltNotificationStrategy>(BuilderStage.PostInitialization);

			builder.Policies.SetDefault<ISingletonPolicy>(new SingletonPolicy(true));
			builder.Policies.SetDefault<IBuilderTracePolicy>(new BuilderTraceSourcePolicy(new TraceSource("Microsoft.Practices.ObjectBuilder")));
			builder.Policies.SetDefault<ObjectBuiltNotificationPolicy>(new ObjectBuiltNotificationPolicy());

			return builder;
		}

		/// <summary>
		/// Returns the root <see cref="WorkItem"/> for the application.
		/// </summary>
		public TWorkItem RootWorkItem
		{
			get { return rootWorkItem; }
		}

		/// <summary>
		/// May be overridden in a derived class to perform work after the root <see cref="WorkItem"/> has
		/// been fully initialized.
		/// </summary>
		protected virtual void OnRootWorkItemInitialized()
		{
		}

		/// <summary>
		/// May be overridden in a derived class to add strategies to the <see cref="Builder"/>.
		/// </summary>
		protected virtual void AddBuilderStrategies(Builder builder)
		{
		}

		/// <summary>
		/// Must be overriden. This method is called when the application is fully created and
		/// ready to run.
		/// </summary>
		protected abstract void Start();

		/// <summary>
		/// May be overridden in a derived class to be notified of any unhandled exceptions
		/// in the <see cref="AppDomain"/>. If the application is started with a debugger,
		/// this will not be called, so that the normal debugger handling of exceptions
		/// can be used.
		/// </summary>
		/// <param name="sender">unused</param>
		/// <param name="e">The exception event information</param>
		public virtual void OnUnhandledException(object sender, UnhandledExceptionEventArgs e)
		{
		}
	}
}