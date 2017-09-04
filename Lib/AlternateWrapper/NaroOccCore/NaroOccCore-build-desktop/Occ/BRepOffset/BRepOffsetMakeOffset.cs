#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;
using NaroCppCore.Occ.TopoDS;
using NaroCppCore.Occ.BRepOffset;
using NaroCppCore.Occ.GeomAbs;

#endregion

namespace NaroCppCore.Occ.BRepOffset
{
	public class BRepOffsetMakeOffset : NativeInstancePtr
	{
		public BRepOffsetMakeOffset()
 :
			base(BRepOffset_MakeOffset_Ctor() )
		{}
			public void Initialize(TopoDSShape S,double Offset,double Tol,BRepOffsetMode Mode,bool Intersection,bool SelfInter,GeomAbsJoinType Join)
				{
					BRepOffset_MakeOffset_Initialize72D69762(Instance, S.Instance, Offset, Tol, (int)Mode, Intersection, SelfInter, (int)Join);
				}
			public void MakeThickSolid()
				{
					BRepOffset_MakeOffset_MakeThickSolid(Instance);
				}
		public TopoDSShape Shape{
			get {
				return new TopoDSShape(BRepOffset_MakeOffset_Shape(Instance));
			}
		}
		public bool IsDone{
			get {
				return BRepOffset_MakeOffset_IsDone(Instance);
			}
		}
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr BRepOffset_MakeOffset_Ctor();
		[DllImport("NaroOccCore.dll")]
		private static extern void BRepOffset_MakeOffset_Initialize72D69762(IntPtr instance, IntPtr S,double Offset,double Tol,int Mode,bool Intersection,bool SelfInter,int Join);
		[DllImport("NaroOccCore.dll")]
		private static extern void BRepOffset_MakeOffset_MakeThickSolid(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr BRepOffset_MakeOffset_Shape(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool BRepOffset_MakeOffset_IsDone(IntPtr instance);

		#region NativeInstancePtr Convert constructor

		public BRepOffsetMakeOffset(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ BRepOffsetMakeOffset_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void BRepOffsetMakeOffset_Dtor(IntPtr instance);
	}
}
