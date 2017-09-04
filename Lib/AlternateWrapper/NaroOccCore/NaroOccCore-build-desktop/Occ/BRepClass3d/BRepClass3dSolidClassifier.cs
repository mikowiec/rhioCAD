#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;
using NaroCppCore.Occ.BRepClass3d;
using NaroCppCore.Occ.TopoDS;
using NaroCppCore.Occ.gp;

#endregion

namespace NaroCppCore.Occ.BRepClass3d
{
	public class BRepClass3dSolidClassifier : BRepClass3dSClassifier
	{
		public BRepClass3dSolidClassifier()
 :
			base(BRepClass3d_SolidClassifier_Ctor() )
		{}
		public BRepClass3dSolidClassifier(TopoDSShape S)
 :
			base(BRepClass3d_SolidClassifier_Ctor9EBAC0C0(S.Instance) )
		{}
		public BRepClass3dSolidClassifier(TopoDSShape S,gpPnt P,double Tol)
 :
			base(BRepClass3d_SolidClassifier_CtorAB62C26C(S.Instance, P.Instance, Tol) )
		{}
			public void Load(TopoDSShape S)
				{
					BRepClass3d_SolidClassifier_Load9EBAC0C0(Instance, S.Instance);
				}
			public void Perform(gpPnt P,double Tol)
				{
					BRepClass3d_SolidClassifier_PerformF0D1E3E6(Instance, P.Instance, Tol);
				}
			public void PerformInfinitePoint(double Tol)
				{
					BRepClass3d_SolidClassifier_PerformInfinitePointD82819F3(Instance, Tol);
				}
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr BRepClass3d_SolidClassifier_Ctor();
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr BRepClass3d_SolidClassifier_Ctor9EBAC0C0(IntPtr S);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr BRepClass3d_SolidClassifier_CtorAB62C26C(IntPtr S,IntPtr P,double Tol);
		[DllImport("NaroOccCore.dll")]
		private static extern void BRepClass3d_SolidClassifier_Load9EBAC0C0(IntPtr instance, IntPtr S);
		[DllImport("NaroOccCore.dll")]
		private static extern void BRepClass3d_SolidClassifier_PerformF0D1E3E6(IntPtr instance, IntPtr P,double Tol);
		[DllImport("NaroOccCore.dll")]
		private static extern void BRepClass3d_SolidClassifier_PerformInfinitePointD82819F3(IntPtr instance, double Tol);

		#region NativeInstancePtr Convert constructor

		public BRepClass3dSolidClassifier(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ BRepClass3dSolidClassifier_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void BRepClass3dSolidClassifier_Dtor(IntPtr instance);
	}
}
