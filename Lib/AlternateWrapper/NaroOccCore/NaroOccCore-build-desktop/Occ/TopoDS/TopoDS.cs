#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;
using NaroCppCore.Occ.TopoDS;

#endregion

namespace NaroCppCore.Occ.TopoDS
{
	public class TopoDS : NativeInstancePtr
	{
			public static TopoDSVertex Vertex(TopoDSShape S)
				{
					return new TopoDSVertex(TopoDS_Vertex9EBAC0C0(S.Instance));
				}
			public static TopoDSEdge Edge(TopoDSShape S)
				{
					return new TopoDSEdge(TopoDS_Edge9EBAC0C0(S.Instance));
				}
			public static TopoDSWire Wire(TopoDSShape S)
				{
					return new TopoDSWire(TopoDS_Wire9EBAC0C0(S.Instance));
				}
			public static TopoDSFace Face(TopoDSShape S)
				{
			        try
			        {
                        return new TopoDSFace(TopoDS_Face9EBAC0C0(S.Instance));
			        }
			        catch (Exception)
			        {
			            return null;
			        }
				}
			public static TopoDSShell Shell(TopoDSShape S)
				{
					return new TopoDSShell(TopoDS_Shell9EBAC0C0(S.Instance));
				}
			public static TopoDSSolid Solid(TopoDSShape S)
				{
					return new TopoDSSolid(TopoDS_Solid9EBAC0C0(S.Instance));
				}
			public static TopoDSCompSolid CompSolid(TopoDSShape S)
				{
					return new TopoDSCompSolid(TopoDS_CompSolid9EBAC0C0(S.Instance));
				}
			public static TopoDSCompound Compound(TopoDSShape S)
				{
					return new TopoDSCompound(TopoDS_Compound9EBAC0C0(S.Instance));
				}
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr TopoDS_Vertex9EBAC0C0(IntPtr S);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr TopoDS_Edge9EBAC0C0(IntPtr S);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr TopoDS_Wire9EBAC0C0(IntPtr S);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr TopoDS_Face9EBAC0C0(IntPtr S);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr TopoDS_Shell9EBAC0C0(IntPtr S);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr TopoDS_Solid9EBAC0C0(IntPtr S);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr TopoDS_CompSolid9EBAC0C0(IntPtr S);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr TopoDS_Compound9EBAC0C0(IntPtr S);

		#region NativeInstancePtr Convert constructor

		public TopoDS() { } 

		public TopoDS(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ TopoDS_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void TopoDS_Dtor(IntPtr instance);
	}
}
