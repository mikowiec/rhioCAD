#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;
using NaroCppCore.Occ.BRepBuilderAPI;
using NaroCppCore.Occ.TopoDS;

#endregion

namespace NaroCppCore.Occ.BRepBuilderAPI
{
	public class BRepBuilderAPIModifyShape : BRepBuilderAPIMakeShape
	{
			public TopoDSShape ModifiedShape(TopoDSShape S)
				{
					return new TopoDSShape(BRepBuilderAPI_ModifyShape_ModifiedShape9EBAC0C0(Instance, S.Instance));
				}
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr BRepBuilderAPI_ModifyShape_ModifiedShape9EBAC0C0(IntPtr instance, IntPtr S);

		#region NativeInstancePtr Convert constructor

		public BRepBuilderAPIModifyShape() { } 

		public BRepBuilderAPIModifyShape(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ BRepBuilderAPIModifyShape_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void BRepBuilderAPIModifyShape_Dtor(IntPtr instance);
	}
}
