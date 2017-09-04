#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;
using NaroCppCore.Occ.GeomAbs;
using NaroCppCore.Occ.TopoDS;
using NaroCppCore.Occ.Bnd;
using NaroCppCore.Occ.gp;
using NaroCppCore.Occ.Adaptor3d;
using NaroCppCore.Occ.IntCurveSurface;
using NaroCppCore.Occ.TopAbs;

#endregion

namespace NaroCppCore.Occ.IntCurvesFace
{
	public class IntCurvesFaceIntersector : NativeInstancePtr
	{
		public IntCurvesFaceIntersector(TopoDSFace F,double aTol)
 :
			base(IntCurvesFace_Intersector_Ctor5D6B238E(F.Instance, aTol) )
		{}
			public void Perform(gpLin L,double PInf,double PSup)
				{
					IntCurvesFace_Intersector_Perform13A123E9(Instance, L.Instance, PInf, PSup);
				}
			public void Perform(Adaptor3dHCurve HCu,double PInf,double PSup)
				{
					IntCurvesFace_Intersector_Perform42BE7C73(Instance, HCu.Instance, PInf, PSup);
				}
			public double UParameter(int I)
				{
					return IntCurvesFace_Intersector_UParameterE8219145(Instance, I);
				}
			public double VParameter(int I)
				{
					return IntCurvesFace_Intersector_VParameterE8219145(Instance, I);
				}
			public double WParameter(int I)
				{
					return IntCurvesFace_Intersector_WParameterE8219145(Instance, I);
				}
			public gpPnt Pnt(int I)
				{
					return new gpPnt(IntCurvesFace_Intersector_PntE8219145(Instance, I));
				}
			public IntCurveSurfaceTransitionOnCurve Transition(int I)
				{
					return (IntCurveSurfaceTransitionOnCurve)IntCurvesFace_Intersector_TransitionE8219145(Instance, I);
				}
			public TopAbsState State(int I)
				{
					return (TopAbsState)IntCurvesFace_Intersector_StateE8219145(Instance, I);
				}
			public TopAbsState ClassifyUVPoint(gpPnt2d Puv)
				{
					return (TopAbsState)IntCurvesFace_Intersector_ClassifyUVPoint6203658C(Instance, Puv.Instance);
				}
		public GeomAbsSurfaceType SurfaceType{
			get {
				return (GeomAbsSurfaceType)IntCurvesFace_Intersector_SurfaceType(Instance);
			}
		}
		public bool IsDone{
			get {
				return IntCurvesFace_Intersector_IsDone(Instance);
			}
		}
		public int NbPnt{
			get {
				return IntCurvesFace_Intersector_NbPnt(Instance);
			}
		}
		public TopoDSFace Face{
			get {
				return new TopoDSFace(IntCurvesFace_Intersector_Face(Instance));
			}
		}
		public BndBox Bounding{
			get {
				return new BndBox(IntCurvesFace_Intersector_Bounding(Instance));
			}
		}
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr IntCurvesFace_Intersector_Ctor5D6B238E(IntPtr F,double aTol);
		[DllImport("NaroOccCore.dll")]
		private static extern void IntCurvesFace_Intersector_Perform13A123E9(IntPtr instance, IntPtr L,double PInf,double PSup);
		[DllImport("NaroOccCore.dll")]
		private static extern void IntCurvesFace_Intersector_Perform42BE7C73(IntPtr instance, IntPtr HCu,double PInf,double PSup);
		[DllImport("NaroOccCore.dll")]
		private static extern double IntCurvesFace_Intersector_UParameterE8219145(IntPtr instance, int I);
		[DllImport("NaroOccCore.dll")]
		private static extern double IntCurvesFace_Intersector_VParameterE8219145(IntPtr instance, int I);
		[DllImport("NaroOccCore.dll")]
		private static extern double IntCurvesFace_Intersector_WParameterE8219145(IntPtr instance, int I);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr IntCurvesFace_Intersector_PntE8219145(IntPtr instance, int I);
		[DllImport("NaroOccCore.dll")]
		private static extern int IntCurvesFace_Intersector_TransitionE8219145(IntPtr instance, int I);
		[DllImport("NaroOccCore.dll")]
		private static extern int IntCurvesFace_Intersector_StateE8219145(IntPtr instance, int I);
		[DllImport("NaroOccCore.dll")]
		private static extern int IntCurvesFace_Intersector_ClassifyUVPoint6203658C(IntPtr instance, IntPtr Puv);
		[DllImport("NaroOccCore.dll")]
		private static extern int IntCurvesFace_Intersector_SurfaceType(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool IntCurvesFace_Intersector_IsDone(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern int IntCurvesFace_Intersector_NbPnt(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr IntCurvesFace_Intersector_Face(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr IntCurvesFace_Intersector_Bounding(IntPtr instance);

		#region NativeInstancePtr Convert constructor

		public IntCurvesFaceIntersector() { } 

		public IntCurvesFaceIntersector(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ IntCurvesFaceIntersector_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void IntCurvesFaceIntersector_Dtor(IntPtr instance);
	}
}
