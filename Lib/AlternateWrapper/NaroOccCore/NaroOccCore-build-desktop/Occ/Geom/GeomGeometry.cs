#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;
using NaroCppCore.Occ.MMgt;
using NaroCppCore.Occ.gp;
using NaroCppCore.Occ.Geom;

#endregion

namespace NaroCppCore.Occ.Geom
{
	public class GeomGeometry : MMgtTShared
	{
			public void Mirror(gpPnt P)
				{
					Geom_Geometry_Mirror9EAECD5B(Instance, P.Instance);
				}
			public void Mirror(gpAx1 A1)
				{
					Geom_Geometry_Mirror608B963B(Instance, A1.Instance);
				}
			public void Mirror(gpAx2 A2)
				{
					Geom_Geometry_Mirror7895386A(Instance, A2.Instance);
				}
			public void Rotate(gpAx1 A1,double Ang)
				{
					Geom_Geometry_Rotate827CB19A(Instance, A1.Instance, Ang);
				}
			public void Scale(gpPnt P,double S)
				{
					Geom_Geometry_ScaleF0D1E3E6(Instance, P.Instance, S);
				}
			public void Translate(gpVec V)
				{
					Geom_Geometry_Translate9BD9CFFE(Instance, V.Instance);
				}
			public void Translate(gpPnt P1,gpPnt P2)
				{
					Geom_Geometry_Translate5C63477E(Instance, P1.Instance, P2.Instance);
				}
			public GeomGeometry Mirrored(gpPnt P)
				{
					return new GeomGeometry(Geom_Geometry_Mirrored9EAECD5B(Instance, P.Instance));
				}
			public GeomGeometry Mirrored(gpAx1 A1)
				{
					return new GeomGeometry(Geom_Geometry_Mirrored608B963B(Instance, A1.Instance));
				}
			public GeomGeometry Mirrored(gpAx2 A2)
				{
					return new GeomGeometry(Geom_Geometry_Mirrored7895386A(Instance, A2.Instance));
				}
			public GeomGeometry Rotated(gpAx1 A1,double Ang)
				{
					return new GeomGeometry(Geom_Geometry_Rotated827CB19A(Instance, A1.Instance, Ang));
				}
			public GeomGeometry Scaled(gpPnt P,double S)
				{
					return new GeomGeometry(Geom_Geometry_ScaledF0D1E3E6(Instance, P.Instance, S));
				}
			public GeomGeometry Transformed(gpTrsf T)
				{
					return new GeomGeometry(Geom_Geometry_Transformed72D78650(Instance, T.Instance));
				}
			public GeomGeometry Translated(gpVec V)
				{
					return new GeomGeometry(Geom_Geometry_Translated9BD9CFFE(Instance, V.Instance));
				}
			public GeomGeometry Translated(gpPnt P1,gpPnt P2)
				{
					return new GeomGeometry(Geom_Geometry_Translated5C63477E(Instance, P1.Instance, P2.Instance));
				}
		[DllImport("NaroOccCore.dll")]
		private static extern void Geom_Geometry_Mirror9EAECD5B(IntPtr instance, IntPtr P);
		[DllImport("NaroOccCore.dll")]
		private static extern void Geom_Geometry_Mirror608B963B(IntPtr instance, IntPtr A1);
		[DllImport("NaroOccCore.dll")]
		private static extern void Geom_Geometry_Mirror7895386A(IntPtr instance, IntPtr A2);
		[DllImport("NaroOccCore.dll")]
		private static extern void Geom_Geometry_Rotate827CB19A(IntPtr instance, IntPtr A1,double Ang);
		[DllImport("NaroOccCore.dll")]
		private static extern void Geom_Geometry_ScaleF0D1E3E6(IntPtr instance, IntPtr P,double S);
		[DllImport("NaroOccCore.dll")]
		private static extern void Geom_Geometry_Translate9BD9CFFE(IntPtr instance, IntPtr V);
		[DllImport("NaroOccCore.dll")]
		private static extern void Geom_Geometry_Translate5C63477E(IntPtr instance, IntPtr P1,IntPtr P2);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Geom_Geometry_Mirrored9EAECD5B(IntPtr instance, IntPtr P);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Geom_Geometry_Mirrored608B963B(IntPtr instance, IntPtr A1);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Geom_Geometry_Mirrored7895386A(IntPtr instance, IntPtr A2);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Geom_Geometry_Rotated827CB19A(IntPtr instance, IntPtr A1,double Ang);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Geom_Geometry_ScaledF0D1E3E6(IntPtr instance, IntPtr P,double S);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Geom_Geometry_Transformed72D78650(IntPtr instance, IntPtr T);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Geom_Geometry_Translated9BD9CFFE(IntPtr instance, IntPtr V);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Geom_Geometry_Translated5C63477E(IntPtr instance, IntPtr P1,IntPtr P2);

		#region NativeInstancePtr Convert constructor

		public GeomGeometry() { } 

		public GeomGeometry(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ GeomGeometry_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void GeomGeometry_Dtor(IntPtr instance);
	}
}
