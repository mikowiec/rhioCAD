#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;

#endregion

namespace NaroCppCore.Occ.TCollection
{
	public class TCollectionBasicMap : NativeInstancePtr
	{
		public int NbBuckets{
			get {
				return TCollection_BasicMap_NbBuckets(Instance);
			}
		}
		public int Extent{
			get {
				return TCollection_BasicMap_Extent(Instance);
			}
		}
		public bool IsEmpty{
			get {
				return TCollection_BasicMap_IsEmpty(Instance);
			}
		}
		[DllImport("NaroOccCore.dll")]
		private static extern int TCollection_BasicMap_NbBuckets(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern int TCollection_BasicMap_Extent(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool TCollection_BasicMap_IsEmpty(IntPtr instance);

		#region NativeInstancePtr Convert constructor

		public TCollectionBasicMap() { } 

		public TCollectionBasicMap(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ TCollectionBasicMap_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void TCollectionBasicMap_Dtor(IntPtr instance);
	}
}
