#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;
using NaroCppCore.Occ.MMgt;
using NaroCppCore.Occ.SelectBasics;
using NaroCppCore.Occ.SelectMgr;

#endregion

namespace NaroCppCore.Occ.SelectMgr
{
	public class SelectMgrSelection : MMgtTShared
	{
		public SelectMgrSelection(int IdMode)
 :
			base(SelectMgr_Selection_CtorE8219145(IdMode) )
		{}
			public void Add(SelectBasicsSensitiveEntity aprimitive)
				{
					SelectMgr_Selection_Add608D2A9E(Instance, aprimitive.Instance);
				}
			public void Clear()
				{
					SelectMgr_Selection_Clear(Instance);
				}
			public void Init()
				{
					SelectMgr_Selection_Init(Instance);
				}
			public void Next()
				{
					SelectMgr_Selection_Next(Instance);
				}
			public SelectMgrTypeOfUpdate UpdateStatus()
				{
					return (SelectMgrTypeOfUpdate)SelectMgr_Selection_UpdateStatus(Instance);
				}
			public void UpdateStatus(SelectMgrTypeOfUpdate UpdateFlag)
				{
					SelectMgr_Selection_UpdateStatus6D7AC047(Instance, (int)UpdateFlag);
				}
		public bool IsEmpty{
			get {
				return SelectMgr_Selection_IsEmpty(Instance);
			}
		}
		public int Mode{
			get {
				return SelectMgr_Selection_Mode(Instance);
			}
		}
		public bool More{
			get {
				return SelectMgr_Selection_More(Instance);
			}
		}
		public SelectBasicsSensitiveEntity Sensitive{
			get {
				return new SelectBasicsSensitiveEntity(SelectMgr_Selection_Sensitive(Instance));
			}
		}
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr SelectMgr_Selection_CtorE8219145(int IdMode);
		[DllImport("NaroOccCore.dll")]
		private static extern void SelectMgr_Selection_Add608D2A9E(IntPtr instance, IntPtr aprimitive);
		[DllImport("NaroOccCore.dll")]
		private static extern void SelectMgr_Selection_Clear(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void SelectMgr_Selection_Init(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void SelectMgr_Selection_Next(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern int SelectMgr_Selection_UpdateStatus(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void SelectMgr_Selection_UpdateStatus6D7AC047(IntPtr instance, int UpdateFlag);
		[DllImport("NaroOccCore.dll")]
		private static extern bool SelectMgr_Selection_IsEmpty(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern int SelectMgr_Selection_Mode(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool SelectMgr_Selection_More(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr SelectMgr_Selection_Sensitive(IntPtr instance);

		#region NativeInstancePtr Convert constructor

		public SelectMgrSelection() { } 

		public SelectMgrSelection(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ SelectMgrSelection_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void SelectMgrSelection_Dtor(IntPtr instance);
	}
}
