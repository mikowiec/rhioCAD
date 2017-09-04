#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;
using NaroCppCore.Occ.MMgt;
using NaroCppCore.Occ.SelectMgr;
using NaroCppCore.Occ.TCollection;

#endregion

namespace NaroCppCore.Occ.SelectMgr
{
	public class SelectMgrSelectionManager : MMgtTShared
	{
		public SelectMgrSelectionManager()
 :
			base(SelectMgr_SelectionManager_Ctor() )
		{}
			public void Add(SelectMgrViewerSelector aSelector)
				{
					SelectMgr_SelectionManager_Add14225620(Instance, aSelector.Instance);
				}
			public void Remove(SelectMgrViewerSelector aSelector)
				{
					SelectMgr_SelectionManager_Remove14225620(Instance, aSelector.Instance);
				}
			public bool Contains(SelectMgrViewerSelector aSelector)
				{
					return SelectMgr_SelectionManager_Contains14225620(Instance, aSelector.Instance);
				}
			public bool Contains(SelectMgrSelectableObject aSelectableObject)
				{
					return SelectMgr_SelectionManager_ContainsCB355689(Instance, aSelectableObject.Instance);
				}
			public void Load(SelectMgrSelectableObject anObject,int aMode)
				{
					SelectMgr_SelectionManager_LoadC6B3194D(Instance, anObject.Instance, aMode);
				}
			public void Load(SelectMgrSelectableObject anObject,SelectMgrViewerSelector aSelector,int aMode)
				{
					SelectMgr_SelectionManager_Load55B1618F(Instance, anObject.Instance, aSelector.Instance, aMode);
				}
			public void Remove(SelectMgrSelectableObject anObject)
				{
					SelectMgr_SelectionManager_RemoveCB355689(Instance, anObject.Instance);
				}
			public void Remove(SelectMgrSelectableObject anObject,SelectMgrViewerSelector aSelector)
				{
					SelectMgr_SelectionManager_Remove6CD936C3(Instance, anObject.Instance, aSelector.Instance);
				}
			public void Activate(SelectMgrSelectableObject anObject,int aMode,bool AutomaticProj)
				{
					SelectMgr_SelectionManager_Activate6947D965(Instance, anObject.Instance, aMode, AutomaticProj);
				}
			public void Activate(SelectMgrSelectableObject anObject,int aMode,SelectMgrViewerSelector aSelector,bool AutomaticProj)
				{
					SelectMgr_SelectionManager_Activate271DDBB2(Instance, anObject.Instance, aMode, aSelector.Instance, AutomaticProj);
				}
			public void Deactivate(SelectMgrSelectableObject anObject)
				{
					SelectMgr_SelectionManager_DeactivateCB355689(Instance, anObject.Instance);
				}
			public void Deactivate(SelectMgrSelectableObject anObject,int aMode)
				{
					SelectMgr_SelectionManager_DeactivateC6B3194D(Instance, anObject.Instance, aMode);
				}
			public void Deactivate(SelectMgrSelectableObject anObject,int aMode,SelectMgrViewerSelector aSelector)
				{
					SelectMgr_SelectionManager_Deactivate9FE1369E(Instance, anObject.Instance, aMode, aSelector.Instance);
				}
			public void Deactivate(SelectMgrSelectableObject anObject,SelectMgrViewerSelector aSelector)
				{
					SelectMgr_SelectionManager_Deactivate6CD936C3(Instance, anObject.Instance, aSelector.Instance);
				}
			public void Sleep(SelectMgrViewerSelector aSelector)
				{
					SelectMgr_SelectionManager_Sleep14225620(Instance, aSelector.Instance);
				}
			public void Sleep(SelectMgrSelectableObject anObject)
				{
					SelectMgr_SelectionManager_SleepCB355689(Instance, anObject.Instance);
				}
			public void Sleep(SelectMgrSelectableObject anObject,SelectMgrViewerSelector aSelector)
				{
					SelectMgr_SelectionManager_Sleep6CD936C3(Instance, anObject.Instance, aSelector.Instance);
				}
			public void Awake(SelectMgrViewerSelector aSelector,bool AutomaticProj)
				{
					SelectMgr_SelectionManager_AwakeC739D92A(Instance, aSelector.Instance, AutomaticProj);
				}
			public void Awake(SelectMgrSelectableObject anObject,bool AutomaticProj)
				{
					SelectMgr_SelectionManager_AwakeD97CA70B(Instance, anObject.Instance, AutomaticProj);
				}
			public void Awake(SelectMgrSelectableObject anObject,SelectMgrViewerSelector aSelector,bool AutomaticProj)
				{
					SelectMgr_SelectionManager_Awake40EFAF9D(Instance, anObject.Instance, aSelector.Instance, AutomaticProj);
				}
			public bool IsActivated(SelectMgrSelectableObject anObject)
				{
					return SelectMgr_SelectionManager_IsActivatedCB355689(Instance, anObject.Instance);
				}
			public bool IsActivated(SelectMgrSelectableObject anObject,int aMode)
				{
					return SelectMgr_SelectionManager_IsActivatedC6B3194D(Instance, anObject.Instance, aMode);
				}
			public bool IsActivated(SelectMgrSelectableObject anObject,SelectMgrViewerSelector aSelector,int aMode)
				{
					return SelectMgr_SelectionManager_IsActivated55B1618F(Instance, anObject.Instance, aSelector.Instance, aMode);
				}
			public void RecomputeSelection(SelectMgrSelectableObject anIObj,bool ForceUpdate,int aMode)
				{
					SelectMgr_SelectionManager_RecomputeSelectionF3DAC1BB(Instance, anIObj.Instance, ForceUpdate, aMode);
				}
			public void Update(SelectMgrSelectableObject anObject,bool ForceUpdate)
				{
					SelectMgr_SelectionManager_UpdateD97CA70B(Instance, anObject.Instance, ForceUpdate);
				}
			public void Update(SelectMgrSelectableObject anObject,SelectMgrViewerSelector aSelector,bool ForceUpdate)
				{
					SelectMgr_SelectionManager_Update40EFAF9D(Instance, anObject.Instance, aSelector.Instance, ForceUpdate);
				}
			public void SetUpdateMode(SelectMgrSelectableObject anObject,SelectMgrTypeOfUpdate aType)
				{
					SelectMgr_SelectionManager_SetUpdateModeC91DC767(Instance, anObject.Instance, (int)aType);
				}
			public void SetUpdateMode(SelectMgrSelectableObject anObject,int aSelMode,SelectMgrTypeOfUpdate aType)
				{
					SelectMgr_SelectionManager_SetUpdateMode25D61FEE(Instance, anObject.Instance, aSelMode, (int)aType);
				}
			public TCollectionAsciiString Status()
				{
					return new TCollectionAsciiString(SelectMgr_SelectionManager_Status(Instance));
				}
			public TCollectionAsciiString Status(SelectMgrSelectableObject anObject)
				{
					return new TCollectionAsciiString(SelectMgr_SelectionManager_StatusCB355689(Instance, anObject.Instance));
				}
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr SelectMgr_SelectionManager_Ctor();
		[DllImport("NaroOccCore.dll")]
		private static extern void SelectMgr_SelectionManager_Add14225620(IntPtr instance, IntPtr aSelector);
		[DllImport("NaroOccCore.dll")]
		private static extern void SelectMgr_SelectionManager_Remove14225620(IntPtr instance, IntPtr aSelector);
		[DllImport("NaroOccCore.dll")]
		private static extern bool SelectMgr_SelectionManager_Contains14225620(IntPtr instance, IntPtr aSelector);
		[DllImport("NaroOccCore.dll")]
		private static extern bool SelectMgr_SelectionManager_ContainsCB355689(IntPtr instance, IntPtr aSelectableObject);
		[DllImport("NaroOccCore.dll")]
		private static extern void SelectMgr_SelectionManager_LoadC6B3194D(IntPtr instance, IntPtr anObject,int aMode);
		[DllImport("NaroOccCore.dll")]
		private static extern void SelectMgr_SelectionManager_Load55B1618F(IntPtr instance, IntPtr anObject,IntPtr aSelector,int aMode);
		[DllImport("NaroOccCore.dll")]
		private static extern void SelectMgr_SelectionManager_RemoveCB355689(IntPtr instance, IntPtr anObject);
		[DllImport("NaroOccCore.dll")]
		private static extern void SelectMgr_SelectionManager_Remove6CD936C3(IntPtr instance, IntPtr anObject,IntPtr aSelector);
		[DllImport("NaroOccCore.dll")]
		private static extern void SelectMgr_SelectionManager_Activate6947D965(IntPtr instance, IntPtr anObject,int aMode,bool AutomaticProj);
		[DllImport("NaroOccCore.dll")]
		private static extern void SelectMgr_SelectionManager_Activate271DDBB2(IntPtr instance, IntPtr anObject,int aMode,IntPtr aSelector,bool AutomaticProj);
		[DllImport("NaroOccCore.dll")]
		private static extern void SelectMgr_SelectionManager_DeactivateCB355689(IntPtr instance, IntPtr anObject);
		[DllImport("NaroOccCore.dll")]
		private static extern void SelectMgr_SelectionManager_DeactivateC6B3194D(IntPtr instance, IntPtr anObject,int aMode);
		[DllImport("NaroOccCore.dll")]
		private static extern void SelectMgr_SelectionManager_Deactivate9FE1369E(IntPtr instance, IntPtr anObject,int aMode,IntPtr aSelector);
		[DllImport("NaroOccCore.dll")]
		private static extern void SelectMgr_SelectionManager_Deactivate6CD936C3(IntPtr instance, IntPtr anObject,IntPtr aSelector);
		[DllImport("NaroOccCore.dll")]
		private static extern void SelectMgr_SelectionManager_Sleep14225620(IntPtr instance, IntPtr aSelector);
		[DllImport("NaroOccCore.dll")]
		private static extern void SelectMgr_SelectionManager_SleepCB355689(IntPtr instance, IntPtr anObject);
		[DllImport("NaroOccCore.dll")]
		private static extern void SelectMgr_SelectionManager_Sleep6CD936C3(IntPtr instance, IntPtr anObject,IntPtr aSelector);
		[DllImport("NaroOccCore.dll")]
		private static extern void SelectMgr_SelectionManager_AwakeC739D92A(IntPtr instance, IntPtr aSelector,bool AutomaticProj);
		[DllImport("NaroOccCore.dll")]
		private static extern void SelectMgr_SelectionManager_AwakeD97CA70B(IntPtr instance, IntPtr anObject,bool AutomaticProj);
		[DllImport("NaroOccCore.dll")]
		private static extern void SelectMgr_SelectionManager_Awake40EFAF9D(IntPtr instance, IntPtr anObject,IntPtr aSelector,bool AutomaticProj);
		[DllImport("NaroOccCore.dll")]
		private static extern bool SelectMgr_SelectionManager_IsActivatedCB355689(IntPtr instance, IntPtr anObject);
		[DllImport("NaroOccCore.dll")]
		private static extern bool SelectMgr_SelectionManager_IsActivatedC6B3194D(IntPtr instance, IntPtr anObject,int aMode);
		[DllImport("NaroOccCore.dll")]
		private static extern bool SelectMgr_SelectionManager_IsActivated55B1618F(IntPtr instance, IntPtr anObject,IntPtr aSelector,int aMode);
		[DllImport("NaroOccCore.dll")]
		private static extern void SelectMgr_SelectionManager_RecomputeSelectionF3DAC1BB(IntPtr instance, IntPtr anIObj,bool ForceUpdate,int aMode);
		[DllImport("NaroOccCore.dll")]
		private static extern void SelectMgr_SelectionManager_UpdateD97CA70B(IntPtr instance, IntPtr anObject,bool ForceUpdate);
		[DllImport("NaroOccCore.dll")]
		private static extern void SelectMgr_SelectionManager_Update40EFAF9D(IntPtr instance, IntPtr anObject,IntPtr aSelector,bool ForceUpdate);
		[DllImport("NaroOccCore.dll")]
		private static extern void SelectMgr_SelectionManager_SetUpdateModeC91DC767(IntPtr instance, IntPtr anObject,int aType);
		[DllImport("NaroOccCore.dll")]
		private static extern void SelectMgr_SelectionManager_SetUpdateMode25D61FEE(IntPtr instance, IntPtr anObject,int aSelMode,int aType);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr SelectMgr_SelectionManager_Status(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr SelectMgr_SelectionManager_StatusCB355689(IntPtr instance, IntPtr anObject);

		#region NativeInstancePtr Convert constructor

		public SelectMgrSelectionManager(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ SelectMgrSelectionManager_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void SelectMgrSelectionManager_Dtor(IntPtr instance);
	}
}
