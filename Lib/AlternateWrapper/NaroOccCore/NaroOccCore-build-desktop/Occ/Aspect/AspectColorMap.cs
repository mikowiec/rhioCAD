#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;
using NaroCppCore.Occ.MMgt;
using NaroCppCore.Occ.Aspect;

#endregion

namespace NaroCppCore.Occ.Aspect
{
	public class AspectColorMap : MMgtTShared
	{
			public int Index(int aColormapIndex)
				{
					return Aspect_ColorMap_IndexE8219145(Instance, aColormapIndex);
				}
			public void Dump()
				{
					Aspect_ColorMap_Dump(Instance);
				}
			public AspectColorMapEntry Entry(int AColorMapIndex)
				{
					return new AspectColorMapEntry(Aspect_ColorMap_EntryE8219145(Instance, AColorMapIndex));
				}
		public AspectTypeOfColorMap Type{
			get {
				return (AspectTypeOfColorMap)Aspect_ColorMap_Type(Instance);
			}
		}
		public int Size{
			get {
				return Aspect_ColorMap_Size(Instance);
			}
		}
		[DllImport("NaroOccCore.dll")]
		private static extern int Aspect_ColorMap_IndexE8219145(IntPtr instance, int aColormapIndex);
		[DllImport("NaroOccCore.dll")]
		private static extern void Aspect_ColorMap_Dump(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Aspect_ColorMap_EntryE8219145(IntPtr instance, int AColorMapIndex);
		[DllImport("NaroOccCore.dll")]
		private static extern int Aspect_ColorMap_Type(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern int Aspect_ColorMap_Size(IntPtr instance);

		#region NativeInstancePtr Convert constructor

		public AspectColorMap() { } 

		public AspectColorMap(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ AspectColorMap_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void AspectColorMap_Dtor(IntPtr instance);
	}
}
