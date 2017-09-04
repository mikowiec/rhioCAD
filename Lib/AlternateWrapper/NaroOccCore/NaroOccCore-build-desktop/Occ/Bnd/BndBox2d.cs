#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;
using NaroCppCore.Occ.gp;
using NaroCppCore.Occ.Bnd;

#endregion

namespace NaroCppCore.Occ.Bnd
{
	public class BndBox2d : NativeInstancePtr
	{
		public BndBox2d()
 :
			base(Bnd_Box2d_Ctor() )
		{}
			public void SetWhole()
				{
					Bnd_Box2d_SetWhole(Instance);
				}
			public void SetVoid()
				{
					Bnd_Box2d_SetVoid(Instance);
				}
			public void Set(gpPnt2d P)
				{
					Bnd_Box2d_Set6203658C(Instance, P.Instance);
				}
			public void Set(gpPnt2d P,gpDir2d D)
				{
					Bnd_Box2d_Set2E9C6BD1(Instance, P.Instance, D.Instance);
				}
			public void Update(double aXmin,double aYmin,double aXmax,double aYmax)
				{
					Bnd_Box2d_UpdateC2777E0C(Instance, aXmin, aYmin, aXmax, aYmax);
				}
			public void Update(double X,double Y)
				{
					Bnd_Box2d_Update9F0E714F(Instance, X, Y);
				}
			public void Enlarge(double Tol)
				{
					Bnd_Box2d_EnlargeD82819F3(Instance, Tol);
				}
			public void Get(ref double aXmin,ref double aYmin,ref double aXmax,ref double aYmax)
				{
					Bnd_Box2d_GetC2777E0C(Instance, ref aXmin, ref aYmin, ref aXmax, ref aYmax);
				}
			public void OpenXmin()
				{
					Bnd_Box2d_OpenXmin(Instance);
				}
			public void OpenXmax()
				{
					Bnd_Box2d_OpenXmax(Instance);
				}
			public void OpenYmin()
				{
					Bnd_Box2d_OpenYmin(Instance);
				}
			public void OpenYmax()
				{
					Bnd_Box2d_OpenYmax(Instance);
				}
			public BndBox2d Transformed(gpTrsf2d T)
				{
					return new BndBox2d(Bnd_Box2d_Transformed27621DCB(Instance, T.Instance));
				}
			public void Add(BndBox2d Other)
				{
					Bnd_Box2d_Add5D98465D(Instance, Other.Instance);
				}
			public void Add(gpPnt2d P)
				{
					Bnd_Box2d_Add6203658C(Instance, P.Instance);
				}
			public void Add(gpPnt2d P,gpDir2d D)
				{
					Bnd_Box2d_Add2E9C6BD1(Instance, P.Instance, D.Instance);
				}
			public void Add(gpDir2d D)
				{
					Bnd_Box2d_Add92BBA68E(Instance, D.Instance);
				}
			public bool IsOut(gpPnt2d P)
				{
					return Bnd_Box2d_IsOut6203658C(Instance, P.Instance);
				}
			public bool IsOut(BndBox2d Other)
				{
					return Bnd_Box2d_IsOut5D98465D(Instance, Other.Instance);
				}
			public bool IsOut(BndBox2d Other,gpTrsf2d T)
				{
					return Bnd_Box2d_IsOutD639843B(Instance, Other.Instance, T.Instance);
				}
			public bool IsOut(gpTrsf2d T1,BndBox2d Other,gpTrsf2d T2)
				{
					return Bnd_Box2d_IsOutF92CC906(Instance, T1.Instance, Other.Instance, T2.Instance);
				}
			public void Dump()
				{
					Bnd_Box2d_Dump(Instance);
				}
		public double GetGap{
			get {
				return Bnd_Box2d_GetGap(Instance);
			}
		}
		public double Gap{
			set { 
				Bnd_Box2d_SetGap(Instance, value);
			}
		}
		public bool IsOpenXmin{
			get {
				return Bnd_Box2d_IsOpenXmin(Instance);
			}
		}
		public bool IsOpenXmax{
			get {
				return Bnd_Box2d_IsOpenXmax(Instance);
			}
		}
		public bool IsOpenYmin{
			get {
				return Bnd_Box2d_IsOpenYmin(Instance);
			}
		}
		public bool IsOpenYmax{
			get {
				return Bnd_Box2d_IsOpenYmax(Instance);
			}
		}
		public bool IsWhole{
			get {
				return Bnd_Box2d_IsWhole(Instance);
			}
		}
		public bool IsVoid{
			get {
				return Bnd_Box2d_IsVoid(Instance);
			}
		}
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Bnd_Box2d_Ctor();
		[DllImport("NaroOccCore.dll")]
		private static extern void Bnd_Box2d_SetWhole(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void Bnd_Box2d_SetVoid(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void Bnd_Box2d_Set6203658C(IntPtr instance, IntPtr P);
		[DllImport("NaroOccCore.dll")]
		private static extern void Bnd_Box2d_Set2E9C6BD1(IntPtr instance, IntPtr P,IntPtr D);
		[DllImport("NaroOccCore.dll")]
		private static extern void Bnd_Box2d_UpdateC2777E0C(IntPtr instance, double aXmin,double aYmin,double aXmax,double aYmax);
		[DllImport("NaroOccCore.dll")]
		private static extern void Bnd_Box2d_Update9F0E714F(IntPtr instance, double X,double Y);
		[DllImport("NaroOccCore.dll")]
		private static extern void Bnd_Box2d_EnlargeD82819F3(IntPtr instance, double Tol);
		[DllImport("NaroOccCore.dll")]
		private static extern void Bnd_Box2d_GetC2777E0C(IntPtr instance, ref double aXmin,ref double aYmin,ref double aXmax,ref double aYmax);
		[DllImport("NaroOccCore.dll")]
		private static extern void Bnd_Box2d_OpenXmin(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void Bnd_Box2d_OpenXmax(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void Bnd_Box2d_OpenYmin(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void Bnd_Box2d_OpenYmax(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Bnd_Box2d_Transformed27621DCB(IntPtr instance, IntPtr T);
		[DllImport("NaroOccCore.dll")]
		private static extern void Bnd_Box2d_Add5D98465D(IntPtr instance, IntPtr Other);
		[DllImport("NaroOccCore.dll")]
		private static extern void Bnd_Box2d_Add6203658C(IntPtr instance, IntPtr P);
		[DllImport("NaroOccCore.dll")]
		private static extern void Bnd_Box2d_Add2E9C6BD1(IntPtr instance, IntPtr P,IntPtr D);
		[DllImport("NaroOccCore.dll")]
		private static extern void Bnd_Box2d_Add92BBA68E(IntPtr instance, IntPtr D);
		[DllImport("NaroOccCore.dll")]
		private static extern bool Bnd_Box2d_IsOut6203658C(IntPtr instance, IntPtr P);
		[DllImport("NaroOccCore.dll")]
		private static extern bool Bnd_Box2d_IsOut5D98465D(IntPtr instance, IntPtr Other);
		[DllImport("NaroOccCore.dll")]
		private static extern bool Bnd_Box2d_IsOutD639843B(IntPtr instance, IntPtr Other,IntPtr T);
		[DllImport("NaroOccCore.dll")]
		private static extern bool Bnd_Box2d_IsOutF92CC906(IntPtr instance, IntPtr T1,IntPtr Other,IntPtr T2);
		[DllImport("NaroOccCore.dll")]
		private static extern void Bnd_Box2d_Dump(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern double Bnd_Box2d_GetGap(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void Bnd_Box2d_SetGap(IntPtr instance, double value);
		[DllImport("NaroOccCore.dll")]
		private static extern bool Bnd_Box2d_IsOpenXmin(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool Bnd_Box2d_IsOpenXmax(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool Bnd_Box2d_IsOpenYmin(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool Bnd_Box2d_IsOpenYmax(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool Bnd_Box2d_IsWhole(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool Bnd_Box2d_IsVoid(IntPtr instance);

		#region NativeInstancePtr Convert constructor

		public BndBox2d(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ BndBox2d_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void BndBox2d_Dtor(IntPtr instance);
	}
}
