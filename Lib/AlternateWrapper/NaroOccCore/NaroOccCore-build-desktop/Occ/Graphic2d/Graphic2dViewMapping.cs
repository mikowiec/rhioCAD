#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;
using NaroCppCore.Occ.MMgt;

#endregion

namespace NaroCppCore.Occ.Graphic2d
{
	public class Graphic2dViewMapping : MMgtTShared
	{
		public Graphic2dViewMapping()
 :
			base(Graphic2d_ViewMapping_Ctor() )
		{}
			public void SetViewMapping(double aXCenter,double aYCenter,double aSize)
				{
					Graphic2d_ViewMapping_SetViewMapping9282A951(Instance, aXCenter, aYCenter, aSize);
				}
			public void SetCenter(double aXCenter,double aYCenter)
				{
					Graphic2d_ViewMapping_SetCenter9F0E714F(Instance, aXCenter, aYCenter);
				}
			public void SetViewMappingDefault()
				{
					Graphic2d_ViewMapping_SetViewMappingDefault(Instance);
				}
			public void ViewMappingReset()
				{
					Graphic2d_ViewMapping_ViewMappingReset(Instance);
				}
			public void ViewMapping(ref double XCenter,ref double YCenter,ref double Size)
				{
					Graphic2d_ViewMapping_ViewMapping9282A951(Instance, ref XCenter, ref YCenter, ref Size);
				}
			public void Center(ref double XCenter,ref double YCenter)
				{
					Graphic2d_ViewMapping_Center9F0E714F(Instance, ref XCenter, ref YCenter);
				}
			public void ViewMappingDefault(ref double XCenter,ref double YCenter,ref double Size)
				{
					Graphic2d_ViewMapping_ViewMappingDefault9282A951(Instance, ref XCenter, ref YCenter, ref Size);
				}
		public double Size{
			set { 
				Graphic2d_ViewMapping_SetSize(Instance, value);
			}
		}
		public double Zoom{
			get {
				return Graphic2d_ViewMapping_Zoom(Instance);
			}
		}
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Graphic2d_ViewMapping_Ctor();
		[DllImport("NaroOccCore.dll")]
		private static extern void Graphic2d_ViewMapping_SetViewMapping9282A951(IntPtr instance, double aXCenter,double aYCenter,double aSize);
		[DllImport("NaroOccCore.dll")]
		private static extern void Graphic2d_ViewMapping_SetCenter9F0E714F(IntPtr instance, double aXCenter,double aYCenter);
		[DllImport("NaroOccCore.dll")]
		private static extern void Graphic2d_ViewMapping_SetViewMappingDefault(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void Graphic2d_ViewMapping_ViewMappingReset(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void Graphic2d_ViewMapping_ViewMapping9282A951(IntPtr instance, ref double XCenter,ref double YCenter,ref double Size);
		[DllImport("NaroOccCore.dll")]
		private static extern void Graphic2d_ViewMapping_Center9F0E714F(IntPtr instance, ref double XCenter,ref double YCenter);
		[DllImport("NaroOccCore.dll")]
		private static extern void Graphic2d_ViewMapping_ViewMappingDefault9282A951(IntPtr instance, ref double XCenter,ref double YCenter,ref double Size);
		[DllImport("NaroOccCore.dll")]
		private static extern void Graphic2d_ViewMapping_SetSize(IntPtr instance, double value);
		[DllImport("NaroOccCore.dll")]
		private static extern double Graphic2d_ViewMapping_Zoom(IntPtr instance);

		#region NativeInstancePtr Convert constructor

		public Graphic2dViewMapping(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ Graphic2dViewMapping_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void Graphic2dViewMapping_Dtor(IntPtr instance);
	}
}
