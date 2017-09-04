#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;
using NaroCppCore.Occ.TopoDS;
using NaroCppCore.Occ.gp;

#endregion

namespace NaroCppCore.Occ.BOP
{
	public class BOPFaceInfo : NativeInstancePtr
	{
		public BOPFaceInfo()
 :
			base(BOP_FaceInfo_Ctor() )
		{}
		public bool Passed{
			set { 
				BOP_FaceInfo_SetPassed(Instance, value);
			}
		}
		public TopoDSFace Face{
			set { 
				BOP_FaceInfo_SetFace(Instance, value.Instance);
			}
			get {
				return new TopoDSFace(BOP_FaceInfo_Face(Instance));
			}
		}
		public gpPnt POnEdge{
			set { 
				BOP_FaceInfo_SetPOnEdge(Instance, value.Instance);
			}
			get {
				return new gpPnt(BOP_FaceInfo_POnEdge(Instance));
			}
		}
		public gpPnt PInFace{
			set { 
				BOP_FaceInfo_SetPInFace(Instance, value.Instance);
			}
			get {
				return new gpPnt(BOP_FaceInfo_PInFace(Instance));
			}
		}
		public gpPnt2d PInFace2D{
			set { 
				BOP_FaceInfo_SetPInFace2D(Instance, value.Instance);
			}
			get {
				return new gpPnt2d(BOP_FaceInfo_PInFace2D(Instance));
			}
		}
		public gpDir Normal{
			set { 
				BOP_FaceInfo_SetNormal(Instance, value.Instance);
			}
			get {
				return new gpDir(BOP_FaceInfo_Normal(Instance));
			}
		}
		public bool IsPassed{
			get {
				return BOP_FaceInfo_IsPassed(Instance);
			}
		}
		public double Angle{
			set { 
				BOP_FaceInfo_SetAngle(Instance, value);
			}
			get {
				return BOP_FaceInfo_Angle(Instance);
			}
		}
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr BOP_FaceInfo_Ctor();
		[DllImport("NaroOccCore.dll")]
		private static extern void BOP_FaceInfo_SetPassed(IntPtr instance, bool value);
		[DllImport("NaroOccCore.dll")]
		private static extern void BOP_FaceInfo_SetFace(IntPtr instance, IntPtr value);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr BOP_FaceInfo_Face(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void BOP_FaceInfo_SetPOnEdge(IntPtr instance, IntPtr value);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr BOP_FaceInfo_POnEdge(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void BOP_FaceInfo_SetPInFace(IntPtr instance, IntPtr value);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr BOP_FaceInfo_PInFace(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void BOP_FaceInfo_SetPInFace2D(IntPtr instance, IntPtr value);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr BOP_FaceInfo_PInFace2D(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void BOP_FaceInfo_SetNormal(IntPtr instance, IntPtr value);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr BOP_FaceInfo_Normal(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool BOP_FaceInfo_IsPassed(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void BOP_FaceInfo_SetAngle(IntPtr instance, double value);
		[DllImport("NaroOccCore.dll")]
		private static extern double BOP_FaceInfo_Angle(IntPtr instance);

		#region NativeInstancePtr Convert constructor

		public BOPFaceInfo(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ BOPFaceInfo_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void BOPFaceInfo_Dtor(IntPtr instance);
	}
}
