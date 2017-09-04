#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;
using NaroCppCore.Occ.MMgt;
using NaroCppCore.Occ.Graphic3d;
using NaroCppCore.Occ.Aspect;

#endregion

namespace NaroCppCore.Occ.Graphic3d
{
	public class Graphic3dStructureManager : MMgtTShared
	{
			public void MinMaxValues(ref double XMin,ref double YMin,ref double ZMin,ref double XMax,ref double YMax,ref double ZMax)
				{
					Graphic3d_StructureManager_MinMaxValuesBC7A5786(Instance, ref XMin, ref YMin, ref ZMin, ref XMax, ref YMax, ref ZMax);
				}
			public int Identification()
				{
					return Graphic3d_StructureManager_Identification(Instance);
				}
		public Graphic3dAspectFillArea3d FillArea3dAspect{
			get {
				return new Graphic3dAspectFillArea3d(Graphic3d_StructureManager_FillArea3dAspect(Instance));
			}
		}
		public static int Limit{
			get {
				return Graphic3d_StructureManager_Limit();
			}
		}
		public Graphic3dAspectText3d Text3dAspect{
			get {
				return new Graphic3dAspectText3d(Graphic3d_StructureManager_Text3dAspect(Instance));
			}
		}
		public AspectTypeOfUpdate UpdateMode{
			set { 
				Graphic3d_StructureManager_SetUpdateMode(Instance, (int)value);
			}
			get {
				return (AspectTypeOfUpdate)Graphic3d_StructureManager_UpdateMode(Instance);
			}
		}
		public static int CurrentId{
			get {
				return Graphic3d_StructureManager_CurrentId();
			}
		}
		public AspectGraphicDevice GraphicDevice{
			get {
				return new AspectGraphicDevice(Graphic3d_StructureManager_GraphicDevice(Instance));
			}
		}
		[DllImport("NaroOccCore.dll")]
		private static extern void Graphic3d_StructureManager_MinMaxValuesBC7A5786(IntPtr instance, ref double XMin,ref double YMin,ref double ZMin,ref double XMax,ref double YMax,ref double ZMax);
		[DllImport("NaroOccCore.dll")]
		private static extern int Graphic3d_StructureManager_Identification(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Graphic3d_StructureManager_FillArea3dAspect(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern int Graphic3d_StructureManager_Limit();
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Graphic3d_StructureManager_Text3dAspect(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void Graphic3d_StructureManager_SetUpdateMode(IntPtr instance, int value);
		[DllImport("NaroOccCore.dll")]
		private static extern int Graphic3d_StructureManager_UpdateMode(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern int Graphic3d_StructureManager_CurrentId();
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Graphic3d_StructureManager_GraphicDevice(IntPtr instance);

		#region NativeInstancePtr Convert constructor

		public Graphic3dStructureManager() { } 

		public Graphic3dStructureManager(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ Graphic3dStructureManager_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void Graphic3dStructureManager_Dtor(IntPtr instance);
	}
}
