#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;
using NaroCppCore.Occ.TCollection;
using NaroCppCore.Occ.TopoDS;
using NaroCppCore.Occ.TopTools;

#endregion

namespace NaroCppCore.Occ.TopTools
{
	public class TopToolsIndexedDataMapOfShapeListOfShape : TCollectionBasicMap
	{
		public TopToolsIndexedDataMapOfShapeListOfShape(int NbBuckets)
 :
			base(TopTools_IndexedDataMapOfShapeListOfShape_CtorE8219145(NbBuckets) )
		{}
			public void ReSize(int NbBuckets)
				{
					TopTools_IndexedDataMapOfShapeListOfShape_ReSizeE8219145(Instance, NbBuckets);
				}
			public int Add(TopoDSShape K,TopToolsListOfShape I)
				{
					return TopTools_IndexedDataMapOfShapeListOfShape_AddA97080D(Instance, K.Instance, I.Instance);
				}
			public void Substitute(int I,TopoDSShape K,TopToolsListOfShape T)
				{
					TopTools_IndexedDataMapOfShapeListOfShape_SubstituteF0D9ACDA(Instance, I, K.Instance, T.Instance);
				}
			public void RemoveLast()
				{
					TopTools_IndexedDataMapOfShapeListOfShape_RemoveLast(Instance);
				}
			public bool Contains(TopoDSShape K)
				{
					return TopTools_IndexedDataMapOfShapeListOfShape_Contains9EBAC0C0(Instance, K.Instance);
				}
			public TopoDSShape FindKey(int I)
				{
					return new TopoDSShape(TopTools_IndexedDataMapOfShapeListOfShape_FindKeyE8219145(Instance, I));
				}
			public TopToolsListOfShape FindFromIndex(int I)
				{
					return new TopToolsListOfShape(TopTools_IndexedDataMapOfShapeListOfShape_FindFromIndexE8219145(Instance, I));
				}
			public int FindIndex(TopoDSShape K)
				{
					return TopTools_IndexedDataMapOfShapeListOfShape_FindIndex9EBAC0C0(Instance, K.Instance);
				}
			public IntPtr FindFromKey1(TopoDSShape K)
				{
					return TopTools_IndexedDataMapOfShapeListOfShape_FindFromKey19EBAC0C0(Instance, K.Instance);
				}
			public IntPtr ChangeFromKey1(TopoDSShape K)
				{
					return TopTools_IndexedDataMapOfShapeListOfShape_ChangeFromKey19EBAC0C0(Instance, K.Instance);
				}
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr TopTools_IndexedDataMapOfShapeListOfShape_CtorE8219145(int NbBuckets);
		[DllImport("NaroOccCore.dll")]
		private static extern void TopTools_IndexedDataMapOfShapeListOfShape_ReSizeE8219145(IntPtr instance, int NbBuckets);
		[DllImport("NaroOccCore.dll")]
		private static extern int TopTools_IndexedDataMapOfShapeListOfShape_AddA97080D(IntPtr instance, IntPtr K,IntPtr I);
		[DllImport("NaroOccCore.dll")]
		private static extern void TopTools_IndexedDataMapOfShapeListOfShape_SubstituteF0D9ACDA(IntPtr instance, int I,IntPtr K,IntPtr T);
		[DllImport("NaroOccCore.dll")]
		private static extern void TopTools_IndexedDataMapOfShapeListOfShape_RemoveLast(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool TopTools_IndexedDataMapOfShapeListOfShape_Contains9EBAC0C0(IntPtr instance, IntPtr K);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr TopTools_IndexedDataMapOfShapeListOfShape_FindKeyE8219145(IntPtr instance, int I);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr TopTools_IndexedDataMapOfShapeListOfShape_FindFromIndexE8219145(IntPtr instance, int I);
		[DllImport("NaroOccCore.dll")]
		private static extern int TopTools_IndexedDataMapOfShapeListOfShape_FindIndex9EBAC0C0(IntPtr instance, IntPtr K);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr TopTools_IndexedDataMapOfShapeListOfShape_FindFromKey19EBAC0C0(IntPtr instance, IntPtr K);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr TopTools_IndexedDataMapOfShapeListOfShape_ChangeFromKey19EBAC0C0(IntPtr instance, IntPtr K);

		#region NativeInstancePtr Convert constructor

		public TopToolsIndexedDataMapOfShapeListOfShape() { } 

		public TopToolsIndexedDataMapOfShapeListOfShape(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ TopToolsIndexedDataMapOfShapeListOfShape_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void TopToolsIndexedDataMapOfShapeListOfShape_Dtor(IntPtr instance);
	}
}
