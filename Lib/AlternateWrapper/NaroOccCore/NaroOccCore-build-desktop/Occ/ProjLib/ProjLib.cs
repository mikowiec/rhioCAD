#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;
using NaroCppCore.Occ.gp;

#endregion

namespace NaroCppCore.Occ.ProjLib
{
	public class ProjLib : NativeInstancePtr
	{
			public static gpPnt2d Project(gpPln Pl,gpPnt P)
				{
					return new gpPnt2d(ProjLib_Project10B48A70(Pl.Instance, P.Instance));
				}
			public static gpLin2d Project(gpPln Pl,gpLin L)
				{
					return new gpLin2d(ProjLib_Project1626C982(Pl.Instance, L.Instance));
				}
			public static gpCirc2d Project(gpPln Pl,gpCirc C)
				{
					return new gpCirc2d(ProjLib_Project13B7CC27(Pl.Instance, C.Instance));
				}
			public static gpElips2d Project(gpPln Pl,gpElips E)
				{
					return new gpElips2d(ProjLib_ProjectEB568F0D(Pl.Instance, E.Instance));
				}
			public static gpParab2d Project(gpPln Pl,gpParab P)
				{
					return new gpParab2d(ProjLib_ProjectDE13DD50(Pl.Instance, P.Instance));
				}
			public static gpHypr2d Project(gpPln Pl,gpHypr H)
				{
					return new gpHypr2d(ProjLib_ProjectEAC29BEC(Pl.Instance, H.Instance));
				}
			public static gpPnt2d Project(gpCylinder Cy,gpPnt P)
				{
					return new gpPnt2d(ProjLib_ProjectFA59BDF6(Cy.Instance, P.Instance));
				}
			public static gpLin2d Project(gpCylinder Cy,gpLin L)
				{
					return new gpLin2d(ProjLib_ProjectDE57BDFB(Cy.Instance, L.Instance));
				}
			public static gpLin2d Project(gpCylinder Cy,gpCirc Ci)
				{
					return new gpLin2d(ProjLib_ProjectED02D9F7(Cy.Instance, Ci.Instance));
				}
			public static gpPnt2d Project(gpCone Co,gpPnt P)
				{
					return new gpPnt2d(ProjLib_ProjectF81943F5(Co.Instance, P.Instance));
				}
			public static gpLin2d Project(gpCone Co,gpLin L)
				{
					return new gpLin2d(ProjLib_Project80DF43EE(Co.Instance, L.Instance));
				}
			public static gpLin2d Project(gpCone Co,gpCirc Ci)
				{
					return new gpLin2d(ProjLib_ProjectA92F9F7D(Co.Instance, Ci.Instance));
				}
			public static gpPnt2d Project(gpSphere Sp,gpPnt P)
				{
					return new gpPnt2d(ProjLib_Project1377F951(Sp.Instance, P.Instance));
				}
			public static gpLin2d Project(gpSphere Sp,gpCirc Ci)
				{
					return new gpLin2d(ProjLib_Project4CF82905(Sp.Instance, Ci.Instance));
				}
			public static gpPnt2d Project(gpTorus To,gpPnt P)
				{
					return new gpPnt2d(ProjLib_ProjectA0BA3DF1(To.Instance, P.Instance));
				}
			public static gpLin2d Project(gpTorus To,gpCirc Ci)
				{
					return new gpLin2d(ProjLib_ProjectB747273A(To.Instance, Ci.Instance));
				}
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr ProjLib_Project10B48A70(IntPtr Pl,IntPtr P);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr ProjLib_Project1626C982(IntPtr Pl,IntPtr L);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr ProjLib_Project13B7CC27(IntPtr Pl,IntPtr C);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr ProjLib_ProjectEB568F0D(IntPtr Pl,IntPtr E);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr ProjLib_ProjectDE13DD50(IntPtr Pl,IntPtr P);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr ProjLib_ProjectEAC29BEC(IntPtr Pl,IntPtr H);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr ProjLib_ProjectFA59BDF6(IntPtr Cy,IntPtr P);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr ProjLib_ProjectDE57BDFB(IntPtr Cy,IntPtr L);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr ProjLib_ProjectED02D9F7(IntPtr Cy,IntPtr Ci);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr ProjLib_ProjectF81943F5(IntPtr Co,IntPtr P);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr ProjLib_Project80DF43EE(IntPtr Co,IntPtr L);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr ProjLib_ProjectA92F9F7D(IntPtr Co,IntPtr Ci);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr ProjLib_Project1377F951(IntPtr Sp,IntPtr P);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr ProjLib_Project4CF82905(IntPtr Sp,IntPtr Ci);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr ProjLib_ProjectA0BA3DF1(IntPtr To,IntPtr P);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr ProjLib_ProjectB747273A(IntPtr To,IntPtr Ci);

		#region NativeInstancePtr Convert constructor

		public ProjLib() { } 

		public ProjLib(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ ProjLib_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void ProjLib_Dtor(IntPtr instance);
	}
}
