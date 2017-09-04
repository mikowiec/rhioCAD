#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;
using NaroCppCore.Occ.Quantity;

#endregion

namespace NaroCppCore.Occ.Quantity
{
	public class QuantityColor : NativeInstancePtr
	{
		public QuantityColor()
 :
			base(Quantity_Color_Ctor() )
		{}
		public QuantityColor(QuantityNameOfColor AName)
 :
			base(Quantity_Color_Ctor48F4F471((int)AName) )
		{}
		public QuantityColor(double R1,double R2,double R3,QuantityTypeOfColor AType)
 :
			base(Quantity_Color_Ctor2BE4ECDC(R1, R2, R3, (int)AType) )
		{}
			public QuantityColor Assign(QuantityColor Other)
				{
					return new QuantityColor(Quantity_Color_Assign8FD7F48(Instance, Other.Instance));
				}
			public void ChangeContrast(double ADelta)
				{
					Quantity_Color_ChangeContrastD82819F3(Instance, ADelta);
				}
			public void ChangeIntensity(double ADelta)
				{
					Quantity_Color_ChangeIntensityD82819F3(Instance, ADelta);
				}
			public void SetValues(QuantityNameOfColor AName)
				{
					Quantity_Color_SetValues48F4F471(Instance, (int)AName);
				}
			public void SetValues(double R1,double R2,double R3,QuantityTypeOfColor AType)
				{
					Quantity_Color_SetValues2BE4ECDC(Instance, R1, R2, R3, (int)AType);
				}
			public void Delta(QuantityColor AColor,ref double DC,ref double DI)
				{
					Quantity_Color_DeltaA6E67349(Instance, AColor.Instance, ref DC, ref DI);
				}
			public double Distance(QuantityColor AColor)
				{
					return Quantity_Color_Distance8FD7F48(Instance, AColor.Instance);
				}
			public double SquareDistance(QuantityColor AColor)
				{
					return Quantity_Color_SquareDistance8FD7F48(Instance, AColor.Instance);
				}
			public bool IsDifferent(QuantityColor Other)
				{
					return Quantity_Color_IsDifferent8FD7F48(Instance, Other.Instance);
				}
			public bool IsEqual(QuantityColor Other)
				{
					return Quantity_Color_IsEqual8FD7F48(Instance, Other.Instance);
				}
			public QuantityNameOfColor Name()
				{
					return (QuantityNameOfColor)Quantity_Color_Name(Instance);
				}
			public void Values(ref double R1,ref double R2,ref double R3,QuantityTypeOfColor AType)
				{
					Quantity_Color_Values2BE4ECDC(Instance, ref R1, ref R2, ref R3, (int)AType);
				}
			public static QuantityNameOfColor Name(double R,double G,double B)
				{
					return (QuantityNameOfColor)Quantity_Color_Name9282A951(R, G, B);
				}
			public static string StringName(QuantityNameOfColor AColor)
				{
					return Quantity_Color_StringName48F4F471((int)AColor);
				}
			public static void HlsRgb(double H,double L,double S,ref double R,ref double G,ref double B)
				{
					Quantity_Color_HlsRgbBC7A5786(H, L, S, ref R, ref G, ref B);
				}
			public static void RgbHls(double R,double G,double B,ref double H,ref double L,ref double S)
				{
					Quantity_Color_RgbHlsBC7A5786(R, G, B, ref H, ref L, ref S);
				}
			public static void Color2argb(QuantityColor theColor,ref int theARGB)
				{
					Quantity_Color_Color2argbDE9AF5DE(theColor.Instance, ref theARGB);
				}
			public static void Argb2color(int theARGB,QuantityColor theColor)
				{
					Quantity_Color_Argb2color8575C8EE(theARGB, theColor.Instance);
				}
			public static void Test()
				{
					Quantity_Color_Test();
				}
		public double Blue{
			get {
				return Quantity_Color_Blue(Instance);
			}
		}
		public double Green{
			get {
				return Quantity_Color_Green(Instance);
			}
		}
		public double Hue{
			get {
				return Quantity_Color_Hue(Instance);
			}
		}
		public double Light{
			get {
				return Quantity_Color_Light(Instance);
			}
		}
		public double Red{
			get {
				return Quantity_Color_Red(Instance);
			}
		}
		public double Saturation{
			get {
				return Quantity_Color_Saturation(Instance);
			}
		}
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Quantity_Color_Ctor();
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Quantity_Color_Ctor48F4F471(int AName);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Quantity_Color_Ctor2BE4ECDC(double R1,double R2,double R3,int AType);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Quantity_Color_Assign8FD7F48(IntPtr instance, IntPtr Other);
		[DllImport("NaroOccCore.dll")]
		private static extern void Quantity_Color_ChangeContrastD82819F3(IntPtr instance, double ADelta);
		[DllImport("NaroOccCore.dll")]
		private static extern void Quantity_Color_ChangeIntensityD82819F3(IntPtr instance, double ADelta);
		[DllImport("NaroOccCore.dll")]
		private static extern void Quantity_Color_SetValues48F4F471(IntPtr instance, int AName);
		[DllImport("NaroOccCore.dll")]
		private static extern void Quantity_Color_SetValues2BE4ECDC(IntPtr instance, double R1,double R2,double R3,int AType);
		[DllImport("NaroOccCore.dll")]
		private static extern void Quantity_Color_DeltaA6E67349(IntPtr instance, IntPtr AColor,ref double DC,ref double DI);
		[DllImport("NaroOccCore.dll")]
		private static extern double Quantity_Color_Distance8FD7F48(IntPtr instance, IntPtr AColor);
		[DllImport("NaroOccCore.dll")]
		private static extern double Quantity_Color_SquareDistance8FD7F48(IntPtr instance, IntPtr AColor);
		[DllImport("NaroOccCore.dll")]
		private static extern bool Quantity_Color_IsDifferent8FD7F48(IntPtr instance, IntPtr Other);
		[DllImport("NaroOccCore.dll")]
		private static extern bool Quantity_Color_IsEqual8FD7F48(IntPtr instance, IntPtr Other);
		[DllImport("NaroOccCore.dll")]
		private static extern int Quantity_Color_Name(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void Quantity_Color_Values2BE4ECDC(IntPtr instance, ref double R1,ref double R2,ref double R3,int AType);
		[DllImport("NaroOccCore.dll")]
		private static extern int Quantity_Color_Name9282A951(double R,double G,double B);
		[DllImport("NaroOccCore.dll")]
		private static extern string Quantity_Color_StringName48F4F471(int AColor);
		[DllImport("NaroOccCore.dll")]
		private static extern void Quantity_Color_HlsRgbBC7A5786(double H,double L,double S,ref double R,ref double G,ref double B);
		[DllImport("NaroOccCore.dll")]
		private static extern void Quantity_Color_RgbHlsBC7A5786(double R,double G,double B,ref double H,ref double L,ref double S);
		[DllImport("NaroOccCore.dll")]
		private static extern void Quantity_Color_Color2argbDE9AF5DE(IntPtr theColor,ref int theARGB);
		[DllImport("NaroOccCore.dll")]
		private static extern void Quantity_Color_Argb2color8575C8EE(int theARGB,IntPtr theColor);
		[DllImport("NaroOccCore.dll")]
		private static extern void Quantity_Color_Test();
		[DllImport("NaroOccCore.dll")]
		private static extern double Quantity_Color_Blue(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern double Quantity_Color_Green(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern double Quantity_Color_Hue(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern double Quantity_Color_Light(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern double Quantity_Color_Red(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern double Quantity_Color_Saturation(IntPtr instance);

		#region NativeInstancePtr Convert constructor

		public QuantityColor(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ QuantityColor_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void QuantityColor_Dtor(IntPtr instance);
	}
}
