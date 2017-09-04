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

using Microsoft.Practices.CompositeUI.Configuration;
using Microsoft.Practices.CompositeUI.Utility;
using System;
using System.Globalization;
using System.Collections.Specialized;
using Microsoft.Practices.CompositeUI.Configuration.Xsd;
namespace Microsoft.Practices.CompositeUI.Services
{
	/// <summary>
	/// This implementation of IModuleEnumerator processes the assemblies specified
	/// in a solution profile.
	/// </summary>
	public class FileCatalogModuleEnumerator : IModuleEnumerator, IConfigurable
	{
		private string catalogFilePath = SolutionProfileReader.DefaultCatalogFile;

		/// <summary>
		/// Initializes a new instance which will use the <see cref="SolutionProfileReader.DefaultCatalogFile"/> as
		/// the solution profile
		/// </summary>
		public FileCatalogModuleEnumerator()
		{
		}

		/// <summary>
		/// Initializes a new instance that will use the specified file as the solution profile.
		/// </summary>
		/// <param name="catalogFilePath">The path to the solution profile. This file must be
		/// located under the application folder.</param>
		public FileCatalogModuleEnumerator(string catalogFilePath)
		{
			Guard.ArgumentNotNullOrEmptyString(catalogFilePath, "catalogFilePath");
			this.catalogFilePath = catalogFilePath;
		}

		/// <summary>
		/// Processes the solution profile and returns the list of modules specified in it.
		/// </summary>
		/// <returns>An array of <see cref="Configuration.ModuleInfo"/> instances.</returns>
		public IModuleInfo[] EnumerateModules()
		{
			try
			{
				SolutionProfileReader reader = new SolutionProfileReader(catalogFilePath);
				SolutionProfileElement profile = reader.ReadProfile();
				return CreateModuleInfos(profile);
			}
			catch (Exception ex)
			{
				throw new ModuleEnumeratorException(String.Format(CultureInfo.CurrentCulture,
            		Properties.Resources.ErrorEnumeratingModules,
            		this), ex);
			}
		}

		/// <summary>
		/// Gets or sets the file path to the solution profile file.
		/// </summary>
		public string CatalogFilePath
		{
			get { return catalogFilePath; }
			set { catalogFilePath = value; }
		}

		/// <summary>
		/// Configures the enumerator by passing the path to the solution profile file.
		/// </summary>
		/// <param name="settings">Provide a value with the key 
		/// "filePath" that points to a file that is valid according to the schema defined by SolutionProfile.xsd</param>
		/// <remarks>
		/// If the file path is absent the catalog will be read from 
		/// the <see cref="SolutionProfileReader.DefaultCatalogFile"/>.
		/// </remarks>
		public void Configure(NameValueCollection settings)
		{
			Guard.ArgumentNotNull(settings, "settings");

			if (!String.IsNullOrEmpty(settings["filePath"]))
			{
				catalogFilePath = settings["filePath"];
			}
		}

		private static IModuleInfo[] CreateModuleInfos(SolutionProfileElement solutionProfile)
		{
			ModuleInfo[] mInfos = new ModuleInfo[solutionProfile.Modules.Length];
			for (int i = 0; i < solutionProfile.Modules.Length; i++)
			{
				ModuleInfoElement xsdModule = solutionProfile.Modules[i];
				ModuleInfo mInfo = new ModuleInfo(xsdModule.AssemblyFile);
				mInfo.SetUpdateLocation(xsdModule.UpdateLocation);
				if (xsdModule.Roles != null && xsdModule.Roles.Length > 0)
				{
					foreach (RoleElement role in xsdModule.Roles)
					{
						mInfo.AddRoles(role.Allow);
					}
				}
				mInfos[i] = mInfo;
			}
			return mInfos;
		}
	}
}