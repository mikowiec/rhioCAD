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
using System.Text;
using System.Configuration;
using System.ComponentModel;

namespace Microsoft.Practices.CompositeUI.Configuration
{
	/// <summary>
	/// Contains the definition of a visualization.
	/// </summary>
	public class VisualizationElement : ConfigurationElement
	{
		/// <summary>
		/// The type of the visualization to use.
		/// </summary>
		[ConfigurationProperty("type", IsKey = true, IsRequired = true)]
		[TypeConverter(typeof(TypeNameConverter))]
		public Type Type
		{
			get { return (Type)this["type"]; }
			set { this["type"] = value; }
		}
	}
}
