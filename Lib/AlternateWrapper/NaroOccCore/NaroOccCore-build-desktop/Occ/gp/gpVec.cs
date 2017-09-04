#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;
using NaroCppCore.Occ.gp;

#endregion

namespace NaroCppCore.Occ.gp
{
	public class gpVec : NativeInstancePtr
	{
		public gpVec()
 :
			base(gp_Vec_Ctor() )
		{}
		public gpVec(gpDir V)
 :
			base(gp_Vec_CtorCEC711A5(V.Instance) )
		{}
		public gpVec(gpXYZ Coord)
 :
			base(gp_Vec_Ctor8EE42329(Coord.Instance) )
		{}
		public gpVec(double Xv,double Yv,double Zv)
 :
			base(gp_Vec_Ctor9282A951(Xv, Yv, Zv) )
		{}
		public gpVec(gpPnt P1,gpPnt P2)
 :
			base(gp_Vec_Ctor5C63477E(P1.Instance, P2.Instance) )
		{}
			public void SetCoord(int Index,double Xi)
				{
					gp_Vec_SetCoord69F5FCCD(Instance, Index, Xi);
				}
			public void SetCoord(double Xv,double Yv,double Zv)
				{
					gp_Vec_SetCoord9282A951(Instance, Xv, Yv, Zv);
				}
			public double Coord(int Index)
				{
					return gp_Vec_CoordE8219145(Instance, Index);
				}
			public void Coord(ref double Xv,ref double Yv,ref double Zv)
				{
					gp_Vec_Coord9282A951(Instance, ref Xv, ref Yv, ref Zv);
				}
			public bool IsEqual(gpVec Other,double LinearTolerance,double AngularTolerance)
				{
					return gp_Vec_IsEqualB72DB00(Instance, Other.Instance, LinearTolerance, AngularTolerance);
				}
			public bool IsNormal(gpVec Other,double AngularTolerance)
				{
					return gp_Vec_IsNormal45D40C1(Instance, Other.Instance, AngularTolerance);
				}
			public bool IsOpposite(gpVec Other,double AngularTolerance)
				{
					return gp_Vec_IsOpposite45D40C1(Instance, Other.Instance, AngularTolerance);
				}
			public bool IsParallel(gpVec Other,double AngularTolerance)
				{
					return gp_Vec_IsParallel45D40C1(Instance, Other.Instance, AngularTolerance);
				}
			public double Angle(gpVec Other)
				{
					return gp_Vec_Angle9BD9CFFE(Instance, Other.Instance);
				}
			public double AngleWithRef(gpVec Other,gpVec VRef)
				{
					return gp_Vec_AngleWithRefD5A0F1EC(Instance, Other.Instance, VRef.Instance);
				}
			public void Add(gpVec Other)
				{
					gp_Vec_Add9BD9CFFE(Instance, Other.Instance);
				}
			public gpVec Added(gpVec Other)
				{
					return new gpVec(gp_Vec_Added9BD9CFFE(Instance, Other.Instance));
				}
			public void Subtract(gpVec Right)
				{
					gp_Vec_Subtract9BD9CFFE(Instance, Right.Instance);
				}
			public gpVec Subtracted(gpVec Right)
				{
					return new gpVec(gp_Vec_Subtracted9BD9CFFE(Instance, Right.Instance));
				}
			public void Multiply(double Scalar)
				{
					gp_Vec_MultiplyD82819F3(Instance, Scalar);
				}
			public gpVec Multiplied(double Scalar)
				{
					return new gpVec(gp_Vec_MultipliedD82819F3(Instance, Scalar));
				}
			public void Divide(double Scalar)
				{
					gp_Vec_DivideD82819F3(Instance, Scalar);
				}
			public gpVec Divided(double Scalar)
				{
					return new gpVec(gp_Vec_DividedD82819F3(Instance, Scalar));
				}
			public void Cross(gpVec Right)
				{
					gp_Vec_Cross9BD9CFFE(Instance, Right.Instance);
				}
			public gpVec Crossed(gpVec Right)
				{
					return new gpVec(gp_Vec_Crossed9BD9CFFE(Instance, Right.Instance));
				}
			public double CrossMagnitude(gpVec Right)
				{
					return gp_Vec_CrossMagnitude9BD9CFFE(Instance, Right.Instance);
				}
			public double CrossSquareMagnitude(gpVec Right)
				{
					return gp_Vec_CrossSquareMagnitude9BD9CFFE(Instance, Right.Instance);
				}
			public void CrossCross(gpVec V1,gpVec V2)
				{
					gp_Vec_CrossCrossD5A0F1EC(Instance, V1.Instance, V2.Instance);
				}
			public gpVec CrossCrossed(gpVec V1,gpVec V2)
				{
					return new gpVec(gp_Vec_CrossCrossedD5A0F1EC(Instance, V1.Instance, V2.Instance));
				}
			public double Dot(gpVec Other)
				{
					return gp_Vec_Dot9BD9CFFE(Instance, Other.Instance);
				}
			public double DotCross(gpVec V1,gpVec V2)
				{
					return gp_Vec_DotCrossD5A0F1EC(Instance, V1.Instance, V2.Instance);
				}
			public void Normalize()
				{
					gp_Vec_Normalize(Instance);
				}
			public void Reverse()
				{
					gp_Vec_Reverse(Instance);
				}
			public void SetLinearForm(double A1,gpVec V1,double A2,gpVec V2,double A3,gpVec V3,gpVec V4)
				{
					gp_Vec_SetLinearFormC27F2330(Instance, A1, V1.Instance, A2, V2.Instance, A3, V3.Instance, V4.Instance);
				}
			public void SetLinearForm(double A1,gpVec V1,double A2,gpVec V2,double A3,gpVec V3)
				{
					gp_Vec_SetLinearForm9A51AB42(Instance, A1, V1.Instance, A2, V2.Instance, A3, V3.Instance);
				}
			public void SetLinearForm(double A1,gpVec V1,double A2,gpVec V2,gpVec V3)
				{
					gp_Vec_SetLinearForm5C2CAE24(Instance, A1, V1.Instance, A2, V2.Instance, V3.Instance);
				}
			public void SetLinearForm(double A1,gpVec V1,double A2,gpVec V2)
				{
					gp_Vec_SetLinearFormF12FD193(Instance, A1, V1.Instance, A2, V2.Instance);
				}
			public void SetLinearForm(double A1,gpVec V1,gpVec V2)
				{
					gp_Vec_SetLinearForm8045255A(Instance, A1, V1.Instance, V2.Instance);
				}
			public void SetLinearForm(gpVec V1,gpVec V2)
				{
					gp_Vec_SetLinearFormD5A0F1EC(Instance, V1.Instance, V2.Instance);
				}
			public void Mirror(gpVec V)
				{
					gp_Vec_Mirror9BD9CFFE(Instance, V.Instance);
				}
			public gpVec Mirrored(gpVec V)
				{
					return new gpVec(gp_Vec_Mirrored9BD9CFFE(Instance, V.Instance));
				}
			public void Mirror(gpAx1 A1)
				{
					gp_Vec_Mirror608B963B(Instance, A1.Instance);
				}
			public gpVec Mirrored(gpAx1 A1)
				{
					return new gpVec(gp_Vec_Mirrored608B963B(Instance, A1.Instance));
				}
			public void Mirror(gpAx2 A2)
				{
					gp_Vec_Mirror7895386A(Instance, A2.Instance);
				}
			public gpVec Mirrored(gpAx2 A2)
				{
					return new gpVec(gp_Vec_Mirrored7895386A(Instance, A2.Instance));
				}
			public void Rotate(gpAx1 A1,double Ang)
				{
					gp_Vec_Rotate827CB19A(Instance, A1.Instance, Ang);
				}
			public gpVec Rotated(gpAx1 A1,double Ang)
				{
					return new gpVec(gp_Vec_Rotated827CB19A(Instance, A1.Instance, Ang));
				}
			public void Scale(double S)
				{
					gp_Vec_ScaleD82819F3(Instance, S);
				}
			public gpVec Scaled(double S)
				{
					return new gpVec(gp_Vec_ScaledD82819F3(Instance, S));
				}
			public void Transform(gpTrsf T)
				{
					gp_Vec_Transform72D78650(Instance, T.Instance);
				}
			public gpVec Transformed(gpTrsf T)
				{
					return new gpVec(gp_Vec_Transformed72D78650(Instance, T.Instance));
				}
		public double X{
			set { 
				gp_Vec_SetX(Instance, value);
			}
			get {
				return gp_Vec_X(Instance);
			}
		}
		public double Y{
			set { 
				gp_Vec_SetY(Instance, value);
			}
			get {
				return gp_Vec_Y(Instance);
			}
		}
		public double Z{
			set { 
				gp_Vec_SetZ(Instance, value);
			}
			get {
				return gp_Vec_Z(Instance);
			}
		}
		public gpXYZ XYZ{
			set { 
				gp_Vec_SetXYZ(Instance, value.Instance);
			}
			get {
				return new gpXYZ(gp_Vec_XYZ(Instance));
			}
		}
		public double Magnitude{
			get {
				return gp_Vec_Magnitude(Instance);
			}
		}
		public double SquareMagnitude{
			get {
				return gp_Vec_SquareMagnitude(Instance);
			}
		}
		public gpVec Normalized{
			get {
				return new gpVec(gp_Vec_Normalized(Instance));
			}
		}
		public gpVec Reversed{
			get {
				return new gpVec(gp_Vec_Reversed(Instance));
			}
		}
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Vec_Ctor();
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Vec_CtorCEC711A5(IntPtr V);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Vec_Ctor8EE42329(IntPtr Coord);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Vec_Ctor9282A951(double Xv,double Yv,double Zv);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Vec_Ctor5C63477E(IntPtr P1,IntPtr P2);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Vec_SetCoord69F5FCCD(IntPtr instance, int Index,double Xi);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Vec_SetCoord9282A951(IntPtr instance, double Xv,double Yv,double Zv);
		[DllImport("NaroOccCore.dll")]
		private static extern double gp_Vec_CoordE8219145(IntPtr instance, int Index);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Vec_Coord9282A951(IntPtr instance, ref double Xv,ref double Yv,ref double Zv);
		[DllImport("NaroOccCore.dll")]
		private static extern bool gp_Vec_IsEqualB72DB00(IntPtr instance, IntPtr Other,double LinearTolerance,double AngularTolerance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool gp_Vec_IsNormal45D40C1(IntPtr instance, IntPtr Other,double AngularTolerance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool gp_Vec_IsOpposite45D40C1(IntPtr instance, IntPtr Other,double AngularTolerance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool gp_Vec_IsParallel45D40C1(IntPtr instance, IntPtr Other,double AngularTolerance);
		[DllImport("NaroOccCore.dll")]
		private static extern double gp_Vec_Angle9BD9CFFE(IntPtr instance, IntPtr Other);
		[DllImport("NaroOccCore.dll")]
		private static extern double gp_Vec_AngleWithRefD5A0F1EC(IntPtr instance, IntPtr Other,IntPtr VRef);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Vec_Add9BD9CFFE(IntPtr instance, IntPtr Other);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Vec_Added9BD9CFFE(IntPtr instance, IntPtr Other);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Vec_Subtract9BD9CFFE(IntPtr instance, IntPtr Right);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Vec_Subtracted9BD9CFFE(IntPtr instance, IntPtr Right);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Vec_MultiplyD82819F3(IntPtr instance, double Scalar);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Vec_MultipliedD82819F3(IntPtr instance, double Scalar);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Vec_DivideD82819F3(IntPtr instance, double Scalar);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Vec_DividedD82819F3(IntPtr instance, double Scalar);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Vec_Cross9BD9CFFE(IntPtr instance, IntPtr Right);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Vec_Crossed9BD9CFFE(IntPtr instance, IntPtr Right);
		[DllImport("NaroOccCore.dll")]
		private static extern double gp_Vec_CrossMagnitude9BD9CFFE(IntPtr instance, IntPtr Right);
		[DllImport("NaroOccCore.dll")]
		private static extern double gp_Vec_CrossSquareMagnitude9BD9CFFE(IntPtr instance, IntPtr Right);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Vec_CrossCrossD5A0F1EC(IntPtr instance, IntPtr V1,IntPtr V2);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Vec_CrossCrossedD5A0F1EC(IntPtr instance, IntPtr V1,IntPtr V2);
		[DllImport("NaroOccCore.dll")]
		private static extern double gp_Vec_Dot9BD9CFFE(IntPtr instance, IntPtr Other);
		[DllImport("NaroOccCore.dll")]
		private static extern double gp_Vec_DotCrossD5A0F1EC(IntPtr instance, IntPtr V1,IntPtr V2);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Vec_Normalize(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Vec_Reverse(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Vec_SetLinearFormC27F2330(IntPtr instance, double A1,IntPtr V1,double A2,IntPtr V2,double A3,IntPtr V3,IntPtr V4);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Vec_SetLinearForm9A51AB42(IntPtr instance, double A1,IntPtr V1,double A2,IntPtr V2,double A3,IntPtr V3);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Vec_SetLinearForm5C2CAE24(IntPtr instance, double A1,IntPtr V1,double A2,IntPtr V2,IntPtr V3);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Vec_SetLinearFormF12FD193(IntPtr instance, double A1,IntPtr V1,double A2,IntPtr V2);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Vec_SetLinearForm8045255A(IntPtr instance, double A1,IntPtr V1,IntPtr V2);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Vec_SetLinearFormD5A0F1EC(IntPtr instance, IntPtr V1,IntPtr V2);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Vec_Mirror9BD9CFFE(IntPtr instance, IntPtr V);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Vec_Mirrored9BD9CFFE(IntPtr instance, IntPtr V);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Vec_Mirror608B963B(IntPtr instance, IntPtr A1);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Vec_Mirrored608B963B(IntPtr instance, IntPtr A1);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Vec_Mirror7895386A(IntPtr instance, IntPtr A2);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Vec_Mirrored7895386A(IntPtr instance, IntPtr A2);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Vec_Rotate827CB19A(IntPtr instance, IntPtr A1,double Ang);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Vec_Rotated827CB19A(IntPtr instance, IntPtr A1,double Ang);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Vec_ScaleD82819F3(IntPtr instance, double S);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Vec_ScaledD82819F3(IntPtr instance, double S);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Vec_Transform72D78650(IntPtr instance, IntPtr T);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Vec_Transformed72D78650(IntPtr instance, IntPtr T);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Vec_SetX(IntPtr instance, double value);
		[DllImport("NaroOccCore.dll")]
		private static extern double gp_Vec_X(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Vec_SetY(IntPtr instance, double value);
		[DllImport("NaroOccCore.dll")]
		private static extern double gp_Vec_Y(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Vec_SetZ(IntPtr instance, double value);
		[DllImport("NaroOccCore.dll")]
		private static extern double gp_Vec_Z(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Vec_SetXYZ(IntPtr instance, IntPtr value);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Vec_XYZ(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern double gp_Vec_Magnitude(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern double gp_Vec_SquareMagnitude(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Vec_Normalized(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Vec_Reversed(IntPtr instance);

		#region NativeInstancePtr Convert constructor

		public gpVec(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ gpVec_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void gpVec_Dtor(IntPtr instance);
	}
}
