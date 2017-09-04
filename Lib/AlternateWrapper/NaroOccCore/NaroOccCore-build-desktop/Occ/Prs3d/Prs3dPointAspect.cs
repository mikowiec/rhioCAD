#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;
using NaroCppCore.Occ.Prs3d;
using NaroCppCore.Occ.Aspect;
using NaroCppCore.Occ.Quantity;

#endregion

namespace NaroCppCore.Occ.Prs3d
{
	public class Prs3dPointAspect : Prs3dBasicAspect
	{
		public Prs3dPointAspect(AspectTypeOfMarker aType,QuantityColor aColor,double aScale)
 :
			base(Prs3d_PointAspect_Ctor9BAF9396((int)aType, aColor.Instance, aScale) )
		{}
		public Prs3dPointAspect(AspectTypeOfMarker aType,QuantityNameOfColor aColor,double aScale)
 :
			base(Prs3d_PointAspect_CtorF00B8265((int)aType, (int)aColor, aScale) )
		{}
			public void SetColor(QuantityColor aColor)
				{
					Prs3d_PointAspect_SetColor8FD7F48(Instance, aColor.Instance);
				}
			public void SetColor(QuantityNameOfColor aColor)
				{
					Prs3d_PointAspect_SetColor48F4F471(Instance, (int)aColor);
				}
			public void GetTextureSize(ref int AWidth,ref int AHeight)
				{
					Prs3d_PointAspect_GetTextureSize5107F6FE(Instance, ref AWidth, ref AHeight);
				}
		public AspectTypeOfMarker TypeOfMarker{
			set { 
				Prs3d_PointAspect_SetTypeOfMarker(Instance, (int)value);
			}
		}
		public double Scale{
			set { 
				Prs3d_PointAspect_SetScale(Instance, value);
			}
		}
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Prs3d_PointAspect_Ctor9BAF9396(int aType,IntPtr aColor,double aScale);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Prs3d_PointAspect_CtorF00B8265(int aType,int aColor,double aScale);
		[DllImport("NaroOccCore.dll")]
		private static extern void Prs3d_PointAspect_SetColor8FD7F48(IntPtr instance, IntPtr aColor);
		[DllImport("NaroOccCore.dll")]
		private static extern void Prs3d_PointAspect_SetColor48F4F471(IntPtr instance, int aColor);
		[DllImport("NaroOccCore.dll")]
		private static extern void Prs3d_PointAspect_GetTextureSize5107F6FE(IntPtr instance, ref int AWidth,ref int AHeight);
		[DllImport("NaroOccCore.dll")]
		private static extern void Prs3d_PointAspect_SetTypeOfMarker(IntPtr instance, int value);
		[DllImport("NaroOccCore.dll")]
		private static extern void Prs3d_PointAspect_SetScale(IntPtr instance, double value);

		#region NativeInstancePtr Convert constructor

		public Prs3dPointAspect() { } 

		public Prs3dPointAspect(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ Prs3dPointAspect_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void Prs3dPointAspect_Dtor(IntPtr instance);
	}
}
