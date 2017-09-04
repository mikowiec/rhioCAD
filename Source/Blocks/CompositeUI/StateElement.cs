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
using System.Collections.Specialized;
using System.Runtime.Serialization;
using System.Security.Permissions;
using Microsoft.Practices.CompositeUI.Properties;
using Microsoft.Practices.CompositeUI.Utility;
using System.Threading;

namespace Microsoft.Practices.CompositeUI
{
	/// <summary>
	/// Provides a dictionary of information which provides notification when items change
	/// in the collection.
	/// </summary>
	/// <remarks>
	/// Strongly-typed derived elements have access to the protected indexer on the class, 
	/// but clients of these classes will have to forcedly use the getters/setters, thus 
	/// the derived class is always in control of its state.
	/// </remarks>
	[Serializable]
	public class StateElement : NameObjectCollectionBase, IChangeNotification, IDisposable
	{
		internal ReaderWriterLock syncRoot = new ReaderWriterLock();
		IDictionary<object, string> valueIndexed = new Dictionary<object, string>();

		/// <summary>
		/// This event is raised when the state has changed.
		/// </summary>
		public event EventHandler<StateChangedEventArgs> StateChanged;

		/// <summary>
		/// Initializes a new instance of the <see cref="StateElement"/> class.
		/// </summary>
		public StateElement()
		{
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="StateElement"/> class using the provided
		/// serialization information.
		/// </summary>
		/// <param name="info">The <see cref="System.Runtime.Serialization.SerializationInfo"/> to populate with data.</param>
		/// <param name="context">The destination (see <see cref="System.Runtime.Serialization.StreamingContext"/>) for this serialization. </param>
		protected StateElement(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
		}

		/// <summary>
		/// Gets and sets values on the state.
		/// </summary>
		/// <remarks>
		/// Derived classes must use this accessor in order to get the <see cref="StateChanged"/> fired. 
		/// This is made protected to force that pattern for strongly typed models, and forbid access to 
		/// the generic dictionary in those cases (unless the developer explicitly exposes a public 
		/// indexer as the <see cref="State"/> class does).
		/// </remarks>
		protected object this[string key]
		{
			get
			{
				Guard.ArgumentNotNull(key, "key");

				using (new ReaderLock(syncRoot))
				{
					return BaseGet(key);
				}
			}
			set
			{
				Guard.ArgumentNotNull(key, "key");

				using (new WriterLock(syncRoot))
				{
					// Remove old value from valueIndexed
					object oldvalue = BaseGet(key);
					if (oldvalue != null)
					{
						Remove(key);
					}

					BaseSet(key, value);

					if (value != null)
					{
						valueIndexed[value] = key;
					}

					RaiseStateChanged(key, value, oldvalue);

					if (value != null)
					{
						HookChangeNotification(value as IChangeNotification);
					}
				}
			}
		}

		private void HookChangeNotification(IChangeNotification element)
		{
			if (element != null)
			{
				// Unhook first to avoid double-hooking if the same 
				// element is passed twice.
				element.Changed -= ChildChanged;
				element.Changed += ChildChanged;
			}
		}

		private void UnHookChangeNotification(IChangeNotification element)
		{
			if (element != null)
			{
				element.Changed -= ChildChanged;
			}
		}

		private void ChildChanged(object sender, EventArgs e)
		{
			if (valueIndexed.ContainsKey(sender))
			{
				RaiseStateChanged(valueIndexed[sender], sender);
			}
		}

		/// <summary>
		/// Removes the item with the given key from the state.
		/// </summary>
		public void Remove(string key)
		{
			Guard.ArgumentNotNull(key, "key");

			using (new WriterLock(syncRoot))
			{
				object value = BaseGet(key);
				UnHookChangeNotification(value as IChangeNotification);
				BaseRemove(key);

				if (value != null)
				{
					valueIndexed.Remove(value);
				}
			}
		}

		/// <summary>
		/// Raises the <see cref="StateChanged"/> event for the given state key 
		/// (can be null if it is unknown).
		/// </summary>
		public void RaiseStateChanged(string key, object newValue, object oldValue)
		{
			OnStateChanged(new StateChangedEventArgs(key, newValue, oldValue));
		}

		/// <summary>
		/// Raises the <see cref="StateChanged"/> event for the given state key 
		/// (can be null if it is unknown).
		/// </summary>
		public void RaiseStateChanged(string key, object newValue)
		{
			RaiseStateChanged(key, newValue, null);
		}

		/// <summary>
		/// Raises the <see cref="StateChanged"/> event.
		/// </summary>
		protected virtual void OnStateChanged(StateChangedEventArgs e)
		{
			EventHandler<StateChangedEventArgs> stateHandler = StateChanged;
			if (stateHandler != null)
			{
				stateHandler(this, e);
			}

			EventHandler changedHandler = (EventHandler)handlers[changedKey];
			if (changedHandler != null)
			{
				changedHandler(this, EventArgs.Empty);
			}
		}

		#region IChangeNotification Members

		object changedKey = new object();
		System.ComponentModel.EventHandlerList handlers = new System.ComponentModel.EventHandlerList();

		/// <summary>
		/// Implemented explicitly to avoid confusion over which event to use at the State level.
		/// </summary>
		event EventHandler IChangeNotification.Changed
		{
			add { handlers.AddHandler(changedKey, value); }
			remove { handlers.RemoveHandler(changedKey, value); }
		}

		#endregion

		#region IDisposable Members

		/// <summary>
		/// Free resources.
		/// </summary>
		public void Dispose()
		{
			Dispose(true);
			GC.SuppressFinalize(this);
		}

		/// <summary>
		/// Called to free resources.
		/// </summary>
		/// <param name="disposing">Should be true when calling from Dispose().</param>
		protected virtual void Dispose(bool disposing)
		{
			if (disposing)
			{
				handlers.Dispose();
			}
		}

		#endregion
	}
}