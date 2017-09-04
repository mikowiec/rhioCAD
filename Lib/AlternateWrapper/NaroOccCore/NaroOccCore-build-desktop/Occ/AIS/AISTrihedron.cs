#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;
using NaroCppCore.Occ.AIS;
using NaroCppCore.Occ.Geom;
using NaroCppCore.Occ.TopLoc;
using NaroCppCore.Occ.Quantity;
using NaroCppCore.Occ.TColgp;

#endregion

namespace NaroCppCore.Occ.AIS
{
	public class AISTrihedron : AISInteractiveObject
	{
		public AISTrihedron(GeomAxis2Placement aComponent)
 :
			base(AIS_Trihedron_Ctor3B3DCDDA(aComponent.Instance) )
		{}
			public void UnsetSize()
				{
					AIS_Trihedron_UnsetSize(Instance);
				}
			public bool AcceptDisplayMode(int aMode)
				{
					return AIS_Trihedron_AcceptDisplayModeE8219145(Instance, aMode);
				}
			public void SetColor(QuantityNameOfColor aColor)
				{
					AIS_Trihedron_SetColor48F4F471(Instance, (int)aColor);
				}
			public void SetColor(QuantityColor aColor)
				{
					AIS_Trihedron_SetColor8FD7F48(Instance, aColor.Instance);
				}
			public void ExtremityPoints(TColgpArray1OfPnt TheExtrem)
				{
					AIS_Trihedron_ExtremityPointsFABD0F95(Instance, TheExtrem.Instance);
				}
			public void UnsetColor()
				{
					AIS_Trihedron_UnsetColor(Instance);
				}
			public void UnsetWidth()
				{
					AIS_Trihedron_UnsetWidth(Instance);
				}
		public GeomAxis2Placement Component{
			set { 
				AIS_Trihedron_SetComponent(Instance, value.Instance);
			}
			get {
				return new GeomAxis2Placement(AIS_Trihedron_Component(Instance));
			}
		}
		public bool HasOwnSize{
			get {
				return AIS_Trihedron_HasOwnSize(Instance);
			}
		}
		public double Size{
			set { 
				AIS_Trihedron_SetSize(Instance, value);
			}
			get {
				return AIS_Trihedron_Size(Instance);
			}
		}
		public AISAxis XAxis{
			get {
				return new AISAxis(AIS_Trihedron_XAxis(Instance));
			}
		}
		public AISAxis YAxis{
			get {
				return new AISAxis(AIS_Trihedron_YAxis(Instance));
			}
		}
		public AISAxis Axis{
			get {
				return new AISAxis(AIS_Trihedron_Axis(Instance));
			}
		}
		public AISPoint Position{
			get {
				return new AISPoint(AIS_Trihedron_Position(Instance));
			}
		}
		public AISPlane XYPlane{
			get {
				return new AISPlane(AIS_Trihedron_XYPlane(Instance));
			}
		}
		public AISPlane XZPlane{
			get {
				return new AISPlane(AIS_Trihedron_XZPlane(Instance));
			}
		}
		public AISPlane YZPlane{
			get {
				return new AISPlane(AIS_Trihedron_YZPlane(Instance));
			}
		}
		public AISInteractiveContext Context{
			set { 
				AIS_Trihedron_SetContext(Instance, value.Instance);
			}
		}
		public TopLocLocation Location{
			set { 
				AIS_Trihedron_SetLocation(Instance, value.Instance);
			}
		}
		public int Signature{
			get {
				return AIS_Trihedron_Signature(Instance);
			}
		}
		public AISKindOfInteractive Type{
			get {
				return (AISKindOfInteractive)AIS_Trihedron_Type(Instance);
			}
		}
		public bool HasTextColor{
			get {
				return AIS_Trihedron_HasTextColor(Instance);
			}
		}
		public QuantityNameOfColor TextColor{
			set { 
				AIS_Trihedron_SetTextColor(Instance, (int)value);
			}
			get {
				return (QuantityNameOfColor)AIS_Trihedron_TextColor(Instance);
			}
		}
		public bool HasArrowColor{
			get {
				return AIS_Trihedron_HasArrowColor(Instance);
			}
		}
		public QuantityNameOfColor ArrowColor{
			set { 
				AIS_Trihedron_SetArrowColor(Instance, (int)value);
			}
			get {
				return (QuantityNameOfColor)AIS_Trihedron_ArrowColor(Instance);
			}
		}
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr AIS_Trihedron_Ctor3B3DCDDA(IntPtr aComponent);
		[DllImport("NaroOccCore.dll")]
		private static extern void AIS_Trihedron_UnsetSize(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool AIS_Trihedron_AcceptDisplayModeE8219145(IntPtr instance, int aMode);
		[DllImport("NaroOccCore.dll")]
		private static extern void AIS_Trihedron_SetColor48F4F471(IntPtr instance, int aColor);
		[DllImport("NaroOccCore.dll")]
		private static extern void AIS_Trihedron_SetColor8FD7F48(IntPtr instance, IntPtr aColor);
		[DllImport("NaroOccCore.dll")]
		private static extern void AIS_Trihedron_ExtremityPointsFABD0F95(IntPtr instance, IntPtr TheExtrem);
		[DllImport("NaroOccCore.dll")]
		private static extern void AIS_Trihedron_UnsetColor(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void AIS_Trihedron_UnsetWidth(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void AIS_Trihedron_SetComponent(IntPtr instance, IntPtr value);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr AIS_Trihedron_Component(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool AIS_Trihedron_HasOwnSize(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void AIS_Trihedron_SetSize(IntPtr instance, double value);
		[DllImport("NaroOccCore.dll")]
		private static extern double AIS_Trihedron_Size(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr AIS_Trihedron_XAxis(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr AIS_Trihedron_YAxis(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr AIS_Trihedron_Axis(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr AIS_Trihedron_Position(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr AIS_Trihedron_XYPlane(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr AIS_Trihedron_XZPlane(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr AIS_Trihedron_YZPlane(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void AIS_Trihedron_SetContext(IntPtr instance, IntPtr value);
		[DllImport("NaroOccCore.dll")]
		private static extern void AIS_Trihedron_SetLocation(IntPtr instance, IntPtr value);
		[DllImport("NaroOccCore.dll")]
		private static extern int AIS_Trihedron_Signature(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern int AIS_Trihedron_Type(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool AIS_Trihedron_HasTextColor(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void AIS_Trihedron_SetTextColor(IntPtr instance, int value);
		[DllImport("NaroOccCore.dll")]
		private static extern int AIS_Trihedron_TextColor(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool AIS_Trihedron_HasArrowColor(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void AIS_Trihedron_SetArrowColor(IntPtr instance, int value);
		[DllImport("NaroOccCore.dll")]
		private static extern int AIS_Trihedron_ArrowColor(IntPtr instance);

		#region NativeInstancePtr Convert constructor

		public AISTrihedron() { } 

		public AISTrihedron(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ AISTrihedron_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void AISTrihedron_Dtor(IntPtr instance);
	}
}
