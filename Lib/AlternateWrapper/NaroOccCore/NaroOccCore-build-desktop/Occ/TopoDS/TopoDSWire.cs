#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;
using NaroCppCore.Occ.TopoDS;

#endregion

namespace NaroCppCore.Occ.TopoDS
{
	public class TopoDSWire : TopoDSShape
	{
		public TopoDSWire()
 :
			base(TopoDS_Wire_Ctor() )
		{}
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr TopoDS_Wire_Ctor();

		#region NativeInstancePtr Convert constructor

		public TopoDSWire(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ TopoDSWire_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void TopoDSWire_Dtor(IntPtr instance);
	}
}
