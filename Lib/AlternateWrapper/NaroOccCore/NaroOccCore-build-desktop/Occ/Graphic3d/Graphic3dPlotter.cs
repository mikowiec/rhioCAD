#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;
using NaroCppCore.Occ.MMgt;
using NaroCppCore.Occ.Graphic3d;

#endregion

namespace NaroCppCore.Occ.Graphic3d
{
	public class Graphic3dPlotter : MMgtTShared
	{
			public bool BeginPlot(Graphic3dDataStructureManager aProjector)
				{
					return Graphic3d_Plotter_BeginPlot8A4E6B67(Instance, aProjector.Instance);
				}
			public void EndPlot()
				{
					Graphic3d_Plotter_EndPlot(Instance);
				}
		[DllImport("NaroOccCore.dll")]
		private static extern bool Graphic3d_Plotter_BeginPlot8A4E6B67(IntPtr instance, IntPtr aProjector);
		[DllImport("NaroOccCore.dll")]
		private static extern void Graphic3d_Plotter_EndPlot(IntPtr instance);

		#region NativeInstancePtr Convert constructor

		public Graphic3dPlotter() { } 

		public Graphic3dPlotter(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ Graphic3dPlotter_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void Graphic3dPlotter_Dtor(IntPtr instance);
	}
}
