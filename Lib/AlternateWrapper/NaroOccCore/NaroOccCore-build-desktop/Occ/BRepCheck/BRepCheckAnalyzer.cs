#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;
using NaroCppCore.Occ.TopoDS;

#endregion

namespace NaroCppCore.Occ.BRepCheck
{
	public class BRepCheckAnalyzer : NativeInstancePtr
	{
		public BRepCheckAnalyzer(TopoDSShape S,bool GeomControls)
 :
			base(BRepCheck_Analyzer_Ctor5E7DD5C8(S.Instance, GeomControls) )
		{}
			public void Init(TopoDSShape S,bool GeomControls)
				{
					BRepCheck_Analyzer_Init5E7DD5C8(Instance, S.Instance, GeomControls);
				}
			public bool IsValid(TopoDSShape S)
				{
					return BRepCheck_Analyzer_IsValid9EBAC0C0(Instance, S.Instance);
				}
			public bool IsValid()
				{
					return BRepCheck_Analyzer_IsValid(Instance);
				}
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr BRepCheck_Analyzer_Ctor5E7DD5C8(IntPtr S,bool GeomControls);
		[DllImport("NaroOccCore.dll")]
		private static extern void BRepCheck_Analyzer_Init5E7DD5C8(IntPtr instance, IntPtr S,bool GeomControls);
		[DllImport("NaroOccCore.dll")]
		private static extern bool BRepCheck_Analyzer_IsValid9EBAC0C0(IntPtr instance, IntPtr S);
		[DllImport("NaroOccCore.dll")]
		private static extern bool BRepCheck_Analyzer_IsValid(IntPtr instance);

		#region NativeInstancePtr Convert constructor

		public BRepCheckAnalyzer() { } 

		public BRepCheckAnalyzer(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ BRepCheckAnalyzer_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void BRepCheckAnalyzer_Dtor(IntPtr instance);
	}
}
