#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;

#endregion

namespace NaroCppCore.Occ.TCollection
{
	public class TCollectionBaseSequence : NativeInstancePtr
	{
			public void Reverse()
				{
					TCollection_BaseSequence_Reverse(Instance);
				}
			public void Exchange(int I,int J)
				{
					TCollection_BaseSequence_Exchange5107F6FE(Instance, I, J);
				}
		public bool IsEmpty{
			get {
				return TCollection_BaseSequence_IsEmpty(Instance);
			}
		}
		public int Length{
			get {
				return TCollection_BaseSequence_Length(Instance);
			}
		}
		[DllImport("NaroOccCore.dll")]
		private static extern void TCollection_BaseSequence_Reverse(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void TCollection_BaseSequence_Exchange5107F6FE(IntPtr instance, int I,int J);
		[DllImport("NaroOccCore.dll")]
		private static extern bool TCollection_BaseSequence_IsEmpty(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern int TCollection_BaseSequence_Length(IntPtr instance);

		#region NativeInstancePtr Convert constructor

		public TCollectionBaseSequence() { } 

		public TCollectionBaseSequence(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ TCollectionBaseSequence_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void TCollectionBaseSequence_Dtor(IntPtr instance);
	}
}
