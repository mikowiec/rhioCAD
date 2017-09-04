#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;
using NaroCppCore.Occ.TopoDS;
using NaroCppCore.Occ.TopTools;

#endregion

namespace NaroCppCore.Occ.TopTools
{
	public class TopToolsListOfShape : NativeInstancePtr
	{
		public TopToolsListOfShape()
 :
			base(TopTools_ListOfShape_Ctor() )
		{}
			public void Assign(TopToolsListOfShape Other)
				{
					TopTools_ListOfShape_Assign49A1D41A(Instance, Other.Instance);
				}
			public void Prepend(TopoDSShape I)
				{
					TopTools_ListOfShape_Prepend9EBAC0C0(Instance, I.Instance);
				}
			public void Prepend(TopoDSShape I,TopToolsListIteratorOfListOfShape theIt)
				{
					TopTools_ListOfShape_Prepend90A9D6CA(Instance, I.Instance, theIt.Instance);
				}
			public void Prepend(TopToolsListOfShape Other)
				{
					TopTools_ListOfShape_Prepend49A1D41A(Instance, Other.Instance);
				}
			public void Append(TopoDSShape I)
				{
					TopTools_ListOfShape_Append9EBAC0C0(Instance, I.Instance);
				}
			public void Append(TopoDSShape I,TopToolsListIteratorOfListOfShape theIt)
				{
					TopTools_ListOfShape_Append90A9D6CA(Instance, I.Instance, theIt.Instance);
				}
			public void Append(TopToolsListOfShape Other)
				{
					TopTools_ListOfShape_Append49A1D41A(Instance, Other.Instance);
				}
			public void RemoveFirst()
				{
					TopTools_ListOfShape_RemoveFirst(Instance);
				}
			public void Remove(TopToolsListIteratorOfListOfShape It)
				{
					TopTools_ListOfShape_RemoveB4C0FF7F(Instance, It.Instance);
				}
			public void InsertBefore(TopoDSShape I,TopToolsListIteratorOfListOfShape It)
				{
					TopTools_ListOfShape_InsertBefore90A9D6CA(Instance, I.Instance, It.Instance);
				}
			public void InsertBefore(TopToolsListOfShape Other,TopToolsListIteratorOfListOfShape It)
				{
					TopTools_ListOfShape_InsertBefore8F414405(Instance, Other.Instance, It.Instance);
				}
			public void InsertAfter(TopoDSShape I,TopToolsListIteratorOfListOfShape It)
				{
					TopTools_ListOfShape_InsertAfter90A9D6CA(Instance, I.Instance, It.Instance);
				}
			public void InsertAfter(TopToolsListOfShape Other,TopToolsListIteratorOfListOfShape It)
				{
					TopTools_ListOfShape_InsertAfter8F414405(Instance, Other.Instance, It.Instance);
				}
		public int Extent{
			get {
				return TopTools_ListOfShape_Extent(Instance);
			}
		}
		public bool IsEmpty{
			get {
				return TopTools_ListOfShape_IsEmpty(Instance);
			}
		}
		public TopoDSShape First{
			get {
				return new TopoDSShape(TopTools_ListOfShape_First(Instance));
			}
		}
		public TopoDSShape Last{
			get {
				return new TopoDSShape(TopTools_ListOfShape_Last(Instance));
			}
		}
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr TopTools_ListOfShape_Ctor();
		[DllImport("NaroOccCore.dll")]
		private static extern void TopTools_ListOfShape_Assign49A1D41A(IntPtr instance, IntPtr Other);
		[DllImport("NaroOccCore.dll")]
		private static extern void TopTools_ListOfShape_Prepend9EBAC0C0(IntPtr instance, IntPtr I);
		[DllImport("NaroOccCore.dll")]
		private static extern void TopTools_ListOfShape_Prepend90A9D6CA(IntPtr instance, IntPtr I,IntPtr theIt);
		[DllImport("NaroOccCore.dll")]
		private static extern void TopTools_ListOfShape_Prepend49A1D41A(IntPtr instance, IntPtr Other);
		[DllImport("NaroOccCore.dll")]
		private static extern void TopTools_ListOfShape_Append9EBAC0C0(IntPtr instance, IntPtr I);
		[DllImport("NaroOccCore.dll")]
		private static extern void TopTools_ListOfShape_Append90A9D6CA(IntPtr instance, IntPtr I,IntPtr theIt);
		[DllImport("NaroOccCore.dll")]
		private static extern void TopTools_ListOfShape_Append49A1D41A(IntPtr instance, IntPtr Other);
		[DllImport("NaroOccCore.dll")]
		private static extern void TopTools_ListOfShape_RemoveFirst(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void TopTools_ListOfShape_RemoveB4C0FF7F(IntPtr instance, IntPtr It);
		[DllImport("NaroOccCore.dll")]
		private static extern void TopTools_ListOfShape_InsertBefore90A9D6CA(IntPtr instance, IntPtr I,IntPtr It);
		[DllImport("NaroOccCore.dll")]
		private static extern void TopTools_ListOfShape_InsertBefore8F414405(IntPtr instance, IntPtr Other,IntPtr It);
		[DllImport("NaroOccCore.dll")]
		private static extern void TopTools_ListOfShape_InsertAfter90A9D6CA(IntPtr instance, IntPtr I,IntPtr It);
		[DllImport("NaroOccCore.dll")]
		private static extern void TopTools_ListOfShape_InsertAfter8F414405(IntPtr instance, IntPtr Other,IntPtr It);
		[DllImport("NaroOccCore.dll")]
		private static extern int TopTools_ListOfShape_Extent(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool TopTools_ListOfShape_IsEmpty(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr TopTools_ListOfShape_First(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr TopTools_ListOfShape_Last(IntPtr instance);

		#region NativeInstancePtr Convert constructor

		public TopToolsListOfShape(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ TopToolsListOfShape_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void TopToolsListOfShape_Dtor(IntPtr instance);
	}
}
