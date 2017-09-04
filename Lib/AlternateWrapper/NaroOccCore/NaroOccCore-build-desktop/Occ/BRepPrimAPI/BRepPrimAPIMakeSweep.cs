#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;
using NaroCppCore.Occ.BRepBuilderAPI;

#endregion

namespace NaroCppCore.Occ.BRepPrimAPI
{
	public class BRepPrimAPIMakeSweep : BRepBuilderAPIMakeShape
	{

		#region NativeInstancePtr Convert constructor

		public BRepPrimAPIMakeSweep() { } 

		public BRepPrimAPIMakeSweep(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ BRepPrimAPIMakeSweep_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void BRepPrimAPIMakeSweep_Dtor(IntPtr instance);
	}
}
