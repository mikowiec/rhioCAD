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
using System.Threading;

namespace Microsoft.Practices.CompositeUI
{
	/// <summary>
	/// Helper class that makes it easier to ensure proper usage of a <see cref="ReaderWriterLock"/> 
	/// for writers by providing support for <see cref="IDisposable"/> and the using keyword.
	/// </summary>
	/// <example>
	/// Common usage is as follows:
	/// <code>
	/// ReaderWriterLock mylock = new ReaderWriterLock();
	/// 
	/// // Inside some method
	/// using (new WriterLock(rwLock))
	///	{
	///		// Do your safe resource write accesses here.
	///	}
	/// </code>
	/// If a timeout is specified, the <see cref="LockBase.TimedOut"/> property should be checked inside the 
	/// using statement:
	/// <code>
	/// ReaderWriterLock mylock = new ReaderWriterLock();
	/// 
	/// // Inside some method
	/// using (WriterLock l = new WriterLock(rwLock, 100))
	///	{
	///		if (l.TimedOut == false)
	///		{
	///			// Do your safe resource write accesses here.
	///		}
	///		else
	///		{
	///			throw new InvalidOperationException("Could not lock the resource.");
	///		}
	///	}
	/// </code>
	/// </example>
	public class WriterLock : LockBase
	{
		/// <summary>
		/// Acquires a reader lock on the rwLock received 
		/// with no timeout specified.
		/// </summary>
		public WriterLock(ReaderWriterLock rwLock)
			: base(new AcquireIntTimeoutMethod(rwLock.AcquireWriterLock),
			new ReleaseMethod(rwLock.ReleaseWriterLock), -1) { }

		/// <summary>
		/// Tries to acquire a reader lock on the rwLock received 
		/// with the timeout specified. 
		/// </summary>
		public WriterLock(ReaderWriterLock rwLock, int millisecondsTimeout)
			: base(new AcquireIntTimeoutMethod(rwLock.AcquireWriterLock),
			new ReleaseMethod(rwLock.ReleaseWriterLock), millisecondsTimeout) { }

		/// <summary>
		/// Tries to acquire a reader lock on the rwLock received 
		/// with the timeout specified. 
		/// </summary>
		public WriterLock(ReaderWriterLock rwLock, TimeSpan timeout)
			: base(new AcquireTimeSpanTimeoutMethod(rwLock.AcquireWriterLock),
			new ReleaseMethod(rwLock.ReleaseWriterLock), timeout) { }
	}
}
