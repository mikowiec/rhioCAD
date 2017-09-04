#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;
using NaroCppCore.Occ.BRepBuilderAPI;
using NaroCppCore.Occ.TopoDS;
using NaroCppCore.Occ.GeomAbs;

#endregion

namespace NaroCppCore.Occ.BRepOffsetAPI
{
	public class BRepOffsetAPIMakeOffset : BRepBuilderAPIMakeShape
	{
		public BRepOffsetAPIMakeOffset()
 :
			base(BRepOffsetAPI_MakeOffset_Ctor() )
		{}
		public BRepOffsetAPIMakeOffset(TopoDSFace Spine,GeomAbsJoinType Join)
 :
			base(BRepOffsetAPI_MakeOffset_CtorA6167785(Spine.Instance, (int)Join) )
		{}
		public BRepOffsetAPIMakeOffset(TopoDSWire Spine,GeomAbsJoinType Join)
 :
			base(BRepOffsetAPI_MakeOffset_Ctor38E1F2B(Spine.Instance, (int)Join) )
		{}
			public void Init(TopoDSFace Spine,GeomAbsJoinType Join)
				{
					BRepOffsetAPI_MakeOffset_InitA6167785(Instance, Spine.Instance, (int)Join);
				}
			public void Init(GeomAbsJoinType Join)
				{
					BRepOffsetAPI_MakeOffset_InitAC370FAD(Instance, (int)Join);
				}
			public void AddWire(TopoDSWire Spine)
				{
					BRepOffsetAPI_MakeOffset_AddWire368EDFE5(Instance, Spine.Instance);
				}
			public void Perform(double Offset,double Alt)
				{
					BRepOffsetAPI_MakeOffset_Perform9F0E714F(Instance, Offset, Alt);
				}
			public void Build()
				{
					BRepOffsetAPI_MakeOffset_Build(Instance);
				}
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr BRepOffsetAPI_MakeOffset_Ctor();
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr BRepOffsetAPI_MakeOffset_CtorA6167785(IntPtr Spine,int Join);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr BRepOffsetAPI_MakeOffset_Ctor38E1F2B(IntPtr Spine,int Join);
		[DllImport("NaroOccCore.dll")]
		private static extern void BRepOffsetAPI_MakeOffset_InitA6167785(IntPtr instance, IntPtr Spine,int Join);
		[DllImport("NaroOccCore.dll")]
		private static extern void BRepOffsetAPI_MakeOffset_InitAC370FAD(IntPtr instance, int Join);
		[DllImport("NaroOccCore.dll")]
		private static extern void BRepOffsetAPI_MakeOffset_AddWire368EDFE5(IntPtr instance, IntPtr Spine);
		[DllImport("NaroOccCore.dll")]
		private static extern void BRepOffsetAPI_MakeOffset_Perform9F0E714F(IntPtr instance, double Offset,double Alt);
		[DllImport("NaroOccCore.dll")]
		private static extern void BRepOffsetAPI_MakeOffset_Build(IntPtr instance);

		#region NativeInstancePtr Convert constructor

		public BRepOffsetAPIMakeOffset(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ BRepOffsetAPIMakeOffset_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void BRepOffsetAPIMakeOffset_Dtor(IntPtr instance);
	}
}
