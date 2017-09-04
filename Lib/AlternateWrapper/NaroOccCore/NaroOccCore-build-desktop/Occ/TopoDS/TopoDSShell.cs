#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;
using NaroCppCore.Occ.TopoDS;

#endregion

namespace NaroCppCore.Occ.TopoDS
{
	public class TopoDSShell : TopoDSShape
	{
		public TopoDSShell()
 :
			base(TopoDS_Shell_Ctor() )
		{}
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr TopoDS_Shell_Ctor();

		#region NativeInstancePtr Convert constructor

		public TopoDSShell(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ TopoDSShell_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void TopoDSShell_Dtor(IntPtr instance);
	}
}
