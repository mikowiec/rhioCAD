#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;
using NaroCppCore.Occ.gp;

#endregion

namespace NaroCppCore.Occ.gp
{
	public class gpAx22d : NativeInstancePtr
	{
		public gpAx22d()
 :
			base(gp_Ax22d_Ctor() )
		{}
		public gpAx22d(gpPnt2d P,gpDir2d Vx,gpDir2d Vy)
 :
			base(gp_Ax22d_CtorE3FB4CCB(P.Instance, Vx.Instance, Vy.Instance) )
		{}
		public gpAx22d(gpPnt2d P,gpDir2d V,bool Sense)
 :
			base(gp_Ax22d_CtorE18CA5E9(P.Instance, V.Instance, Sense) )
		{}
		public gpAx22d(gpAx2d A,bool Sense)
 :
			base(gp_Ax22d_Ctor2C652E28(A.Instance, Sense) )
		{}
			public void Mirror(gpPnt2d P)
				{
					gp_Ax22d_Mirror6203658C(Instance, P.Instance);
				}
			public gpAx22d Mirrored(gpPnt2d P)
				{
					return new gpAx22d(gp_Ax22d_Mirrored6203658C(Instance, P.Instance));
				}
			public void Mirror(gpAx2d A)
				{
					gp_Ax22d_Mirror90E1386A(Instance, A.Instance);
				}
			public gpAx22d Mirrored(gpAx2d A)
				{
					return new gpAx22d(gp_Ax22d_Mirrored90E1386A(Instance, A.Instance));
				}
			public void Rotate(gpPnt2d P,double Ang)
				{
					gp_Ax22d_RotateE3062737(Instance, P.Instance, Ang);
				}
			public gpAx22d Rotated(gpPnt2d P,double Ang)
				{
					return new gpAx22d(gp_Ax22d_RotatedE3062737(Instance, P.Instance, Ang));
				}
			public void Scale(gpPnt2d P,double S)
				{
					gp_Ax22d_ScaleE3062737(Instance, P.Instance, S);
				}
			public gpAx22d Scaled(gpPnt2d P,double S)
				{
					return new gpAx22d(gp_Ax22d_ScaledE3062737(Instance, P.Instance, S));
				}
			public void Transform(gpTrsf2d T)
				{
					gp_Ax22d_Transform27621DCB(Instance, T.Instance);
				}
			public gpAx22d Transformed(gpTrsf2d T)
				{
					return new gpAx22d(gp_Ax22d_Transformed27621DCB(Instance, T.Instance));
				}
			public void Translate(gpVec2d V)
				{
					gp_Ax22d_Translate5E4E66E7(Instance, V.Instance);
				}
			public gpAx22d Translated(gpVec2d V)
				{
					return new gpAx22d(gp_Ax22d_Translated5E4E66E7(Instance, V.Instance));
				}
			public void Translate(gpPnt2d P1,gpPnt2d P2)
				{
					gp_Ax22d_Translate5F54ADE3(Instance, P1.Instance, P2.Instance);
				}
			public gpAx22d Translated(gpPnt2d P1,gpPnt2d P2)
				{
					return new gpAx22d(gp_Ax22d_Translated5F54ADE3(Instance, P1.Instance, P2.Instance));
				}
		public gpAx22d Axis{
			set { 
				gp_Ax22d_SetAxis(Instance, value.Instance);
			}
		}
		public gpAx2d XAxis{
			set { 
				gp_Ax22d_SetXAxis(Instance, value.Instance);
			}
			get {
				return new gpAx2d(gp_Ax22d_XAxis(Instance));
			}
		}
		public gpAx2d YAxis{
			set { 
				gp_Ax22d_SetYAxis(Instance, value.Instance);
			}
			get {
				return new gpAx2d(gp_Ax22d_YAxis(Instance));
			}
		}
		public gpPnt2d Location{
			set { 
				gp_Ax22d_SetLocation(Instance, value.Instance);
			}
			get {
				return new gpPnt2d(gp_Ax22d_Location(Instance));
			}
		}
		public gpDir2d XDirection{
			set { 
				gp_Ax22d_SetXDirection(Instance, value.Instance);
			}
			get {
				return new gpDir2d(gp_Ax22d_XDirection(Instance));
			}
		}
		public gpDir2d YDirection{
			set { 
				gp_Ax22d_SetYDirection(Instance, value.Instance);
			}
			get {
				return new gpDir2d(gp_Ax22d_YDirection(Instance));
			}
		}
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Ax22d_Ctor();
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Ax22d_CtorE3FB4CCB(IntPtr P,IntPtr Vx,IntPtr Vy);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Ax22d_CtorE18CA5E9(IntPtr P,IntPtr V,bool Sense);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Ax22d_Ctor2C652E28(IntPtr A,bool Sense);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Ax22d_Mirror6203658C(IntPtr instance, IntPtr P);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Ax22d_Mirrored6203658C(IntPtr instance, IntPtr P);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Ax22d_Mirror90E1386A(IntPtr instance, IntPtr A);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Ax22d_Mirrored90E1386A(IntPtr instance, IntPtr A);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Ax22d_RotateE3062737(IntPtr instance, IntPtr P,double Ang);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Ax22d_RotatedE3062737(IntPtr instance, IntPtr P,double Ang);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Ax22d_ScaleE3062737(IntPtr instance, IntPtr P,double S);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Ax22d_ScaledE3062737(IntPtr instance, IntPtr P,double S);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Ax22d_Transform27621DCB(IntPtr instance, IntPtr T);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Ax22d_Transformed27621DCB(IntPtr instance, IntPtr T);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Ax22d_Translate5E4E66E7(IntPtr instance, IntPtr V);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Ax22d_Translated5E4E66E7(IntPtr instance, IntPtr V);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Ax22d_Translate5F54ADE3(IntPtr instance, IntPtr P1,IntPtr P2);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Ax22d_Translated5F54ADE3(IntPtr instance, IntPtr P1,IntPtr P2);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Ax22d_SetAxis(IntPtr instance, IntPtr value);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Ax22d_SetXAxis(IntPtr instance, IntPtr value);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Ax22d_XAxis(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Ax22d_SetYAxis(IntPtr instance, IntPtr value);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Ax22d_YAxis(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Ax22d_SetLocation(IntPtr instance, IntPtr value);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Ax22d_Location(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Ax22d_SetXDirection(IntPtr instance, IntPtr value);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Ax22d_XDirection(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Ax22d_SetYDirection(IntPtr instance, IntPtr value);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Ax22d_YDirection(IntPtr instance);

		#region NativeInstancePtr Convert constructor

		public gpAx22d(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ gpAx22d_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void gpAx22d_Dtor(IntPtr instance);
	}
}
