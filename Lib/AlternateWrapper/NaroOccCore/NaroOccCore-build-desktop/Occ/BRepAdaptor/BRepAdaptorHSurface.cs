#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;
using NaroCppCore.Occ.Adaptor3d;
using NaroCppCore.Occ.BRepAdaptor;

#endregion

namespace NaroCppCore.Occ.BRepAdaptor
{
	public class BRepAdaptorHSurface : Adaptor3dHSurface
	{
		public BRepAdaptorHSurface()
 :
			base(BRepAdaptor_HSurface_Ctor() )
		{}
		public BRepAdaptorHSurface(BRepAdaptorSurface S)
 :
			base(BRepAdaptor_HSurface_CtorE0C6985A(S.Instance) )
		{}
			public void Set(BRepAdaptorSurface S)
				{
					BRepAdaptor_HSurface_SetE0C6985A(Instance, S.Instance);
				}
		public Adaptor3dSurface Surface{
			get {
				return new Adaptor3dSurface(BRepAdaptor_HSurface_Surface(Instance));
			}
		}
		public BRepAdaptorSurface ChangeSurface{
			get {
				return new BRepAdaptorSurface(BRepAdaptor_HSurface_ChangeSurface(Instance));
			}
		}
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr BRepAdaptor_HSurface_Ctor();
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr BRepAdaptor_HSurface_CtorE0C6985A(IntPtr S);
		[DllImport("NaroOccCore.dll")]
		private static extern void BRepAdaptor_HSurface_SetE0C6985A(IntPtr instance, IntPtr S);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr BRepAdaptor_HSurface_Surface(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr BRepAdaptor_HSurface_ChangeSurface(IntPtr instance);

		#region NativeInstancePtr Convert constructor

		public BRepAdaptorHSurface(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ BRepAdaptorHSurface_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void BRepAdaptorHSurface_Dtor(IntPtr instance);
	}
}
