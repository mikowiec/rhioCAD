#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;
using NaroCppCore.Occ.gce;
using NaroCppCore.Occ.gp;

#endregion

namespace NaroCppCore.Occ.gce
{
	public class gceMakeLin : gceRoot
	{
		public gceMakeLin(gpAx1 A1)
 :
			base(gce_MakeLin_Ctor608B963B(A1.Instance) )
		{}
		public gceMakeLin(gpPnt P,gpDir V)
 :
			base(gce_MakeLin_CtorE13B639C(P.Instance, V.Instance) )
		{}
		public gceMakeLin(gpLin Lin,gpPnt Point)
 :
			base(gce_MakeLin_Ctor1CB0FB3C(Lin.Instance, Point.Instance) )
		{}
		public gceMakeLin(gpPnt P1,gpPnt P2)
 :
			base(gce_MakeLin_Ctor5C63477E(P1.Instance, P2.Instance) )
		{}
		public gpLin Value{
			get {
				return new gpLin(gce_MakeLin_Value(Instance));
			}
		}
		public gpLin Operator{
			get {
				return new gpLin(gce_MakeLin_Operator(Instance));
			}
		}
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gce_MakeLin_Ctor608B963B(IntPtr A1);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gce_MakeLin_CtorE13B639C(IntPtr P,IntPtr V);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gce_MakeLin_Ctor1CB0FB3C(IntPtr Lin,IntPtr Point);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gce_MakeLin_Ctor5C63477E(IntPtr P1,IntPtr P2);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gce_MakeLin_Value(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gce_MakeLin_Operator(IntPtr instance);

		#region NativeInstancePtr Convert constructor

		public gceMakeLin() { } 

		public gceMakeLin(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ gceMakeLin_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void gceMakeLin_Dtor(IntPtr instance);
	}
}
