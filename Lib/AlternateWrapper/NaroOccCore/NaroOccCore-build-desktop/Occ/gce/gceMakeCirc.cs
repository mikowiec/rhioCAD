#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;
using NaroCppCore.Occ.gce;
using NaroCppCore.Occ.gp;

#endregion

namespace NaroCppCore.Occ.gce
{
	public class gceMakeCirc : gceRoot
	{
		public gceMakeCirc(gpAx2 A2,double Radius)
 :
			base(gce_MakeCirc_Ctor673FA07D(A2.Instance, Radius) )
		{}
		public gceMakeCirc(gpCirc Circ,double Dist)
 :
			base(gce_MakeCirc_Ctor941DBF06(Circ.Instance, Dist) )
		{}
		public gceMakeCirc(gpCirc Circ,gpPnt Point)
 :
			base(gce_MakeCirc_Ctor89B70D29(Circ.Instance, Point.Instance) )
		{}
		public gceMakeCirc(gpPnt P1,gpPnt P2,gpPnt P3)
 :
			base(gce_MakeCirc_Ctor4B855FC1(P1.Instance, P2.Instance, P3.Instance) )
		{}
		public gceMakeCirc(gpPnt Center,gpDir Norm,double Radius)
 :
			base(gce_MakeCirc_Ctor9327D37B(Center.Instance, Norm.Instance, Radius) )
		{}
		public gceMakeCirc(gpPnt Center,gpPln Plane,double Radius)
 :
			base(gce_MakeCirc_CtorE73602A3(Center.Instance, Plane.Instance, Radius) )
		{}
		public gceMakeCirc(gpPnt Center,gpPnt Ptaxis,double Radius)
 :
			base(gce_MakeCirc_CtorB8940259(Center.Instance, Ptaxis.Instance, Radius) )
		{}
		public gceMakeCirc(gpAx1 Axis,double Radius)
 :
			base(gce_MakeCirc_Ctor827CB19A(Axis.Instance, Radius) )
		{}
		public gpCirc Value{
			get {
				return new gpCirc(gce_MakeCirc_Value(Instance));
			}
		}
		public gpCirc Operator{
			get {
				return new gpCirc(gce_MakeCirc_Operator(Instance));
			}
		}
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gce_MakeCirc_Ctor673FA07D(IntPtr A2,double Radius);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gce_MakeCirc_Ctor941DBF06(IntPtr Circ,double Dist);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gce_MakeCirc_Ctor89B70D29(IntPtr Circ,IntPtr Point);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gce_MakeCirc_Ctor4B855FC1(IntPtr P1,IntPtr P2,IntPtr P3);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gce_MakeCirc_Ctor9327D37B(IntPtr Center,IntPtr Norm,double Radius);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gce_MakeCirc_CtorE73602A3(IntPtr Center,IntPtr Plane,double Radius);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gce_MakeCirc_CtorB8940259(IntPtr Center,IntPtr Ptaxis,double Radius);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gce_MakeCirc_Ctor827CB19A(IntPtr Axis,double Radius);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gce_MakeCirc_Value(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gce_MakeCirc_Operator(IntPtr instance);

		#region NativeInstancePtr Convert constructor

		public gceMakeCirc() { } 

		public gceMakeCirc(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ gceMakeCirc_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void gceMakeCirc_Dtor(IntPtr instance);
	}
}
