#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;
using NaroCppCore.Occ.Prs3d;
using NaroCppCore.Occ.Graphic3d;
using NaroCppCore.Occ.Quantity;
using NaroCppCore.Occ.Aspect;

#endregion

namespace NaroCppCore.Occ.Prs3d
{
	public class Prs3dShadingAspect : Prs3dBasicAspect
	{
		public Prs3dShadingAspect()
 :
			base(Prs3d_ShadingAspect_Ctor() )
		{}
			public void SetColor(QuantityColor aColor,AspectTypeOfFacingModel aModel)
				{
					Prs3d_ShadingAspect_SetColor91B95C7E(Instance, aColor.Instance, (int)aModel);
				}
			public void SetColor(QuantityNameOfColor aColor,AspectTypeOfFacingModel aModel)
				{
					Prs3d_ShadingAspect_SetColor6AB9C7E3(Instance, (int)aColor, (int)aModel);
				}
			public void SetMaterial(Graphic3dMaterialAspect aMaterial,AspectTypeOfFacingModel aModel)
				{
					Prs3d_ShadingAspect_SetMaterial4216C4F1(Instance, aMaterial.Instance, (int)aModel);
				}
			public void SetMaterial(Graphic3dNameOfMaterial aMaterial,AspectTypeOfFacingModel aModel)
				{
					Prs3d_ShadingAspect_SetMaterialC75397AB(Instance, (int)aMaterial, (int)aModel);
				}
			public void SetTransparency(double aValue,AspectTypeOfFacingModel aModel)
				{
					Prs3d_ShadingAspect_SetTransparencyEE7B4701(Instance, aValue, (int)aModel);
				}
			public QuantityColor Color(AspectTypeOfFacingModel aModel)
				{
					return new QuantityColor(Prs3d_ShadingAspect_ColorAE582B9F(Instance, (int)aModel));
				}
			public Graphic3dMaterialAspect Material(AspectTypeOfFacingModel aModel)
				{
					return new Graphic3dMaterialAspect(Prs3d_ShadingAspect_MaterialAE582B9F(Instance, (int)aModel));
				}
			public double Transparency(AspectTypeOfFacingModel aModel)
				{
					return Prs3d_ShadingAspect_TransparencyAE582B9F(Instance, (int)aModel);
				}
		public Graphic3dAspectFillArea3d Aspect{
			set { 
				Prs3d_ShadingAspect_SetAspect(Instance, value.Instance);
			}
			get {
				return new Graphic3dAspectFillArea3d(Prs3d_ShadingAspect_Aspect(Instance));
			}
		}
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Prs3d_ShadingAspect_Ctor();
		[DllImport("NaroOccCore.dll")]
		private static extern void Prs3d_ShadingAspect_SetColor91B95C7E(IntPtr instance, IntPtr aColor,int aModel);
		[DllImport("NaroOccCore.dll")]
		private static extern void Prs3d_ShadingAspect_SetColor6AB9C7E3(IntPtr instance, int aColor,int aModel);
		[DllImport("NaroOccCore.dll")]
		private static extern void Prs3d_ShadingAspect_SetMaterial4216C4F1(IntPtr instance, IntPtr aMaterial,int aModel);
		[DllImport("NaroOccCore.dll")]
		private static extern void Prs3d_ShadingAspect_SetMaterialC75397AB(IntPtr instance, int aMaterial,int aModel);
		[DllImport("NaroOccCore.dll")]
		private static extern void Prs3d_ShadingAspect_SetTransparencyEE7B4701(IntPtr instance, double aValue,int aModel);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Prs3d_ShadingAspect_ColorAE582B9F(IntPtr instance, int aModel);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Prs3d_ShadingAspect_MaterialAE582B9F(IntPtr instance, int aModel);
		[DllImport("NaroOccCore.dll")]
		private static extern double Prs3d_ShadingAspect_TransparencyAE582B9F(IntPtr instance, int aModel);
		[DllImport("NaroOccCore.dll")]
		private static extern void Prs3d_ShadingAspect_SetAspect(IntPtr instance, IntPtr value);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Prs3d_ShadingAspect_Aspect(IntPtr instance);

		#region NativeInstancePtr Convert constructor

		public Prs3dShadingAspect(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ Prs3dShadingAspect_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void Prs3dShadingAspect_Dtor(IntPtr instance);
	}
}
