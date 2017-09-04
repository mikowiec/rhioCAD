#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;
using NaroCppCore.Occ.Visual3d;

#endregion

namespace NaroCppCore.Occ.Visual3d
{
	public class Visual3dContextPick : NativeInstancePtr
	{
		public Visual3dContextPick()
 :
			base(Visual3d_ContextPick_Ctor() )
		{}
		public Visual3dContextPick(double Aperture,int Depth,Visual3dTypeOfOrder Order)
 :
			base(Visual3d_ContextPick_CtorA3634D78(Aperture, Depth, (int)Order) )
		{}
		public double Aperture{
			set { 
				Visual3d_ContextPick_SetAperture(Instance, value);
			}
			get {
				return Visual3d_ContextPick_Aperture(Instance);
			}
		}
		public int Depth{
			set { 
				Visual3d_ContextPick_SetDepth(Instance, value);
			}
			get {
				return Visual3d_ContextPick_Depth(Instance);
			}
		}
		public Visual3dTypeOfOrder Order{
			set { 
				Visual3d_ContextPick_SetOrder(Instance, (int)value);
			}
			get {
				return (Visual3dTypeOfOrder)Visual3d_ContextPick_Order(Instance);
			}
		}
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Visual3d_ContextPick_Ctor();
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Visual3d_ContextPick_CtorA3634D78(double Aperture,int Depth,int Order);
		[DllImport("NaroOccCore.dll")]
		private static extern void Visual3d_ContextPick_SetAperture(IntPtr instance, double value);
		[DllImport("NaroOccCore.dll")]
		private static extern double Visual3d_ContextPick_Aperture(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void Visual3d_ContextPick_SetDepth(IntPtr instance, int value);
		[DllImport("NaroOccCore.dll")]
		private static extern int Visual3d_ContextPick_Depth(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void Visual3d_ContextPick_SetOrder(IntPtr instance, int value);
		[DllImport("NaroOccCore.dll")]
		private static extern int Visual3d_ContextPick_Order(IntPtr instance);

		#region NativeInstancePtr Convert constructor

		public Visual3dContextPick(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ Visual3dContextPick_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void Visual3dContextPick_Dtor(IntPtr instance);
	}
}
