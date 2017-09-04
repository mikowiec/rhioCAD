#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;
using NaroCppCore.Occ.StepGeom;

#endregion

namespace NaroCppCore.Occ.StepGeom
{
	public class StepGeomBoundedCurve : StepGeomCurve
	{
		public StepGeomBoundedCurve()
 :
			base(StepGeom_BoundedCurve_Ctor() )
		{}
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr StepGeom_BoundedCurve_Ctor();

		#region NativeInstancePtr Convert constructor

		public StepGeomBoundedCurve(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ StepGeomBoundedCurve_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void StepGeomBoundedCurve_Dtor(IntPtr instance);
	}
}
