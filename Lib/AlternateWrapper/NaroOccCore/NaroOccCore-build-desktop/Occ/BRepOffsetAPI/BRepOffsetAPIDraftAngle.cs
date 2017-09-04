#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;
using NaroCppCore.Occ.BRepBuilderAPI;
using NaroCppCore.Occ.TopoDS;
using NaroCppCore.Occ.Draft;
using NaroCppCore.Occ.gp;

#endregion

namespace NaroCppCore.Occ.BRepOffsetAPI
{
	public class BRepOffsetAPIDraftAngle : BRepBuilderAPIModifyShape
	{
		public BRepOffsetAPIDraftAngle()
 :
			base(BRepOffsetAPI_DraftAngle_Ctor() )
		{}
		public BRepOffsetAPIDraftAngle(TopoDSShape S)
 :
			base(BRepOffsetAPI_DraftAngle_Ctor9EBAC0C0(S.Instance) )
		{}
			public void Clear()
				{
					BRepOffsetAPI_DraftAngle_Clear(Instance);
				}
			public void Init(TopoDSShape S)
				{
					BRepOffsetAPI_DraftAngle_Init9EBAC0C0(Instance, S.Instance);
				}
			public void Add(TopoDSFace F,gpDir Direction,double Angle,gpPln NeutralPlane,bool Flag)
				{
					BRepOffsetAPI_DraftAngle_AddABCF3248(Instance, F.Instance, Direction.Instance, Angle, NeutralPlane.Instance, Flag);
				}
			public void Remove(TopoDSFace F)
				{
					BRepOffsetAPI_DraftAngle_RemoveAEC70AC1(Instance, F.Instance);
				}
			public void Build()
				{
					BRepOffsetAPI_DraftAngle_Build(Instance);
				}
			public void CorrectWires()
				{
					BRepOffsetAPI_DraftAngle_CorrectWires(Instance);
				}
		public bool AddDone{
			get {
				return BRepOffsetAPI_DraftAngle_AddDone(Instance);
			}
		}
		public TopoDSShape ProblematicShape{
			get {
				return new TopoDSShape(BRepOffsetAPI_DraftAngle_ProblematicShape(Instance));
			}
		}
		public DraftErrorStatus Status{
			get {
				return (DraftErrorStatus)BRepOffsetAPI_DraftAngle_Status(Instance);
			}
		}
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr BRepOffsetAPI_DraftAngle_Ctor();
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr BRepOffsetAPI_DraftAngle_Ctor9EBAC0C0(IntPtr S);
		[DllImport("NaroOccCore.dll")]
		private static extern void BRepOffsetAPI_DraftAngle_Clear(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void BRepOffsetAPI_DraftAngle_Init9EBAC0C0(IntPtr instance, IntPtr S);
		[DllImport("NaroOccCore.dll")]
		private static extern void BRepOffsetAPI_DraftAngle_AddABCF3248(IntPtr instance, IntPtr F,IntPtr Direction,double Angle,IntPtr NeutralPlane,bool Flag);
		[DllImport("NaroOccCore.dll")]
		private static extern void BRepOffsetAPI_DraftAngle_RemoveAEC70AC1(IntPtr instance, IntPtr F);
		[DllImport("NaroOccCore.dll")]
		private static extern void BRepOffsetAPI_DraftAngle_Build(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void BRepOffsetAPI_DraftAngle_CorrectWires(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool BRepOffsetAPI_DraftAngle_AddDone(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr BRepOffsetAPI_DraftAngle_ProblematicShape(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern int BRepOffsetAPI_DraftAngle_Status(IntPtr instance);

		#region NativeInstancePtr Convert constructor

		public BRepOffsetAPIDraftAngle(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ BRepOffsetAPIDraftAngle_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void BRepOffsetAPIDraftAngle_Dtor(IntPtr instance);
	}
}
