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
using System.Globalization;
using Microsoft.Practices.CompositeUI.Properties;
using Microsoft.Practices.CompositeUI.Utility;

namespace Microsoft.Practices.CompositeUI.Services
{
	/// <summary>
	/// Used by the <see cref="ModuleLoaderService"/> to get the load sequence
	/// for the modules to load according to their dependencies.
	/// </summary>
	public class ModuleDependencySolver
	{
		private ListDictionary<string, string> dependencyMatrix = new ListDictionary<string, string>();
		private List<string> knownModules = new List<string>();

		/// <summary>
		/// Adds a module to the solver.
		/// </summary>
		/// <param name="name">The name that uniquely identifies the module.</param>
		public void AddModule(string name)
		{
			Guard.ArgumentNotNullOrEmptyString(name, "name");

			AddToDependencyMatrix(name);
			AddToKnownModules(name);
		}

		/// <summary>
		/// Adds a module dependency between the modules specified by dependingModule and
		/// dependentModule.
		/// </summary>
		/// <param name="dependingModule">The name of the module with the dependency.</param>
		/// <param name="dependentModule">The name of the module dependingModule
		/// depends on.</param>
		public void AddDependency(string dependingModule, string dependentModule)
		{
			Guard.ArgumentNotNullOrEmptyString(dependingModule, "dependingModule");
			Guard.ArgumentNotNullOrEmptyString(dependentModule, "dependentModule");

			if (!knownModules.Contains(dependingModule))
				throw new ArgumentException(string.Format(CultureInfo.CurrentCulture,
					Properties.Resources.DependencyForUnknownModule, dependingModule));

			AddToDependencyMatrix(dependentModule);
			dependencyMatrix.Add(dependentModule, dependingModule);
		}

		private void AddToDependencyMatrix(string module)
		{
			if (!dependencyMatrix.ContainsKey(module))
			{
				dependencyMatrix.Add(module);
			}
		}

		private void AddToKnownModules(string module)
		{
			if (!knownModules.Contains(module))
			{
				knownModules.Add(module);
			}
		}

		/// <summary>
		/// Calculates an ordered vector according to the defined dependencies.
		/// Non-dependant modules appears at the beginning of the resulting array.
		/// </summary>
		/// <returns>The resulting ordered list of modules.</returns>
		/// <exception cref="CyclicDependencyFoundException">This exception is thrown
		/// when a cycle is found in the defined depedency graph.</exception>
		public string[] Solve()
		{
			List<string> skip = new List<string>();
			while (skip.Count < dependencyMatrix.Count)
			{
				List<string> leaves = this.FindLeaves(skip);
				if (leaves.Count == 0 && skip.Count < dependencyMatrix.Count)
				{
					throw new CyclicDependencyFoundException();
				}
				skip.AddRange(leaves);
			}
			skip.Reverse();

			if (skip.Count > knownModules.Count)
			{
				throw new ModuleLoadException(String.Format(CultureInfo.CurrentCulture,
				                                            Resources.DependencyOnMissingModule,
				                                            FindMissingModules(skip)));
			}

			return skip.ToArray();
		}

		private string FindMissingModules(List<string> skip)
		{
			string missingModules = "";

			foreach (string module in skip)
			{
				if (!knownModules.Contains(module))
				{
					missingModules += ", ";
					missingModules += module;
				}
			}

			return missingModules.Substring(2);
		}

		/// <summary>
		/// Gets the number of modules added to the solver.
		/// </summary>
		public int ModuleCount
		{
			get { return dependencyMatrix.Count; }
		}

		private List<string> FindLeaves(List<string> skip)
		{
			List<string> result = new List<string>();

			foreach (string precedent in dependencyMatrix.Keys)
			{
				if (skip.Contains(precedent))
				{
					continue;
				}

				int count = 0;
				foreach (string dependent in dependencyMatrix[precedent])
				{
					if (skip.Contains(dependent))
					{
						continue;
					}
					count++;
				}
				if (count == 0)
				{
					result.Add(precedent);
				}
			}
			return result;
		}
	}
}