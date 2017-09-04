#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;
using NaroCppCore.Occ.gp;

#endregion

namespace NaroCppCore.Occ.gp
{
	public class gpLin : NativeInstancePtr
	{
		public gpLin()
 :
			base(gp_Lin_Ctor() )
		{}
		public gpLin(gpAx1 A1)
 :
			base(gp_Lin_Ctor608B963B(A1.Instance) )
		{}
		public gpLin(gpPnt P,gpDir V)
 :
			base(gp_Lin_CtorE13B639C(P.Instance, V.Instance) )
		{}
			public void Reverse()
				{
					gp_Lin_Reverse(Instance);
				}
			public double Angle(gpLin Other)
				{
					return gp_Lin_Angle9917D291(Instance, Other.Instance);
				}
			public bool Contains(gpPnt P,double LinearTolerance)
				{
					return gp_Lin_ContainsF0D1E3E6(Instance, P.Instance, LinearTolerance);
				}
			public double Distance(gpPnt P)
				{
					return gp_Lin_Distance9EAECD5B(Instance, P.Instance);
				}
			public double Distance(gpLin Other)
				{
					return gp_Lin_Distance9917D291(Instance, Other.Instance);
				}
			public double SquareDistance(gpPnt P)
				{
					return gp_Lin_SquareDistance9EAECD5B(Instance, P.Instance);
				}
			public double SquareDistance(gpLin Other)
				{
					return gp_Lin_SquareDistance9917D291(Instance, Other.Instance);
				}
			public gpLin Normal(gpPnt P)
				{
					return new gpLin(gp_Lin_Normal9EAECD5B(Instance, P.Instance));
				}
			public void Mirror(gpPnt P)
				{
					gp_Lin_Mirror9EAECD5B(Instance, P.Instance);
				}
			public gpLin Mirrored(gpPnt P)
				{
					return new gpLin(gp_Lin_Mirrored9EAECD5B(Instance, P.Instance));
				}
			public void Mirror(gpAx1 A1)
				{
					gp_Lin_Mirror608B963B(Instance, A1.Instance);
				}
			public gpLin Mirrored(gpAx1 A1)
				{
					return new gpLin(gp_Lin_Mirrored608B963B(Instance, A1.Instance));
				}
			public void Mirror(gpAx2 A2)
				{
					gp_Lin_Mirror7895386A(Instance, A2.Instance);
				}
			public gpLin Mirrored(gpAx2 A2)
				{
					return new gpLin(gp_Lin_Mirrored7895386A(Instance, A2.Instance));
				}
			public void Rotate(gpAx1 A1,double Ang)
				{
					gp_Lin_Rotate827CB19A(Instance, A1.Instance, Ang);
				}
			public gpLin Rotated(gpAx1 A1,double Ang)
				{
					return new gpLin(gp_Lin_Rotated827CB19A(Instance, A1.Instance, Ang));
				}
			public void Scale(gpPnt P,double S)
				{
					gp_Lin_ScaleF0D1E3E6(Instance, P.Instance, S);
				}
			public gpLin Scaled(gpPnt P,double S)
				{
					return new gpLin(gp_Lin_ScaledF0D1E3E6(Instance, P.Instance, S));
				}
			public void Transform(gpTrsf T)
				{
					gp_Lin_Transform72D78650(Instance, T.Instance);
				}
			public gpLin Transformed(gpTrsf T)
				{
					return new gpLin(gp_Lin_Transformed72D78650(Instance, T.Instance));
				}
			public void Translate(gpVec V)
				{
					gp_Lin_Translate9BD9CFFE(Instance, V.Instance);
				}
			public gpLin Translated(gpVec V)
				{
					return new gpLin(gp_Lin_Translated9BD9CFFE(Instance, V.Instance));
				}
			public void Translate(gpPnt P1,gpPnt P2)
				{
					gp_Lin_Translate5C63477E(Instance, P1.Instance, P2.Instance);
				}
			public gpLin Translated(gpPnt P1,gpPnt P2)
				{
					return new gpLin(gp_Lin_Translated5C63477E(Instance, P1.Instance, P2.Instance));
				}
		public gpLin Reversed{
			get {
				return new gpLin(gp_Lin_Reversed(Instance));
			}
		}
		public gpDir Direction{
			set { 
				gp_Lin_SetDirection(Instance, value.Instance);
			}
			get {
				return new gpDir(gp_Lin_Direction(Instance));
			}
		}
		public gpPnt Location{
			set { 
				gp_Lin_SetLocation(Instance, value.Instance);
			}
			get {
				return new gpPnt(gp_Lin_Location(Instance));
			}
		}
		public gpAx1 Position{
			set { 
				gp_Lin_SetPosition(Instance, value.Instance);
			}
			get {
				return new gpAx1(gp_Lin_Position(Instance));
			}
		}
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Lin_Ctor();
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Lin_Ctor608B963B(IntPtr A1);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Lin_CtorE13B639C(IntPtr P,IntPtr V);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Lin_Reverse(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern double gp_Lin_Angle9917D291(IntPtr instance, IntPtr Other);
		[DllImport("NaroOccCore.dll")]
		private static extern bool gp_Lin_ContainsF0D1E3E6(IntPtr instance, IntPtr P,double LinearTolerance);
		[DllImport("NaroOccCore.dll")]
		private static extern double gp_Lin_Distance9EAECD5B(IntPtr instance, IntPtr P);
		[DllImport("NaroOccCore.dll")]
		private static extern double gp_Lin_Distance9917D291(IntPtr instance, IntPtr Other);
		[DllImport("NaroOccCore.dll")]
		private static extern double gp_Lin_SquareDistance9EAECD5B(IntPtr instance, IntPtr P);
		[DllImport("NaroOccCore.dll")]
		private static extern double gp_Lin_SquareDistance9917D291(IntPtr instance, IntPtr Other);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Lin_Normal9EAECD5B(IntPtr instance, IntPtr P);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Lin_Mirror9EAECD5B(IntPtr instance, IntPtr P);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Lin_Mirrored9EAECD5B(IntPtr instance, IntPtr P);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Lin_Mirror608B963B(IntPtr instance, IntPtr A1);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Lin_Mirrored608B963B(IntPtr instance, IntPtr A1);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Lin_Mirror7895386A(IntPtr instance, IntPtr A2);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Lin_Mirrored7895386A(IntPtr instance, IntPtr A2);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Lin_Rotate827CB19A(IntPtr instance, IntPtr A1,double Ang);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Lin_Rotated827CB19A(IntPtr instance, IntPtr A1,double Ang);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Lin_ScaleF0D1E3E6(IntPtr instance, IntPtr P,double S);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Lin_ScaledF0D1E3E6(IntPtr instance, IntPtr P,double S);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Lin_Transform72D78650(IntPtr instance, IntPtr T);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Lin_Transformed72D78650(IntPtr instance, IntPtr T);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Lin_Translate9BD9CFFE(IntPtr instance, IntPtr V);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Lin_Translated9BD9CFFE(IntPtr instance, IntPtr V);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Lin_Translate5C63477E(IntPtr instance, IntPtr P1,IntPtr P2);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Lin_Translated5C63477E(IntPtr instance, IntPtr P1,IntPtr P2);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Lin_Reversed(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Lin_SetDirection(IntPtr instance, IntPtr value);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Lin_Direction(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Lin_SetLocation(IntPtr instance, IntPtr value);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Lin_Location(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Lin_SetPosition(IntPtr instance, IntPtr value);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Lin_Position(IntPtr instance);

		#region NativeInstancePtr Convert constructor

		public gpLin(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ gpLin_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void gpLin_Dtor(IntPtr instance);
	}
}
