#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;
using NaroCppCore.Occ.BRepPrimAPI;
using NaroCppCore.Occ.gp;

#endregion

namespace NaroCppCore.Occ.BRepPrimAPI
{
	public class BRepPrimAPIMakeSphere : BRepPrimAPIMakeOneAxis
	{
		public BRepPrimAPIMakeSphere(double R)
 :
			base(BRepPrimAPI_MakeSphere_CtorD82819F3(R) )
		{}
		public BRepPrimAPIMakeSphere(double R,double angle)
 :
			base(BRepPrimAPI_MakeSphere_Ctor9F0E714F(R, angle) )
		{}
		public BRepPrimAPIMakeSphere(double R,double angle1,double angle2)
 :
			base(BRepPrimAPI_MakeSphere_Ctor9282A951(R, angle1, angle2) )
		{}
		public BRepPrimAPIMakeSphere(double R,double angle1,double angle2,double angle3)
 :
			base(BRepPrimAPI_MakeSphere_CtorC2777E0C(R, angle1, angle2, angle3) )
		{}
		public BRepPrimAPIMakeSphere(gpPnt Center,double R)
 :
			base(BRepPrimAPI_MakeSphere_CtorF0D1E3E6(Center.Instance, R) )
		{}
		public BRepPrimAPIMakeSphere(gpPnt Center,double R,double angle)
 :
			base(BRepPrimAPI_MakeSphere_Ctor9515F856(Center.Instance, R, angle) )
		{}
		public BRepPrimAPIMakeSphere(gpPnt Center,double R,double angle1,double angle2)
 :
			base(BRepPrimAPI_MakeSphere_Ctor22BACD62(Center.Instance, R, angle1, angle2) )
		{}
		public BRepPrimAPIMakeSphere(gpPnt Center,double R,double angle1,double angle2,double angle3)
 :
			base(BRepPrimAPI_MakeSphere_CtorD969C62A(Center.Instance, R, angle1, angle2, angle3) )
		{}
		public BRepPrimAPIMakeSphere(gpAx2 Axis,double R)
 :
			base(BRepPrimAPI_MakeSphere_Ctor673FA07D(Axis.Instance, R) )
		{}
		public BRepPrimAPIMakeSphere(gpAx2 Axis,double R,double angle)
 :
			base(BRepPrimAPI_MakeSphere_CtorB1A3BD2A(Axis.Instance, R, angle) )
		{}
		public BRepPrimAPIMakeSphere(gpAx2 Axis,double R,double angle1,double angle2)
 :
			base(BRepPrimAPI_MakeSphere_CtorF0200AF(Axis.Instance, R, angle1, angle2) )
		{}
		public BRepPrimAPIMakeSphere(gpAx2 Axis,double R,double angle1,double angle2,double angle3)
 :
			base(BRepPrimAPI_MakeSphere_Ctor77315A3D(Axis.Instance, R, angle1, angle2, angle3) )
		{}
		public IntPtr OneAxis{
			get {
				return BRepPrimAPI_MakeSphere_OneAxis(Instance);
			}
		}
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr BRepPrimAPI_MakeSphere_CtorD82819F3(double R);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr BRepPrimAPI_MakeSphere_Ctor9F0E714F(double R,double angle);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr BRepPrimAPI_MakeSphere_Ctor9282A951(double R,double angle1,double angle2);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr BRepPrimAPI_MakeSphere_CtorC2777E0C(double R,double angle1,double angle2,double angle3);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr BRepPrimAPI_MakeSphere_CtorF0D1E3E6(IntPtr Center,double R);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr BRepPrimAPI_MakeSphere_Ctor9515F856(IntPtr Center,double R,double angle);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr BRepPrimAPI_MakeSphere_Ctor22BACD62(IntPtr Center,double R,double angle1,double angle2);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr BRepPrimAPI_MakeSphere_CtorD969C62A(IntPtr Center,double R,double angle1,double angle2,double angle3);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr BRepPrimAPI_MakeSphere_Ctor673FA07D(IntPtr Axis,double R);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr BRepPrimAPI_MakeSphere_CtorB1A3BD2A(IntPtr Axis,double R,double angle);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr BRepPrimAPI_MakeSphere_CtorF0200AF(IntPtr Axis,double R,double angle1,double angle2);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr BRepPrimAPI_MakeSphere_Ctor77315A3D(IntPtr Axis,double R,double angle1,double angle2,double angle3);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr BRepPrimAPI_MakeSphere_OneAxis(IntPtr instance);

		#region NativeInstancePtr Convert constructor

		public BRepPrimAPIMakeSphere() { } 

		public BRepPrimAPIMakeSphere(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ BRepPrimAPIMakeSphere_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void BRepPrimAPIMakeSphere_Dtor(IntPtr instance);
	}
}
