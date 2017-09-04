#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;
using NaroCppCore.Occ.BRepPrimAPI;
using NaroCppCore.Occ.gp;

#endregion

namespace NaroCppCore.Occ.BRepPrimAPI
{
	public class BRepPrimAPIMakeTorus : BRepPrimAPIMakeOneAxis
	{
		public BRepPrimAPIMakeTorus(double R1,double R2)
 :
			base(BRepPrimAPI_MakeTorus_Ctor9F0E714F(R1, R2) )
		{}
		public BRepPrimAPIMakeTorus(double R1,double R2,double angle)
 :
			base(BRepPrimAPI_MakeTorus_Ctor9282A951(R1, R2, angle) )
		{}
		public BRepPrimAPIMakeTorus(double R1,double R2,double angle1,double angle2)
 :
			base(BRepPrimAPI_MakeTorus_CtorC2777E0C(R1, R2, angle1, angle2) )
		{}
		public BRepPrimAPIMakeTorus(double R1,double R2,double angle1,double angle2,double angle)
 :
			base(BRepPrimAPI_MakeTorus_Ctor216AF150(R1, R2, angle1, angle2, angle) )
		{}
		public BRepPrimAPIMakeTorus(gpAx2 Axes,double R1,double R2)
 :
			base(BRepPrimAPI_MakeTorus_CtorB1A3BD2A(Axes.Instance, R1, R2) )
		{}
		public BRepPrimAPIMakeTorus(gpAx2 Axes,double R1,double R2,double angle)
 :
			base(BRepPrimAPI_MakeTorus_CtorF0200AF(Axes.Instance, R1, R2, angle) )
		{}
		public BRepPrimAPIMakeTorus(gpAx2 Axes,double R1,double R2,double angle1,double angle2)
 :
			base(BRepPrimAPI_MakeTorus_Ctor77315A3D(Axes.Instance, R1, R2, angle1, angle2) )
		{}
		public BRepPrimAPIMakeTorus(gpAx2 Axes,double R1,double R2,double angle1,double angle2,double angle)
 :
			base(BRepPrimAPI_MakeTorus_CtorDC3808AF(Axes.Instance, R1, R2, angle1, angle2, angle) )
		{}
		public IntPtr OneAxis{
			get {
				return BRepPrimAPI_MakeTorus_OneAxis(Instance);
			}
		}
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr BRepPrimAPI_MakeTorus_Ctor9F0E714F(double R1,double R2);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr BRepPrimAPI_MakeTorus_Ctor9282A951(double R1,double R2,double angle);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr BRepPrimAPI_MakeTorus_CtorC2777E0C(double R1,double R2,double angle1,double angle2);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr BRepPrimAPI_MakeTorus_Ctor216AF150(double R1,double R2,double angle1,double angle2,double angle);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr BRepPrimAPI_MakeTorus_CtorB1A3BD2A(IntPtr Axes,double R1,double R2);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr BRepPrimAPI_MakeTorus_CtorF0200AF(IntPtr Axes,double R1,double R2,double angle);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr BRepPrimAPI_MakeTorus_Ctor77315A3D(IntPtr Axes,double R1,double R2,double angle1,double angle2);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr BRepPrimAPI_MakeTorus_CtorDC3808AF(IntPtr Axes,double R1,double R2,double angle1,double angle2,double angle);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr BRepPrimAPI_MakeTorus_OneAxis(IntPtr instance);

		#region NativeInstancePtr Convert constructor

		public BRepPrimAPIMakeTorus() { } 

		public BRepPrimAPIMakeTorus(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ BRepPrimAPIMakeTorus_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void BRepPrimAPIMakeTorus_Dtor(IntPtr instance);
	}
}
