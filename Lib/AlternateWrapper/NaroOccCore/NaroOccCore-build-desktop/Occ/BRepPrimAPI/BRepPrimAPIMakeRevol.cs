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
	public class BRepPrimAPIMakeRevol : BRepPrimAPIMakeSweep
	{
		public BRepPrimAPIMakeRevol(TopoDSShape S,gpAx1 A,double D,bool Copy)
 :
			base(BRepPrimAPI_MakeRevol_CtorFAF6E492(S.Instance, A.Instance, D, Copy) )
		{}
		public BRepPrimAPIMakeRevol(TopoDSShape S,gpAx1 A,bool Copy)
 :
			base(BRepPrimAPI_MakeRevol_CtorE3E37232(S.Instance, A.Instance, Copy) )
		{}
			public void Build()
				{
					BRepPrimAPI_MakeRevol_Build(Instance);
				}
			public TopoDSShape FirstShape()
				{
					return new TopoDSShape(BRepPrimAPI_MakeRevol_FirstShape(Instance));
				}
			public TopoDSShape LastShape()
				{
					return new TopoDSShape(BRepPrimAPI_MakeRevol_LastShape(Instance));
				}
			public TopoDSShape FirstShape(TopoDSShape theShape)
				{
					return new TopoDSShape(BRepPrimAPI_MakeRevol_FirstShape9EBAC0C0(Instance, theShape.Instance));
				}
			public TopoDSShape LastShape(TopoDSShape theShape)
				{
					return new TopoDSShape(BRepPrimAPI_MakeRevol_LastShape9EBAC0C0(Instance, theShape.Instance));
				}
		public bool HasDegenerated{
			get {
				return BRepPrimAPI_MakeRevol_HasDegenerated(Instance);
			}
		}
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr BRepPrimAPI_MakeRevol_CtorFAF6E492(IntPtr S,IntPtr A,double D,bool Copy);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr BRepPrimAPI_MakeRevol_CtorE3E37232(IntPtr S,IntPtr A,bool Copy);
		[DllImport("NaroOccCore.dll")]
		private static extern void BRepPrimAPI_MakeRevol_Build(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr BRepPrimAPI_MakeRevol_FirstShape(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr BRepPrimAPI_MakeRevol_LastShape(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr BRepPrimAPI_MakeRevol_FirstShape9EBAC0C0(IntPtr instance, IntPtr theShape);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr BRepPrimAPI_MakeRevol_LastShape9EBAC0C0(IntPtr instance, IntPtr theShape);
		[DllImport("NaroOccCore.dll")]
		private static extern bool BRepPrimAPI_MakeRevol_HasDegenerated(IntPtr instance);

		#region NativeInstancePtr Convert constructor

		public BRepPrimAPIMakeRevol() { } 

		public BRepPrimAPIMakeRevol(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ BRepPrimAPIMakeRevol_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void BRepPrimAPIMakeRevol_Dtor(IntPtr instance);
	}
}
