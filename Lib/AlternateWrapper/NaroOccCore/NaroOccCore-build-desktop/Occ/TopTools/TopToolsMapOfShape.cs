#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;
using NaroCppCore.Occ.TCollection;
using NaroCppCore.Occ.TopTools;
using NaroCppCore.Occ.TopoDS;

#endregion

namespace NaroCppCore.Occ.TopTools
{
	public class TopToolsMapOfShape : TCollectionBasicMap
	{
		public TopToolsMapOfShape(int NbBuckets)
 :
			base(TopTools_MapOfShape_CtorE8219145(NbBuckets) )
		{}
			public TopToolsMapOfShape Assign(TopToolsMapOfShape Other)
				{
					return new TopToolsMapOfShape(TopTools_MapOfShape_Assign5AADDC61(Instance, Other.Instance));
				}
			public void ReSize(int NbBuckets)
				{
					TopTools_MapOfShape_ReSizeE8219145(Instance, NbBuckets);
				}
			public bool Add(TopoDSShape aKey)
				{
					return TopTools_MapOfShape_Add9EBAC0C0(Instance, aKey.Instance);
				}
			public bool Contains(TopoDSShape aKey)
				{
					return TopTools_MapOfShape_Contains9EBAC0C0(Instance, aKey.Instance);
				}
			public bool Remove(TopoDSShape aKey)
				{
					return TopTools_MapOfShape_Remove9EBAC0C0(Instance, aKey.Instance);
				}
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr TopTools_MapOfShape_CtorE8219145(int NbBuckets);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr TopTools_MapOfShape_Assign5AADDC61(IntPtr instance, IntPtr Other);
		[DllImport("NaroOccCore.dll")]
		private static extern void TopTools_MapOfShape_ReSizeE8219145(IntPtr instance, int NbBuckets);
		[DllImport("NaroOccCore.dll")]
		private static extern bool TopTools_MapOfShape_Add9EBAC0C0(IntPtr instance, IntPtr aKey);
		[DllImport("NaroOccCore.dll")]
		private static extern bool TopTools_MapOfShape_Contains9EBAC0C0(IntPtr instance, IntPtr aKey);
		[DllImport("NaroOccCore.dll")]
		private static extern bool TopTools_MapOfShape_Remove9EBAC0C0(IntPtr instance, IntPtr aKey);

		#region NativeInstancePtr Convert constructor

		public TopToolsMapOfShape() { } 

		public TopToolsMapOfShape(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ TopToolsMapOfShape_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void TopToolsMapOfShape_Dtor(IntPtr instance);
	}
}
