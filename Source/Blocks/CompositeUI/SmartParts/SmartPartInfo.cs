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
using Microsoft.Practices.CompositeUI.Utility;

namespace Microsoft.Practices.CompositeUI.SmartParts
{
	/// <summary>
	/// Provides information about a specific smartpart.
	/// </summary>
	public partial class SmartPartInfo : ISmartPartInfo
	{
		#region Fields

		private string description = string.Empty;
		private string title = string.Empty;

		#endregion

		#region Constructors

		/// <summary>
		/// Initializes a new instance of the <see cref="SmartPartInfo"/> class.
		/// </summary>
		public SmartPartInfo()
		{
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="SmartPartInfo"/> class 
		/// with the title and description values.
		/// </summary>
		public SmartPartInfo(string title, string description)
		{
			this.title = title;
			this.description = description;
		} 

		#endregion

		#region Properties

		/// <summary>
		/// Description to associate with the related smart part.
		/// </summary>
		[Category("Layout")]
		public string Description
		{
			get { return description; }
			set { description = value; }
		}

		/// <summary>
		/// Title to associate with the related smart part.
		/// </summary>
		[Category("Layout")]
		public string Title
		{
			get { return title; }
			set { title = value; }
		}

		#endregion

		#region Public Methods

		/// <summary>
		/// Creates a new instance of the TSmartPartInfo 
		/// and copies over the information in the source smart part.
		/// </summary>
		public static TSmartPartInfo ConvertTo<TSmartPartInfo>(ISmartPartInfo source)
			where TSmartPartInfo : ISmartPartInfo, new()
		{
			Guard.ArgumentNotNull(source, "source");

			TSmartPartInfo info = new TSmartPartInfo();

			info.Description = source.Description;
			info.Title = source.Title;

			return info;
		} 

		#endregion
	}
}