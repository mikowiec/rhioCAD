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
using System.Runtime.Serialization;
using System.Security.Permissions;
using System.Diagnostics;

namespace Microsoft.Practices.CompositeUI
{
	/// <summary>
	/// Provides a dictionary of information which provides notification when items change
	/// in the collection. It is serialized with the <see cref="WorkItem"/> when the
	/// <see cref="WorkItem"/> is saved and loaded.
	/// </summary>
	[Serializable]
	public class State : StateElement, ISerializable
	{
		private bool hasChanges;
		private string id;
		private TraceSource traceSource = null;

		/// <summary>
		/// Sets the <see cref="TraceSource"/> to use for tracing messages.
		/// </summary>
		[ClassNameTraceSource]
		public TraceSource TraceSource
		{
			set { traceSource = value; }
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="State"/> class using a random ID.
		/// </summary>
		public State() : this(Guid.NewGuid().ToString())
		{
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="State"/> class using the provided ID.
		/// </summary>
		/// <param name="id">The ID for the state.</param>
		public State(string id)
		{
			this.id = id;
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="State"/> class using the provided
		/// serialization information.
		/// </summary>
		/// <param name="info">The <see cref="SerializationInfo"/> to populate with data.</param>
		/// <param name="context">The destination (see <see cref="StreamingContext"/>) for this serialization. </param>
		protected State(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
			this.id = (string)info.GetValue("id", typeof(string));
		}

		/// <summary>
		/// Populates a System.Runtime.Serialization.SerializationInfo with the data
		/// needed to serialize the target object.
		/// </summary>
		/// <param name="info">The System.Runtime.Serialization.SerializationInfo to populate with data.</param>
		/// <param name="context">The destination <see cref="StreamingContext"/>
		/// for this serialization.</param>
		[SecurityPermission(SecurityAction.Demand, Flags = SecurityPermissionFlag.SerializationFormatter)]
		public override void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			base.GetObjectData(info, context);
			info.AddValue("id", this.id);
		}

		/// <summary>
		/// Gets and sets the value of an element in the state.
		/// </summary>
		public new object this[string key]
		{
			get { return base[key]; }
			set { base[key] = value; }
		}

		/// <summary>
		/// Resets the <see cref="HasChanges"/> flag.
		/// </summary>
		public void AcceptChanges()
		{
			hasChanges = false;
		}

		/// <summary>
		/// Gets whether the state has changed since it was initially created or 
		/// the last call to <see cref="AcceptChanges"/>.
		/// </summary>
		[DefaultValue(false)]
		public bool HasChanges
		{
			get { return hasChanges; }
		}

		/// <summary>
		/// Gets the state ID.
		/// </summary>
		public string ID
		{
			get { return this.id; }
		}

		/// <summary>
		/// Raises the <see cref="StateElement.StateChanged"/> event and sets the <see cref="HasChanges"/> flag to true.
		/// </summary>
		protected override void OnStateChanged(StateChangedEventArgs e)
		{
			if (traceSource != null)
				traceSource.TraceInformation(Properties.Resources.TraceStateChangedMessage, id, e.Key);

			base.OnStateChanged(e);
			hasChanges = true;
		}

		class ClassNameTraceSourceAttribute : TraceSourceAttribute
		{
			public ClassNameTraceSourceAttribute() : base(typeof(State).FullName) { }
		}
	}
}