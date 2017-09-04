#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;
using NaroCppCore.Occ.GC;
using NaroCppCore.Occ.Geom;
using NaroCppCore.Occ.gp;

#endregion

namespace NaroCppCore.Occ.GC
{
	public class GCMakePlane : GCRoot
	{
		public GCMakePlane(gpAx2 A2)
 :
			base(GC_MakePlane_Ctor7895386A(A2.Instance) )
		{}
		public GCMakePlane(gpPln Pl)
 :
			base(GC_MakePlane_Ctor9914D2AD(Pl.Instance) )
		{}
		public GCMakePlane(gpPnt P,gpDir V)
 :
			base(GC_MakePlane_CtorE13B639C(P.Instance, V.Instance) )
		{}
		public GCMakePlane(double A,double B,double C,double D)
 :
			base(GC_MakePlane_CtorC2777E0C(A, B, C, D) )
		{}
		public GCMakePlane(gpPln Pln,gpPnt Point)
 :
			base(GC_MakePlane_Ctor10B48A70(Pln.Instance, Point.Instance) )
		{}
		public GCMakePlane(gpPln Pln,double Dist)
 :
			base(GC_MakePlane_Ctor6FF7E7CC(Pln.Instance, Dist) )
		{}
		public GCMakePlane(gpPnt P1,gpPnt P2,gpPnt P3)
 :
			base(GC_MakePlane_Ctor4B855FC1(P1.Instance, P2.Instance, P3.Instance) )
		{}
		public GCMakePlane(gpAx1 Axis)
 :
			base(GC_MakePlane_Ctor608B963B(Axis.Instance) )
		{}
		public GeomPlane Value{
			get {
				return new GeomPlane(GC_MakePlane_Value(Instance));
			}
		}
		public GeomPlane Operator{
			get {
				return new GeomPlane(GC_MakePlane_Operator(Instance));
			}
		}
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr GC_MakePlane_Ctor7895386A(IntPtr A2);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr GC_MakePlane_Ctor9914D2AD(IntPtr Pl);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr GC_MakePlane_CtorE13B639C(IntPtr P,IntPtr V);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr GC_MakePlane_CtorC2777E0C(double A,double B,double C,double D);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr GC_MakePlane_Ctor10B48A70(IntPtr Pln,IntPtr Point);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr GC_MakePlane_Ctor6FF7E7CC(IntPtr Pln,double Dist);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr GC_MakePlane_Ctor4B855FC1(IntPtr P1,IntPtr P2,IntPtr P3);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr GC_MakePlane_Ctor608B963B(IntPtr Axis);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr GC_MakePlane_Value(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr GC_MakePlane_Operator(IntPtr instance);

		#region NativeInstancePtr Convert constructor

		public GCMakePlane() { } 

		public GCMakePlane(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ GCMakePlane_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void GCMakePlane_Dtor(IntPtr instance);
	}
}
