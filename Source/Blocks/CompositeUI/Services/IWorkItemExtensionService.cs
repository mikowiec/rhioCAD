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

namespace Microsoft.Practices.CompositeUI.Services
{
	/// <summary>
	/// Service that manages the <see cref="IWorkItemExtension"/>s registration.
	/// </summary>
	public interface IWorkItemExtensionService
	{
		/// <summary>
		/// Gets a dictionary of the registered <see cref="WorkItem"/> extensions, where
		/// the key is the <see cref="WorkItem"/> type, and the value is a list of the
		/// types of classes that offer extensions for that <see cref="WorkItem"/>.
		/// </summary>
		ReadOnlyDictionary<Type, IList<Type>> RegisteredExtensions { get; }

		/// <summary>
		/// Gets a list of the registered root <see cref="WorkItem"/> extension class types.
		/// </summary>
		IList<Type> RegisteredRootExtensions { get; }

		/// <summary>
		/// Creates and initializes the extensions for the given <see cref="WorkItem"/>.
		/// </summary>
		/// <param name="workItem">The <see cref="WorkItem"/> to add the extensions to and initialize 
		/// the extensions for.</param>
		void InitializeExtensions(WorkItem workItem);

		/// <summary>
		/// Registers a type as an extension to a specific <see cref="WorkItem"/> type.
		/// </summary>
		/// <param name="workItemType">The type of <see cref="WorkItem"/> to be extended.</param>
		/// <param name="extensionType">The type of the class to perform the extension.</param>
		void RegisterExtension(Type workItemType, Type extensionType);

		/// <summary>
		/// Registers a type as an extension to the root <see cref="WorkItem"/>.
		/// </summary>
		/// <param name="extensionType">The type of the class to perform the extension.</param>
		void RegisterRootExtension(Type extensionType);
	}
}