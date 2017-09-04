#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;
using NaroCppCore.Occ.Graphic3d;

#endregion

namespace NaroCppCore.Occ.Visual3d
{
	public class Visual3dViewOrientation : NativeInstancePtr
	{
		public Visual3dViewOrientation()
 :
			base(Visual3d_ViewOrientation_Ctor() )
		{}
		public Visual3dViewOrientation(Graphic3dVertex VRP,Graphic3dVector VPN,Graphic3dVector VUP)
 :
			base(Visual3d_ViewOrientation_Ctor72AC10FF(VRP.Instance, VPN.Instance, VUP.Instance) )
		{}
		public Visual3dViewOrientation(Graphic3dVertex VRP,Graphic3dVector VPN,double Twist)
 :
			base(Visual3d_ViewOrientation_CtorBF9B1A1D(VRP.Instance, VPN.Instance, Twist) )
		{}
		public Visual3dViewOrientation(Graphic3dVertex VRP,double Azim,double Inc,double Twist)
 :
			base(Visual3d_ViewOrientation_Ctor346A1607(VRP.Instance, Azim, Inc, Twist) )
		{}
			public void SetAxialScale(double Sx,double Sy,double Sz)
				{
					Visual3d_ViewOrientation_SetAxialScale9282A951(Instance, Sx, Sy, Sz);
				}
			public void AxialScale(ref double Sx,ref double Sy,ref double Sz)
				{
					Visual3d_ViewOrientation_AxialScale9282A951(Instance, ref Sx, ref Sy, ref Sz);
				}
		public double Twist{
			get {
				return Visual3d_ViewOrientation_Twist(Instance);
			}
		}
		public Graphic3dVector ViewReferencePlane{
			set { 
				Visual3d_ViewOrientation_SetViewReferencePlane(Instance, value.Instance);
			}
			get {
				return new Graphic3dVector(Visual3d_ViewOrientation_ViewReferencePlane(Instance));
			}
		}
		public Graphic3dVertex ViewReferencePoint{
			set { 
				Visual3d_ViewOrientation_SetViewReferencePoint(Instance, value.Instance);
			}
			get {
				return new Graphic3dVertex(Visual3d_ViewOrientation_ViewReferencePoint(Instance));
			}
		}
		public Graphic3dVector ViewReferenceUp{
			set { 
				Visual3d_ViewOrientation_SetViewReferenceUp(Instance, value.Instance);
			}
			get {
				return new Graphic3dVector(Visual3d_ViewOrientation_ViewReferenceUp(Instance));
			}
		}
		public bool IsCustomMatrix{
			get {
				return Visual3d_ViewOrientation_IsCustomMatrix(Instance);
			}
		}
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Visual3d_ViewOrientation_Ctor();
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Visual3d_ViewOrientation_Ctor72AC10FF(IntPtr VRP,IntPtr VPN,IntPtr VUP);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Visual3d_ViewOrientation_CtorBF9B1A1D(IntPtr VRP,IntPtr VPN,double Twist);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Visual3d_ViewOrientation_Ctor346A1607(IntPtr VRP,double Azim,double Inc,double Twist);
		[DllImport("NaroOccCore.dll")]
		private static extern void Visual3d_ViewOrientation_SetAxialScale9282A951(IntPtr instance, double Sx,double Sy,double Sz);
		[DllImport("NaroOccCore.dll")]
		private static extern void Visual3d_ViewOrientation_AxialScale9282A951(IntPtr instance, ref double Sx,ref double Sy,ref double Sz);
		[DllImport("NaroOccCore.dll")]
		private static extern double Visual3d_ViewOrientation_Twist(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void Visual3d_ViewOrientation_SetViewReferencePlane(IntPtr instance, IntPtr value);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Visual3d_ViewOrientation_ViewReferencePlane(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void Visual3d_ViewOrientation_SetViewReferencePoint(IntPtr instance, IntPtr value);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Visual3d_ViewOrientation_ViewReferencePoint(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void Visual3d_ViewOrientation_SetViewReferenceUp(IntPtr instance, IntPtr value);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Visual3d_ViewOrientation_ViewReferenceUp(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool Visual3d_ViewOrientation_IsCustomMatrix(IntPtr instance);

		#region NativeInstancePtr Convert constructor

		public Visual3dViewOrientation(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ Visual3dViewOrientation_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void Visual3dViewOrientation_Dtor(IntPtr instance);
	}
}
