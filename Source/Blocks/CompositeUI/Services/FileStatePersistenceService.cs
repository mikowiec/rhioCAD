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
using System.ComponentModel;
using System.Globalization;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Microsoft.Practices.CompositeUI.Services
{
	/// <summary>
	/// Implements simple file based <see cref="IStatePersistenceService"/> that stores
	/// the state in binary files using the <see cref="BinaryFormatter"/> serializer.
	/// </summary>
	public class FileStatePersistenceService : StreamStatePersistenceService
	{
		private string basePath;

		private readonly string fileNameFormat = "{0}.state";

		/// <summary>
		/// Initializes the service with the default folder location being the 
		/// current <see cref="System.AppDomain.BaseDirectory"/>.
		/// </summary>
		public FileStatePersistenceService() : this(AppDomain.CurrentDomain.BaseDirectory) { }

		/// <summary>
		/// Initializes the service specifying the root folder to use for the persisted state.
		/// </summary>
		/// <param name="basePath">Root folder for the persisted state.</param>
		/// <remarks>
		/// If the basePath is a relative path, it will be resolved relative to 
		/// the <see cref="AppDomain.BaseDirectory"/>.
		/// </remarks>
		public FileStatePersistenceService(string basePath)
		{
			BasePath = basePath;
		}

		/// <summary>
		/// Specifies the root folder for the persisted state.
		/// </summary>
		/// <remarks>
		/// If the value is a relative path, it will be resolved relative to 
		/// the <see cref="AppDomain.BaseDirectory"/>.
		/// </remarks>
		public string BasePath
		{
			get { return basePath; }
			set { basePath = new DirectoryInfo(value).FullName; }
		}

		/// <summary>
		/// Determines whether the file associated with the given state id exists.
		/// </summary>
		/// <param name="id">Identifier of the state.</param>
		/// <returns>true if the file exists; otherwise false.</returns>
		public override bool Contains(string id)
		{
			return File.Exists(GetFileName(id));
		}

		/// <summary>
		/// Removes the file associated with the given state id.
		/// </summary>
		/// <param name="id">Identifier of the state to remove.</param>
		public override void RemoveStream(string id)
		{
			string filename = GetFileName(id);
			if (File.Exists(filename))
			{
				File.Delete(filename);
			}
		}

		/// <summary>
		/// Retrieves the storage file <see cref="Stream"/>associated with the given state id.
		/// </summary>
		/// <param name="id">Identitier of the state.</param>
		protected override Stream GetStream(string id)
		{
			string filename = GetFileName(id);
			return new FileStream(filename,
				File.Exists(filename) ? FileMode.Open : FileMode.Create, FileAccess.ReadWrite);
		}

		private string GetFileName(string id)
		{
			return Path.Combine(basePath, String.Format(CultureInfo.InvariantCulture, fileNameFormat, id));
		}
	}
}