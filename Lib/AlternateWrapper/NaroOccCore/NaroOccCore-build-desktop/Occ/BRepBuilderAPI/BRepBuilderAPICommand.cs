#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;

#endregion

namespace NaroCppCore.Occ.BRepBuilderAPI
{
	public class BRepBuilderAPICommand : NativeInstancePtr
	{
			public void Delete()
				{
					BRepBuilderAPI_Command_Delete(Instance);
				}
			public void Check()
				{
					BRepBuilderAPI_Command_Check(Instance);
				}
		public bool IsDone{
			get {
				return BRepBuilderAPI_Command_IsDone(Instance);
			}
		}
		[DllImport("NaroOccCore.dll")]
		private static extern void BRepBuilderAPI_Command_Delete(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void BRepBuilderAPI_Command_Check(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool BRepBuilderAPI_Command_IsDone(IntPtr instance);

		#region NativeInstancePtr Convert constructor

		public BRepBuilderAPICommand() { } 

		public BRepBuilderAPICommand(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ BRepBuilderAPICommand_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void BRepBuilderAPICommand_Dtor(IntPtr instance);
	}
}
