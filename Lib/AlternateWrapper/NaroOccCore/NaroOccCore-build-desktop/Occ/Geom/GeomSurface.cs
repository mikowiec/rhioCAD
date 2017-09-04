#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;
using NaroCppCore.Occ.Geom;
using NaroCppCore.Occ.gp;

#endregion

namespace NaroCppCore.Occ.Geom
{
	public class GeomSurface : GeomGeometry
	{
			public void TransformParameters(ref double U,ref double V,gpTrsf T)
				{
					Geom_Surface_TransformParametersFD94EFCC(Instance, ref U, ref V, T.Instance);
				}
			public gpGTrsf2d ParametricTransformation(gpTrsf T)
				{
					return new gpGTrsf2d(Geom_Surface_ParametricTransformation72D78650(Instance, T.Instance));
				}
			public gpPnt Value(double U,double V)
				{
					return new gpPnt(Geom_Surface_Value9F0E714F(Instance, U, V));
				}
		public GeomSurface UReversed{
			get {
				return new GeomSurface(Geom_Surface_UReversed(Instance));
			}
		}
		public GeomSurface VReversed{
			get {
				return new GeomSurface(Geom_Surface_VReversed(Instance));
			}
		}
		public double UPeriod{
			get {
				return Geom_Surface_UPeriod(Instance);
			}
		}
		public double VPeriod{
			get {
				return Geom_Surface_VPeriod(Instance);
			}
		}
		[DllImport("NaroOccCore.dll")]
		private static extern void Geom_Surface_TransformParametersFD94EFCC(IntPtr instance, ref double U,ref double V,IntPtr T);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Geom_Surface_ParametricTransformation72D78650(IntPtr instance, IntPtr T);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Geom_Surface_Value9F0E714F(IntPtr instance, double U,double V);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Geom_Surface_UReversed(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Geom_Surface_VReversed(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern double Geom_Surface_UPeriod(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern double Geom_Surface_VPeriod(IntPtr instance);

		#region NativeInstancePtr Convert constructor

		public GeomSurface() { } 

		public GeomSurface(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ GeomSurface_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void GeomSurface_Dtor(IntPtr instance);
	}
}
