#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;
using NaroCppCore.Occ.MMgt;

#endregion

namespace NaroCppCore.Occ.Graphic3d
{
	public class Graphic3dDataStructureManager : MMgtTShared
	{

		#region NativeInstancePtr Convert constructor

		public Graphic3dDataStructureManager() { } 

		public Graphic3dDataStructureManager(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ Graphic3dDataStructureManager_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void Graphic3dDataStructureManager_Dtor(IntPtr instance);
	}
}
