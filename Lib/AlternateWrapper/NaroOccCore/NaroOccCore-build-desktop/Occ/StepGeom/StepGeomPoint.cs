#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;
using NaroCppCore.Occ.StepGeom;

#endregion

namespace NaroCppCore.Occ.StepGeom
{
	public class StepGeomPoint : StepGeomGeometricRepresentationItem
	{
		public StepGeomPoint()
 :
			base(StepGeom_Point_Ctor() )
		{}
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr StepGeom_Point_Ctor();

		#region NativeInstancePtr Convert constructor

		public StepGeomPoint(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ StepGeomPoint_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void StepGeomPoint_Dtor(IntPtr instance);
	}
}
