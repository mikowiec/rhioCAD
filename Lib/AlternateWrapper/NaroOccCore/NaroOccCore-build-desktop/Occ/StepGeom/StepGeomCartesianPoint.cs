#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;
using NaroCppCore.Occ.StepGeom;
using NaroCppCore.Occ.TCollection;

#endregion

namespace NaroCppCore.Occ.StepGeom
{
	public class StepGeomCartesianPoint : StepGeomPoint
	{
		public StepGeomCartesianPoint()
 :
			base(StepGeom_CartesianPoint_Ctor() )
		{}
			public void Init(TCollectionHAsciiString aName)
				{
					StepGeom_CartesianPoint_InitB439B3D5(Instance, aName.Instance);
				}
			public void Init2D(TCollectionHAsciiString aName,double X,double Y)
				{
					StepGeom_CartesianPoint_Init2D3BC3DBE2(Instance, aName.Instance, X, Y);
				}
			public void Init3D(TCollectionHAsciiString aName,double X,double Y,double Z)
				{
					StepGeom_CartesianPoint_Init3D13512EBE(Instance, aName.Instance, X, Y, Z);
				}
			public double CoordinatesValue(int num)
				{
					return StepGeom_CartesianPoint_CoordinatesValueE8219145(Instance, num);
				}
		public int NbCoordinates{
			get {
				return StepGeom_CartesianPoint_NbCoordinates(Instance);
			}
		}
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr StepGeom_CartesianPoint_Ctor();
		[DllImport("NaroOccCore.dll")]
		private static extern void StepGeom_CartesianPoint_InitB439B3D5(IntPtr instance, IntPtr aName);
		[DllImport("NaroOccCore.dll")]
		private static extern void StepGeom_CartesianPoint_Init2D3BC3DBE2(IntPtr instance, IntPtr aName,double X,double Y);
		[DllImport("NaroOccCore.dll")]
		private static extern void StepGeom_CartesianPoint_Init3D13512EBE(IntPtr instance, IntPtr aName,double X,double Y,double Z);
		[DllImport("NaroOccCore.dll")]
		private static extern double StepGeom_CartesianPoint_CoordinatesValueE8219145(IntPtr instance, int num);
		[DllImport("NaroOccCore.dll")]
		private static extern int StepGeom_CartesianPoint_NbCoordinates(IntPtr instance);

		#region NativeInstancePtr Convert constructor

		public StepGeomCartesianPoint(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ StepGeomCartesianPoint_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void StepGeomCartesianPoint_Dtor(IntPtr instance);
	}
}
