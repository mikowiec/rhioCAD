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
using System.Collections.Specialized;
using System.Globalization;
using System.IO;
using System.IO.IsolatedStorage;
using Microsoft.Practices.CompositeUI.Properties;

namespace Microsoft.Practices.CompositeUI.Services
{
	/// <summary>
	/// Service that uses isolated storage for state persistence.
	/// </summary>
	public class IsolatedStorageStatePersistenceService : StreamStatePersistenceService
	{
		/// <summary>
		/// Configuration attribute that can be passed to the <see cref="IConfigurable.Configure"/> implementation 
		/// on the service, to determine the scope of the isolated storage to use for persistence. It must be a 
		/// key in the dictionary with the name <c>Scope</c>.
		/// </summary>
		/// <example>
		/// Supported syntax is the same one as C#, except that the <see cref="System.IO.IsolatedStorage.IsolatedStorageScope"/> enum type 
		/// must be omited:
		/// <code>Assembly | User</code>
		/// or:
		/// <code>Roaming | User | Assembly | Domain</code>
		/// </example>
		public const string ScopeAttribute = "Scope";

		IsolatedStorageScope scope;

		/// <summary>
		/// Initializes the service with the default isolated store, which is the combination 
		/// of the flags <see cref="IsolatedStorageScope.Roaming"/>, <see cref="IsolatedStorageScope.User"/>,
		/// <see cref="IsolatedStorageScope.Assembly"/> and <see cref="IsolatedStorageScope.Domain"/>.
		/// </summary>
		public IsolatedStorageStatePersistenceService()
			: this(IsolatedStorageScope.Roaming | IsolatedStorageScope.User |
			       IsolatedStorageScope.Assembly | IsolatedStorageScope.Domain)
		{
		}

		/// <summary>
		/// Initializes the service with a specific isolated storage scope.
		/// </summary>
		public IsolatedStorageStatePersistenceService(IsolatedStorageScope scope)
		{
			this.scope = scope;
		}

		/// <summary>
		/// Checks if the persistence service has the state with the specified
		/// id in its storage.
		/// </summary>
		/// <param name="id">The id of the state to look for.</param>
		/// <returns>true if the state is persisted in the storage; otherwise false.</returns>
		public override bool Contains(string id)
		{
			IsolatedStorageFile store = IsolatedStorageFile.GetStore(scope, null, null);
			string[] files = store.GetFileNames(GetFileName(id));

			return files.Length == 1;
		}

		/// <summary>
		/// Removes the state from the persistence storage.
		/// </summary>
		/// <param name="id">The id of the state to remove.</param>
		public override void RemoveStream(string id)
		{
			if (Contains(id))
			{
				IsolatedStorageFile store = IsolatedStorageFile.GetStore(scope, null, null);
				store.DeleteFile(GetFileName(id));
			}
		}

		/// <summary>
		/// Retrieves the <see cref="Stream"/> to use as the storage for the state.
		/// </summary>
		/// <param name="id">The identifier of the state.</param>
		/// <returns>The storage stream.</returns>
		protected override Stream GetStream(string id)
		{
			IsolatedStorageFile store = IsolatedStorageFile.GetStore(scope, null, null);
			string fileName = GetFileName(id);

			if (Contains(id) == false)
			{
				return new IsolatedStorageFileStream(fileName, FileMode.CreateNew, store);
			}
			else
			{
				return new IsolatedStorageFileStream(fileName, FileMode.Open, store);
			}
		}

		/// <summary>
		/// Configures the service with the <see cref="ScopeAttribute"/> value, to customize the 
		/// store location.
		/// </summary>
		/// <param name="settings">Values to configure the service with.</param>
		public override void Configure(NameValueCollection settings)
		{
			base.Configure(settings);
			if (!String.IsNullOrEmpty(settings[ScopeAttribute]))
			{
				string[] values = settings[ScopeAttribute].Split(new char[] {'|'}, StringSplitOptions.RemoveEmptyEntries);
				List<IsolatedStorageScope> scopes = new List<IsolatedStorageScope>(values.Length);
				foreach (string value in values)
				{
					string trimmed = value.Trim();
					if (trimmed.Length > 0)
					{
						if (Enum.IsDefined(typeof (IsolatedStorageScope), trimmed) == false)
						{
							throw new StatePersistenceException(String.Format(
							                                    	CultureInfo.CurrentCulture,
							                                    	Resources.InvalidIsolatedStorageStatePersistanceScope,
							                                    	settings[ScopeAttribute], trimmed));
						}
						scopes.Add((IsolatedStorageScope) Enum.Parse(typeof (IsolatedStorageScope), trimmed));
					}
				}

				scope = IsolatedStorageScope.None;
				foreach (IsolatedStorageScope tmpscope in scopes)
				{
					scope |= tmpscope;
				}

				// Try to initialize a store with the given scope.
				try
				{
					IsolatedStorageFile store = IsolatedStorageFile.GetStore(scope, null, null);
				}
				catch (ArgumentException aex)
				{
					throw new StatePersistenceException(String.Format(
					                                    	CultureInfo.CurrentCulture,
					                                    	Resources.InvalidIsolatedStorageStatePersistanceParsedScope,
					                                    	settings[ScopeAttribute]), aex);
				}
			}
		}

		/// <summary>
		/// Removes all state from the store.
		/// </summary>
		public void Clear()
		{
			IsolatedStorageFile store = IsolatedStorageFile.GetStore(scope, null, null);
			string[] files = store.GetFileNames("*");
			foreach (string file in files)
			{
				store.DeleteFile(file);
			}
		}

		/// <summary>
		/// Specifies the scope for the storage.
		/// </summary>
		public IsolatedStorageScope Scope
		{
			get { return scope; }
			set { scope = value; }
		}

		private string GetFileName(string id)
		{
			return String.Format(CultureInfo.InvariantCulture, "{0}.state", id);
		}
	}
}