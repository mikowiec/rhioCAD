#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;
using NaroCppCore.Occ.MMgt;

#endregion

namespace NaroCppCore.Occ.StepData
{
	public class StepDataEDescr : MMgtTShared
	{

		#region NativeInstancePtr Convert constructor

		public StepDataEDescr() { } 

		public StepDataEDescr(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ StepDataEDescr_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void StepDataEDescr_Dtor(IntPtr instance);
	}
}
