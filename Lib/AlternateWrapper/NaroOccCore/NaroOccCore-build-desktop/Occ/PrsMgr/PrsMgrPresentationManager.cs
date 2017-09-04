#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;
using NaroCppCore.Occ.MMgt;
using NaroCppCore.Occ.PrsMgr;

#endregion

namespace NaroCppCore.Occ.PrsMgr
{
	public class PrsMgrPresentationManager : MMgtTShared
	{
			public void Display(PrsMgrPresentableObject aPresentableObject,int aMode)
				{
					PrsMgr_PresentationManager_Display6305B33D(Instance, aPresentableObject.Instance, aMode);
				}
			public void Erase(PrsMgrPresentableObject aPresentableObject,int aMode)
				{
					PrsMgr_PresentationManager_Erase6305B33D(Instance, aPresentableObject.Instance, aMode);
				}
			public void Clear(PrsMgrPresentableObject aPresentableObject,int aMode)
				{
					PrsMgr_PresentationManager_Clear6305B33D(Instance, aPresentableObject.Instance, aMode);
				}
			public void Highlight(PrsMgrPresentableObject aPresentableObject,int aMode)
				{
					PrsMgr_PresentationManager_Highlight6305B33D(Instance, aPresentableObject.Instance, aMode);
				}
			public void Unhighlight(PrsMgrPresentableObject aPresentableObject,int aMode)
				{
					PrsMgr_PresentationManager_Unhighlight6305B33D(Instance, aPresentableObject.Instance, aMode);
				}
			public void SetDisplayPriority(PrsMgrPresentableObject aPresentableObject,int amode,int aNewPrior)
				{
					PrsMgr_PresentationManager_SetDisplayPriority46D23B97(Instance, aPresentableObject.Instance, amode, aNewPrior);
				}
			public int DisplayPriority(PrsMgrPresentableObject aPresentableObject,int amode)
				{
					return PrsMgr_PresentationManager_DisplayPriority6305B33D(Instance, aPresentableObject.Instance, amode);
				}
			public void SetZLayer(PrsMgrPresentableObject thePresentableObject,int theLayerId)
				{
					PrsMgr_PresentationManager_SetZLayer6305B33D(Instance, thePresentableObject.Instance, theLayerId);
				}
			public int GetZLayer(PrsMgrPresentableObject thePresentableObject)
				{
					return PrsMgr_PresentationManager_GetZLayerF2913F8C(Instance, thePresentableObject.Instance);
				}
			public bool IsDisplayed(PrsMgrPresentableObject aPresentableObject,int aMode)
				{
					return PrsMgr_PresentationManager_IsDisplayed6305B33D(Instance, aPresentableObject.Instance, aMode);
				}
			public bool IsHighlighted(PrsMgrPresentableObject aPresentableObject,int aMode)
				{
					return PrsMgr_PresentationManager_IsHighlighted6305B33D(Instance, aPresentableObject.Instance, aMode);
				}
			public void Update(PrsMgrPresentableObject aPresentableObject,int aMode)
				{
					PrsMgr_PresentationManager_Update6305B33D(Instance, aPresentableObject.Instance, aMode);
				}
			public void BeginDraw()
				{
					PrsMgr_PresentationManager_BeginDraw(Instance);
				}
			public void Add(PrsMgrPresentableObject aPresentableObject,int aMode)
				{
					PrsMgr_PresentationManager_Add6305B33D(Instance, aPresentableObject.Instance, aMode);
				}
			public void Remove(PrsMgrPresentableObject aPresentableObject,int aMode)
				{
					PrsMgr_PresentationManager_Remove6305B33D(Instance, aPresentableObject.Instance, aMode);
				}
			public bool HasPresentation(PrsMgrPresentableObject aPresentableObject,int aMode)
				{
					return PrsMgr_PresentationManager_HasPresentation6305B33D(Instance, aPresentableObject.Instance, aMode);
				}
			public PrsMgrPresentation Presentation(PrsMgrPresentableObject aPresentableObject,int aMode)
				{
					return new PrsMgrPresentation(PrsMgr_PresentationManager_Presentation6305B33D(Instance, aPresentableObject.Instance, aMode));
				}
		public bool IsImmediateModeOn{
			get {
				return PrsMgr_PresentationManager_IsImmediateModeOn(Instance);
			}
		}
		[DllImport("NaroOccCore.dll")]
		private static extern void PrsMgr_PresentationManager_Display6305B33D(IntPtr instance, IntPtr aPresentableObject,int aMode);
		[DllImport("NaroOccCore.dll")]
		private static extern void PrsMgr_PresentationManager_Erase6305B33D(IntPtr instance, IntPtr aPresentableObject,int aMode);
		[DllImport("NaroOccCore.dll")]
		private static extern void PrsMgr_PresentationManager_Clear6305B33D(IntPtr instance, IntPtr aPresentableObject,int aMode);
		[DllImport("NaroOccCore.dll")]
		private static extern void PrsMgr_PresentationManager_Highlight6305B33D(IntPtr instance, IntPtr aPresentableObject,int aMode);
		[DllImport("NaroOccCore.dll")]
		private static extern void PrsMgr_PresentationManager_Unhighlight6305B33D(IntPtr instance, IntPtr aPresentableObject,int aMode);
		[DllImport("NaroOccCore.dll")]
		private static extern void PrsMgr_PresentationManager_SetDisplayPriority46D23B97(IntPtr instance, IntPtr aPresentableObject,int amode,int aNewPrior);
		[DllImport("NaroOccCore.dll")]
		private static extern int PrsMgr_PresentationManager_DisplayPriority6305B33D(IntPtr instance, IntPtr aPresentableObject,int amode);
		[DllImport("NaroOccCore.dll")]
		private static extern void PrsMgr_PresentationManager_SetZLayer6305B33D(IntPtr instance, IntPtr thePresentableObject,int theLayerId);
		[DllImport("NaroOccCore.dll")]
		private static extern int PrsMgr_PresentationManager_GetZLayerF2913F8C(IntPtr instance, IntPtr thePresentableObject);
		[DllImport("NaroOccCore.dll")]
		private static extern bool PrsMgr_PresentationManager_IsDisplayed6305B33D(IntPtr instance, IntPtr aPresentableObject,int aMode);
		[DllImport("NaroOccCore.dll")]
		private static extern bool PrsMgr_PresentationManager_IsHighlighted6305B33D(IntPtr instance, IntPtr aPresentableObject,int aMode);
		[DllImport("NaroOccCore.dll")]
		private static extern void PrsMgr_PresentationManager_Update6305B33D(IntPtr instance, IntPtr aPresentableObject,int aMode);
		[DllImport("NaroOccCore.dll")]
		private static extern void PrsMgr_PresentationManager_BeginDraw(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void PrsMgr_PresentationManager_Add6305B33D(IntPtr instance, IntPtr aPresentableObject,int aMode);
		[DllImport("NaroOccCore.dll")]
		private static extern void PrsMgr_PresentationManager_Remove6305B33D(IntPtr instance, IntPtr aPresentableObject,int aMode);
		[DllImport("NaroOccCore.dll")]
		private static extern bool PrsMgr_PresentationManager_HasPresentation6305B33D(IntPtr instance, IntPtr aPresentableObject,int aMode);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr PrsMgr_PresentationManager_Presentation6305B33D(IntPtr instance, IntPtr aPresentableObject,int aMode);
		[DllImport("NaroOccCore.dll")]
		private static extern bool PrsMgr_PresentationManager_IsImmediateModeOn(IntPtr instance);

		#region NativeInstancePtr Convert constructor

		public PrsMgrPresentationManager() { } 

		public PrsMgrPresentationManager(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ PrsMgrPresentationManager_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void PrsMgrPresentationManager_Dtor(IntPtr instance);
	}
}
