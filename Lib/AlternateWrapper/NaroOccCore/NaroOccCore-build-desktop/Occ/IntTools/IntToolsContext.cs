#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;
using NaroCppCore.Occ.MMgt;
using NaroCppCore.Occ.TopoDS;
using NaroCppCore.Occ.BRepClass3d;
using NaroCppCore.Occ.gp;
using NaroCppCore.Occ.TopAbs;
using NaroCppCore.Occ.IntTools;

#endregion

namespace NaroCppCore.Occ.IntTools
{
	public class IntToolsContext : MMgtTShared
	{
		public IntToolsContext()
 :
			base(IntTools_Context_Ctor() )
		{}
			public BRepClass3dSolidClassifier SolidClassifier(TopoDSSolid aSolid)
				{
					return new BRepClass3dSolidClassifier(IntTools_Context_SolidClassifier56111E92(Instance, aSolid.Instance));
				}
			public int ComputeVE(TopoDSVertex aV,TopoDSEdge aE,ref double aT)
				{
					return IntTools_Context_ComputeVE644637E6(Instance, aV.Instance, aE.Instance, ref aT);
				}
			public int ComputeVE(TopoDSVertex aV,TopoDSEdge aE,ref double aT,ref bool bToUpdateVertex,ref double aDist)
				{
					return IntTools_Context_ComputeVE14B7C63A(Instance, aV.Instance, aE.Instance, ref aT, ref bToUpdateVertex, ref aDist);
				}
			public int ComputeVS(TopoDSVertex aV,TopoDSFace aF,ref double U,ref double V)
				{
					return IntTools_Context_ComputeVS2502EEC5(Instance, aV.Instance, aF.Instance, ref U, ref V);
				}
			public TopAbsState StatePointFace(TopoDSFace aF,gpPnt2d aP2D)
				{
					return (TopAbsState)IntTools_Context_StatePointFace15F1B95A(Instance, aF.Instance, aP2D.Instance);
				}
			public bool IsPointInFace(TopoDSFace aF,gpPnt2d aP2D)
				{
					return IntTools_Context_IsPointInFace15F1B95A(Instance, aF.Instance, aP2D.Instance);
				}
			public bool IsPointInOnFace(TopoDSFace aF,gpPnt2d aP2D)
				{
					return IntTools_Context_IsPointInOnFace15F1B95A(Instance, aF.Instance, aP2D.Instance);
				}
			public bool IsValidPointForFace(gpPnt aP3D,TopoDSFace aF,double aTol)
				{
					return IntTools_Context_IsValidPointForFace51B2A608(Instance, aP3D.Instance, aF.Instance, aTol);
				}
			public bool IsValidPointForFaces(gpPnt aP3D,TopoDSFace aF1,TopoDSFace aF2,double aTol)
				{
					return IntTools_Context_IsValidPointForFaces53322313(Instance, aP3D.Instance, aF1.Instance, aF2.Instance, aTol);
				}
			public bool IsValidBlockForFace(double aT1,double aT2,IntToolsCurve aIC,TopoDSFace aF,double aTol)
				{
					return IntTools_Context_IsValidBlockForFace3F82E9C8(Instance, aT1, aT2, aIC.Instance, aF.Instance, aTol);
				}
			public bool IsValidBlockForFaces(double aT1,double aT2,IntToolsCurve aIC,TopoDSFace aF1,TopoDSFace aF2,double aTol)
				{
					return IntTools_Context_IsValidBlockForFacesC37F6D8D(Instance, aT1, aT2, aIC.Instance, aF1.Instance, aF2.Instance, aTol);
				}
			public bool IsVertexOnLine(TopoDSVertex aV,IntToolsCurve aIC,double aTolC,ref double aT)
				{
					return IntTools_Context_IsVertexOnLineE4D8858(Instance, aV.Instance, aIC.Instance, aTolC, ref aT);
				}
			public bool IsVertexOnLine(TopoDSVertex aV,double aTolV,IntToolsCurve aIC,double aTolC,ref double aT)
				{
					return IntTools_Context_IsVertexOnLine7D7AFC65(Instance, aV.Instance, aTolV, aIC.Instance, aTolC, ref aT);
				}
			public bool ProjectPointOnEdge(gpPnt aP,TopoDSEdge aE,ref double aT)
				{
					return IntTools_Context_ProjectPointOnEdge31FF11E7(Instance, aP.Instance, aE.Instance, ref aT);
				}
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr IntTools_Context_Ctor();
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr IntTools_Context_SolidClassifier56111E92(IntPtr instance, IntPtr aSolid);
		[DllImport("NaroOccCore.dll")]
		private static extern int IntTools_Context_ComputeVE644637E6(IntPtr instance, IntPtr aV,IntPtr aE,ref double aT);
		[DllImport("NaroOccCore.dll")]
		private static extern int IntTools_Context_ComputeVE14B7C63A(IntPtr instance, IntPtr aV,IntPtr aE,ref double aT,ref bool bToUpdateVertex,ref double aDist);
		[DllImport("NaroOccCore.dll")]
		private static extern int IntTools_Context_ComputeVS2502EEC5(IntPtr instance, IntPtr aV,IntPtr aF,ref double U,ref double V);
		[DllImport("NaroOccCore.dll")]
		private static extern int IntTools_Context_StatePointFace15F1B95A(IntPtr instance, IntPtr aF,IntPtr aP2D);
		[DllImport("NaroOccCore.dll")]
		private static extern bool IntTools_Context_IsPointInFace15F1B95A(IntPtr instance, IntPtr aF,IntPtr aP2D);
		[DllImport("NaroOccCore.dll")]
		private static extern bool IntTools_Context_IsPointInOnFace15F1B95A(IntPtr instance, IntPtr aF,IntPtr aP2D);
		[DllImport("NaroOccCore.dll")]
		private static extern bool IntTools_Context_IsValidPointForFace51B2A608(IntPtr instance, IntPtr aP3D,IntPtr aF,double aTol);
		[DllImport("NaroOccCore.dll")]
		private static extern bool IntTools_Context_IsValidPointForFaces53322313(IntPtr instance, IntPtr aP3D,IntPtr aF1,IntPtr aF2,double aTol);
		[DllImport("NaroOccCore.dll")]
		private static extern bool IntTools_Context_IsValidBlockForFace3F82E9C8(IntPtr instance, double aT1,double aT2,IntPtr aIC,IntPtr aF,double aTol);
		[DllImport("NaroOccCore.dll")]
		private static extern bool IntTools_Context_IsValidBlockForFacesC37F6D8D(IntPtr instance, double aT1,double aT2,IntPtr aIC,IntPtr aF1,IntPtr aF2,double aTol);
		[DllImport("NaroOccCore.dll")]
		private static extern bool IntTools_Context_IsVertexOnLineE4D8858(IntPtr instance, IntPtr aV,IntPtr aIC,double aTolC,ref double aT);
		[DllImport("NaroOccCore.dll")]
		private static extern bool IntTools_Context_IsVertexOnLine7D7AFC65(IntPtr instance, IntPtr aV,double aTolV,IntPtr aIC,double aTolC,ref double aT);
		[DllImport("NaroOccCore.dll")]
		private static extern bool IntTools_Context_ProjectPointOnEdge31FF11E7(IntPtr instance, IntPtr aP,IntPtr aE,ref double aT);

		#region NativeInstancePtr Convert constructor

		public IntToolsContext(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ IntToolsContext_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void IntToolsContext_Dtor(IntPtr instance);
	}
}
