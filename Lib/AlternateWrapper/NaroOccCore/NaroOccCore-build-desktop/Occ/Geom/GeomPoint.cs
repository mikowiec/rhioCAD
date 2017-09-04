#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;
using NaroCppCore.Occ.Geom;

#endregion

namespace NaroCppCore.Occ.Geom
{
	public class GeomPoint : GeomGeometry
	{
			public double Distance(GeomPoint Other)
				{
					return Geom_Point_Distance121385BD(Instance, Other.Instance);
				}
			public double SquareDistance(GeomPoint Other)
				{
					return Geom_Point_SquareDistance121385BD(Instance, Other.Instance);
				}
		[DllImport("NaroOccCore.dll")]
		private static extern double Geom_Point_Distance121385BD(IntPtr instance, IntPtr Other);
		[DllImport("NaroOccCore.dll")]
		private static extern double Geom_Point_SquareDistance121385BD(IntPtr instance, IntPtr Other);

		#region NativeInstancePtr Convert constructor

		public GeomPoint() { } 

		public GeomPoint(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ GeomPoint_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void GeomPoint_Dtor(IntPtr instance);
	}
}
