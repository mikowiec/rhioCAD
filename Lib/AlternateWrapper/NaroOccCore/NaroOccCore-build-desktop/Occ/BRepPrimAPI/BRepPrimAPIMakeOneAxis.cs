#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;
using NaroCppCore.Occ.BRepBuilderAPI;
using NaroCppCore.Occ.TopoDS;

#endregion

namespace NaroCppCore.Occ.BRepPrimAPI
{
	public class BRepPrimAPIMakeOneAxis : BRepBuilderAPIMakeShape
	{
			public void Build()
				{
					BRepPrimAPI_MakeOneAxis_Build(Instance);
				}
		public TopoDSFace Face{
			get {
				return new TopoDSFace(BRepPrimAPI_MakeOneAxis_Face(Instance));
			}
		}
		public TopoDSShell Shell{
			get {
				return new TopoDSShell(BRepPrimAPI_MakeOneAxis_Shell(Instance));
			}
		}
		public TopoDSSolid Solid{
			get {
				return new TopoDSSolid(BRepPrimAPI_MakeOneAxis_Solid(Instance));
			}
		}
		[DllImport("NaroOccCore.dll")]
		private static extern void BRepPrimAPI_MakeOneAxis_Build(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr BRepPrimAPI_MakeOneAxis_Face(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr BRepPrimAPI_MakeOneAxis_Shell(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr BRepPrimAPI_MakeOneAxis_Solid(IntPtr instance);

		#region NativeInstancePtr Convert constructor

		public BRepPrimAPIMakeOneAxis() { } 

		public BRepPrimAPIMakeOneAxis(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ BRepPrimAPIMakeOneAxis_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void BRepPrimAPIMakeOneAxis_Dtor(IntPtr instance);
	}
}
