#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;
using NaroCppCore.Occ.MMgt;
using NaroCppCore.Occ.Quantity;
using NaroCppCore.Occ.Aspect;
using NaroCppCore.Occ.Font;

#endregion

namespace NaroCppCore.Occ.Graphic3d
{
	public class Graphic3dAspectText3d : MMgtTShared
	{
		public Graphic3dAspectText3d()
 :
			base(Graphic3d_AspectText3d_Ctor() )
		{}
		public Graphic3dAspectText3d(QuantityColor AColor,string AFont,double AExpansionFactor,double ASpace,AspectTypeOfStyleText AStyle,AspectTypeOfDisplayText ADisplayType)
 :
			base(Graphic3d_AspectText3d_Ctor61B9B574(AColor.Instance, AFont, AExpansionFactor, ASpace, (int)AStyle, (int)ADisplayType) )
		{}
		public QuantityColor Color{
			set { 
				Graphic3d_AspectText3d_SetColor(Instance, value.Instance);
			}
		}
		public double ExpansionFactor{
			set { 
				Graphic3d_AspectText3d_SetExpansionFactor(Instance, value);
			}
		}
		public string Font{
			set { 
				Graphic3d_AspectText3d_SetFont(Instance, value);
			}
		}
		public double Space{
			set { 
				Graphic3d_AspectText3d_SetSpace(Instance, value);
			}
		}
		public AspectTypeOfStyleText Style{
			set { 
				Graphic3d_AspectText3d_SetStyle(Instance, (int)value);
			}
		}
		public AspectTypeOfDisplayText DisplayType{
			set { 
				Graphic3d_AspectText3d_SetDisplayType(Instance, (int)value);
			}
		}
		public QuantityColor ColorSubTitle{
			set { 
				Graphic3d_AspectText3d_SetColorSubTitle(Instance, value.Instance);
			}
		}
		public bool TextZoomable{
			set { 
				Graphic3d_AspectText3d_SetTextZoomable(Instance, value);
			}
		}
		public bool GetTextZoomable{
			get {
				return Graphic3d_AspectText3d_GetTextZoomable(Instance);
			}
		}
		public double TextAngle{
			set { 
				Graphic3d_AspectText3d_SetTextAngle(Instance, value);
			}
		}
		public double GetTextAngle{
			get {
				return Graphic3d_AspectText3d_GetTextAngle(Instance);
			}
		}
		public FontFontAspect TextFontAspect{
			set { 
				Graphic3d_AspectText3d_SetTextFontAspect(Instance, (int)value);
			}
		}
		public FontFontAspect GetTextFontAspect{
			get {
				return (FontFontAspect)Graphic3d_AspectText3d_GetTextFontAspect(Instance);
			}
		}
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Graphic3d_AspectText3d_Ctor();
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Graphic3d_AspectText3d_Ctor61B9B574(IntPtr AColor,string AFont,double AExpansionFactor,double ASpace,int AStyle,int ADisplayType);
		[DllImport("NaroOccCore.dll")]
		private static extern void Graphic3d_AspectText3d_SetColor(IntPtr instance, IntPtr value);
		[DllImport("NaroOccCore.dll")]
		private static extern void Graphic3d_AspectText3d_SetExpansionFactor(IntPtr instance, double value);
		[DllImport("NaroOccCore.dll")]
		private static extern void Graphic3d_AspectText3d_SetFont(IntPtr instance, string value);
		[DllImport("NaroOccCore.dll")]
		private static extern void Graphic3d_AspectText3d_SetSpace(IntPtr instance, double value);
		[DllImport("NaroOccCore.dll")]
		private static extern void Graphic3d_AspectText3d_SetStyle(IntPtr instance, int value);
		[DllImport("NaroOccCore.dll")]
		private static extern void Graphic3d_AspectText3d_SetDisplayType(IntPtr instance, int value);
		[DllImport("NaroOccCore.dll")]
		private static extern void Graphic3d_AspectText3d_SetColorSubTitle(IntPtr instance, IntPtr value);
		[DllImport("NaroOccCore.dll")]
		private static extern void Graphic3d_AspectText3d_SetTextZoomable(IntPtr instance, bool value);
		[DllImport("NaroOccCore.dll")]
		private static extern bool Graphic3d_AspectText3d_GetTextZoomable(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void Graphic3d_AspectText3d_SetTextAngle(IntPtr instance, double value);
		[DllImport("NaroOccCore.dll")]
		private static extern double Graphic3d_AspectText3d_GetTextAngle(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void Graphic3d_AspectText3d_SetTextFontAspect(IntPtr instance, int value);
		[DllImport("NaroOccCore.dll")]
		private static extern int Graphic3d_AspectText3d_GetTextFontAspect(IntPtr instance);

		#region NativeInstancePtr Convert constructor

		public Graphic3dAspectText3d(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ Graphic3dAspectText3d_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void Graphic3dAspectText3d_Dtor(IntPtr instance);
	}
}
