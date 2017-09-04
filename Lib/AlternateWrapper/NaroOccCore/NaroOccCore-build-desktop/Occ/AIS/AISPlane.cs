#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;
using NaroCppCore.Occ.AIS;
using NaroCppCore.Occ.Geom;
using NaroCppCore.Occ.gp;
using NaroCppCore.Occ.SelectMgr;
using NaroCppCore.Occ.Quantity;

#endregion

namespace NaroCppCore.Occ.AIS
{
	public class AISPlane : AISInteractiveObject
	{
		public AISPlane(GeomPlane aComponent,bool aCurrentMode)
 :
			base(AIS_Plane_Ctor774085EF(aComponent.Instance, aCurrentMode) )
		{}
		public AISPlane(GeomPlane aComponent,gpPnt aCenter,bool aCurrentMode)
 :
			base(AIS_Plane_Ctor13B4A2BC(aComponent.Instance, aCenter.Instance, aCurrentMode) )
		{}
		public AISPlane(GeomPlane aComponent,gpPnt aCenter,gpPnt aPmin,gpPnt aPmax,bool aCurrentMode)
 :
			base(AIS_Plane_Ctor57A70980(aComponent.Instance, aCenter.Instance, aPmin.Instance, aPmax.Instance, aCurrentMode) )
		{}
		public AISPlane(GeomAxis2Placement aComponent,AISTypeOfPlane aPlaneType,bool aCurrentMode)
 :
			base(AIS_Plane_Ctor8C5294A9(aComponent.Instance, (int)aPlaneType, aCurrentMode) )
		{}
			public void SetSize(double aValue)
				{
					AIS_Plane_SetSizeD82819F3(Instance, aValue);
				}
			public void SetSize(double Xval,double YVal)
				{
					AIS_Plane_SetSize9F0E714F(Instance, Xval, YVal);
				}
			public void UnsetSize()
				{
					AIS_Plane_UnsetSize(Instance);
				}
			public bool Size(ref double X,ref double Y)
				{
					return AIS_Plane_Size9F0E714F(Instance, ref X, ref Y);
				}
			public bool PlaneAttributes(GeomPlane aComponent,gpPnt aCenter,gpPnt aPmin,gpPnt aPmax)
				{
					return AIS_Plane_PlaneAttributesC014B0(Instance, aComponent.Instance, aCenter.Instance, aPmin.Instance, aPmax.Instance);
				}
			public void SetPlaneAttributes(GeomPlane aComponent,gpPnt aCenter,gpPnt aPmin,gpPnt aPmax)
				{
					AIS_Plane_SetPlaneAttributesC014B0(Instance, aComponent.Instance, aCenter.Instance, aPmin.Instance, aPmax.Instance);
				}
			public void SetAxis2Placement(GeomAxis2Placement aComponent,AISTypeOfPlane aPlaneType)
				{
					AIS_Plane_SetAxis2PlacementA35F2F3B(Instance, aComponent.Instance, (int)aPlaneType);
				}
			public GeomAxis2Placement Axis2Placement()
				{
					return new GeomAxis2Placement(AIS_Plane_Axis2Placement(Instance));
				}
			public bool AcceptDisplayMode(int aMode)
				{
					return AIS_Plane_AcceptDisplayModeE8219145(Instance, aMode);
				}
			public void ComputeSelection(SelectMgrSelection aSelection,int aMode)
				{
					AIS_Plane_ComputeSelection7C718F26(Instance, aSelection.Instance, aMode);
				}
			public void SetColor(QuantityNameOfColor aColor)
				{
					AIS_Plane_SetColor48F4F471(Instance, (int)aColor);
				}
			public void SetColor(QuantityColor aColor)
				{
					AIS_Plane_SetColor8FD7F48(Instance, aColor.Instance);
				}
			public void UnsetColor()
				{
					AIS_Plane_UnsetColor(Instance);
				}
		public bool HasOwnSize{
			get {
				return AIS_Plane_HasOwnSize(Instance);
			}
		}
		public int Signature{
			get {
				return AIS_Plane_Signature(Instance);
			}
		}
		public AISKindOfInteractive Type{
			get {
				return (AISKindOfInteractive)AIS_Plane_Type(Instance);
			}
		}
		public GeomPlane Component{
			set { 
				AIS_Plane_SetComponent(Instance, value.Instance);
			}
			get {
				return new GeomPlane(AIS_Plane_Component(Instance));
			}
		}
		public gpPnt Center{
			set { 
				AIS_Plane_SetCenter(Instance, value.Instance);
			}
			get {
				return new gpPnt(AIS_Plane_Center(Instance));
			}
		}
		public AISTypeOfPlane TypeOfPlane{
			get {
				return (AISTypeOfPlane)AIS_Plane_TypeOfPlane(Instance);
			}
		}
		public bool IsXYZPlane{
			get {
				return AIS_Plane_IsXYZPlane(Instance);
			}
		}
		public bool CurrentMode{
			set { 
				AIS_Plane_SetCurrentMode(Instance, value);
			}
			get {
				return AIS_Plane_CurrentMode(Instance);
			}
		}
		public AISInteractiveContext Context{
			set { 
				AIS_Plane_SetContext(Instance, value.Instance);
			}
		}
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr AIS_Plane_Ctor774085EF(IntPtr aComponent,bool aCurrentMode);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr AIS_Plane_Ctor13B4A2BC(IntPtr aComponent,IntPtr aCenter,bool aCurrentMode);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr AIS_Plane_Ctor57A70980(IntPtr aComponent,IntPtr aCenter,IntPtr aPmin,IntPtr aPmax,bool aCurrentMode);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr AIS_Plane_Ctor8C5294A9(IntPtr aComponent,int aPlaneType,bool aCurrentMode);
		[DllImport("NaroOccCore.dll")]
		private static extern void AIS_Plane_SetSizeD82819F3(IntPtr instance, double aValue);
		[DllImport("NaroOccCore.dll")]
		private static extern void AIS_Plane_SetSize9F0E714F(IntPtr instance, double Xval,double YVal);
		[DllImport("NaroOccCore.dll")]
		private static extern void AIS_Plane_UnsetSize(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool AIS_Plane_Size9F0E714F(IntPtr instance, ref double X,ref double Y);
		[DllImport("NaroOccCore.dll")]
		private static extern bool AIS_Plane_PlaneAttributesC014B0(IntPtr instance, IntPtr aComponent,IntPtr aCenter,IntPtr aPmin,IntPtr aPmax);
		[DllImport("NaroOccCore.dll")]
		private static extern void AIS_Plane_SetPlaneAttributesC014B0(IntPtr instance, IntPtr aComponent,IntPtr aCenter,IntPtr aPmin,IntPtr aPmax);
		[DllImport("NaroOccCore.dll")]
		private static extern void AIS_Plane_SetAxis2PlacementA35F2F3B(IntPtr instance, IntPtr aComponent,int aPlaneType);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr AIS_Plane_Axis2Placement(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool AIS_Plane_AcceptDisplayModeE8219145(IntPtr instance, int aMode);
		[DllImport("NaroOccCore.dll")]
		private static extern void AIS_Plane_ComputeSelection7C718F26(IntPtr instance, IntPtr aSelection,int aMode);
		[DllImport("NaroOccCore.dll")]
		private static extern void AIS_Plane_SetColor48F4F471(IntPtr instance, int aColor);
		[DllImport("NaroOccCore.dll")]
		private static extern void AIS_Plane_SetColor8FD7F48(IntPtr instance, IntPtr aColor);
		[DllImport("NaroOccCore.dll")]
		private static extern void AIS_Plane_UnsetColor(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool AIS_Plane_HasOwnSize(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern int AIS_Plane_Signature(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern int AIS_Plane_Type(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void AIS_Plane_SetComponent(IntPtr instance, IntPtr value);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr AIS_Plane_Component(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void AIS_Plane_SetCenter(IntPtr instance, IntPtr value);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr AIS_Plane_Center(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern int AIS_Plane_TypeOfPlane(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool AIS_Plane_IsXYZPlane(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void AIS_Plane_SetCurrentMode(IntPtr instance, bool value);
		[DllImport("NaroOccCore.dll")]
		private static extern bool AIS_Plane_CurrentMode(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void AIS_Plane_SetContext(IntPtr instance, IntPtr value);

		#region NativeInstancePtr Convert constructor

		public AISPlane() { } 

		public AISPlane(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ AISPlane_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void AISPlane_Dtor(IntPtr instance);
	}
}
