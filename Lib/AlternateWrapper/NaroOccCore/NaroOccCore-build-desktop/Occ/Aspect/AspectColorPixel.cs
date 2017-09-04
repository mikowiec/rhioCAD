#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;
using NaroCppCore.Occ.Aspect;
using NaroCppCore.Occ.Quantity;

#endregion

namespace NaroCppCore.Occ.Aspect
{
	public class AspectColorPixel : AspectPixel
	{
		public AspectColorPixel()
 :
			base(Aspect_ColorPixel_Ctor() )
		{}
		public AspectColorPixel(QuantityColor aColor)
 :
			base(Aspect_ColorPixel_Ctor8FD7F48(aColor.Instance) )
		{}
			public int HashCode(int Upper)
				{
					return Aspect_ColorPixel_HashCodeE8219145(Instance, Upper);
				}
			public bool IsEqual(AspectColorPixel Other)
				{
					return Aspect_ColorPixel_IsEqualBD406A6D(Instance, Other.Instance);
				}
			public bool IsNotEqual(AspectColorPixel Other)
				{
					return Aspect_ColorPixel_IsNotEqualBD406A6D(Instance, Other.Instance);
				}
		public QuantityColor Value{
			set { 
				Aspect_ColorPixel_SetValue(Instance, value.Instance);
			}
			get {
				return new QuantityColor(Aspect_ColorPixel_Value(Instance));
			}
		}
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Aspect_ColorPixel_Ctor();
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Aspect_ColorPixel_Ctor8FD7F48(IntPtr aColor);
		[DllImport("NaroOccCore.dll")]
		private static extern int Aspect_ColorPixel_HashCodeE8219145(IntPtr instance, int Upper);
		[DllImport("NaroOccCore.dll")]
		private static extern bool Aspect_ColorPixel_IsEqualBD406A6D(IntPtr instance, IntPtr Other);
		[DllImport("NaroOccCore.dll")]
		private static extern bool Aspect_ColorPixel_IsNotEqualBD406A6D(IntPtr instance, IntPtr Other);
		[DllImport("NaroOccCore.dll")]
		private static extern void Aspect_ColorPixel_SetValue(IntPtr instance, IntPtr value);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Aspect_ColorPixel_Value(IntPtr instance);

		#region NativeInstancePtr Convert constructor

		public AspectColorPixel(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ AspectColorPixel_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void AspectColorPixel_Dtor(IntPtr instance);
	}
}
