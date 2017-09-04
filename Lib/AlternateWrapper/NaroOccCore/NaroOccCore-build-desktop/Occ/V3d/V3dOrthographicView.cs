#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;
using NaroCppCore.Occ.V3d;

#endregion

namespace NaroCppCore.Occ.V3d
{
	public class V3dOrthographicView : V3dView
	{
		public V3dOrthographicView(V3dViewer VM)
 :
			base(V3d_OrthographicView_Ctor79560492(VM.Instance) )
		{}
		public V3dOrthographicView(V3dViewer VM,V3dPerspectiveView V)
 :
			base(V3d_OrthographicView_Ctor4B0A5FC8(VM.Instance, V.Instance) )
		{}
		public V3dOrthographicView(V3dViewer VM,V3dOrthographicView V)
 :
			base(V3d_OrthographicView_Ctor4E6B6F5D(VM.Instance, V.Instance) )
		{}
		public V3dOrthographicView Copy{
			get {
				return new V3dOrthographicView(V3d_OrthographicView_Copy(Instance));
			}
		}
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr V3d_OrthographicView_Ctor79560492(IntPtr VM);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr V3d_OrthographicView_Ctor4B0A5FC8(IntPtr VM,IntPtr V);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr V3d_OrthographicView_Ctor4E6B6F5D(IntPtr VM,IntPtr V);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr V3d_OrthographicView_Copy(IntPtr instance);

		#region NativeInstancePtr Convert constructor

		public V3dOrthographicView() { } 

		public V3dOrthographicView(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ V3dOrthographicView_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void V3dOrthographicView_Dtor(IntPtr instance);
	}
}
