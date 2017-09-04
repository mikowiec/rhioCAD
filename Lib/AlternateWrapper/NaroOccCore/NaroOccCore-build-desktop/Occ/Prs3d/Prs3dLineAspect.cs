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
	public class Prs3dLineAspect : Prs3dBasicAspect
	{
		public Prs3dLineAspect(QuantityNameOfColor aColor,AspectTypeOfLine aType,double aWidth)
 :
			base(Prs3d_LineAspect_Ctor1A9E9376((int)aColor, (int)aType, aWidth) )
		{}
		public Prs3dLineAspect(QuantityColor aColor,AspectTypeOfLine aType,double aWidth)
 :
			base(Prs3d_LineAspect_Ctor94ED4A31(aColor.Instance, (int)aType, aWidth) )
		{}
			public void SetColor(QuantityColor aColor)
				{
					Prs3d_LineAspect_SetColor8FD7F48(Instance, aColor.Instance);
				}
			public void SetColor(QuantityNameOfColor aColor)
				{
					Prs3d_LineAspect_SetColor48F4F471(Instance, (int)aColor);
				}
		public AspectTypeOfLine TypeOfLine{
			set { 
				Prs3d_LineAspect_SetTypeOfLine(Instance, (int)value);
			}
		}
		public double Width{
			set { 
				Prs3d_LineAspect_SetWidth(Instance, value);
			}
		}
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Prs3d_LineAspect_Ctor1A9E9376(int aColor,int aType,double aWidth);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Prs3d_LineAspect_Ctor94ED4A31(IntPtr aColor,int aType,double aWidth);
		[DllImport("NaroOccCore.dll")]
		private static extern void Prs3d_LineAspect_SetColor8FD7F48(IntPtr instance, IntPtr aColor);
		[DllImport("NaroOccCore.dll")]
		private static extern void Prs3d_LineAspect_SetColor48F4F471(IntPtr instance, int aColor);
		[DllImport("NaroOccCore.dll")]
		private static extern void Prs3d_LineAspect_SetTypeOfLine(IntPtr instance, int value);
		[DllImport("NaroOccCore.dll")]
		private static extern void Prs3d_LineAspect_SetWidth(IntPtr instance, double value);

		#region NativeInstancePtr Convert constructor

		public Prs3dLineAspect() { } 

		public Prs3dLineAspect(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ Prs3dLineAspect_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void Prs3dLineAspect_Dtor(IntPtr instance);
	}
}
