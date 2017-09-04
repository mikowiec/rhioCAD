#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;
using NaroCppCore.Occ.MMgt;

#endregion

namespace NaroCppCore.Occ.SelectBasics
{
	public class SelectBasicsEntityOwner : MMgtTShared
	{
			public void Set(int aPriority)
				{
					SelectBasics_EntityOwner_SetE8219145(Instance, aPriority);
				}
		public int Priority{
			get {
				return SelectBasics_EntityOwner_Priority(Instance);
			}
		}
		[DllImport("NaroOccCore.dll")]
		private static extern void SelectBasics_EntityOwner_SetE8219145(IntPtr instance, int aPriority);
		[DllImport("NaroOccCore.dll")]
		private static extern int SelectBasics_EntityOwner_Priority(IntPtr instance);

		#region NativeInstancePtr Convert constructor

		public SelectBasicsEntityOwner() { } 

		public SelectBasicsEntityOwner(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ SelectBasicsEntityOwner_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void SelectBasicsEntityOwner_Dtor(IntPtr instance);
	}
}
