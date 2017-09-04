#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;
using NaroCppCore.Occ.BRepPrimAPI;
using NaroCppCore.Occ.gp;

#endregion

namespace NaroCppCore.Occ.BRepPrimAPI
{
	public class BRepPrimAPIMakeCone : BRepPrimAPIMakeOneAxis
	{
		public BRepPrimAPIMakeCone(double R1,double R2,double H)
 :
			base(BRepPrimAPI_MakeCone_Ctor9282A951(R1, R2, H) )
		{}
		public BRepPrimAPIMakeCone(double R1,double R2,double H,double angle)
 :
			base(BRepPrimAPI_MakeCone_CtorC2777E0C(R1, R2, H, angle) )
		{}
		public BRepPrimAPIMakeCone(gpAx2 Axes,double R1,double R2,double H)
 :
			base(BRepPrimAPI_MakeCone_CtorF0200AF(Axes.Instance, R1, R2, H) )
		{}
		public BRepPrimAPIMakeCone(gpAx2 Axes,double R1,double R2,double H,double angle)
 :
			base(BRepPrimAPI_MakeCone_Ctor77315A3D(Axes.Instance, R1, R2, H, angle) )
		{}
		public IntPtr OneAxis{
			get {
				return BRepPrimAPI_MakeCone_OneAxis(Instance);
			}
		}
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr BRepPrimAPI_MakeCone_Ctor9282A951(double R1,double R2,double H);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr BRepPrimAPI_MakeCone_CtorC2777E0C(double R1,double R2,double H,double angle);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr BRepPrimAPI_MakeCone_CtorF0200AF(IntPtr Axes,double R1,double R2,double H);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr BRepPrimAPI_MakeCone_Ctor77315A3D(IntPtr Axes,double R1,double R2,double H,double angle);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr BRepPrimAPI_MakeCone_OneAxis(IntPtr instance);

		#region NativeInstancePtr Convert constructor

		public BRepPrimAPIMakeCone() { } 

		public BRepPrimAPIMakeCone(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ BRepPrimAPIMakeCone_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void BRepPrimAPIMakeCone_Dtor(IntPtr instance);
	}
}
