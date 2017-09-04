#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;
using NaroCppCore.Occ.Quantity;
using NaroCppCore.Occ.Aspect;

#endregion

namespace NaroCppCore.Occ.Aspect
{
	public class AspectColorMapEntry : NativeInstancePtr
	{
		public AspectColorMapEntry()
 :
			base(Aspect_ColorMapEntry_Ctor() )
		{}
		public AspectColorMapEntry(int index,QuantityColor rgb)
 :
			base(Aspect_ColorMapEntry_Ctor8575C8EE(index, rgb.Instance) )
		{}
		public AspectColorMapEntry(AspectColorMapEntry entry)
 :
			base(Aspect_ColorMapEntry_CtorE9FD56D3(entry.Instance) )
		{}
			public void SetValue(int index,QuantityColor rgb)
				{
					Aspect_ColorMapEntry_SetValue8575C8EE(Instance, index, rgb.Instance);
				}
			public void SetValue(AspectColorMapEntry entry)
				{
					Aspect_ColorMapEntry_SetValueE9FD56D3(Instance, entry.Instance);
				}
			public void Free()
				{
					Aspect_ColorMapEntry_Free(Instance);
				}
			public void Dump()
				{
					Aspect_ColorMapEntry_Dump(Instance);
				}
		public QuantityColor Color{
			set { 
				Aspect_ColorMapEntry_SetColor(Instance, value.Instance);
			}
			get {
				return new QuantityColor(Aspect_ColorMapEntry_Color(Instance));
			}
		}
		public int Index{
			set { 
				Aspect_ColorMapEntry_SetIndex(Instance, value);
			}
			get {
				return Aspect_ColorMapEntry_Index(Instance);
			}
		}
		public bool IsAllocated{
			get {
				return Aspect_ColorMapEntry_IsAllocated(Instance);
			}
		}
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Aspect_ColorMapEntry_Ctor();
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Aspect_ColorMapEntry_Ctor8575C8EE(int index,IntPtr rgb);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Aspect_ColorMapEntry_CtorE9FD56D3(IntPtr entry);
		[DllImport("NaroOccCore.dll")]
		private static extern void Aspect_ColorMapEntry_SetValue8575C8EE(IntPtr instance, int index,IntPtr rgb);
		[DllImport("NaroOccCore.dll")]
		private static extern void Aspect_ColorMapEntry_SetValueE9FD56D3(IntPtr instance, IntPtr entry);
		[DllImport("NaroOccCore.dll")]
		private static extern void Aspect_ColorMapEntry_Free(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void Aspect_ColorMapEntry_Dump(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void Aspect_ColorMapEntry_SetColor(IntPtr instance, IntPtr value);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Aspect_ColorMapEntry_Color(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void Aspect_ColorMapEntry_SetIndex(IntPtr instance, int value);
		[DllImport("NaroOccCore.dll")]
		private static extern int Aspect_ColorMapEntry_Index(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool Aspect_ColorMapEntry_IsAllocated(IntPtr instance);

		#region NativeInstancePtr Convert constructor

		public AspectColorMapEntry(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ AspectColorMapEntry_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void AspectColorMapEntry_Dtor(IntPtr instance);
	}
}
