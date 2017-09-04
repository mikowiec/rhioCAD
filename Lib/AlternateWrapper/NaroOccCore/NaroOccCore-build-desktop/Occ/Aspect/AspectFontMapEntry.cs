#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;
using NaroCppCore.Occ.Aspect;

#endregion

namespace NaroCppCore.Occ.Aspect
{
	public class AspectFontMapEntry : NativeInstancePtr
	{
		public AspectFontMapEntry()
 :
			base(Aspect_FontMapEntry_Ctor() )
		{}
		public AspectFontMapEntry(int index,AspectFontStyle style)
 :
			base(Aspect_FontMapEntry_Ctor387C7A2F(index, style.Instance) )
		{}
		public AspectFontMapEntry(AspectFontMapEntry entry)
 :
			base(Aspect_FontMapEntry_CtorF998EDD2(entry.Instance) )
		{}
			public void SetValue(int index,AspectFontStyle style)
				{
					Aspect_FontMapEntry_SetValue387C7A2F(Instance, index, style.Instance);
				}
			public void SetValue(AspectFontMapEntry entry)
				{
					Aspect_FontMapEntry_SetValueF998EDD2(Instance, entry.Instance);
				}
			public void Free()
				{
					Aspect_FontMapEntry_Free(Instance);
				}
			public void Dump()
				{
					Aspect_FontMapEntry_Dump(Instance);
				}
		public AspectFontStyle Type{
			set { 
				Aspect_FontMapEntry_SetType(Instance, value.Instance);
			}
			get {
				return new AspectFontStyle(Aspect_FontMapEntry_Type(Instance));
			}
		}
		public int Index{
			set { 
				Aspect_FontMapEntry_SetIndex(Instance, value);
			}
			get {
				return Aspect_FontMapEntry_Index(Instance);
			}
		}
		public bool IsAllocated{
			get {
				return Aspect_FontMapEntry_IsAllocated(Instance);
			}
		}
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Aspect_FontMapEntry_Ctor();
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Aspect_FontMapEntry_Ctor387C7A2F(int index,IntPtr style);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Aspect_FontMapEntry_CtorF998EDD2(IntPtr entry);
		[DllImport("NaroOccCore.dll")]
		private static extern void Aspect_FontMapEntry_SetValue387C7A2F(IntPtr instance, int index,IntPtr style);
		[DllImport("NaroOccCore.dll")]
		private static extern void Aspect_FontMapEntry_SetValueF998EDD2(IntPtr instance, IntPtr entry);
		[DllImport("NaroOccCore.dll")]
		private static extern void Aspect_FontMapEntry_Free(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void Aspect_FontMapEntry_Dump(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void Aspect_FontMapEntry_SetType(IntPtr instance, IntPtr value);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Aspect_FontMapEntry_Type(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void Aspect_FontMapEntry_SetIndex(IntPtr instance, int value);
		[DllImport("NaroOccCore.dll")]
		private static extern int Aspect_FontMapEntry_Index(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool Aspect_FontMapEntry_IsAllocated(IntPtr instance);

		#region NativeInstancePtr Convert constructor

		public AspectFontMapEntry(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ AspectFontMapEntry_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void AspectFontMapEntry_Dtor(IntPtr instance);
	}
}
