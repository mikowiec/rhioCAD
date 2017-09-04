#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;
using NaroCppCore.Occ.Prs3d;
using NaroCppCore.Occ.Graphic3d;
using NaroCppCore.Occ.Quantity;

#endregion

namespace NaroCppCore.Occ.Prs3d
{
	public class Prs3dTextAspect : Prs3dBasicAspect
	{
		public Prs3dTextAspect()
 :
			base(Prs3d_TextAspect_Ctor() )
		{}
			public void SetColor(QuantityColor aColor)
				{
					Prs3d_TextAspect_SetColor8FD7F48(Instance, aColor.Instance);
				}
			public void SetColor(QuantityNameOfColor aColor)
				{
					Prs3d_TextAspect_SetColor48F4F471(Instance, (int)aColor);
				}
		public string Font{
			set { 
				Prs3d_TextAspect_SetFont(Instance, value);
			}
		}
		public double HeightWidthRatio{
			set { 
				Prs3d_TextAspect_SetHeightWidthRatio(Instance, value);
			}
		}
		public double Space{
			set { 
				Prs3d_TextAspect_SetSpace(Instance, value);
			}
		}
		public double Height{
			set { 
				Prs3d_TextAspect_SetHeight(Instance, value);
			}
			get {
				return Prs3d_TextAspect_Height(Instance);
			}
		}
		public double Angle{
			set { 
				Prs3d_TextAspect_SetAngle(Instance, value);
			}
			get {
				return Prs3d_TextAspect_Angle(Instance);
			}
		}
		public Graphic3dHorizontalTextAlignment HorizontalJustification{
			set { 
				Prs3d_TextAspect_SetHorizontalJustification(Instance, (int)value);
			}
			get {
				return (Graphic3dHorizontalTextAlignment)Prs3d_TextAspect_HorizontalJustification(Instance);
			}
		}
		public Graphic3dVerticalTextAlignment VerticalJustification{
			set { 
				Prs3d_TextAspect_SetVerticalJustification(Instance, (int)value);
			}
			get {
				return (Graphic3dVerticalTextAlignment)Prs3d_TextAspect_VerticalJustification(Instance);
			}
		}
		public Graphic3dTextPath Orientation{
			set { 
				Prs3d_TextAspect_SetOrientation(Instance, (int)value);
			}
			get {
				return (Graphic3dTextPath)Prs3d_TextAspect_Orientation(Instance);
			}
		}
		public Graphic3dAspectText3d Aspect{
			get {
				return new Graphic3dAspectText3d(Prs3d_TextAspect_Aspect(Instance));
			}
		}
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Prs3d_TextAspect_Ctor();
		[DllImport("NaroOccCore.dll")]
		private static extern void Prs3d_TextAspect_SetColor8FD7F48(IntPtr instance, IntPtr aColor);
		[DllImport("NaroOccCore.dll")]
		private static extern void Prs3d_TextAspect_SetColor48F4F471(IntPtr instance, int aColor);
		[DllImport("NaroOccCore.dll")]
		private static extern void Prs3d_TextAspect_SetFont(IntPtr instance, string value);
		[DllImport("NaroOccCore.dll")]
		private static extern void Prs3d_TextAspect_SetHeightWidthRatio(IntPtr instance, double value);
		[DllImport("NaroOccCore.dll")]
		private static extern void Prs3d_TextAspect_SetSpace(IntPtr instance, double value);
		[DllImport("NaroOccCore.dll")]
		private static extern void Prs3d_TextAspect_SetHeight(IntPtr instance, double value);
		[DllImport("NaroOccCore.dll")]
		private static extern double Prs3d_TextAspect_Height(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void Prs3d_TextAspect_SetAngle(IntPtr instance, double value);
		[DllImport("NaroOccCore.dll")]
		private static extern double Prs3d_TextAspect_Angle(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void Prs3d_TextAspect_SetHorizontalJustification(IntPtr instance, int value);
		[DllImport("NaroOccCore.dll")]
		private static extern int Prs3d_TextAspect_HorizontalJustification(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void Prs3d_TextAspect_SetVerticalJustification(IntPtr instance, int value);
		[DllImport("NaroOccCore.dll")]
		private static extern int Prs3d_TextAspect_VerticalJustification(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void Prs3d_TextAspect_SetOrientation(IntPtr instance, int value);
		[DllImport("NaroOccCore.dll")]
		private static extern int Prs3d_TextAspect_Orientation(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Prs3d_TextAspect_Aspect(IntPtr instance);

		#region NativeInstancePtr Convert constructor

		public Prs3dTextAspect(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ Prs3dTextAspect_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void Prs3dTextAspect_Dtor(IntPtr instance);
	}
}
