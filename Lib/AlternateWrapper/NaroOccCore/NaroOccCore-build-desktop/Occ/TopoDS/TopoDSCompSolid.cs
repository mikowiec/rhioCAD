#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;
using NaroCppCore.Occ.TopoDS;

#endregion

namespace NaroCppCore.Occ.TopoDS
{
	public class TopoDSCompSolid : TopoDSShape
	{
		public TopoDSCompSolid()
 :
			base(TopoDS_CompSolid_Ctor() )
		{}
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr TopoDS_CompSolid_Ctor();

		#region NativeInstancePtr Convert constructor

		public TopoDSCompSolid(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ TopoDSCompSolid_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void TopoDSCompSolid_Dtor(IntPtr instance);
	}
}
