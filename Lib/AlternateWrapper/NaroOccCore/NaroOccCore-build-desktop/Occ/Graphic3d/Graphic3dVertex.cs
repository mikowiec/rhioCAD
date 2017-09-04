#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;
using NaroCppCore.Occ.Graphic3d;

#endregion

namespace NaroCppCore.Occ.Graphic3d
{
	public class Graphic3dVertex : NativeInstancePtr
	{
		public Graphic3dVertex()
 :
			base(Graphic3d_Vertex_Ctor() )
		{}
		public Graphic3dVertex(Graphic3dVertex APoint)
 :
			base(Graphic3d_Vertex_CtorC6E2F35B(APoint.Instance) )
		{}
		public Graphic3dVertex(double AX,double AY,double AZ)
 :
			base(Graphic3d_Vertex_Ctor9282A951(AX, AY, AZ) )
		{}
			public void SetCoord(double Xnew,double Ynew,double Znew)
				{
					Graphic3d_Vertex_SetCoord9282A951(Instance, Xnew, Ynew, Znew);
				}
			public void Coord(ref double AX,ref double AY,ref double AZ)
				{
					Graphic3d_Vertex_Coord9282A951(Instance, ref AX, ref AY, ref AZ);
				}
			public static double Distance(Graphic3dVertex AV1,Graphic3dVertex AV2)
				{
					return Graphic3d_Vertex_Distance29D8F78D(AV1.Instance, AV2.Instance);
				}
		public double XCoord{
			set { 
				Graphic3d_Vertex_SetXCoord(Instance, value);
			}
		}
		public double YCoord{
			set { 
				Graphic3d_Vertex_SetYCoord(Instance, value);
			}
		}
		public double ZCoord{
			set { 
				Graphic3d_Vertex_SetZCoord(Instance, value);
			}
		}
		public double X{
			get {
				return Graphic3d_Vertex_X(Instance);
			}
		}
		public double Y{
			get {
				return Graphic3d_Vertex_Y(Instance);
			}
		}
		public double Z{
			get {
				return Graphic3d_Vertex_Z(Instance);
			}
		}
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Graphic3d_Vertex_Ctor();
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Graphic3d_Vertex_CtorC6E2F35B(IntPtr APoint);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Graphic3d_Vertex_Ctor9282A951(double AX,double AY,double AZ);
		[DllImport("NaroOccCore.dll")]
		private static extern void Graphic3d_Vertex_SetCoord9282A951(IntPtr instance, double Xnew,double Ynew,double Znew);
		[DllImport("NaroOccCore.dll")]
		private static extern void Graphic3d_Vertex_Coord9282A951(IntPtr instance, ref double AX,ref double AY,ref double AZ);
		[DllImport("NaroOccCore.dll")]
		private static extern double Graphic3d_Vertex_Distance29D8F78D(IntPtr AV1,IntPtr AV2);
		[DllImport("NaroOccCore.dll")]
		private static extern void Graphic3d_Vertex_SetXCoord(IntPtr instance, double value);
		[DllImport("NaroOccCore.dll")]
		private static extern void Graphic3d_Vertex_SetYCoord(IntPtr instance, double value);
		[DllImport("NaroOccCore.dll")]
		private static extern void Graphic3d_Vertex_SetZCoord(IntPtr instance, double value);
		[DllImport("NaroOccCore.dll")]
		private static extern double Graphic3d_Vertex_X(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern double Graphic3d_Vertex_Y(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern double Graphic3d_Vertex_Z(IntPtr instance);

		#region NativeInstancePtr Convert constructor

		public Graphic3dVertex(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ Graphic3dVertex_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void Graphic3dVertex_Dtor(IntPtr instance);
	}
}
