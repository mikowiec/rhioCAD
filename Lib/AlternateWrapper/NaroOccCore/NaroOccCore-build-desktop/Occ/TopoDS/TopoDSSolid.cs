#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;
using NaroCppCore.Occ.TopoDS;

#endregion

namespace NaroCppCore.Occ.TopoDS
{
	public class TopoDSSolid : TopoDSShape
	{
		public TopoDSSolid()
 :
			base(TopoDS_Solid_Ctor() )
		{}
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr TopoDS_Solid_Ctor();

		#region NativeInstancePtr Convert constructor

		public TopoDSSolid(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ TopoDSSolid_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void TopoDSSolid_Dtor(IntPtr instance);
	}
}
