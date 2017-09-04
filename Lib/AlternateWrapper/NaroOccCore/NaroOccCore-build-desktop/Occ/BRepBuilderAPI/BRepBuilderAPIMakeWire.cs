#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;
using NaroCppCore.Occ.BRepBuilderAPI;
using NaroCppCore.Occ.TopoDS;
using NaroCppCore.Occ.TopTools;

#endregion

namespace NaroCppCore.Occ.BRepBuilderAPI
{
	public class BRepBuilderAPIMakeWire : BRepBuilderAPIMakeShape
	{
		public BRepBuilderAPIMakeWire()
 :
			base(BRepBuilderAPI_MakeWire_Ctor() )
		{}
		public BRepBuilderAPIMakeWire(TopoDSEdge E)
 :
			base(BRepBuilderAPI_MakeWire_Ctor24263856(E.Instance) )
		{}
		public BRepBuilderAPIMakeWire(TopoDSEdge E1,TopoDSEdge E2)
 :
			base(BRepBuilderAPI_MakeWire_Ctor4DFF7017(E1.Instance, E2.Instance) )
		{}
		public BRepBuilderAPIMakeWire(TopoDSEdge E1,TopoDSEdge E2,TopoDSEdge E3)
 :
			base(BRepBuilderAPI_MakeWire_CtorFC90A78C(E1.Instance, E2.Instance, E3.Instance) )
		{}
		public BRepBuilderAPIMakeWire(TopoDSEdge E1,TopoDSEdge E2,TopoDSEdge E3,TopoDSEdge E4)
 :
			base(BRepBuilderAPI_MakeWire_Ctor4181D08D(E1.Instance, E2.Instance, E3.Instance, E4.Instance) )
		{}
		public BRepBuilderAPIMakeWire(TopoDSWire W)
 :
			base(BRepBuilderAPI_MakeWire_Ctor368EDFE5(W.Instance) )
		{}
		public BRepBuilderAPIMakeWire(TopoDSWire W,TopoDSEdge E)
 :
			base(BRepBuilderAPI_MakeWire_Ctor23F02239(W.Instance, E.Instance) )
		{}
			public void Add(TopoDSEdge E)
				{
					BRepBuilderAPI_MakeWire_Add24263856(Instance, E.Instance);
				}
			public void Add(TopoDSWire W)
				{
					BRepBuilderAPI_MakeWire_Add368EDFE5(Instance, W.Instance);
				}
			public void Add(TopToolsListOfShape L)
				{
					BRepBuilderAPI_MakeWire_Add49A1D41A(Instance, L.Instance);
				}
		public bool IsDone{
			get {
				return BRepBuilderAPI_MakeWire_IsDone(Instance);
			}
		}
		public BRepBuilderAPIWireError Error{
			get {
				return (BRepBuilderAPIWireError)BRepBuilderAPI_MakeWire_Error(Instance);
			}
		}
		public TopoDSWire Wire{
			get {
				return new TopoDSWire(BRepBuilderAPI_MakeWire_Wire(Instance));
			}
		}
		public TopoDSEdge Edge{
			get {
				return new TopoDSEdge(BRepBuilderAPI_MakeWire_Edge(Instance));
			}
		}
		public TopoDSVertex Vertex{
			get {
				return new TopoDSVertex(BRepBuilderAPI_MakeWire_Vertex(Instance));
			}
		}
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr BRepBuilderAPI_MakeWire_Ctor();
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr BRepBuilderAPI_MakeWire_Ctor24263856(IntPtr E);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr BRepBuilderAPI_MakeWire_Ctor4DFF7017(IntPtr E1,IntPtr E2);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr BRepBuilderAPI_MakeWire_CtorFC90A78C(IntPtr E1,IntPtr E2,IntPtr E3);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr BRepBuilderAPI_MakeWire_Ctor4181D08D(IntPtr E1,IntPtr E2,IntPtr E3,IntPtr E4);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr BRepBuilderAPI_MakeWire_Ctor368EDFE5(IntPtr W);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr BRepBuilderAPI_MakeWire_Ctor23F02239(IntPtr W,IntPtr E);
		[DllImport("NaroOccCore.dll")]
		private static extern void BRepBuilderAPI_MakeWire_Add24263856(IntPtr instance, IntPtr E);
		[DllImport("NaroOccCore.dll")]
		private static extern void BRepBuilderAPI_MakeWire_Add368EDFE5(IntPtr instance, IntPtr W);
		[DllImport("NaroOccCore.dll")]
		private static extern void BRepBuilderAPI_MakeWire_Add49A1D41A(IntPtr instance, IntPtr L);
		[DllImport("NaroOccCore.dll")]
		private static extern bool BRepBuilderAPI_MakeWire_IsDone(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern int BRepBuilderAPI_MakeWire_Error(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr BRepBuilderAPI_MakeWire_Wire(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr BRepBuilderAPI_MakeWire_Edge(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr BRepBuilderAPI_MakeWire_Vertex(IntPtr instance);

		#region NativeInstancePtr Convert constructor

		public BRepBuilderAPIMakeWire(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ BRepBuilderAPIMakeWire_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void BRepBuilderAPIMakeWire_Dtor(IntPtr instance);
	}
}
