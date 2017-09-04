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
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.CompositeUI.UIElements;
using Microsoft.Practices.CompositeUI.Utility;
using System.Globalization;

namespace Microsoft.Practices.CompositeUI
{
	/// <summary>
	/// Represents a named collection of sites for UI elements.
	/// </summary>
	public class UIExtensionSiteCollection : ICollection, IEnumerable<string>, IDisposable
	{
		UIExtensionSiteCollection parent;
		WorkItem rootWorkItem;
		Dictionary<string, UIExtensionSite> sites = new Dictionary<string, UIExtensionSite>();
		List<IUIElementAdapter> createdAdapters = new List<IUIElementAdapter>();

		/// <summary>
		/// Initializes a new instance of the <see cref="UIExtensionSiteCollection"/> class.
		/// </summary>
		public UIExtensionSiteCollection()
			: this(null, null)
		{
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="UIExtensionSiteCollection"/> class using the provided
		/// root <see cref="WorkItem"/>.
		/// </summary>
		public UIExtensionSiteCollection(WorkItem rootWorkItem)
			: this(rootWorkItem, null)
		{
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="UIExtensionSiteCollection"/> class using the provided
		/// parent <see cref="UIExtensionSiteCollection"/>.
		/// </summary>
		public UIExtensionSiteCollection(UIExtensionSiteCollection parent)
			: this(parent.rootWorkItem, parent)
		{
		}

		private UIExtensionSiteCollection(WorkItem rootWorkItem, UIExtensionSiteCollection parent)
		{
			this.parent = parent;
			this.rootWorkItem = rootWorkItem;
		}

		/// <summary>
		/// Retrieves an extension site by name.
		/// </summary>
		/// <param name="siteName">The name of the extension site to get.</param>
		/// <returns>The extension site.</returns>
		public UIExtensionSite this[string siteName]
		{
			get
			{
				if (sites.ContainsKey(siteName))
					return sites[siteName];

				if (parent != null)
				{
					UIExtensionSite childSite = parent[siteName].Duplicate();
					sites.Add(siteName, childSite);
					return childSite;
				}

				throw new ArgumentException(string.Format(CultureInfo.CurrentCulture,
					Properties.Resources.ExtensionSiteDoesNotExist, siteName), "siteName");
			}
		}

		/// <summary>
		/// Returns a count of the available extension sites.
		/// </summary>
		public int Count
		{
			get
			{
				int result = 0;

				foreach (string siteName in this)
					result++;

				return result;
			}
		}

		/// <summary>
		/// Determines whether an extension site is available.
		/// </summary>
		/// <param name="siteName">The site name to find.</param>
		/// <returns>true if the site is available; false otherwise.</returns>
		public bool Contains(string siteName)
		{
			if (sites.ContainsKey(siteName))
				return true;

			if (parent != null)
				return parent.Contains(siteName);

			return false;
		}

		/// <summary>
		/// Registers a site for the given UI element by asking the adapter factory to
		/// automatically allocate an adapter based on the element type.
		/// </summary>
		/// <param name="siteName">The site name to register.</param>
		/// <param name="uiElement">The UI element.</param>
		public void RegisterSite(string siteName, object uiElement)
		{
			Guard.ArgumentNotNullOrEmptyString(siteName, "siteName");
			Guard.ArgumentNotNull(uiElement, "uiElement");

			IUIElementAdapterFactory factory = FactoryCatalog.GetFactory(uiElement);
			IUIElementAdapter adapter = factory.GetAdapter(uiElement);
			createdAdapters.Add(adapter);
			RegisterSite(siteName, adapter);
		}

		/// <summary>
		/// Registers a site using the given adapter.
		/// </summary>
		/// <param name="siteName">The site name to register.</param>
		/// <param name="adapter">The UI element adapter for the site.</param>
		public void RegisterSite(string siteName, IUIElementAdapter adapter)
		{
			Guard.ArgumentNotNullOrEmptyString(siteName, "siteName");
			Guard.ArgumentNotNull(adapter, "adapter");

			if (Contains(siteName))
				throw new ArgumentException(string.Format(CultureInfo.CurrentCulture,
					Properties.Resources.DuplicateUIExtensionSite, siteName), "siteName");

			sites.Add(siteName, new UIExtensionSite(adapter));
		}

		/// <summary>
		/// Unregisters a site.
		/// </summary>
		/// <param name="siteName">The site name to unregister.</param>
		public void UnregisterSite(string siteName)
		{
			Guard.ArgumentNotNullOrEmptyString(siteName, "siteName");

			if (parent != null && parent.Contains(siteName))
				throw new ArgumentException(string.Format(CultureInfo.CurrentCulture,
					Properties.Resources.CannotUnregisterSiteRegisteredWithParent, siteName), "siteName");

			sites.Remove(siteName);
		}

		private IUIElementAdapterFactoryCatalog FactoryCatalog
		{
			get { return rootWorkItem.Services.Get<IUIElementAdapterFactoryCatalog>(); }
		}

		IEnumerator<string> IEnumerable<string>.GetEnumerator()
		{
			Set<string> seenNames = new Set<string>();

			for (UIExtensionSiteCollection current = this; current != null; current = current.parent)
			{
				foreach (string siteName in current.sites.Keys)
				{
					if (!seenNames.Contains(siteName))
					{
						seenNames.Add(siteName);
						yield return siteName;
					}
				}
			}
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return ((IEnumerable<string>)this).GetEnumerator();
		}

		void ICollection.CopyTo(Array array, int index)
		{
			throw new NotImplementedException();
		}

		int ICollection.Count
		{
			get { return Count; }
		}

		bool ICollection.IsSynchronized
		{
			get { return false; }
		}

		object ICollection.SyncRoot
		{
			get { throw new NotImplementedException(); }
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
		/// See <see cref="IDisposable.Dispose"/> for more information.
		/// </summary>
		protected virtual void Dispose(bool disposing)
		{
			foreach (UIExtensionSite site in sites.Values)
				site.Clear();

			foreach (IUIElementAdapter adapter in createdAdapters)
			{
				IDisposable disp = adapter as IDisposable;

				if (disp != null)
					disp.Dispose();
			}

			sites.Clear();
			createdAdapters.Clear();
		}
	}
}
