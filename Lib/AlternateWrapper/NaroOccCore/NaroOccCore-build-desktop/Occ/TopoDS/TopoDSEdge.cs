#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;
using NaroCppCore.Occ.TopoDS;

#endregion

namespace NaroCppCore.Occ.TopoDS
{
	public class TopoDSEdge : TopoDSShape
	{
		public TopoDSEdge()
 :
			base(TopoDS_Edge_Ctor() )
		{}
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr TopoDS_Edge_Ctor();

		#region NativeInstancePtr Convert constructor

		public TopoDSEdge(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ TopoDSEdge_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void TopoDSEdge_Dtor(IntPtr instance);
	}
}
