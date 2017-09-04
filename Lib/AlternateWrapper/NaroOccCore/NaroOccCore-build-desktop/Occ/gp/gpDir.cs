#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;
using NaroCppCore.Occ.gp;

#endregion

namespace NaroCppCore.Occ.gp
{
	public class gpDir : NativeInstancePtr
	{
		public gpDir()
 :
			base(gp_Dir_Ctor() )
		{}
		public gpDir(gpVec V)
 :
			base(gp_Dir_Ctor9BD9CFFE(V.Instance) )
		{}
		public gpDir(gpXYZ Coord)
 :
			base(gp_Dir_Ctor8EE42329(Coord.Instance) )
		{}
		public gpDir(double Xv,double Yv,double Zv)
 :
			base(gp_Dir_Ctor9282A951(Xv, Yv, Zv) )
		{}
			public void SetCoord(int Index,double Xi)
				{
					gp_Dir_SetCoord69F5FCCD(Instance, Index, Xi);
				}
			public void SetCoord(double Xv,double Yv,double Zv)
				{
					gp_Dir_SetCoord9282A951(Instance, Xv, Yv, Zv);
				}
			public double Coord(int Index)
				{
					return gp_Dir_CoordE8219145(Instance, Index);
				}
			public void Coord(ref double Xv,ref double Yv,ref double Zv)
				{
					gp_Dir_Coord9282A951(Instance, ref Xv, ref Yv, ref Zv);
				}
			public bool IsEqual(gpDir Other,double AngularTolerance)
				{
					return gp_Dir_IsEqual1924C304(Instance, Other.Instance, AngularTolerance);
				}
			public bool IsNormal(gpDir Other,double AngularTolerance)
				{
					return gp_Dir_IsNormal1924C304(Instance, Other.Instance, AngularTolerance);
				}
			public bool IsOpposite(gpDir Other,double AngularTolerance)
				{
					return gp_Dir_IsOpposite1924C304(Instance, Other.Instance, AngularTolerance);
				}
			public bool IsParallel(gpDir Other,double AngularTolerance)
				{
					return gp_Dir_IsParallel1924C304(Instance, Other.Instance, AngularTolerance);
				}
			public double Angle(gpDir Other)
				{
					return gp_Dir_AngleCEC711A5(Instance, Other.Instance);
				}
			public double AngleWithRef(gpDir Other,gpDir VRef)
				{
					return gp_Dir_AngleWithRef8BEC0F26(Instance, Other.Instance, VRef.Instance);
				}
			public void Cross(gpDir Right)
				{
					gp_Dir_CrossCEC711A5(Instance, Right.Instance);
				}
			public gpDir Crossed(gpDir Right)
				{
					return new gpDir(gp_Dir_CrossedCEC711A5(Instance, Right.Instance));
				}
			public void CrossCross(gpDir V1,gpDir V2)
				{
					gp_Dir_CrossCross8BEC0F26(Instance, V1.Instance, V2.Instance);
				}
			public gpDir CrossCrossed(gpDir V1,gpDir V2)
				{
					return new gpDir(gp_Dir_CrossCrossed8BEC0F26(Instance, V1.Instance, V2.Instance));
				}
			public double Dot(gpDir Other)
				{
					return gp_Dir_DotCEC711A5(Instance, Other.Instance);
				}
			public double DotCross(gpDir V1,gpDir V2)
				{
					return gp_Dir_DotCross8BEC0F26(Instance, V1.Instance, V2.Instance);
				}
			public void Reverse()
				{
					gp_Dir_Reverse(Instance);
				}
			public void Mirror(gpDir V)
				{
					gp_Dir_MirrorCEC711A5(Instance, V.Instance);
				}
			public gpDir Mirrored(gpDir V)
				{
					return new gpDir(gp_Dir_MirroredCEC711A5(Instance, V.Instance));
				}
			public void Mirror(gpAx1 A1)
				{
					gp_Dir_Mirror608B963B(Instance, A1.Instance);
				}
			public gpDir Mirrored(gpAx1 A1)
				{
					return new gpDir(gp_Dir_Mirrored608B963B(Instance, A1.Instance));
				}
			public void Mirror(gpAx2 A2)
				{
					gp_Dir_Mirror7895386A(Instance, A2.Instance);
				}
			public gpDir Mirrored(gpAx2 A2)
				{
					return new gpDir(gp_Dir_Mirrored7895386A(Instance, A2.Instance));
				}
			public void Rotate(gpAx1 A1,double Ang)
				{
					gp_Dir_Rotate827CB19A(Instance, A1.Instance, Ang);
				}
			public gpDir Rotated(gpAx1 A1,double Ang)
				{
					return new gpDir(gp_Dir_Rotated827CB19A(Instance, A1.Instance, Ang));
				}
			public void Transform(gpTrsf T)
				{
					gp_Dir_Transform72D78650(Instance, T.Instance);
				}
			public gpDir Transformed(gpTrsf T)
				{
					return new gpDir(gp_Dir_Transformed72D78650(Instance, T.Instance));
				}
		public double X{
			set { 
				gp_Dir_SetX(Instance, value);
			}
			get {
				return gp_Dir_X(Instance);
			}
		}
		public double Y{
			set { 
				gp_Dir_SetY(Instance, value);
			}
			get {
				return gp_Dir_Y(Instance);
			}
		}
		public double Z{
			set { 
				gp_Dir_SetZ(Instance, value);
			}
			get {
				return gp_Dir_Z(Instance);
			}
		}
		public gpXYZ XYZ{
			set { 
				gp_Dir_SetXYZ(Instance, value.Instance);
			}
			get {
				return new gpXYZ(gp_Dir_XYZ(Instance));
			}
		}
		public gpDir Reversed{
			get {
				return new gpDir(gp_Dir_Reversed(Instance));
			}
		}
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Dir_Ctor();
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Dir_Ctor9BD9CFFE(IntPtr V);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Dir_Ctor8EE42329(IntPtr Coord);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Dir_Ctor9282A951(double Xv,double Yv,double Zv);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Dir_SetCoord69F5FCCD(IntPtr instance, int Index,double Xi);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Dir_SetCoord9282A951(IntPtr instance, double Xv,double Yv,double Zv);
		[DllImport("NaroOccCore.dll")]
		private static extern double gp_Dir_CoordE8219145(IntPtr instance, int Index);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Dir_Coord9282A951(IntPtr instance, ref double Xv,ref double Yv,ref double Zv);
		[DllImport("NaroOccCore.dll")]
		private static extern bool gp_Dir_IsEqual1924C304(IntPtr instance, IntPtr Other,double AngularTolerance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool gp_Dir_IsNormal1924C304(IntPtr instance, IntPtr Other,double AngularTolerance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool gp_Dir_IsOpposite1924C304(IntPtr instance, IntPtr Other,double AngularTolerance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool gp_Dir_IsParallel1924C304(IntPtr instance, IntPtr Other,double AngularTolerance);
		[DllImport("NaroOccCore.dll")]
		private static extern double gp_Dir_AngleCEC711A5(IntPtr instance, IntPtr Other);
		[DllImport("NaroOccCore.dll")]
		private static extern double gp_Dir_AngleWithRef8BEC0F26(IntPtr instance, IntPtr Other,IntPtr VRef);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Dir_CrossCEC711A5(IntPtr instance, IntPtr Right);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Dir_CrossedCEC711A5(IntPtr instance, IntPtr Right);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Dir_CrossCross8BEC0F26(IntPtr instance, IntPtr V1,IntPtr V2);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Dir_CrossCrossed8BEC0F26(IntPtr instance, IntPtr V1,IntPtr V2);
		[DllImport("NaroOccCore.dll")]
		private static extern double gp_Dir_DotCEC711A5(IntPtr instance, IntPtr Other);
		[DllImport("NaroOccCore.dll")]
		private static extern double gp_Dir_DotCross8BEC0F26(IntPtr instance, IntPtr V1,IntPtr V2);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Dir_Reverse(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Dir_MirrorCEC711A5(IntPtr instance, IntPtr V);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Dir_MirroredCEC711A5(IntPtr instance, IntPtr V);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Dir_Mirror608B963B(IntPtr instance, IntPtr A1);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Dir_Mirrored608B963B(IntPtr instance, IntPtr A1);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Dir_Mirror7895386A(IntPtr instance, IntPtr A2);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Dir_Mirrored7895386A(IntPtr instance, IntPtr A2);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Dir_Rotate827CB19A(IntPtr instance, IntPtr A1,double Ang);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Dir_Rotated827CB19A(IntPtr instance, IntPtr A1,double Ang);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Dir_Transform72D78650(IntPtr instance, IntPtr T);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Dir_Transformed72D78650(IntPtr instance, IntPtr T);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Dir_SetX(IntPtr instance, double value);
		[DllImport("NaroOccCore.dll")]
		private static extern double gp_Dir_X(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Dir_SetY(IntPtr instance, double value);
		[DllImport("NaroOccCore.dll")]
		private static extern double gp_Dir_Y(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Dir_SetZ(IntPtr instance, double value);
		[DllImport("NaroOccCore.dll")]
		private static extern double gp_Dir_Z(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Dir_SetXYZ(IntPtr instance, IntPtr value);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Dir_XYZ(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Dir_Reversed(IntPtr instance);

		#region NativeInstancePtr Convert constructor

		public gpDir(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ gpDir_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void gpDir_Dtor(IntPtr instance);
	}
}
