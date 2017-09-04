#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;
using NaroCppCore.Occ.BOPTools;

#endregion

namespace NaroCppCore.Occ.BOPTools
{
	public class BOPToolsCommonBlock : NativeInstancePtr
	{
		public BOPToolsCommonBlock()
 :
			base(BOPTools_CommonBlock_Ctor() )
		{}
		public BOPToolsCommonBlock(BOPToolsPaveBlock aPB1,BOPToolsPaveBlock aPB2)
 :
			base(BOPTools_CommonBlock_CtorA5B57975(aPB1.Instance, aPB2.Instance) )
		{}
		public BOPToolsCommonBlock(BOPToolsPaveBlock aPB1,int aF)
 :
			base(BOPTools_CommonBlock_CtorE11775D8(aPB1.Instance, aF) )
		{}
			public void SetPaveBlock1(BOPToolsPaveBlock aPB1)
				{
					BOPTools_CommonBlock_SetPaveBlock136FC67E4(Instance, aPB1.Instance);
				}
			public void SetPaveBlock2(BOPToolsPaveBlock aPB2)
				{
					BOPTools_CommonBlock_SetPaveBlock236FC67E4(Instance, aPB2.Instance);
				}
			public BOPToolsPaveBlock PaveBlock1()
				{
					return new BOPToolsPaveBlock(BOPTools_CommonBlock_PaveBlock1(Instance));
				}
			public BOPToolsPaveBlock PaveBlock1(int anIndex)
				{
					return new BOPToolsPaveBlock(BOPTools_CommonBlock_PaveBlock1E8219145(Instance, anIndex));
				}
			public BOPToolsPaveBlock PaveBlock2()
				{
					return new BOPToolsPaveBlock(BOPTools_CommonBlock_PaveBlock2(Instance));
				}
			public BOPToolsPaveBlock PaveBlock2(int anIndex)
				{
					return new BOPToolsPaveBlock(BOPTools_CommonBlock_PaveBlock2E8219145(Instance, anIndex));
				}
		public int Face{
			set { 
				BOPTools_CommonBlock_SetFace(Instance, value);
			}
			get {
				return BOPTools_CommonBlock_Face(Instance);
			}
		}
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr BOPTools_CommonBlock_Ctor();
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr BOPTools_CommonBlock_CtorA5B57975(IntPtr aPB1,IntPtr aPB2);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr BOPTools_CommonBlock_CtorE11775D8(IntPtr aPB1,int aF);
		[DllImport("NaroOccCore.dll")]
		private static extern void BOPTools_CommonBlock_SetPaveBlock136FC67E4(IntPtr instance, IntPtr aPB1);
		[DllImport("NaroOccCore.dll")]
		private static extern void BOPTools_CommonBlock_SetPaveBlock236FC67E4(IntPtr instance, IntPtr aPB2);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr BOPTools_CommonBlock_PaveBlock1(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr BOPTools_CommonBlock_PaveBlock1E8219145(IntPtr instance, int anIndex);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr BOPTools_CommonBlock_PaveBlock2(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr BOPTools_CommonBlock_PaveBlock2E8219145(IntPtr instance, int anIndex);
		[DllImport("NaroOccCore.dll")]
		private static extern void BOPTools_CommonBlock_SetFace(IntPtr instance, int value);
		[DllImport("NaroOccCore.dll")]
		private static extern int BOPTools_CommonBlock_Face(IntPtr instance);

		#region NativeInstancePtr Convert constructor

		public BOPToolsCommonBlock(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ BOPToolsCommonBlock_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void BOPToolsCommonBlock_Dtor(IntPtr instance);
	}
}
