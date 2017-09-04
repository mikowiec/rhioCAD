#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;
using NaroCppCore.Occ.StepGeom;
using NaroCppCore.Occ.TCollection;

#endregion

namespace NaroCppCore.Occ.StepGeom
{
	public class StepGeomDirection : StepGeomGeometricRepresentationItem
	{
		public StepGeomDirection()
 :
			base(StepGeom_Direction_Ctor() )
		{}
			public void Init(TCollectionHAsciiString aName)
				{
					StepGeom_Direction_InitB439B3D5(Instance, aName.Instance);
				}
			public double DirectionRatiosValue(int num)
				{
					return StepGeom_Direction_DirectionRatiosValueE8219145(Instance, num);
				}
		public int NbDirectionRatios{
			get {
				return StepGeom_Direction_NbDirectionRatios(Instance);
			}
		}
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr StepGeom_Direction_Ctor();
		[DllImport("NaroOccCore.dll")]
		private static extern void StepGeom_Direction_InitB439B3D5(IntPtr instance, IntPtr aName);
		[DllImport("NaroOccCore.dll")]
		private static extern double StepGeom_Direction_DirectionRatiosValueE8219145(IntPtr instance, int num);
		[DllImport("NaroOccCore.dll")]
		private static extern int StepGeom_Direction_NbDirectionRatios(IntPtr instance);

		#region NativeInstancePtr Convert constructor

		public StepGeomDirection(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ StepGeomDirection_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void StepGeomDirection_Dtor(IntPtr instance);
	}
}
