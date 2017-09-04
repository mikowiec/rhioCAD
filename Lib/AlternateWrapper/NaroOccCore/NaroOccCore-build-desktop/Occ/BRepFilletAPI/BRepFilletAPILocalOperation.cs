#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;
using NaroCppCore.Occ.BRepBuilderAPI;

#endregion

namespace NaroCppCore.Occ.BRepFilletAPI
{
	public class BRepFilletAPILocalOperation : BRepBuilderAPIMakeShape
	{

		#region NativeInstancePtr Convert constructor

		public BRepFilletAPILocalOperation() { } 

		public BRepFilletAPILocalOperation(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ BRepFilletAPILocalOperation_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void BRepFilletAPILocalOperation_Dtor(IntPtr instance);
	}
}
