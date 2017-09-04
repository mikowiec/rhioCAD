#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;
using NaroCppCore.Occ.Graphic3d;
using NaroCppCore.Occ.Quantity;

#endregion

namespace NaroCppCore.Occ.Graphic3d
{
	public class Graphic3dMaterialAspect : NativeInstancePtr
	{
		public Graphic3dMaterialAspect()
 :
			base(Graphic3d_MaterialAspect_Ctor() )
		{}
		public Graphic3dMaterialAspect(Graphic3dNameOfMaterial AName)
 :
			base(Graphic3d_MaterialAspect_CtorE047B55B((int)AName) )
		{}
			public void IncreaseShine(double ADelta)
				{
					Graphic3d_MaterialAspect_IncreaseShineD82819F3(Instance, ADelta);
				}
			public void SetMaterialType(Graphic3dTypeOfMaterial AType)
				{
					Graphic3d_MaterialAspect_SetMaterialType34A704C6(Instance, (int)AType);
				}
			public void SetMaterialName(string AName)
				{
					Graphic3d_MaterialAspect_SetMaterialName9381D4D(Instance, AName);
				}
			public void Reset()
				{
					Graphic3d_MaterialAspect_Reset(Instance);
				}
			public bool ReflectionMode(Graphic3dTypeOfReflection AType)
				{
					return Graphic3d_MaterialAspect_ReflectionModeC74D89AD(Instance, (int)AType);
				}
			public bool MaterialType(Graphic3dTypeOfMaterial AType)
				{
					return Graphic3d_MaterialAspect_MaterialType34A704C6(Instance, (int)AType);
				}
			public bool IsDifferent(Graphic3dMaterialAspect Other)
				{
					return Graphic3d_MaterialAspect_IsDifferentC0044920(Instance, Other.Instance);
				}
			public bool IsEqual(Graphic3dMaterialAspect Other)
				{
					return Graphic3d_MaterialAspect_IsEqualC0044920(Instance, Other.Instance);
				}
			public static string MaterialName(int aRank)
				{
					return Graphic3d_MaterialAspect_MaterialNameE8219145(aRank);
				}
			public string MaterialName()
				{
					return Graphic3d_MaterialAspect_MaterialName(Instance);
				}
			public static Graphic3dTypeOfMaterial MaterialType(int aRank)
				{
					return (Graphic3dTypeOfMaterial)Graphic3d_MaterialAspect_MaterialTypeE8219145(aRank);
				}
		public Graphic3dTypeOfReflection ReflectionModeOn{
			set { 
				Graphic3d_MaterialAspect_SetReflectionModeOn(Instance, (int)value);
			}
		}
		public Graphic3dTypeOfReflection ReflectionModeOff{
			set { 
				Graphic3d_MaterialAspect_SetReflectionModeOff(Instance, (int)value);
			}
		}
		public QuantityColor Color{
			set { 
				Graphic3d_MaterialAspect_SetColor(Instance, value.Instance);
			}
			get {
				return new QuantityColor(Graphic3d_MaterialAspect_Color(Instance));
			}
		}
		public QuantityColor AmbientColor{
			set { 
				Graphic3d_MaterialAspect_SetAmbientColor(Instance, value.Instance);
			}
			get {
				return new QuantityColor(Graphic3d_MaterialAspect_AmbientColor(Instance));
			}
		}
		public QuantityColor DiffuseColor{
			set { 
				Graphic3d_MaterialAspect_SetDiffuseColor(Instance, value.Instance);
			}
			get {
				return new QuantityColor(Graphic3d_MaterialAspect_DiffuseColor(Instance));
			}
		}
		public QuantityColor SpecularColor{
			set { 
				Graphic3d_MaterialAspect_SetSpecularColor(Instance, value.Instance);
			}
			get {
				return new QuantityColor(Graphic3d_MaterialAspect_SpecularColor(Instance));
			}
		}
		public QuantityColor EmissiveColor{
			set { 
				Graphic3d_MaterialAspect_SetEmissiveColor(Instance, value.Instance);
			}
			get {
				return new QuantityColor(Graphic3d_MaterialAspect_EmissiveColor(Instance));
			}
		}
		public double Ambient{
			set { 
				Graphic3d_MaterialAspect_SetAmbient(Instance, value);
			}
			get {
				return Graphic3d_MaterialAspect_Ambient(Instance);
			}
		}
		public double Diffuse{
			set { 
				Graphic3d_MaterialAspect_SetDiffuse(Instance, value);
			}
			get {
				return Graphic3d_MaterialAspect_Diffuse(Instance);
			}
		}
		public double Specular{
			set { 
				Graphic3d_MaterialAspect_SetSpecular(Instance, value);
			}
			get {
				return Graphic3d_MaterialAspect_Specular(Instance);
			}
		}
		public double Transparency{
			set { 
				Graphic3d_MaterialAspect_SetTransparency(Instance, value);
			}
			get {
				return Graphic3d_MaterialAspect_Transparency(Instance);
			}
		}
		public double Emissive{
			set { 
				Graphic3d_MaterialAspect_SetEmissive(Instance, value);
			}
			get {
				return Graphic3d_MaterialAspect_Emissive(Instance);
			}
		}
		public double Shininess{
			set { 
				Graphic3d_MaterialAspect_SetShininess(Instance, value);
			}
			get {
				return Graphic3d_MaterialAspect_Shininess(Instance);
			}
		}
		public double EnvReflexion{
			set { 
				Graphic3d_MaterialAspect_SetEnvReflexion(Instance, value);
			}
			get {
				return Graphic3d_MaterialAspect_EnvReflexion(Instance);
			}
		}
		public Graphic3dNameOfMaterial Name{
			get {
				return (Graphic3dNameOfMaterial)Graphic3d_MaterialAspect_Name(Instance);
			}
		}
		public static int NumberOfMaterials{
			get {
				return Graphic3d_MaterialAspect_NumberOfMaterials();
			}
		}
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Graphic3d_MaterialAspect_Ctor();
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Graphic3d_MaterialAspect_CtorE047B55B(int AName);
		[DllImport("NaroOccCore.dll")]
		private static extern void Graphic3d_MaterialAspect_IncreaseShineD82819F3(IntPtr instance, double ADelta);
		[DllImport("NaroOccCore.dll")]
		private static extern void Graphic3d_MaterialAspect_SetMaterialType34A704C6(IntPtr instance, int AType);
		[DllImport("NaroOccCore.dll")]
		private static extern void Graphic3d_MaterialAspect_SetMaterialName9381D4D(IntPtr instance, string AName);
		[DllImport("NaroOccCore.dll")]
		private static extern void Graphic3d_MaterialAspect_Reset(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool Graphic3d_MaterialAspect_ReflectionModeC74D89AD(IntPtr instance, int AType);
		[DllImport("NaroOccCore.dll")]
		private static extern bool Graphic3d_MaterialAspect_MaterialType34A704C6(IntPtr instance, int AType);
		[DllImport("NaroOccCore.dll")]
		private static extern bool Graphic3d_MaterialAspect_IsDifferentC0044920(IntPtr instance, IntPtr Other);
		[DllImport("NaroOccCore.dll")]
		private static extern bool Graphic3d_MaterialAspect_IsEqualC0044920(IntPtr instance, IntPtr Other);
		[DllImport("NaroOccCore.dll")]
		private static extern string Graphic3d_MaterialAspect_MaterialNameE8219145(int aRank);
		[DllImport("NaroOccCore.dll")]
		private static extern string Graphic3d_MaterialAspect_MaterialName(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern int Graphic3d_MaterialAspect_MaterialTypeE8219145(int aRank);
		[DllImport("NaroOccCore.dll")]
		private static extern void Graphic3d_MaterialAspect_SetReflectionModeOn(IntPtr instance, int value);
		[DllImport("NaroOccCore.dll")]
		private static extern void Graphic3d_MaterialAspect_SetReflectionModeOff(IntPtr instance, int value);
		[DllImport("NaroOccCore.dll")]
		private static extern void Graphic3d_MaterialAspect_SetColor(IntPtr instance, IntPtr value);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Graphic3d_MaterialAspect_Color(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void Graphic3d_MaterialAspect_SetAmbientColor(IntPtr instance, IntPtr value);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Graphic3d_MaterialAspect_AmbientColor(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void Graphic3d_MaterialAspect_SetDiffuseColor(IntPtr instance, IntPtr value);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Graphic3d_MaterialAspect_DiffuseColor(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void Graphic3d_MaterialAspect_SetSpecularColor(IntPtr instance, IntPtr value);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Graphic3d_MaterialAspect_SpecularColor(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void Graphic3d_MaterialAspect_SetEmissiveColor(IntPtr instance, IntPtr value);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Graphic3d_MaterialAspect_EmissiveColor(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void Graphic3d_MaterialAspect_SetAmbient(IntPtr instance, double value);
		[DllImport("NaroOccCore.dll")]
		private static extern double Graphic3d_MaterialAspect_Ambient(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void Graphic3d_MaterialAspect_SetDiffuse(IntPtr instance, double value);
		[DllImport("NaroOccCore.dll")]
		private static extern double Graphic3d_MaterialAspect_Diffuse(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void Graphic3d_MaterialAspect_SetSpecular(IntPtr instance, double value);
		[DllImport("NaroOccCore.dll")]
		private static extern double Graphic3d_MaterialAspect_Specular(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void Graphic3d_MaterialAspect_SetTransparency(IntPtr instance, double value);
		[DllImport("NaroOccCore.dll")]
		private static extern double Graphic3d_MaterialAspect_Transparency(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void Graphic3d_MaterialAspect_SetEmissive(IntPtr instance, double value);
		[DllImport("NaroOccCore.dll")]
		private static extern double Graphic3d_MaterialAspect_Emissive(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void Graphic3d_MaterialAspect_SetShininess(IntPtr instance, double value);
		[DllImport("NaroOccCore.dll")]
		private static extern double Graphic3d_MaterialAspect_Shininess(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void Graphic3d_MaterialAspect_SetEnvReflexion(IntPtr instance, double value);
		[DllImport("NaroOccCore.dll")]
		private static extern double Graphic3d_MaterialAspect_EnvReflexion(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern int Graphic3d_MaterialAspect_Name(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern int Graphic3d_MaterialAspect_NumberOfMaterials();

		#region NativeInstancePtr Convert constructor

		public Graphic3dMaterialAspect(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ Graphic3dMaterialAspect_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void Graphic3dMaterialAspect_Dtor(IntPtr instance);
	}
}
