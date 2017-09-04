#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;
using NaroCppCore.Occ.MMgt;
using NaroCppCore.Occ.TopoDS;
using NaroCppCore.Occ.BOP;

#endregion

namespace NaroCppCore.Occ.BOP
{
	public class BOPLoop : MMgtTShared
	{
		public BOPLoop(TopoDSShape S)
 :
			base(BOP_Loop_Ctor9EBAC0C0(S.Instance) )
		{}
		public BOPLoop(BOPBlockIterator BI)
 :
			base(BOP_Loop_CtorD1FD8153(BI.Instance) )
		{}
		public bool IsShape{
			get {
				return BOP_Loop_IsShape(Instance);
			}
		}
		public TopoDSShape Shape{
			get {
				return new TopoDSShape(BOP_Loop_Shape(Instance));
			}
		}
		public BOPBlockIterator BlockIterator{
			get {
				return new BOPBlockIterator(BOP_Loop_BlockIterator(Instance));
			}
		}
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr BOP_Loop_Ctor9EBAC0C0(IntPtr S);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr BOP_Loop_CtorD1FD8153(IntPtr BI);
		[DllImport("NaroOccCore.dll")]
		private static extern bool BOP_Loop_IsShape(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr BOP_Loop_Shape(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr BOP_Loop_BlockIterator(IntPtr instance);

		#region NativeInstancePtr Convert constructor

		public BOPLoop() { } 

		public BOPLoop(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ BOPLoop_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void BOPLoop_Dtor(IntPtr instance);
	}
}
