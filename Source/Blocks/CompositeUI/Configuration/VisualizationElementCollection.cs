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
using System.Configuration;
using System.Collections.Generic;

namespace Microsoft.Practices.CompositeUI.Configuration
{
	/// <summary>
	/// Contains the definition of a narrator.
	/// </summary>
	[ConfigurationCollection(typeof(VisualizationElement))]
	public class VisualizationElementCollection : ConfigurationElementCollection, IEnumerable<VisualizationElement>
	{
		/// <summary>
		/// See <see cref="ConfigurationElementCollection.CreateNewElement()"/> for more information.
		/// </summary>
		protected override ConfigurationElement CreateNewElement()
		{
			return new VisualizationElement();
		}

		/// <summary>
		/// See <see cref="ConfigurationElementCollection.GetElementKey"/> for more information.
		/// </summary>
		protected override object GetElementKey(ConfigurationElement element)
		{
			return ((VisualizationElement)element).Type;
		}

		/// <summary>
		/// See <see cref="IEnumerable{T}.GetEnumerator"/> for more information.
		/// </summary>
		public new IEnumerator<VisualizationElement> GetEnumerator()
		{
			int count = base.Count;
			for (int i = 0; i < count; i++)
			{
				yield return (VisualizationElement)base.BaseGet(i);
			}
		}

		/// <summary>
		/// Adds a new element to the collection.
		/// </summary>
		/// <param name="element">The element to be added.</param>
		public void Add(VisualizationElement element)
		{
			base.BaseAdd(element);
		}
	}
}