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
using System.Configuration;

namespace Microsoft.Practices.CompositeUI.Configuration
{
	/// <summary>
	/// List of services configured for the <see cref="CabApplication{TWorkItem}"/>.
	/// </summary>
	[ConfigurationCollection(typeof (ServiceElement))]
	public class ServiceElementCollection : ConfigurationElementCollection, IEnumerable<ServiceElement>
	{
		/// <summary>
		/// Creates a new <see cref="ServiceElement"/>.
		/// </summary>
		protected override ConfigurationElement CreateNewElement()
		{
			return new ServiceElement();
		}

		/// <summary>
		/// Retrieves the key for the configuration element.
		/// </summary>
		protected override object GetElementKey(ConfigurationElement element)
		{
			return ((ServiceElement) element).ServiceType;
		}

		/// <summary>
		/// Provides access to the service elements by the type of service registered.
		/// </summary>
		public ServiceElement this[Type serviceType]
		{
			get { return (ServiceElement) base.BaseGet(serviceType); }
			set
			{
				if (base.BaseGet(serviceType) != null)
				{
					base.BaseRemove(serviceType);
				}
				base.BaseAdd(value);
			}
		}

		/// <summary>
		/// Adds a new service to the collection.
		/// </summary>
		public void Add(ServiceElement service)
		{
			base.BaseAdd(service);
		}

		/// <summary>
		/// Removes a service from the collection.
		/// </summary>
		public void Remove(Type serviceType)
		{
			base.BaseRemove(serviceType);
		}

		#region IEnumerable<ServiceElement> Members

		/// <summary>
		/// Enumerates the services in the collection.
		/// </summary>
		public new IEnumerator<ServiceElement> GetEnumerator()
		{
			int count = base.Count;
			for (int i = 0; i < count; i++)
			{
				yield return (ServiceElement) base.BaseGet(i) ;
			}
		}

		#endregion
	}
}