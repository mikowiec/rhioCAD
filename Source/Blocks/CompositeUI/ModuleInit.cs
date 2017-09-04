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

namespace Microsoft.Practices.CompositeUI
{
	/// <summary>
	/// A default implementation of the <see cref="IModule"/> interface.
	/// </summary>
	public abstract class ModuleInit : IModule
	{
		/// <summary>
		/// See <see cref="IModule.AddServices"/> for more information.
		/// </summary>
		public virtual void AddServices()
		{
		}

		/// <summary>
		/// See <see cref="IModule.Load"/> for more information.
		/// </summary>
		public virtual void Load()
		{
		}
	}
}