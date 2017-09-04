#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;
using NaroCppCore.Occ.MMgt;
using NaroCppCore.Occ.Aspect;
using NaroCppCore.Occ.Quantity;

#endregion

namespace NaroCppCore.Occ.Aspect
{
	public class AspectGrid : MMgtTShared
	{
			public void Rotate(double anAngle)
				{
					Aspect_Grid_RotateD82819F3(Instance, anAngle);
				}
			public void Translate(double aDx,double aDy)
				{
					Aspect_Grid_Translate9F0E714F(Instance, aDx, aDy);
				}
			public void SetColors(QuantityColor aColor,QuantityColor aTenthColor)
				{
					Aspect_Grid_SetColorsCF0F9433(Instance, aColor.Instance, aTenthColor.Instance);
				}
			public void Hit(double X,double Y,ref double gridX,ref double gridY)
				{
					Aspect_Grid_HitC2777E0C(Instance, X, Y, ref gridX, ref gridY);
				}
			public void Activate()
				{
					Aspect_Grid_Activate(Instance);
				}
			public void Deactivate()
				{
					Aspect_Grid_Deactivate(Instance);
				}
			public void Colors(QuantityColor aColor,QuantityColor aTenthColor)
				{
					Aspect_Grid_ColorsCF0F9433(Instance, aColor.Instance, aTenthColor.Instance);
				}
			public void Display()
				{
					Aspect_Grid_Display(Instance);
				}
			public void Erase()
				{
					Aspect_Grid_Erase(Instance);
				}
		public double XOrigin{
			set { 
				Aspect_Grid_SetXOrigin(Instance, value);
			}
			get {
				return Aspect_Grid_XOrigin(Instance);
			}
		}
		public double YOrigin{
			set { 
				Aspect_Grid_SetYOrigin(Instance, value);
			}
			get {
				return Aspect_Grid_YOrigin(Instance);
			}
		}
		public double RotationAngle{
			set { 
				Aspect_Grid_SetRotationAngle(Instance, value);
			}
			get {
				return Aspect_Grid_RotationAngle(Instance);
			}
		}
		public bool IsActive{
			get {
				return Aspect_Grid_IsActive(Instance);
			}
		}
		public AspectGridDrawMode DrawMode{
			set { 
				Aspect_Grid_SetDrawMode(Instance, (int)value);
			}
			get {
				return (AspectGridDrawMode)Aspect_Grid_DrawMode(Instance);
			}
		}
		public bool IsDisplayed{
			get {
				return Aspect_Grid_IsDisplayed(Instance);
			}
		}
		[DllImport("NaroOccCore.dll")]
		private static extern void Aspect_Grid_RotateD82819F3(IntPtr instance, double anAngle);
		[DllImport("NaroOccCore.dll")]
		private static extern void Aspect_Grid_Translate9F0E714F(IntPtr instance, double aDx,double aDy);
		[DllImport("NaroOccCore.dll")]
		private static extern void Aspect_Grid_SetColorsCF0F9433(IntPtr instance, IntPtr aColor,IntPtr aTenthColor);
		[DllImport("NaroOccCore.dll")]
		private static extern void Aspect_Grid_HitC2777E0C(IntPtr instance, double X,double Y,ref double gridX,ref double gridY);
		[DllImport("NaroOccCore.dll")]
		private static extern void Aspect_Grid_Activate(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void Aspect_Grid_Deactivate(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void Aspect_Grid_ColorsCF0F9433(IntPtr instance, IntPtr aColor,IntPtr aTenthColor);
		[DllImport("NaroOccCore.dll")]
		private static extern void Aspect_Grid_Display(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void Aspect_Grid_Erase(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void Aspect_Grid_SetXOrigin(IntPtr instance, double value);
		[DllImport("NaroOccCore.dll")]
		private static extern double Aspect_Grid_XOrigin(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void Aspect_Grid_SetYOrigin(IntPtr instance, double value);
		[DllImport("NaroOccCore.dll")]
		private static extern double Aspect_Grid_YOrigin(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void Aspect_Grid_SetRotationAngle(IntPtr instance, double value);
		[DllImport("NaroOccCore.dll")]
		private static extern double Aspect_Grid_RotationAngle(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool Aspect_Grid_IsActive(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void Aspect_Grid_SetDrawMode(IntPtr instance, int value);
		[DllImport("NaroOccCore.dll")]
		private static extern int Aspect_Grid_DrawMode(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool Aspect_Grid_IsDisplayed(IntPtr instance);

		#region NativeInstancePtr Convert constructor

		public AspectGrid() { } 

		public AspectGrid(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ AspectGrid_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void AspectGrid_Dtor(IntPtr instance);
	}
}
