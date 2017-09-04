#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;
using NaroCppCore.Occ.gp;

#endregion

namespace NaroCppCore.Occ.gp
{
	public class gpHypr : NativeInstancePtr
	{
		public gpHypr()
 :
			base(gp_Hypr_Ctor() )
		{}
		public gpHypr(gpAx2 A2,double MajorRadius,double MinorRadius)
 :
			base(gp_Hypr_CtorB1A3BD2A(A2.Instance, MajorRadius, MinorRadius) )
		{}
			public void Mirror(gpPnt P)
				{
					gp_Hypr_Mirror9EAECD5B(Instance, P.Instance);
				}
			public gpHypr Mirrored(gpPnt P)
				{
					return new gpHypr(gp_Hypr_Mirrored9EAECD5B(Instance, P.Instance));
				}
			public void Mirror(gpAx1 A1)
				{
					gp_Hypr_Mirror608B963B(Instance, A1.Instance);
				}
			public gpHypr Mirrored(gpAx1 A1)
				{
					return new gpHypr(gp_Hypr_Mirrored608B963B(Instance, A1.Instance));
				}
			public void Mirror(gpAx2 A2)
				{
					gp_Hypr_Mirror7895386A(Instance, A2.Instance);
				}
			public gpHypr Mirrored(gpAx2 A2)
				{
					return new gpHypr(gp_Hypr_Mirrored7895386A(Instance, A2.Instance));
				}
			public void Rotate(gpAx1 A1,double Ang)
				{
					gp_Hypr_Rotate827CB19A(Instance, A1.Instance, Ang);
				}
			public gpHypr Rotated(gpAx1 A1,double Ang)
				{
					return new gpHypr(gp_Hypr_Rotated827CB19A(Instance, A1.Instance, Ang));
				}
			public void Scale(gpPnt P,double S)
				{
					gp_Hypr_ScaleF0D1E3E6(Instance, P.Instance, S);
				}
			public gpHypr Scaled(gpPnt P,double S)
				{
					return new gpHypr(gp_Hypr_ScaledF0D1E3E6(Instance, P.Instance, S));
				}
			public void Transform(gpTrsf T)
				{
					gp_Hypr_Transform72D78650(Instance, T.Instance);
				}
			public gpHypr Transformed(gpTrsf T)
				{
					return new gpHypr(gp_Hypr_Transformed72D78650(Instance, T.Instance));
				}
			public void Translate(gpVec V)
				{
					gp_Hypr_Translate9BD9CFFE(Instance, V.Instance);
				}
			public gpHypr Translated(gpVec V)
				{
					return new gpHypr(gp_Hypr_Translated9BD9CFFE(Instance, V.Instance));
				}
			public void Translate(gpPnt P1,gpPnt P2)
				{
					gp_Hypr_Translate5C63477E(Instance, P1.Instance, P2.Instance);
				}
			public gpHypr Translated(gpPnt P1,gpPnt P2)
				{
					return new gpHypr(gp_Hypr_Translated5C63477E(Instance, P1.Instance, P2.Instance));
				}
		public gpAx1 Asymptote1{
			get {
				return new gpAx1(gp_Hypr_Asymptote1(Instance));
			}
		}
		public gpAx1 Asymptote2{
			get {
				return new gpAx1(gp_Hypr_Asymptote2(Instance));
			}
		}
		public gpAx1 Axis{
			set { 
				gp_Hypr_SetAxis(Instance, value.Instance);
			}
			get {
				return new gpAx1(gp_Hypr_Axis(Instance));
			}
		}
		public gpHypr ConjugateBranch1{
			get {
				return new gpHypr(gp_Hypr_ConjugateBranch1(Instance));
			}
		}
		public gpHypr ConjugateBranch2{
			get {
				return new gpHypr(gp_Hypr_ConjugateBranch2(Instance));
			}
		}
		public gpAx1 Directrix1{
			get {
				return new gpAx1(gp_Hypr_Directrix1(Instance));
			}
		}
		public gpAx1 Directrix2{
			get {
				return new gpAx1(gp_Hypr_Directrix2(Instance));
			}
		}
		public double Eccentricity{
			get {
				return gp_Hypr_Eccentricity(Instance);
			}
		}
		public double Focal{
			get {
				return gp_Hypr_Focal(Instance);
			}
		}
		public gpPnt Focus1{
			get {
				return new gpPnt(gp_Hypr_Focus1(Instance));
			}
		}
		public gpPnt Focus2{
			get {
				return new gpPnt(gp_Hypr_Focus2(Instance));
			}
		}
		public gpPnt Location{
			set { 
				gp_Hypr_SetLocation(Instance, value.Instance);
			}
			get {
				return new gpPnt(gp_Hypr_Location(Instance));
			}
		}
		public double MajorRadius{
			set { 
				gp_Hypr_SetMajorRadius(Instance, value);
			}
			get {
				return gp_Hypr_MajorRadius(Instance);
			}
		}
		public double MinorRadius{
			set { 
				gp_Hypr_SetMinorRadius(Instance, value);
			}
			get {
				return gp_Hypr_MinorRadius(Instance);
			}
		}
		public gpHypr OtherBranch{
			get {
				return new gpHypr(gp_Hypr_OtherBranch(Instance));
			}
		}
		public double Parameter{
			get {
				return gp_Hypr_Parameter(Instance);
			}
		}
		public gpAx2 Position{
			set { 
				gp_Hypr_SetPosition(Instance, value.Instance);
			}
			get {
				return new gpAx2(gp_Hypr_Position(Instance));
			}
		}
		public gpAx1 XAxis{
			get {
				return new gpAx1(gp_Hypr_XAxis(Instance));
			}
		}
		public gpAx1 YAxis{
			get {
				return new gpAx1(gp_Hypr_YAxis(Instance));
			}
		}
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Hypr_Ctor();
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Hypr_CtorB1A3BD2A(IntPtr A2,double MajorRadius,double MinorRadius);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Hypr_Mirror9EAECD5B(IntPtr instance, IntPtr P);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Hypr_Mirrored9EAECD5B(IntPtr instance, IntPtr P);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Hypr_Mirror608B963B(IntPtr instance, IntPtr A1);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Hypr_Mirrored608B963B(IntPtr instance, IntPtr A1);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Hypr_Mirror7895386A(IntPtr instance, IntPtr A2);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Hypr_Mirrored7895386A(IntPtr instance, IntPtr A2);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Hypr_Rotate827CB19A(IntPtr instance, IntPtr A1,double Ang);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Hypr_Rotated827CB19A(IntPtr instance, IntPtr A1,double Ang);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Hypr_ScaleF0D1E3E6(IntPtr instance, IntPtr P,double S);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Hypr_ScaledF0D1E3E6(IntPtr instance, IntPtr P,double S);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Hypr_Transform72D78650(IntPtr instance, IntPtr T);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Hypr_Transformed72D78650(IntPtr instance, IntPtr T);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Hypr_Translate9BD9CFFE(IntPtr instance, IntPtr V);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Hypr_Translated9BD9CFFE(IntPtr instance, IntPtr V);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Hypr_Translate5C63477E(IntPtr instance, IntPtr P1,IntPtr P2);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Hypr_Translated5C63477E(IntPtr instance, IntPtr P1,IntPtr P2);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Hypr_Asymptote1(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Hypr_Asymptote2(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Hypr_SetAxis(IntPtr instance, IntPtr value);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Hypr_Axis(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Hypr_ConjugateBranch1(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Hypr_ConjugateBranch2(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Hypr_Directrix1(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Hypr_Directrix2(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern double gp_Hypr_Eccentricity(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern double gp_Hypr_Focal(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Hypr_Focus1(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Hypr_Focus2(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Hypr_SetLocation(IntPtr instance, IntPtr value);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Hypr_Location(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Hypr_SetMajorRadius(IntPtr instance, double value);
		[DllImport("NaroOccCore.dll")]
		private static extern double gp_Hypr_MajorRadius(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Hypr_SetMinorRadius(IntPtr instance, double value);
		[DllImport("NaroOccCore.dll")]
		private static extern double gp_Hypr_MinorRadius(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Hypr_OtherBranch(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern double gp_Hypr_Parameter(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Hypr_SetPosition(IntPtr instance, IntPtr value);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Hypr_Position(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Hypr_XAxis(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Hypr_YAxis(IntPtr instance);

		#region NativeInstancePtr Convert constructor

		public gpHypr(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ gpHypr_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void gpHypr_Dtor(IntPtr instance);
	}
}
