#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;
using NaroCppCore.Occ.TopoDS;
using NaroCppCore.Occ.gp;

#endregion

namespace NaroCppCore.Occ.BRepExtrema
{
	public class BRepExtremaExtCC : NativeInstancePtr
	{
		public BRepExtremaExtCC()
 :
			base(BRepExtrema_ExtCC_Ctor() )
		{}
		public BRepExtremaExtCC(TopoDSEdge E1,TopoDSEdge E2)
 :
			base(BRepExtrema_ExtCC_Ctor4DFF7017(E1.Instance, E2.Instance) )
		{}
			public void Initialize(TopoDSEdge E2)
				{
					BRepExtrema_ExtCC_Initialize24263856(Instance, E2.Instance);
				}
			public void Perform(TopoDSEdge E1)
				{
					BRepExtrema_ExtCC_Perform24263856(Instance, E1.Instance);
				}
			public double SquareDistance(int N)
				{
					return BRepExtrema_ExtCC_SquareDistanceE8219145(Instance, N);
				}
			public double ParameterOnE1(int N)
				{
					return BRepExtrema_ExtCC_ParameterOnE1E8219145(Instance, N);
				}
			public gpPnt PointOnE1(int N)
				{
					return new gpPnt(BRepExtrema_ExtCC_PointOnE1E8219145(Instance, N));
				}
			public double ParameterOnE2(int N)
				{
					return BRepExtrema_ExtCC_ParameterOnE2E8219145(Instance, N);
				}
			public gpPnt PointOnE2(int N)
				{
					return new gpPnt(BRepExtrema_ExtCC_PointOnE2E8219145(Instance, N));
				}
			public void TrimmedDistances(ref double dist11,ref double distP12,ref double distP21,ref double distP22,gpPnt P11,gpPnt P12,gpPnt P21,gpPnt P22)
				{
					BRepExtrema_ExtCC_TrimmedDistancesACE69995(Instance, ref dist11, ref distP12, ref distP21, ref distP22, P11.Instance, P12.Instance, P21.Instance, P22.Instance);
				}
		public bool IsDone{
			get {
				return BRepExtrema_ExtCC_IsDone(Instance);
			}
		}
		public int NbExt{
			get {
				return BRepExtrema_ExtCC_NbExt(Instance);
			}
		}
		public bool IsParallel{
			get {
				return BRepExtrema_ExtCC_IsParallel(Instance);
			}
		}
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr BRepExtrema_ExtCC_Ctor();
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr BRepExtrema_ExtCC_Ctor4DFF7017(IntPtr E1,IntPtr E2);
		[DllImport("NaroOccCore.dll")]
		private static extern void BRepExtrema_ExtCC_Initialize24263856(IntPtr instance, IntPtr E2);
		[DllImport("NaroOccCore.dll")]
		private static extern void BRepExtrema_ExtCC_Perform24263856(IntPtr instance, IntPtr E1);
		[DllImport("NaroOccCore.dll")]
		private static extern double BRepExtrema_ExtCC_SquareDistanceE8219145(IntPtr instance, int N);
		[DllImport("NaroOccCore.dll")]
		private static extern double BRepExtrema_ExtCC_ParameterOnE1E8219145(IntPtr instance, int N);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr BRepExtrema_ExtCC_PointOnE1E8219145(IntPtr instance, int N);
		[DllImport("NaroOccCore.dll")]
		private static extern double BRepExtrema_ExtCC_ParameterOnE2E8219145(IntPtr instance, int N);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr BRepExtrema_ExtCC_PointOnE2E8219145(IntPtr instance, int N);
		[DllImport("NaroOccCore.dll")]
		private static extern void BRepExtrema_ExtCC_TrimmedDistancesACE69995(IntPtr instance, ref double dist11,ref double distP12,ref double distP21,ref double distP22,IntPtr P11,IntPtr P12,IntPtr P21,IntPtr P22);
		[DllImport("NaroOccCore.dll")]
		private static extern bool BRepExtrema_ExtCC_IsDone(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern int BRepExtrema_ExtCC_NbExt(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool BRepExtrema_ExtCC_IsParallel(IntPtr instance);

		#region NativeInstancePtr Convert constructor

		public BRepExtremaExtCC(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ BRepExtremaExtCC_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void BRepExtremaExtCC_Dtor(IntPtr instance);
	}
}
