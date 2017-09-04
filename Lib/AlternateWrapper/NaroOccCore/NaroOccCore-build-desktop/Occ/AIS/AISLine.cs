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
	public class AISLine : AISInteractiveObject
	{
		public AISLine(GeomLine aLine)
 :
			base(AIS_Line_Ctor7C3C08A3(aLine.Instance) )
		{}
		public AISLine(GeomPoint aStartPoint,GeomPoint aEndPoint)
 :
			base(AIS_Line_Ctor2A4E6D38(aStartPoint.Instance, aEndPoint.Instance) )
		{}
			public void Points(GeomPoint PStart,GeomPoint PEnd)
				{
					AIS_Line_Points2A4E6D38(Instance, PStart.Instance, PEnd.Instance);
				}
			public void SetPoints(GeomPoint P1,GeomPoint P2)
				{
					AIS_Line_SetPoints2A4E6D38(Instance, P1.Instance, P2.Instance);
				}
			public void SetColor(QuantityNameOfColor aColor)
				{
					AIS_Line_SetColor48F4F471(Instance, (int)aColor);
				}
			public void SetColor(QuantityColor aColor)
				{
					AIS_Line_SetColor8FD7F48(Instance, aColor.Instance);
				}
			public void UnsetColor()
				{
					AIS_Line_UnsetColor(Instance);
				}
			public void UnsetWidth()
				{
					AIS_Line_UnsetWidth(Instance);
				}
		public int Signature{
			get {
				return AIS_Line_Signature(Instance);
			}
		}
		public AISKindOfInteractive Type{
			get {
				return (AISKindOfInteractive)AIS_Line_Type(Instance);
			}
		}
		public GeomLine Line{
			set { 
				AIS_Line_SetLine(Instance, value.Instance);
			}
			get {
				return new GeomLine(AIS_Line_Line(Instance));
			}
		}
		public double Width{
			set { 
				AIS_Line_SetWidth(Instance, value);
			}
		}
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr AIS_Line_Ctor7C3C08A3(IntPtr aLine);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr AIS_Line_Ctor2A4E6D38(IntPtr aStartPoint,IntPtr aEndPoint);
		[DllImport("NaroOccCore.dll")]
		private static extern void AIS_Line_Points2A4E6D38(IntPtr instance, IntPtr PStart,IntPtr PEnd);
		[DllImport("NaroOccCore.dll")]
		private static extern void AIS_Line_SetPoints2A4E6D38(IntPtr instance, IntPtr P1,IntPtr P2);
		[DllImport("NaroOccCore.dll")]
		private static extern void AIS_Line_SetColor48F4F471(IntPtr instance, int aColor);
		[DllImport("NaroOccCore.dll")]
		private static extern void AIS_Line_SetColor8FD7F48(IntPtr instance, IntPtr aColor);
		[DllImport("NaroOccCore.dll")]
		private static extern void AIS_Line_UnsetColor(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void AIS_Line_UnsetWidth(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern int AIS_Line_Signature(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern int AIS_Line_Type(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void AIS_Line_SetLine(IntPtr instance, IntPtr value);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr AIS_Line_Line(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void AIS_Line_SetWidth(IntPtr instance, double value);

		#region NativeInstancePtr Convert constructor

		public AISLine() { } 

		public AISLine(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ AISLine_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void AISLine_Dtor(IntPtr instance);
	}
}
