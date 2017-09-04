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
using System.IO;
using System.Reflection;
using Microsoft.Practices.CompositeUI.Configuration;

namespace Microsoft.Practices.CompositeUI.Services
{
	/// <summary>
	/// This implementation of <see cref="IModuleEnumerator"/> processes the assemblies located in a specified
	/// folder and enumerates the modules locating them using reflection.
	/// </summary>
	public class ReflectionModuleEnumerator : IModuleEnumerator
	{
		private string basePath;

		/// <summary>
		/// Initializes a new <see cref="ReflectionModuleEnumerator"/> instance.
		/// </summary>
		public ReflectionModuleEnumerator()
		{
			basePath = AppDomain.CurrentDomain.BaseDirectory;
		}

		/// <summary>
		/// Gets or sets the path where the assemblies to be reflected are located.
		/// </summary>
		public string BasePath
		{
			get { return basePath; }
			set { basePath = value; }
		}

		/// <summary>
		/// Returns an array with the modules found by using reflection.
		/// </summary>
		/// <returns>An array of <see cref="IModuleInfo"/>. An empty array is returned if no module is located.</returns>
		public IModuleInfo[] EnumerateModules()
		{
			List<ModuleInfo> modules = new List<ModuleInfo>();
			List<string> directories = new List<string>();

			directories.Add(BasePath);
			while (directories.Count > 0)
			{
				string directory = directories[0];
				directories.Remove(directory);
				foreach (string filename in Directory.GetFiles(directory, "*.dll"))
				{
					Assembly assm = Assembly.LoadFile(filename);
					if (AssemblyHasModuleAttribute(assm))
					{
						ModuleInfo mi = new ModuleInfo();
						mi.SetAssemblyFile(filename);
						modules.Add(mi);
					}
				}
				directories.AddRange(Directory.GetDirectories(directory));
			}

			return modules.ToArray();
		}

		private static bool AssemblyHasModuleAttribute(Assembly assm)
		{
			return assm.GetCustomAttributes(typeof (ModuleAttribute), false).Length > 0;
		}
	}
}