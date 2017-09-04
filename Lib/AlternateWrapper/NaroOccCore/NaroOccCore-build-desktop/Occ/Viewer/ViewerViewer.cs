#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;
using NaroCppCore.Occ.MMgt;
using NaroCppCore.Occ.Aspect;

#endregion

namespace NaroCppCore.Occ.Viewer
{
	public class ViewerViewer : MMgtTShared
	{
		public AspectGraphicDevice Device{
			get {
				return new AspectGraphicDevice(Viewer_Viewer_Device(Instance));
			}
		}
		public string Domain{
			get {
				return Viewer_Viewer_Domain(Instance);
			}
		}
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Viewer_Viewer_Device(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern string Viewer_Viewer_Domain(IntPtr instance);

		#region NativeInstancePtr Convert constructor

		public ViewerViewer() { } 

		public ViewerViewer(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ ViewerViewer_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void ViewerViewer_Dtor(IntPtr instance);
	}
}
