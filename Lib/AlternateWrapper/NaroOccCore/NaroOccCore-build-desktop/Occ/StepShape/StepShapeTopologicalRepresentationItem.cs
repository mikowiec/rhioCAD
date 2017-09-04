#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;

#endregion

namespace NaroCppCore.Occ.StepShape
{
	public class StepShapeTopologicalRepresentationItem : NativeInstancePtr
	{
		public StepShapeTopologicalRepresentationItem()
 :
			base(StepShape_TopologicalRepresentationItem_Ctor() )
		{}
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr StepShape_TopologicalRepresentationItem_Ctor();

		#region NativeInstancePtr Convert constructor

		public StepShapeTopologicalRepresentationItem(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ StepShapeTopologicalRepresentationItem_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void StepShapeTopologicalRepresentationItem_Dtor(IntPtr instance);
	}
}
