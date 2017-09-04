#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;
using NaroCppCore.Occ.Geom;

#endregion

namespace NaroCppCore.Occ.Geom
{
	public class GeomBoundedCurve : GeomCurve
	{

		#region NativeInstancePtr Convert constructor

		public GeomBoundedCurve() { } 

		public GeomBoundedCurve(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ GeomBoundedCurve_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void GeomBoundedCurve_Dtor(IntPtr instance);
	}
}
