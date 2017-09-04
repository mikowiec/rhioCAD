#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;
using NaroCppCore.Occ.gp;

#endregion

namespace NaroCppCore.Occ.gp
{
	public class gpParab2d : NativeInstancePtr
	{
		public gpParab2d()
 :
			base(gp_Parab2d_Ctor() )
		{}
		public gpParab2d(gpAx2d MirrorAxis,double Focal,bool Sense)
 :
			base(gp_Parab2d_Ctor462C7341(MirrorAxis.Instance, Focal, Sense) )
		{}
		public gpParab2d(gpAx22d A,double Focal)
 :
			base(gp_Parab2d_Ctor443D47DE(A.Instance, Focal) )
		{}
		public gpParab2d(gpAx2d D,gpPnt2d F,bool Sense)
 :
			base(gp_Parab2d_CtorF2803558(D.Instance, F.Instance, Sense) )
		{}
		public gpParab2d(gpAx22d D,gpPnt2d F)
 :
			base(gp_Parab2d_Ctor3DE242E8(D.Instance, F.Instance) )
		{}
			public void Coefficients(ref double A,ref double B,ref double C,ref double D,ref double E,ref double F)
				{
					gp_Parab2d_CoefficientsBC7A5786(Instance, ref A, ref B, ref C, ref D, ref E, ref F);
				}
			public void Reverse()
				{
					gp_Parab2d_Reverse(Instance);
				}
			public void Mirror(gpPnt2d P)
				{
					gp_Parab2d_Mirror6203658C(Instance, P.Instance);
				}
			public gpParab2d Mirrored(gpPnt2d P)
				{
					return new gpParab2d(gp_Parab2d_Mirrored6203658C(Instance, P.Instance));
				}
			public void Mirror(gpAx2d A)
				{
					gp_Parab2d_Mirror90E1386A(Instance, A.Instance);
				}
			public gpParab2d Mirrored(gpAx2d A)
				{
					return new gpParab2d(gp_Parab2d_Mirrored90E1386A(Instance, A.Instance));
				}
			public void Rotate(gpPnt2d P,double Ang)
				{
					gp_Parab2d_RotateE3062737(Instance, P.Instance, Ang);
				}
			public gpParab2d Rotated(gpPnt2d P,double Ang)
				{
					return new gpParab2d(gp_Parab2d_RotatedE3062737(Instance, P.Instance, Ang));
				}
			public void Scale(gpPnt2d P,double S)
				{
					gp_Parab2d_ScaleE3062737(Instance, P.Instance, S);
				}
			public gpParab2d Scaled(gpPnt2d P,double S)
				{
					return new gpParab2d(gp_Parab2d_ScaledE3062737(Instance, P.Instance, S));
				}
			public void Transform(gpTrsf2d T)
				{
					gp_Parab2d_Transform27621DCB(Instance, T.Instance);
				}
			public gpParab2d Transformed(gpTrsf2d T)
				{
					return new gpParab2d(gp_Parab2d_Transformed27621DCB(Instance, T.Instance));
				}
			public void Translate(gpVec2d V)
				{
					gp_Parab2d_Translate5E4E66E7(Instance, V.Instance);
				}
			public gpParab2d Translated(gpVec2d V)
				{
					return new gpParab2d(gp_Parab2d_Translated5E4E66E7(Instance, V.Instance));
				}
			public void Translate(gpPnt2d P1,gpPnt2d P2)
				{
					gp_Parab2d_Translate5F54ADE3(Instance, P1.Instance, P2.Instance);
				}
			public gpParab2d Translated(gpPnt2d P1,gpPnt2d P2)
				{
					return new gpParab2d(gp_Parab2d_Translated5F54ADE3(Instance, P1.Instance, P2.Instance));
				}
		public gpAx2d Directrix{
			get {
				return new gpAx2d(gp_Parab2d_Directrix(Instance));
			}
		}
		public double Focal{
			set { 
				gp_Parab2d_SetFocal(Instance, value);
			}
			get {
				return gp_Parab2d_Focal(Instance);
			}
		}
		public gpPnt2d Focus{
			get {
				return new gpPnt2d(gp_Parab2d_Focus(Instance));
			}
		}
		public gpPnt2d Location{
			set { 
				gp_Parab2d_SetLocation(Instance, value.Instance);
			}
			get {
				return new gpPnt2d(gp_Parab2d_Location(Instance));
			}
		}
		public gpAx2d MirrorAxis{
			set { 
				gp_Parab2d_SetMirrorAxis(Instance, value.Instance);
			}
			get {
				return new gpAx2d(gp_Parab2d_MirrorAxis(Instance));
			}
		}
		public gpAx22d Axis{
			set { 
				gp_Parab2d_SetAxis(Instance, value.Instance);
			}
			get {
				return new gpAx22d(gp_Parab2d_Axis(Instance));
			}
		}
		public double Parameter{
			get {
				return gp_Parab2d_Parameter(Instance);
			}
		}
		public gpParab2d Reversed{
			get {
				return new gpParab2d(gp_Parab2d_Reversed(Instance));
			}
		}
		public bool IsDirect{
			get {
				return gp_Parab2d_IsDirect(Instance);
			}
		}
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Parab2d_Ctor();
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Parab2d_Ctor462C7341(IntPtr MirrorAxis,double Focal,bool Sense);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Parab2d_Ctor443D47DE(IntPtr A,double Focal);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Parab2d_CtorF2803558(IntPtr D,IntPtr F,bool Sense);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Parab2d_Ctor3DE242E8(IntPtr D,IntPtr F);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Parab2d_CoefficientsBC7A5786(IntPtr instance, ref double A,ref double B,ref double C,ref double D,ref double E,ref double F);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Parab2d_Reverse(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Parab2d_Mirror6203658C(IntPtr instance, IntPtr P);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Parab2d_Mirrored6203658C(IntPtr instance, IntPtr P);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Parab2d_Mirror90E1386A(IntPtr instance, IntPtr A);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Parab2d_Mirrored90E1386A(IntPtr instance, IntPtr A);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Parab2d_RotateE3062737(IntPtr instance, IntPtr P,double Ang);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Parab2d_RotatedE3062737(IntPtr instance, IntPtr P,double Ang);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Parab2d_ScaleE3062737(IntPtr instance, IntPtr P,double S);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Parab2d_ScaledE3062737(IntPtr instance, IntPtr P,double S);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Parab2d_Transform27621DCB(IntPtr instance, IntPtr T);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Parab2d_Transformed27621DCB(IntPtr instance, IntPtr T);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Parab2d_Translate5E4E66E7(IntPtr instance, IntPtr V);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Parab2d_Translated5E4E66E7(IntPtr instance, IntPtr V);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Parab2d_Translate5F54ADE3(IntPtr instance, IntPtr P1,IntPtr P2);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Parab2d_Translated5F54ADE3(IntPtr instance, IntPtr P1,IntPtr P2);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Parab2d_Directrix(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Parab2d_SetFocal(IntPtr instance, double value);
		[DllImport("NaroOccCore.dll")]
		private static extern double gp_Parab2d_Focal(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Parab2d_Focus(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Parab2d_SetLocation(IntPtr instance, IntPtr value);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Parab2d_Location(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Parab2d_SetMirrorAxis(IntPtr instance, IntPtr value);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Parab2d_MirrorAxis(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Parab2d_SetAxis(IntPtr instance, IntPtr value);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Parab2d_Axis(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern double gp_Parab2d_Parameter(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Parab2d_Reversed(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool gp_Parab2d_IsDirect(IntPtr instance);

		#region NativeInstancePtr Convert constructor

		public gpParab2d(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ gpParab2d_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void gpParab2d_Dtor(IntPtr instance);
	}
}
