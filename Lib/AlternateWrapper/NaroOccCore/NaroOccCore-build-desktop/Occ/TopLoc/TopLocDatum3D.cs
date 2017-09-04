#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;
using NaroCppCore.Occ.MMgt;
using NaroCppCore.Occ.gp;

#endregion

namespace NaroCppCore.Occ.TopLoc
{
	public class TopLocDatum3D : MMgtTShared
	{
		public TopLocDatum3D()
 :
			base(TopLoc_Datum3D_Ctor() )
		{}
		public TopLocDatum3D(gpTrsf T)
 :
			base(TopLoc_Datum3D_Ctor72D78650(T.Instance) )
		{}
		public gpTrsf Transformation{
			get {
				return new gpTrsf(TopLoc_Datum3D_Transformation(Instance));
			}
		}
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr TopLoc_Datum3D_Ctor();
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr TopLoc_Datum3D_Ctor72D78650(IntPtr T);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr TopLoc_Datum3D_Transformation(IntPtr instance);

		#region NativeInstancePtr Convert constructor

		public TopLocDatum3D(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ TopLocDatum3D_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void TopLocDatum3D_Dtor(IntPtr instance);
	}
}
