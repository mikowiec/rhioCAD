#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;
using NaroCppCore.Occ.TopoDS;

#endregion

namespace NaroCppCore.Occ.TopoDS
{
	public class TopoDSCompound : TopoDSShape
	{
		public TopoDSCompound()
 :
			base(TopoDS_Compound_Ctor() )
		{}
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr TopoDS_Compound_Ctor();

		#region NativeInstancePtr Convert constructor

		public TopoDSCompound(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ TopoDSCompound_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void TopoDSCompound_Dtor(IntPtr instance);
	}
}
