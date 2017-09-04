#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;
using NaroCppCore.Occ.BRepBuilderAPI;
using NaroCppCore.Occ.TopoDS;
using NaroCppCore.Occ.gp;
using NaroCppCore.Occ.Geom;

#endregion

namespace NaroCppCore.Occ.BRepBuilderAPI
{
	public class BRepBuilderAPIMakeEdge : BRepBuilderAPIMakeShape
	{
		public BRepBuilderAPIMakeEdge()
 :
			base(BRepBuilderAPI_MakeEdge_Ctor() )
		{}
		public BRepBuilderAPIMakeEdge(TopoDSVertex V1,TopoDSVertex V2)
 :
			base(BRepBuilderAPI_MakeEdge_Ctor17F57B4B(V1.Instance, V2.Instance) )
		{}
		public BRepBuilderAPIMakeEdge(gpPnt P1,gpPnt P2)
 :
			base(BRepBuilderAPI_MakeEdge_Ctor5C63477E(P1.Instance, P2.Instance) )
		{}
		public BRepBuilderAPIMakeEdge(gpLin L)
 :
			base(BRepBuilderAPI_MakeEdge_Ctor9917D291(L.Instance) )
		{}
		public BRepBuilderAPIMakeEdge(gpLin L,double p1,double p2)
 :
			base(BRepBuilderAPI_MakeEdge_Ctor13A123E9(L.Instance, p1, p2) )
		{}
		public BRepBuilderAPIMakeEdge(gpLin L,gpPnt P1,gpPnt P2)
 :
			base(BRepBuilderAPI_MakeEdge_Ctor89D07A8C(L.Instance, P1.Instance, P2.Instance) )
		{}
		public BRepBuilderAPIMakeEdge(gpLin L,TopoDSVertex V1,TopoDSVertex V2)
 :
			base(BRepBuilderAPI_MakeEdge_Ctor1D47CBD(L.Instance, V1.Instance, V2.Instance) )
		{}
		public BRepBuilderAPIMakeEdge(gpCirc L)
 :
			base(BRepBuilderAPI_MakeEdge_Ctor727811A8(L.Instance) )
		{}
		public BRepBuilderAPIMakeEdge(gpCirc L,double p1,double p2)
 :
			base(BRepBuilderAPI_MakeEdge_CtorD1F21AD1(L.Instance, p1, p2) )
		{}
		public BRepBuilderAPIMakeEdge(gpCirc L,gpPnt P1,gpPnt P2)
 :
			base(BRepBuilderAPI_MakeEdge_CtorF9002809(L.Instance, P1.Instance, P2.Instance) )
		{}
		public BRepBuilderAPIMakeEdge(gpCirc L,TopoDSVertex V1,TopoDSVertex V2)
 :
			base(BRepBuilderAPI_MakeEdge_CtorE5C0731B(L.Instance, V1.Instance, V2.Instance) )
		{}
		public BRepBuilderAPIMakeEdge(gpElips L)
 :
			base(BRepBuilderAPI_MakeEdge_CtorAA0BF3BF(L.Instance) )
		{}
		public BRepBuilderAPIMakeEdge(gpElips L,double p1,double p2)
 :
			base(BRepBuilderAPI_MakeEdge_CtorE07A45E0(L.Instance, p1, p2) )
		{}
		public BRepBuilderAPIMakeEdge(gpElips L,gpPnt P1,gpPnt P2)
 :
			base(BRepBuilderAPI_MakeEdge_CtorF09C8A36(L.Instance, P1.Instance, P2.Instance) )
		{}
		public BRepBuilderAPIMakeEdge(gpElips L,TopoDSVertex V1,TopoDSVertex V2)
 :
			base(BRepBuilderAPI_MakeEdge_Ctor3CB9094F(L.Instance, V1.Instance, V2.Instance) )
		{}
		public BRepBuilderAPIMakeEdge(gpHypr L)
 :
			base(BRepBuilderAPI_MakeEdge_CtorF96BFAD7(L.Instance) )
		{}
		public BRepBuilderAPIMakeEdge(gpHypr L,double p1,double p2)
 :
			base(BRepBuilderAPI_MakeEdge_Ctor8CC08831(L.Instance, p1, p2) )
		{}
		public BRepBuilderAPIMakeEdge(gpHypr L,gpPnt P1,gpPnt P2)
 :
			base(BRepBuilderAPI_MakeEdge_Ctor23F161EC(L.Instance, P1.Instance, P2.Instance) )
		{}
		public BRepBuilderAPIMakeEdge(gpHypr L,TopoDSVertex V1,TopoDSVertex V2)
 :
			base(BRepBuilderAPI_MakeEdge_Ctor61331CF3(L.Instance, V1.Instance, V2.Instance) )
		{}
		public BRepBuilderAPIMakeEdge(gpParab L)
 :
			base(BRepBuilderAPI_MakeEdge_Ctor4008A9E4(L.Instance) )
		{}
		public BRepBuilderAPIMakeEdge(gpParab L,double p1,double p2)
 :
			base(BRepBuilderAPI_MakeEdge_Ctor8DF7070E(L.Instance, p1, p2) )
		{}
		public BRepBuilderAPIMakeEdge(gpParab L,gpPnt P1,gpPnt P2)
 :
			base(BRepBuilderAPI_MakeEdge_CtorB18E1764(L.Instance, P1.Instance, P2.Instance) )
		{}
		public BRepBuilderAPIMakeEdge(gpParab L,TopoDSVertex V1,TopoDSVertex V2)
 :
			base(BRepBuilderAPI_MakeEdge_CtorFB0B4975(L.Instance, V1.Instance, V2.Instance) )
		{}
		public BRepBuilderAPIMakeEdge(GeomCurve L)
 :
			base(BRepBuilderAPI_MakeEdge_CtorFF608AE4(L.Instance) )
		{}
		public BRepBuilderAPIMakeEdge(GeomCurve L,double p1,double p2)
 :
			base(BRepBuilderAPI_MakeEdge_CtorED53F64D(L.Instance, p1, p2) )
		{}
		public BRepBuilderAPIMakeEdge(GeomCurve L,gpPnt P1,gpPnt P2)
 :
			base(BRepBuilderAPI_MakeEdge_Ctor442B1D85(L.Instance, P1.Instance, P2.Instance) )
		{}
		public BRepBuilderAPIMakeEdge(GeomCurve L,TopoDSVertex V1,TopoDSVertex V2)
 :
			base(BRepBuilderAPI_MakeEdge_Ctor1D50351E(L.Instance, V1.Instance, V2.Instance) )
		{}
		public BRepBuilderAPIMakeEdge(GeomCurve L,gpPnt P1,gpPnt P2,double p1,double p2)
 :
			base(BRepBuilderAPI_MakeEdge_CtorAFABB219(L.Instance, P1.Instance, P2.Instance, p1, p2) )
		{}
		public BRepBuilderAPIMakeEdge(GeomCurve L,TopoDSVertex V1,TopoDSVertex V2,double p1,double p2)
 :
			base(BRepBuilderAPI_MakeEdge_CtorA7D86004(L.Instance, V1.Instance, V2.Instance, p1, p2) )
		{}
			public void Init(GeomCurve C)
				{
					BRepBuilderAPI_MakeEdge_InitFF608AE4(Instance, C.Instance);
				}
			public void Init(GeomCurve C,double p1,double p2)
				{
					BRepBuilderAPI_MakeEdge_InitED53F64D(Instance, C.Instance, p1, p2);
				}
			public void Init(GeomCurve C,gpPnt P1,gpPnt P2)
				{
					BRepBuilderAPI_MakeEdge_Init442B1D85(Instance, C.Instance, P1.Instance, P2.Instance);
				}
			public void Init(GeomCurve C,TopoDSVertex V1,TopoDSVertex V2)
				{
					BRepBuilderAPI_MakeEdge_Init1D50351E(Instance, C.Instance, V1.Instance, V2.Instance);
				}
			public void Init(GeomCurve C,gpPnt P1,gpPnt P2,double p1,double p2)
				{
					BRepBuilderAPI_MakeEdge_InitAFABB219(Instance, C.Instance, P1.Instance, P2.Instance, p1, p2);
				}
			public void Init(GeomCurve C,TopoDSVertex V1,TopoDSVertex V2,double p1,double p2)
				{
					BRepBuilderAPI_MakeEdge_InitA7D86004(Instance, C.Instance, V1.Instance, V2.Instance, p1, p2);
				}
		public bool IsDone{
			get {
				return BRepBuilderAPI_MakeEdge_IsDone(Instance);
			}
		}
		public BRepBuilderAPIEdgeError Error{
			get {
				return (BRepBuilderAPIEdgeError)BRepBuilderAPI_MakeEdge_Error(Instance);
			}
		}
		public TopoDSEdge Edge{
			get {
				return new TopoDSEdge(BRepBuilderAPI_MakeEdge_Edge(Instance));
			}
		}
		public TopoDSVertex Vertex1{
			get {
				return new TopoDSVertex(BRepBuilderAPI_MakeEdge_Vertex1(Instance));
			}
		}
		public TopoDSVertex Vertex2{
			get {
				return new TopoDSVertex(BRepBuilderAPI_MakeEdge_Vertex2(Instance));
			}
		}
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr BRepBuilderAPI_MakeEdge_Ctor();
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr BRepBuilderAPI_MakeEdge_Ctor17F57B4B(IntPtr V1,IntPtr V2);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr BRepBuilderAPI_MakeEdge_Ctor5C63477E(IntPtr P1,IntPtr P2);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr BRepBuilderAPI_MakeEdge_Ctor9917D291(IntPtr L);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr BRepBuilderAPI_MakeEdge_Ctor13A123E9(IntPtr L,double p1,double p2);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr BRepBuilderAPI_MakeEdge_Ctor89D07A8C(IntPtr L,IntPtr P1,IntPtr P2);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr BRepBuilderAPI_MakeEdge_Ctor1D47CBD(IntPtr L,IntPtr V1,IntPtr V2);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr BRepBuilderAPI_MakeEdge_Ctor727811A8(IntPtr L);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr BRepBuilderAPI_MakeEdge_CtorD1F21AD1(IntPtr L,double p1,double p2);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr BRepBuilderAPI_MakeEdge_CtorF9002809(IntPtr L,IntPtr P1,IntPtr P2);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr BRepBuilderAPI_MakeEdge_CtorE5C0731B(IntPtr L,IntPtr V1,IntPtr V2);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr BRepBuilderAPI_MakeEdge_CtorAA0BF3BF(IntPtr L);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr BRepBuilderAPI_MakeEdge_CtorE07A45E0(IntPtr L,double p1,double p2);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr BRepBuilderAPI_MakeEdge_CtorF09C8A36(IntPtr L,IntPtr P1,IntPtr P2);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr BRepBuilderAPI_MakeEdge_Ctor3CB9094F(IntPtr L,IntPtr V1,IntPtr V2);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr BRepBuilderAPI_MakeEdge_CtorF96BFAD7(IntPtr L);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr BRepBuilderAPI_MakeEdge_Ctor8CC08831(IntPtr L,double p1,double p2);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr BRepBuilderAPI_MakeEdge_Ctor23F161EC(IntPtr L,IntPtr P1,IntPtr P2);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr BRepBuilderAPI_MakeEdge_Ctor61331CF3(IntPtr L,IntPtr V1,IntPtr V2);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr BRepBuilderAPI_MakeEdge_Ctor4008A9E4(IntPtr L);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr BRepBuilderAPI_MakeEdge_Ctor8DF7070E(IntPtr L,double p1,double p2);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr BRepBuilderAPI_MakeEdge_CtorB18E1764(IntPtr L,IntPtr P1,IntPtr P2);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr BRepBuilderAPI_MakeEdge_CtorFB0B4975(IntPtr L,IntPtr V1,IntPtr V2);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr BRepBuilderAPI_MakeEdge_CtorFF608AE4(IntPtr L);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr BRepBuilderAPI_MakeEdge_CtorED53F64D(IntPtr L,double p1,double p2);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr BRepBuilderAPI_MakeEdge_Ctor442B1D85(IntPtr L,IntPtr P1,IntPtr P2);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr BRepBuilderAPI_MakeEdge_Ctor1D50351E(IntPtr L,IntPtr V1,IntPtr V2);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr BRepBuilderAPI_MakeEdge_CtorAFABB219(IntPtr L,IntPtr P1,IntPtr P2,double p1,double p2);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr BRepBuilderAPI_MakeEdge_CtorA7D86004(IntPtr L,IntPtr V1,IntPtr V2,double p1,double p2);
		[DllImport("NaroOccCore.dll")]
		private static extern void BRepBuilderAPI_MakeEdge_InitFF608AE4(IntPtr instance, IntPtr C);
		[DllImport("NaroOccCore.dll")]
		private static extern void BRepBuilderAPI_MakeEdge_InitED53F64D(IntPtr instance, IntPtr C,double p1,double p2);
		[DllImport("NaroOccCore.dll")]
		private static extern void BRepBuilderAPI_MakeEdge_Init442B1D85(IntPtr instance, IntPtr C,IntPtr P1,IntPtr P2);
		[DllImport("NaroOccCore.dll")]
		private static extern void BRepBuilderAPI_MakeEdge_Init1D50351E(IntPtr instance, IntPtr C,IntPtr V1,IntPtr V2);
		[DllImport("NaroOccCore.dll")]
		private static extern void BRepBuilderAPI_MakeEdge_InitAFABB219(IntPtr instance, IntPtr C,IntPtr P1,IntPtr P2,double p1,double p2);
		[DllImport("NaroOccCore.dll")]
		private static extern void BRepBuilderAPI_MakeEdge_InitA7D86004(IntPtr instance, IntPtr C,IntPtr V1,IntPtr V2,double p1,double p2);
		[DllImport("NaroOccCore.dll")]
		private static extern bool BRepBuilderAPI_MakeEdge_IsDone(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern int BRepBuilderAPI_MakeEdge_Error(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr BRepBuilderAPI_MakeEdge_Edge(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr BRepBuilderAPI_MakeEdge_Vertex1(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr BRepBuilderAPI_MakeEdge_Vertex2(IntPtr instance);

		#region NativeInstancePtr Convert constructor

		public BRepBuilderAPIMakeEdge(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ BRepBuilderAPIMakeEdge_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void BRepBuilderAPIMakeEdge_Dtor(IntPtr instance);
	}
}
