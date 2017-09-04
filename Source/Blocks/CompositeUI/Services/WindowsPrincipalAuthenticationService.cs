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
using System.Security.Principal;

namespace Microsoft.Practices.CompositeUI.Services
{
	/// <summary>
	/// Implementation of <see cref="IAuthenticationService"/> that 
	/// sets the current WindowsPrincipal as the principal policy.
	/// </summary>
	public class WindowsPrincipalAuthenticationService : IAuthenticationService
	{
		/// <summary>
		/// Authenticates the user.
		/// </summary>
		public void Authenticate()
		{
			// Set current principal.
			AppDomain.CurrentDomain.SetPrincipalPolicy(PrincipalPolicy.WindowsPrincipal);
		}
	}
}