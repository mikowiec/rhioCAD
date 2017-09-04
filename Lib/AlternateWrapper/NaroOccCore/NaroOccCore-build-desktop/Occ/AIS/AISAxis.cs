#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;
using NaroCppCore.Occ.AIS;
using NaroCppCore.Occ.Geom;
using NaroCppCore.Occ.Quantity;

#endregion

namespace NaroCppCore.Occ.AIS
{
	public class AISAxis : AISInteractiveObject
	{
		public AISAxis(GeomLine aComponent)
 :
			base(AIS_Axis_Ctor7C3C08A3(aComponent.Instance) )
		{}
		public AISAxis(GeomAxis2Placement aComponent,AISTypeOfAxis anAxisType)
 :
			base(AIS_Axis_CtorD1476D1E(aComponent.Instance, (int)anAxisType) )
		{}
		public AISAxis(GeomAxis1Placement anAxis)
 :
			base(AIS_Axis_CtorA2B99193(anAxis.Instance) )
		{}
			public GeomAxis2Placement Axis2Placement()
				{
					return new GeomAxis2Placement(AIS_Axis_Axis2Placement(Instance));
				}
			public void SetAxis2Placement(GeomAxis2Placement aComponent,AISTypeOfAxis anAxisType)
				{
					AIS_Axis_SetAxis2PlacementD1476D1E(Instance, aComponent.Instance, (int)anAxisType);
				}
			public bool AcceptDisplayMode(int aMode)
				{
					return AIS_Axis_AcceptDisplayModeE8219145(Instance, aMode);
				}
			public void SetColor(QuantityNameOfColor aColor)
				{
					AIS_Axis_SetColor48F4F471(Instance, (int)aColor);
				}
			public void SetColor(QuantityColor aColor)
				{
					AIS_Axis_SetColor8FD7F48(Instance, aColor.Instance);
				}
			public void UnsetColor()
				{
					AIS_Axis_UnsetColor(Instance);
				}
			public void UnsetWidth()
				{
					AIS_Axis_UnsetWidth(Instance);
				}
		public GeomLine Component{
			set { 
				AIS_Axis_SetComponent(Instance, value.Instance);
			}
			get {
				return new GeomLine(AIS_Axis_Component(Instance));
			}
		}
		public GeomAxis1Placement Axis1Placement{
			set { 
				AIS_Axis_SetAxis1Placement(Instance, value.Instance);
			}
		}
		public AISTypeOfAxis TypeOfAxis{
			set { 
				AIS_Axis_SetTypeOfAxis(Instance, (int)value);
			}
			get {
				return (AISTypeOfAxis)AIS_Axis_TypeOfAxis(Instance);
			}
		}
		public bool IsXYZAxis{
			get {
				return AIS_Axis_IsXYZAxis(Instance);
			}
		}
		public int Signature{
			get {
				return AIS_Axis_Signature(Instance);
			}
		}
		public AISKindOfInteractive Type{
			get {
				return (AISKindOfInteractive)AIS_Axis_Type(Instance);
			}
		}
		public double Width{
			set { 
				AIS_Axis_SetWidth(Instance, value);
			}
		}
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr AIS_Axis_Ctor7C3C08A3(IntPtr aComponent);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr AIS_Axis_CtorD1476D1E(IntPtr aComponent,int anAxisType);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr AIS_Axis_CtorA2B99193(IntPtr anAxis);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr AIS_Axis_Axis2Placement(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void AIS_Axis_SetAxis2PlacementD1476D1E(IntPtr instance, IntPtr aComponent,int anAxisType);
		[DllImport("NaroOccCore.dll")]
		private static extern bool AIS_Axis_AcceptDisplayModeE8219145(IntPtr instance, int aMode);
		[DllImport("NaroOccCore.dll")]
		private static extern void AIS_Axis_SetColor48F4F471(IntPtr instance, int aColor);
		[DllImport("NaroOccCore.dll")]
		private static extern void AIS_Axis_SetColor8FD7F48(IntPtr instance, IntPtr aColor);
		[DllImport("NaroOccCore.dll")]
		private static extern void AIS_Axis_UnsetColor(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void AIS_Axis_UnsetWidth(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void AIS_Axis_SetComponent(IntPtr instance, IntPtr value);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr AIS_Axis_Component(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void AIS_Axis_SetAxis1Placement(IntPtr instance, IntPtr value);
		[DllImport("NaroOccCore.dll")]
		private static extern void AIS_Axis_SetTypeOfAxis(IntPtr instance, int value);
		[DllImport("NaroOccCore.dll")]
		private static extern int AIS_Axis_TypeOfAxis(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool AIS_Axis_IsXYZAxis(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern int AIS_Axis_Signature(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern int AIS_Axis_Type(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void AIS_Axis_SetWidth(IntPtr instance, double value);

		#region NativeInstancePtr Convert constructor

		public AISAxis() { } 

		public AISAxis(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ AISAxis_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void AISAxis_Dtor(IntPtr instance);
	}
}
