#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;

#endregion

namespace NaroCppCore.Occ.StepGeom
{
	public class StepGeomGeometricRepresentationItem : NativeInstancePtr
	{
		public StepGeomGeometricRepresentationItem()
 :
			base(StepGeom_GeometricRepresentationItem_Ctor() )
		{}
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr StepGeom_GeometricRepresentationItem_Ctor();

		#region NativeInstancePtr Convert constructor

		public StepGeomGeometricRepresentationItem(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ StepGeomGeometricRepresentationItem_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void StepGeomGeometricRepresentationItem_Dtor(IntPtr instance);
	}
}
