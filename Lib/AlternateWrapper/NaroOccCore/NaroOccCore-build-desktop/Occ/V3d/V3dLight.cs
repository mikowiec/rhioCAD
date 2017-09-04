#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;
using NaroCppCore.Occ.MMgt;
using NaroCppCore.Occ.V3d;

#endregion

namespace NaroCppCore.Occ.V3d
{
	public class V3dLight : MMgtTShared
	{
		public V3dTypeOfLight Type{
			get {
				return (V3dTypeOfLight)V3d_Light_Type(Instance);
			}
		}
		public bool Headlight{
			get {
				return V3d_Light_Headlight(Instance);
			}
		}
		public bool IsDisplayed{
			get {
				return V3d_Light_IsDisplayed(Instance);
			}
		}
		[DllImport("NaroOccCore.dll")]
		private static extern int V3d_Light_Type(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool V3d_Light_Headlight(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool V3d_Light_IsDisplayed(IntPtr instance);

		#region NativeInstancePtr Convert constructor

		public V3dLight() { } 

		public V3dLight(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ V3dLight_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void V3dLight_Dtor(IntPtr instance);
	}
}
