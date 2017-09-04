#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;
using NaroCppCore.Occ.Aspect;

#endregion

namespace NaroCppCore.Occ.Aspect
{
	public class AspectFontStyle : NativeInstancePtr
	{
		public AspectFontStyle()
 :
			base(Aspect_FontStyle_Ctor() )
		{}
		public AspectFontStyle(AspectTypeOfFont Type,double Size,double Slant,bool CapsHeight)
 :
			base(Aspect_FontStyle_Ctor625FF186((int)Type, Size, Slant, CapsHeight) )
		{}
		public AspectFontStyle(string Style,double Size,double Slant,bool CapsHeight)
 :
			base(Aspect_FontStyle_Ctor27C00EC7(Style, Size, Slant, CapsHeight) )
		{}
		public AspectFontStyle(string Style)
 :
			base(Aspect_FontStyle_Ctor9381D4D(Style) )
		{}
			public AspectFontStyle Assign(AspectFontStyle Other)
				{
					return new AspectFontStyle(Aspect_FontStyle_Assign8E648131(Instance, Other.Instance));
				}
			public void SetValues(AspectTypeOfFont Type,double Size,double Slant,bool CapsHeight)
				{
					Aspect_FontStyle_SetValues625FF186(Instance, (int)Type, Size, Slant, CapsHeight);
				}
			public void SetValues(string Style,double Size,double Slant,bool CapsHeight)
				{
					Aspect_FontStyle_SetValues27C00EC7(Instance, Style, Size, Slant, CapsHeight);
				}
			public void SetValues(string Style)
				{
					Aspect_FontStyle_SetValues9381D4D(Instance, Style);
				}
			public void Dump()
				{
					Aspect_FontStyle_Dump(Instance);
				}
			public bool IsEqual(AspectFontStyle Other)
				{
					return Aspect_FontStyle_IsEqual8E648131(Instance, Other.Instance);
				}
			public bool IsNotEqual(AspectFontStyle Other)
				{
					return Aspect_FontStyle_IsNotEqual8E648131(Instance, Other.Instance);
				}
		public AspectTypeOfFont Style{
			get {
				return (AspectTypeOfFont)Aspect_FontStyle_Style(Instance);
			}
		}
		public int Length{
			get {
				return Aspect_FontStyle_Length(Instance);
			}
		}
		public string Value{
			get {
				return Aspect_FontStyle_Value(Instance);
			}
		}
		public double Size{
			get {
				return Aspect_FontStyle_Size(Instance);
			}
		}
		public double Slant{
			get {
				return Aspect_FontStyle_Slant(Instance);
			}
		}
		public bool CapsHeight{
			get {
				return Aspect_FontStyle_CapsHeight(Instance);
			}
		}
		public string AliasName{
			get {
				return Aspect_FontStyle_AliasName(Instance);
			}
		}
		public string FullName{
			get {
				return Aspect_FontStyle_FullName(Instance);
			}
		}
		public string Foundry{
			get {
				return Aspect_FontStyle_Foundry(Instance);
			}
		}
		public string Family{
			set { 
				Aspect_FontStyle_SetFamily(Instance, value);
			}
			get {
				return Aspect_FontStyle_Family(Instance);
			}
		}
		public string Weight{
			set { 
				Aspect_FontStyle_SetWeight(Instance, value);
			}
			get {
				return Aspect_FontStyle_Weight(Instance);
			}
		}
		public string Registry{
			set { 
				Aspect_FontStyle_SetRegistry(Instance, value);
			}
			get {
				return Aspect_FontStyle_Registry(Instance);
			}
		}
		public string Encoding{
			set { 
				Aspect_FontStyle_SetEncoding(Instance, value);
			}
			get {
				return Aspect_FontStyle_Encoding(Instance);
			}
		}
		public string SSlant{
			get {
				return Aspect_FontStyle_SSlant(Instance);
			}
		}
		public string SWidth{
			get {
				return Aspect_FontStyle_SWidth(Instance);
			}
		}
		public string SStyle{
			get {
				return Aspect_FontStyle_SStyle(Instance);
			}
		}
		public string SPixelSize{
			get {
				return Aspect_FontStyle_SPixelSize(Instance);
			}
		}
		public string SPointSize{
			get {
				return Aspect_FontStyle_SPointSize(Instance);
			}
		}
		public string SResolutionX{
			get {
				return Aspect_FontStyle_SResolutionX(Instance);
			}
		}
		public string SResolutionY{
			get {
				return Aspect_FontStyle_SResolutionY(Instance);
			}
		}
		public string SSpacing{
			get {
				return Aspect_FontStyle_SSpacing(Instance);
			}
		}
		public string SAverageWidth{
			get {
				return Aspect_FontStyle_SAverageWidth(Instance);
			}
		}
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Aspect_FontStyle_Ctor();
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Aspect_FontStyle_Ctor625FF186(int Type,double Size,double Slant,bool CapsHeight);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Aspect_FontStyle_Ctor27C00EC7(string Style,double Size,double Slant,bool CapsHeight);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Aspect_FontStyle_Ctor9381D4D(string Style);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Aspect_FontStyle_Assign8E648131(IntPtr instance, IntPtr Other);
		[DllImport("NaroOccCore.dll")]
		private static extern void Aspect_FontStyle_SetValues625FF186(IntPtr instance, int Type,double Size,double Slant,bool CapsHeight);
		[DllImport("NaroOccCore.dll")]
		private static extern void Aspect_FontStyle_SetValues27C00EC7(IntPtr instance, string Style,double Size,double Slant,bool CapsHeight);
		[DllImport("NaroOccCore.dll")]
		private static extern void Aspect_FontStyle_SetValues9381D4D(IntPtr instance, string Style);
		[DllImport("NaroOccCore.dll")]
		private static extern void Aspect_FontStyle_Dump(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool Aspect_FontStyle_IsEqual8E648131(IntPtr instance, IntPtr Other);
		[DllImport("NaroOccCore.dll")]
		private static extern bool Aspect_FontStyle_IsNotEqual8E648131(IntPtr instance, IntPtr Other);
		[DllImport("NaroOccCore.dll")]
		private static extern int Aspect_FontStyle_Style(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern int Aspect_FontStyle_Length(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern string Aspect_FontStyle_Value(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern double Aspect_FontStyle_Size(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern double Aspect_FontStyle_Slant(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool Aspect_FontStyle_CapsHeight(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern string Aspect_FontStyle_AliasName(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern string Aspect_FontStyle_FullName(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern string Aspect_FontStyle_Foundry(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void Aspect_FontStyle_SetFamily(IntPtr instance, string value);
		[DllImport("NaroOccCore.dll")]
		private static extern string Aspect_FontStyle_Family(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void Aspect_FontStyle_SetWeight(IntPtr instance, string value);
		[DllImport("NaroOccCore.dll")]
		private static extern string Aspect_FontStyle_Weight(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void Aspect_FontStyle_SetRegistry(IntPtr instance, string value);
		[DllImport("NaroOccCore.dll")]
		private static extern string Aspect_FontStyle_Registry(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void Aspect_FontStyle_SetEncoding(IntPtr instance, string value);
		[DllImport("NaroOccCore.dll")]
		private static extern string Aspect_FontStyle_Encoding(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern string Aspect_FontStyle_SSlant(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern string Aspect_FontStyle_SWidth(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern string Aspect_FontStyle_SStyle(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern string Aspect_FontStyle_SPixelSize(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern string Aspect_FontStyle_SPointSize(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern string Aspect_FontStyle_SResolutionX(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern string Aspect_FontStyle_SResolutionY(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern string Aspect_FontStyle_SSpacing(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern string Aspect_FontStyle_SAverageWidth(IntPtr instance);

		#region NativeInstancePtr Convert constructor

		public AspectFontStyle(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ AspectFontStyle_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void AspectFontStyle_Dtor(IntPtr instance);
	}
}
