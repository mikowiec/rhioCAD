#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;
using NaroCppCore.Occ.MMgt;
using NaroCppCore.Occ.TopAbs;
using NaroCppCore.Occ.ChFiDS;
using NaroCppCore.Occ.gp;

#endregion

namespace NaroCppCore.Occ.ChFiDS
{
	public class ChFiDSSurfData : MMgtTShared
	{
		public ChFiDSSurfData()
 :
			base(ChFiDS_SurfData_Ctor() )
		{}
			public void Copy(ChFiDSSurfData Other)
				{
					ChFiDS_SurfData_CopyB9327F76(Instance, Other.Instance);
				}
			public void ChangeIndexOfS1(int Index)
				{
					ChFiDS_SurfData_ChangeIndexOfS1E8219145(Instance, Index);
				}
			public void ChangeIndexOfS2(int Index)
				{
					ChFiDS_SurfData_ChangeIndexOfS2E8219145(Instance, Index);
				}
			public void ChangeSurf(int Index)
				{
					ChFiDS_SurfData_ChangeSurfE8219145(Instance, Index);
				}
			public ChFiDSFaceInterference Interference(int OnS)
				{
					return new ChFiDSFaceInterference(ChFiDS_SurfData_InterferenceE8219145(Instance, OnS));
				}
			public ChFiDSFaceInterference ChangeInterference(int OnS)
				{
					return new ChFiDSFaceInterference(ChFiDS_SurfData_ChangeInterferenceE8219145(Instance, OnS));
				}
			public int Index(int OfS)
				{
					return ChFiDS_SurfData_IndexE8219145(Instance, OfS);
				}
			public ChFiDSCommonPoint Vertex(bool First,int OnS)
				{
					return new ChFiDSCommonPoint(ChFiDS_SurfData_VertexD4631C92(Instance, First, OnS));
				}
			public ChFiDSCommonPoint ChangeVertex(bool First,int OnS)
				{
					return new ChFiDSCommonPoint(ChFiDS_SurfData_ChangeVertexD4631C92(Instance, First, OnS));
				}
			public bool IsOnCurve(int OnS)
				{
					return ChFiDS_SurfData_IsOnCurveE8219145(Instance, OnS);
				}
			public int IndexOfC(int OnS)
				{
					return ChFiDS_SurfData_IndexOfCE8219145(Instance, OnS);
				}
			public double FirstSpineParam()
				{
					return ChFiDS_SurfData_FirstSpineParam(Instance);
				}
			public double LastSpineParam()
				{
					return ChFiDS_SurfData_LastSpineParam(Instance);
				}
			public void FirstSpineParam(double Par)
				{
					ChFiDS_SurfData_FirstSpineParamD82819F3(Instance, Par);
				}
			public void LastSpineParam(double Par)
				{
					ChFiDS_SurfData_LastSpineParamD82819F3(Instance, Par);
				}
			public double FirstExtensionValue()
				{
					return ChFiDS_SurfData_FirstExtensionValue(Instance);
				}
			public double LastExtensionValue()
				{
					return ChFiDS_SurfData_LastExtensionValue(Instance);
				}
			public void FirstExtensionValue(double Extend)
				{
					ChFiDS_SurfData_FirstExtensionValueD82819F3(Instance, Extend);
				}
			public void LastExtensionValue(double Extend)
				{
					ChFiDS_SurfData_LastExtensionValueD82819F3(Instance, Extend);
				}
			public void ResetSimul()
				{
					ChFiDS_SurfData_ResetSimul(Instance);
				}
			public gpPnt2d Get2dPoints(bool First,int OnS)
				{
					return new gpPnt2d(ChFiDS_SurfData_Get2dPointsD4631C92(Instance, First, OnS));
				}
			public void Get2dPoints(gpPnt2d P2df1,gpPnt2d P2dl1,gpPnt2d P2df2,gpPnt2d P2dl2)
				{
					ChFiDS_SurfData_Get2dPoints79D6D16B(Instance, P2df1.Instance, P2dl1.Instance, P2df2.Instance, P2dl2.Instance);
				}
			public void Set2dPoints(gpPnt2d P2df1,gpPnt2d P2dl1,gpPnt2d P2df2,gpPnt2d P2dl2)
				{
					ChFiDS_SurfData_Set2dPoints79D6D16B(Instance, P2df1.Instance, P2dl1.Instance, P2df2.Instance, P2dl2.Instance);
				}
			public bool TwistOnS1()
				{
					return ChFiDS_SurfData_TwistOnS1(Instance);
				}
			public bool TwistOnS2()
				{
					return ChFiDS_SurfData_TwistOnS2(Instance);
				}
			public void TwistOnS1(bool T)
				{
					ChFiDS_SurfData_TwistOnS1461FC46A(Instance, T);
				}
			public void TwistOnS2(bool T)
				{
					ChFiDS_SurfData_TwistOnS2461FC46A(Instance, T);
				}
		public int IndexOfS1{
			get {
				return ChFiDS_SurfData_IndexOfS1(Instance);
			}
		}
		public int IndexOfS2{
			get {
				return ChFiDS_SurfData_IndexOfS2(Instance);
			}
		}
		public bool IsOnCurve1{
			get {
				return ChFiDS_SurfData_IsOnCurve1(Instance);
			}
		}
		public bool IsOnCurve2{
			get {
				return ChFiDS_SurfData_IsOnCurve2(Instance);
			}
		}
		public int Surf{
			get {
				return ChFiDS_SurfData_Surf(Instance);
			}
		}
		public TopAbsOrientation Orientation{
			get {
				return (TopAbsOrientation)ChFiDS_SurfData_Orientation(Instance);
			}
		}
		public ChFiDSFaceInterference InterferenceOnS1{
			get {
				return new ChFiDSFaceInterference(ChFiDS_SurfData_InterferenceOnS1(Instance));
			}
		}
		public ChFiDSFaceInterference InterferenceOnS2{
			get {
				return new ChFiDSFaceInterference(ChFiDS_SurfData_InterferenceOnS2(Instance));
			}
		}
		public ChFiDSCommonPoint VertexFirstOnS1{
			get {
				return new ChFiDSCommonPoint(ChFiDS_SurfData_VertexFirstOnS1(Instance));
			}
		}
		public ChFiDSCommonPoint VertexFirstOnS2{
			get {
				return new ChFiDSCommonPoint(ChFiDS_SurfData_VertexFirstOnS2(Instance));
			}
		}
		public ChFiDSCommonPoint VertexLastOnS1{
			get {
				return new ChFiDSCommonPoint(ChFiDS_SurfData_VertexLastOnS1(Instance));
			}
		}
		public ChFiDSCommonPoint VertexLastOnS2{
			get {
				return new ChFiDSCommonPoint(ChFiDS_SurfData_VertexLastOnS2(Instance));
			}
		}
		public int IndexOfC1{
			set { 
				ChFiDS_SurfData_SetIndexOfC1(Instance, value);
			}
			get {
				return ChFiDS_SurfData_IndexOfC1(Instance);
			}
		}
		public int IndexOfC2{
			set { 
				ChFiDS_SurfData_SetIndexOfC2(Instance, value);
			}
			get {
				return ChFiDS_SurfData_IndexOfC2(Instance);
			}
		}
		public TopAbsOrientation ChangeOrientation{
			get {
				return (TopAbsOrientation)ChFiDS_SurfData_ChangeOrientation(Instance);
			}
		}
		public ChFiDSFaceInterference ChangeInterferenceOnS1{
			get {
				return new ChFiDSFaceInterference(ChFiDS_SurfData_ChangeInterferenceOnS1(Instance));
			}
		}
		public ChFiDSFaceInterference ChangeInterferenceOnS2{
			get {
				return new ChFiDSFaceInterference(ChFiDS_SurfData_ChangeInterferenceOnS2(Instance));
			}
		}
		public ChFiDSCommonPoint ChangeVertexFirstOnS1{
			get {
				return new ChFiDSCommonPoint(ChFiDS_SurfData_ChangeVertexFirstOnS1(Instance));
			}
		}
		public ChFiDSCommonPoint ChangeVertexFirstOnS2{
			get {
				return new ChFiDSCommonPoint(ChFiDS_SurfData_ChangeVertexFirstOnS2(Instance));
			}
		}
		public ChFiDSCommonPoint ChangeVertexLastOnS1{
			get {
				return new ChFiDSCommonPoint(ChFiDS_SurfData_ChangeVertexLastOnS1(Instance));
			}
		}
		public ChFiDSCommonPoint ChangeVertexLastOnS2{
			get {
				return new ChFiDSCommonPoint(ChFiDS_SurfData_ChangeVertexLastOnS2(Instance));
			}
		}
		public MMgtTShared Simul{
			set { 
				ChFiDS_SurfData_SetSimul(Instance, value.Instance);
			}
			get {
				return new MMgtTShared(ChFiDS_SurfData_Simul(Instance));
			}
		}
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr ChFiDS_SurfData_Ctor();
		[DllImport("NaroOccCore.dll")]
		private static extern void ChFiDS_SurfData_CopyB9327F76(IntPtr instance, IntPtr Other);
		[DllImport("NaroOccCore.dll")]
		private static extern void ChFiDS_SurfData_ChangeIndexOfS1E8219145(IntPtr instance, int Index);
		[DllImport("NaroOccCore.dll")]
		private static extern void ChFiDS_SurfData_ChangeIndexOfS2E8219145(IntPtr instance, int Index);
		[DllImport("NaroOccCore.dll")]
		private static extern void ChFiDS_SurfData_ChangeSurfE8219145(IntPtr instance, int Index);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr ChFiDS_SurfData_InterferenceE8219145(IntPtr instance, int OnS);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr ChFiDS_SurfData_ChangeInterferenceE8219145(IntPtr instance, int OnS);
		[DllImport("NaroOccCore.dll")]
		private static extern int ChFiDS_SurfData_IndexE8219145(IntPtr instance, int OfS);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr ChFiDS_SurfData_VertexD4631C92(IntPtr instance, bool First,int OnS);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr ChFiDS_SurfData_ChangeVertexD4631C92(IntPtr instance, bool First,int OnS);
		[DllImport("NaroOccCore.dll")]
		private static extern bool ChFiDS_SurfData_IsOnCurveE8219145(IntPtr instance, int OnS);
		[DllImport("NaroOccCore.dll")]
		private static extern int ChFiDS_SurfData_IndexOfCE8219145(IntPtr instance, int OnS);
		[DllImport("NaroOccCore.dll")]
		private static extern double ChFiDS_SurfData_FirstSpineParam(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern double ChFiDS_SurfData_LastSpineParam(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void ChFiDS_SurfData_FirstSpineParamD82819F3(IntPtr instance, double Par);
		[DllImport("NaroOccCore.dll")]
		private static extern void ChFiDS_SurfData_LastSpineParamD82819F3(IntPtr instance, double Par);
		[DllImport("NaroOccCore.dll")]
		private static extern double ChFiDS_SurfData_FirstExtensionValue(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern double ChFiDS_SurfData_LastExtensionValue(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void ChFiDS_SurfData_FirstExtensionValueD82819F3(IntPtr instance, double Extend);
		[DllImport("NaroOccCore.dll")]
		private static extern void ChFiDS_SurfData_LastExtensionValueD82819F3(IntPtr instance, double Extend);
		[DllImport("NaroOccCore.dll")]
		private static extern void ChFiDS_SurfData_ResetSimul(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr ChFiDS_SurfData_Get2dPointsD4631C92(IntPtr instance, bool First,int OnS);
		[DllImport("NaroOccCore.dll")]
		private static extern void ChFiDS_SurfData_Get2dPoints79D6D16B(IntPtr instance, IntPtr P2df1,IntPtr P2dl1,IntPtr P2df2,IntPtr P2dl2);
		[DllImport("NaroOccCore.dll")]
		private static extern void ChFiDS_SurfData_Set2dPoints79D6D16B(IntPtr instance, IntPtr P2df1,IntPtr P2dl1,IntPtr P2df2,IntPtr P2dl2);
		[DllImport("NaroOccCore.dll")]
		private static extern bool ChFiDS_SurfData_TwistOnS1(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool ChFiDS_SurfData_TwistOnS2(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void ChFiDS_SurfData_TwistOnS1461FC46A(IntPtr instance, bool T);
		[DllImport("NaroOccCore.dll")]
		private static extern void ChFiDS_SurfData_TwistOnS2461FC46A(IntPtr instance, bool T);
		[DllImport("NaroOccCore.dll")]
		private static extern int ChFiDS_SurfData_IndexOfS1(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern int ChFiDS_SurfData_IndexOfS2(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool ChFiDS_SurfData_IsOnCurve1(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool ChFiDS_SurfData_IsOnCurve2(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern int ChFiDS_SurfData_Surf(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern int ChFiDS_SurfData_Orientation(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr ChFiDS_SurfData_InterferenceOnS1(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr ChFiDS_SurfData_InterferenceOnS2(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr ChFiDS_SurfData_VertexFirstOnS1(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr ChFiDS_SurfData_VertexFirstOnS2(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr ChFiDS_SurfData_VertexLastOnS1(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr ChFiDS_SurfData_VertexLastOnS2(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void ChFiDS_SurfData_SetIndexOfC1(IntPtr instance, int value);
		[DllImport("NaroOccCore.dll")]
		private static extern int ChFiDS_SurfData_IndexOfC1(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void ChFiDS_SurfData_SetIndexOfC2(IntPtr instance, int value);
		[DllImport("NaroOccCore.dll")]
		private static extern int ChFiDS_SurfData_IndexOfC2(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern int ChFiDS_SurfData_ChangeOrientation(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr ChFiDS_SurfData_ChangeInterferenceOnS1(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr ChFiDS_SurfData_ChangeInterferenceOnS2(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr ChFiDS_SurfData_ChangeVertexFirstOnS1(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr ChFiDS_SurfData_ChangeVertexFirstOnS2(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr ChFiDS_SurfData_ChangeVertexLastOnS1(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr ChFiDS_SurfData_ChangeVertexLastOnS2(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void ChFiDS_SurfData_SetSimul(IntPtr instance, IntPtr value);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr ChFiDS_SurfData_Simul(IntPtr instance);

		#region NativeInstancePtr Convert constructor

		public ChFiDSSurfData(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ ChFiDSSurfData_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void ChFiDSSurfData_Dtor(IntPtr instance);
	}
}
