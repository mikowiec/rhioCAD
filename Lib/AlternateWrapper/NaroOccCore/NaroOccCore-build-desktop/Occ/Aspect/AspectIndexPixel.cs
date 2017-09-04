#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;
using NaroCppCore.Occ.Aspect;

#endregion

namespace NaroCppCore.Occ.Aspect
{
	public class AspectIndexPixel : AspectPixel
	{
		public AspectIndexPixel()
 :
			base(Aspect_IndexPixel_Ctor() )
		{}
		public AspectIndexPixel(int anIndex)
 :
			base(Aspect_IndexPixel_CtorE8219145(anIndex) )
		{}
			public int HashCode(int Upper)
				{
					return Aspect_IndexPixel_HashCodeE8219145(Instance, Upper);
				}
			public bool IsEqual(AspectIndexPixel Other)
				{
					return Aspect_IndexPixel_IsEqual24DA5CD5(Instance, Other.Instance);
				}
			public bool IsNotEqual(AspectIndexPixel Other)
				{
					return Aspect_IndexPixel_IsNotEqual24DA5CD5(Instance, Other.Instance);
				}
		public int Value{
			set { 
				Aspect_IndexPixel_SetValue(Instance, value);
			}
			get {
				return Aspect_IndexPixel_Value(Instance);
			}
		}
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Aspect_IndexPixel_Ctor();
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Aspect_IndexPixel_CtorE8219145(int anIndex);
		[DllImport("NaroOccCore.dll")]
		private static extern int Aspect_IndexPixel_HashCodeE8219145(IntPtr instance, int Upper);
		[DllImport("NaroOccCore.dll")]
		private static extern bool Aspect_IndexPixel_IsEqual24DA5CD5(IntPtr instance, IntPtr Other);
		[DllImport("NaroOccCore.dll")]
		private static extern bool Aspect_IndexPixel_IsNotEqual24DA5CD5(IntPtr instance, IntPtr Other);
		[DllImport("NaroOccCore.dll")]
		private static extern void Aspect_IndexPixel_SetValue(IntPtr instance, int value);
		[DllImport("NaroOccCore.dll")]
		private static extern int Aspect_IndexPixel_Value(IntPtr instance);

		#region NativeInstancePtr Convert constructor

		public AspectIndexPixel(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ AspectIndexPixel_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void AspectIndexPixel_Dtor(IntPtr instance);
	}
}
