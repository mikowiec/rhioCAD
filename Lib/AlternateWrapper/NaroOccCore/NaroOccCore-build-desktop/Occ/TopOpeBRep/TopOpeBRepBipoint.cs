#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;

#endregion

namespace NaroCppCore.Occ.TopOpeBRep
{
	public class TopOpeBRepBipoint : NativeInstancePtr
	{
		public TopOpeBRepBipoint()
 :
			base(TopOpeBRep_Bipoint_Ctor() )
		{}
		public TopOpeBRepBipoint(int I1,int I2)
 :
			base(TopOpeBRep_Bipoint_Ctor5107F6FE(I1, I2) )
		{}
		public int I1{
			get {
				return TopOpeBRep_Bipoint_I1(Instance);
			}
		}
		public int I2{
			get {
				return TopOpeBRep_Bipoint_I2(Instance);
			}
		}
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr TopOpeBRep_Bipoint_Ctor();
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr TopOpeBRep_Bipoint_Ctor5107F6FE(int I1,int I2);
		[DllImport("NaroOccCore.dll")]
		private static extern int TopOpeBRep_Bipoint_I1(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern int TopOpeBRep_Bipoint_I2(IntPtr instance);

		#region NativeInstancePtr Convert constructor

		public TopOpeBRepBipoint(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ TopOpeBRepBipoint_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void TopOpeBRepBipoint_Dtor(IntPtr instance);
	}
}
