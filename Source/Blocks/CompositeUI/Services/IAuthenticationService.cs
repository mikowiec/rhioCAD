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

namespace Microsoft.Practices.CompositeUI.Services
{
	/// <summary>
	/// Service that performs the authentication of the current user.
	/// </summary>
	public interface IAuthenticationService
	{
		/// <summary>
		/// This method is expected to set the appropriate 
		/// implementation of an <see cref="System.Security.Principal.IPrincipal"/> on the thread 
		/// and optionally call <see cref="System.AppDomain.SetPrincipalPolicy"/> and <see cref="System.AppDomain.SetThreadPrincipal"/>.
		/// </summary>
		void Authenticate();
	}
}