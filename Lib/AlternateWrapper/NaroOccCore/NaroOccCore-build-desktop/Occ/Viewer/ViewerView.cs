#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;
using NaroCppCore.Occ.MMgt;

#endregion

namespace NaroCppCore.Occ.Viewer
{
	public class ViewerView : MMgtTShared
	{
			public bool SetImmediateUpdate(bool onoff)
				{
					return Viewer_View_SetImmediateUpdate461FC46A(Instance, onoff);
				}
		[DllImport("NaroOccCore.dll")]
		private static extern bool Viewer_View_SetImmediateUpdate461FC46A(IntPtr instance, bool onoff);

		#region NativeInstancePtr Convert constructor

		public ViewerView() { } 

		public ViewerView(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ ViewerView_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void ViewerView_Dtor(IntPtr instance);
	}
}
