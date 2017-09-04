#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;
using NaroCppCore.Occ.TopAbs;
using NaroCppCore.Occ.TopoDS;

#endregion

namespace NaroCppCore.Occ.BRepClass3d
{
	public class BRepClass3dSClassifier : NativeInstancePtr
	{
		public BRepClass3dSClassifier()
 :
			base(BRepClass3d_SClassifier_Ctor() )
		{}
		public bool Rejected{
			get {
				return BRepClass3d_SClassifier_Rejected(Instance);
			}
		}
		public TopAbsState State{
			get {
				return (TopAbsState)BRepClass3d_SClassifier_State(Instance);
			}
		}
		public bool IsOnAFace{
			get {
				return BRepClass3d_SClassifier_IsOnAFace(Instance);
			}
		}
		public TopoDSFace Face{
			get {
				return new TopoDSFace(BRepClass3d_SClassifier_Face(Instance));
			}
		}
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr BRepClass3d_SClassifier_Ctor();
		[DllImport("NaroOccCore.dll")]
		private static extern bool BRepClass3d_SClassifier_Rejected(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern int BRepClass3d_SClassifier_State(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool BRepClass3d_SClassifier_IsOnAFace(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr BRepClass3d_SClassifier_Face(IntPtr instance);

		#region NativeInstancePtr Convert constructor

		public BRepClass3dSClassifier(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ BRepClass3dSClassifier_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void BRepClass3dSClassifier_Dtor(IntPtr instance);
	}
}
