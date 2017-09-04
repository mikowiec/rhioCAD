#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;
using NaroCppCore.Occ.BRepBuilderAPI;
using NaroCppCore.Occ.TopoDS;

#endregion

namespace NaroCppCore.Occ.BRepOffsetAPI
{
	public class BRepOffsetAPIMiddlePath : BRepBuilderAPIMakeShape
	{
		public BRepOffsetAPIMiddlePath(TopoDSShape aShape,TopoDSShape StartShape,TopoDSShape EndShape)
 :
			base(BRepOffsetAPI_MiddlePath_Ctor5887D0C7(aShape.Instance, StartShape.Instance, EndShape.Instance) )
		{}
			public void Build()
				{
					BRepOffsetAPI_MiddlePath_Build(Instance);
				}
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr BRepOffsetAPI_MiddlePath_Ctor5887D0C7(IntPtr aShape,IntPtr StartShape,IntPtr EndShape);
		[DllImport("NaroOccCore.dll")]
		private static extern void BRepOffsetAPI_MiddlePath_Build(IntPtr instance);

		#region NativeInstancePtr Convert constructor

		public BRepOffsetAPIMiddlePath() { } 

		public BRepOffsetAPIMiddlePath(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ BRepOffsetAPIMiddlePath_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void BRepOffsetAPIMiddlePath_Dtor(IntPtr instance);
	}
}
