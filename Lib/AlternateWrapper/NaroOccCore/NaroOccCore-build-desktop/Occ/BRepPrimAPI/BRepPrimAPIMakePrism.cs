#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;
using NaroCppCore.Occ.BRepPrimAPI;
using NaroCppCore.Occ.TopoDS;
using NaroCppCore.Occ.gp;

#endregion

namespace NaroCppCore.Occ.BRepPrimAPI
{
	public class BRepPrimAPIMakePrism : BRepPrimAPIMakeSweep
	{
		public BRepPrimAPIMakePrism(TopoDSShape S,gpVec V,bool Copy,bool Canonize)
 :
			base(BRepPrimAPI_MakePrism_CtorDCCCD2D4(S.Instance, V.Instance, Copy, Canonize) )
		{}
		public BRepPrimAPIMakePrism(TopoDSShape S,gpDir D,bool Inf,bool Copy,bool Canonize)
 :
			base(BRepPrimAPI_MakePrism_Ctor6CDB262A(S.Instance, D.Instance, Inf, Copy, Canonize) )
		{}
			public void Build()
				{
					BRepPrimAPI_MakePrism_Build(Instance);
				}
			public TopoDSShape FirstShape()
				{
					return new TopoDSShape(BRepPrimAPI_MakePrism_FirstShape(Instance));
				}
			public TopoDSShape LastShape()
				{
					return new TopoDSShape(BRepPrimAPI_MakePrism_LastShape(Instance));
				}
			public TopoDSShape FirstShape(TopoDSShape theShape)
				{
					return new TopoDSShape(BRepPrimAPI_MakePrism_FirstShape9EBAC0C0(Instance, theShape.Instance));
				}
			public TopoDSShape LastShape(TopoDSShape theShape)
				{
					return new TopoDSShape(BRepPrimAPI_MakePrism_LastShape9EBAC0C0(Instance, theShape.Instance));
				}
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr BRepPrimAPI_MakePrism_CtorDCCCD2D4(IntPtr S,IntPtr V,bool Copy,bool Canonize);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr BRepPrimAPI_MakePrism_Ctor6CDB262A(IntPtr S,IntPtr D,bool Inf,bool Copy,bool Canonize);
		[DllImport("NaroOccCore.dll")]
		private static extern void BRepPrimAPI_MakePrism_Build(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr BRepPrimAPI_MakePrism_FirstShape(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr BRepPrimAPI_MakePrism_LastShape(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr BRepPrimAPI_MakePrism_FirstShape9EBAC0C0(IntPtr instance, IntPtr theShape);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr BRepPrimAPI_MakePrism_LastShape9EBAC0C0(IntPtr instance, IntPtr theShape);

		#region NativeInstancePtr Convert constructor

		public BRepPrimAPIMakePrism() { } 

		public BRepPrimAPIMakePrism(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ BRepPrimAPIMakePrism_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void BRepPrimAPIMakePrism_Dtor(IntPtr instance);
	}
}
