#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;
using NaroCppCore.Occ.IntTools;

#endregion

namespace NaroCppCore.Occ.IntTools
{
	public class IntToolsPntOn2Faces : NativeInstancePtr
	{
		public IntToolsPntOn2Faces()
 :
			base(IntTools_PntOn2Faces_Ctor() )
		{}
		public IntToolsPntOn2Faces(IntToolsPntOnFace aP1,IntToolsPntOnFace aP2)
 :
			base(IntTools_PntOn2Faces_Ctor85669E67(aP1.Instance, aP2.Instance) )
		{}
		public bool Valid{
			set { 
				IntTools_PntOn2Faces_SetValid(Instance, value);
			}
		}
		public IntToolsPntOnFace P1{
			set { 
				IntTools_PntOn2Faces_SetP1(Instance, value.Instance);
			}
			get {
				return new IntToolsPntOnFace(IntTools_PntOn2Faces_P1(Instance));
			}
		}
		public IntToolsPntOnFace P2{
			set { 
				IntTools_PntOn2Faces_SetP2(Instance, value.Instance);
			}
			get {
				return new IntToolsPntOnFace(IntTools_PntOn2Faces_P2(Instance));
			}
		}
		public bool IsValid{
			get {
				return IntTools_PntOn2Faces_IsValid(Instance);
			}
		}
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr IntTools_PntOn2Faces_Ctor();
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr IntTools_PntOn2Faces_Ctor85669E67(IntPtr aP1,IntPtr aP2);
		[DllImport("NaroOccCore.dll")]
		private static extern void IntTools_PntOn2Faces_SetValid(IntPtr instance, bool value);
		[DllImport("NaroOccCore.dll")]
		private static extern void IntTools_PntOn2Faces_SetP1(IntPtr instance, IntPtr value);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr IntTools_PntOn2Faces_P1(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void IntTools_PntOn2Faces_SetP2(IntPtr instance, IntPtr value);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr IntTools_PntOn2Faces_P2(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool IntTools_PntOn2Faces_IsValid(IntPtr instance);

		#region NativeInstancePtr Convert constructor

		public IntToolsPntOn2Faces(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ IntToolsPntOn2Faces_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void IntToolsPntOn2Faces_Dtor(IntPtr instance);
	}
}
