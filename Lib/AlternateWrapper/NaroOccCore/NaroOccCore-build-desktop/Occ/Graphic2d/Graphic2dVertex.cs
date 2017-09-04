#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;
using NaroCppCore.Occ.Graphic2d;

#endregion

namespace NaroCppCore.Occ.Graphic2d
{
	public class Graphic2dVertex : NativeInstancePtr
	{
		public Graphic2dVertex()
 :
			base(Graphic2d_Vertex_Ctor() )
		{}
		public Graphic2dVertex(double AX,double AY)
 :
			base(Graphic2d_Vertex_Ctor9F0E714F(AX, AY) )
		{}
			public void SetCoord(double Xnew,double Ynew)
				{
					Graphic2d_Vertex_SetCoord9F0E714F(Instance, Xnew, Ynew);
				}
			public void Coord(ref double AX,ref double AY)
				{
					Graphic2d_Vertex_Coord9F0E714F(Instance, ref AX, ref AY);
				}
			public bool IsEqual(Graphic2dVertex other)
				{
					return Graphic2d_Vertex_IsEqualC6E2F71C(Instance, other.Instance);
				}
			public static double Distance(Graphic2dVertex AV1,Graphic2dVertex AV2)
				{
					return Graphic2d_Vertex_Distance693D9ECB(AV1.Instance, AV2.Instance);
				}
		public double XCoord{
			set { 
				Graphic2d_Vertex_SetXCoord(Instance, value);
			}
		}
		public double YCoord{
			set { 
				Graphic2d_Vertex_SetYCoord(Instance, value);
			}
		}
		public double X{
			get {
				return Graphic2d_Vertex_X(Instance);
			}
		}
		public double Y{
			get {
				return Graphic2d_Vertex_Y(Instance);
			}
		}
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Graphic2d_Vertex_Ctor();
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Graphic2d_Vertex_Ctor9F0E714F(double AX,double AY);
		[DllImport("NaroOccCore.dll")]
		private static extern void Graphic2d_Vertex_SetCoord9F0E714F(IntPtr instance, double Xnew,double Ynew);
		[DllImport("NaroOccCore.dll")]
		private static extern void Graphic2d_Vertex_Coord9F0E714F(IntPtr instance, ref double AX,ref double AY);
		[DllImport("NaroOccCore.dll")]
		private static extern bool Graphic2d_Vertex_IsEqualC6E2F71C(IntPtr instance, IntPtr other);
		[DllImport("NaroOccCore.dll")]
		private static extern double Graphic2d_Vertex_Distance693D9ECB(IntPtr AV1,IntPtr AV2);
		[DllImport("NaroOccCore.dll")]
		private static extern void Graphic2d_Vertex_SetXCoord(IntPtr instance, double value);
		[DllImport("NaroOccCore.dll")]
		private static extern void Graphic2d_Vertex_SetYCoord(IntPtr instance, double value);
		[DllImport("NaroOccCore.dll")]
		private static extern double Graphic2d_Vertex_X(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern double Graphic2d_Vertex_Y(IntPtr instance);

		#region NativeInstancePtr Convert constructor

		public Graphic2dVertex(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ Graphic2dVertex_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void Graphic2dVertex_Dtor(IntPtr instance);
	}
}
