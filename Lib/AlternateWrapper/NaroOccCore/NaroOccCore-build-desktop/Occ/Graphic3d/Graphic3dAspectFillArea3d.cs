#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;
using NaroCppCore.Occ.Aspect;
using NaroCppCore.Occ.Graphic3d;
using NaroCppCore.Occ.Quantity;

#endregion

namespace NaroCppCore.Occ.Graphic3d
{
	public class Graphic3dAspectFillArea3d : AspectAspectFillArea
	{
		public Graphic3dAspectFillArea3d()
 :
			base(Graphic3d_AspectFillArea3d_Ctor() )
		{}
		public Graphic3dAspectFillArea3d(AspectInteriorStyle Interior,QuantityColor InteriorColor,QuantityColor EdgeColor,AspectTypeOfLine EdgeLineType,double EdgeWidth,Graphic3dMaterialAspect FrontMaterial,Graphic3dMaterialAspect BackMaterial)
 :
			base(Graphic3d_AspectFillArea3d_Ctor173C01E9((int)Interior, InteriorColor.Instance, EdgeColor.Instance, (int)EdgeLineType, EdgeWidth, FrontMaterial.Instance, BackMaterial.Instance) )
		{}
			public void AllowBackFace()
				{
					Graphic3d_AspectFillArea3d_AllowBackFace(Instance);
				}
			public void SetDistinguishOn()
				{
					Graphic3d_AspectFillArea3d_SetDistinguishOn(Instance);
				}
			public void SetDistinguishOff()
				{
					Graphic3d_AspectFillArea3d_SetDistinguishOff(Instance);
				}
			public void SetEdgeOn()
				{
					Graphic3d_AspectFillArea3d_SetEdgeOn(Instance);
				}
			public void SetEdgeOff()
				{
					Graphic3d_AspectFillArea3d_SetEdgeOff(Instance);
				}
			public void SuppressBackFace()
				{
					Graphic3d_AspectFillArea3d_SuppressBackFace(Instance);
				}
			public void SetTextureMapOn()
				{
					Graphic3d_AspectFillArea3d_SetTextureMapOn(Instance);
				}
			public void SetTextureMapOff()
				{
					Graphic3d_AspectFillArea3d_SetTextureMapOff(Instance);
				}
			public static void SetDefaultDegenerateModel(AspectTypeOfDegenerateModel aModel,double aRatio)
				{
					Graphic3d_AspectFillArea3d_SetDefaultDegenerateModelE6DFDFE0((int)aModel, aRatio);
				}
			public void SetDegenerateModel(AspectTypeOfDegenerateModel aModel,double aRatio)
				{
					Graphic3d_AspectFillArea3d_SetDegenerateModelE6DFDFE0(Instance, (int)aModel, aRatio);
				}
			public void SetPolygonOffsets(int aMode,double aFactor,double aUnits)
				{
					Graphic3d_AspectFillArea3d_SetPolygonOffsets306E0DFB(Instance, aMode, aFactor, aUnits);
				}
			public AspectTypeOfDegenerateModel DegenerateModel(ref double aRatio)
				{
					return (AspectTypeOfDegenerateModel)Graphic3d_AspectFillArea3d_DegenerateModelD82819F3(Instance, ref aRatio);
				}
			public static AspectTypeOfDegenerateModel DefaultDegenerateModel(ref double aRatio)
				{
					return (AspectTypeOfDegenerateModel)Graphic3d_AspectFillArea3d_DefaultDegenerateModelD82819F3(ref aRatio);
				}
            //public void PolygonOffsets(ref int aMode,ref double aFactor,ref double aUnits)
            //    {
            //        Graphic3d_AspectFillArea3d_PolygonOffsets306E0DFB(Instance, ref aMode, ref aFactor, ref aUnits);
            //    }
		public bool BackFace{
			get {
				return Graphic3d_AspectFillArea3d_BackFace(Instance);
			}
		}
		public bool Distinguish{
			get {
				return Graphic3d_AspectFillArea3d_Distinguish(Instance);
			}
		}
		public bool Edge{
			get {
				return Graphic3d_AspectFillArea3d_Edge(Instance);
			}
		}
		public Graphic3dMaterialAspect BackMaterial{
			set { 
				Graphic3d_AspectFillArea3d_SetBackMaterial(Instance, value.Instance);
			}
			get {
				return new Graphic3dMaterialAspect(Graphic3d_AspectFillArea3d_BackMaterial(Instance));
			}
		}
		public Graphic3dMaterialAspect FrontMaterial{
			set { 
				Graphic3d_AspectFillArea3d_SetFrontMaterial(Instance, value.Instance);
			}
			get {
				return new Graphic3dMaterialAspect(Graphic3d_AspectFillArea3d_FrontMaterial(Instance));
			}
		}
		public bool TextureMapState{
			get {
				return Graphic3d_AspectFillArea3d_TextureMapState(Instance);
			}
		}
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Graphic3d_AspectFillArea3d_Ctor();
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Graphic3d_AspectFillArea3d_Ctor173C01E9(int Interior,IntPtr InteriorColor,IntPtr EdgeColor,int EdgeLineType,double EdgeWidth,IntPtr FrontMaterial,IntPtr BackMaterial);
		[DllImport("NaroOccCore.dll")]
		private static extern void Graphic3d_AspectFillArea3d_AllowBackFace(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void Graphic3d_AspectFillArea3d_SetDistinguishOn(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void Graphic3d_AspectFillArea3d_SetDistinguishOff(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void Graphic3d_AspectFillArea3d_SetEdgeOn(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void Graphic3d_AspectFillArea3d_SetEdgeOff(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void Graphic3d_AspectFillArea3d_SuppressBackFace(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void Graphic3d_AspectFillArea3d_SetTextureMapOn(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void Graphic3d_AspectFillArea3d_SetTextureMapOff(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void Graphic3d_AspectFillArea3d_SetDefaultDegenerateModelE6DFDFE0(int aModel,double aRatio);
		[DllImport("NaroOccCore.dll")]
		private static extern void Graphic3d_AspectFillArea3d_SetDegenerateModelE6DFDFE0(IntPtr instance, int aModel,double aRatio);
		[DllImport("NaroOccCore.dll")]
		private static extern void Graphic3d_AspectFillArea3d_SetPolygonOffsets306E0DFB(IntPtr instance, int aMode,double aFactor,double aUnits);
		[DllImport("NaroOccCore.dll")]
		private static extern int Graphic3d_AspectFillArea3d_DegenerateModelD82819F3(IntPtr instance, ref double aRatio);
		[DllImport("NaroOccCore.dll")]
		private static extern int Graphic3d_AspectFillArea3d_DefaultDegenerateModelD82819F3(ref double aRatio);
        //[DllImport("NaroOccCore.dll")]
        //private static extern void Graphic3d_AspectFillArea3d_PolygonOffsets306E0DFB(IntPtr instance, ref int aMode,ref double aFactor,ref double aUnits);
		[DllImport("NaroOccCore.dll")]
		private static extern bool Graphic3d_AspectFillArea3d_BackFace(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool Graphic3d_AspectFillArea3d_Distinguish(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool Graphic3d_AspectFillArea3d_Edge(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void Graphic3d_AspectFillArea3d_SetBackMaterial(IntPtr instance, IntPtr value);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Graphic3d_AspectFillArea3d_BackMaterial(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void Graphic3d_AspectFillArea3d_SetFrontMaterial(IntPtr instance, IntPtr value);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Graphic3d_AspectFillArea3d_FrontMaterial(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool Graphic3d_AspectFillArea3d_TextureMapState(IntPtr instance);

		#region NativeInstancePtr Convert constructor

		public Graphic3dAspectFillArea3d(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ Graphic3dAspectFillArea3d_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void Graphic3dAspectFillArea3d_Dtor(IntPtr instance);
	}
}
