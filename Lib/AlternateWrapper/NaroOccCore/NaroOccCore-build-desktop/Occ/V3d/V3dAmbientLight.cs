#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;
using NaroCppCore.Occ.V3d;
using NaroCppCore.Occ.Quantity;

#endregion

namespace NaroCppCore.Occ.V3d
{
	public class V3dAmbientLight : V3dLight
	{
		public V3dAmbientLight(V3dViewer VM,QuantityNameOfColor Color)
 :
			base(V3d_AmbientLight_Ctor185B9A99(VM.Instance, (int)Color) )
		{}
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr V3d_AmbientLight_Ctor185B9A99(IntPtr VM,int Color);

		#region NativeInstancePtr Convert constructor

		public V3dAmbientLight() { } 

		public V3dAmbientLight(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ V3dAmbientLight_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void V3dAmbientLight_Dtor(IntPtr instance);
	}
}
