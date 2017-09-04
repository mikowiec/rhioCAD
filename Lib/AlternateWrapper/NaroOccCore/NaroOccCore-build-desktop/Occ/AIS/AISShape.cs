#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;
using NaroCppCore.Occ.AIS;
using NaroCppCore.Occ.TopoDS;
using NaroCppCore.Occ.Bnd;
using NaroCppCore.Occ.Quantity;
using NaroCppCore.Occ.Graphic3d;
using NaroCppCore.Occ.TopAbs;
using NaroCppCore.Occ.Prs3d;

#endregion

namespace NaroCppCore.Occ.AIS
{
	public class AISShape : AISInteractiveObject
	{
		public AISShape(TopoDSShape shap)
 :
			base(AIS_Shape_Ctor9EBAC0C0(shap.Instance) )
		{}
			public void Set(TopoDSShape ashap)
				{
					AIS_Shape_Set9EBAC0C0(Instance, ashap.Instance);
				}
			public bool SetOwnDeviationCoefficient()
				{
					return AIS_Shape_SetOwnDeviationCoefficient(Instance);
				}
			public bool SetOwnHLRDeviationCoefficient()
				{
					return AIS_Shape_SetOwnHLRDeviationCoefficient(Instance);
				}
			public bool SetOwnDeviationAngle()
				{
					return AIS_Shape_SetOwnDeviationAngle(Instance);
				}
			public bool SetOwnHLRDeviationAngle()
				{
					return AIS_Shape_SetOwnHLRDeviationAngle(Instance);
				}
			public void SetOwnDeviationCoefficient(double aCoefficient)
				{
					AIS_Shape_SetOwnDeviationCoefficientD82819F3(Instance, aCoefficient);
				}
			public void SetOwnHLRDeviationCoefficient(double aCoefficient)
				{
					AIS_Shape_SetOwnHLRDeviationCoefficientD82819F3(Instance, aCoefficient);
				}
			public void SetOwnDeviationAngle(double anAngle)
				{
					AIS_Shape_SetOwnDeviationAngleD82819F3(Instance, anAngle);
				}
			public void SetOwnHLRDeviationAngle(double anAngle)
				{
					AIS_Shape_SetOwnHLRDeviationAngleD82819F3(Instance, anAngle);
				}
			public bool OwnDeviationCoefficient(ref double aCoefficient,ref double aPreviousCoefficient)
				{
					return AIS_Shape_OwnDeviationCoefficient9F0E714F(Instance, ref aCoefficient, ref aPreviousCoefficient);
				}
			public bool OwnHLRDeviationCoefficient(ref double aCoefficient,ref double aPreviousCoefficient)
				{
					return AIS_Shape_OwnHLRDeviationCoefficient9F0E714F(Instance, ref aCoefficient, ref aPreviousCoefficient);
				}
			public bool OwnDeviationAngle(ref double anAngle,ref double aPreviousAngle)
				{
					return AIS_Shape_OwnDeviationAngle9F0E714F(Instance, ref anAngle, ref aPreviousAngle);
				}
			public bool OwnHLRDeviationAngle(ref double anAngle,ref double aPreviousAngle)
				{
					return AIS_Shape_OwnHLRDeviationAngle9F0E714F(Instance, ref anAngle, ref aPreviousAngle);
				}
			public void SetColor(QuantityNameOfColor aColor)
				{
					AIS_Shape_SetColor48F4F471(Instance, (int)aColor);
				}
			public void SetColor(QuantityColor aColor)
				{
					AIS_Shape_SetColor8FD7F48(Instance, aColor.Instance);
				}
			public void UnsetColor()
				{
					AIS_Shape_UnsetColor(Instance);
				}
			public void UnsetWidth()
				{
					AIS_Shape_UnsetWidth(Instance);
				}
			public void SetMaterial(Graphic3dNameOfMaterial aName)
				{
					AIS_Shape_SetMaterialE047B55B(Instance, (int)aName);
				}
			public void SetMaterial(Graphic3dMaterialAspect aName)
				{
					AIS_Shape_SetMaterialC0044920(Instance, aName.Instance);
				}
			public void UnsetMaterial()
				{
					AIS_Shape_UnsetMaterial(Instance);
				}
			public void UnsetTransparency()
				{
					AIS_Shape_UnsetTransparency(Instance);
				}
			public QuantityNameOfColor Color()
				{
					return (QuantityNameOfColor)AIS_Shape_Color(Instance);
				}
			public void Color(QuantityColor aColor)
				{
					AIS_Shape_Color8FD7F48(Instance, aColor.Instance);
				}
			public Graphic3dNameOfMaterial Material()
				{
					return (Graphic3dNameOfMaterial)AIS_Shape_Material(Instance);
				}
			public static TopAbsShapeEnum SelectionType(int aDecompositionMode)
				{
					return (TopAbsShapeEnum)AIS_Shape_SelectionTypeE8219145(aDecompositionMode);
				}
			public static int SelectionMode(TopAbsShapeEnum aShapeType)
				{
					return AIS_Shape_SelectionModeC6FD32C4((int)aShapeType);
				}
			public static double GetDeflection(TopoDSShape aShape,Prs3dDrawer aDrawer)
				{
					return AIS_Shape_GetDeflectionC3E71CA1(aShape.Instance, aDrawer.Instance);
				}
		public int Signature{
			get {
				return AIS_Shape_Signature(Instance);
			}
		}
		public AISKindOfInteractive Type{
			get {
				return (AISKindOfInteractive)AIS_Shape_Type(Instance);
			}
		}
		public bool AcceptShapeDecomposition{
			get {
				return AIS_Shape_AcceptShapeDecomposition(Instance);
			}
		}
		public TopoDSShape Shape{
			get {
				return new TopoDSShape(AIS_Shape_Shape(Instance));
			}
		}
		public double AngleAndDeviation{
			set { 
				AIS_Shape_SetAngleAndDeviation(Instance, value);
			}
		}
		public double UserAngle{
			get {
				return AIS_Shape_UserAngle(Instance);
			}
		}
		public double HLRAngleAndDeviation{
			set { 
				AIS_Shape_SetHLRAngleAndDeviation(Instance, value);
			}
		}
		public double Width{
			set { 
				AIS_Shape_SetWidth(Instance, value);
			}
		}
		public BndBox BoundingBox{
			get {
				return new BndBox(AIS_Shape_BoundingBox(Instance));
			}
		}
		public double Transparency{
			set { 
				AIS_Shape_SetTransparency(Instance, value);
			}
			get {
				return AIS_Shape_Transparency(Instance);
			}
		}
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr AIS_Shape_Ctor9EBAC0C0(IntPtr shap);
		[DllImport("NaroOccCore.dll")]
		private static extern void AIS_Shape_Set9EBAC0C0(IntPtr instance, IntPtr ashap);
		[DllImport("NaroOccCore.dll")]
		private static extern bool AIS_Shape_SetOwnDeviationCoefficient(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool AIS_Shape_SetOwnHLRDeviationCoefficient(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool AIS_Shape_SetOwnDeviationAngle(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool AIS_Shape_SetOwnHLRDeviationAngle(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void AIS_Shape_SetOwnDeviationCoefficientD82819F3(IntPtr instance, double aCoefficient);
		[DllImport("NaroOccCore.dll")]
		private static extern void AIS_Shape_SetOwnHLRDeviationCoefficientD82819F3(IntPtr instance, double aCoefficient);
		[DllImport("NaroOccCore.dll")]
		private static extern void AIS_Shape_SetOwnDeviationAngleD82819F3(IntPtr instance, double anAngle);
		[DllImport("NaroOccCore.dll")]
		private static extern void AIS_Shape_SetOwnHLRDeviationAngleD82819F3(IntPtr instance, double anAngle);
		[DllImport("NaroOccCore.dll")]
		private static extern bool AIS_Shape_OwnDeviationCoefficient9F0E714F(IntPtr instance, ref double aCoefficient,ref double aPreviousCoefficient);
		[DllImport("NaroOccCore.dll")]
		private static extern bool AIS_Shape_OwnHLRDeviationCoefficient9F0E714F(IntPtr instance, ref double aCoefficient,ref double aPreviousCoefficient);
		[DllImport("NaroOccCore.dll")]
		private static extern bool AIS_Shape_OwnDeviationAngle9F0E714F(IntPtr instance, ref double anAngle,ref double aPreviousAngle);
		[DllImport("NaroOccCore.dll")]
		private static extern bool AIS_Shape_OwnHLRDeviationAngle9F0E714F(IntPtr instance, ref double anAngle,ref double aPreviousAngle);
		[DllImport("NaroOccCore.dll")]
		private static extern void AIS_Shape_SetColor48F4F471(IntPtr instance, int aColor);
		[DllImport("NaroOccCore.dll")]
		private static extern void AIS_Shape_SetColor8FD7F48(IntPtr instance, IntPtr aColor);
		[DllImport("NaroOccCore.dll")]
		private static extern void AIS_Shape_UnsetColor(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void AIS_Shape_UnsetWidth(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void AIS_Shape_SetMaterialE047B55B(IntPtr instance, int aName);
		[DllImport("NaroOccCore.dll")]
		private static extern void AIS_Shape_SetMaterialC0044920(IntPtr instance, IntPtr aName);
		[DllImport("NaroOccCore.dll")]
		private static extern void AIS_Shape_UnsetMaterial(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void AIS_Shape_UnsetTransparency(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern int AIS_Shape_Color(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void AIS_Shape_Color8FD7F48(IntPtr instance, IntPtr aColor);
		[DllImport("NaroOccCore.dll")]
		private static extern int AIS_Shape_Material(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern int AIS_Shape_SelectionTypeE8219145(int aDecompositionMode);
		[DllImport("NaroOccCore.dll")]
		private static extern int AIS_Shape_SelectionModeC6FD32C4(int aShapeType);
		[DllImport("NaroOccCore.dll")]
		private static extern double AIS_Shape_GetDeflectionC3E71CA1(IntPtr aShape,IntPtr aDrawer);
		[DllImport("NaroOccCore.dll")]
		private static extern int AIS_Shape_Signature(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern int AIS_Shape_Type(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool AIS_Shape_AcceptShapeDecomposition(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr AIS_Shape_Shape(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void AIS_Shape_SetAngleAndDeviation(IntPtr instance, double value);
		[DllImport("NaroOccCore.dll")]
		private static extern double AIS_Shape_UserAngle(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void AIS_Shape_SetHLRAngleAndDeviation(IntPtr instance, double value);
		[DllImport("NaroOccCore.dll")]
		private static extern void AIS_Shape_SetWidth(IntPtr instance, double value);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr AIS_Shape_BoundingBox(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void AIS_Shape_SetTransparency(IntPtr instance, double value);
		[DllImport("NaroOccCore.dll")]
		private static extern double AIS_Shape_Transparency(IntPtr instance);

		#region NativeInstancePtr Convert constructor

		public AISShape() { } 

		public AISShape(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ AISShape_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void AISShape_Dtor(IntPtr instance);
	}
}
