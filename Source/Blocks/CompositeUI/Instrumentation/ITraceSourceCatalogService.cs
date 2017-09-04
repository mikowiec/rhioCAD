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
using System.Diagnostics;
using System.Security.Permissions;
using Microsoft.Practices.CompositeUI.Utility;

namespace Microsoft.Practices.CompositeUI
{
	/// <summary>
	/// Defines a set of methods and an event which represent a trace source catalog
	/// service. The purpose of the service is to manage <see cref="TraceSource"/> instances
	/// that are used in the application.
	/// </summary>
	public interface ITraceSourceCatalogService
	{
		/// <summary>
		/// Raised when a trace source is added to the collection
		/// </summary>
		event EventHandler<DataEventArgs<TraceSource>> TraceSourceAdded;

		/// <summary>
		/// Retrieves a <see cref="TraceSource"/> by name.
		/// </summary>
		/// <param name="sourceName">Name of the source to retrieve.</param>
		/// <returns>Always retrieves a valid source. If one 
		/// was not previously created, it will be initialized upon retrieval.</returns>
		TraceSource GetTraceSource(string sourceName);

		/// <summary>
		/// Returns a <see cref="ReadOnlyDictionary{TKey, TValue}"/> for all the known trace sources.
		/// </summary>
		/// <returns>The dictionary of trace sources</returns>
		ReadOnlyDictionary<string, TraceSource> TraceSources { get; }
	}
}