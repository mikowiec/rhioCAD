#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;

#endregion

namespace NaroCppCore.Occ.HLRAlgo
{
	public class HLRAlgoCoincidence : NativeInstancePtr
	{
		public HLRAlgoCoincidence()
 :
			base(HLRAlgo_Coincidence_Ctor() )
		{}
			public void Set2D(int FE,double Param)
				{
					HLRAlgo_Coincidence_Set2D69F5FCCD(Instance, FE, Param);
				}
			public void Value2D(ref int FE,ref double Param)
				{
					HLRAlgo_Coincidence_Value2D69F5FCCD(Instance, ref FE, ref Param);
				}
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr HLRAlgo_Coincidence_Ctor();
		[DllImport("NaroOccCore.dll")]
		private static extern void HLRAlgo_Coincidence_Set2D69F5FCCD(IntPtr instance, int FE,double Param);
		[DllImport("NaroOccCore.dll")]
		private static extern void HLRAlgo_Coincidence_Value2D69F5FCCD(IntPtr instance, ref int FE,ref double Param);

		#region NativeInstancePtr Convert constructor

		public HLRAlgoCoincidence(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ HLRAlgoCoincidence_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void HLRAlgoCoincidence_Dtor(IntPtr instance);
	}
}
