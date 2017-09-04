#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;
using NaroCppCore.Occ.MMgt;

#endregion

namespace NaroCppCore.Occ.TopoDS
{
	public class TopoDSTShape : MMgtTShared
	{
			public bool Free()
				{
					return TopoDS_TShape_Free(Instance);
				}
			public void Free(bool F)
				{
					TopoDS_TShape_Free461FC46A(Instance, F);
				}
			public bool Modified()
				{
					return TopoDS_TShape_Modified(Instance);
				}
			public void Modified(bool M)
				{
					TopoDS_TShape_Modified461FC46A(Instance, M);
				}
			public bool Checked()
				{
					return TopoDS_TShape_Checked(Instance);
				}
			public void Checked(bool C)
				{
					TopoDS_TShape_Checked461FC46A(Instance, C);
				}
			public bool Orientable()
				{
					return TopoDS_TShape_Orientable(Instance);
				}
			public void Orientable(bool C)
				{
					TopoDS_TShape_Orientable461FC46A(Instance, C);
				}
			public bool Closed()
				{
					return TopoDS_TShape_Closed(Instance);
				}
			public void Closed(bool C)
				{
					TopoDS_TShape_Closed461FC46A(Instance, C);
				}
			public bool Infinite()
				{
					return TopoDS_TShape_Infinite(Instance);
				}
			public void Infinite(bool C)
				{
					TopoDS_TShape_Infinite461FC46A(Instance, C);
				}
			public bool Convex()
				{
					return TopoDS_TShape_Convex(Instance);
				}
			public void Convex(bool C)
				{
					TopoDS_TShape_Convex461FC46A(Instance, C);
				}
		[DllImport("NaroOccCore.dll")]
		private static extern bool TopoDS_TShape_Free(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void TopoDS_TShape_Free461FC46A(IntPtr instance, bool F);
		[DllImport("NaroOccCore.dll")]
		private static extern bool TopoDS_TShape_Modified(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void TopoDS_TShape_Modified461FC46A(IntPtr instance, bool M);
		[DllImport("NaroOccCore.dll")]
		private static extern bool TopoDS_TShape_Checked(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void TopoDS_TShape_Checked461FC46A(IntPtr instance, bool C);
		[DllImport("NaroOccCore.dll")]
		private static extern bool TopoDS_TShape_Orientable(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void TopoDS_TShape_Orientable461FC46A(IntPtr instance, bool C);
		[DllImport("NaroOccCore.dll")]
		private static extern bool TopoDS_TShape_Closed(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void TopoDS_TShape_Closed461FC46A(IntPtr instance, bool C);
		[DllImport("NaroOccCore.dll")]
		private static extern bool TopoDS_TShape_Infinite(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void TopoDS_TShape_Infinite461FC46A(IntPtr instance, bool C);
		[DllImport("NaroOccCore.dll")]
		private static extern bool TopoDS_TShape_Convex(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void TopoDS_TShape_Convex461FC46A(IntPtr instance, bool C);

		#region NativeInstancePtr Convert constructor

		public TopoDSTShape() { } 

		public TopoDSTShape(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ TopoDSTShape_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void TopoDSTShape_Dtor(IntPtr instance);
	}
}
