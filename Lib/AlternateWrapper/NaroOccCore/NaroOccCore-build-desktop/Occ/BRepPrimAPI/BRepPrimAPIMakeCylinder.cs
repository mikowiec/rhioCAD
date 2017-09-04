#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;
using NaroCppCore.Occ.BRepPrimAPI;
using NaroCppCore.Occ.gp;

#endregion

namespace NaroCppCore.Occ.BRepPrimAPI
{
	public class BRepPrimAPIMakeCylinder : BRepPrimAPIMakeOneAxis
	{
		public BRepPrimAPIMakeCylinder(double R,double H)
 :
			base(BRepPrimAPI_MakeCylinder_Ctor9F0E714F(R, H) )
		{}
		public BRepPrimAPIMakeCylinder(double R,double H,double Angle)
 :
			base(BRepPrimAPI_MakeCylinder_Ctor9282A951(R, H, Angle) )
		{}
		public BRepPrimAPIMakeCylinder(gpAx2 Axes,double R,double H)
 :
			base(BRepPrimAPI_MakeCylinder_CtorB1A3BD2A(Axes.Instance, R, H) )
		{}
		public BRepPrimAPIMakeCylinder(gpAx2 Axes,double R,double H,double Angle)
 :
			base(BRepPrimAPI_MakeCylinder_CtorF0200AF(Axes.Instance, R, H, Angle) )
		{}
		public IntPtr OneAxis{
			get {
				return BRepPrimAPI_MakeCylinder_OneAxis(Instance);
			}
		}
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr BRepPrimAPI_MakeCylinder_Ctor9F0E714F(double R,double H);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr BRepPrimAPI_MakeCylinder_Ctor9282A951(double R,double H,double Angle);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr BRepPrimAPI_MakeCylinder_CtorB1A3BD2A(IntPtr Axes,double R,double H);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr BRepPrimAPI_MakeCylinder_CtorF0200AF(IntPtr Axes,double R,double H,double Angle);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr BRepPrimAPI_MakeCylinder_OneAxis(IntPtr instance);

		#region NativeInstancePtr Convert constructor

		public BRepPrimAPIMakeCylinder() { } 

		public BRepPrimAPIMakeCylinder(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ BRepPrimAPIMakeCylinder_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void BRepPrimAPIMakeCylinder_Dtor(IntPtr instance);
	}
}
