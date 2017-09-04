#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;
using NaroCppCore.Occ.Aspect;

#endregion

namespace NaroCppCore.Occ.Aspect
{
	public class AspectWidthMapEntry : NativeInstancePtr
	{
		public AspectWidthMapEntry()
 :
			base(Aspect_WidthMapEntry_Ctor() )
		{}
		public AspectWidthMapEntry(int index,AspectWidthOfLine style)
 :
			base(Aspect_WidthMapEntry_CtorA80F21D5(index, (int)style) )
		{}
		public AspectWidthMapEntry(int index,double width)
 :
			base(Aspect_WidthMapEntry_Ctor69F5FCCD(index, width) )
		{}
		public AspectWidthMapEntry(AspectWidthMapEntry entry)
 :
			base(Aspect_WidthMapEntry_Ctor290679CE(entry.Instance) )
		{}
			public void SetValue(int index,AspectWidthOfLine style)
				{
					Aspect_WidthMapEntry_SetValueA80F21D5(Instance, index, (int)style);
				}
			public void SetValue(int index,double width)
				{
					Aspect_WidthMapEntry_SetValue69F5FCCD(Instance, index, width);
				}
			public void SetValue(AspectWidthMapEntry entry)
				{
					Aspect_WidthMapEntry_SetValue290679CE(Instance, entry.Instance);
				}
			public void Free()
				{
					Aspect_WidthMapEntry_Free(Instance);
				}
			public void Dump()
				{
					Aspect_WidthMapEntry_Dump(Instance);
				}
		public AspectWidthOfLine Type{
			set { 
				Aspect_WidthMapEntry_SetType(Instance, (int)value);
			}
			get {
				return (AspectWidthOfLine)Aspect_WidthMapEntry_Type(Instance);
			}
		}
		public double Width{
			set { 
				Aspect_WidthMapEntry_SetWidth(Instance, value);
			}
			get {
				return Aspect_WidthMapEntry_Width(Instance);
			}
		}
		public int Index{
			set { 
				Aspect_WidthMapEntry_SetIndex(Instance, value);
			}
			get {
				return Aspect_WidthMapEntry_Index(Instance);
			}
		}
		public bool IsAllocated{
			get {
				return Aspect_WidthMapEntry_IsAllocated(Instance);
			}
		}
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Aspect_WidthMapEntry_Ctor();
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Aspect_WidthMapEntry_CtorA80F21D5(int index,int style);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Aspect_WidthMapEntry_Ctor69F5FCCD(int index,double width);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Aspect_WidthMapEntry_Ctor290679CE(IntPtr entry);
		[DllImport("NaroOccCore.dll")]
		private static extern void Aspect_WidthMapEntry_SetValueA80F21D5(IntPtr instance, int index,int style);
		[DllImport("NaroOccCore.dll")]
		private static extern void Aspect_WidthMapEntry_SetValue69F5FCCD(IntPtr instance, int index,double width);
		[DllImport("NaroOccCore.dll")]
		private static extern void Aspect_WidthMapEntry_SetValue290679CE(IntPtr instance, IntPtr entry);
		[DllImport("NaroOccCore.dll")]
		private static extern void Aspect_WidthMapEntry_Free(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void Aspect_WidthMapEntry_Dump(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void Aspect_WidthMapEntry_SetType(IntPtr instance, int value);
		[DllImport("NaroOccCore.dll")]
		private static extern int Aspect_WidthMapEntry_Type(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void Aspect_WidthMapEntry_SetWidth(IntPtr instance, double value);
		[DllImport("NaroOccCore.dll")]
		private static extern double Aspect_WidthMapEntry_Width(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void Aspect_WidthMapEntry_SetIndex(IntPtr instance, int value);
		[DllImport("NaroOccCore.dll")]
		private static extern int Aspect_WidthMapEntry_Index(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool Aspect_WidthMapEntry_IsAllocated(IntPtr instance);

		#region NativeInstancePtr Convert constructor

		public AspectWidthMapEntry(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ AspectWidthMapEntry_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void AspectWidthMapEntry_Dtor(IntPtr instance);
	}
}
