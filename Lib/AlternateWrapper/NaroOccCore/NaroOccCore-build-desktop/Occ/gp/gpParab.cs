#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;
using NaroCppCore.Occ.gp;

#endregion

namespace NaroCppCore.Occ.gp
{
	public class gpParab : NativeInstancePtr
	{
		public gpParab()
 :
			base(gp_Parab_Ctor() )
		{}
		public gpParab(gpAx2 A2,double Focal)
 :
			base(gp_Parab_Ctor673FA07D(A2.Instance, Focal) )
		{}
		public gpParab(gpAx1 D,gpPnt F)
 :
			base(gp_Parab_Ctor3B6CEA26(D.Instance, F.Instance) )
		{}
			public void Mirror(gpPnt P)
				{
					gp_Parab_Mirror9EAECD5B(Instance, P.Instance);
				}
			public gpParab Mirrored(gpPnt P)
				{
					return new gpParab(gp_Parab_Mirrored9EAECD5B(Instance, P.Instance));
				}
			public void Mirror(gpAx1 A1)
				{
					gp_Parab_Mirror608B963B(Instance, A1.Instance);
				}
			public gpParab Mirrored(gpAx1 A1)
				{
					return new gpParab(gp_Parab_Mirrored608B963B(Instance, A1.Instance));
				}
			public void Mirror(gpAx2 A2)
				{
					gp_Parab_Mirror7895386A(Instance, A2.Instance);
				}
			public gpParab Mirrored(gpAx2 A2)
				{
					return new gpParab(gp_Parab_Mirrored7895386A(Instance, A2.Instance));
				}
			public void Rotate(gpAx1 A1,double Ang)
				{
					gp_Parab_Rotate827CB19A(Instance, A1.Instance, Ang);
				}
			public gpParab Rotated(gpAx1 A1,double Ang)
				{
					return new gpParab(gp_Parab_Rotated827CB19A(Instance, A1.Instance, Ang));
				}
			public void Scale(gpPnt P,double S)
				{
					gp_Parab_ScaleF0D1E3E6(Instance, P.Instance, S);
				}
			public gpParab Scaled(gpPnt P,double S)
				{
					return new gpParab(gp_Parab_ScaledF0D1E3E6(Instance, P.Instance, S));
				}
			public void Transform(gpTrsf T)
				{
					gp_Parab_Transform72D78650(Instance, T.Instance);
				}
			public gpParab Transformed(gpTrsf T)
				{
					return new gpParab(gp_Parab_Transformed72D78650(Instance, T.Instance));
				}
			public void Translate(gpVec V)
				{
					gp_Parab_Translate9BD9CFFE(Instance, V.Instance);
				}
			public gpParab Translated(gpVec V)
				{
					return new gpParab(gp_Parab_Translated9BD9CFFE(Instance, V.Instance));
				}
			public void Translate(gpPnt P1,gpPnt P2)
				{
					gp_Parab_Translate5C63477E(Instance, P1.Instance, P2.Instance);
				}
			public gpParab Translated(gpPnt P1,gpPnt P2)
				{
					return new gpParab(gp_Parab_Translated5C63477E(Instance, P1.Instance, P2.Instance));
				}
		public gpAx1 Axis{
			set { 
				gp_Parab_SetAxis(Instance, value.Instance);
			}
			get {
				return new gpAx1(gp_Parab_Axis(Instance));
			}
		}
		public gpAx1 Directrix{
			get {
				return new gpAx1(gp_Parab_Directrix(Instance));
			}
		}
		public double Focal{
			set { 
				gp_Parab_SetFocal(Instance, value);
			}
			get {
				return gp_Parab_Focal(Instance);
			}
		}
		public gpPnt Focus{
			get {
				return new gpPnt(gp_Parab_Focus(Instance));
			}
		}
		public gpPnt Location{
			set { 
				gp_Parab_SetLocation(Instance, value.Instance);
			}
			get {
				return new gpPnt(gp_Parab_Location(Instance));
			}
		}
		public double Parameter{
			get {
				return gp_Parab_Parameter(Instance);
			}
		}
		public gpAx2 Position{
			set { 
				gp_Parab_SetPosition(Instance, value.Instance);
			}
			get {
				return new gpAx2(gp_Parab_Position(Instance));
			}
		}
		public gpAx1 XAxis{
			get {
				return new gpAx1(gp_Parab_XAxis(Instance));
			}
		}
		public gpAx1 YAxis{
			get {
				return new gpAx1(gp_Parab_YAxis(Instance));
			}
		}
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Parab_Ctor();
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Parab_Ctor673FA07D(IntPtr A2,double Focal);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Parab_Ctor3B6CEA26(IntPtr D,IntPtr F);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Parab_Mirror9EAECD5B(IntPtr instance, IntPtr P);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Parab_Mirrored9EAECD5B(IntPtr instance, IntPtr P);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Parab_Mirror608B963B(IntPtr instance, IntPtr A1);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Parab_Mirrored608B963B(IntPtr instance, IntPtr A1);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Parab_Mirror7895386A(IntPtr instance, IntPtr A2);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Parab_Mirrored7895386A(IntPtr instance, IntPtr A2);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Parab_Rotate827CB19A(IntPtr instance, IntPtr A1,double Ang);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Parab_Rotated827CB19A(IntPtr instance, IntPtr A1,double Ang);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Parab_ScaleF0D1E3E6(IntPtr instance, IntPtr P,double S);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Parab_ScaledF0D1E3E6(IntPtr instance, IntPtr P,double S);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Parab_Transform72D78650(IntPtr instance, IntPtr T);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Parab_Transformed72D78650(IntPtr instance, IntPtr T);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Parab_Translate9BD9CFFE(IntPtr instance, IntPtr V);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Parab_Translated9BD9CFFE(IntPtr instance, IntPtr V);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Parab_Translate5C63477E(IntPtr instance, IntPtr P1,IntPtr P2);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Parab_Translated5C63477E(IntPtr instance, IntPtr P1,IntPtr P2);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Parab_SetAxis(IntPtr instance, IntPtr value);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Parab_Axis(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Parab_Directrix(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Parab_SetFocal(IntPtr instance, double value);
		[DllImport("NaroOccCore.dll")]
		private static extern double gp_Parab_Focal(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Parab_Focus(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Parab_SetLocation(IntPtr instance, IntPtr value);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Parab_Location(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern double gp_Parab_Parameter(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Parab_SetPosition(IntPtr instance, IntPtr value);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Parab_Position(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Parab_XAxis(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Parab_YAxis(IntPtr instance);

		#region NativeInstancePtr Convert constructor

		public gpParab(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ gpParab_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void gpParab_Dtor(IntPtr instance);
	}
}
