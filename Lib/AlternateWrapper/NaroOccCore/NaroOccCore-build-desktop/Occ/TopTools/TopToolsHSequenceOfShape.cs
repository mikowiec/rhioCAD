#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;
using NaroCppCore.Occ.MMgt;
using NaroCppCore.Occ.TopTools;
using NaroCppCore.Occ.TopoDS;

#endregion

namespace NaroCppCore.Occ.TopTools
{
	public class TopToolsHSequenceOfShape : MMgtTShared
	{
		public TopToolsHSequenceOfShape()
 :
			base(TopTools_HSequenceOfShape_Ctor() )
		{}
			public void Clear()
				{
					TopTools_HSequenceOfShape_Clear(Instance);
				}
			public void Append(TopoDSShape anItem)
				{
					TopTools_HSequenceOfShape_Append9EBAC0C0(Instance, anItem.Instance);
				}
			public void Append(TopToolsHSequenceOfShape aSequence)
				{
					TopTools_HSequenceOfShape_AppendE578D17E(Instance, aSequence.Instance);
				}
			public void Prepend(TopoDSShape anItem)
				{
					TopTools_HSequenceOfShape_Prepend9EBAC0C0(Instance, anItem.Instance);
				}
			public void Prepend(TopToolsHSequenceOfShape aSequence)
				{
					TopTools_HSequenceOfShape_PrependE578D17E(Instance, aSequence.Instance);
				}
			public void Reverse()
				{
					TopTools_HSequenceOfShape_Reverse(Instance);
				}
			public void InsertBefore(int anIndex,TopoDSShape anItem)
				{
					TopTools_HSequenceOfShape_InsertBeforeA4F60BB8(Instance, anIndex, anItem.Instance);
				}
			public void InsertBefore(int anIndex,TopToolsHSequenceOfShape aSequence)
				{
					TopTools_HSequenceOfShape_InsertBefore9D43C6B8(Instance, anIndex, aSequence.Instance);
				}
			public void InsertAfter(int anIndex,TopoDSShape anItem)
				{
					TopTools_HSequenceOfShape_InsertAfterA4F60BB8(Instance, anIndex, anItem.Instance);
				}
			public void InsertAfter(int anIndex,TopToolsHSequenceOfShape aSequence)
				{
					TopTools_HSequenceOfShape_InsertAfter9D43C6B8(Instance, anIndex, aSequence.Instance);
				}
			public void Exchange(int anIndex,int anOtherIndex)
				{
					TopTools_HSequenceOfShape_Exchange5107F6FE(Instance, anIndex, anOtherIndex);
				}
			public TopToolsHSequenceOfShape Split(int anIndex)
				{
					return new TopToolsHSequenceOfShape(TopTools_HSequenceOfShape_SplitE8219145(Instance, anIndex));
				}
			public void SetValue(int anIndex,TopoDSShape anItem)
				{
					TopTools_HSequenceOfShape_SetValueA4F60BB8(Instance, anIndex, anItem.Instance);
				}
			public TopoDSShape Value(int anIndex)
				{
					return new TopoDSShape(TopTools_HSequenceOfShape_ValueE8219145(Instance, anIndex));
				}
			public TopoDSShape ChangeValue(int anIndex)
				{
					return new TopoDSShape(TopTools_HSequenceOfShape_ChangeValueE8219145(Instance, anIndex));
				}
			public void Remove(int anIndex)
				{
					TopTools_HSequenceOfShape_RemoveE8219145(Instance, anIndex);
				}
			public void Remove(int fromIndex,int toIndex)
				{
					TopTools_HSequenceOfShape_Remove5107F6FE(Instance, fromIndex, toIndex);
				}
		public bool IsEmpty{
			get {
				return TopTools_HSequenceOfShape_IsEmpty(Instance);
			}
		}
		public int Length{
			get {
				return TopTools_HSequenceOfShape_Length(Instance);
			}
		}
		public TopToolsHSequenceOfShape ShallowCopy{
			get {
				return new TopToolsHSequenceOfShape(TopTools_HSequenceOfShape_ShallowCopy(Instance));
			}
		}
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr TopTools_HSequenceOfShape_Ctor();
		[DllImport("NaroOccCore.dll")]
		private static extern void TopTools_HSequenceOfShape_Clear(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void TopTools_HSequenceOfShape_Append9EBAC0C0(IntPtr instance, IntPtr anItem);
		[DllImport("NaroOccCore.dll")]
		private static extern void TopTools_HSequenceOfShape_AppendE578D17E(IntPtr instance, IntPtr aSequence);
		[DllImport("NaroOccCore.dll")]
		private static extern void TopTools_HSequenceOfShape_Prepend9EBAC0C0(IntPtr instance, IntPtr anItem);
		[DllImport("NaroOccCore.dll")]
		private static extern void TopTools_HSequenceOfShape_PrependE578D17E(IntPtr instance, IntPtr aSequence);
		[DllImport("NaroOccCore.dll")]
		private static extern void TopTools_HSequenceOfShape_Reverse(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void TopTools_HSequenceOfShape_InsertBeforeA4F60BB8(IntPtr instance, int anIndex,IntPtr anItem);
		[DllImport("NaroOccCore.dll")]
		private static extern void TopTools_HSequenceOfShape_InsertBefore9D43C6B8(IntPtr instance, int anIndex,IntPtr aSequence);
		[DllImport("NaroOccCore.dll")]
		private static extern void TopTools_HSequenceOfShape_InsertAfterA4F60BB8(IntPtr instance, int anIndex,IntPtr anItem);
		[DllImport("NaroOccCore.dll")]
		private static extern void TopTools_HSequenceOfShape_InsertAfter9D43C6B8(IntPtr instance, int anIndex,IntPtr aSequence);
		[DllImport("NaroOccCore.dll")]
		private static extern void TopTools_HSequenceOfShape_Exchange5107F6FE(IntPtr instance, int anIndex,int anOtherIndex);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr TopTools_HSequenceOfShape_SplitE8219145(IntPtr instance, int anIndex);
		[DllImport("NaroOccCore.dll")]
		private static extern void TopTools_HSequenceOfShape_SetValueA4F60BB8(IntPtr instance, int anIndex,IntPtr anItem);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr TopTools_HSequenceOfShape_ValueE8219145(IntPtr instance, int anIndex);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr TopTools_HSequenceOfShape_ChangeValueE8219145(IntPtr instance, int anIndex);
		[DllImport("NaroOccCore.dll")]
		private static extern void TopTools_HSequenceOfShape_RemoveE8219145(IntPtr instance, int anIndex);
		[DllImport("NaroOccCore.dll")]
		private static extern void TopTools_HSequenceOfShape_Remove5107F6FE(IntPtr instance, int fromIndex,int toIndex);
		[DllImport("NaroOccCore.dll")]
		private static extern bool TopTools_HSequenceOfShape_IsEmpty(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern int TopTools_HSequenceOfShape_Length(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr TopTools_HSequenceOfShape_ShallowCopy(IntPtr instance);

		#region NativeInstancePtr Convert constructor

		public TopToolsHSequenceOfShape(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ TopToolsHSequenceOfShape_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void TopToolsHSequenceOfShape_Dtor(IntPtr instance);
	}
}
