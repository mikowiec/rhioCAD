#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;
using NaroCppCore.Occ.AIS;
using NaroCppCore.Occ.TopoDS;
using NaroCppCore.Occ.Geom;
using NaroCppCore.Occ.gp;
using NaroCppCore.Occ.TCollection;
using NaroCppCore.Occ.DsgPrs;
using NaroCppCore.Occ.Quantity;

#endregion

namespace NaroCppCore.Occ.AIS
{
	public class AISRelation : AISInteractiveObject
	{
			public void SetColor(QuantityNameOfColor aColor)
				{
					AIS_Relation_SetColor48F4F471(Instance, (int)aColor);
				}
			public void SetColor(QuantityColor aColor)
				{
					AIS_Relation_SetColor8FD7F48(Instance, aColor.Instance);
				}
			public void UnsetColor()
				{
					AIS_Relation_UnsetColor(Instance);
				}
			public void SetBndBox(double Xmin,double Ymin,double Zmin,double Xmax,double Ymax,double Zmax)
				{
					AIS_Relation_SetBndBoxBC7A5786(Instance, Xmin, Ymin, Zmin, Xmax, Ymax, Zmax);
				}
			public void UnsetBndBox()
				{
					AIS_Relation_UnsetBndBox(Instance);
				}
			public bool AcceptDisplayMode(int aMode)
				{
					return AIS_Relation_AcceptDisplayModeE8219145(Instance, aMode);
				}
		public AISKindOfInteractive Type{
			get {
				return (AISKindOfInteractive)AIS_Relation_Type(Instance);
			}
		}
		public AISKindOfDimension KindOfDimension{
			get {
				return (AISKindOfDimension)AIS_Relation_KindOfDimension(Instance);
			}
		}
		public bool IsMovable{
			get {
				return AIS_Relation_IsMovable(Instance);
			}
		}
		public TopoDSShape FirstShape{
			set { 
				AIS_Relation_SetFirstShape(Instance, value.Instance);
			}
			get {
				return new TopoDSShape(AIS_Relation_FirstShape(Instance));
			}
		}
		public TopoDSShape SecondShape{
			set { 
				AIS_Relation_SetSecondShape(Instance, value.Instance);
			}
			get {
				return new TopoDSShape(AIS_Relation_SecondShape(Instance));
			}
		}
		public GeomPlane Plane{
			set { 
				AIS_Relation_SetPlane(Instance, value.Instance);
			}
			get {
				return new GeomPlane(AIS_Relation_Plane(Instance));
			}
		}
		public double Value{
			set { 
				AIS_Relation_SetValue(Instance, value);
			}
			get {
				return AIS_Relation_Value(Instance);
			}
		}
		public gpPnt Position{
			set { 
				AIS_Relation_SetPosition(Instance, value.Instance);
			}
			get {
				return new gpPnt(AIS_Relation_Position(Instance));
			}
		}
		public TCollectionExtendedString Text{
			set { 
				AIS_Relation_SetText(Instance, value.Instance);
			}
			get {
				return new TCollectionExtendedString(AIS_Relation_Text(Instance));
			}
		}
		public double ArrowSize{
			set { 
				AIS_Relation_SetArrowSize(Instance, value);
			}
			get {
				return AIS_Relation_ArrowSize(Instance);
			}
		}
		public DsgPrsArrowSide SymbolPrs{
			set { 
				AIS_Relation_SetSymbolPrs(Instance, (int)value);
			}
			get {
				return (DsgPrsArrowSide)AIS_Relation_SymbolPrs(Instance);
			}
		}
		public int ExtShape{
			set { 
				AIS_Relation_SetExtShape(Instance, value);
			}
			get {
				return AIS_Relation_ExtShape(Instance);
			}
		}
		public bool AutomaticPosition{
			set { 
				AIS_Relation_SetAutomaticPosition(Instance, value);
			}
			get {
				return AIS_Relation_AutomaticPosition(Instance);
			}
		}
		[DllImport("NaroOccCore.dll")]
		private static extern void AIS_Relation_SetColor48F4F471(IntPtr instance, int aColor);
		[DllImport("NaroOccCore.dll")]
		private static extern void AIS_Relation_SetColor8FD7F48(IntPtr instance, IntPtr aColor);
		[DllImport("NaroOccCore.dll")]
		private static extern void AIS_Relation_UnsetColor(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void AIS_Relation_SetBndBoxBC7A5786(IntPtr instance, double Xmin,double Ymin,double Zmin,double Xmax,double Ymax,double Zmax);
		[DllImport("NaroOccCore.dll")]
		private static extern void AIS_Relation_UnsetBndBox(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool AIS_Relation_AcceptDisplayModeE8219145(IntPtr instance, int aMode);
		[DllImport("NaroOccCore.dll")]
		private static extern int AIS_Relation_Type(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern int AIS_Relation_KindOfDimension(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool AIS_Relation_IsMovable(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void AIS_Relation_SetFirstShape(IntPtr instance, IntPtr value);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr AIS_Relation_FirstShape(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void AIS_Relation_SetSecondShape(IntPtr instance, IntPtr value);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr AIS_Relation_SecondShape(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void AIS_Relation_SetPlane(IntPtr instance, IntPtr value);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr AIS_Relation_Plane(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void AIS_Relation_SetValue(IntPtr instance, double value);
		[DllImport("NaroOccCore.dll")]
		private static extern double AIS_Relation_Value(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void AIS_Relation_SetPosition(IntPtr instance, IntPtr value);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr AIS_Relation_Position(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void AIS_Relation_SetText(IntPtr instance, IntPtr value);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr AIS_Relation_Text(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void AIS_Relation_SetArrowSize(IntPtr instance, double value);
		[DllImport("NaroOccCore.dll")]
		private static extern double AIS_Relation_ArrowSize(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void AIS_Relation_SetSymbolPrs(IntPtr instance, int value);
		[DllImport("NaroOccCore.dll")]
		private static extern int AIS_Relation_SymbolPrs(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void AIS_Relation_SetExtShape(IntPtr instance, int value);
		[DllImport("NaroOccCore.dll")]
		private static extern int AIS_Relation_ExtShape(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void AIS_Relation_SetAutomaticPosition(IntPtr instance, bool value);
		[DllImport("NaroOccCore.dll")]
		private static extern bool AIS_Relation_AutomaticPosition(IntPtr instance);

		#region NativeInstancePtr Convert constructor

		public AISRelation() { } 

		public AISRelation(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ AISRelation_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void AISRelation_Dtor(IntPtr instance);
	}
}
