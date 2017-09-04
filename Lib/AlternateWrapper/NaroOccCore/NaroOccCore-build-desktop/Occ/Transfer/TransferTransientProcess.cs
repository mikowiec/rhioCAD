#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;
using NaroCppCore.Occ.Transfer;
using NaroCppCore.Occ.Dico;

#endregion

namespace NaroCppCore.Occ.Transfer
{
	public class TransferTransientProcess : TransferProcessForTransient
	{
		public TransferTransientProcess(int nb)
 :
			base(Transfer_TransientProcess_CtorE8219145(nb) )
		{}
			public DicoDictionaryOfTransient Context()
				{
					return new DicoDictionaryOfTransient(Transfer_TransientProcess_Context(Instance));
				}
		public bool HasGraph{
			get {
				return Transfer_TransientProcess_HasGraph(Instance);
			}
		}
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Transfer_TransientProcess_CtorE8219145(int nb);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Transfer_TransientProcess_Context(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool Transfer_TransientProcess_HasGraph(IntPtr instance);

		#region NativeInstancePtr Convert constructor

		public TransferTransientProcess() { } 

		public TransferTransientProcess(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ TransferTransientProcess_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void TransferTransientProcess_Dtor(IntPtr instance);
	}
}
