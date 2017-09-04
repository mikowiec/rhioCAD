#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;
using NaroCppCore.Occ.TopoDS;

#endregion

namespace NaroCppCore.Occ.TopoDS
{
	public class TopoDSVertex : TopoDSShape
	{
		public TopoDSVertex()
 :
			base(TopoDS_Vertex_Ctor() )
		{}
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr TopoDS_Vertex_Ctor();

		#region NativeInstancePtr Convert constructor

		public TopoDSVertex(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ TopoDSVertex_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void TopoDSVertex_Dtor(IntPtr instance);
	}
}
