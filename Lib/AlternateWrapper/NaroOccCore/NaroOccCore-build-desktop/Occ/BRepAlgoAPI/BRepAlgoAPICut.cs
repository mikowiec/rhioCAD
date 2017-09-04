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
	public class BRepAlgoAPICut : BRepAlgoAPIBooleanOperation
	{
		public BRepAlgoAPICut(TopoDSShape S1,TopoDSShape S2)
 :
			base(BRepAlgoAPI_Cut_Ctor877A736F(S1.Instance, S2.Instance) )
		{}
		public BRepAlgoAPICut(TopoDSShape S1,TopoDSShape S2,BOPToolsDSFiller aDSF,bool bFWD)
 :
			base(BRepAlgoAPI_Cut_Ctor421BE7CD(S1.Instance, S2.Instance, aDSF.Instance, bFWD) )
		{}
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr BRepAlgoAPI_Cut_Ctor877A736F(IntPtr S1,IntPtr S2);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr BRepAlgoAPI_Cut_Ctor421BE7CD(IntPtr S1,IntPtr S2,IntPtr aDSF,bool bFWD);

		#region NativeInstancePtr Convert constructor

		public BRepAlgoAPICut() { } 

		public BRepAlgoAPICut(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ BRepAlgoAPICut_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void BRepAlgoAPICut_Dtor(IntPtr instance);
	}
}
