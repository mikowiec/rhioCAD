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
using Microsoft.Practices.ObjectBuilder;

namespace Microsoft.Practices.CompositeUI
{
	/// <summary>
	/// Indicates that a property or parameter should be injected with a value from
	/// the <see cref="State"/> of the <see cref="WorkItem"/>.
	/// </summary>
	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Parameter, AllowMultiple = false, Inherited = true)]
	public sealed class StateAttribute : ParameterAttribute
	{
		private string id;

		/// <summary>
		/// Initializes a new instance of the <see cref="StateAttribute"/> class. Will
		/// cause dependency injection to select the first item in the <see cref="State"/>
		/// container with a compatible type.
		/// </summary>
		public StateAttribute()
		{
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="StateAttribute"/> class using the
		/// provided state ID. This causes the dependency injection to select the item
		/// in the <see cref="State"/> container with the given ID.
		/// </summary>
		public StateAttribute(string id)
		{
			this.id = id;
		}

		/// <summary>
		/// See <see cref="ParameterAttribute.CreateParameter"/> for more information.
		/// </summary>
		public override IParameter CreateParameter(Type memberType)
		{
			return new StateParameter(memberType, id);
		}

		private class StateParameter : KnownTypeParameter
		{
			string id;

			public StateParameter(Type type, string id)
				: base(type)
			{
				this.id = id;
			}

			public override object GetValue(IBuilderContext context)
			{
				DependencyResolutionLocatorKey key = new DependencyResolutionLocatorKey(typeof(WorkItem), null);
				WorkItem wi = (WorkItem)context.Locator.Get(key);

				if (id != null)
					return wi.State[id];

				foreach (string stateID in wi.State.Keys)
					if (type.IsAssignableFrom(wi.State[stateID].GetType()))
						return wi.State[stateID];

				return null;
			}
		}
	}
}
