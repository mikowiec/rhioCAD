#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;
using NaroCppCore.Occ.V3d;
using NaroCppCore.Occ.Quantity;

#endregion

namespace NaroCppCore.Occ.V3d
{
	public class V3dDirectionalLight : V3dPositionLight
	{
		public V3dDirectionalLight(V3dViewer VM,V3dTypeOfOrientation Direction,QuantityNameOfColor Color,bool Headlight)
 :
			base(V3d_DirectionalLight_Ctor83D2E67B(VM.Instance, (int)Direction, (int)Color, Headlight) )
		{}
		public V3dDirectionalLight(V3dViewer VM,double Xt,double Yt,double Zt,double Xp,double Yp,double Zp,QuantityNameOfColor Color,bool Headlight)
 :
			base(V3d_DirectionalLight_CtorEB2CC882(VM.Instance, Xt, Yt, Zt, Xp, Yp, Zp, (int)Color, Headlight) )
		{}
			public void SetDirection(V3dTypeOfOrientation Direction)
				{
					V3d_DirectionalLight_SetDirection17AA5025(Instance, (int)Direction);
				}
			public void SetDirection(double Xm,double Ym,double Zm)
				{
					V3d_DirectionalLight_SetDirection9282A951(Instance, Xm, Ym, Zm);
				}
			public void SetDisplayPosition(double X,double Y,double Z)
				{
					V3d_DirectionalLight_SetDisplayPosition9282A951(Instance, X, Y, Z);
				}
			public void SetPosition(double Xp,double Yp,double Zp)
				{
					V3d_DirectionalLight_SetPosition9282A951(Instance, Xp, Yp, Zp);
				}
			public void Display(V3dView aView,V3dTypeOfRepresentation Representation)
				{
					V3d_DirectionalLight_DisplayF5FC77BB(Instance, aView.Instance, (int)Representation);
				}
			public void Position(ref double X,ref double Y,ref double Z)
				{
					V3d_DirectionalLight_Position9282A951(Instance, ref X, ref Y, ref Z);
				}
			public void DisplayPosition(ref double X,ref double Y,ref double Z)
				{
					V3d_DirectionalLight_DisplayPosition9282A951(Instance, ref X, ref Y, ref Z);
				}
			public void Direction(ref double Vx,ref double Vy,ref double Vz)
				{
					V3d_DirectionalLight_Direction9282A951(Instance, ref Vx, ref Vy, ref Vz);
				}
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr V3d_DirectionalLight_Ctor83D2E67B(IntPtr VM,int Direction,int Color,bool Headlight);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr V3d_DirectionalLight_CtorEB2CC882(IntPtr VM,double Xt,double Yt,double Zt,double Xp,double Yp,double Zp,int Color,bool Headlight);
		[DllImport("NaroOccCore.dll")]
		private static extern void V3d_DirectionalLight_SetDirection17AA5025(IntPtr instance, int Direction);
		[DllImport("NaroOccCore.dll")]
		private static extern void V3d_DirectionalLight_SetDirection9282A951(IntPtr instance, double Xm,double Ym,double Zm);
		[DllImport("NaroOccCore.dll")]
		private static extern void V3d_DirectionalLight_SetDisplayPosition9282A951(IntPtr instance, double X,double Y,double Z);
		[DllImport("NaroOccCore.dll")]
		private static extern void V3d_DirectionalLight_SetPosition9282A951(IntPtr instance, double Xp,double Yp,double Zp);
		[DllImport("NaroOccCore.dll")]
		private static extern void V3d_DirectionalLight_DisplayF5FC77BB(IntPtr instance, IntPtr aView,int Representation);
		[DllImport("NaroOccCore.dll")]
		private static extern void V3d_DirectionalLight_Position9282A951(IntPtr instance, ref double X,ref double Y,ref double Z);
		[DllImport("NaroOccCore.dll")]
		private static extern void V3d_DirectionalLight_DisplayPosition9282A951(IntPtr instance, ref double X,ref double Y,ref double Z);
		[DllImport("NaroOccCore.dll")]
		private static extern void V3d_DirectionalLight_Direction9282A951(IntPtr instance, ref double Vx,ref double Vy,ref double Vz);

		#region NativeInstancePtr Convert constructor

		public V3dDirectionalLight() { } 

		public V3dDirectionalLight(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ V3dDirectionalLight_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void V3dDirectionalLight_Dtor(IntPtr instance);
	}
}
