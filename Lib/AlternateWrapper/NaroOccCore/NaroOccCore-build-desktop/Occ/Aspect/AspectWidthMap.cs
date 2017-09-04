#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;
using NaroCppCore.Occ.MMgt;
using NaroCppCore.Occ.Aspect;

#endregion

namespace NaroCppCore.Occ.Aspect
{
	public class AspectWidthMap : MMgtTShared
	{
		public AspectWidthMap()
 :
			base(Aspect_WidthMap_Ctor() )
		{}
			public void AddEntry(AspectWidthMapEntry AnEntry)
				{
					Aspect_WidthMap_AddEntry290679CE(Instance, AnEntry.Instance);
				}
			public int AddEntry(AspectWidthOfLine aStyle)
				{
					return Aspect_WidthMap_AddEntry82DA6A16(Instance, (int)aStyle);
				}
			public int AddEntry(double aStyle)
				{
					return Aspect_WidthMap_AddEntryD82819F3(Instance, aStyle);
				}
			public int Index(int aWidthmapIndex)
				{
					return Aspect_WidthMap_IndexE8219145(Instance, aWidthmapIndex);
				}
			public AspectWidthMapEntry Entry(int AnIndex)
				{
					return new AspectWidthMapEntry(Aspect_WidthMap_EntryE8219145(Instance, AnIndex));
				}
			public void Dump()
				{
					Aspect_WidthMap_Dump(Instance);
				}
		public int Size{
			get {
				return Aspect_WidthMap_Size(Instance);
			}
		}
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Aspect_WidthMap_Ctor();
		[DllImport("NaroOccCore.dll")]
		private static extern void Aspect_WidthMap_AddEntry290679CE(IntPtr instance, IntPtr AnEntry);
		[DllImport("NaroOccCore.dll")]
		private static extern int Aspect_WidthMap_AddEntry82DA6A16(IntPtr instance, int aStyle);
		[DllImport("NaroOccCore.dll")]
		private static extern int Aspect_WidthMap_AddEntryD82819F3(IntPtr instance, double aStyle);
		[DllImport("NaroOccCore.dll")]
		private static extern int Aspect_WidthMap_IndexE8219145(IntPtr instance, int aWidthmapIndex);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Aspect_WidthMap_EntryE8219145(IntPtr instance, int AnIndex);
		[DllImport("NaroOccCore.dll")]
		private static extern void Aspect_WidthMap_Dump(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern int Aspect_WidthMap_Size(IntPtr instance);

		#region NativeInstancePtr Convert constructor

		public AspectWidthMap(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ AspectWidthMap_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void AspectWidthMap_Dtor(IntPtr instance);
	}
}
