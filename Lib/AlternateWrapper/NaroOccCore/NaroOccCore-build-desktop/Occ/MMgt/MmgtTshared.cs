#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;
using NaroCppCore.Occ.Standard;

#endregion

namespace NaroCppCore.Occ.MMgt
{
	public class MMgtTShared : StandardTransient
	{
			public void Delete()
				{
					MMgt_TShared_Delete(Instance);
				}
		[DllImport("NaroOccCore.dll")]
		private static extern void MMgt_TShared_Delete(IntPtr instance);

		#region NativeInstancePtr Convert constructor

		public MMgtTShared() { } 

		public MMgtTShared(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ MMgtTShared_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void MMgtTShared_Dtor(IntPtr instance);
	}
}
