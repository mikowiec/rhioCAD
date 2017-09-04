#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;
using NaroCppCore.Occ.TopTools;
using NaroCppCore.Occ.TopoDS;

#endregion

namespace NaroCppCore.Occ.ShapeAnalysis
{
	public class ShapeAnalysisShapeContents : NativeInstancePtr
	{
		public ShapeAnalysisShapeContents()
 :
			base(ShapeAnalysis_ShapeContents_Ctor() )
		{}
			public void Clear()
				{
					ShapeAnalysis_ShapeContents_Clear(Instance);
				}
			public void ClearFlags()
				{
					ShapeAnalysis_ShapeContents_ClearFlags(Instance);
				}
			public void Perform(TopoDSShape shape)
				{
					ShapeAnalysis_ShapeContents_Perform9EBAC0C0(Instance, shape.Instance);
				}
		public bool ModifyBigSplineMode{
			get {
				return ShapeAnalysis_ShapeContents_ModifyBigSplineMode(Instance);
			}
		}
		public bool ModifyIndirectMode{
			get {
				return ShapeAnalysis_ShapeContents_ModifyIndirectMode(Instance);
			}
		}
		public bool ModifyOffestSurfaceMode{
			get {
				return ShapeAnalysis_ShapeContents_ModifyOffestSurfaceMode(Instance);
			}
		}
		public bool ModifyTrimmed3dMode{
			get {
				return ShapeAnalysis_ShapeContents_ModifyTrimmed3dMode(Instance);
			}
		}
		public bool ModifyOffsetCurveMode{
			get {
				return ShapeAnalysis_ShapeContents_ModifyOffsetCurveMode(Instance);
			}
		}
		public bool ModifyTrimmed2dMode{
			get {
				return ShapeAnalysis_ShapeContents_ModifyTrimmed2dMode(Instance);
			}
		}
		public int NbSolids{
			get {
				return ShapeAnalysis_ShapeContents_NbSolids(Instance);
			}
		}
		public int NbShells{
			get {
				return ShapeAnalysis_ShapeContents_NbShells(Instance);
			}
		}
		public int NbFaces{
			get {
				return ShapeAnalysis_ShapeContents_NbFaces(Instance);
			}
		}
		public int NbWires{
			get {
				return ShapeAnalysis_ShapeContents_NbWires(Instance);
			}
		}
		public int NbEdges{
			get {
				return ShapeAnalysis_ShapeContents_NbEdges(Instance);
			}
		}
		public int NbVertices{
			get {
				return ShapeAnalysis_ShapeContents_NbVertices(Instance);
			}
		}
		public int NbSolidsWithVoids{
			get {
				return ShapeAnalysis_ShapeContents_NbSolidsWithVoids(Instance);
			}
		}
		public int NbBigSplines{
			get {
				return ShapeAnalysis_ShapeContents_NbBigSplines(Instance);
			}
		}
		public int NbC0Surfaces{
			get {
				return ShapeAnalysis_ShapeContents_NbC0Surfaces(Instance);
			}
		}
		public int NbC0Curves{
			get {
				return ShapeAnalysis_ShapeContents_NbC0Curves(Instance);
			}
		}
		public int NbOffsetSurf{
			get {
				return ShapeAnalysis_ShapeContents_NbOffsetSurf(Instance);
			}
		}
		public int NbIndirectSurf{
			get {
				return ShapeAnalysis_ShapeContents_NbIndirectSurf(Instance);
			}
		}
		public int NbOffsetCurves{
			get {
				return ShapeAnalysis_ShapeContents_NbOffsetCurves(Instance);
			}
		}
		public int NbTrimmedCurve2d{
			get {
				return ShapeAnalysis_ShapeContents_NbTrimmedCurve2d(Instance);
			}
		}
		public int NbTrimmedCurve3d{
			get {
				return ShapeAnalysis_ShapeContents_NbTrimmedCurve3d(Instance);
			}
		}
		public int NbBSplibeSurf{
			get {
				return ShapeAnalysis_ShapeContents_NbBSplibeSurf(Instance);
			}
		}
		public int NbBezierSurf{
			get {
				return ShapeAnalysis_ShapeContents_NbBezierSurf(Instance);
			}
		}
		public int NbTrimSurf{
			get {
				return ShapeAnalysis_ShapeContents_NbTrimSurf(Instance);
			}
		}
		public int NbWireWitnSeam{
			get {
				return ShapeAnalysis_ShapeContents_NbWireWitnSeam(Instance);
			}
		}
		public int NbWireWithSevSeams{
			get {
				return ShapeAnalysis_ShapeContents_NbWireWithSevSeams(Instance);
			}
		}
		public int NbFaceWithSevWires{
			get {
				return ShapeAnalysis_ShapeContents_NbFaceWithSevWires(Instance);
			}
		}
		public int NbNoPCurve{
			get {
				return ShapeAnalysis_ShapeContents_NbNoPCurve(Instance);
			}
		}
		public int NbFreeFaces{
			get {
				return ShapeAnalysis_ShapeContents_NbFreeFaces(Instance);
			}
		}
		public int NbFreeWires{
			get {
				return ShapeAnalysis_ShapeContents_NbFreeWires(Instance);
			}
		}
		public int NbFreeEdges{
			get {
				return ShapeAnalysis_ShapeContents_NbFreeEdges(Instance);
			}
		}
		public int NbSharedSolids{
			get {
				return ShapeAnalysis_ShapeContents_NbSharedSolids(Instance);
			}
		}
		public int NbSharedShells{
			get {
				return ShapeAnalysis_ShapeContents_NbSharedShells(Instance);
			}
		}
		public int NbSharedFaces{
			get {
				return ShapeAnalysis_ShapeContents_NbSharedFaces(Instance);
			}
		}
		public int NbSharedWires{
			get {
				return ShapeAnalysis_ShapeContents_NbSharedWires(Instance);
			}
		}
		public int NbSharedFreeWires{
			get {
				return ShapeAnalysis_ShapeContents_NbSharedFreeWires(Instance);
			}
		}
		public int NbSharedFreeEdges{
			get {
				return ShapeAnalysis_ShapeContents_NbSharedFreeEdges(Instance);
			}
		}
		public int NbSharedEdges{
			get {
				return ShapeAnalysis_ShapeContents_NbSharedEdges(Instance);
			}
		}
		public int NbSharedVertices{
			get {
				return ShapeAnalysis_ShapeContents_NbSharedVertices(Instance);
			}
		}
		public TopToolsHSequenceOfShape BigSplineSec{
			get {
				return new TopToolsHSequenceOfShape(ShapeAnalysis_ShapeContents_BigSplineSec(Instance));
			}
		}
		public TopToolsHSequenceOfShape IndirectSec{
			get {
				return new TopToolsHSequenceOfShape(ShapeAnalysis_ShapeContents_IndirectSec(Instance));
			}
		}
		public TopToolsHSequenceOfShape OffsetSurfaceSec{
			get {
				return new TopToolsHSequenceOfShape(ShapeAnalysis_ShapeContents_OffsetSurfaceSec(Instance));
			}
		}
		public TopToolsHSequenceOfShape Trimmed3dSec{
			get {
				return new TopToolsHSequenceOfShape(ShapeAnalysis_ShapeContents_Trimmed3dSec(Instance));
			}
		}
		public TopToolsHSequenceOfShape OffsetCurveSec{
			get {
				return new TopToolsHSequenceOfShape(ShapeAnalysis_ShapeContents_OffsetCurveSec(Instance));
			}
		}
		public TopToolsHSequenceOfShape Trimmed2dSec{
			get {
				return new TopToolsHSequenceOfShape(ShapeAnalysis_ShapeContents_Trimmed2dSec(Instance));
			}
		}
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr ShapeAnalysis_ShapeContents_Ctor();
		[DllImport("NaroOccCore.dll")]
		private static extern void ShapeAnalysis_ShapeContents_Clear(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void ShapeAnalysis_ShapeContents_ClearFlags(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void ShapeAnalysis_ShapeContents_Perform9EBAC0C0(IntPtr instance, IntPtr shape);
		[DllImport("NaroOccCore.dll")]
		private static extern bool ShapeAnalysis_ShapeContents_ModifyBigSplineMode(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool ShapeAnalysis_ShapeContents_ModifyIndirectMode(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool ShapeAnalysis_ShapeContents_ModifyOffestSurfaceMode(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool ShapeAnalysis_ShapeContents_ModifyTrimmed3dMode(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool ShapeAnalysis_ShapeContents_ModifyOffsetCurveMode(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool ShapeAnalysis_ShapeContents_ModifyTrimmed2dMode(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern int ShapeAnalysis_ShapeContents_NbSolids(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern int ShapeAnalysis_ShapeContents_NbShells(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern int ShapeAnalysis_ShapeContents_NbFaces(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern int ShapeAnalysis_ShapeContents_NbWires(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern int ShapeAnalysis_ShapeContents_NbEdges(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern int ShapeAnalysis_ShapeContents_NbVertices(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern int ShapeAnalysis_ShapeContents_NbSolidsWithVoids(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern int ShapeAnalysis_ShapeContents_NbBigSplines(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern int ShapeAnalysis_ShapeContents_NbC0Surfaces(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern int ShapeAnalysis_ShapeContents_NbC0Curves(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern int ShapeAnalysis_ShapeContents_NbOffsetSurf(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern int ShapeAnalysis_ShapeContents_NbIndirectSurf(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern int ShapeAnalysis_ShapeContents_NbOffsetCurves(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern int ShapeAnalysis_ShapeContents_NbTrimmedCurve2d(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern int ShapeAnalysis_ShapeContents_NbTrimmedCurve3d(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern int ShapeAnalysis_ShapeContents_NbBSplibeSurf(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern int ShapeAnalysis_ShapeContents_NbBezierSurf(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern int ShapeAnalysis_ShapeContents_NbTrimSurf(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern int ShapeAnalysis_ShapeContents_NbWireWitnSeam(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern int ShapeAnalysis_ShapeContents_NbWireWithSevSeams(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern int ShapeAnalysis_ShapeContents_NbFaceWithSevWires(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern int ShapeAnalysis_ShapeContents_NbNoPCurve(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern int ShapeAnalysis_ShapeContents_NbFreeFaces(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern int ShapeAnalysis_ShapeContents_NbFreeWires(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern int ShapeAnalysis_ShapeContents_NbFreeEdges(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern int ShapeAnalysis_ShapeContents_NbSharedSolids(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern int ShapeAnalysis_ShapeContents_NbSharedShells(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern int ShapeAnalysis_ShapeContents_NbSharedFaces(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern int ShapeAnalysis_ShapeContents_NbSharedWires(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern int ShapeAnalysis_ShapeContents_NbSharedFreeWires(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern int ShapeAnalysis_ShapeContents_NbSharedFreeEdges(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern int ShapeAnalysis_ShapeContents_NbSharedEdges(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern int ShapeAnalysis_ShapeContents_NbSharedVertices(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr ShapeAnalysis_ShapeContents_BigSplineSec(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr ShapeAnalysis_ShapeContents_IndirectSec(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr ShapeAnalysis_ShapeContents_OffsetSurfaceSec(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr ShapeAnalysis_ShapeContents_Trimmed3dSec(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr ShapeAnalysis_ShapeContents_OffsetCurveSec(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr ShapeAnalysis_ShapeContents_Trimmed2dSec(IntPtr instance);

		#region NativeInstancePtr Convert constructor

		public ShapeAnalysisShapeContents(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ ShapeAnalysisShapeContents_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void ShapeAnalysisShapeContents_Dtor(IntPtr instance);
	}
}
