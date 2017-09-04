#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;
using NaroCppCore.Occ.MMgt;
using NaroCppCore.Occ.Prs2d;

#endregion

namespace NaroCppCore.Occ.Prs2d
{
	public class Prs2dDrawer : MMgtTShared
	{
		public Prs2dDrawer()
 :
			base(Prs2d_Drawer_Ctor() )
		{}
			public Prs2dAspectRoot FindAspect(Prs2dAspectName anAspectName)
				{
					return new Prs2dAspectRoot(Prs2d_Drawer_FindAspect3485EFC5(Instance, (int)anAspectName));
				}
			public void SetAspect(Prs2dAspectRoot anAspectRoot,Prs2dAspectName anAspectName)
				{
					Prs2d_Drawer_SetAspectADBB773B(Instance, anAspectRoot.Instance, (int)anAspectName);
				}
		public double MaxParameterValue{
			set { 
				Prs2d_Drawer_SetMaxParameterValue(Instance, value);
			}
			get {
				return Prs2d_Drawer_MaxParameterValue(Instance);
			}
		}
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Prs2d_Drawer_Ctor();
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Prs2d_Drawer_FindAspect3485EFC5(IntPtr instance, int anAspectName);
		[DllImport("NaroOccCore.dll")]
		private static extern void Prs2d_Drawer_SetAspectADBB773B(IntPtr instance, IntPtr anAspectRoot,int anAspectName);
		[DllImport("NaroOccCore.dll")]
		private static extern void Prs2d_Drawer_SetMaxParameterValue(IntPtr instance, double value);
		[DllImport("NaroOccCore.dll")]
		private static extern double Prs2d_Drawer_MaxParameterValue(IntPtr instance);

		#region NativeInstancePtr Convert constructor

		public Prs2dDrawer(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ Prs2dDrawer_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void Prs2dDrawer_Dtor(IntPtr instance);
	}
}
