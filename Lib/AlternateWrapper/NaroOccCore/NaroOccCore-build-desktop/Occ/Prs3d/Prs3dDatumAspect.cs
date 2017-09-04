#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;
using NaroCppCore.Occ.Prs3d;

#endregion

namespace NaroCppCore.Occ.Prs3d
{
	public class Prs3dDatumAspect : Prs3dCompositeAspect
	{
		public Prs3dDatumAspect()
 :
			base(Prs3d_DatumAspect_Ctor() )
		{}
			public void SetAxisLength(double L1,double L2,double L3)
				{
					Prs3d_DatumAspect_SetAxisLength9282A951(Instance, L1, L2, L3);
				}
		public Prs3dLineAspect FirstAxisAspect{
			get {
				return new Prs3dLineAspect(Prs3d_DatumAspect_FirstAxisAspect(Instance));
			}
		}
		public Prs3dLineAspect SecondAxisAspect{
			get {
				return new Prs3dLineAspect(Prs3d_DatumAspect_SecondAxisAspect(Instance));
			}
		}
		public Prs3dLineAspect ThirdAxisAspect{
			get {
				return new Prs3dLineAspect(Prs3d_DatumAspect_ThirdAxisAspect(Instance));
			}
		}
		public bool DrawFirstAndSecondAxis{
			set { 
				Prs3d_DatumAspect_SetDrawFirstAndSecondAxis(Instance, value);
			}
			get {
				return Prs3d_DatumAspect_DrawFirstAndSecondAxis(Instance);
			}
		}
		public bool DrawThirdAxis{
			set { 
				Prs3d_DatumAspect_SetDrawThirdAxis(Instance, value);
			}
			get {
				return Prs3d_DatumAspect_DrawThirdAxis(Instance);
			}
		}
		public double FirstAxisLength{
			get {
				return Prs3d_DatumAspect_FirstAxisLength(Instance);
			}
		}
		public double SecondAxisLength{
			get {
				return Prs3d_DatumAspect_SecondAxisLength(Instance);
			}
		}
		public double ThirdAxisLength{
			get {
				return Prs3d_DatumAspect_ThirdAxisLength(Instance);
			}
		}
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Prs3d_DatumAspect_Ctor();
		[DllImport("NaroOccCore.dll")]
		private static extern void Prs3d_DatumAspect_SetAxisLength9282A951(IntPtr instance, double L1,double L2,double L3);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Prs3d_DatumAspect_FirstAxisAspect(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Prs3d_DatumAspect_SecondAxisAspect(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Prs3d_DatumAspect_ThirdAxisAspect(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void Prs3d_DatumAspect_SetDrawFirstAndSecondAxis(IntPtr instance, bool value);
		[DllImport("NaroOccCore.dll")]
		private static extern bool Prs3d_DatumAspect_DrawFirstAndSecondAxis(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void Prs3d_DatumAspect_SetDrawThirdAxis(IntPtr instance, bool value);
		[DllImport("NaroOccCore.dll")]
		private static extern bool Prs3d_DatumAspect_DrawThirdAxis(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern double Prs3d_DatumAspect_FirstAxisLength(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern double Prs3d_DatumAspect_SecondAxisLength(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern double Prs3d_DatumAspect_ThirdAxisLength(IntPtr instance);

		#region NativeInstancePtr Convert constructor

		public Prs3dDatumAspect(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ Prs3dDatumAspect_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void Prs3dDatumAspect_Dtor(IntPtr instance);
	}
}
