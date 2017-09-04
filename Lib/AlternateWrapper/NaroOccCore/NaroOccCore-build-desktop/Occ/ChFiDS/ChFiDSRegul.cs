#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;

#endregion

namespace NaroCppCore.Occ.ChFiDS
{
	public class ChFiDSRegul : NativeInstancePtr
	{
		public ChFiDSRegul()
 :
			base(ChFiDS_Regul_Ctor() )
		{}
			public void SetS1(int IS1,bool IsFace)
				{
					ChFiDS_Regul_SetS1898DAFFC(Instance, IS1, IsFace);
				}
			public void SetS2(int IS2,bool IsFace)
				{
					ChFiDS_Regul_SetS2898DAFFC(Instance, IS2, IsFace);
				}
			public int S1()
				{
					return ChFiDS_Regul_S1(Instance);
				}
			public int S2()
				{
					return ChFiDS_Regul_S2(Instance);
				}
		public bool IsSurface1{
			get {
				return ChFiDS_Regul_IsSurface1(Instance);
			}
		}
		public bool IsSurface2{
			get {
				return ChFiDS_Regul_IsSurface2(Instance);
			}
		}
		public int Curve{
			set { 
				ChFiDS_Regul_SetCurve(Instance, value);
			}
			get {
				return ChFiDS_Regul_Curve(Instance);
			}
		}
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr ChFiDS_Regul_Ctor();
		[DllImport("NaroOccCore.dll")]
		private static extern void ChFiDS_Regul_SetS1898DAFFC(IntPtr instance, int IS1,bool IsFace);
		[DllImport("NaroOccCore.dll")]
		private static extern void ChFiDS_Regul_SetS2898DAFFC(IntPtr instance, int IS2,bool IsFace);
		[DllImport("NaroOccCore.dll")]
		private static extern int ChFiDS_Regul_S1(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern int ChFiDS_Regul_S2(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool ChFiDS_Regul_IsSurface1(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool ChFiDS_Regul_IsSurface2(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void ChFiDS_Regul_SetCurve(IntPtr instance, int value);
		[DllImport("NaroOccCore.dll")]
		private static extern int ChFiDS_Regul_Curve(IntPtr instance);

		#region NativeInstancePtr Convert constructor

		public ChFiDSRegul(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ ChFiDSRegul_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void ChFiDSRegul_Dtor(IntPtr instance);
	}
}
