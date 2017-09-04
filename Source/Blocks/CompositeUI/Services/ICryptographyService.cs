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
	/// Service that exposes cryptography methods to encrypt and decrypt data.
	/// </summary>
	public interface ICryptographyService
	{
		/// <summary>
		/// Encrypts data using a specified symmetric cryptography provider.
		/// </summary>
		/// <param name="plainText">The input data to encrypt.</param>
		/// <returns>The resulting cipher text.</returns>
		byte[] EncryptSymmetric(byte[] plainText);

		/// <summary>
		/// Decrypts a cipher text using a specified symmetric cryptography provider.
		/// </summary>
		/// <param name="cipherText">The cipher text for which you want to decrypt.</param>
		/// <returns>The resulting plain text.</returns>
		byte[] DecryptSymmetric(byte[] cipherText);

	}
}