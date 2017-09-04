#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;
using NaroCppCore.Occ.TopoDS;
using NaroCppCore.Occ.GeomAbs;
using NaroCppCore.Occ.TopTools;

#endregion

namespace NaroCppCore.Occ.BRepAlgo
{
	public class BRepAlgo : NativeInstancePtr
	{
			public static TopoDSWire ConcatenateWire(TopoDSWire Wire,GeomAbsShape Option,double AngularTolerance)
				{
					return new TopoDSWire(BRepAlgo_ConcatenateWireB2333A01(Wire.Instance, (int)Option, AngularTolerance));
				}
			public static bool IsValid(TopoDSShape S)
				{
					return BRepAlgo_IsValid9EBAC0C0(S.Instance);
				}
			public static bool IsValid(TopToolsListOfShape theArgs,TopoDSShape theResult,bool closedSolid,bool GeomCtrl)
				{
					return BRepAlgo_IsValid49B662F1(theArgs.Instance, theResult.Instance, closedSolid, GeomCtrl);
				}
			public static bool IsTopologicallyValid(TopoDSShape S)
				{
					return BRepAlgo_IsTopologicallyValid9EBAC0C0(S.Instance);
				}
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr BRepAlgo_ConcatenateWireB2333A01(IntPtr Wire,int Option,double AngularTolerance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool BRepAlgo_IsValid9EBAC0C0(IntPtr S);
		[DllImport("NaroOccCore.dll")]
		private static extern bool BRepAlgo_IsValid49B662F1(IntPtr theArgs,IntPtr theResult,bool closedSolid,bool GeomCtrl);
		[DllImport("NaroOccCore.dll")]
		private static extern bool BRepAlgo_IsTopologicallyValid9EBAC0C0(IntPtr S);

		#region NativeInstancePtr Convert constructor

		public BRepAlgo() { } 

		public BRepAlgo(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ BRepAlgo_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void BRepAlgo_Dtor(IntPtr instance);
	}
}
