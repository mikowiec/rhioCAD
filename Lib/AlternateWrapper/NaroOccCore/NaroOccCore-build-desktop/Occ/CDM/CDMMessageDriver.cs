#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;
using NaroCppCore.Occ.Standard;

#endregion

namespace NaroCppCore.Occ.CDM
{
	public class CDMMessageDriver : StandardTransient
	{

		#region NativeInstancePtr Convert constructor

		public CDMMessageDriver() { } 

		public CDMMessageDriver(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ CDMMessageDriver_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void CDMMessageDriver_Dtor(IntPtr instance);
	}
}
