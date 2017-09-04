#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;
using NaroCppCore.Occ.Geom;
using NaroCppCore.Occ.gp;
using NaroCppCore.Occ.GeomAbs;

#endregion

namespace NaroCppCore.Occ.Geom
{
	public class GeomConic : GeomCurve
	{
			public void Reverse()
				{
					Geom_Conic_Reverse(Instance);
				}
			public bool IsCN(int N)
				{
					return Geom_Conic_IsCNE8219145(Instance, N);
				}
		public gpAx1 Axis{
			set { 
				Geom_Conic_SetAxis(Instance, value.Instance);
			}
			get {
				return new gpAx1(Geom_Conic_Axis(Instance));
			}
		}
		public gpPnt Location{
			set { 
				Geom_Conic_SetLocation(Instance, value.Instance);
			}
			get {
				return new gpPnt(Geom_Conic_Location(Instance));
			}
		}
		public gpAx2 Position{
			set { 
				Geom_Conic_SetPosition(Instance, value.Instance);
			}
			get {
				return new gpAx2(Geom_Conic_Position(Instance));
			}
		}
		public gpAx1 XAxis{
			get {
				return new gpAx1(Geom_Conic_XAxis(Instance));
			}
		}
		public gpAx1 YAxis{
			get {
				return new gpAx1(Geom_Conic_YAxis(Instance));
			}
		}
		public GeomAbsShape Continuity{
			get {
				return (GeomAbsShape)Geom_Conic_Continuity(Instance);
			}
		}
		[DllImport("NaroOccCore.dll")]
		private static extern void Geom_Conic_Reverse(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool Geom_Conic_IsCNE8219145(IntPtr instance, int N);
		[DllImport("NaroOccCore.dll")]
		private static extern void Geom_Conic_SetAxis(IntPtr instance, IntPtr value);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Geom_Conic_Axis(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void Geom_Conic_SetLocation(IntPtr instance, IntPtr value);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Geom_Conic_Location(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void Geom_Conic_SetPosition(IntPtr instance, IntPtr value);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Geom_Conic_Position(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Geom_Conic_XAxis(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Geom_Conic_YAxis(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern int Geom_Conic_Continuity(IntPtr instance);

		#region NativeInstancePtr Convert constructor

		public GeomConic() { } 

		public GeomConic(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ GeomConic_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void GeomConic_Dtor(IntPtr instance);
	}
}
