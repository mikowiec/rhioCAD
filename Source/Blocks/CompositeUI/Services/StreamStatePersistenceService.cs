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
using System.Collections.Specialized;
using System.Globalization;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using Microsoft.Practices.CompositeUI.Properties;

namespace Microsoft.Practices.CompositeUI.Services
{
	/// <summary>
	/// Implements simple file based <see cref="IStatePersistenceService"/> that stores
	/// <see cref="State"/> data in binary files using the <see cref="BinaryFormatter"/> serializer.
	/// </summary>
	public abstract class StreamStatePersistenceService : IStatePersistenceService, IConfigurable
	{
		private bool useCryptography = false;

		private ICryptographyService cryptoSvc = null;

		/// <summary>
		/// The <see cref="ICryptographyService"/> used to protect sensitive data.
		/// </summary>
		[ServiceDependency(Required = false)]
		public ICryptographyService CryptographyService
		{
			get
			{
				if (cryptoSvc == null)
				{
					throw new StatePersistenceException(String.Format(
						CultureInfo.CurrentCulture,
						Properties.Resources.ServiceMissingExceptionMessage,
						typeof(ICryptographyService),
						this.GetType()));
				}

				return cryptoSvc;
			}
			set { cryptoSvc = value; }
		}

		/// <summary>
		/// Configuration attribute that can be passed to the <see cref="IConfigurable.Configure"/> implementation 
		/// on the service, to determine whether cryptography must be used for persistence. It must be a 
		/// key in the dictionary with the name <c>UseCryptography</c>.
		/// </summary>
		public const string UseCryptographyAttribute = "UseCryptography";

		/// <summary>
		/// Saves the <see cref="State"/> to the persistence storage.
		/// </summary>
		/// <param name="state">The <see cref="State"/> to store.</param>
		public void Save(State state)
		{
			if (state == null)
			{
				throw new ArgumentNullException("state");
			}
			try
			{
				// Always overwrite state when saving.
				if (Contains(state.ID))
				{
					Remove(state.ID);
				}
				if (useCryptography)
				{
					BinaryFormatter fmt = new BinaryFormatter();
                    using (MemoryStream stream = new MemoryStream())
                    {
                        fmt.Serialize(stream, state);
                        byte[] data = CryptographyService.EncryptSymmetric(stream.GetBuffer());

                        OpenStream(state.ID, delegate(Stream fs)
                                    {
                                        fs.Write(data, 0, data.Length);
                                    });
                    }
				}
				else
				{
					BinaryFormatter fmt = new BinaryFormatter();
					OpenStream(state.ID, delegate(Stream stream)
								{
									fmt.Serialize(stream, state);
								});
				}
			}
			catch (Exception ex)
			{
				throw new StatePersistenceException(String.Format(CultureInfo.CurrentCulture,
					Resources.CannotSaveState, state.ID),
					ex);
			}
		}

		/// <summary>
		/// Retrieves the saved <see cref="State"/> from the persistence storage.
		/// </summary>
		/// <param name="id">The id of the <see cref="State"/> to retrieve.</param>
		/// <returns>The <see cref="State"/> instance created from the store.</returns>
		public State Load(string id)
		{
			if (Contains(id) == false)
			{
				throw new StatePersistenceException(String.Format(
					CultureInfo.CurrentCulture,
					Resources.StateDoesNotExist, id));
			}
			try
			{
				if (useCryptography)
				{
					byte[] cipherData = null;
					OpenStream(id, delegate(Stream stream)
								{
									cipherData = new byte[stream.Length];
									stream.Read(cipherData, 0, (int)stream.Length);
								});

                    using (MemoryStream ms = new MemoryStream(CryptographyService.DecryptSymmetric(cipherData)))
                    {
                        BinaryFormatter fmt = new BinaryFormatter();
                        return (State)fmt.Deserialize(ms);
                    }
				}
				else
				{
					BinaryFormatter fmt = new BinaryFormatter();
					State state = null;
					OpenStream(id, delegate(Stream stream)
								{
									state = (State)fmt.Deserialize(stream);
								});

					return state;
				}
			}
			catch (Exception ex)
			{
				throw new StatePersistenceException(String.Format(CultureInfo.CurrentCulture,
					Resources.CannotLoadState, id),
					ex);
			}
		}

		/// <summary>
		/// Removes the <see cref="State"/> from the persistence storage.
		/// </summary>
		/// <param name="id">The id of the <see cref="State"/> to remove.</param>
		public void Remove(string id)
		{
			try
			{
				RemoveStream(id);
			}
			catch (Exception ex)
			{
				throw new StatePersistenceException(String.Format(CultureInfo.CurrentCulture,
					Resources.CannotLoadState, id),
					ex);
			}
		}

		/// <summary>
		/// Checks if the persistence services has the <see cref="State"/> with the specified
		/// id in its storage.
		/// </summary>
		/// <param name="id">The id of the <see cref="State"/> to look for.</param>
		/// <returns>true if the <see cref="State"/> is persisted in the storage; otherwise false.</returns>
		public abstract bool Contains(string id);

		private static void ThrowIfInvalidStream(Stream stm)
		{
			if (stm == null || stm.CanRead == false)
			{
				throw new StatePersistenceException(Resources.InvalidStateStream);
			}
		}

		/// <summary>
		/// Removes the <see cref="State"/> from the persistence storage.
		/// </summary>
		/// <param name="id">The id of the <see cref="State"/> to remove.</param>
		public abstract void RemoveStream(string id);

		/// <summary>
		/// Retrieves the <see cref="Stream"/> to use as the storage for the <see cref="State"/>.
		/// </summary>
		/// <param name="id">The identifier of the <see cref="State"/> to retrieve.</param>
		/// <returns>The storage stream.</returns>
		protected abstract Stream GetStream(string id);

		/// <summary>
		/// Retrieves the <see cref="Stream"/> to use as the storage for the <see cref="State"/>, specifying whether the 
		/// stream should be disposed after usage.
		/// </summary>
		/// <param name="id">The identifier of the associated <see cref="State"/>.</param>
		/// <param name="shouldDispose">A <see labgword="bool"/> value indicating if the stream will be 
		/// disposed after usage.</param>
		/// <returns>The storage stream.</returns>
		protected virtual Stream GetStream(string id, out bool shouldDispose)
		{
			shouldDispose = true;
			return GetStream(id);
		}

		/// <summary>
		/// Configures the <see cref="StreamStatePersistenceService"/> using the settings provided
		/// by the provided settings collection.
		/// </summary>
		/// <param name="settings"></param>
		public virtual void Configure(NameValueCollection settings)
		{
			if (settings == null)
			{
				throw new ArgumentNullException("settings");
			}
			if (!String.IsNullOrEmpty(settings[UseCryptographyAttribute]))
			{
				if (Boolean.TryParse(settings[UseCryptographyAttribute], out useCryptography) == false)
				{
					throw new StatePersistenceException(
						Resources.InvalidCryptographyValue);
				}
			}
		}

		private delegate void OpenStreamDelegate(Stream openedStream);

		private void OpenStream(string stateId, OpenStreamDelegate operation)
		{
			bool dispose;
			Stream stream = GetStream(stateId, out dispose);

			try
			{
				ThrowIfInvalidStream(stream);
				operation(stream);
			}
			finally
			{
				if (dispose && stream != null)
				{
					((IDisposable)stream).Dispose();
				}
			}
		}
	}
}