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
using System.Globalization;
using System.IO;
using System.Reflection;
using Microsoft.Practices.CompositeUI.Configuration;
using Microsoft.Practices.CompositeUI.Utility;
using Microsoft.Practices.ObjectBuilder;

namespace Microsoft.Practices.CompositeUI.Services
{
	/// <summary>
	/// Service to load modules into the application.
	/// </summary>
	public class ModuleLoaderService : IModuleLoaderService
	{
		Dictionary<Assembly, ModuleMetadata> loadedModules = new Dictionary<Assembly, ModuleMetadata>();
		TraceSource traceSource = null;

		/// <summary>
		/// Initializes a new instance of the <see cref="ModuleLoaderService"/> class with the
		/// provided trace source.
		/// </summary>
		/// <param name="traceSource">The trace source for tracing. If null is
		/// passed, the service does not perform tracing.</param>
		[InjectionConstructor]
		public ModuleLoaderService([ClassNameTraceSource] TraceSource traceSource)
		{
			this.traceSource = traceSource;
		}

		/// <summary>
		/// See <see cref="IModuleLoaderService.ModuleLoaded"/> for more information.
		/// </summary>
		public event EventHandler<DataEventArgs<LoadedModuleInfo>> ModuleLoaded;

		/// <summary>
		/// See <see cref="IModuleLoaderService.LoadedModules"/> for more information.
		/// </summary>
		public IList<LoadedModuleInfo> LoadedModules
		{
			get
			{
				List<LoadedModuleInfo> result = new List<LoadedModuleInfo>();

				foreach (ModuleMetadata module in loadedModules.Values)
					result.Add(module.ToLoadedModuleInfo());

				return result.AsReadOnly();
			}
		}

		/// <summary>
		/// See <see cref="IModuleLoaderService.Load(WorkItem, IModuleInfo[])"/> for more information.
		/// </summary>
		public void Load(WorkItem workItem, params IModuleInfo[] modules)
		{
			Guard.ArgumentNotNull(workItem, "workItem");
			Guard.ArgumentNotNull(modules, "modules");

			InnerLoad(workItem, modules);
		}

		/// <summary>
		/// See <see cref="IModuleLoaderService.Load(WorkItem, Assembly[])"/> for more information.
		/// </summary>
		public void Load(WorkItem workItem, params Assembly[] assemblies)
		{
			Guard.ArgumentNotNull(workItem, "workItem");
			Guard.ArgumentNotNull(assemblies, "assemblies");

			List<IModuleInfo> modules = new List<IModuleInfo>();

			foreach (Assembly assembly in assemblies)
				modules.Add(new ModuleInfo(assembly));

			InnerLoad(workItem, modules.ToArray());
		}

		/// <summary>
		/// Fires the ModuleLoaded event.
		/// </summary>
		/// <param name="module">The module that was loaded.</param>
		protected virtual void OnModuleLoaded(LoadedModuleInfo module)
		{
			if (ModuleLoaded != null)
				ModuleLoaded(this, new DataEventArgs<LoadedModuleInfo>(module));
		}

		private void InnerLoad(WorkItem workItem, IModuleInfo[] modules)
		{
			if (modules.Length == 0)
				return;

			LoadAssemblies(modules);
			List<ModuleMetadata> loadOrder = GetLoadOrder();

			foreach (ModuleMetadata module in loadOrder)
				module.LoadServices(workItem);

			foreach (ModuleMetadata module in loadOrder)
				module.InitializeModuleClasses(workItem);

			foreach (ModuleMetadata module in loadOrder)
				module.InitializeWorkItemExtensions(workItem);

			foreach (ModuleMetadata module in loadOrder)
				module.NotifyOfLoadedModule(OnModuleLoaded);
		}

		private List<ModuleMetadata> GetLoadOrder()
		{
			Dictionary<string, ModuleMetadata> indexedInfo = new Dictionary<string, ModuleMetadata>();
			ModuleDependencySolver solver = new ModuleDependencySolver();
			List<ModuleMetadata> result = new List<ModuleMetadata>();

			foreach (ModuleMetadata data in loadedModules.Values)
			{
				if (indexedInfo.ContainsKey(data.Name))
					throw new ModuleLoadException(String.Format(CultureInfo.CurrentCulture,
						Properties.Resources.DuplicatedModule, data.Name));

				indexedInfo.Add(data.Name, data);
				solver.AddModule(data.Name);

				foreach (string dependency in data.Dependencies)
					solver.AddDependency(data.Name, dependency);
			}

			if (solver.ModuleCount > 0)
			{
				string[] loadOrder = solver.Solve();

				for (int i = 0; i < loadOrder.Length; i++)
					result.Add(indexedInfo[loadOrder[i]]);
			}

			return result;
		}

		private void LoadAssemblies(IModuleInfo[] modules)
		{
			foreach (IModuleInfo module in modules)
			{
				GuardLegalAssemblyFile(module);
				Assembly assembly = LoadAssembly(module.AssemblyFile);

				if (loadedModules.ContainsKey(assembly))
					continue;

				loadedModules.Add(assembly, new ModuleMetadata(assembly, traceSource));
			}
		}

		private Assembly LoadAssembly(string assemblyFile)
		{
			Guard.ArgumentNotNullOrEmptyString(assemblyFile, "assemblyFile");

			assemblyFile = GetModulePath(assemblyFile);

			FileInfo file = new FileInfo(assemblyFile);
			Assembly assembly = null;

			try
			{
				assembly = Assembly.LoadFrom(file.FullName);
			}
			catch (Exception ex)
			{
				throw new ModuleLoadException(assemblyFile, ex.Message, ex);
			}

			if (traceSource != null)
				traceSource.TraceInformation(Properties.Resources.LogModuleAssemblyLoaded, file.FullName);

			return assembly;
		}

		private string GetModulePath(string assemblyFile)
		{
			if (Path.IsPathRooted(assemblyFile) == false)
				assemblyFile = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, assemblyFile);

			return assemblyFile;
		}

		#region Guards

		private void GuardLegalAssemblyFile(IModuleInfo modInfo)
		{
			Guard.ArgumentNotNull(modInfo, "modInfo");
			Guard.ArgumentNotNull(modInfo.AssemblyFile, "modInfo.AssemblyFile");

			string assemblyFilePath = GetModulePath(modInfo.AssemblyFile);

			if (File.Exists(assemblyFilePath) == false)
			{
				throw new ModuleLoadException(
					string.Format(CultureInfo.CurrentCulture,
						Properties.Resources.ModuleNotFound, assemblyFilePath));
			}
		}

		#endregion

		#region Helper classes

		class ModuleMetadata
		{
			Assembly assembly;
			bool loadedServices = false;
			bool extensionsInitialized = false;
			bool modulesInitialzed = false;
			string name = null;
			bool notified = false;

			List<string> dependencies = new List<string>();
			List<Type> moduleTypes = new List<Type>();
			List<IModule> moduleClasses = new List<IModule>();
			List<string> roles = new List<string>();
			List<ServiceMetadata> services = new List<ServiceMetadata>();
			List<KeyValuePair<Type, Type>> workItemExtensions = new List<KeyValuePair<Type, Type>>();
			List<Type> workItemRootExtensions = new List<Type>();

			TraceSource traceSource;

			public ModuleMetadata(Assembly assembly, TraceSource traceSource)
			{
				this.assembly = assembly;
				this.traceSource = traceSource;

				foreach (ModuleAttribute attr in assembly.GetCustomAttributes(typeof(ModuleAttribute), true))
					name = attr.Name;

				foreach (ModuleDependencyAttribute attr in assembly.GetCustomAttributes(typeof(ModuleDependencyAttribute), true))
					dependencies.Add(attr.Name);

				foreach (Type type in assembly.GetExportedTypes())
				{
					foreach (ServiceAttribute attr in type.GetCustomAttributes(typeof(ServiceAttribute), true))
						services.Add(new ServiceMetadata(type, attr.RegisterAs ?? type, attr.AddOnDemand));

					foreach (WorkItemExtensionAttribute attr in type.GetCustomAttributes(typeof(WorkItemExtensionAttribute), true))
						workItemExtensions.Add(new KeyValuePair<Type, Type>(attr.WorkItemType, type));

					foreach (RootWorkItemExtensionAttribute attr in type.GetCustomAttributes(typeof(RootWorkItemExtensionAttribute), true))
						workItemRootExtensions.Add(type);

					if (!type.IsAbstract && typeof(IModule).IsAssignableFrom(type))
						moduleTypes.Add(type);
				}
			}

			public IEnumerable<string> Dependencies
			{
				get { return dependencies; }
			}

			public string Name
			{
				get
				{
					if (name == null)
						name = assembly.FullName;

					return name;
				}
				set { name = value; }
			}

			public void LoadServices(WorkItem workItem)
			{
				if (loadedServices)
					return;

				loadedServices = true;
				EnsureModuleClassesExist(workItem);

				try
				{
					foreach (IModule moduleClass in moduleClasses)
					{
						moduleClass.AddServices();

						if (traceSource != null)
							traceSource.TraceInformation(Properties.Resources.AddServicesCalled, moduleClass.GetType());
					}

					foreach (ServiceMetadata svc in services)
					{
						if (svc.AddOnDemand)
						{
							workItem.Services.AddOnDemand(svc.InstanceType, svc.RegistrationType);

							if (traceSource != null)
								traceSource.TraceInformation(Properties.Resources.ServiceAddedOnDemand, Name, svc.InstanceType);
						}
						else
						{
							workItem.Services.AddNew(svc.InstanceType, svc.RegistrationType);

							if (traceSource != null)
								traceSource.TraceInformation(Properties.Resources.ServiceAdded, Name, svc.InstanceType);
						}
					}
				}
				catch (Exception ex) { ThrowModuleLoadException(ex); }
			}

			private void EnsureModuleClassesExist(WorkItem workItem)
			{
				if (moduleClasses.Count == moduleTypes.Count)
					return;

				try
				{
					foreach (Type moduleType in moduleTypes)
					{
						IModule module = (IModule)workItem.Items.AddNew(moduleType);
						moduleClasses.Add(module);

						if (traceSource != null)
							traceSource.TraceInformation(Properties.Resources.LogModuleAdded, moduleType);
					}
				}
				catch (FileNotFoundException ex) { ThrowModuleReferenceException(ex); }
				catch (Exception ex) { ThrowModuleLoadException(ex); }
			}

			public void InitializeModuleClasses(WorkItem workItem)
			{
				if (modulesInitialzed)
					return;

				modulesInitialzed = true;
				EnsureModuleClassesExist(workItem);

				try
				{
					foreach (IModule module in moduleClasses)
					{
						module.Load();

						if (traceSource != null)
							traceSource.TraceInformation(Properties.Resources.ModuleStartCalled, module.GetType());
					}
				}
                catch (FileNotFoundException ex) { ThrowModuleReferenceException(ex); }
				catch (Exception ex) { ThrowModuleLoadException(ex); }
			}

			public void InitializeWorkItemExtensions(WorkItem workItem)
			{
				if (extensionsInitialized)
					return;

				extensionsInitialized = true;

				IWorkItemExtensionService svc = workItem.Services.Get<IWorkItemExtensionService>();

				if (svc == null)
					return;

				foreach (KeyValuePair<Type, Type> kvp in workItemExtensions)
					svc.RegisterExtension(kvp.Key, kvp.Value);

				foreach (Type type in workItemRootExtensions)
					svc.RegisterRootExtension(type);
			}

			public void NotifyOfLoadedModule(Action<LoadedModuleInfo> action)
			{
				if (notified)
					return;

				notified = true;
				action(ToLoadedModuleInfo());
			}

			public LoadedModuleInfo ToLoadedModuleInfo()
			{
				return new LoadedModuleInfo(assembly, Name, roles, dependencies);
			}

			private void ThrowModuleLoadException(Exception innerException)
			{
				throw new ModuleLoadException(Name,
						String.Format(CultureInfo.CurrentCulture,
										  Properties.Resources.FailedToLoadModule,
										  assembly.FullName, innerException.Message),
						innerException);
			}

			private void ThrowModuleReferenceException(Exception innerException)
			{
				throw new ModuleLoadException(Name,
						Properties.Resources.ReferencedAssemblyNotFound,
						innerException);
			}
		}

		class ServiceMetadata
		{
			public bool AddOnDemand = false;
			public Type InstanceType = null;
			public Type RegistrationType = null;

			public ServiceMetadata(Type instanceType, Type registrationType, bool addOnDemand)
			{
				this.InstanceType = instanceType;
				this.RegistrationType = registrationType;
				this.AddOnDemand = addOnDemand;
			}
		}

		class ClassNameTraceSourceAttribute : TraceSourceAttribute
		{
			/// <summary>
			/// Initializes the attribute using the <see cref="IModuleLoaderService"/> 
			/// interface namespace as the source name.
			/// </summary>
			public ClassNameTraceSourceAttribute() : base(typeof(ModuleLoaderService).FullName)
			{
			}
		}

		#endregion
	}
}
