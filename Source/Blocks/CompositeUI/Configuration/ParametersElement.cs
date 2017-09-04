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

using System.Collections.Specialized;
using System.Configuration;

namespace Microsoft.Practices.CompositeUI.Configuration
{
	/// <summary>
	/// Base class for those configuration elements that support receiving 
	/// arbitrary name-value pairs through configuration.
	/// </summary>
	public abstract class ParametersElement : ConfigurationElement
	{
		/// <summary>
		/// Properties we're creating on the fly as unrecognized attributes appear.
		/// </summary>
		private ConfigurationPropertyCollection dynamicProperties = new ConfigurationPropertyCollection();

		private NameValueCollection configAttributes = new NameValueCollection();

		/// <summary>
		/// Constructor for use by derived classes.
		/// </summary>
		protected ParametersElement()
		{
		}

		/// <summary>
		/// Retrieves the accumulated properties for the element, which include 
		/// the dynamically generated ones.
		/// </summary>
		protected override ConfigurationPropertyCollection Properties
		{
			get
			{
				ConfigurationPropertyCollection baseprops = base.Properties;
				foreach (ConfigurationProperty dynprop in dynamicProperties)
				{
					baseprops.Add(dynprop);
				}
				return baseprops;
			}
		}

		/// <summary>
		/// Parameters received by the element as attributes in the configuration file.
		/// </summary>
		public NameValueCollection Parameters
		{
			get { return configAttributes; }
		}

		/// <summary>
		/// Create a new property on the fly for the attribute.
		/// </summary>
		protected override bool OnDeserializeUnrecognizedAttribute(string name, string value)
		{
			ConfigurationProperty dynprop = new ConfigurationProperty(name, typeof (string), value);
			dynamicProperties.Add(dynprop);
			this[dynprop] = value; // Add the value to values bag
			configAttributes.Add(name, value);
			return true;
		}
	}
}