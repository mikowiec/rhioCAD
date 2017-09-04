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
	public class GeomElementarySurface : GeomSurface
	{
			public void UReverse()
				{
					Geom_ElementarySurface_UReverse(Instance);
				}
			public void VReverse()
				{
					Geom_ElementarySurface_VReverse(Instance);
				}
			public bool IsCNu(int N)
				{
					return Geom_ElementarySurface_IsCNuE8219145(Instance, N);
				}
			public bool IsCNv(int N)
				{
					return Geom_ElementarySurface_IsCNvE8219145(Instance, N);
				}
		public gpAx1 Axis{
			set { 
				Geom_ElementarySurface_SetAxis(Instance, value.Instance);
			}
			get {
				return new gpAx1(Geom_ElementarySurface_Axis(Instance));
			}
		}
		public gpPnt Location{
			set { 
				Geom_ElementarySurface_SetLocation(Instance, value.Instance);
			}
			get {
				return new gpPnt(Geom_ElementarySurface_Location(Instance));
			}
		}
		public gpAx3 Position{
			set { 
				Geom_ElementarySurface_SetPosition(Instance, value.Instance);
			}
			get {
				return new gpAx3(Geom_ElementarySurface_Position(Instance));
			}
		}
		public GeomAbsShape Continuity{
			get {
				return (GeomAbsShape)Geom_ElementarySurface_Continuity(Instance);
			}
		}
		[DllImport("NaroOccCore.dll")]
		private static extern void Geom_ElementarySurface_UReverse(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void Geom_ElementarySurface_VReverse(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool Geom_ElementarySurface_IsCNuE8219145(IntPtr instance, int N);
		[DllImport("NaroOccCore.dll")]
		private static extern bool Geom_ElementarySurface_IsCNvE8219145(IntPtr instance, int N);
		[DllImport("NaroOccCore.dll")]
		private static extern void Geom_ElementarySurface_SetAxis(IntPtr instance, IntPtr value);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Geom_ElementarySurface_Axis(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void Geom_ElementarySurface_SetLocation(IntPtr instance, IntPtr value);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Geom_ElementarySurface_Location(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void Geom_ElementarySurface_SetPosition(IntPtr instance, IntPtr value);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Geom_ElementarySurface_Position(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern int Geom_ElementarySurface_Continuity(IntPtr instance);

		#region NativeInstancePtr Convert constructor

		public GeomElementarySurface() { } 

		public GeomElementarySurface(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ GeomElementarySurface_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void GeomElementarySurface_Dtor(IntPtr instance);
	}
}
