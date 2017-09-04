#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;
using NaroCppCore.Occ.AIS;
using NaroCppCore.Occ.Geom;
using NaroCppCore.Occ.Aspect;
using NaroCppCore.Occ.TopoDS;
using NaroCppCore.Occ.Quantity;

#endregion

namespace NaroCppCore.Occ.AIS
{
	public class AISPoint : AISInteractiveObject
	{
		public AISPoint(GeomPoint aComponent)
 :
			base(AIS_Point_Ctor121385BD(aComponent.Instance) )
		{}
			public bool AcceptDisplayMode(int aMode)
				{
					return AIS_Point_AcceptDisplayModeE8219145(Instance, aMode);
				}
			public void SetColor(QuantityNameOfColor aColor)
				{
					AIS_Point_SetColor48F4F471(Instance, (int)aColor);
				}
			public void SetColor(QuantityColor aColor)
				{
					AIS_Point_SetColor8FD7F48(Instance, aColor.Instance);
				}
			public void UnsetColor()
				{
					AIS_Point_UnsetColor(Instance);
				}
			public void UnsetMarker()
				{
					AIS_Point_UnsetMarker(Instance);
				}
		public int Signature{
			get {
				return AIS_Point_Signature(Instance);
			}
		}
		public AISKindOfInteractive Type{
			get {
				return (AISKindOfInteractive)AIS_Point_Type(Instance);
			}
		}
		public GeomPoint Component{
			set { 
				AIS_Point_SetComponent(Instance, value.Instance);
			}
			get {
				return new GeomPoint(AIS_Point_Component(Instance));
			}
		}
		public AspectTypeOfMarker Marker{
			set { 
				AIS_Point_SetMarker(Instance, (int)value);
			}
		}
		public bool HasMarker{
			get {
				return AIS_Point_HasMarker(Instance);
			}
		}
		public TopoDSVertex Vertex{
			get {
				return new TopoDSVertex(AIS_Point_Vertex(Instance));
			}
		}
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr AIS_Point_Ctor121385BD(IntPtr aComponent);
		[DllImport("NaroOccCore.dll")]
		private static extern bool AIS_Point_AcceptDisplayModeE8219145(IntPtr instance, int aMode);
		[DllImport("NaroOccCore.dll")]
		private static extern void AIS_Point_SetColor48F4F471(IntPtr instance, int aColor);
		[DllImport("NaroOccCore.dll")]
		private static extern void AIS_Point_SetColor8FD7F48(IntPtr instance, IntPtr aColor);
		[DllImport("NaroOccCore.dll")]
		private static extern void AIS_Point_UnsetColor(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void AIS_Point_UnsetMarker(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern int AIS_Point_Signature(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern int AIS_Point_Type(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void AIS_Point_SetComponent(IntPtr instance, IntPtr value);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr AIS_Point_Component(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void AIS_Point_SetMarker(IntPtr instance, int value);
		[DllImport("NaroOccCore.dll")]
		private static extern bool AIS_Point_HasMarker(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr AIS_Point_Vertex(IntPtr instance);

		#region NativeInstancePtr Convert constructor

		public AISPoint() { } 

		public AISPoint(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ AISPoint_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void AISPoint_Dtor(IntPtr instance);
	}
}
