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
	/// Base class for dependency attributes that can be made optional.
	/// </summary>
	public abstract class OptionalDependencyAttribute : ParameterAttribute
	{
		private bool required = true;

		/// <summary>
		/// Whether the dependency is required. Defaults to true.
		/// </summary>
		public bool Required
		{
			get { return required; }
			set { required = value; }
		}

		/// <summary>
		/// See <see cref="ParameterAttribute.CreateParameter"/> for more information.
		/// </summary>
		public override abstract IParameter CreateParameter(Type memberType);
	}
}
