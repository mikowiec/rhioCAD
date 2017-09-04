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
	public class GCMakeArcOfCircle : GCRoot
	{
		public GCMakeArcOfCircle(gpCirc Circ,double Alpha1,double Alpha2,bool Sense)
 :
			base(GC_MakeArcOfCircle_CtorB4ED9646(Circ.Instance, Alpha1, Alpha2, Sense) )
		{}
		public GCMakeArcOfCircle(gpCirc Circ,gpPnt P,double Alpha,bool Sense)
 :
			base(GC_MakeArcOfCircle_CtorF0177DDE(Circ.Instance, P.Instance, Alpha, Sense) )
		{}
		public GCMakeArcOfCircle(gpCirc Circ,gpPnt P1,gpPnt P2,bool Sense)
 :
			base(GC_MakeArcOfCircle_CtorFA26BC9F(Circ.Instance, P1.Instance, P2.Instance, Sense) )
		{}
		public GCMakeArcOfCircle(gpPnt P1,gpPnt P2,gpPnt P3)
 :
			base(GC_MakeArcOfCircle_Ctor4B855FC1(P1.Instance, P2.Instance, P3.Instance) )
		{}
		public GCMakeArcOfCircle(gpPnt P1,gpVec V,gpPnt P2)
 :
			base(GC_MakeArcOfCircle_Ctor5450E69C(P1.Instance, V.Instance, P2.Instance) )
		{}
		public GeomTrimmedCurve Value{
			get {
				return new GeomTrimmedCurve(GC_MakeArcOfCircle_Value(Instance));
			}
		}
		public GeomTrimmedCurve Operator{
			get {
				return new GeomTrimmedCurve(GC_MakeArcOfCircle_Operator(Instance));
			}
		}
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr GC_MakeArcOfCircle_CtorB4ED9646(IntPtr Circ,double Alpha1,double Alpha2,bool Sense);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr GC_MakeArcOfCircle_CtorF0177DDE(IntPtr Circ,IntPtr P,double Alpha,bool Sense);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr GC_MakeArcOfCircle_CtorFA26BC9F(IntPtr Circ,IntPtr P1,IntPtr P2,bool Sense);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr GC_MakeArcOfCircle_Ctor4B855FC1(IntPtr P1,IntPtr P2,IntPtr P3);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr GC_MakeArcOfCircle_Ctor5450E69C(IntPtr P1,IntPtr V,IntPtr P2);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr GC_MakeArcOfCircle_Value(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr GC_MakeArcOfCircle_Operator(IntPtr instance);

		#region NativeInstancePtr Convert constructor

		public GCMakeArcOfCircle() { } 

		public GCMakeArcOfCircle(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ GCMakeArcOfCircle_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void GCMakeArcOfCircle_Dtor(IntPtr instance);
	}
}
