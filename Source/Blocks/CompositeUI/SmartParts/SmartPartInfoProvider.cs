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
using System.ComponentModel;

namespace Microsoft.Practices.CompositeUI.SmartParts
{
	/// <summary>
	/// Default implementation of a <see cref="ISmartPartInfoProvider"/> that 
	/// can be used to aggregate the behavior on smart parts that use 
	/// a designer to drag and drop the <see cref="ISmartPartInfo"/> components.
	/// </summary>
	[DesignTimeVisible(false)]
	public class SmartPartInfoProvider : Component, ISmartPartInfoProvider
	{
		private List<ISmartPartInfo> items = new List<ISmartPartInfo>();

		/// <summary>
		/// The list of <see cref="ISmartPartInfo"/> items the provider exposes.
		/// </summary>
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[Browsable(false)]
		public ICollection<ISmartPartInfo> Items
		{
			get { return items; }
		}

		#region ISmartPartInfoProvider Members

		/// <summary>
		/// Retrieves a smart part information object of the given type from the 
		/// registered <see cref="Items"/>.
		/// </summary>
		/// <seealso cref="ISmartPartInfoProvider.GetSmartPartInfo"/>
		public ISmartPartInfo GetSmartPartInfo(Type smartPartInfoType)
		{
			return items.Find(delegate(ISmartPartInfo info)
			{
				return info != null && info.GetType() == smartPartInfoType;
			});
		}

		#endregion
	}
}
