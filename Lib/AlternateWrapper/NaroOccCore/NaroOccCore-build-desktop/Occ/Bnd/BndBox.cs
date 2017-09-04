#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;
using NaroCppCore.Occ.gp;
using NaroCppCore.Occ.Bnd;

#endregion

namespace NaroCppCore.Occ.Bnd
{
	public class BndBox : NativeInstancePtr
	{
		public BndBox()
 :
			base(Bnd_Box_Ctor() )
		{}
			public void SetWhole()
				{
					Bnd_Box_SetWhole(Instance);
				}
			public void SetVoid()
				{
					Bnd_Box_SetVoid(Instance);
				}
			public void Set(gpPnt P)
				{
					Bnd_Box_Set9EAECD5B(Instance, P.Instance);
				}
			public void Set(gpPnt P,gpDir D)
				{
					Bnd_Box_SetE13B639C(Instance, P.Instance, D.Instance);
				}
			public void Update(double aXmin,double aYmin,double aZmin,double aXmax,double aYmax,double aZmax)
				{
					Bnd_Box_UpdateBC7A5786(Instance, aXmin, aYmin, aZmin, aXmax, aYmax, aZmax);
				}
			public void Update(double X,double Y,double Z)
				{
					Bnd_Box_Update9282A951(Instance, X, Y, Z);
				}
			public void Enlarge(double Tol)
				{
					Bnd_Box_EnlargeD82819F3(Instance, Tol);
				}
			public void Get(ref double aXmin,ref double aYmin,ref double aZmin,ref double aXmax,ref double aYmax,ref double aZmax)
				{
					Bnd_Box_GetBC7A5786(Instance, ref aXmin, ref aYmin, ref aZmin, ref aXmax, ref aYmax, ref aZmax);
				}
			public void OpenXmin()
				{
					Bnd_Box_OpenXmin(Instance);
				}
			public void OpenXmax()
				{
					Bnd_Box_OpenXmax(Instance);
				}
			public void OpenYmin()
				{
					Bnd_Box_OpenYmin(Instance);
				}
			public void OpenYmax()
				{
					Bnd_Box_OpenYmax(Instance);
				}
			public void OpenZmin()
				{
					Bnd_Box_OpenZmin(Instance);
				}
			public void OpenZmax()
				{
					Bnd_Box_OpenZmax(Instance);
				}
			public bool IsXThin(double tol)
				{
					return Bnd_Box_IsXThinD82819F3(Instance, tol);
				}
			public bool IsYThin(double tol)
				{
					return Bnd_Box_IsYThinD82819F3(Instance, tol);
				}
			public bool IsZThin(double tol)
				{
					return Bnd_Box_IsZThinD82819F3(Instance, tol);
				}
			public bool IsThin(double tol)
				{
					return Bnd_Box_IsThinD82819F3(Instance, tol);
				}
			public BndBox Transformed(gpTrsf T)
				{
					return new BndBox(Bnd_Box_Transformed72D78650(Instance, T.Instance));
				}
			public void Add(BndBox Other)
				{
					Bnd_Box_Add1ADB021(Instance, Other.Instance);
				}
			public void Add(gpPnt P)
				{
					Bnd_Box_Add9EAECD5B(Instance, P.Instance);
				}
			public void Add(gpPnt P,gpDir D)
				{
					Bnd_Box_AddE13B639C(Instance, P.Instance, D.Instance);
				}
			public void Add(gpDir D)
				{
					Bnd_Box_AddCEC711A5(Instance, D.Instance);
				}
			public bool IsOut(gpPnt P)
				{
					return Bnd_Box_IsOut9EAECD5B(Instance, P.Instance);
				}
			public bool IsOut(gpLin L)
				{
					return Bnd_Box_IsOut9917D291(Instance, L.Instance);
				}
			public bool IsOut(gpPln P)
				{
					return Bnd_Box_IsOut9914D2AD(Instance, P.Instance);
				}
			public bool IsOut(BndBox Other)
				{
					return Bnd_Box_IsOut1ADB021(Instance, Other.Instance);
				}
			public bool IsOut(BndBox Other,gpTrsf T)
				{
					return Bnd_Box_IsOut3A879F89(Instance, Other.Instance, T.Instance);
				}
			public bool IsOut(gpTrsf T1,BndBox Other,gpTrsf T2)
				{
					return Bnd_Box_IsOutBCD9C93D(Instance, T1.Instance, Other.Instance, T2.Instance);
				}
			public bool IsOut(gpPnt P1,gpPnt P2,gpDir D)
				{
					return Bnd_Box_IsOut637767F(Instance, P1.Instance, P2.Instance, D.Instance);
				}
			public double Distance(BndBox Other)
				{
					return Bnd_Box_Distance1ADB021(Instance, Other.Instance);
				}
			public void Dump()
				{
					Bnd_Box_Dump(Instance);
				}
		public double GetGap{
			get {
				return Bnd_Box_GetGap(Instance);
			}
		}
		public double Gap{
			set { 
				Bnd_Box_SetGap(Instance, value);
			}
		}
		public bool IsOpenXmin{
			get {
				return Bnd_Box_IsOpenXmin(Instance);
			}
		}
		public bool IsOpenXmax{
			get {
				return Bnd_Box_IsOpenXmax(Instance);
			}
		}
		public bool IsOpenYmin{
			get {
				return Bnd_Box_IsOpenYmin(Instance);
			}
		}
		public bool IsOpenYmax{
			get {
				return Bnd_Box_IsOpenYmax(Instance);
			}
		}
		public bool IsOpenZmin{
			get {
				return Bnd_Box_IsOpenZmin(Instance);
			}
		}
		public bool IsOpenZmax{
			get {
				return Bnd_Box_IsOpenZmax(Instance);
			}
		}
		public bool IsWhole{
			get {
				return Bnd_Box_IsWhole(Instance);
			}
		}
		public bool IsVoid{
			get {
				return Bnd_Box_IsVoid(Instance);
			}
		}
		public double SquareExtent{
			get {
				return Bnd_Box_SquareExtent(Instance);
			}
		}
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Bnd_Box_Ctor();
		[DllImport("NaroOccCore.dll")]
		private static extern void Bnd_Box_SetWhole(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void Bnd_Box_SetVoid(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void Bnd_Box_Set9EAECD5B(IntPtr instance, IntPtr P);
		[DllImport("NaroOccCore.dll")]
		private static extern void Bnd_Box_SetE13B639C(IntPtr instance, IntPtr P,IntPtr D);
		[DllImport("NaroOccCore.dll")]
		private static extern void Bnd_Box_UpdateBC7A5786(IntPtr instance, double aXmin,double aYmin,double aZmin,double aXmax,double aYmax,double aZmax);
		[DllImport("NaroOccCore.dll")]
		private static extern void Bnd_Box_Update9282A951(IntPtr instance, double X,double Y,double Z);
		[DllImport("NaroOccCore.dll")]
		private static extern void Bnd_Box_EnlargeD82819F3(IntPtr instance, double Tol);
		[DllImport("NaroOccCore.dll")]
		private static extern void Bnd_Box_GetBC7A5786(IntPtr instance, ref double aXmin,ref double aYmin,ref double aZmin,ref double aXmax,ref double aYmax,ref double aZmax);
		[DllImport("NaroOccCore.dll")]
		private static extern void Bnd_Box_OpenXmin(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void Bnd_Box_OpenXmax(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void Bnd_Box_OpenYmin(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void Bnd_Box_OpenYmax(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void Bnd_Box_OpenZmin(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void Bnd_Box_OpenZmax(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool Bnd_Box_IsXThinD82819F3(IntPtr instance, double tol);
		[DllImport("NaroOccCore.dll")]
		private static extern bool Bnd_Box_IsYThinD82819F3(IntPtr instance, double tol);
		[DllImport("NaroOccCore.dll")]
		private static extern bool Bnd_Box_IsZThinD82819F3(IntPtr instance, double tol);
		[DllImport("NaroOccCore.dll")]
		private static extern bool Bnd_Box_IsThinD82819F3(IntPtr instance, double tol);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Bnd_Box_Transformed72D78650(IntPtr instance, IntPtr T);
		[DllImport("NaroOccCore.dll")]
		private static extern void Bnd_Box_Add1ADB021(IntPtr instance, IntPtr Other);
		[DllImport("NaroOccCore.dll")]
		private static extern void Bnd_Box_Add9EAECD5B(IntPtr instance, IntPtr P);
		[DllImport("NaroOccCore.dll")]
		private static extern void Bnd_Box_AddE13B639C(IntPtr instance, IntPtr P,IntPtr D);
		[DllImport("NaroOccCore.dll")]
		private static extern void Bnd_Box_AddCEC711A5(IntPtr instance, IntPtr D);
		[DllImport("NaroOccCore.dll")]
		private static extern bool Bnd_Box_IsOut9EAECD5B(IntPtr instance, IntPtr P);
		[DllImport("NaroOccCore.dll")]
		private static extern bool Bnd_Box_IsOut9917D291(IntPtr instance, IntPtr L);
		[DllImport("NaroOccCore.dll")]
		private static extern bool Bnd_Box_IsOut9914D2AD(IntPtr instance, IntPtr P);
		[DllImport("NaroOccCore.dll")]
		private static extern bool Bnd_Box_IsOut1ADB021(IntPtr instance, IntPtr Other);
		[DllImport("NaroOccCore.dll")]
		private static extern bool Bnd_Box_IsOut3A879F89(IntPtr instance, IntPtr Other,IntPtr T);
		[DllImport("NaroOccCore.dll")]
		private static extern bool Bnd_Box_IsOutBCD9C93D(IntPtr instance, IntPtr T1,IntPtr Other,IntPtr T2);
		[DllImport("NaroOccCore.dll")]
		private static extern bool Bnd_Box_IsOut637767F(IntPtr instance, IntPtr P1,IntPtr P2,IntPtr D);
		[DllImport("NaroOccCore.dll")]
		private static extern double Bnd_Box_Distance1ADB021(IntPtr instance, IntPtr Other);
		[DllImport("NaroOccCore.dll")]
		private static extern void Bnd_Box_Dump(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern double Bnd_Box_GetGap(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void Bnd_Box_SetGap(IntPtr instance, double value);
		[DllImport("NaroOccCore.dll")]
		private static extern bool Bnd_Box_IsOpenXmin(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool Bnd_Box_IsOpenXmax(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool Bnd_Box_IsOpenYmin(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool Bnd_Box_IsOpenYmax(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool Bnd_Box_IsOpenZmin(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool Bnd_Box_IsOpenZmax(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool Bnd_Box_IsWhole(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool Bnd_Box_IsVoid(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern double Bnd_Box_SquareExtent(IntPtr instance);

		#region NativeInstancePtr Convert constructor

		public BndBox(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ BndBox_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void BndBox_Dtor(IntPtr instance);
	}
}
