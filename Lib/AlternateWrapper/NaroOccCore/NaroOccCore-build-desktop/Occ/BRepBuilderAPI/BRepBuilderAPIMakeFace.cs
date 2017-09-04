#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;
using NaroCppCore.Occ.BRepBuilderAPI;
using NaroCppCore.Occ.TopoDS;
using NaroCppCore.Occ.gp;
using NaroCppCore.Occ.Geom;

#endregion

namespace NaroCppCore.Occ.BRepBuilderAPI
{
	public class BRepBuilderAPIMakeFace : BRepBuilderAPIMakeShape
	{
		public BRepBuilderAPIMakeFace()
 :
			base(BRepBuilderAPI_MakeFace_Ctor() )
		{}
		public BRepBuilderAPIMakeFace(TopoDSFace F)
 :
			base(BRepBuilderAPI_MakeFace_CtorAEC70AC1(F.Instance) )
		{}
		public BRepBuilderAPIMakeFace(gpPln P)
 :
			base(BRepBuilderAPI_MakeFace_Ctor9914D2AD(P.Instance) )
		{}
		public BRepBuilderAPIMakeFace(gpCylinder C)
 :
			base(BRepBuilderAPI_MakeFace_Ctor67FD6A6(C.Instance) )
		{}
		public BRepBuilderAPIMakeFace(gpCone C)
 :
			base(BRepBuilderAPI_MakeFace_Ctor25F8D29C(C.Instance) )
		{}
		public BRepBuilderAPIMakeFace(gpSphere S)
 :
			base(BRepBuilderAPI_MakeFace_Ctor95E480D1(S.Instance) )
		{}
		public BRepBuilderAPIMakeFace(gpTorus C)
 :
			base(BRepBuilderAPI_MakeFace_CtorC906A96F(C.Instance) )
		{}
		public BRepBuilderAPIMakeFace(GeomSurface S,double TolDegen)
 :
			base(BRepBuilderAPI_MakeFace_Ctor4C43CA45(S.Instance, TolDegen) )
		{}
		public BRepBuilderAPIMakeFace(gpPln P,double UMin,double UMax,double VMin,double VMax)
 :
			base(BRepBuilderAPI_MakeFace_CtorDD072DE5(P.Instance, UMin, UMax, VMin, VMax) )
		{}
		public BRepBuilderAPIMakeFace(gpCylinder C,double UMin,double UMax,double VMin,double VMax)
 :
			base(BRepBuilderAPI_MakeFace_Ctor1CF3267A(C.Instance, UMin, UMax, VMin, VMax) )
		{}
		public BRepBuilderAPIMakeFace(gpCone C,double UMin,double UMax,double VMin,double VMax)
 :
			base(BRepBuilderAPI_MakeFace_Ctor90A7A2D3(C.Instance, UMin, UMax, VMin, VMax) )
		{}
		public BRepBuilderAPIMakeFace(gpSphere S,double UMin,double UMax,double VMin,double VMax)
 :
			base(BRepBuilderAPI_MakeFace_CtorDF1FCE01(S.Instance, UMin, UMax, VMin, VMax) )
		{}
		public BRepBuilderAPIMakeFace(gpTorus C,double UMin,double UMax,double VMin,double VMax)
 :
			base(BRepBuilderAPI_MakeFace_Ctor126052F0(C.Instance, UMin, UMax, VMin, VMax) )
		{}
		public BRepBuilderAPIMakeFace(GeomSurface S,double UMin,double UMax,double VMin,double VMax,double TolDegen)
 :
			base(BRepBuilderAPI_MakeFace_Ctor8F43826(S.Instance, UMin, UMax, VMin, VMax, TolDegen) )
		{}
		public BRepBuilderAPIMakeFace(TopoDSWire W,bool OnlyPlane)
 :
			base(BRepBuilderAPI_MakeFace_CtorF673DC3(W.Instance, OnlyPlane) )
		{}
		public BRepBuilderAPIMakeFace(gpPln P,TopoDSWire W,bool Inside)
 :
			base(BRepBuilderAPI_MakeFace_CtorF0D4468(P.Instance, W.Instance, Inside) )
		{}
		public BRepBuilderAPIMakeFace(gpCylinder C,TopoDSWire W,bool Inside)
 :
			base(BRepBuilderAPI_MakeFace_Ctor7D92CEE4(C.Instance, W.Instance, Inside) )
		{}
		public BRepBuilderAPIMakeFace(gpCone C,TopoDSWire W,bool Inside)
 :
			base(BRepBuilderAPI_MakeFace_Ctor1AD3E6A2(C.Instance, W.Instance, Inside) )
		{}
		public BRepBuilderAPIMakeFace(gpSphere S,TopoDSWire W,bool Inside)
 :
			base(BRepBuilderAPI_MakeFace_Ctor9D6BF994(S.Instance, W.Instance, Inside) )
		{}
		public BRepBuilderAPIMakeFace(gpTorus C,TopoDSWire W,bool Inside)
 :
			base(BRepBuilderAPI_MakeFace_Ctor570E9DA5(C.Instance, W.Instance, Inside) )
		{}
		public BRepBuilderAPIMakeFace(GeomSurface S,TopoDSWire W,bool Inside)
 :
			base(BRepBuilderAPI_MakeFace_CtorC9D68572(S.Instance, W.Instance, Inside) )
		{}
		public BRepBuilderAPIMakeFace(TopoDSFace F,TopoDSWire W)
 :
			base(BRepBuilderAPI_MakeFace_Ctor15D7DFC2(F.Instance, W.Instance) )
		{}
			public void Init(TopoDSFace F)
				{
					BRepBuilderAPI_MakeFace_InitAEC70AC1(Instance, F.Instance);
				}
			public void Init(GeomSurface S,bool Bound,double TolDegen)
				{
					BRepBuilderAPI_MakeFace_Init78C1643F(Instance, S.Instance, Bound, TolDegen);
				}
			public void Init(GeomSurface S,double UMin,double UMax,double VMin,double VMax,double TolDegen)
				{
					BRepBuilderAPI_MakeFace_Init8F43826(Instance, S.Instance, UMin, UMax, VMin, VMax, TolDegen);
				}
			public void Add(TopoDSWire W)
				{
					BRepBuilderAPI_MakeFace_Add368EDFE5(Instance, W.Instance);
				}
		public bool IsDone{
			get {
				return BRepBuilderAPI_MakeFace_IsDone(Instance);
			}
		}
		public BRepBuilderAPIFaceError Error{
			get {
				return (BRepBuilderAPIFaceError)BRepBuilderAPI_MakeFace_Error(Instance);
			}
		}
		public TopoDSFace Face{
			get {
				return new TopoDSFace(BRepBuilderAPI_MakeFace_Face(Instance));
			}
		}
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr BRepBuilderAPI_MakeFace_Ctor();
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr BRepBuilderAPI_MakeFace_CtorAEC70AC1(IntPtr F);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr BRepBuilderAPI_MakeFace_Ctor9914D2AD(IntPtr P);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr BRepBuilderAPI_MakeFace_Ctor67FD6A6(IntPtr C);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr BRepBuilderAPI_MakeFace_Ctor25F8D29C(IntPtr C);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr BRepBuilderAPI_MakeFace_Ctor95E480D1(IntPtr S);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr BRepBuilderAPI_MakeFace_CtorC906A96F(IntPtr C);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr BRepBuilderAPI_MakeFace_Ctor4C43CA45(IntPtr S,double TolDegen);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr BRepBuilderAPI_MakeFace_CtorDD072DE5(IntPtr P,double UMin,double UMax,double VMin,double VMax);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr BRepBuilderAPI_MakeFace_Ctor1CF3267A(IntPtr C,double UMin,double UMax,double VMin,double VMax);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr BRepBuilderAPI_MakeFace_Ctor90A7A2D3(IntPtr C,double UMin,double UMax,double VMin,double VMax);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr BRepBuilderAPI_MakeFace_CtorDF1FCE01(IntPtr S,double UMin,double UMax,double VMin,double VMax);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr BRepBuilderAPI_MakeFace_Ctor126052F0(IntPtr C,double UMin,double UMax,double VMin,double VMax);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr BRepBuilderAPI_MakeFace_Ctor8F43826(IntPtr S,double UMin,double UMax,double VMin,double VMax,double TolDegen);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr BRepBuilderAPI_MakeFace_CtorF673DC3(IntPtr W,bool OnlyPlane);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr BRepBuilderAPI_MakeFace_CtorF0D4468(IntPtr P,IntPtr W,bool Inside);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr BRepBuilderAPI_MakeFace_Ctor7D92CEE4(IntPtr C,IntPtr W,bool Inside);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr BRepBuilderAPI_MakeFace_Ctor1AD3E6A2(IntPtr C,IntPtr W,bool Inside);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr BRepBuilderAPI_MakeFace_Ctor9D6BF994(IntPtr S,IntPtr W,bool Inside);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr BRepBuilderAPI_MakeFace_Ctor570E9DA5(IntPtr C,IntPtr W,bool Inside);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr BRepBuilderAPI_MakeFace_CtorC9D68572(IntPtr S,IntPtr W,bool Inside);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr BRepBuilderAPI_MakeFace_Ctor15D7DFC2(IntPtr F,IntPtr W);
		[DllImport("NaroOccCore.dll")]
		private static extern void BRepBuilderAPI_MakeFace_InitAEC70AC1(IntPtr instance, IntPtr F);
		[DllImport("NaroOccCore.dll")]
		private static extern void BRepBuilderAPI_MakeFace_Init78C1643F(IntPtr instance, IntPtr S,bool Bound,double TolDegen);
		[DllImport("NaroOccCore.dll")]
		private static extern void BRepBuilderAPI_MakeFace_Init8F43826(IntPtr instance, IntPtr S,double UMin,double UMax,double VMin,double VMax,double TolDegen);
		[DllImport("NaroOccCore.dll")]
		private static extern void BRepBuilderAPI_MakeFace_Add368EDFE5(IntPtr instance, IntPtr W);
		[DllImport("NaroOccCore.dll")]
		private static extern bool BRepBuilderAPI_MakeFace_IsDone(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern int BRepBuilderAPI_MakeFace_Error(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr BRepBuilderAPI_MakeFace_Face(IntPtr instance);

		#region NativeInstancePtr Convert constructor

		public BRepBuilderAPIMakeFace(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ BRepBuilderAPIMakeFace_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void BRepBuilderAPIMakeFace_Dtor(IntPtr instance);
	}
}
