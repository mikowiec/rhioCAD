#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;
using NaroCppCore.Occ.BRepBuilderAPI;
using NaroCppCore.Occ.gp;
using NaroCppCore.Occ.TopoDS;

#endregion

namespace NaroCppCore.Occ.BRepBuilderAPI
{
	public class BRepBuilderAPITransform : BRepBuilderAPIModifyShape
	{
		public BRepBuilderAPITransform(gpTrsf T)
 :
			base(BRepBuilderAPI_Transform_Ctor72D78650(T.Instance) )
		{}
		public BRepBuilderAPITransform(TopoDSShape S,gpTrsf T,bool Copy)
 :
			base(BRepBuilderAPI_Transform_CtorE2FB96F1(S.Instance, T.Instance, Copy) )
		{}
			public void Perform(TopoDSShape S,bool Copy)
				{
					BRepBuilderAPI_Transform_Perform5E7DD5C8(Instance, S.Instance, Copy);
				}
			public TopoDSShape ModifiedShape(TopoDSShape S)
				{
					return new TopoDSShape(BRepBuilderAPI_Transform_ModifiedShape9EBAC0C0(Instance, S.Instance));
				}
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr BRepBuilderAPI_Transform_Ctor72D78650(IntPtr T);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr BRepBuilderAPI_Transform_CtorE2FB96F1(IntPtr S,IntPtr T,bool Copy);
		[DllImport("NaroOccCore.dll")]
		private static extern void BRepBuilderAPI_Transform_Perform5E7DD5C8(IntPtr instance, IntPtr S,bool Copy);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr BRepBuilderAPI_Transform_ModifiedShape9EBAC0C0(IntPtr instance, IntPtr S);

		#region NativeInstancePtr Convert constructor

		public BRepBuilderAPITransform() { } 

		public BRepBuilderAPITransform(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ BRepBuilderAPITransform_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void BRepBuilderAPITransform_Dtor(IntPtr instance);
	}
}
