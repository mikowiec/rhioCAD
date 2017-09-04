#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;
using NaroCppCore.Occ.TopoDS;
using NaroCppCore.Occ.TopAbs;

#endregion

namespace NaroCppCore.Occ.BRepTools
{
	public class BRepToolsWireExplorer : NativeInstancePtr
	{
		public BRepToolsWireExplorer()
 :
			base(BRepTools_WireExplorer_Ctor() )
		{}
		public BRepToolsWireExplorer(TopoDSWire W)
 :
			base(BRepTools_WireExplorer_Ctor368EDFE5(W.Instance) )
		{}
		public BRepToolsWireExplorer(TopoDSWire W,TopoDSFace F)
 :
			base(BRepTools_WireExplorer_Ctor3BE52234(W.Instance, F.Instance) )
		{}
			public void Init(TopoDSWire W)
				{
					BRepTools_WireExplorer_Init368EDFE5(Instance, W.Instance);
				}
			public void Init(TopoDSWire W,TopoDSFace F)
				{
					BRepTools_WireExplorer_Init3BE52234(Instance, W.Instance, F.Instance);
				}
			public void Next()
				{
					BRepTools_WireExplorer_Next(Instance);
				}
			public void Clear()
				{
					BRepTools_WireExplorer_Clear(Instance);
				}
		public bool More{
			get {
				return BRepTools_WireExplorer_More(Instance);
			}
		}
		public TopoDSEdge Current{
			get {
				return new TopoDSEdge(BRepTools_WireExplorer_Current(Instance));
			}
		}
		public TopAbsOrientation Orientation{
			get {
				return (TopAbsOrientation)BRepTools_WireExplorer_Orientation(Instance);
			}
		}
		public TopoDSVertex CurrentVertex{
			get {
				return new TopoDSVertex(BRepTools_WireExplorer_CurrentVertex(Instance));
			}
		}
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr BRepTools_WireExplorer_Ctor();
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr BRepTools_WireExplorer_Ctor368EDFE5(IntPtr W);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr BRepTools_WireExplorer_Ctor3BE52234(IntPtr W,IntPtr F);
		[DllImport("NaroOccCore.dll")]
		private static extern void BRepTools_WireExplorer_Init368EDFE5(IntPtr instance, IntPtr W);
		[DllImport("NaroOccCore.dll")]
		private static extern void BRepTools_WireExplorer_Init3BE52234(IntPtr instance, IntPtr W,IntPtr F);
		[DllImport("NaroOccCore.dll")]
		private static extern void BRepTools_WireExplorer_Next(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void BRepTools_WireExplorer_Clear(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool BRepTools_WireExplorer_More(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr BRepTools_WireExplorer_Current(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern int BRepTools_WireExplorer_Orientation(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr BRepTools_WireExplorer_CurrentVertex(IntPtr instance);

		#region NativeInstancePtr Convert constructor

		public BRepToolsWireExplorer(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ BRepToolsWireExplorer_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void BRepToolsWireExplorer_Dtor(IntPtr instance);
	}
}
