#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;

#endregion

namespace NaroCppCore.Occ.BOP
{
	public class BOPBlockIterator : NativeInstancePtr
	{
		public BOPBlockIterator()
 :
			base(BOP_BlockIterator_Ctor() )
		{}
		public BOPBlockIterator(int Lower,int Upper)
 :
			base(BOP_BlockIterator_Ctor5107F6FE(Lower, Upper) )
		{}
			public void Initialize()
				{
					BOP_BlockIterator_Initialize(Instance);
				}
			public void Next()
				{
					BOP_BlockIterator_Next(Instance);
				}
		public bool More{
			get {
				return BOP_BlockIterator_More(Instance);
			}
		}
		public int Value{
			get {
				return BOP_BlockIterator_Value(Instance);
			}
		}
		public int Extent{
			get {
				return BOP_BlockIterator_Extent(Instance);
			}
		}
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr BOP_BlockIterator_Ctor();
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr BOP_BlockIterator_Ctor5107F6FE(int Lower,int Upper);
		[DllImport("NaroOccCore.dll")]
		private static extern void BOP_BlockIterator_Initialize(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void BOP_BlockIterator_Next(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool BOP_BlockIterator_More(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern int BOP_BlockIterator_Value(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern int BOP_BlockIterator_Extent(IntPtr instance);

		#region NativeInstancePtr Convert constructor

		public BOPBlockIterator(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ BOPBlockIterator_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void BOPBlockIterator_Dtor(IntPtr instance);
	}
}
