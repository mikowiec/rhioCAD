#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;
using NaroCppCore.Occ.V3d;

#endregion

namespace NaroCppCore.Occ.V3d
{
	public class V3dPositionLight : V3dLight
	{
			public void SetTarget(double X,double Y,double Z)
				{
					V3d_PositionLight_SetTarget9282A951(Instance, X, Y, Z);
				}
			public void OnHideFace(V3dView aView)
				{
					V3d_PositionLight_OnHideFace36A6FAB7(Instance, aView.Instance);
				}
			public void OnSeeFace(V3dView aView)
				{
					V3d_PositionLight_OnSeeFace36A6FAB7(Instance, aView.Instance);
				}
			public void Tracking(V3dView aView,V3dTypeOfPickLight WathPick,int Xpix,int Ypix)
				{
					V3d_PositionLight_TrackingA941FC63(Instance, aView.Instance, (int)WathPick, Xpix, Ypix);
				}
			public void Display(V3dView aView,V3dTypeOfRepresentation Representation)
				{
					V3d_PositionLight_DisplayF5FC77BB(Instance, aView.Instance, (int)Representation);
				}
			public void Erase()
				{
					V3d_PositionLight_Erase(Instance);
				}
			public bool SeeOrHide(V3dView aView)
				{
					return V3d_PositionLight_SeeOrHide36A6FAB7(Instance, aView.Instance);
				}
			public void Target(ref double X,ref double Y,ref double Z)
				{
					V3d_PositionLight_Target9282A951(Instance, ref X, ref Y, ref Z);
				}
		public double Radius{
			set { 
				V3d_PositionLight_SetRadius(Instance, value);
			}
			get {
				return V3d_PositionLight_Radius(Instance);
			}
		}
		[DllImport("NaroOccCore.dll")]
		private static extern void V3d_PositionLight_SetTarget9282A951(IntPtr instance, double X,double Y,double Z);
		[DllImport("NaroOccCore.dll")]
		private static extern void V3d_PositionLight_OnHideFace36A6FAB7(IntPtr instance, IntPtr aView);
		[DllImport("NaroOccCore.dll")]
		private static extern void V3d_PositionLight_OnSeeFace36A6FAB7(IntPtr instance, IntPtr aView);
		[DllImport("NaroOccCore.dll")]
		private static extern void V3d_PositionLight_TrackingA941FC63(IntPtr instance, IntPtr aView,int WathPick,int Xpix,int Ypix);
		[DllImport("NaroOccCore.dll")]
		private static extern void V3d_PositionLight_DisplayF5FC77BB(IntPtr instance, IntPtr aView,int Representation);
		[DllImport("NaroOccCore.dll")]
		private static extern void V3d_PositionLight_Erase(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool V3d_PositionLight_SeeOrHide36A6FAB7(IntPtr instance, IntPtr aView);
		[DllImport("NaroOccCore.dll")]
		private static extern void V3d_PositionLight_Target9282A951(IntPtr instance, ref double X,ref double Y,ref double Z);
		[DllImport("NaroOccCore.dll")]
		private static extern void V3d_PositionLight_SetRadius(IntPtr instance, double value);
		[DllImport("NaroOccCore.dll")]
		private static extern double V3d_PositionLight_Radius(IntPtr instance);

		#region NativeInstancePtr Convert constructor

		public V3dPositionLight() { } 

		public V3dPositionLight(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ V3dPositionLight_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void V3dPositionLight_Dtor(IntPtr instance);
	}
}
