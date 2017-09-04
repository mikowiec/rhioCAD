#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;
using NaroCppCore.Occ.MMgt;
using NaroCppCore.Occ.TopoDS;
using NaroCppCore.Occ.Message;

#endregion

namespace NaroCppCore.Occ.BRepBuilderAPI
{
	public class BRepBuilderAPISewing : MMgtTShared
	{
		public BRepBuilderAPISewing(double tolerance,bool option1,bool option2,bool option3,bool option4)
 :
			base(BRepBuilderAPI_Sewing_Ctor7CD625AC(tolerance, option1, option2, option3, option4) )
		{}
			public void Init(double tolerance,bool option1,bool option2,bool option3,bool option4)
				{
					BRepBuilderAPI_Sewing_Init7CD625AC(Instance, tolerance, option1, option2, option3, option4);
				}
			public void Load(TopoDSShape shape)
				{
					BRepBuilderAPI_Sewing_Load9EBAC0C0(Instance, shape.Instance);
				}
			public void Add(TopoDSShape shape)
				{
					BRepBuilderAPI_Sewing_Add9EBAC0C0(Instance, shape.Instance);
				}
			public void Perform(MessageProgressIndicator thePI)
				{
					BRepBuilderAPI_Sewing_Perform346F5010(Instance, thePI.Instance);
				}
			public TopoDSEdge FreeEdge(int index)
				{
					return new TopoDSEdge(BRepBuilderAPI_Sewing_FreeEdgeE8219145(Instance, index));
				}
			public TopoDSEdge MultipleEdge(int index)
				{
					return new TopoDSEdge(BRepBuilderAPI_Sewing_MultipleEdgeE8219145(Instance, index));
				}
			public TopoDSEdge ContigousEdge(int index)
				{
					return new TopoDSEdge(BRepBuilderAPI_Sewing_ContigousEdgeE8219145(Instance, index));
				}
			public bool IsSectionBound(TopoDSEdge section)
				{
					return BRepBuilderAPI_Sewing_IsSectionBound24263856(Instance, section.Instance);
				}
			public TopoDSEdge SectionToBoundary(TopoDSEdge section)
				{
					return new TopoDSEdge(BRepBuilderAPI_Sewing_SectionToBoundary24263856(Instance, section.Instance));
				}
			public TopoDSShape DegeneratedShape(int index)
				{
					return new TopoDSShape(BRepBuilderAPI_Sewing_DegeneratedShapeE8219145(Instance, index));
				}
			public bool IsDegenerated(TopoDSShape shape)
				{
					return BRepBuilderAPI_Sewing_IsDegenerated9EBAC0C0(Instance, shape.Instance);
				}
			public bool IsModified(TopoDSShape shape)
				{
					return BRepBuilderAPI_Sewing_IsModified9EBAC0C0(Instance, shape.Instance);
				}
			public TopoDSShape Modified(TopoDSShape shape)
				{
					return new TopoDSShape(BRepBuilderAPI_Sewing_Modified9EBAC0C0(Instance, shape.Instance));
				}
			public bool IsModifiedSubShape(TopoDSShape shape)
				{
					return BRepBuilderAPI_Sewing_IsModifiedSubShape9EBAC0C0(Instance, shape.Instance);
				}
			public TopoDSShape ModifiedSubShape(TopoDSShape shape)
				{
					return new TopoDSShape(BRepBuilderAPI_Sewing_ModifiedSubShape9EBAC0C0(Instance, shape.Instance));
				}
			public void Dump()
				{
					BRepBuilderAPI_Sewing_Dump(Instance);
				}
			public TopoDSFace DeletedFace(int index)
				{
					return new TopoDSFace(BRepBuilderAPI_Sewing_DeletedFaceE8219145(Instance, index));
				}
			public TopoDSFace WhichFace(TopoDSEdge theEdg,int index)
				{
					return new TopoDSFace(BRepBuilderAPI_Sewing_WhichFace3274CFB8(Instance, theEdg.Instance, index));
				}
		public TopoDSShape SewedShape{
			get {
				return new TopoDSShape(BRepBuilderAPI_Sewing_SewedShape(Instance));
			}
		}
		public int NbFreeEdges{
			get {
				return BRepBuilderAPI_Sewing_NbFreeEdges(Instance);
			}
		}
		public int NbMultipleEdges{
			get {
				return BRepBuilderAPI_Sewing_NbMultipleEdges(Instance);
			}
		}
		public int NbContigousEdges{
			get {
				return BRepBuilderAPI_Sewing_NbContigousEdges(Instance);
			}
		}
		public int NbDegeneratedShapes{
			get {
				return BRepBuilderAPI_Sewing_NbDegeneratedShapes(Instance);
			}
		}
		public int NbDeletedFaces{
			get {
				return BRepBuilderAPI_Sewing_NbDeletedFaces(Instance);
			}
		}
		public bool SameParameterMode{
			set { 
				BRepBuilderAPI_Sewing_SetSameParameterMode(Instance, value);
			}
			get {
				return BRepBuilderAPI_Sewing_SameParameterMode(Instance);
			}
		}
		public double Tolerance{
			set { 
				BRepBuilderAPI_Sewing_SetTolerance(Instance, value);
			}
			get {
				return BRepBuilderAPI_Sewing_Tolerance(Instance);
			}
		}
		public double MinTolerance{
			set { 
				BRepBuilderAPI_Sewing_SetMinTolerance(Instance, value);
			}
			get {
				return BRepBuilderAPI_Sewing_MinTolerance(Instance);
			}
		}
		public double MaxTolerance{
			set { 
				BRepBuilderAPI_Sewing_SetMaxTolerance(Instance, value);
			}
			get {
				return BRepBuilderAPI_Sewing_MaxTolerance(Instance);
			}
		}
		public bool FaceMode{
			set { 
				BRepBuilderAPI_Sewing_SetFaceMode(Instance, value);
			}
			get {
				return BRepBuilderAPI_Sewing_FaceMode(Instance);
			}
		}
		public bool FloatingEdgesMode{
			set { 
				BRepBuilderAPI_Sewing_SetFloatingEdgesMode(Instance, value);
			}
			get {
				return BRepBuilderAPI_Sewing_FloatingEdgesMode(Instance);
			}
		}
		public bool LocalTolerancesMode{
			set { 
				BRepBuilderAPI_Sewing_SetLocalTolerancesMode(Instance, value);
			}
			get {
				return BRepBuilderAPI_Sewing_LocalTolerancesMode(Instance);
			}
		}
		public bool NonManifoldMode{
			set { 
				BRepBuilderAPI_Sewing_SetNonManifoldMode(Instance, value);
			}
			get {
				return BRepBuilderAPI_Sewing_NonManifoldMode(Instance);
			}
		}
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr BRepBuilderAPI_Sewing_Ctor7CD625AC(double tolerance,bool option1,bool option2,bool option3,bool option4);
		[DllImport("NaroOccCore.dll")]
		private static extern void BRepBuilderAPI_Sewing_Init7CD625AC(IntPtr instance, double tolerance,bool option1,bool option2,bool option3,bool option4);
		[DllImport("NaroOccCore.dll")]
		private static extern void BRepBuilderAPI_Sewing_Load9EBAC0C0(IntPtr instance, IntPtr shape);
		[DllImport("NaroOccCore.dll")]
		private static extern void BRepBuilderAPI_Sewing_Add9EBAC0C0(IntPtr instance, IntPtr shape);
		[DllImport("NaroOccCore.dll")]
		private static extern void BRepBuilderAPI_Sewing_Perform346F5010(IntPtr instance, IntPtr thePI);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr BRepBuilderAPI_Sewing_FreeEdgeE8219145(IntPtr instance, int index);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr BRepBuilderAPI_Sewing_MultipleEdgeE8219145(IntPtr instance, int index);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr BRepBuilderAPI_Sewing_ContigousEdgeE8219145(IntPtr instance, int index);
		[DllImport("NaroOccCore.dll")]
		private static extern bool BRepBuilderAPI_Sewing_IsSectionBound24263856(IntPtr instance, IntPtr section);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr BRepBuilderAPI_Sewing_SectionToBoundary24263856(IntPtr instance, IntPtr section);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr BRepBuilderAPI_Sewing_DegeneratedShapeE8219145(IntPtr instance, int index);
		[DllImport("NaroOccCore.dll")]
		private static extern bool BRepBuilderAPI_Sewing_IsDegenerated9EBAC0C0(IntPtr instance, IntPtr shape);
		[DllImport("NaroOccCore.dll")]
		private static extern bool BRepBuilderAPI_Sewing_IsModified9EBAC0C0(IntPtr instance, IntPtr shape);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr BRepBuilderAPI_Sewing_Modified9EBAC0C0(IntPtr instance, IntPtr shape);
		[DllImport("NaroOccCore.dll")]
		private static extern bool BRepBuilderAPI_Sewing_IsModifiedSubShape9EBAC0C0(IntPtr instance, IntPtr shape);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr BRepBuilderAPI_Sewing_ModifiedSubShape9EBAC0C0(IntPtr instance, IntPtr shape);
		[DllImport("NaroOccCore.dll")]
		private static extern void BRepBuilderAPI_Sewing_Dump(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr BRepBuilderAPI_Sewing_DeletedFaceE8219145(IntPtr instance, int index);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr BRepBuilderAPI_Sewing_WhichFace3274CFB8(IntPtr instance, IntPtr theEdg,int index);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr BRepBuilderAPI_Sewing_SewedShape(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern int BRepBuilderAPI_Sewing_NbFreeEdges(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern int BRepBuilderAPI_Sewing_NbMultipleEdges(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern int BRepBuilderAPI_Sewing_NbContigousEdges(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern int BRepBuilderAPI_Sewing_NbDegeneratedShapes(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern int BRepBuilderAPI_Sewing_NbDeletedFaces(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void BRepBuilderAPI_Sewing_SetSameParameterMode(IntPtr instance, bool value);
		[DllImport("NaroOccCore.dll")]
		private static extern bool BRepBuilderAPI_Sewing_SameParameterMode(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void BRepBuilderAPI_Sewing_SetTolerance(IntPtr instance, double value);
		[DllImport("NaroOccCore.dll")]
		private static extern double BRepBuilderAPI_Sewing_Tolerance(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void BRepBuilderAPI_Sewing_SetMinTolerance(IntPtr instance, double value);
		[DllImport("NaroOccCore.dll")]
		private static extern double BRepBuilderAPI_Sewing_MinTolerance(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void BRepBuilderAPI_Sewing_SetMaxTolerance(IntPtr instance, double value);
		[DllImport("NaroOccCore.dll")]
		private static extern double BRepBuilderAPI_Sewing_MaxTolerance(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void BRepBuilderAPI_Sewing_SetFaceMode(IntPtr instance, bool value);
		[DllImport("NaroOccCore.dll")]
		private static extern bool BRepBuilderAPI_Sewing_FaceMode(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void BRepBuilderAPI_Sewing_SetFloatingEdgesMode(IntPtr instance, bool value);
		[DllImport("NaroOccCore.dll")]
		private static extern bool BRepBuilderAPI_Sewing_FloatingEdgesMode(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void BRepBuilderAPI_Sewing_SetLocalTolerancesMode(IntPtr instance, bool value);
		[DllImport("NaroOccCore.dll")]
		private static extern bool BRepBuilderAPI_Sewing_LocalTolerancesMode(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void BRepBuilderAPI_Sewing_SetNonManifoldMode(IntPtr instance, bool value);
		[DllImport("NaroOccCore.dll")]
		private static extern bool BRepBuilderAPI_Sewing_NonManifoldMode(IntPtr instance);

		#region NativeInstancePtr Convert constructor

		public BRepBuilderAPISewing() { } 

		public BRepBuilderAPISewing(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ BRepBuilderAPISewing_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void BRepBuilderAPISewing_Dtor(IntPtr instance);
	}
}
