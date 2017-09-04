#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;
using NaroCppCore.Occ.gp;

#endregion

namespace NaroCppCore.Occ.gp
{
	public class gpTorus : NativeInstancePtr
	{
		public gpTorus()
 :
			base(gp_Torus_Ctor() )
		{}
		public gpTorus(gpAx3 A3,double MajorRadius,double MinorRadius)
 :
			base(gp_Torus_Ctor32BF0691(A3.Instance, MajorRadius, MinorRadius) )
		{}
			public void UReverse()
				{
					gp_Torus_UReverse(Instance);
				}
			public void VReverse()
				{
					gp_Torus_VReverse(Instance);
				}
			public void Mirror(gpPnt P)
				{
					gp_Torus_Mirror9EAECD5B(Instance, P.Instance);
				}
			public gpTorus Mirrored(gpPnt P)
				{
					return new gpTorus(gp_Torus_Mirrored9EAECD5B(Instance, P.Instance));
				}
			public void Mirror(gpAx1 A1)
				{
					gp_Torus_Mirror608B963B(Instance, A1.Instance);
				}
			public gpTorus Mirrored(gpAx1 A1)
				{
					return new gpTorus(gp_Torus_Mirrored608B963B(Instance, A1.Instance));
				}
			public void Mirror(gpAx2 A2)
				{
					gp_Torus_Mirror7895386A(Instance, A2.Instance);
				}
			public gpTorus Mirrored(gpAx2 A2)
				{
					return new gpTorus(gp_Torus_Mirrored7895386A(Instance, A2.Instance));
				}
			public void Rotate(gpAx1 A1,double Ang)
				{
					gp_Torus_Rotate827CB19A(Instance, A1.Instance, Ang);
				}
			public gpTorus Rotated(gpAx1 A1,double Ang)
				{
					return new gpTorus(gp_Torus_Rotated827CB19A(Instance, A1.Instance, Ang));
				}
			public void Scale(gpPnt P,double S)
				{
					gp_Torus_ScaleF0D1E3E6(Instance, P.Instance, S);
				}
			public gpTorus Scaled(gpPnt P,double S)
				{
					return new gpTorus(gp_Torus_ScaledF0D1E3E6(Instance, P.Instance, S));
				}
			public void Transform(gpTrsf T)
				{
					gp_Torus_Transform72D78650(Instance, T.Instance);
				}
			public gpTorus Transformed(gpTrsf T)
				{
					return new gpTorus(gp_Torus_Transformed72D78650(Instance, T.Instance));
				}
			public void Translate(gpVec V)
				{
					gp_Torus_Translate9BD9CFFE(Instance, V.Instance);
				}
			public gpTorus Translated(gpVec V)
				{
					return new gpTorus(gp_Torus_Translated9BD9CFFE(Instance, V.Instance));
				}
			public void Translate(gpPnt P1,gpPnt P2)
				{
					gp_Torus_Translate5C63477E(Instance, P1.Instance, P2.Instance);
				}
			public gpTorus Translated(gpPnt P1,gpPnt P2)
				{
					return new gpTorus(gp_Torus_Translated5C63477E(Instance, P1.Instance, P2.Instance));
				}
		public double Area{
			get {
				return gp_Torus_Area(Instance);
			}
		}
		public bool Direct{
			get {
				return gp_Torus_Direct(Instance);
			}
		}
		public gpAx1 Axis{
			set { 
				gp_Torus_SetAxis(Instance, value.Instance);
			}
			get {
				return new gpAx1(gp_Torus_Axis(Instance));
			}
		}
		public gpPnt Location{
			set { 
				gp_Torus_SetLocation(Instance, value.Instance);
			}
			get {
				return new gpPnt(gp_Torus_Location(Instance));
			}
		}
		public gpAx3 Position{
			set { 
				gp_Torus_SetPosition(Instance, value.Instance);
			}
			get {
				return new gpAx3(gp_Torus_Position(Instance));
			}
		}
		public double MajorRadius{
			set { 
				gp_Torus_SetMajorRadius(Instance, value);
			}
			get {
				return gp_Torus_MajorRadius(Instance);
			}
		}
		public double MinorRadius{
			set { 
				gp_Torus_SetMinorRadius(Instance, value);
			}
			get {
				return gp_Torus_MinorRadius(Instance);
			}
		}
		public double Volume{
			get {
				return gp_Torus_Volume(Instance);
			}
		}
		public gpAx1 XAxis{
			get {
				return new gpAx1(gp_Torus_XAxis(Instance));
			}
		}
		public gpAx1 YAxis{
			get {
				return new gpAx1(gp_Torus_YAxis(Instance));
			}
		}
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Torus_Ctor();
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Torus_Ctor32BF0691(IntPtr A3,double MajorRadius,double MinorRadius);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Torus_UReverse(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Torus_VReverse(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Torus_Mirror9EAECD5B(IntPtr instance, IntPtr P);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Torus_Mirrored9EAECD5B(IntPtr instance, IntPtr P);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Torus_Mirror608B963B(IntPtr instance, IntPtr A1);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Torus_Mirrored608B963B(IntPtr instance, IntPtr A1);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Torus_Mirror7895386A(IntPtr instance, IntPtr A2);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Torus_Mirrored7895386A(IntPtr instance, IntPtr A2);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Torus_Rotate827CB19A(IntPtr instance, IntPtr A1,double Ang);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Torus_Rotated827CB19A(IntPtr instance, IntPtr A1,double Ang);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Torus_ScaleF0D1E3E6(IntPtr instance, IntPtr P,double S);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Torus_ScaledF0D1E3E6(IntPtr instance, IntPtr P,double S);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Torus_Transform72D78650(IntPtr instance, IntPtr T);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Torus_Transformed72D78650(IntPtr instance, IntPtr T);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Torus_Translate9BD9CFFE(IntPtr instance, IntPtr V);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Torus_Translated9BD9CFFE(IntPtr instance, IntPtr V);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Torus_Translate5C63477E(IntPtr instance, IntPtr P1,IntPtr P2);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Torus_Translated5C63477E(IntPtr instance, IntPtr P1,IntPtr P2);
		[DllImport("NaroOccCore.dll")]
		private static extern double gp_Torus_Area(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool gp_Torus_Direct(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Torus_SetAxis(IntPtr instance, IntPtr value);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Torus_Axis(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Torus_SetLocation(IntPtr instance, IntPtr value);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Torus_Location(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Torus_SetPosition(IntPtr instance, IntPtr value);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Torus_Position(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Torus_SetMajorRadius(IntPtr instance, double value);
		[DllImport("NaroOccCore.dll")]
		private static extern double gp_Torus_MajorRadius(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Torus_SetMinorRadius(IntPtr instance, double value);
		[DllImport("NaroOccCore.dll")]
		private static extern double gp_Torus_MinorRadius(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern double gp_Torus_Volume(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Torus_XAxis(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Torus_YAxis(IntPtr instance);

		#region NativeInstancePtr Convert constructor

		public gpTorus(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ gpTorus_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void gpTorus_Dtor(IntPtr instance);
	}
}
