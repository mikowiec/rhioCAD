#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;
using NaroCppCore.Occ.MMgt;
using NaroCppCore.Occ.Aspect;

#endregion

namespace NaroCppCore.Occ.Aspect
{
	public class AspectFontMap : MMgtTShared
	{
		public AspectFontMap()
 :
			base(Aspect_FontMap_Ctor() )
		{}
			public void AddEntry(AspectFontMapEntry AnEntry)
				{
					Aspect_FontMap_AddEntryF998EDD2(Instance, AnEntry.Instance);
				}
			public int AddEntry(AspectFontStyle aStyle)
				{
					return Aspect_FontMap_AddEntry8E648131(Instance, aStyle.Instance);
				}
			public int Index(int aFontmapIndex)
				{
					return Aspect_FontMap_IndexE8219145(Instance, aFontmapIndex);
				}
			public void Dump()
				{
					Aspect_FontMap_Dump(Instance);
				}
			public AspectFontMapEntry Entry(int AnIndex)
				{
					return new AspectFontMapEntry(Aspect_FontMap_EntryE8219145(Instance, AnIndex));
				}
		public int Size{
			get {
				return Aspect_FontMap_Size(Instance);
			}
		}
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Aspect_FontMap_Ctor();
		[DllImport("NaroOccCore.dll")]
		private static extern void Aspect_FontMap_AddEntryF998EDD2(IntPtr instance, IntPtr AnEntry);
		[DllImport("NaroOccCore.dll")]
		private static extern int Aspect_FontMap_AddEntry8E648131(IntPtr instance, IntPtr aStyle);
		[DllImport("NaroOccCore.dll")]
		private static extern int Aspect_FontMap_IndexE8219145(IntPtr instance, int aFontmapIndex);
		[DllImport("NaroOccCore.dll")]
		private static extern void Aspect_FontMap_Dump(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Aspect_FontMap_EntryE8219145(IntPtr instance, int AnIndex);
		[DllImport("NaroOccCore.dll")]
		private static extern int Aspect_FontMap_Size(IntPtr instance);

		#region NativeInstancePtr Convert constructor

		public AspectFontMap(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ AspectFontMap_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void AspectFontMap_Dtor(IntPtr instance);
	}
}
