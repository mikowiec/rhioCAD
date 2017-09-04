#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;
using NaroCppCore.Occ.MMgt;

#endregion

namespace NaroCppCore.Occ.Law
{
	public class LawFunction : MMgtTShared
	{

		#region NativeInstancePtr Convert constructor

		public LawFunction() { } 

		public LawFunction(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ LawFunction_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void LawFunction_Dtor(IntPtr instance);
	}
}
