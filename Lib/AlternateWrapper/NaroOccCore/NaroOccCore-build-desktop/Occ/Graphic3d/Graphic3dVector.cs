#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;
using NaroCppCore.Occ.Graphic3d;

#endregion

namespace NaroCppCore.Occ.Graphic3d
{
	public class Graphic3dVector : NativeInstancePtr
	{
		public Graphic3dVector()
 :
			base(Graphic3d_Vector_Ctor() )
		{}
		public Graphic3dVector(double AX,double AY,double AZ)
 :
			base(Graphic3d_Vector_Ctor9282A951(AX, AY, AZ) )
		{}
		public Graphic3dVector(Graphic3dVertex APoint1,Graphic3dVertex APoint2)
 :
			base(Graphic3d_Vector_Ctor29D8F78D(APoint1.Instance, APoint2.Instance) )
		{}
			public void Normalize()
				{
					Graphic3d_Vector_Normalize(Instance);
				}
			public void SetCoord(double Xnew,double Ynew,double Znew)
				{
					Graphic3d_Vector_SetCoord9282A951(Instance, Xnew, Ynew, Znew);
				}
			public void Coord(ref double AX,ref double AY,ref double AZ)
				{
					Graphic3d_Vector_Coord9282A951(Instance, ref AX, ref AY, ref AZ);
				}
			public static bool IsParallel(Graphic3dVector AV1,Graphic3dVector AV2)
				{
					return Graphic3d_Vector_IsParallelE005972F(AV1.Instance, AV2.Instance);
				}
			public static double NormeOf(double AX,double AY,double AZ)
				{
					return Graphic3d_Vector_NormeOf9282A951(AX, AY, AZ);
				}
			public static double NormeOf(Graphic3dVector AVector)
				{
					return Graphic3d_Vector_NormeOf8053F351(AVector.Instance);
				}
		public double XCoord{
			set { 
				Graphic3d_Vector_SetXCoord(Instance, value);
			}
		}
		public double YCoord{
			set { 
				Graphic3d_Vector_SetYCoord(Instance, value);
			}
		}
		public double ZCoord{
			set { 
				Graphic3d_Vector_SetZCoord(Instance, value);
			}
		}
		public bool IsNormalized{
			get {
				return Graphic3d_Vector_IsNormalized(Instance);
			}
		}
		public bool LengthZero{
			get {
				return Graphic3d_Vector_LengthZero(Instance);
			}
		}
		public double X{
			get {
				return Graphic3d_Vector_X(Instance);
			}
		}
		public double Y{
			get {
				return Graphic3d_Vector_Y(Instance);
			}
		}
		public double Z{
			get {
				return Graphic3d_Vector_Z(Instance);
			}
		}
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Graphic3d_Vector_Ctor();
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Graphic3d_Vector_Ctor9282A951(double AX,double AY,double AZ);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Graphic3d_Vector_Ctor29D8F78D(IntPtr APoint1,IntPtr APoint2);
		[DllImport("NaroOccCore.dll")]
		private static extern void Graphic3d_Vector_Normalize(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void Graphic3d_Vector_SetCoord9282A951(IntPtr instance, double Xnew,double Ynew,double Znew);
		[DllImport("NaroOccCore.dll")]
		private static extern void Graphic3d_Vector_Coord9282A951(IntPtr instance, ref double AX,ref double AY,ref double AZ);
		[DllImport("NaroOccCore.dll")]
		private static extern bool Graphic3d_Vector_IsParallelE005972F(IntPtr AV1,IntPtr AV2);
		[DllImport("NaroOccCore.dll")]
		private static extern double Graphic3d_Vector_NormeOf9282A951(double AX,double AY,double AZ);
		[DllImport("NaroOccCore.dll")]
		private static extern double Graphic3d_Vector_NormeOf8053F351(IntPtr AVector);
		[DllImport("NaroOccCore.dll")]
		private static extern void Graphic3d_Vector_SetXCoord(IntPtr instance, double value);
		[DllImport("NaroOccCore.dll")]
		private static extern void Graphic3d_Vector_SetYCoord(IntPtr instance, double value);
		[DllImport("NaroOccCore.dll")]
		private static extern void Graphic3d_Vector_SetZCoord(IntPtr instance, double value);
		[DllImport("NaroOccCore.dll")]
		private static extern bool Graphic3d_Vector_IsNormalized(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool Graphic3d_Vector_LengthZero(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern double Graphic3d_Vector_X(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern double Graphic3d_Vector_Y(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern double Graphic3d_Vector_Z(IntPtr instance);

		#region NativeInstancePtr Convert constructor

		public Graphic3dVector(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ Graphic3dVector_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void Graphic3dVector_Dtor(IntPtr instance);
	}
}
