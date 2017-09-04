#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;
using NaroCppCore.Occ.MMgt;
using NaroCppCore.Occ.Quantity;
using NaroCppCore.Occ.Aspect;

#endregion

namespace NaroCppCore.Occ.Aspect
{
	public class AspectAspectFillArea : MMgtTShared
	{
		public QuantityColor EdgeColor{
			set { 
				Aspect_AspectFillArea_SetEdgeColor(Instance, value.Instance);
			}
		}
		public AspectTypeOfLine EdgeLineType{
			set { 
				Aspect_AspectFillArea_SetEdgeLineType(Instance, (int)value);
			}
		}
		public double EdgeWidth{
			set { 
				Aspect_AspectFillArea_SetEdgeWidth(Instance, value);
			}
		}
		public QuantityColor InteriorColor{
			set { 
				Aspect_AspectFillArea_SetInteriorColor(Instance, value.Instance);
			}
		}
		public QuantityColor BackInteriorColor{
			set { 
				Aspect_AspectFillArea_SetBackInteriorColor(Instance, value.Instance);
			}
		}
		public AspectInteriorStyle InteriorStyle{
			set { 
				Aspect_AspectFillArea_SetInteriorStyle(Instance, (int)value);
			}
		}
		public AspectHatchStyle HatchStyle{
			set { 
				Aspect_AspectFillArea_SetHatchStyle(Instance, (int)value);
			}
			get {
				return (AspectHatchStyle)Aspect_AspectFillArea_HatchStyle(Instance);
			}
		}
		[DllImport("NaroOccCore.dll")]
		private static extern void Aspect_AspectFillArea_SetEdgeColor(IntPtr instance, IntPtr value);
		[DllImport("NaroOccCore.dll")]
		private static extern void Aspect_AspectFillArea_SetEdgeLineType(IntPtr instance, int value);
		[DllImport("NaroOccCore.dll")]
		private static extern void Aspect_AspectFillArea_SetEdgeWidth(IntPtr instance, double value);
		[DllImport("NaroOccCore.dll")]
		private static extern void Aspect_AspectFillArea_SetInteriorColor(IntPtr instance, IntPtr value);
		[DllImport("NaroOccCore.dll")]
		private static extern void Aspect_AspectFillArea_SetBackInteriorColor(IntPtr instance, IntPtr value);
		[DllImport("NaroOccCore.dll")]
		private static extern void Aspect_AspectFillArea_SetInteriorStyle(IntPtr instance, int value);
		[DllImport("NaroOccCore.dll")]
		private static extern void Aspect_AspectFillArea_SetHatchStyle(IntPtr instance, int value);
		[DllImport("NaroOccCore.dll")]
		private static extern int Aspect_AspectFillArea_HatchStyle(IntPtr instance);

		#region NativeInstancePtr Convert constructor

		public AspectAspectFillArea() { } 

		public AspectAspectFillArea(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ AspectAspectFillArea_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void AspectAspectFillArea_Dtor(IntPtr instance);
	}
}
