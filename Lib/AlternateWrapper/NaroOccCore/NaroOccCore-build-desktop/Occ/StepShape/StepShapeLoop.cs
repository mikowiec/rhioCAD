#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;
using NaroCppCore.Occ.StepShape;

#endregion

namespace NaroCppCore.Occ.StepShape
{
	public class StepShapeLoop : StepShapeTopologicalRepresentationItem
	{
		public StepShapeLoop()
 :
			base(StepShape_Loop_Ctor() )
		{}
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr StepShape_Loop_Ctor();

		#region NativeInstancePtr Convert constructor

		public StepShapeLoop(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ StepShapeLoop_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void StepShapeLoop_Dtor(IntPtr instance);
	}
}
