#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;
using NaroCppCore.Occ.BRepBuilderAPI;
using NaroCppCore.Occ.TopoDS;

#endregion

namespace NaroCppCore.Occ.BRepBuilderAPI
{
	public class BRepBuilderAPIMakeShape : BRepBuilderAPICommand
	{
			public void Delete()
				{
					BRepBuilderAPI_MakeShape_Delete(Instance);
				}
			public void Build()
				{
					BRepBuilderAPI_MakeShape_Build(Instance);
				}
			public bool IsDeleted(TopoDSShape S)
				{
					return BRepBuilderAPI_MakeShape_IsDeleted9EBAC0C0(Instance, S.Instance);
				}
		public TopoDSShape Shape{
			get {
				return new TopoDSShape(BRepBuilderAPI_MakeShape_Shape(Instance));
			}
		}
		[DllImport("NaroOccCore.dll")]
		private static extern void BRepBuilderAPI_MakeShape_Delete(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void BRepBuilderAPI_MakeShape_Build(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool BRepBuilderAPI_MakeShape_IsDeleted9EBAC0C0(IntPtr instance, IntPtr S);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr BRepBuilderAPI_MakeShape_Shape(IntPtr instance);

		#region NativeInstancePtr Convert constructor

		public BRepBuilderAPIMakeShape() { } 

		public BRepBuilderAPIMakeShape(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ BRepBuilderAPIMakeShape_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void BRepBuilderAPIMakeShape_Dtor(IntPtr instance);
	}
}
