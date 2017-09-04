#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;
using NaroCppCore.Occ.BRepBuilderAPI;
using NaroCppCore.Occ.TopoDS;
using NaroCppCore.Occ.gp;

#endregion

namespace NaroCppCore.Occ.BRepBuilderAPI
{
	public class BRepBuilderAPIMakeVertex : BRepBuilderAPIMakeShape
	{
		public BRepBuilderAPIMakeVertex(gpPnt P)
 :
			base(BRepBuilderAPI_MakeVertex_Ctor9EAECD5B(P.Instance) )
		{}
		public TopoDSVertex Vertex{
			get {
				return new TopoDSVertex(BRepBuilderAPI_MakeVertex_Vertex(Instance));
			}
		}
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr BRepBuilderAPI_MakeVertex_Ctor9EAECD5B(IntPtr P);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr BRepBuilderAPI_MakeVertex_Vertex(IntPtr instance);

		#region NativeInstancePtr Convert constructor

		public BRepBuilderAPIMakeVertex() { } 

		public BRepBuilderAPIMakeVertex(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ BRepBuilderAPIMakeVertex_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void BRepBuilderAPIMakeVertex_Dtor(IntPtr instance);
	}
}
