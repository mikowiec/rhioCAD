#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;
using NaroCppCore.Occ.StepGeom;

#endregion

namespace NaroCppCore.Occ.StepGeom
{
	public class StepGeomCurve : StepGeomGeometricRepresentationItem
	{
		public StepGeomCurve()
 :
			base(StepGeom_Curve_Ctor() )
		{}
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr StepGeom_Curve_Ctor();

		#region NativeInstancePtr Convert constructor

		public StepGeomCurve(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ StepGeomCurve_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void StepGeomCurve_Dtor(IntPtr instance);
	}
}
