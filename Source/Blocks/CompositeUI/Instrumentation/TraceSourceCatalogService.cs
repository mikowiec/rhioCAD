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
using System.Diagnostics;
using Microsoft.Practices.CompositeUI.Utility;
using System.Security.Permissions;

namespace Microsoft.Practices.CompositeUI
{
	/// <summary>
	/// Service that manages the <see cref="TraceSource"/> objects used in the application.
	/// </summary>
	public class TraceSourceCatalogService : ITraceSourceCatalogService
	{
		private Dictionary<string, TraceSource> sources = new Dictionary<string, TraceSource>();

		/// <summary>
		/// Initializes a new instance of the <see cref="TraceSourceCatalogService"/> class.
		/// </summary>
		public TraceSourceCatalogService()
		{
		}

		/// <summary>
		/// Raised when a trace source is added.
		/// </summary>
		public event EventHandler<DataEventArgs<TraceSource>> TraceSourceAdded;

		/// <summary>
		/// Gets a <see cref="TraceSource"/> with the given source name.
		/// </summary>
		/// <param name="sourceName">The name of the <see cref="TraceSource"/> to retrieve.</param>
		/// <returns>Either an existing <see cref="TraceSource"/> or a new one if 
		/// it does not exist already.</returns>
		[SecurityPermission(SecurityAction.Demand, Flags = SecurityPermissionFlag.UnmanagedCode)]
		public TraceSource GetTraceSource(string sourceName)
		{
			Guard.ArgumentNotNull(sourceName, "sourceName");

			if (sources.ContainsKey(sourceName))
				return sources[sourceName];

			TraceSource source = new TraceSource(sourceName);
			sources.Add(source.Name, source);

			// Only clear the built-in default listener added when the 
			// source is initialized with no config.
			if (source.Listeners.Count == 1 && source.Listeners[0] is DefaultTraceListener)
				source.Listeners.Clear();

			source.Listeners.AddRange(Trace.Listeners);

			if (TraceSourceAdded != null)
				TraceSourceAdded.Invoke(this, new DataEventArgs<TraceSource>(source));

			return source;
		}

		/// <summary>
		/// Adds the listener to all the trace sources.
		/// </summary>
		public void AddSharedListener(TraceListener listener)
		{
			Guard.ArgumentNotNull(listener, "listener");

			AddSharedListener(listener, string.Empty);
		}

		/// <summary>
		/// Adds the listener to all the trace sources with a specific name.
		/// </summary>
		[SecurityPermission(SecurityAction.Demand, Flags = SecurityPermissionFlag.UnmanagedCode)]
		public void AddSharedListener(TraceListener listener, string name)
		{
			Guard.ArgumentNotNull(listener, "listener");
			Guard.ArgumentNotNull(name, "name");

			if (name.Length != 0)
			{
				listener.Name = name;
			}

			foreach (KeyValuePair<string, TraceSource> pair in sources)
			{
				pair.Value.Listeners.Add(listener);
			}
		}

		/// <summary>
		/// Returns a <see cref="ReadOnlyDictionary{TKey, TValue}"/> for all the known trace sources.
		/// </summary>
		/// <returns>The dictionary of trace sources</returns>
		public ReadOnlyDictionary<string, TraceSource> TraceSources
		{
			get
			{
				return new ReadOnlyDictionary<string, TraceSource>(sources);
			}
		}
	}
}