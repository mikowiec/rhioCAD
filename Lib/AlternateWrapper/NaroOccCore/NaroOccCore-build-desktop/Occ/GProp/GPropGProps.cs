#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;
using NaroCppCore.Occ.gp;
using NaroCppCore.Occ.GProp;

#endregion

namespace NaroCppCore.Occ.GProp
{
	public class GPropGProps : NativeInstancePtr
	{
		public GPropGProps()
 :
			base(GProp_GProps_Ctor() )
		{}
		public GPropGProps(gpPnt SystemLocation)
 :
			base(GProp_GProps_Ctor9EAECD5B(SystemLocation.Instance) )
		{}
			public void Add(GPropGProps Item,double Density)
				{
					GProp_GProps_Add38D0113A(Instance, Item.Instance, Density);
				}
			public void StaticMoments(ref double Ix,ref double Iy,ref double Iz)
				{
					GProp_GProps_StaticMoments9282A951(Instance, ref Ix, ref Iy, ref Iz);
				}
			public double MomentOfInertia(gpAx1 A)
				{
					return GProp_GProps_MomentOfInertia608B963B(Instance, A.Instance);
				}
			public double RadiusOfGyration(gpAx1 A)
				{
					return GProp_GProps_RadiusOfGyration608B963B(Instance, A.Instance);
				}
		public double Mass{
			get {
				return GProp_GProps_Mass(Instance);
			}
		}
		public gpPnt CentreOfMass{
			get {
				return new gpPnt(GProp_GProps_CentreOfMass(Instance));
			}
		}
		public gpMat MatrixOfInertia{
			get {
				return new gpMat(GProp_GProps_MatrixOfInertia(Instance));
			}
		}
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr GProp_GProps_Ctor();
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr GProp_GProps_Ctor9EAECD5B(IntPtr SystemLocation);
		[DllImport("NaroOccCore.dll")]
		private static extern void GProp_GProps_Add38D0113A(IntPtr instance, IntPtr Item,double Density);
		[DllImport("NaroOccCore.dll")]
		private static extern void GProp_GProps_StaticMoments9282A951(IntPtr instance, ref double Ix,ref double Iy,ref double Iz);
		[DllImport("NaroOccCore.dll")]
		private static extern double GProp_GProps_MomentOfInertia608B963B(IntPtr instance, IntPtr A);
		[DllImport("NaroOccCore.dll")]
		private static extern double GProp_GProps_RadiusOfGyration608B963B(IntPtr instance, IntPtr A);
		[DllImport("NaroOccCore.dll")]
		private static extern double GProp_GProps_Mass(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr GProp_GProps_CentreOfMass(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr GProp_GProps_MatrixOfInertia(IntPtr instance);

		#region NativeInstancePtr Convert constructor

		public GPropGProps(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ GPropGProps_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void GPropGProps_Dtor(IntPtr instance);
	}
}
