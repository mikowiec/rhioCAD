#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;
using NaroCppCore.Occ.Aspect;
using NaroCppCore.Occ.WNT;
using NaroCppCore.Occ.Quantity;

#endregion

namespace NaroCppCore.Occ.WNT
{
	public class WNTWindow : AspectWindow
	{
		public WNTWindow(WNTGraphicDevice aDevice,string aTitle,WNTWClass aClass,double aStyle,double Xc,double Yc,double aWidth,double aHeight,QuantityNameOfColor aBackColor,IntPtr aParent,IntPtr aMenu,IntPtr aClientStruct)
 :
			base(WNT_Window_CtorB0EE1CA(aDevice.Instance, aTitle, aClass.Instance, aStyle, Xc, Yc, aWidth, aHeight, (int)aBackColor, aParent, aMenu, aClientStruct) )
		{}
		public WNTWindow(WNTGraphicDevice theDevice,string theTitle,WNTWClass theClass,double theStyle,int thePxLeft,int thePxTop,int thePxWidth,int thePxHeight,QuantityNameOfColor theBackColor,IntPtr theParent,IntPtr theMenu,IntPtr theClientStruct)
 :
			base(WNT_Window_Ctor83D53D04(theDevice.Instance, theTitle, theClass.Instance, theStyle, thePxLeft, thePxTop, thePxWidth, thePxHeight, (int)theBackColor, theParent, theMenu, theClientStruct) )
		{}
		public WNTWindow(WNTGraphicDevice aDevice,IntPtr aHandle,QuantityNameOfColor aBackColor)
 :
			base(WNT_Window_Ctor9F345CFF(aDevice.Instance, aHandle, (int)aBackColor) )
		{}
		public WNTWindow(WNTGraphicDevice aDevice,int aPart1,int aPart2,QuantityNameOfColor aBackColor)
 :
			base(WNT_Window_CtorBCEC06DC(aDevice.Instance, aPart1, aPart2, (int)aBackColor) )
		{}
			public void SetBackground(AspectBackground Background)
				{
					WNT_Window_SetBackground60C2D936(Instance, Background.Instance);
				}
			public void SetBackground(QuantityNameOfColor BackColor)
				{
					WNT_Window_SetBackground48F4F471(Instance, (int)BackColor);
				}
			public void SetBackground(QuantityColor color)
				{
					WNT_Window_SetBackground8FD7F48(Instance, color.Instance);
				}
			public void SetBackground(IntPtr aBackPixmap)
				{
					WNT_Window_SetBackgroundF9F0DFF(Instance, aBackPixmap);
				}
			public bool SetBackground(string aName,AspectFillMethod aMethod)
				{
					return WNT_Window_SetBackground7B49F0A3(Instance, aName, (int)aMethod);
				}
			public void SetBackground(QuantityColor aCol1,QuantityColor aCol2,AspectGradientFillMethod aMethod)
				{
					WNT_Window_SetBackgroundEE919A89(Instance, aCol1.Instance, aCol2.Instance, (int)aMethod);
				}
			public void SetIcon(IntPtr anIcon,string aName)
				{
					WNT_Window_SetIconB5B2B94C(Instance, anIcon, aName);
				}
			public void Flush()
				{
					WNT_Window_Flush(Instance);
				}
			public void Map()
				{
					WNT_Window_Map(Instance);
				}
			public void Map(int aMapMode)
				{
					WNT_Window_MapE8219145(Instance, aMapMode);
				}
			public void Unmap()
				{
					WNT_Window_Unmap(Instance);
				}
			public void Clear()
				{
					WNT_Window_Clear(Instance);
				}
			public void ClearArea(int Xc,int Yc,int Width,int Height)
				{
					WNT_Window_ClearArea8C6D7843(Instance, Xc, Yc, Width, Height);
				}
			public void Restore()
				{
					WNT_Window_Restore(Instance);
				}
			public void RestoreArea(int Xc,int Yc,int Width,int Height)
				{
					WNT_Window_RestoreArea8C6D7843(Instance, Xc, Yc, Width, Height);
				}
			public bool Dump(string aFilename,double aGammaValue)
				{
					return WNT_Window_Dump28A665C3(Instance, aFilename, aGammaValue);
				}
			public bool DumpArea(string aFilename,int Xc,int Yc,int Width,int Height,double aGammaValue)
				{
					return WNT_Window_DumpArea5B56276E(Instance, aFilename, Xc, Yc, Width, Height, aGammaValue);
				}
			public bool Load(string aFilename)
				{
					return WNT_Window_Load9381D4D(Instance, aFilename);
				}
			public bool LoadArea(string aFilename,int Xc,int Yc,int Width,int Height)
				{
					return WNT_Window_LoadAreaE8738FE0(Instance, aFilename, Xc, Yc, Width, Height);
				}
			public void SetPos(int X,int Y,int X1,int Y1)
				{
					WNT_Window_SetPos8C6D7843(Instance, X, Y, X1, Y1);
				}
			public void ResetFlags(int aFlags)
				{
					WNT_Window_ResetFlagsE8219145(Instance, aFlags);
				}
			public void Position(ref double X1,ref double Y1,ref double X2,ref double Y2)
				{
					WNT_Window_PositionC2777E0C(Instance, ref X1, ref Y1, ref X2, ref Y2);
				}
			public void Position(ref int X1,ref int Y1,ref int X2,ref int Y2)
				{
					WNT_Window_Position8C6D7843(Instance, ref X1, ref Y1, ref X2, ref Y2);
				}
			public void Size(ref double Width,ref double Height)
				{
					WNT_Window_Size9F0E714F(Instance, ref Width, ref Height);
				}
			public void Size(ref int Width,ref int Height)
				{
					WNT_Window_Size5107F6FE(Instance, ref Width, ref Height);
				}
			public void MMSize(ref double Width,ref double Height)
				{
					WNT_Window_MMSize9F0E714F(Instance, ref Width, ref Height);
				}
			public double Convert(int PV)
				{
					return WNT_Window_ConvertE8219145(Instance, PV);
				}
			public int Convert(double DV)
				{
					return WNT_Window_ConvertD82819F3(Instance, DV);
				}
			public void Convert(int PX,int PY,ref double DX,ref double DY)
				{
					WNT_Window_ConvertB83D31A8(Instance, PX, PY, ref DX, ref DY);
				}
			public void Convert(double DX,double DY,ref int PX,ref int PY)
				{
					WNT_Window_Convert852507E(Instance, DX, DY, ref PX, ref PY);
				}
		public IntPtr Cursor{
			set { 
				WNT_Window_SetCursor(Instance, value);
			}
		}
		public string IconName{
			set { 
				WNT_Window_SetIconName(Instance, value);
			}
		}
		public AspectTypeOfResize DoResize{
			get {
				return (AspectTypeOfResize)WNT_Window_DoResize(Instance);
			}
		}
		public bool DoMapping{
			get {
				return WNT_Window_DoMapping(Instance);
			}
		}
		public WNTTypeOfImage OutputFormat{
			set { 
				WNT_Window_SetOutputFormat(Instance, (int)value);
			}
		}
		public int Flags{
			set { 
				WNT_Window_SetFlags(Instance, value);
			}
		}
		public bool BackingStore{
			get {
				return WNT_Window_BackingStore(Instance);
			}
		}
		public bool DoubleBuffer{
			set { 
				WNT_Window_SetDoubleBuffer(Instance, value);
			}
			get {
				return WNT_Window_DoubleBuffer(Instance);
			}
		}
		public bool IsMapped{
			get {
				return WNT_Window_IsMapped(Instance);
			}
		}
		public double Ratio{
			get {
				return WNT_Window_Ratio(Instance);
			}
		}
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr WNT_Window_CtorB0EE1CA(IntPtr aDevice,string aTitle,IntPtr aClass,double aStyle,double Xc,double Yc,double aWidth,double aHeight,int aBackColor,IntPtr aParent,IntPtr aMenu,IntPtr aClientStruct);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr WNT_Window_Ctor83D53D04(IntPtr theDevice,string theTitle,IntPtr theClass,double theStyle,int thePxLeft,int thePxTop,int thePxWidth,int thePxHeight,int theBackColor,IntPtr theParent,IntPtr theMenu,IntPtr theClientStruct);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr WNT_Window_Ctor9F345CFF(IntPtr aDevice,IntPtr aHandle,int aBackColor);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr WNT_Window_CtorBCEC06DC(IntPtr aDevice,int aPart1,int aPart2,int aBackColor);
		[DllImport("NaroOccCore.dll")]
		private static extern void WNT_Window_SetBackground60C2D936(IntPtr instance, IntPtr Background);
		[DllImport("NaroOccCore.dll")]
		private static extern void WNT_Window_SetBackground48F4F471(IntPtr instance, int BackColor);
		[DllImport("NaroOccCore.dll")]
		private static extern void WNT_Window_SetBackground8FD7F48(IntPtr instance, IntPtr color);
		[DllImport("NaroOccCore.dll")]
		private static extern void WNT_Window_SetBackgroundF9F0DFF(IntPtr instance, IntPtr aBackPixmap);
		[DllImport("NaroOccCore.dll")]
		private static extern bool WNT_Window_SetBackground7B49F0A3(IntPtr instance, string aName,int aMethod);
		[DllImport("NaroOccCore.dll")]
		private static extern void WNT_Window_SetBackgroundEE919A89(IntPtr instance, IntPtr aCol1,IntPtr aCol2,int aMethod);
		[DllImport("NaroOccCore.dll")]
		private static extern void WNT_Window_SetIconB5B2B94C(IntPtr instance, IntPtr anIcon,string aName);
		[DllImport("NaroOccCore.dll")]
		private static extern void WNT_Window_Flush(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void WNT_Window_Map(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void WNT_Window_MapE8219145(IntPtr instance, int aMapMode);
		[DllImport("NaroOccCore.dll")]
		private static extern void WNT_Window_Unmap(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void WNT_Window_Clear(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void WNT_Window_ClearArea8C6D7843(IntPtr instance, int Xc,int Yc,int Width,int Height);
		[DllImport("NaroOccCore.dll")]
		private static extern void WNT_Window_Restore(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void WNT_Window_RestoreArea8C6D7843(IntPtr instance, int Xc,int Yc,int Width,int Height);
		[DllImport("NaroOccCore.dll")]
		private static extern bool WNT_Window_Dump28A665C3(IntPtr instance, string aFilename,double aGammaValue);
		[DllImport("NaroOccCore.dll")]
		private static extern bool WNT_Window_DumpArea5B56276E(IntPtr instance, string aFilename,int Xc,int Yc,int Width,int Height,double aGammaValue);
		[DllImport("NaroOccCore.dll")]
		private static extern bool WNT_Window_Load9381D4D(IntPtr instance, string aFilename);
		[DllImport("NaroOccCore.dll")]
		private static extern bool WNT_Window_LoadAreaE8738FE0(IntPtr instance, string aFilename,int Xc,int Yc,int Width,int Height);
		[DllImport("NaroOccCore.dll")]
		private static extern void WNT_Window_SetPos8C6D7843(IntPtr instance, int X,int Y,int X1,int Y1);
		[DllImport("NaroOccCore.dll")]
		private static extern void WNT_Window_ResetFlagsE8219145(IntPtr instance, int aFlags);
		[DllImport("NaroOccCore.dll")]
		private static extern void WNT_Window_PositionC2777E0C(IntPtr instance, ref double X1,ref double Y1,ref double X2,ref double Y2);
		[DllImport("NaroOccCore.dll")]
		private static extern void WNT_Window_Position8C6D7843(IntPtr instance, ref int X1,ref int Y1,ref int X2,ref int Y2);
		[DllImport("NaroOccCore.dll")]
		private static extern void WNT_Window_Size9F0E714F(IntPtr instance, ref double Width,ref double Height);
		[DllImport("NaroOccCore.dll")]
		private static extern void WNT_Window_Size5107F6FE(IntPtr instance, ref int Width,ref int Height);
		[DllImport("NaroOccCore.dll")]
		private static extern void WNT_Window_MMSize9F0E714F(IntPtr instance, ref double Width,ref double Height);
		[DllImport("NaroOccCore.dll")]
		private static extern double WNT_Window_ConvertE8219145(IntPtr instance, int PV);
		[DllImport("NaroOccCore.dll")]
		private static extern int WNT_Window_ConvertD82819F3(IntPtr instance, double DV);
		[DllImport("NaroOccCore.dll")]
		private static extern void WNT_Window_ConvertB83D31A8(IntPtr instance, int PX,int PY,ref double DX,ref double DY);
		[DllImport("NaroOccCore.dll")]
		private static extern void WNT_Window_Convert852507E(IntPtr instance, double DX,double DY,ref int PX,ref int PY);
		[DllImport("NaroOccCore.dll")]
		private static extern void WNT_Window_SetCursor(IntPtr instance, IntPtr value);
		[DllImport("NaroOccCore.dll")]
		private static extern void WNT_Window_SetIconName(IntPtr instance, string value);
		[DllImport("NaroOccCore.dll")]
		private static extern int WNT_Window_DoResize(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool WNT_Window_DoMapping(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void WNT_Window_SetOutputFormat(IntPtr instance, int value);
		[DllImport("NaroOccCore.dll")]
		private static extern void WNT_Window_SetFlags(IntPtr instance, int value);
		[DllImport("NaroOccCore.dll")]
		private static extern bool WNT_Window_BackingStore(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void WNT_Window_SetDoubleBuffer(IntPtr instance, bool value);
		[DllImport("NaroOccCore.dll")]
		private static extern bool WNT_Window_DoubleBuffer(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool WNT_Window_IsMapped(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern double WNT_Window_Ratio(IntPtr instance);

		#region NativeInstancePtr Convert constructor

		public WNTWindow() { } 

		public WNTWindow(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ WNTWindow_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void WNTWindow_Dtor(IntPtr instance);
	}
}
