#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;
using NaroCppCore.Occ.TCollection;
using NaroCppCore.Occ.TopoDS;

#endregion

namespace NaroCppCore.Occ.TopTools
{
	public class TopToolsIndexedMapOfShape : TCollectionBasicMap
	{
		public TopToolsIndexedMapOfShape(int NbBuckets)
 :
			base(TopTools_IndexedMapOfShape_CtorE8219145(NbBuckets) )
		{}
			public void ReSize(int NbBuckets)
				{
					TopTools_IndexedMapOfShape_ReSizeE8219145(Instance, NbBuckets);
				}
			public int Add(TopoDSShape K)
				{
					return TopTools_IndexedMapOfShape_Add9EBAC0C0(Instance, K.Instance);
				}
			public void Substitute(int I,TopoDSShape K)
				{
					TopTools_IndexedMapOfShape_SubstituteA4F60BB8(Instance, I, K.Instance);
				}
			public void RemoveLast()
				{
					TopTools_IndexedMapOfShape_RemoveLast(Instance);
				}
			public bool Contains(TopoDSShape K)
				{
					return TopTools_IndexedMapOfShape_Contains9EBAC0C0(Instance, K.Instance);
				}
			public TopoDSShape FindKey(int I)
				{
					return new TopoDSShape(TopTools_IndexedMapOfShape_FindKeyE8219145(Instance, I));
				}
			public int FindIndex(TopoDSShape K)
				{
					return TopTools_IndexedMapOfShape_FindIndex9EBAC0C0(Instance, K.Instance);
				}
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr TopTools_IndexedMapOfShape_CtorE8219145(int NbBuckets);
		[DllImport("NaroOccCore.dll")]
		private static extern void TopTools_IndexedMapOfShape_ReSizeE8219145(IntPtr instance, int NbBuckets);
		[DllImport("NaroOccCore.dll")]
		private static extern int TopTools_IndexedMapOfShape_Add9EBAC0C0(IntPtr instance, IntPtr K);
		[DllImport("NaroOccCore.dll")]
		private static extern void TopTools_IndexedMapOfShape_SubstituteA4F60BB8(IntPtr instance, int I,IntPtr K);
		[DllImport("NaroOccCore.dll")]
		private static extern void TopTools_IndexedMapOfShape_RemoveLast(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool TopTools_IndexedMapOfShape_Contains9EBAC0C0(IntPtr instance, IntPtr K);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr TopTools_IndexedMapOfShape_FindKeyE8219145(IntPtr instance, int I);
		[DllImport("NaroOccCore.dll")]
		private static extern int TopTools_IndexedMapOfShape_FindIndex9EBAC0C0(IntPtr instance, IntPtr K);

		#region NativeInstancePtr Convert constructor

		public TopToolsIndexedMapOfShape() { } 

		public TopToolsIndexedMapOfShape(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ TopToolsIndexedMapOfShape_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void TopToolsIndexedMapOfShape_Dtor(IntPtr instance);
	}
}
