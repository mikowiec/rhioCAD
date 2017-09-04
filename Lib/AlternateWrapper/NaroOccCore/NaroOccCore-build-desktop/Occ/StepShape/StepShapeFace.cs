#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;
using NaroCppCore.Occ.StepShape;

#endregion

namespace NaroCppCore.Occ.StepShape
{
	public class StepShapeFace : StepShapeTopologicalRepresentationItem
	{
		public StepShapeFace()
 :
			base(StepShape_Face_Ctor() )
		{}
		public int NbBounds{
			get {
				return StepShape_Face_NbBounds(Instance);
			}
		}
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr StepShape_Face_Ctor();
		[DllImport("NaroOccCore.dll")]
		private static extern int StepShape_Face_NbBounds(IntPtr instance);

		#region NativeInstancePtr Convert constructor

		public StepShapeFace(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ StepShapeFace_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void StepShapeFace_Dtor(IntPtr instance);
	}
}
