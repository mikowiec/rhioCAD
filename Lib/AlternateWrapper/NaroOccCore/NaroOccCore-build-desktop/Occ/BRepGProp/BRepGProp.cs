#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;
using NaroCppCore.Occ.TopoDS;
using NaroCppCore.Occ.GProp;
using NaroCppCore.Occ.gp;

#endregion

namespace NaroCppCore.Occ.BRepGProp
{
	public class BRepGProp : NativeInstancePtr
	{
			public static void LinearProperties(TopoDSShape S,GPropGProps LProps)
				{
					BRepGProp_LinearProperties883E019(S.Instance, LProps.Instance);
				}
			public static void SurfaceProperties(TopoDSShape S,GPropGProps SProps)
				{
					BRepGProp_SurfaceProperties883E019(S.Instance, SProps.Instance);
				}
			public static double SurfaceProperties(TopoDSShape S,GPropGProps SProps,double Eps)
				{
					return BRepGProp_SurfacePropertiesCE035849(S.Instance, SProps.Instance, Eps);
				}
			public static void VolumeProperties(TopoDSShape S,GPropGProps VProps,bool OnlyClosed)
				{
					BRepGProp_VolumeProperties6CC68073(S.Instance, VProps.Instance, OnlyClosed);
				}
			public static double VolumeProperties(TopoDSShape S,GPropGProps VProps,double Eps,bool OnlyClosed)
				{
					return BRepGProp_VolumeProperties95E7E8(S.Instance, VProps.Instance, Eps, OnlyClosed);
				}
			public static double VolumePropertiesGK(TopoDSShape S,GPropGProps VProps,double Eps,bool OnlyClosed,bool IsUseSpan,bool CGFlag,bool IFlag)
				{
					return BRepGProp_VolumePropertiesGK7C6171BD(S.Instance, VProps.Instance, Eps, OnlyClosed, IsUseSpan, CGFlag, IFlag);
				}
			public static double VolumePropertiesGK(TopoDSShape S,GPropGProps VProps,gpPln thePln,double Eps,bool OnlyClosed,bool IsUseSpan,bool CGFlag,bool IFlag)
				{
					return BRepGProp_VolumePropertiesGKD4DE636B(S.Instance, VProps.Instance, thePln.Instance, Eps, OnlyClosed, IsUseSpan, CGFlag, IFlag);
				}
		[DllImport("NaroOccCore.dll")]
		private static extern void BRepGProp_LinearProperties883E019(IntPtr S,IntPtr LProps);
		[DllImport("NaroOccCore.dll")]
		private static extern void BRepGProp_SurfaceProperties883E019(IntPtr S,IntPtr SProps);
		[DllImport("NaroOccCore.dll")]
		private static extern double BRepGProp_SurfacePropertiesCE035849(IntPtr S,IntPtr SProps,double Eps);
		[DllImport("NaroOccCore.dll")]
		private static extern void BRepGProp_VolumeProperties6CC68073(IntPtr S,IntPtr VProps,bool OnlyClosed);
		[DllImport("NaroOccCore.dll")]
		private static extern double BRepGProp_VolumeProperties95E7E8(IntPtr S,IntPtr VProps,double Eps,bool OnlyClosed);
		[DllImport("NaroOccCore.dll")]
		private static extern double BRepGProp_VolumePropertiesGK7C6171BD(IntPtr S,IntPtr VProps,double Eps,bool OnlyClosed,bool IsUseSpan,bool CGFlag,bool IFlag);
		[DllImport("NaroOccCore.dll")]
		private static extern double BRepGProp_VolumePropertiesGKD4DE636B(IntPtr S,IntPtr VProps,IntPtr thePln,double Eps,bool OnlyClosed,bool IsUseSpan,bool CGFlag,bool IFlag);

		#region NativeInstancePtr Convert constructor

		public BRepGProp() { } 

		public BRepGProp(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ BRepGProp_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void BRepGProp_Dtor(IntPtr instance);
	}
}
