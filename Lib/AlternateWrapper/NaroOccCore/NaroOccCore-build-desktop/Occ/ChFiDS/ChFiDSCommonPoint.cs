#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;
using NaroCppCore.Occ.TopoDS;
using NaroCppCore.Occ.TopAbs;
using NaroCppCore.Occ.gp;

#endregion

namespace NaroCppCore.Occ.ChFiDS
{
	public class ChFiDSCommonPoint : NativeInstancePtr
	{
		public ChFiDSCommonPoint()
 :
			base(ChFiDS_CommonPoint_Ctor() )
		{}
			public void Reset()
				{
					ChFiDS_CommonPoint_Reset(Instance);
				}
			public void SetArc(double Tol,TopoDSEdge A,double Param,TopAbsOrientation TArc)
				{
					ChFiDS_CommonPoint_SetArc65E3D459(Instance, Tol, A.Instance, Param, (int)TArc);
				}
			public TopoDSEdge Arc()
				{
					return new TopoDSEdge(ChFiDS_CommonPoint_Arc(Instance));
				}
		public double Tolerance{
			set { 
				ChFiDS_CommonPoint_SetTolerance(Instance, value);
			}
			get {
				return ChFiDS_CommonPoint_Tolerance(Instance);
			}
		}
		public bool IsVertex{
			get {
				return ChFiDS_CommonPoint_IsVertex(Instance);
			}
		}
		public TopoDSVertex Vertex{
			set { 
				ChFiDS_CommonPoint_SetVertex(Instance, value.Instance);
			}
			get {
				return new TopoDSVertex(ChFiDS_CommonPoint_Vertex(Instance));
			}
		}
		public bool IsOnArc{
			get {
				return ChFiDS_CommonPoint_IsOnArc(Instance);
			}
		}
		public TopAbsOrientation TransitionOnArc{
			get {
				return (TopAbsOrientation)ChFiDS_CommonPoint_TransitionOnArc(Instance);
			}
		}
		public double ParameterOnArc{
			get {
				return ChFiDS_CommonPoint_ParameterOnArc(Instance);
			}
		}
		public double Parameter{
			set { 
				ChFiDS_CommonPoint_SetParameter(Instance, value);
			}
			get {
				return ChFiDS_CommonPoint_Parameter(Instance);
			}
		}
		public gpPnt Point{
			set { 
				ChFiDS_CommonPoint_SetPoint(Instance, value.Instance);
			}
			get {
				return new gpPnt(ChFiDS_CommonPoint_Point(Instance));
			}
		}
		public bool HasVector{
			get {
				return ChFiDS_CommonPoint_HasVector(Instance);
			}
		}
		public gpVec Vector{
			set { 
				ChFiDS_CommonPoint_SetVector(Instance, value.Instance);
			}
			get {
				return new gpVec(ChFiDS_CommonPoint_Vector(Instance));
			}
		}
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr ChFiDS_CommonPoint_Ctor();
		[DllImport("NaroOccCore.dll")]
		private static extern void ChFiDS_CommonPoint_Reset(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void ChFiDS_CommonPoint_SetArc65E3D459(IntPtr instance, double Tol,IntPtr A,double Param,int TArc);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr ChFiDS_CommonPoint_Arc(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void ChFiDS_CommonPoint_SetTolerance(IntPtr instance, double value);
		[DllImport("NaroOccCore.dll")]
		private static extern double ChFiDS_CommonPoint_Tolerance(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool ChFiDS_CommonPoint_IsVertex(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void ChFiDS_CommonPoint_SetVertex(IntPtr instance, IntPtr value);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr ChFiDS_CommonPoint_Vertex(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool ChFiDS_CommonPoint_IsOnArc(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern int ChFiDS_CommonPoint_TransitionOnArc(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern double ChFiDS_CommonPoint_ParameterOnArc(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void ChFiDS_CommonPoint_SetParameter(IntPtr instance, double value);
		[DllImport("NaroOccCore.dll")]
		private static extern double ChFiDS_CommonPoint_Parameter(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void ChFiDS_CommonPoint_SetPoint(IntPtr instance, IntPtr value);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr ChFiDS_CommonPoint_Point(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool ChFiDS_CommonPoint_HasVector(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void ChFiDS_CommonPoint_SetVector(IntPtr instance, IntPtr value);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr ChFiDS_CommonPoint_Vector(IntPtr instance);

		#region NativeInstancePtr Convert constructor

		public ChFiDSCommonPoint(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ ChFiDSCommonPoint_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void ChFiDSCommonPoint_Dtor(IntPtr instance);
	}
}
