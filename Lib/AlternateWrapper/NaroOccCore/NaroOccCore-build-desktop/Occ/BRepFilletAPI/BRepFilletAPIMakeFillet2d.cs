#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;
using NaroCppCore.Occ.BRepBuilderAPI;
using NaroCppCore.Occ.ChFi2d;
using NaroCppCore.Occ.TopoDS;

#endregion

namespace NaroCppCore.Occ.BRepFilletAPI
{
	public class BRepFilletAPIMakeFillet2d : BRepBuilderAPIMakeShape
	{
		public BRepFilletAPIMakeFillet2d()
 :
			base(BRepFilletAPI_MakeFillet2d_Ctor() )
		{}
		public BRepFilletAPIMakeFillet2d(TopoDSFace F)
 :
			base(BRepFilletAPI_MakeFillet2d_CtorAEC70AC1(F.Instance) )
		{}
			public void Init(TopoDSFace F)
				{
					BRepFilletAPI_MakeFillet2d_InitAEC70AC1(Instance, F.Instance);
				}
			public void Init(TopoDSFace RefFace,TopoDSFace ModFace)
				{
					BRepFilletAPI_MakeFillet2d_Init9D93DFBA(Instance, RefFace.Instance, ModFace.Instance);
				}
			public TopoDSEdge AddFillet(TopoDSVertex V,double Radius)
				{
					return new TopoDSEdge(BRepFilletAPI_MakeFillet2d_AddFillet729B627B(Instance, V.Instance, Radius));
				}
			public TopoDSEdge ModifyFillet(TopoDSEdge Fillet,double Radius)
				{
					return new TopoDSEdge(BRepFilletAPI_MakeFillet2d_ModifyFillet809BA47B(Instance, Fillet.Instance, Radius));
				}
			public TopoDSVertex RemoveFillet(TopoDSEdge Fillet)
				{
					return new TopoDSVertex(BRepFilletAPI_MakeFillet2d_RemoveFillet24263856(Instance, Fillet.Instance));
				}
			public TopoDSEdge AddChamfer(TopoDSEdge E1,TopoDSEdge E2,double D1,double D2)
				{
					return new TopoDSEdge(BRepFilletAPI_MakeFillet2d_AddChamferFF157EBA(Instance, E1.Instance, E2.Instance, D1, D2));
				}
			public TopoDSEdge AddChamfer(TopoDSEdge E,TopoDSVertex V,double D,double Ang)
				{
					return new TopoDSEdge(BRepFilletAPI_MakeFillet2d_AddChamfer619A10E2(Instance, E.Instance, V.Instance, D, Ang));
				}
			public TopoDSEdge ModifyChamfer(TopoDSEdge Chamfer,TopoDSEdge E1,TopoDSEdge E2,double D1,double D2)
				{
					return new TopoDSEdge(BRepFilletAPI_MakeFillet2d_ModifyChamfer9D62DE59(Instance, Chamfer.Instance, E1.Instance, E2.Instance, D1, D2));
				}
			public TopoDSEdge ModifyChamfer(TopoDSEdge Chamfer,TopoDSEdge E,double D,double Ang)
				{
					return new TopoDSEdge(BRepFilletAPI_MakeFillet2d_ModifyChamferFF157EBA(Instance, Chamfer.Instance, E.Instance, D, Ang));
				}
			public TopoDSVertex RemoveChamfer(TopoDSEdge Chamfer)
				{
					return new TopoDSVertex(BRepFilletAPI_MakeFillet2d_RemoveChamfer24263856(Instance, Chamfer.Instance));
				}
			public bool IsModified(TopoDSEdge E)
				{
					return BRepFilletAPI_MakeFillet2d_IsModified24263856(Instance, E.Instance);
				}
			public bool HasDescendant(TopoDSEdge E)
				{
					return BRepFilletAPI_MakeFillet2d_HasDescendant24263856(Instance, E.Instance);
				}
			public TopoDSEdge DescendantEdge(TopoDSEdge E)
				{
					return new TopoDSEdge(BRepFilletAPI_MakeFillet2d_DescendantEdge24263856(Instance, E.Instance));
				}
			public TopoDSEdge BasisEdge(TopoDSEdge E)
				{
					return new TopoDSEdge(BRepFilletAPI_MakeFillet2d_BasisEdge24263856(Instance, E.Instance));
				}
			public void Build()
				{
					BRepFilletAPI_MakeFillet2d_Build(Instance);
				}
		public int NbFillet{
			get {
				return BRepFilletAPI_MakeFillet2d_NbFillet(Instance);
			}
		}
		public int NbChamfer{
			get {
				return BRepFilletAPI_MakeFillet2d_NbChamfer(Instance);
			}
		}
		public int NbCurves{
			get {
				return BRepFilletAPI_MakeFillet2d_NbCurves(Instance);
			}
		}
		public ChFi2dConstructionError Status{
			get {
				return (ChFi2dConstructionError)BRepFilletAPI_MakeFillet2d_Status(Instance);
			}
		}
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr BRepFilletAPI_MakeFillet2d_Ctor();
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr BRepFilletAPI_MakeFillet2d_CtorAEC70AC1(IntPtr F);
		[DllImport("NaroOccCore.dll")]
		private static extern void BRepFilletAPI_MakeFillet2d_InitAEC70AC1(IntPtr instance, IntPtr F);
		[DllImport("NaroOccCore.dll")]
		private static extern void BRepFilletAPI_MakeFillet2d_Init9D93DFBA(IntPtr instance, IntPtr RefFace,IntPtr ModFace);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr BRepFilletAPI_MakeFillet2d_AddFillet729B627B(IntPtr instance, IntPtr V,double Radius);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr BRepFilletAPI_MakeFillet2d_ModifyFillet809BA47B(IntPtr instance, IntPtr Fillet,double Radius);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr BRepFilletAPI_MakeFillet2d_RemoveFillet24263856(IntPtr instance, IntPtr Fillet);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr BRepFilletAPI_MakeFillet2d_AddChamferFF157EBA(IntPtr instance, IntPtr E1,IntPtr E2,double D1,double D2);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr BRepFilletAPI_MakeFillet2d_AddChamfer619A10E2(IntPtr instance, IntPtr E,IntPtr V,double D,double Ang);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr BRepFilletAPI_MakeFillet2d_ModifyChamfer9D62DE59(IntPtr instance, IntPtr Chamfer,IntPtr E1,IntPtr E2,double D1,double D2);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr BRepFilletAPI_MakeFillet2d_ModifyChamferFF157EBA(IntPtr instance, IntPtr Chamfer,IntPtr E,double D,double Ang);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr BRepFilletAPI_MakeFillet2d_RemoveChamfer24263856(IntPtr instance, IntPtr Chamfer);
		[DllImport("NaroOccCore.dll")]
		private static extern bool BRepFilletAPI_MakeFillet2d_IsModified24263856(IntPtr instance, IntPtr E);
		[DllImport("NaroOccCore.dll")]
		private static extern bool BRepFilletAPI_MakeFillet2d_HasDescendant24263856(IntPtr instance, IntPtr E);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr BRepFilletAPI_MakeFillet2d_DescendantEdge24263856(IntPtr instance, IntPtr E);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr BRepFilletAPI_MakeFillet2d_BasisEdge24263856(IntPtr instance, IntPtr E);
		[DllImport("NaroOccCore.dll")]
		private static extern void BRepFilletAPI_MakeFillet2d_Build(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern int BRepFilletAPI_MakeFillet2d_NbFillet(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern int BRepFilletAPI_MakeFillet2d_NbChamfer(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern int BRepFilletAPI_MakeFillet2d_NbCurves(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern int BRepFilletAPI_MakeFillet2d_Status(IntPtr instance);

		#region NativeInstancePtr Convert constructor

		public BRepFilletAPIMakeFillet2d(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ BRepFilletAPIMakeFillet2d_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void BRepFilletAPIMakeFillet2d_Dtor(IntPtr instance);
	}
}
