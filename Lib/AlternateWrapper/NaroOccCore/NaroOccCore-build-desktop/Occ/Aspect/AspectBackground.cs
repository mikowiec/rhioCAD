#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;
using NaroCppCore.Occ.Quantity;

#endregion

namespace NaroCppCore.Occ.Aspect
{
	public class AspectBackground : NativeInstancePtr
	{
		public AspectBackground()
 :
			base(Aspect_Background_Ctor() )
		{}
		public AspectBackground(QuantityColor AColor)
 :
			base(Aspect_Background_Ctor8FD7F48(AColor.Instance) )
		{}
		public QuantityColor Color{
			set { 
				Aspect_Background_SetColor(Instance, value.Instance);
			}
			get {
				return new QuantityColor(Aspect_Background_Color(Instance));
			}
		}
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Aspect_Background_Ctor();
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Aspect_Background_Ctor8FD7F48(IntPtr AColor);
		[DllImport("NaroOccCore.dll")]
		private static extern void Aspect_Background_SetColor(IntPtr instance, IntPtr value);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Aspect_Background_Color(IntPtr instance);

		#region NativeInstancePtr Convert constructor

		public AspectBackground(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ AspectBackground_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void AspectBackground_Dtor(IntPtr instance);
	}
}
