#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;
using NaroCppCore.Occ.TopoDS;

#endregion

namespace NaroCppCore.Occ.TopoDS
{
	public class TopoDSFace : TopoDSShape
	{
		public TopoDSFace()
 :
			base(TopoDS_Face_Ctor() )
		{}
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr TopoDS_Face_Ctor();

		#region NativeInstancePtr Convert constructor

		public TopoDSFace(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ TopoDSFace_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void TopoDSFace_Dtor(IntPtr instance);
	}
}
