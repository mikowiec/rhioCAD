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
using Microsoft.Practices.CompositeUI.BuilderStrategies;
using Microsoft.Practices.CompositeUI.Commands;
using Microsoft.Practices.CompositeUI.EventBroker;
using Microsoft.Practices.CompositeUI.Services;
using Microsoft.Practices.CompositeUI.UIElements;
using Microsoft.Practices.ObjectBuilder;
using Microsoft.Practices.CompositeUI.Configuration;
using System.Configuration;
using System.Globalization;
using System.Collections.Generic;

namespace Microsoft.Practices.CompositeUI
{
	/// <summary>
	/// Base class for the CAB visualizer system.
	/// </summary>
	public class CabVisualizer : IVisualizer
	{
		Builder cabBuilder;
		WorkItem cabRootWorkItem;
		WorkItem rootWorkItem;
		VisualizationElementCollection configuration;
		List<object> visualizations = new List<object>();

		/// <summary>
		/// Returns all of the visualizations in the visualizer
		/// </summary>
		protected ICollection<object> Visualizations
		{
			get
			{
				return visualizations.AsReadOnly();
			}
		}

		/// <summary>
		/// Loads the configuration section for the visualizer
		/// </summary>
		protected virtual VisualizationElementCollection Configuration
		{
			get
			{
				if (configuration == null)
					configuration = LoadConfiguration();

				return configuration;
			}
		}

		private VisualizationElementCollection LoadConfiguration()
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

			return configSection.Visualizer;
		}

		/// <summary>
		/// See <see cref="IVisualizer.CabRootWorkItem"/> for more information.
		/// </summary>
		public Builder CabBuilder
		{
			get { return cabBuilder; }
		}

		/// <summary>
		/// See <see cref="IVisualizer.CabRootWorkItem"/> for more information.
		/// </summary>
		public WorkItem CabRootWorkItem
		{
			get { return cabRootWorkItem; }
		}

		/// <summary>
		/// Returns the root <see cref="WorkItem"/> for the Visualizer hierarchy.
		/// </summary>
		protected WorkItem RootWorkItem
		{
			get { return rootWorkItem; }
		}

		/// <summary>
		/// See <see cref="IVisualizer.Initialize"/> for more information.
		/// </summary>
		public void Initialize(WorkItem cabRootWorkItem, Builder cabBuilder)
		{
			if (this.cabRootWorkItem != null)
				throw new InvalidOperationException(Properties.Resources.VisualizerAlreadyInitialized);

			this.cabRootWorkItem = cabRootWorkItem;
			this.cabBuilder = cabBuilder;

			Builder builder = CreateBuilder();
			AddBuilderStrategies(builder);
			CreateRootWorkItem(builder);
			AddRequiredServices();
			AddServices();

			rootWorkItem.BuildUp();
			CreateVisualizationShell();
			LoadVisualizerPlugins();

			rootWorkItem.Run();
		}

		/// <summary>
		/// May be overridden in derived class to create the main shell of the visualizer.
		/// </summary>
		protected virtual void CreateVisualizationShell()
		{
		}

		/// <summary>
		/// May be overridden in a derived class to add strategies to the <see cref="Builder"/>.
		/// </summary>
		protected virtual void AddBuilderStrategies(Builder builder)
		{
		}

		/// <summary>
		/// May be overridden in a derived class to add services to visualizer's root <see cref="WorkItem"/>.
		/// </summary>
		protected virtual void AddServices()
		{
		}

		private Builder CreateBuilder()
		{
			Builder builder = new Builder();

			builder.Strategies.AddNew<EventBrokerStrategy>(BuilderStage.Initialization);
			builder.Strategies.AddNew<CommandStrategy>(BuilderStage.Initialization);
			builder.Policies.SetDefault<ISingletonPolicy>(new SingletonPolicy(true));

			return builder;
		}

		private void CreateRootWorkItem(Builder builder)
		{
			rootWorkItem = new WorkItem();
			RootWorkItem.InitializeRootWorkItem(builder);
		}

		private void AddRequiredServices()
		{
			RootWorkItem.Services.AddNew<TraceSourceCatalogService, ITraceSourceCatalogService>();
			RootWorkItem.Services.AddNew<WorkItemTypeCatalogService, IWorkItemTypeCatalogService>();
			RootWorkItem.Services.AddNew<SimpleWorkItemActivationService, IWorkItemActivationService>();
			RootWorkItem.Services.AddNew<CommandAdapterMapService, ICommandAdapterMapService>();
			RootWorkItem.Services.AddNew<UIElementAdapterFactoryCatalog, IUIElementAdapterFactoryCatalog>();
			RootWorkItem.Services.Add<IVisualizer>(this);
		}

		private void LoadVisualizerPlugins()
		{
			foreach (VisualizationElement elt in Configuration)
				AddNewVisualization(elt.Type);
		}

		/// <summary>
		/// See <see cref="IDisposable.Dispose"/> for more information.
		/// </summary>
		public void Dispose()
		{
			Dispose(true);
			GC.SuppressFinalize(this);
		}

		/// <summary>
		/// Called to free resources.
		/// </summary>
		/// <param name="disposing">Should be true when calling from Dispose().</param>
		protected virtual void Dispose(bool disposing)
		{
			if (disposing)
			{
				rootWorkItem.Services.Remove<IVisualizer>();
				rootWorkItem.Dispose();
			}
		}

		/// <summary>
		/// Adds a new visualization to the visualizer.
		/// </summary>
		/// <typeparam name="TVisualization">The type of the visualization to make.</typeparam>
		/// <returns>The new visualization.</returns>
		protected TVisualization AddNewVisualization<TVisualization>()
		{
			return (TVisualization)AddNewVisualization(typeof(TVisualization));
		}

		/// <summary>
		/// Adds a new visualization to the visualizer.
		/// </summary>
		/// <param name="type">The type of the visualization to make.</param>
		/// <returns>The new visualization.</returns>
		protected object AddNewVisualization(Type type)
		{
			object result = RootWorkItem.Items.AddNew(type);
			visualizations.Add(result);
			return result;
		}
	}
}
