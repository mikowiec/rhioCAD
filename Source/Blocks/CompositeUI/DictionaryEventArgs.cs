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
using Microsoft.Practices.CompositeUI.Utility;

namespace Microsoft.Practices.CompositeUI
{
	/// <summary>
	/// Provides data for an event that requires a dictionary of information.
	/// </summary>
	public class DictionaryEventArgs : DataEventArgs<Dictionary<string, object>>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="DictionaryEventArgs"/> class.
		/// </summary>
		public DictionaryEventArgs() : base(new Dictionary<string, object>())
		{
		}

		/// <summary>
		/// Provides a string representation of the argument data.
		/// </summary>
		public override string ToString()
		{
			string[] values = new string[Data.Count];
			int i = 0;

			foreach (KeyValuePair<String, object> pair in Data)
				values[i++] = pair.Key + ": " + pair.Value;

			return String.Join(", ", values);
		}
	}
}