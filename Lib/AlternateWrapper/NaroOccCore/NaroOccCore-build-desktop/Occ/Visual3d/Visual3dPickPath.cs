#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;

#endregion

namespace NaroCppCore.Occ.Visual3d
{
	public class Visual3dPickPath : NativeInstancePtr
	{
		public Visual3dPickPath()
 :
			base(Visual3d_PickPath_Ctor() )
		{}
		public int ElementNumber{
			set { 
				Visual3d_PickPath_SetElementNumber(Instance, value);
			}
			get {
				return Visual3d_PickPath_ElementNumber(Instance);
			}
		}
		public int PickIdentifier{
			set { 
				Visual3d_PickPath_SetPickIdentifier(Instance, value);
			}
			get {
				return Visual3d_PickPath_PickIdentifier(Instance);
			}
		}
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Visual3d_PickPath_Ctor();
		[DllImport("NaroOccCore.dll")]
		private static extern void Visual3d_PickPath_SetElementNumber(IntPtr instance, int value);
		[DllImport("NaroOccCore.dll")]
		private static extern int Visual3d_PickPath_ElementNumber(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void Visual3d_PickPath_SetPickIdentifier(IntPtr instance, int value);
		[DllImport("NaroOccCore.dll")]
		private static extern int Visual3d_PickPath_PickIdentifier(IntPtr instance);

		#region NativeInstancePtr Convert constructor

		public Visual3dPickPath(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ Visual3dPickPath_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void Visual3dPickPath_Dtor(IntPtr instance);
	}
}
