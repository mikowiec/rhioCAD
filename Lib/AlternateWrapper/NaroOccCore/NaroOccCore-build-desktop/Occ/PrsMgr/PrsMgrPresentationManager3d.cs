#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;
using NaroCppCore.Occ.PrsMgr;
using NaroCppCore.Occ.Graphic3d;
using NaroCppCore.Occ.Quantity;
using NaroCppCore.Occ.Viewer;
using NaroCppCore.Occ.Geom;
using NaroCppCore.Occ.Prs3d;

#endregion

namespace NaroCppCore.Occ.PrsMgr
{
	public class PrsMgrPresentationManager3d : PrsMgrPresentationManager
	{
		public PrsMgrPresentationManager3d(Graphic3dStructureManager aStructureManager)
 :
			base(PrsMgr_PresentationManager3d_Ctor6B9CC1AA(aStructureManager.Instance) )
		{}
			public void Color(PrsMgrPresentableObject aPresentableObject,QuantityNameOfColor aColor,int aMode)
				{
					PrsMgr_PresentationManager3d_ColorB83441D9(Instance, aPresentableObject.Instance, (int)aColor, aMode);
				}
			public void BoundBox(PrsMgrPresentableObject aPresentableObject,int aMode)
				{
					PrsMgr_PresentationManager3d_BoundBox6305B33D(Instance, aPresentableObject.Instance, aMode);
				}
			public void BeginDraw()
				{
					PrsMgr_PresentationManager3d_BeginDraw(Instance);
				}
			public void EndDraw(ViewerView aView,bool DoubleBuffer)
				{
					PrsMgr_PresentationManager3d_EndDrawAD710B01(Instance, aView.Instance, DoubleBuffer);
				}
			public void Connect(PrsMgrPresentableObject aPresentableObject,PrsMgrPresentableObject anOtherObject,int aMode,int anOtherMode)
				{
					PrsMgr_PresentationManager3d_ConnectDA51193F(Instance, aPresentableObject.Instance, anOtherObject.Instance, aMode, anOtherMode);
				}
			public void Transform(PrsMgrPresentableObject aPresentableObject,GeomTransformation aTransformation,int aMode)
				{
					PrsMgr_PresentationManager3d_Transform17D81909(Instance, aPresentableObject.Instance, aTransformation.Instance, aMode);
				}
			public void Place(PrsMgrPresentableObject aPresentableObject,double X,double Y,double Z,int aMode)
				{
					PrsMgr_PresentationManager3d_PlaceDCA8B26(Instance, aPresentableObject.Instance, X, Y, Z, aMode);
				}
			public void Multiply(PrsMgrPresentableObject aPresentableObject,GeomTransformation aTransformation,int aMode)
				{
					PrsMgr_PresentationManager3d_Multiply17D81909(Instance, aPresentableObject.Instance, aTransformation.Instance, aMode);
				}
			public void Move(PrsMgrPresentableObject aPresentableObject,double X,double Y,double Z,int aMode)
				{
					PrsMgr_PresentationManager3d_MoveDCA8B26(Instance, aPresentableObject.Instance, X, Y, Z, aMode);
				}
			public void SetShadingAspect(PrsMgrPresentableObject aPresentableObject,QuantityNameOfColor aColor,Graphic3dNameOfMaterial aMaterial,int aMode)
				{
					PrsMgr_PresentationManager3d_SetShadingAspect4A55E6F9(Instance, aPresentableObject.Instance, (int)aColor, (int)aMaterial, aMode);
				}
			public void SetShadingAspect(PrsMgrPresentableObject aPresentableObject,Prs3dShadingAspect aShadingAspect,int aMode)
				{
					PrsMgr_PresentationManager3d_SetShadingAspect2BCEAF8F(Instance, aPresentableObject.Instance, aShadingAspect.Instance, aMode);
				}
			public PrsMgrPresentation3d CastPresentation(PrsMgrPresentableObject aPresentableObject,int aMode)
				{
					return new PrsMgrPresentation3d(PrsMgr_PresentationManager3d_CastPresentation6305B33D(Instance, aPresentableObject.Instance, aMode));
				}
		public bool Is3D{
			get {
				return PrsMgr_PresentationManager3d_Is3D(Instance);
			}
		}
		public Graphic3dStructureManager StructureManager{
			get {
				return new Graphic3dStructureManager(PrsMgr_PresentationManager3d_StructureManager(Instance));
			}
		}
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr PrsMgr_PresentationManager3d_Ctor6B9CC1AA(IntPtr aStructureManager);
		[DllImport("NaroOccCore.dll")]
		private static extern void PrsMgr_PresentationManager3d_ColorB83441D9(IntPtr instance, IntPtr aPresentableObject,int aColor,int aMode);
		[DllImport("NaroOccCore.dll")]
		private static extern void PrsMgr_PresentationManager3d_BoundBox6305B33D(IntPtr instance, IntPtr aPresentableObject,int aMode);
		[DllImport("NaroOccCore.dll")]
		private static extern void PrsMgr_PresentationManager3d_BeginDraw(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void PrsMgr_PresentationManager3d_EndDrawAD710B01(IntPtr instance, IntPtr aView,bool DoubleBuffer);
		[DllImport("NaroOccCore.dll")]
		private static extern void PrsMgr_PresentationManager3d_ConnectDA51193F(IntPtr instance, IntPtr aPresentableObject,IntPtr anOtherObject,int aMode,int anOtherMode);
		[DllImport("NaroOccCore.dll")]
		private static extern void PrsMgr_PresentationManager3d_Transform17D81909(IntPtr instance, IntPtr aPresentableObject,IntPtr aTransformation,int aMode);
		[DllImport("NaroOccCore.dll")]
		private static extern void PrsMgr_PresentationManager3d_PlaceDCA8B26(IntPtr instance, IntPtr aPresentableObject,double X,double Y,double Z,int aMode);
		[DllImport("NaroOccCore.dll")]
		private static extern void PrsMgr_PresentationManager3d_Multiply17D81909(IntPtr instance, IntPtr aPresentableObject,IntPtr aTransformation,int aMode);
		[DllImport("NaroOccCore.dll")]
		private static extern void PrsMgr_PresentationManager3d_MoveDCA8B26(IntPtr instance, IntPtr aPresentableObject,double X,double Y,double Z,int aMode);
		[DllImport("NaroOccCore.dll")]
		private static extern void PrsMgr_PresentationManager3d_SetShadingAspect4A55E6F9(IntPtr instance, IntPtr aPresentableObject,int aColor,int aMaterial,int aMode);
		[DllImport("NaroOccCore.dll")]
		private static extern void PrsMgr_PresentationManager3d_SetShadingAspect2BCEAF8F(IntPtr instance, IntPtr aPresentableObject,IntPtr aShadingAspect,int aMode);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr PrsMgr_PresentationManager3d_CastPresentation6305B33D(IntPtr instance, IntPtr aPresentableObject,int aMode);
		[DllImport("NaroOccCore.dll")]
		private static extern bool PrsMgr_PresentationManager3d_Is3D(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr PrsMgr_PresentationManager3d_StructureManager(IntPtr instance);

		#region NativeInstancePtr Convert constructor

		public PrsMgrPresentationManager3d() { } 

		public PrsMgrPresentationManager3d(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ PrsMgrPresentationManager3d_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void PrsMgrPresentationManager3d_Dtor(IntPtr instance);
	}
}
