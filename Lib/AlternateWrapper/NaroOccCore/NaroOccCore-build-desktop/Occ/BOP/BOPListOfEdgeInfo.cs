#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;
using NaroCppCore.Occ.BOP;

#endregion

namespace NaroCppCore.Occ.BOP
{
	public class BOPListOfEdgeInfo : NativeInstancePtr
	{
		public BOPListOfEdgeInfo()
 :
			base(BOP_ListOfEdgeInfo_Ctor() )
		{}
			public void Assign(BOPListOfEdgeInfo Other)
				{
					BOP_ListOfEdgeInfo_AssignBB93B226(Instance, Other.Instance);
				}
			public void Prepend(BOPEdgeInfo I)
				{
					BOP_ListOfEdgeInfo_Prepend6C1C9DDA(Instance, I.Instance);
				}
			public void Prepend(BOPEdgeInfo I,BOPListIteratorOfListOfEdgeInfo theIt)
				{
					BOP_ListOfEdgeInfo_Prepend7EDD85A0(Instance, I.Instance, theIt.Instance);
				}
			public void Prepend(BOPListOfEdgeInfo Other)
				{
					BOP_ListOfEdgeInfo_PrependBB93B226(Instance, Other.Instance);
				}
			public void Append(BOPEdgeInfo I)
				{
					BOP_ListOfEdgeInfo_Append6C1C9DDA(Instance, I.Instance);
				}
			public void Append(BOPEdgeInfo I,BOPListIteratorOfListOfEdgeInfo theIt)
				{
					BOP_ListOfEdgeInfo_Append7EDD85A0(Instance, I.Instance, theIt.Instance);
				}
			public void Append(BOPListOfEdgeInfo Other)
				{
					BOP_ListOfEdgeInfo_AppendBB93B226(Instance, Other.Instance);
				}
			public void RemoveFirst()
				{
					BOP_ListOfEdgeInfo_RemoveFirst(Instance);
				}
			public void Remove(BOPListIteratorOfListOfEdgeInfo It)
				{
					BOP_ListOfEdgeInfo_RemoveF9227B7D(Instance, It.Instance);
				}
			public void InsertBefore(BOPEdgeInfo I,BOPListIteratorOfListOfEdgeInfo It)
				{
					BOP_ListOfEdgeInfo_InsertBefore7EDD85A0(Instance, I.Instance, It.Instance);
				}
			public void InsertBefore(BOPListOfEdgeInfo Other,BOPListIteratorOfListOfEdgeInfo It)
				{
					BOP_ListOfEdgeInfo_InsertBefore7A35FC8F(Instance, Other.Instance, It.Instance);
				}
			public void InsertAfter(BOPEdgeInfo I,BOPListIteratorOfListOfEdgeInfo It)
				{
					BOP_ListOfEdgeInfo_InsertAfter7EDD85A0(Instance, I.Instance, It.Instance);
				}
			public void InsertAfter(BOPListOfEdgeInfo Other,BOPListIteratorOfListOfEdgeInfo It)
				{
					BOP_ListOfEdgeInfo_InsertAfter7A35FC8F(Instance, Other.Instance, It.Instance);
				}
		public int Extent{
			get {
				return BOP_ListOfEdgeInfo_Extent(Instance);
			}
		}
		public bool IsEmpty{
			get {
				return BOP_ListOfEdgeInfo_IsEmpty(Instance);
			}
		}
		public BOPEdgeInfo First{
			get {
				return new BOPEdgeInfo(BOP_ListOfEdgeInfo_First(Instance));
			}
		}
		public BOPEdgeInfo Last{
			get {
				return new BOPEdgeInfo(BOP_ListOfEdgeInfo_Last(Instance));
			}
		}
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr BOP_ListOfEdgeInfo_Ctor();
		[DllImport("NaroOccCore.dll")]
		private static extern void BOP_ListOfEdgeInfo_AssignBB93B226(IntPtr instance, IntPtr Other);
		[DllImport("NaroOccCore.dll")]
		private static extern void BOP_ListOfEdgeInfo_Prepend6C1C9DDA(IntPtr instance, IntPtr I);
		[DllImport("NaroOccCore.dll")]
		private static extern void BOP_ListOfEdgeInfo_Prepend7EDD85A0(IntPtr instance, IntPtr I,IntPtr theIt);
		[DllImport("NaroOccCore.dll")]
		private static extern void BOP_ListOfEdgeInfo_PrependBB93B226(IntPtr instance, IntPtr Other);
		[DllImport("NaroOccCore.dll")]
		private static extern void BOP_ListOfEdgeInfo_Append6C1C9DDA(IntPtr instance, IntPtr I);
		[DllImport("NaroOccCore.dll")]
		private static extern void BOP_ListOfEdgeInfo_Append7EDD85A0(IntPtr instance, IntPtr I,IntPtr theIt);
		[DllImport("NaroOccCore.dll")]
		private static extern void BOP_ListOfEdgeInfo_AppendBB93B226(IntPtr instance, IntPtr Other);
		[DllImport("NaroOccCore.dll")]
		private static extern void BOP_ListOfEdgeInfo_RemoveFirst(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void BOP_ListOfEdgeInfo_RemoveF9227B7D(IntPtr instance, IntPtr It);
		[DllImport("NaroOccCore.dll")]
		private static extern void BOP_ListOfEdgeInfo_InsertBefore7EDD85A0(IntPtr instance, IntPtr I,IntPtr It);
		[DllImport("NaroOccCore.dll")]
		private static extern void BOP_ListOfEdgeInfo_InsertBefore7A35FC8F(IntPtr instance, IntPtr Other,IntPtr It);
		[DllImport("NaroOccCore.dll")]
		private static extern void BOP_ListOfEdgeInfo_InsertAfter7EDD85A0(IntPtr instance, IntPtr I,IntPtr It);
		[DllImport("NaroOccCore.dll")]
		private static extern void BOP_ListOfEdgeInfo_InsertAfter7A35FC8F(IntPtr instance, IntPtr Other,IntPtr It);
		[DllImport("NaroOccCore.dll")]
		private static extern int BOP_ListOfEdgeInfo_Extent(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool BOP_ListOfEdgeInfo_IsEmpty(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr BOP_ListOfEdgeInfo_First(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr BOP_ListOfEdgeInfo_Last(IntPtr instance);

		#region NativeInstancePtr Convert constructor

		public BOPListOfEdgeInfo(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ BOPListOfEdgeInfo_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void BOPListOfEdgeInfo_Dtor(IntPtr instance);
	}
}
