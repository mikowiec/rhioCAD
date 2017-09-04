#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;
using NaroCppCore.Occ.BOP;

#endregion

namespace NaroCppCore.Occ.BOP
{
	public class BOPListIteratorOfListOfEdgeInfo : NativeInstancePtr
	{
		public BOPListIteratorOfListOfEdgeInfo()
 :
			base(BOP_ListIteratorOfListOfEdgeInfo_Ctor() )
		{}
		public BOPListIteratorOfListOfEdgeInfo(BOPListOfEdgeInfo L)
 :
			base(BOP_ListIteratorOfListOfEdgeInfo_CtorBB93B226(L.Instance) )
		{}
			public void Initialize(BOPListOfEdgeInfo L)
				{
					BOP_ListIteratorOfListOfEdgeInfo_InitializeBB93B226(Instance, L.Instance);
				}
			public void Next()
				{
					BOP_ListIteratorOfListOfEdgeInfo_Next(Instance);
				}
		public bool More{
			get {
				return BOP_ListIteratorOfListOfEdgeInfo_More(Instance);
			}
		}
		public BOPEdgeInfo Value{
			get {
				return new BOPEdgeInfo(BOP_ListIteratorOfListOfEdgeInfo_Value(Instance));
			}
		}
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr BOP_ListIteratorOfListOfEdgeInfo_Ctor();
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr BOP_ListIteratorOfListOfEdgeInfo_CtorBB93B226(IntPtr L);
		[DllImport("NaroOccCore.dll")]
		private static extern void BOP_ListIteratorOfListOfEdgeInfo_InitializeBB93B226(IntPtr instance, IntPtr L);
		[DllImport("NaroOccCore.dll")]
		private static extern void BOP_ListIteratorOfListOfEdgeInfo_Next(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool BOP_ListIteratorOfListOfEdgeInfo_More(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr BOP_ListIteratorOfListOfEdgeInfo_Value(IntPtr instance);

		#region NativeInstancePtr Convert constructor

		public BOPListIteratorOfListOfEdgeInfo(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ BOPListIteratorOfListOfEdgeInfo_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void BOPListIteratorOfListOfEdgeInfo_Dtor(IntPtr instance);
	}
}
