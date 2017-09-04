#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;
using NaroCppCore.Occ.MMgt;
using NaroCppCore.Occ.TCollection;

#endregion

namespace NaroCppCore.Occ.MDF
{
	public class MDFASDriver : MMgtTShared
	{
			public void WriteMessage(TCollectionExtendedString theMessage)
				{
					MDF_ASDriver_WriteMessage6EE6EE89(Instance, theMessage.Instance);
				}
		[DllImport("NaroOccCore.dll")]
		private static extern void MDF_ASDriver_WriteMessage6EE6EE89(IntPtr instance, IntPtr theMessage);

		#region NativeInstancePtr Convert constructor

		public MDFASDriver() { } 

		public MDFASDriver(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ MDFASDriver_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void MDFASDriver_Dtor(IntPtr instance);
	}
}
