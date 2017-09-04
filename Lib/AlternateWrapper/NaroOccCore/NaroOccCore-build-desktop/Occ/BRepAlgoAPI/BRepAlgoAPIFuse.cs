#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;
using NaroCppCore.Occ.BRepAlgoAPI;
using NaroCppCore.Occ.TopoDS;
using NaroCppCore.Occ.BOPTools;

#endregion

namespace NaroCppCore.Occ.BRepAlgoAPI
{
	public class BRepAlgoAPIFuse : BRepAlgoAPIBooleanOperation
	{
		public BRepAlgoAPIFuse(TopoDSShape S1,TopoDSShape S2)
 :
			base(BRepAlgoAPI_Fuse_Ctor877A736F(S1.Instance, S2.Instance) )
		{}
		public BRepAlgoAPIFuse(TopoDSShape S1,TopoDSShape S2,BOPToolsDSFiller aDSF)
 :
			base(BRepAlgoAPI_Fuse_Ctor1641F7D4(S1.Instance, S2.Instance, aDSF.Instance) )
		{}
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr BRepAlgoAPI_Fuse_Ctor877A736F(IntPtr S1,IntPtr S2);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr BRepAlgoAPI_Fuse_Ctor1641F7D4(IntPtr S1,IntPtr S2,IntPtr aDSF);

		#region NativeInstancePtr Convert constructor

		public BRepAlgoAPIFuse() { } 

		public BRepAlgoAPIFuse(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ BRepAlgoAPIFuse_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void BRepAlgoAPIFuse_Dtor(IntPtr instance);
	}
}
