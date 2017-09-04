#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;
using NaroCppCore.Occ.XSControl;

#endregion

namespace NaroCppCore.Occ.STEPControl
{
	public class STEPControlReader : XSControlReader
	{
		public STEPControlReader()
 :
			base(STEPControl_Reader_Ctor() )
		{}
		public STEPControlReader(XSControlWorkSession WS,bool scratch)
 :
			base(STEPControl_Reader_CtorC53309E3(WS.Instance, scratch) )
		{}
			public bool TransferRoot(int num)
				{
					return STEPControl_Reader_TransferRootE8219145(Instance, num);
				}
		public int NbRootsForTransfer{
			get {
				return STEPControl_Reader_NbRootsForTransfer(Instance);
			}
		}
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr STEPControl_Reader_Ctor();
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr STEPControl_Reader_CtorC53309E3(IntPtr WS,bool scratch);
		[DllImport("NaroOccCore.dll")]
		private static extern bool STEPControl_Reader_TransferRootE8219145(IntPtr instance, int num);
		[DllImport("NaroOccCore.dll")]
		private static extern int STEPControl_Reader_NbRootsForTransfer(IntPtr instance);

		#region NativeInstancePtr Convert constructor

		public STEPControlReader(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ STEPControlReader_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void STEPControlReader_Dtor(IntPtr instance);
	}
}
