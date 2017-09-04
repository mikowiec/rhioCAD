#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;
using NaroCppCore.Occ.Prs3d;
using NaroCppCore.Occ.Quantity;
using NaroCppCore.Occ.Aspect;

#endregion

namespace NaroCppCore.Occ.Prs3d
{
	public class Prs3dIsoAspect : Prs3dLineAspect
	{
		public Prs3dIsoAspect(QuantityNameOfColor aColor,AspectTypeOfLine aType,double aWidth,int aNumber)
 :
			base(Prs3d_IsoAspect_CtorC2594F57((int)aColor, (int)aType, aWidth, aNumber) )
		{}
		public Prs3dIsoAspect(QuantityColor aColor,AspectTypeOfLine aType,double aWidth,int aNumber)
 :
			base(Prs3d_IsoAspect_CtorE8121D05(aColor.Instance, (int)aType, aWidth, aNumber) )
		{}
		public int Number{
			set { 
				Prs3d_IsoAspect_SetNumber(Instance, value);
			}
			get {
				return Prs3d_IsoAspect_Number(Instance);
			}
		}
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Prs3d_IsoAspect_CtorC2594F57(int aColor,int aType,double aWidth,int aNumber);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Prs3d_IsoAspect_CtorE8121D05(IntPtr aColor,int aType,double aWidth,int aNumber);
		[DllImport("NaroOccCore.dll")]
		private static extern void Prs3d_IsoAspect_SetNumber(IntPtr instance, int value);
		[DllImport("NaroOccCore.dll")]
		private static extern int Prs3d_IsoAspect_Number(IntPtr instance);

		#region NativeInstancePtr Convert constructor

		public Prs3dIsoAspect() { } 

		public Prs3dIsoAspect(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ Prs3dIsoAspect_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void Prs3dIsoAspect_Dtor(IntPtr instance);
	}
}
