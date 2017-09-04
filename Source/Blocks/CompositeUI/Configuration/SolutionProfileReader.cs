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
using System.IO;
using System.Reflection;
using System.Security.Principal;
using System.Threading;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
using Microsoft.Practices.CompositeUI.Configuration.Xsd;
using Microsoft.Practices.CompositeUI.Properties;
using Microsoft.Practices.CompositeUI.Utility;

namespace Microsoft.Practices.CompositeUI.Configuration
{
	/// <summary>
	/// Reads the <see cref="SolutionProfileElement"/> from a file.
	/// </summary>
	public class SolutionProfileReader
	{
		private string catalogFilePath = DefaultCatalogFile;

		/// <summary>
		/// The default profile to use if no profile is specified.
		/// </summary>
		public const string DefaultCatalogFile = "ProfileCatalog.xml";

		/// <summary>
		/// Initializes a new instance which will use the <see cref="DefaultCatalogFile"/> as
		/// the solution profile.
		/// </summary>
		public SolutionProfileReader()
		{
		}

		/// <summary>
		/// Initializes a new instance that will use the specified file as the solution profile.
		/// </summary>
		/// <param name="catalogFilePath">The path to the solution profile. This file must be
		/// located under the application folder.</param>
		public SolutionProfileReader(string catalogFilePath)
		{
			this.catalogFilePath = GetFullPathOrThrowIfInvalid(catalogFilePath);
		}

		/// <summary>
		/// Gets the solution profile file path.
		/// </summary>
		public string CatalogFilePath
		{
			get { return catalogFilePath; }
		}

		/// <summary>
		/// Reads the solution profile form the specified file.
		/// </summary>
		/// <returns>An instance of <see cref="SolutionProfileElement"/>.</returns>
		public SolutionProfileElement ReadProfile()
		{
			SolutionProfileElement solution = new SolutionProfileElement();
			if (File.Exists(catalogFilePath))
			{
				try
				{
					XmlSerializer serializer = new XmlSerializer(typeof(SolutionProfileElement));
					using (XmlReader reader = GetValidatingReader())
					{
						solution = (SolutionProfileElement)serializer.Deserialize(reader);
						ProcessProfileRoles(solution);
						return solution;
					}
				}
				catch (Exception ex)
				{
					throw new SolutionProfileReaderException(String.Format(
						CultureInfo.CurrentCulture,
						Resources.ErrorReadingProfile,
						catalogFilePath), ex);
				}
			}
			else
			{
				ThrowIfCatalogPathNotDefault();
			}
			return solution;
		}

		private XmlReader GetValidatingReader()
		{
			Stream stream = Assembly.GetExecutingAssembly().GetManifestResourceStream("Microsoft.Practices.CompositeUI.SolutionProfile.xsd");
			XmlTextReader schemaReader = new XmlTextReader(stream);
			stream.Dispose();

			XmlReaderSettings settings = new XmlReaderSettings();
			settings.Schemas.Add("http://schemas.microsoft.com/pag/cab-profile", schemaReader);
			XmlReader catalogReader = XmlReader.Create(catalogFilePath, settings);

			return catalogReader;
		}

		/// <summary>
		/// Processes the solution profile comparing the roles the user has against
		/// the roles specified on the solution profile. The list of modules in the 
		/// solution profile is modified eliminating the modules the user has not
		/// access to according his/her roles.
		/// </summary>
		/// <param name="profile">The solution profile specifying the modules and
		/// the roles needed to use that modules.</param>
		private static void ProcessProfileRoles(SolutionProfileElement profile)
		{
			IPrincipal principal = Thread.CurrentPrincipal;

			List<ModuleInfoElement> permittedModules = new List<ModuleInfoElement>();
			if (profile.Modules != null)
			{
				foreach (ModuleInfoElement modInfo in profile.Modules)
				{
					if (modInfo.Roles != null)
					{
						if (principal.Identity.IsAuthenticated)
						{
							foreach (RoleElement role in modInfo.Roles)
							{
								if (principal.IsInRole(role.Allow))
								{
									permittedModules.Add(modInfo);
									break;
								}
							}
						}
					}
					else
					{
						permittedModules.Add(modInfo);
					}
				}
				profile.Modules = permittedModules.ToArray();
			}
		}

		private void ThrowIfCatalogPathNotDefault()
		{
			string defaultFullPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, DefaultCatalogFile);
			if (String.Compare(catalogFilePath, DefaultCatalogFile, true, CultureInfo.CurrentCulture) == 0 ||
				String.Compare(catalogFilePath, defaultFullPath, true, CultureInfo.CurrentCulture) == 0)
			{
				return;
			}

			throw new SolutionProfileReaderException(String.Format(CultureInfo.CurrentCulture,
				Resources.SolutionProfileNotFound,
				catalogFilePath));
		}



		private string GetFullPathOrThrowIfInvalid(string catalogFilePath)
		{
			// Only change the default if we have a non-empty value.
			Guard.ArgumentNotNullOrEmptyString(catalogFilePath, "catalogFilePath");

			string fullPath = catalogFilePath;

			if (!Path.IsPathRooted(fullPath))
			{
				fullPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, fullPath);
			}

			// Simplify relative path movements.
			fullPath = new FileInfo(fullPath).FullName;

			if (!fullPath.StartsWith(AppDomain.CurrentDomain.BaseDirectory, true, CultureInfo.CurrentCulture))
			{
				throw new SolutionProfileReaderException(String.Format(
					CultureInfo.CurrentCulture,
					Resources.InvalidSolutionProfilePath,
					catalogFilePath,
					AppDomain.CurrentDomain.BaseDirectory));
			}

			return fullPath;
		}


	}
}