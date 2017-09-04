#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;
using NaroCppCore.Occ.TopoDS;

#endregion

namespace NaroCppCore.Occ.BOP
{
	public class BOPEdgeInfo : NativeInstancePtr
	{
		public BOPEdgeInfo()
 :
			base(BOP_EdgeInfo_Ctor() )
		{}
		public bool InFlag{
			set { 
				BOP_EdgeInfo_SetInFlag(Instance, value);
			}
		}
		public TopoDSEdge Edge{
			set { 
				BOP_EdgeInfo_SetEdge(Instance, value.Instance);
			}
			get {
				return new TopoDSEdge(BOP_EdgeInfo_Edge(Instance));
			}
		}
		public bool Passed{
			set { 
				BOP_EdgeInfo_SetPassed(Instance, value);
			}
			get {
				return BOP_EdgeInfo_Passed(Instance);
			}
		}
		public double Angle{
			set { 
				BOP_EdgeInfo_SetAngle(Instance, value);
			}
			get {
				return BOP_EdgeInfo_Angle(Instance);
			}
		}
		public bool IsIn{
			get {
				return BOP_EdgeInfo_IsIn(Instance);
			}
		}
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr BOP_EdgeInfo_Ctor();
		[DllImport("NaroOccCore.dll")]
		private static extern void BOP_EdgeInfo_SetInFlag(IntPtr instance, bool value);
		[DllImport("NaroOccCore.dll")]
		private static extern void BOP_EdgeInfo_SetEdge(IntPtr instance, IntPtr value);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr BOP_EdgeInfo_Edge(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void BOP_EdgeInfo_SetPassed(IntPtr instance, bool value);
		[DllImport("NaroOccCore.dll")]
		private static extern bool BOP_EdgeInfo_Passed(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void BOP_EdgeInfo_SetAngle(IntPtr instance, double value);
		[DllImport("NaroOccCore.dll")]
		private static extern double BOP_EdgeInfo_Angle(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool BOP_EdgeInfo_IsIn(IntPtr instance);

		#region NativeInstancePtr Convert constructor

		public BOPEdgeInfo(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ BOPEdgeInfo_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void BOPEdgeInfo_Dtor(IntPtr instance);
	}
}
