#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;
using NaroCppCore.Occ.StepGeom;

#endregion

namespace NaroCppCore.Occ.StepGeom
{
	public class StepGeomSurface : StepGeomGeometricRepresentationItem
	{
		public StepGeomSurface()
 :
			base(StepGeom_Surface_Ctor() )
		{}
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr StepGeom_Surface_Ctor();

		#region NativeInstancePtr Convert constructor

		public StepGeomSurface(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ StepGeomSurface_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void StepGeomSurface_Dtor(IntPtr instance);
	}
}
