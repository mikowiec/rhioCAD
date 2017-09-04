#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;
using NaroCppCore.Occ.MMgt;
using NaroCppCore.Occ.StdSelect;
using NaroCppCore.Occ.Quantity;
using NaroCppCore.Occ.Prs3d;
using NaroCppCore.Occ.AIS;
using NaroCppCore.Occ.TopoDS;
using NaroCppCore.Occ.SelectMgr;
using NaroCppCore.Occ.Standard;
using NaroCppCore.Occ.V3d;
using NaroCppCore.Occ.TCollection;
using NaroCppCore.Occ.PrsMgr;
using NaroCppCore.Occ.TopLoc;
using NaroCppCore.Occ.Aspect;
using NaroCppCore.Occ.Graphic3d;
using NaroCppCore.Occ.Geom;
using NaroCppCore.Occ.TopAbs;

#endregion

namespace NaroCppCore.Occ.AIS
{
	public class AISInteractiveContext : MMgtTShared
	{
		public AISInteractiveContext(V3dViewer MainViewer)
 :
			base(AIS_InteractiveContext_Ctor79560492(MainViewer.Instance) )
		{}
		public AISInteractiveContext(V3dViewer MainViewer,V3dViewer Collector)
 :
			base(AIS_InteractiveContext_Ctor27F4A3E3(MainViewer.Instance, Collector.Instance) )
		{}
			public void Delete()
				{
					AIS_InteractiveContext_Delete(Instance);
				}
			public void CloseCollector()
				{
					AIS_InteractiveContext_CloseCollector(Instance);
				}
			public void OpenCollector()
				{
					AIS_InteractiveContext_OpenCollector(Instance);
				}
			public void Display(AISInteractiveObject anIobj,bool updateviewer)
				{
					AIS_InteractiveContext_Display7BDA0103(Instance, anIobj.Instance, updateviewer);
				}
			public void Display(AISInteractiveObject anIobj,int amode,int aSelectionMode,bool updateviewer,bool allowdecomposition)
				{
					AIS_InteractiveContext_DisplayBB87E00C(Instance, anIobj.Instance, amode, aSelectionMode, updateviewer, allowdecomposition);
				}
			public void Load(AISInteractiveObject aniobj,int SelectionMode,bool AllowDecomp)
				{
					AIS_InteractiveContext_LoadFDB02EB(Instance, aniobj.Instance, SelectionMode, AllowDecomp);
				}
			public void Erase(AISInteractiveObject aniobj,bool updateviewer,bool PutInCollector)
				{
					AIS_InteractiveContext_EraseB05E0FC3(Instance, aniobj.Instance, updateviewer, PutInCollector);
				}
			public void EraseMode(AISInteractiveObject aniobj,int aMode,bool updateviewer)
				{
					AIS_InteractiveContext_EraseModeFDB02EB(Instance, aniobj.Instance, aMode, updateviewer);
				}
			public void EraseAll(bool PutInCollector,bool updateviewer)
				{
					AIS_InteractiveContext_EraseAllAE8C3818(Instance, PutInCollector, updateviewer);
				}
			public void DisplayAll(bool OnlyFromCollector,bool updateviewer)
				{
					AIS_InteractiveContext_DisplayAllAE8C3818(Instance, OnlyFromCollector, updateviewer);
				}
			public void DisplayFromCollector(AISInteractiveObject anIObj,bool updateviewer)
				{
					AIS_InteractiveContext_DisplayFromCollector7BDA0103(Instance, anIObj.Instance, updateviewer);
				}
			public void EraseSelected(bool PutInCollector,bool updateviewer)
				{
					AIS_InteractiveContext_EraseSelectedAE8C3818(Instance, PutInCollector, updateviewer);
				}
			public void DisplaySelected(bool updateviewer)
				{
					AIS_InteractiveContext_DisplaySelected461FC46A(Instance, updateviewer);
				}
			public bool KeepTemporary(AISInteractiveObject anIObj,int InWhichLocal)
				{
					return AIS_InteractiveContext_KeepTemporary4F47E777(Instance, anIObj.Instance, InWhichLocal);
				}
			public void Clear(AISInteractiveObject aniobj,bool updateviewer)
				{
					AIS_InteractiveContext_Clear7BDA0103(Instance, aniobj.Instance, updateviewer);
				}
			public void ClearPrs(AISInteractiveObject aniobj,int aMode,bool updateviewer)
				{
					AIS_InteractiveContext_ClearPrsFDB02EB(Instance, aniobj.Instance, aMode, updateviewer);
				}
			public void Remove(AISInteractiveObject aniobj,bool updateviewer)
				{
					AIS_InteractiveContext_Remove7BDA0103(Instance, aniobj.Instance, updateviewer);
				}
			public void RemoveAll(bool updateviewer)
				{
					AIS_InteractiveContext_RemoveAll461FC46A(Instance, updateviewer);
				}
			public void Hilight(AISInteractiveObject aniobj,bool updateviewer)
				{
					AIS_InteractiveContext_Hilight7BDA0103(Instance, aniobj.Instance, updateviewer);
				}
			public void HilightWithColor(AISInteractiveObject aniobj,QuantityNameOfColor aCol,bool updateviewer)
				{
					AIS_InteractiveContext_HilightWithColor80F07260(Instance, aniobj.Instance, (int)aCol, updateviewer);
				}
			public void Unhilight(AISInteractiveObject aniobj,bool updateviewer)
				{
					AIS_InteractiveContext_Unhilight7BDA0103(Instance, aniobj.Instance, updateviewer);
				}
			public void SetDisplayPriority(AISInteractiveObject anIobj,int aPriority)
				{
					AIS_InteractiveContext_SetDisplayPriority4F47E777(Instance, anIobj.Instance, aPriority);
				}
			public void SetZLayer(AISInteractiveObject theIObj,int theLayerId)
				{
					AIS_InteractiveContext_SetZLayer4F47E777(Instance, theIObj.Instance, theLayerId);
				}
			public int GetZLayer(AISInteractiveObject theIObj)
				{
					return AIS_InteractiveContext_GetZLayer5DD8A2CA(Instance, theIObj.Instance);
				}
			public void Redisplay(AISInteractiveObject aniobj,bool updateviewer,bool allmodes)
				{
					AIS_InteractiveContext_RedisplayB05E0FC3(Instance, aniobj.Instance, updateviewer, allmodes);
				}
			public void Redisplay(AISKindOfInteractive aTypeOfObject,int Signature,bool updateviewer)
				{
					AIS_InteractiveContext_Redisplay766D350B(Instance, (int)aTypeOfObject, Signature, updateviewer);
				}
			public void RecomputePrsOnly(AISInteractiveObject anIobj,bool updateviewer,bool allmodes)
				{
					AIS_InteractiveContext_RecomputePrsOnlyB05E0FC3(Instance, anIobj.Instance, updateviewer, allmodes);
				}
			public void RecomputeSelectionOnly(AISInteractiveObject anIObj)
				{
					AIS_InteractiveContext_RecomputeSelectionOnly5DD8A2CA(Instance, anIObj.Instance);
				}
			public void Update(AISInteractiveObject anIobj,bool updateviewer)
				{
					AIS_InteractiveContext_Update7BDA0103(Instance, anIobj.Instance, updateviewer);
				}
			public void SetDisplayMode(AISInteractiveObject aniobj,int aMode,bool updateviewer)
				{
					AIS_InteractiveContext_SetDisplayModeFDB02EB(Instance, aniobj.Instance, aMode, updateviewer);
				}
			public void UnsetDisplayMode(AISInteractiveObject aniobj,bool updateviewer)
				{
					AIS_InteractiveContext_UnsetDisplayMode7BDA0103(Instance, aniobj.Instance, updateviewer);
				}
			public void SetSelectionMode(AISInteractiveObject aniobj,int aMode)
				{
					AIS_InteractiveContext_SetSelectionMode4F47E777(Instance, aniobj.Instance, aMode);
				}
			public void UnsetSelectionMode(AISInteractiveObject aniobj)
				{
					AIS_InteractiveContext_UnsetSelectionMode5DD8A2CA(Instance, aniobj.Instance);
				}
			public void SetLocation(AISInteractiveObject aniobj,TopLocLocation aLocation)
				{
					AIS_InteractiveContext_SetLocation852B9922(Instance, aniobj.Instance, aLocation.Instance);
				}
			public void ResetLocation(AISInteractiveObject aniobj)
				{
					AIS_InteractiveContext_ResetLocation5DD8A2CA(Instance, aniobj.Instance);
				}
			public bool HasLocation(AISInteractiveObject aniobj)
				{
					return AIS_InteractiveContext_HasLocation5DD8A2CA(Instance, aniobj.Instance);
				}
			public TopLocLocation Location(AISInteractiveObject aniobj)
				{
					return new TopLocLocation(AIS_InteractiveContext_Location5DD8A2CA(Instance, aniobj.Instance));
				}
			public void SetCurrentFacingModel(AISInteractiveObject aniobj,AspectTypeOfFacingModel aModel)
				{
					AIS_InteractiveContext_SetCurrentFacingModelCD8717A5(Instance, aniobj.Instance, (int)aModel);
				}
			public void SetColor(AISInteractiveObject aniobj,QuantityNameOfColor aColor,bool updateviewer)
				{
					AIS_InteractiveContext_SetColor80F07260(Instance, aniobj.Instance, (int)aColor, updateviewer);
				}
			public void SetColor(AISInteractiveObject aniobj,QuantityColor aColor,bool updateviewer)
				{
					AIS_InteractiveContext_SetColorCCA19205(Instance, aniobj.Instance, aColor.Instance, updateviewer);
				}
			public void UnsetColor(AISInteractiveObject aniobj,bool updateviewer)
				{
					AIS_InteractiveContext_UnsetColor7BDA0103(Instance, aniobj.Instance, updateviewer);
				}
			public void SetWidth(AISInteractiveObject aniobj,double aValue,bool updateviewer)
				{
					AIS_InteractiveContext_SetWidthADEC6198(Instance, aniobj.Instance, aValue, updateviewer);
				}
			public void UnsetWidth(AISInteractiveObject aniobj,bool updateviewer)
				{
					AIS_InteractiveContext_UnsetWidth7BDA0103(Instance, aniobj.Instance, updateviewer);
				}
			public void SetMaterial(AISInteractiveObject aniobj,Graphic3dNameOfMaterial aName,bool updateviewer)
				{
					AIS_InteractiveContext_SetMaterial4D782AAE(Instance, aniobj.Instance, (int)aName, updateviewer);
				}
			public void UnsetMaterial(AISInteractiveObject anObj,bool updateviewer)
				{
					AIS_InteractiveContext_UnsetMaterial7BDA0103(Instance, anObj.Instance, updateviewer);
				}
			public void SetTransparency(AISInteractiveObject aniobj,double aValue,bool updateviewer)
				{
					AIS_InteractiveContext_SetTransparencyADEC6198(Instance, aniobj.Instance, aValue, updateviewer);
				}
			public void UnsetTransparency(AISInteractiveObject aniobj,bool updateviewer)
				{
					AIS_InteractiveContext_UnsetTransparency7BDA0103(Instance, aniobj.Instance, updateviewer);
				}
			public void SetDegenerateModel(AISInteractiveObject aniobj,AspectTypeOfDegenerateModel aModel,double aRatio)
				{
					AIS_InteractiveContext_SetDegenerateModel157E506C(Instance, aniobj.Instance, (int)aModel, aRatio);
				}
			public void SetDegenerateModel(AspectTypeOfDegenerateModel aModel,double aSkipRatio)
				{
					AIS_InteractiveContext_SetDegenerateModelE6DFDFE0(Instance, (int)aModel, aSkipRatio);
				}
			public void SetLocalAttributes(AISInteractiveObject aniobj,AISDrawer aDrawer,bool updateviewer)
				{
					AIS_InteractiveContext_SetLocalAttributes6233D91F(Instance, aniobj.Instance, aDrawer.Instance, updateviewer);
				}
			public void UnsetLocalAttributes(AISInteractiveObject anObj,bool updateviewer)
				{
					AIS_InteractiveContext_UnsetLocalAttributes7BDA0103(Instance, anObj.Instance, updateviewer);
				}
			public void SetPolygonOffsets(AISInteractiveObject anObj,int aMode,double aFactor,double aUnits,bool updateviewer)
				{
					AIS_InteractiveContext_SetPolygonOffsets6907E6A5(Instance, anObj.Instance, aMode, aFactor, aUnits, updateviewer);
				}
			public bool HasPolygonOffsets(AISInteractiveObject anObj)
				{
					return AIS_InteractiveContext_HasPolygonOffsets5DD8A2CA(Instance, anObj.Instance);
				}
            //public void PolygonOffsets(AISInteractiveObject anObj,ref int aMode,ref double aFactor,ref double aUnits)
            //    {
            //        AIS_InteractiveContext_PolygonOffsets330EF62(Instance, anObj.Instance, ref aMode, ref aFactor, ref aUnits);
            //    }
			public void SetTrihedronSize(double aSize,bool updateviewer)
				{
					AIS_InteractiveContext_SetTrihedronSizeC85E5E0F(Instance, aSize, updateviewer);
				}
			public double TrihedronSize()
				{
					return AIS_InteractiveContext_TrihedronSize(Instance);
				}
			public bool PlaneSize(ref double XSize,ref double YSize)
				{
					return AIS_InteractiveContext_PlaneSize9F0E714F(Instance, ref XSize, ref YSize);
				}
			public AISDisplayStatus DisplayStatus(AISInteractiveObject anIobj)
				{
					return (AISDisplayStatus)AIS_InteractiveContext_DisplayStatus5DD8A2CA(Instance, anIobj.Instance);
				}
			public bool IsDisplayed(AISInteractiveObject anIobj)
				{
					return AIS_InteractiveContext_IsDisplayed5DD8A2CA(Instance, anIobj.Instance);
				}
			public bool IsDisplayed(AISInteractiveObject aniobj,int aMode)
				{
					return AIS_InteractiveContext_IsDisplayed4F47E777(Instance, aniobj.Instance, aMode);
				}
			public bool IsInCollector(AISInteractiveObject anIObj)
				{
					return AIS_InteractiveContext_IsInCollector5DD8A2CA(Instance, anIObj.Instance);
				}
			public int DisplayPriority(AISInteractiveObject anIobj)
				{
					return AIS_InteractiveContext_DisplayPriority5DD8A2CA(Instance, anIobj.Instance);
				}
			public bool HasColor(AISInteractiveObject aniobj)
				{
					return AIS_InteractiveContext_HasColor5DD8A2CA(Instance, aniobj.Instance);
				}
			public QuantityNameOfColor Color(AISInteractiveObject aniobj)
				{
					return (QuantityNameOfColor)AIS_InteractiveContext_Color5DD8A2CA(Instance, aniobj.Instance);
				}
			public void Color(AISInteractiveObject aniobj,QuantityColor acolor)
				{
					AIS_InteractiveContext_ColorE6084039(Instance, aniobj.Instance, acolor.Instance);
				}
			public double Width(AISInteractiveObject aniobj)
				{
					return AIS_InteractiveContext_Width5DD8A2CA(Instance, aniobj.Instance);
				}
			public void Status(AISInteractiveObject anObj,TCollectionExtendedString astatus)
				{
					AIS_InteractiveContext_StatusE16287D5(Instance, anObj.Instance, astatus.Instance);
				}
			public void UpdateCurrentViewer()
				{
					AIS_InteractiveContext_UpdateCurrentViewer(Instance);
				}
			public void UpdateCollector()
				{
					AIS_InteractiveContext_UpdateCollector(Instance);
				}
			public int DisplayMode()
				{
					return AIS_InteractiveContext_DisplayMode(Instance);
				}
			public QuantityNameOfColor SelectionColor()
				{
					return (QuantityNameOfColor)AIS_InteractiveContext_SelectionColor(Instance);
				}
			public void SelectionColor(QuantityNameOfColor aCol)
				{
					AIS_InteractiveContext_SelectionColor48F4F471(Instance, (int)aCol);
				}
			public void SetDisplayMode(AISDisplayMode AMode,bool updateviewer)
				{
					AIS_InteractiveContext_SetDisplayMode989C8794(Instance, (int)AMode, updateviewer);
				}
			public void SetDeviationCoefficient(AISInteractiveObject aniobj,double aCoefficient,bool updateviewer)
				{
					AIS_InteractiveContext_SetDeviationCoefficientADEC6198(Instance, aniobj.Instance, aCoefficient, updateviewer);
				}
			public void SetDeviationAngle(AISInteractiveObject aniobj,double anAngle,bool updateviewer)
				{
					AIS_InteractiveContext_SetDeviationAngleADEC6198(Instance, aniobj.Instance, anAngle, updateviewer);
				}
			public void SetAngleAndDeviation(AISInteractiveObject aniobj,double anAngle,bool updateviewer)
				{
					AIS_InteractiveContext_SetAngleAndDeviationADEC6198(Instance, aniobj.Instance, anAngle, updateviewer);
				}
			public void SetHLRDeviationCoefficient(AISInteractiveObject aniobj,double aCoefficient,bool updateviewer)
				{
					AIS_InteractiveContext_SetHLRDeviationCoefficientADEC6198(Instance, aniobj.Instance, aCoefficient, updateviewer);
				}
			public void SetHLRDeviationAngle(AISInteractiveObject aniobj,double anAngle,bool updateviewer)
				{
					AIS_InteractiveContext_SetHLRDeviationAngleADEC6198(Instance, aniobj.Instance, anAngle, updateviewer);
				}
			public void SetHLRAngleAndDeviation(AISInteractiveObject aniobj,double anAngle,bool updateviewer)
				{
					AIS_InteractiveContext_SetHLRAngleAndDeviationADEC6198(Instance, aniobj.Instance, anAngle, updateviewer);
				}
			public void SetDeviationCoefficient(double aCoefficient)
				{
					AIS_InteractiveContext_SetDeviationCoefficientD82819F3(Instance, aCoefficient);
				}
			public double DeviationCoefficient()
				{
					return AIS_InteractiveContext_DeviationCoefficient(Instance);
				}
			public void SetDeviationAngle(double anAngle)
				{
					AIS_InteractiveContext_SetDeviationAngleD82819F3(Instance, anAngle);
				}
			public double DeviationAngle()
				{
					return AIS_InteractiveContext_DeviationAngle(Instance);
				}
			public void SetHLRDeviationCoefficient(double aCoefficient)
				{
					AIS_InteractiveContext_SetHLRDeviationCoefficientD82819F3(Instance, aCoefficient);
				}
			public double HLRDeviationCoefficient()
				{
					return AIS_InteractiveContext_HLRDeviationCoefficient(Instance);
				}
			public void SetHLRAngleAndDeviation(double anAngle)
				{
					AIS_InteractiveContext_SetHLRAngleAndDeviationD82819F3(Instance, anAngle);
				}
			public void EnableDrawHiddenLine()
				{
					AIS_InteractiveContext_EnableDrawHiddenLine(Instance);
				}
			public void DisableDrawHiddenLine()
				{
					AIS_InteractiveContext_DisableDrawHiddenLine(Instance);
				}
			public void SetIsoNumber(int NbIsos,AISTypeOfIso WhichIsos)
				{
					AIS_InteractiveContext_SetIsoNumber818B71C9(Instance, NbIsos, (int)WhichIsos);
				}
			public int IsoNumber(AISTypeOfIso WhichIsos)
				{
					return AIS_InteractiveContext_IsoNumber4113B908(Instance, (int)WhichIsos);
				}
			public void IsoOnPlane(bool SwitchOn)
				{
					AIS_InteractiveContext_IsoOnPlane461FC46A(Instance, SwitchOn);
				}
			public bool IsoOnPlane()
				{
					return AIS_InteractiveContext_IsoOnPlane(Instance);
				}
			public void SetSelectedAspect(Prs3dBasicAspect anAspect,bool globalChange,bool updateViewer)
				{
					AIS_InteractiveContext_SetSelectedAspectBD651AAF(Instance, anAspect.Instance, globalChange, updateViewer);
				}
			public AISStatusOfDetection MoveTo(int XPix,int YPix,V3dView aView)
				{
					return (AISStatusOfDetection)AIS_InteractiveContext_MoveTo556D776C(Instance, XPix, YPix, aView.Instance);
				}
			public int HilightNextDetected(V3dView aView)
				{
					return AIS_InteractiveContext_HilightNextDetected36A6FAB7(Instance, aView.Instance);
				}
			public int HilightPreviousDetected(V3dView aView)
				{
					return AIS_InteractiveContext_HilightPreviousDetected36A6FAB7(Instance, aView.Instance);
				}
			public AISStatusOfPick Select(int XPMin,int YPMin,int XPMax,int YPMax,V3dView aView,bool updateviewer)
				{
					return (AISStatusOfPick)AIS_InteractiveContext_Select92079733(Instance, XPMin, YPMin, XPMax, YPMax, aView.Instance, updateviewer);
				}
			public AISStatusOfPick Select(bool updateviewer)
				{
					return (AISStatusOfPick)AIS_InteractiveContext_Select461FC46A(Instance, updateviewer);
				}
			public AISStatusOfPick ShiftSelect(bool updateviewer)
				{
					return (AISStatusOfPick)AIS_InteractiveContext_ShiftSelect461FC46A(Instance, updateviewer);
				}
			public AISStatusOfPick ShiftSelect(int XPMin,int YPMin,int XPMax,int YPMax,V3dView aView,bool updateviewer)
				{
					return (AISStatusOfPick)AIS_InteractiveContext_ShiftSelect92079733(Instance, XPMin, YPMin, XPMax, YPMax, aView.Instance, updateviewer);
				}
			public void SetCurrentObject(AISInteractiveObject aniobj,bool updateviewer)
				{
					AIS_InteractiveContext_SetCurrentObject7BDA0103(Instance, aniobj.Instance, updateviewer);
				}
			public void AddOrRemoveCurrentObject(AISInteractiveObject aniobj,bool updateviewer)
				{
					AIS_InteractiveContext_AddOrRemoveCurrentObject7BDA0103(Instance, aniobj.Instance, updateviewer);
				}
			public void UpdateCurrent()
				{
					AIS_InteractiveContext_UpdateCurrent(Instance);
				}
			public void SetOkCurrent()
				{
					AIS_InteractiveContext_SetOkCurrent(Instance);
				}
			public bool IsCurrent(AISInteractiveObject aniobj)
				{
					return AIS_InteractiveContext_IsCurrent5DD8A2CA(Instance, aniobj.Instance);
				}
			public void InitCurrent()
				{
					AIS_InteractiveContext_InitCurrent(Instance);
				}
			public void NextCurrent()
				{
					AIS_InteractiveContext_NextCurrent(Instance);
				}
			public void HilightCurrents(bool updateviewer)
				{
					AIS_InteractiveContext_HilightCurrents461FC46A(Instance, updateviewer);
				}
			public void UnhilightCurrents(bool updateviewer)
				{
					AIS_InteractiveContext_UnhilightCurrents461FC46A(Instance, updateviewer);
				}
			public void ClearCurrents(bool updateviewer)
				{
					AIS_InteractiveContext_ClearCurrents461FC46A(Instance, updateviewer);
				}
			public void SetSelected(AISInteractiveObject aniObj,bool updateviewer)
				{
					AIS_InteractiveContext_SetSelected7BDA0103(Instance, aniObj.Instance, updateviewer);
				}
			public void SetSelectedCurrent()
				{
					AIS_InteractiveContext_SetSelectedCurrent(Instance);
				}
			public void UpdateSelected(bool updateviewer)
				{
					AIS_InteractiveContext_UpdateSelected461FC46A(Instance, updateviewer);
				}
			public void AddOrRemoveSelected(AISInteractiveObject aniobj,bool updateviewer)
				{
					AIS_InteractiveContext_AddOrRemoveSelected7BDA0103(Instance, aniobj.Instance, updateviewer);
				}
			public void HilightSelected(bool updateviewer)
				{
					AIS_InteractiveContext_HilightSelected461FC46A(Instance, updateviewer);
				}
			public void UnhilightSelected(bool updateviewer)
				{
					AIS_InteractiveContext_UnhilightSelected461FC46A(Instance, updateviewer);
				}
			public void ClearSelected(bool updateviewer)
				{
					AIS_InteractiveContext_ClearSelected461FC46A(Instance, updateviewer);
				}
			public void AddOrRemoveSelected(TopoDSShape aShape,bool updateviewer)
				{
					AIS_InteractiveContext_AddOrRemoveSelected5E7DD5C8(Instance, aShape.Instance, updateviewer);
				}
			public void AddOrRemoveSelected(SelectMgrEntityOwner anOwner,bool updateviewer)
				{
					AIS_InteractiveContext_AddOrRemoveSelected26C4ECD2(Instance, anOwner.Instance, updateviewer);
				}
			public bool IsSelected(AISInteractiveObject aniobj)
				{
					return AIS_InteractiveContext_IsSelected5DD8A2CA(Instance, aniobj.Instance);
				}
			public void InitSelected()
				{
					AIS_InteractiveContext_InitSelected(Instance);
				}
			public void NextSelected()
				{
					AIS_InteractiveContext_NextSelected(Instance);
				}
			public void InitDetected()
				{
					AIS_InteractiveContext_InitDetected(Instance);
				}
			public void NextDetected()
				{
					AIS_InteractiveContext_NextDetected(Instance);
				}
			public int OpenLocalContext(bool UseDisplayedObjects,bool AllowShapeDecomposition,bool AcceptEraseOfObjects,bool BothViewers)
				{
					return AIS_InteractiveContext_OpenLocalContextA58FCEEB(Instance, UseDisplayedObjects, AllowShapeDecomposition, AcceptEraseOfObjects, BothViewers);
				}
			public void CloseLocalContext(int Index,bool updateviewer)
				{
					AIS_InteractiveContext_CloseLocalContext898DAFFC(Instance, Index, updateviewer);
				}
			public void CloseAllContexts(bool updateviewer)
				{
					AIS_InteractiveContext_CloseAllContexts461FC46A(Instance, updateviewer);
				}
			public void ResetOriginalState(bool updateviewer)
				{
					AIS_InteractiveContext_ResetOriginalState461FC46A(Instance, updateviewer);
				}
			public void ClearLocalContext(AISClearMode TheMode)
				{
					AIS_InteractiveContext_ClearLocalContext4E21E443(Instance, (int)TheMode);
				}
			public void UseDisplayedObjects()
				{
					AIS_InteractiveContext_UseDisplayedObjects(Instance);
				}
			public void NotUseDisplayedObjects()
				{
					AIS_InteractiveContext_NotUseDisplayedObjects(Instance);
				}
			public bool ImmediateAdd(AISInteractiveObject anIObj,int aMode)
				{
					return AIS_InteractiveContext_ImmediateAdd4F47E777(Instance, anIObj.Instance, aMode);
				}
			public bool ImmediateRemove(AISInteractiveObject anIObj,int aMode)
				{
					return AIS_InteractiveContext_ImmediateRemove4F47E777(Instance, anIObj.Instance, aMode);
				}
			public bool EndImmediateDraw(V3dView aView,bool DoubleBuf)
				{
					return AIS_InteractiveContext_EndImmediateDraw3F19241F(Instance, aView.Instance, DoubleBuf);
				}
			public bool EndImmediateDraw(bool DoubleBuf)
				{
					return AIS_InteractiveContext_EndImmediateDraw461FC46A(Instance, DoubleBuf);
				}
			public void Drag(V3dView aView,AISInteractiveObject anObject,GeomTransformation aTranformation,bool postConcatenate,bool update,bool zBuffer)
				{
					AIS_InteractiveContext_Drag5E8F49C8(Instance, aView.Instance, anObject.Instance, aTranformation.Instance, postConcatenate, update, zBuffer);
				}
			public void Activate(AISInteractiveObject anIobj,int aMode)
				{
					AIS_InteractiveContext_Activate4F47E777(Instance, anIobj.Instance, aMode);
				}
			public void Deactivate(AISInteractiveObject anIObj)
				{
					AIS_InteractiveContext_Deactivate5DD8A2CA(Instance, anIObj.Instance);
				}
			public void Deactivate(AISInteractiveObject anIobj,int aMode)
				{
					AIS_InteractiveContext_Deactivate4F47E777(Instance, anIobj.Instance, aMode);
				}
			public void SetShapeDecomposition(AISInteractiveObject anIobj,bool aStatus)
				{
					AIS_InteractiveContext_SetShapeDecomposition7BDA0103(Instance, anIobj.Instance, aStatus);
				}
			public void SetTemporaryAttributes(AISInteractiveObject anObj,Prs3dDrawer aDrawer,bool updateviewer)
				{
					AIS_InteractiveContext_SetTemporaryAttributesA5FB0AF4(Instance, anObj.Instance, aDrawer.Instance, updateviewer);
				}
			public void SubIntensityOn(AISInteractiveObject aniobj,bool updateviewer)
				{
					AIS_InteractiveContext_SubIntensityOn7BDA0103(Instance, aniobj.Instance, updateviewer);
				}
			public void SubIntensityOff(AISInteractiveObject aniobj,bool updateviewer)
				{
					AIS_InteractiveContext_SubIntensityOff7BDA0103(Instance, aniobj.Instance, updateviewer);
				}
			public void SubIntensityOn(bool updateviewer)
				{
					AIS_InteractiveContext_SubIntensityOn461FC46A(Instance, updateviewer);
				}
			public void SubIntensityOff(bool updateviewer)
				{
					AIS_InteractiveContext_SubIntensityOff461FC46A(Instance, updateviewer);
				}
			public void AddFilter(SelectMgrFilter aFilter)
				{
					AIS_InteractiveContext_AddFilter3C9475B7(Instance, aFilter.Instance);
				}
			public void RemoveFilter(SelectMgrFilter aFilter)
				{
					AIS_InteractiveContext_RemoveFilter3C9475B7(Instance, aFilter.Instance);
				}
			public void RemoveFilters()
				{
					AIS_InteractiveContext_RemoveFilters(Instance);
				}
			public void ActivateStandardMode(TopAbsShapeEnum aStandardActivation)
				{
					AIS_InteractiveContext_ActivateStandardModeC6FD32C4(Instance, (int)aStandardActivation);
				}
			public void DeactivateStandardMode(TopAbsShapeEnum aStandardActivation)
				{
					AIS_InteractiveContext_DeactivateStandardModeC6FD32C4(Instance, (int)aStandardActivation);
				}
			public void DisplayedObjects(AISListOfInteractive aListOfIO,bool OnlyFromNeutral)
				{
					AIS_InteractiveContext_DisplayedObjectsFB1E3476(Instance, aListOfIO.Instance, OnlyFromNeutral);
				}
			public void DisplayedObjects(AISKindOfInteractive WhichKind,int WhichSignature,AISListOfInteractive aListOfIO,bool OnlyFromNeutral)
				{
					AIS_InteractiveContext_DisplayedObjects552A363C(Instance, (int)WhichKind, WhichSignature, aListOfIO.Instance, OnlyFromNeutral);
				}
			public void ObjectsInCollector(AISListOfInteractive aListOfIO)
				{
					AIS_InteractiveContext_ObjectsInCollector235DE22E(Instance, aListOfIO.Instance);
				}
			public void ObjectsInCollector(AISKindOfInteractive WhichKind,int WhichSignature,AISListOfInteractive aListOfIO)
				{
					AIS_InteractiveContext_ObjectsInCollectorFB8692A(Instance, (int)WhichKind, WhichSignature, aListOfIO.Instance);
				}
			public void ErasedObjects(AISListOfInteractive theListOfIO)
				{
					AIS_InteractiveContext_ErasedObjects235DE22E(Instance, theListOfIO.Instance);
				}
			public void ErasedObjects(AISKindOfInteractive WhichKind,int WhichSignature,AISListOfInteractive theListOfIO)
				{
					AIS_InteractiveContext_ErasedObjectsFB8692A(Instance, (int)WhichKind, WhichSignature, theListOfIO.Instance);
				}
			public void ObjectsByDisplayStatus(AISDisplayStatus theStatus,AISListOfInteractive theListOfIO)
				{
					AIS_InteractiveContext_ObjectsByDisplayStatusF86BDF5C(Instance, (int)theStatus, theListOfIO.Instance);
				}
			public void ObjectsByDisplayStatus(AISKindOfInteractive WhichKind,int WhichSignature,AISDisplayStatus theStatus,AISListOfInteractive theListOfIO)
				{
					AIS_InteractiveContext_ObjectsByDisplayStatusB048A7AD(Instance, (int)WhichKind, WhichSignature, (int)theStatus, theListOfIO.Instance);
				}
			public void ObjectsInside(AISListOfInteractive aListOfIO,AISKindOfInteractive WhichKind,int WhichSignature)
				{
					AIS_InteractiveContext_ObjectsInsideC8729CEC(Instance, aListOfIO.Instance, (int)WhichKind, WhichSignature);
				}
			public int PurgeDisplay(bool CollectorToo)
				{
					return AIS_InteractiveContext_PurgeDisplay461FC46A(Instance, CollectorToo);
				}
			public void DisplayActiveAreas(V3dView aView)
				{
					AIS_InteractiveContext_DisplayActiveAreas36A6FAB7(Instance, aView.Instance);
				}
			public void ClearActiveAreas(V3dView aView)
				{
					AIS_InteractiveContext_ClearActiveAreas36A6FAB7(Instance, aView.Instance);
				}
			public void DisplayActiveSensitive(V3dView aView)
				{
					AIS_InteractiveContext_DisplayActiveSensitive36A6FAB7(Instance, aView.Instance);
				}
			public void ClearActiveSensitive(V3dView aView)
				{
					AIS_InteractiveContext_ClearActiveSensitive36A6FAB7(Instance, aView.Instance);
				}
			public void DisplayActiveSensitive(AISInteractiveObject anObject,V3dView aView)
				{
					AIS_InteractiveContext_DisplayActiveSensitiveC47ED7A2(Instance, anObject.Instance, aView.Instance);
				}
			public void DisplayActiveAreas(AISInteractiveObject anObject,V3dView aView)
				{
					AIS_InteractiveContext_DisplayActiveAreasC47ED7A2(Instance, anObject.Instance, aView.Instance);
				}
			public bool IsInLocal(AISInteractiveObject anObject,ref int TheIndex)
				{
					return AIS_InteractiveContext_IsInLocal4F47E777(Instance, anObject.Instance, ref TheIndex);
				}
		public bool IsCollectorClosed{
			get {
				return AIS_InteractiveContext_IsCollectorClosed(Instance);
			}
		}
		public bool AutoActivateSelection{
			set { 
				AIS_InteractiveContext_SetAutoActivateSelection(Instance, value);
			}
		}
		public bool GetAutoActivateSelection{
			get {
				return AIS_InteractiveContext_GetAutoActivateSelection(Instance);
			}
		}
		public StdSelectSensitivityMode SensitivityMode{
			set { 
				AIS_InteractiveContext_SetSensitivityMode(Instance, (int)value);
			}
			get {
				return (StdSelectSensitivityMode)AIS_InteractiveContext_SensitivityMode(Instance);
			}
		}
		public double Sensitivity{
			set { 
				AIS_InteractiveContext_SetSensitivity(Instance, value);
			}
			get {
				return AIS_InteractiveContext_Sensitivity(Instance);
			}
		}
		public int PixelTolerance{
			set { 
				AIS_InteractiveContext_SetPixelTolerance(Instance, value);
			}
			get {
				return AIS_InteractiveContext_PixelTolerance(Instance);
			}
		}
		public QuantityNameOfColor PreSelectionColor{
			get {
				return (QuantityNameOfColor)AIS_InteractiveContext_PreSelectionColor(Instance);
			}
		}
		public QuantityNameOfColor DefaultColor{
			get {
				return (QuantityNameOfColor)AIS_InteractiveContext_DefaultColor(Instance);
			}
		}
		public QuantityNameOfColor HilightColor{
			set { 
				AIS_InteractiveContext_SetHilightColor(Instance, (int)value);
			}
			get {
				return (QuantityNameOfColor)AIS_InteractiveContext_HilightColor(Instance);
			}
		}
		public QuantityNameOfColor PreselectionColor{
			set { 
				AIS_InteractiveContext_SetPreselectionColor(Instance, (int)value);
			}
		}
		public QuantityNameOfColor SubIntensityColor{
			set { 
				AIS_InteractiveContext_SetSubIntensityColor(Instance, (int)value);
			}
			get {
				return (QuantityNameOfColor)AIS_InteractiveContext_SubIntensityColor(Instance);
			}
		}
		public double HLRAngle{
			set { 
				AIS_InteractiveContext_SetHLRAngle(Instance, value);
			}
			get {
				return AIS_InteractiveContext_HLRAngle(Instance);
			}
		}
		public Prs3dLineAspect HiddenLineAspect{
			set { 
				AIS_InteractiveContext_SetHiddenLineAspect(Instance, value.Instance);
			}
			get {
				return new Prs3dLineAspect(AIS_InteractiveContext_HiddenLineAspect(Instance));
			}
		}
		public bool DrawHiddenLine{
			get {
				return AIS_InteractiveContext_DrawHiddenLine(Instance);
			}
		}
		public bool HasNextDetected{
			get {
				return AIS_InteractiveContext_HasNextDetected(Instance);
			}
		}
		public bool ToHilightSelected{
			set { 
				AIS_InteractiveContext_SetToHilightSelected(Instance, value);
			}
			get {
				return AIS_InteractiveContext_ToHilightSelected(Instance);
			}
		}
		public bool WasCurrentTouched{
			get {
				return AIS_InteractiveContext_WasCurrentTouched(Instance);
			}
		}
		public bool MoreCurrent{
			get {
				return AIS_InteractiveContext_MoreCurrent(Instance);
			}
		}
		public AISInteractiveObject Current{
			get {
				return new AISInteractiveObject(AIS_InteractiveContext_Current(Instance));
			}
		}
		public int NbCurrents{
			get {
				return AIS_InteractiveContext_NbCurrents(Instance);
			}
		}
		public AISInteractiveObject FirstCurrentObject{
			get {
				return new AISInteractiveObject(AIS_InteractiveContext_FirstCurrentObject(Instance));
			}
		}
		public bool MoreSelected{
			get {
				return AIS_InteractiveContext_MoreSelected(Instance);
			}
		}
		public int NbSelected{
			get {
				return AIS_InteractiveContext_NbSelected(Instance);
			}
		}
		public bool HasSelectedShape{
			get {
				return AIS_InteractiveContext_HasSelectedShape(Instance);
			}
		}
		public TopoDSShape SelectedShape{
			get {
				return new TopoDSShape(AIS_InteractiveContext_SelectedShape(Instance));
			}
		}
		public SelectMgrEntityOwner SelectedOwner{
			get {
				return new SelectMgrEntityOwner(AIS_InteractiveContext_SelectedOwner(Instance));
			}
		}
		public AISInteractiveObject Interactive{
			get {
				return new AISInteractiveObject(AIS_InteractiveContext_Interactive(Instance));
			}
		}
		public AISInteractiveObject SelectedInteractive{
			get {
				return new AISInteractiveObject(AIS_InteractiveContext_SelectedInteractive(Instance));
			}
		}
		public bool HasApplicative{
			get {
				return AIS_InteractiveContext_HasApplicative(Instance);
			}
		}
		public StandardTransient Applicative{
			get {
				return new StandardTransient(AIS_InteractiveContext_Applicative(Instance));
			}
		}
		public bool HasDetected{
			get {
				return AIS_InteractiveContext_HasDetected(Instance);
			}
		}
		public bool HasDetectedShape{
			get {
				return AIS_InteractiveContext_HasDetectedShape(Instance);
			}
		}
		public TopoDSShape DetectedShape{
			get {
				return new TopoDSShape(AIS_InteractiveContext_DetectedShape(Instance));
			}
		}
		public AISInteractiveObject DetectedInteractive{
			get {
				return new AISInteractiveObject(AIS_InteractiveContext_DetectedInteractive(Instance));
			}
		}
		public SelectMgrEntityOwner DetectedOwner{
			get {
				return new SelectMgrEntityOwner(AIS_InteractiveContext_DetectedOwner(Instance));
			}
		}
		public bool MoreDetected{
			get {
				return AIS_InteractiveContext_MoreDetected(Instance);
			}
		}
		public TopoDSShape DetectedCurrentShape{
			get {
				return new TopoDSShape(AIS_InteractiveContext_DetectedCurrentShape(Instance));
			}
		}
		public AISInteractiveObject DetectedCurrentObject{
			get {
				return new AISInteractiveObject(AIS_InteractiveContext_DetectedCurrentObject(Instance));
			}
		}
		public int IndexOfCurrentLocal{
			get {
				return AIS_InteractiveContext_IndexOfCurrentLocal(Instance);
			}
		}
		public bool BeginImmediateDraw{
			get {
				return AIS_InteractiveContext_BeginImmediateDraw(Instance);
			}
		}
		public bool IsImmediateModeOn{
			get {
				return AIS_InteractiveContext_IsImmediateModeOn(Instance);
			}
		}
		public bool AutomaticHilight{
			set { 
				AIS_InteractiveContext_SetAutomaticHilight(Instance, value);
			}
			get {
				return AIS_InteractiveContext_AutomaticHilight(Instance);
			}
		}
		public bool ZDetection{
			set { 
				AIS_InteractiveContext_SetZDetection(Instance, value);
			}
			get {
				return AIS_InteractiveContext_ZDetection(Instance);
			}
		}
		public Prs3dDrawer DefaultDrawer{
			get {
				return new Prs3dDrawer(AIS_InteractiveContext_DefaultDrawer(Instance));
			}
		}
		public V3dViewer CurrentViewer{
			get {
				return new V3dViewer(AIS_InteractiveContext_CurrentViewer(Instance));
			}
		}
		public V3dViewer Collector{
			get {
				return new V3dViewer(AIS_InteractiveContext_Collector(Instance));
			}
		}
		public bool HasOpenedContext{
			get {
				return AIS_InteractiveContext_HasOpenedContext(Instance);
			}
		}
		public TCollectionAsciiString CurrentName{
			get {
				return new TCollectionAsciiString(AIS_InteractiveContext_CurrentName(Instance));
			}
		}
		public TCollectionAsciiString SelectionName{
			get {
				return new TCollectionAsciiString(AIS_InteractiveContext_SelectionName(Instance));
			}
		}
		public string DomainOfMainViewer{
			get {
				return AIS_InteractiveContext_DomainOfMainViewer(Instance);
			}
		}
		public SelectMgrSelectionManager SelectionManager{
			get {
				return new SelectMgrSelectionManager(AIS_InteractiveContext_SelectionManager(Instance));
			}
		}
		public PrsMgrPresentationManager3d MainPrsMgr{
			get {
				return new PrsMgrPresentationManager3d(AIS_InteractiveContext_MainPrsMgr(Instance));
			}
		}
		public PrsMgrPresentationManager3d CollectorPrsMgr{
			get {
				return new PrsMgrPresentationManager3d(AIS_InteractiveContext_CollectorPrsMgr(Instance));
			}
		}
		public StdSelectViewerSelector3d MainSelector{
			get {
				return new StdSelectViewerSelector3d(AIS_InteractiveContext_MainSelector(Instance));
			}
		}
		public StdSelectViewerSelector3d LocalSelector{
			get {
				return new StdSelectViewerSelector3d(AIS_InteractiveContext_LocalSelector(Instance));
			}
		}
		public StdSelectViewerSelector3d CollectorSelector{
			get {
				return new StdSelectViewerSelector3d(AIS_InteractiveContext_CollectorSelector(Instance));
			}
		}
		public int HighestIndex{
			get {
				return AIS_InteractiveContext_HighestIndex(Instance);
			}
		}
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr AIS_InteractiveContext_Ctor79560492(IntPtr MainViewer);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr AIS_InteractiveContext_Ctor27F4A3E3(IntPtr MainViewer,IntPtr Collector);
		[DllImport("NaroOccCore.dll")]
		private static extern void AIS_InteractiveContext_Delete(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void AIS_InteractiveContext_CloseCollector(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void AIS_InteractiveContext_OpenCollector(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void AIS_InteractiveContext_Display7BDA0103(IntPtr instance, IntPtr anIobj,bool updateviewer);
		[DllImport("NaroOccCore.dll")]
		private static extern void AIS_InteractiveContext_DisplayBB87E00C(IntPtr instance, IntPtr anIobj,int amode,int aSelectionMode,bool updateviewer,bool allowdecomposition);
		[DllImport("NaroOccCore.dll")]
		private static extern void AIS_InteractiveContext_LoadFDB02EB(IntPtr instance, IntPtr aniobj,int SelectionMode,bool AllowDecomp);
		[DllImport("NaroOccCore.dll")]
		private static extern void AIS_InteractiveContext_EraseB05E0FC3(IntPtr instance, IntPtr aniobj,bool updateviewer,bool PutInCollector);
		[DllImport("NaroOccCore.dll")]
		private static extern void AIS_InteractiveContext_EraseModeFDB02EB(IntPtr instance, IntPtr aniobj,int aMode,bool updateviewer);
		[DllImport("NaroOccCore.dll")]
		private static extern void AIS_InteractiveContext_EraseAllAE8C3818(IntPtr instance, bool PutInCollector,bool updateviewer);
		[DllImport("NaroOccCore.dll")]
		private static extern void AIS_InteractiveContext_DisplayAllAE8C3818(IntPtr instance, bool OnlyFromCollector,bool updateviewer);
		[DllImport("NaroOccCore.dll")]
		private static extern void AIS_InteractiveContext_DisplayFromCollector7BDA0103(IntPtr instance, IntPtr anIObj,bool updateviewer);
		[DllImport("NaroOccCore.dll")]
		private static extern void AIS_InteractiveContext_EraseSelectedAE8C3818(IntPtr instance, bool PutInCollector,bool updateviewer);
		[DllImport("NaroOccCore.dll")]
		private static extern void AIS_InteractiveContext_DisplaySelected461FC46A(IntPtr instance, bool updateviewer);
		[DllImport("NaroOccCore.dll")]
		private static extern bool AIS_InteractiveContext_KeepTemporary4F47E777(IntPtr instance, IntPtr anIObj,int InWhichLocal);
		[DllImport("NaroOccCore.dll")]
		private static extern void AIS_InteractiveContext_Clear7BDA0103(IntPtr instance, IntPtr aniobj,bool updateviewer);
		[DllImport("NaroOccCore.dll")]
		private static extern void AIS_InteractiveContext_ClearPrsFDB02EB(IntPtr instance, IntPtr aniobj,int aMode,bool updateviewer);
		[DllImport("NaroOccCore.dll")]
		private static extern void AIS_InteractiveContext_Remove7BDA0103(IntPtr instance, IntPtr aniobj,bool updateviewer);
		[DllImport("NaroOccCore.dll")]
		private static extern void AIS_InteractiveContext_RemoveAll461FC46A(IntPtr instance, bool updateviewer);
		[DllImport("NaroOccCore.dll")]
		private static extern void AIS_InteractiveContext_Hilight7BDA0103(IntPtr instance, IntPtr aniobj,bool updateviewer);
		[DllImport("NaroOccCore.dll")]
		private static extern void AIS_InteractiveContext_HilightWithColor80F07260(IntPtr instance, IntPtr aniobj,int aCol,bool updateviewer);
		[DllImport("NaroOccCore.dll")]
		private static extern void AIS_InteractiveContext_Unhilight7BDA0103(IntPtr instance, IntPtr aniobj,bool updateviewer);
		[DllImport("NaroOccCore.dll")]
		private static extern void AIS_InteractiveContext_SetDisplayPriority4F47E777(IntPtr instance, IntPtr anIobj,int aPriority);
		[DllImport("NaroOccCore.dll")]
		private static extern void AIS_InteractiveContext_SetZLayer4F47E777(IntPtr instance, IntPtr theIObj,int theLayerId);
		[DllImport("NaroOccCore.dll")]
		private static extern int AIS_InteractiveContext_GetZLayer5DD8A2CA(IntPtr instance, IntPtr theIObj);
		[DllImport("NaroOccCore.dll")]
		private static extern void AIS_InteractiveContext_RedisplayB05E0FC3(IntPtr instance, IntPtr aniobj,bool updateviewer,bool allmodes);
		[DllImport("NaroOccCore.dll")]
		private static extern void AIS_InteractiveContext_Redisplay766D350B(IntPtr instance, int aTypeOfObject,int Signature,bool updateviewer);
		[DllImport("NaroOccCore.dll")]
		private static extern void AIS_InteractiveContext_RecomputePrsOnlyB05E0FC3(IntPtr instance, IntPtr anIobj,bool updateviewer,bool allmodes);
		[DllImport("NaroOccCore.dll")]
		private static extern void AIS_InteractiveContext_RecomputeSelectionOnly5DD8A2CA(IntPtr instance, IntPtr anIObj);
		[DllImport("NaroOccCore.dll")]
		private static extern void AIS_InteractiveContext_Update7BDA0103(IntPtr instance, IntPtr anIobj,bool updateviewer);
		[DllImport("NaroOccCore.dll")]
		private static extern void AIS_InteractiveContext_SetDisplayModeFDB02EB(IntPtr instance, IntPtr aniobj,int aMode,bool updateviewer);
		[DllImport("NaroOccCore.dll")]
		private static extern void AIS_InteractiveContext_UnsetDisplayMode7BDA0103(IntPtr instance, IntPtr aniobj,bool updateviewer);
		[DllImport("NaroOccCore.dll")]
		private static extern void AIS_InteractiveContext_SetSelectionMode4F47E777(IntPtr instance, IntPtr aniobj,int aMode);
		[DllImport("NaroOccCore.dll")]
		private static extern void AIS_InteractiveContext_UnsetSelectionMode5DD8A2CA(IntPtr instance, IntPtr aniobj);
		[DllImport("NaroOccCore.dll")]
		private static extern void AIS_InteractiveContext_SetLocation852B9922(IntPtr instance, IntPtr aniobj,IntPtr aLocation);
		[DllImport("NaroOccCore.dll")]
		private static extern void AIS_InteractiveContext_ResetLocation5DD8A2CA(IntPtr instance, IntPtr aniobj);
		[DllImport("NaroOccCore.dll")]
		private static extern bool AIS_InteractiveContext_HasLocation5DD8A2CA(IntPtr instance, IntPtr aniobj);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr AIS_InteractiveContext_Location5DD8A2CA(IntPtr instance, IntPtr aniobj);
		[DllImport("NaroOccCore.dll")]
		private static extern void AIS_InteractiveContext_SetCurrentFacingModelCD8717A5(IntPtr instance, IntPtr aniobj,int aModel);
		[DllImport("NaroOccCore.dll")]
		private static extern void AIS_InteractiveContext_SetColor80F07260(IntPtr instance, IntPtr aniobj,int aColor,bool updateviewer);
		[DllImport("NaroOccCore.dll")]
		private static extern void AIS_InteractiveContext_SetColorCCA19205(IntPtr instance, IntPtr aniobj,IntPtr aColor,bool updateviewer);
		[DllImport("NaroOccCore.dll")]
		private static extern void AIS_InteractiveContext_UnsetColor7BDA0103(IntPtr instance, IntPtr aniobj,bool updateviewer);
		[DllImport("NaroOccCore.dll")]
		private static extern void AIS_InteractiveContext_SetWidthADEC6198(IntPtr instance, IntPtr aniobj,double aValue,bool updateviewer);
		[DllImport("NaroOccCore.dll")]
		private static extern void AIS_InteractiveContext_UnsetWidth7BDA0103(IntPtr instance, IntPtr aniobj,bool updateviewer);
		[DllImport("NaroOccCore.dll")]
		private static extern void AIS_InteractiveContext_SetMaterial4D782AAE(IntPtr instance, IntPtr aniobj,int aName,bool updateviewer);
		[DllImport("NaroOccCore.dll")]
		private static extern void AIS_InteractiveContext_UnsetMaterial7BDA0103(IntPtr instance, IntPtr anObj,bool updateviewer);
		[DllImport("NaroOccCore.dll")]
		private static extern void AIS_InteractiveContext_SetTransparencyADEC6198(IntPtr instance, IntPtr aniobj,double aValue,bool updateviewer);
		[DllImport("NaroOccCore.dll")]
		private static extern void AIS_InteractiveContext_UnsetTransparency7BDA0103(IntPtr instance, IntPtr aniobj,bool updateviewer);
		[DllImport("NaroOccCore.dll")]
		private static extern void AIS_InteractiveContext_SetDegenerateModel157E506C(IntPtr instance, IntPtr aniobj,int aModel,double aRatio);
		[DllImport("NaroOccCore.dll")]
		private static extern void AIS_InteractiveContext_SetDegenerateModelE6DFDFE0(IntPtr instance, int aModel,double aSkipRatio);
		[DllImport("NaroOccCore.dll")]
		private static extern void AIS_InteractiveContext_SetLocalAttributes6233D91F(IntPtr instance, IntPtr aniobj,IntPtr aDrawer,bool updateviewer);
		[DllImport("NaroOccCore.dll")]
		private static extern void AIS_InteractiveContext_UnsetLocalAttributes7BDA0103(IntPtr instance, IntPtr anObj,bool updateviewer);
		[DllImport("NaroOccCore.dll")]
		private static extern void AIS_InteractiveContext_SetPolygonOffsets6907E6A5(IntPtr instance, IntPtr anObj,int aMode,double aFactor,double aUnits,bool updateviewer);
		[DllImport("NaroOccCore.dll")]
		private static extern bool AIS_InteractiveContext_HasPolygonOffsets5DD8A2CA(IntPtr instance, IntPtr anObj);
        //[DllImport("NaroOccCore.dll")]
        //private static extern void AIS_InteractiveContext_PolygonOffsets330EF62(IntPtr instance, IntPtr anObj,ref int aMode,ref double aFactor,ref double aUnits);
		[DllImport("NaroOccCore.dll")]
		private static extern void AIS_InteractiveContext_SetTrihedronSizeC85E5E0F(IntPtr instance, double aSize,bool updateviewer);
		[DllImport("NaroOccCore.dll")]
		private static extern double AIS_InteractiveContext_TrihedronSize(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool AIS_InteractiveContext_PlaneSize9F0E714F(IntPtr instance, ref double XSize,ref double YSize);
		[DllImport("NaroOccCore.dll")]
		private static extern int AIS_InteractiveContext_DisplayStatus5DD8A2CA(IntPtr instance, IntPtr anIobj);
		[DllImport("NaroOccCore.dll")]
		private static extern bool AIS_InteractiveContext_IsDisplayed5DD8A2CA(IntPtr instance, IntPtr anIobj);
		[DllImport("NaroOccCore.dll")]
		private static extern bool AIS_InteractiveContext_IsDisplayed4F47E777(IntPtr instance, IntPtr aniobj,int aMode);
		[DllImport("NaroOccCore.dll")]
		private static extern bool AIS_InteractiveContext_IsInCollector5DD8A2CA(IntPtr instance, IntPtr anIObj);
		[DllImport("NaroOccCore.dll")]
		private static extern int AIS_InteractiveContext_DisplayPriority5DD8A2CA(IntPtr instance, IntPtr anIobj);
		[DllImport("NaroOccCore.dll")]
		private static extern bool AIS_InteractiveContext_HasColor5DD8A2CA(IntPtr instance, IntPtr aniobj);
		[DllImport("NaroOccCore.dll")]
		private static extern int AIS_InteractiveContext_Color5DD8A2CA(IntPtr instance, IntPtr aniobj);
		[DllImport("NaroOccCore.dll")]
		private static extern void AIS_InteractiveContext_ColorE6084039(IntPtr instance, IntPtr aniobj,IntPtr acolor);
		[DllImport("NaroOccCore.dll")]
		private static extern double AIS_InteractiveContext_Width5DD8A2CA(IntPtr instance, IntPtr aniobj);
		[DllImport("NaroOccCore.dll")]
		private static extern void AIS_InteractiveContext_StatusE16287D5(IntPtr instance, IntPtr anObj,IntPtr astatus);
		[DllImport("NaroOccCore.dll")]
		private static extern void AIS_InteractiveContext_UpdateCurrentViewer(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void AIS_InteractiveContext_UpdateCollector(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern int AIS_InteractiveContext_DisplayMode(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern int AIS_InteractiveContext_SelectionColor(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void AIS_InteractiveContext_SelectionColor48F4F471(IntPtr instance, int aCol);
		[DllImport("NaroOccCore.dll")]
		private static extern void AIS_InteractiveContext_SetDisplayMode989C8794(IntPtr instance, int AMode,bool updateviewer);
		[DllImport("NaroOccCore.dll")]
		private static extern void AIS_InteractiveContext_SetDeviationCoefficientADEC6198(IntPtr instance, IntPtr aniobj,double aCoefficient,bool updateviewer);
		[DllImport("NaroOccCore.dll")]
		private static extern void AIS_InteractiveContext_SetDeviationAngleADEC6198(IntPtr instance, IntPtr aniobj,double anAngle,bool updateviewer);
		[DllImport("NaroOccCore.dll")]
		private static extern void AIS_InteractiveContext_SetAngleAndDeviationADEC6198(IntPtr instance, IntPtr aniobj,double anAngle,bool updateviewer);
		[DllImport("NaroOccCore.dll")]
		private static extern void AIS_InteractiveContext_SetHLRDeviationCoefficientADEC6198(IntPtr instance, IntPtr aniobj,double aCoefficient,bool updateviewer);
		[DllImport("NaroOccCore.dll")]
		private static extern void AIS_InteractiveContext_SetHLRDeviationAngleADEC6198(IntPtr instance, IntPtr aniobj,double anAngle,bool updateviewer);
		[DllImport("NaroOccCore.dll")]
		private static extern void AIS_InteractiveContext_SetHLRAngleAndDeviationADEC6198(IntPtr instance, IntPtr aniobj,double anAngle,bool updateviewer);
		[DllImport("NaroOccCore.dll")]
		private static extern void AIS_InteractiveContext_SetDeviationCoefficientD82819F3(IntPtr instance, double aCoefficient);
		[DllImport("NaroOccCore.dll")]
		private static extern double AIS_InteractiveContext_DeviationCoefficient(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void AIS_InteractiveContext_SetDeviationAngleD82819F3(IntPtr instance, double anAngle);
		[DllImport("NaroOccCore.dll")]
		private static extern double AIS_InteractiveContext_DeviationAngle(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void AIS_InteractiveContext_SetHLRDeviationCoefficientD82819F3(IntPtr instance, double aCoefficient);
		[DllImport("NaroOccCore.dll")]
		private static extern double AIS_InteractiveContext_HLRDeviationCoefficient(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void AIS_InteractiveContext_SetHLRAngleAndDeviationD82819F3(IntPtr instance, double anAngle);
		[DllImport("NaroOccCore.dll")]
		private static extern void AIS_InteractiveContext_EnableDrawHiddenLine(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void AIS_InteractiveContext_DisableDrawHiddenLine(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void AIS_InteractiveContext_SetIsoNumber818B71C9(IntPtr instance, int NbIsos,int WhichIsos);
		[DllImport("NaroOccCore.dll")]
		private static extern int AIS_InteractiveContext_IsoNumber4113B908(IntPtr instance, int WhichIsos);
		[DllImport("NaroOccCore.dll")]
		private static extern void AIS_InteractiveContext_IsoOnPlane461FC46A(IntPtr instance, bool SwitchOn);
		[DllImport("NaroOccCore.dll")]
		private static extern bool AIS_InteractiveContext_IsoOnPlane(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void AIS_InteractiveContext_SetSelectedAspectBD651AAF(IntPtr instance, IntPtr anAspect,bool globalChange,bool updateViewer);
		[DllImport("NaroOccCore.dll")]
		private static extern int AIS_InteractiveContext_MoveTo556D776C(IntPtr instance, int XPix,int YPix,IntPtr aView);
		[DllImport("NaroOccCore.dll")]
		private static extern int AIS_InteractiveContext_HilightNextDetected36A6FAB7(IntPtr instance, IntPtr aView);
		[DllImport("NaroOccCore.dll")]
		private static extern int AIS_InteractiveContext_HilightPreviousDetected36A6FAB7(IntPtr instance, IntPtr aView);
		[DllImport("NaroOccCore.dll")]
		private static extern int AIS_InteractiveContext_Select92079733(IntPtr instance, int XPMin,int YPMin,int XPMax,int YPMax,IntPtr aView,bool updateviewer);
		[DllImport("NaroOccCore.dll")]
		private static extern int AIS_InteractiveContext_Select461FC46A(IntPtr instance, bool updateviewer);
		[DllImport("NaroOccCore.dll")]
		private static extern int AIS_InteractiveContext_ShiftSelect461FC46A(IntPtr instance, bool updateviewer);
		[DllImport("NaroOccCore.dll")]
		private static extern int AIS_InteractiveContext_ShiftSelect92079733(IntPtr instance, int XPMin,int YPMin,int XPMax,int YPMax,IntPtr aView,bool updateviewer);
		[DllImport("NaroOccCore.dll")]
		private static extern void AIS_InteractiveContext_SetCurrentObject7BDA0103(IntPtr instance, IntPtr aniobj,bool updateviewer);
		[DllImport("NaroOccCore.dll")]
		private static extern void AIS_InteractiveContext_AddOrRemoveCurrentObject7BDA0103(IntPtr instance, IntPtr aniobj,bool updateviewer);
		[DllImport("NaroOccCore.dll")]
		private static extern void AIS_InteractiveContext_UpdateCurrent(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void AIS_InteractiveContext_SetOkCurrent(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool AIS_InteractiveContext_IsCurrent5DD8A2CA(IntPtr instance, IntPtr aniobj);
		[DllImport("NaroOccCore.dll")]
		private static extern void AIS_InteractiveContext_InitCurrent(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void AIS_InteractiveContext_NextCurrent(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void AIS_InteractiveContext_HilightCurrents461FC46A(IntPtr instance, bool updateviewer);
		[DllImport("NaroOccCore.dll")]
		private static extern void AIS_InteractiveContext_UnhilightCurrents461FC46A(IntPtr instance, bool updateviewer);
		[DllImport("NaroOccCore.dll")]
		private static extern void AIS_InteractiveContext_ClearCurrents461FC46A(IntPtr instance, bool updateviewer);
		[DllImport("NaroOccCore.dll")]
		private static extern void AIS_InteractiveContext_SetSelected7BDA0103(IntPtr instance, IntPtr aniObj,bool updateviewer);
		[DllImport("NaroOccCore.dll")]
		private static extern void AIS_InteractiveContext_SetSelectedCurrent(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void AIS_InteractiveContext_UpdateSelected461FC46A(IntPtr instance, bool updateviewer);
		[DllImport("NaroOccCore.dll")]
		private static extern void AIS_InteractiveContext_AddOrRemoveSelected7BDA0103(IntPtr instance, IntPtr aniobj,bool updateviewer);
		[DllImport("NaroOccCore.dll")]
		private static extern void AIS_InteractiveContext_HilightSelected461FC46A(IntPtr instance, bool updateviewer);
		[DllImport("NaroOccCore.dll")]
		private static extern void AIS_InteractiveContext_UnhilightSelected461FC46A(IntPtr instance, bool updateviewer);
		[DllImport("NaroOccCore.dll")]
		private static extern void AIS_InteractiveContext_ClearSelected461FC46A(IntPtr instance, bool updateviewer);
		[DllImport("NaroOccCore.dll")]
		private static extern void AIS_InteractiveContext_AddOrRemoveSelected5E7DD5C8(IntPtr instance, IntPtr aShape,bool updateviewer);
		[DllImport("NaroOccCore.dll")]
		private static extern void AIS_InteractiveContext_AddOrRemoveSelected26C4ECD2(IntPtr instance, IntPtr anOwner,bool updateviewer);
		[DllImport("NaroOccCore.dll")]
		private static extern bool AIS_InteractiveContext_IsSelected5DD8A2CA(IntPtr instance, IntPtr aniobj);
		[DllImport("NaroOccCore.dll")]
		private static extern void AIS_InteractiveContext_InitSelected(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void AIS_InteractiveContext_NextSelected(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void AIS_InteractiveContext_InitDetected(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void AIS_InteractiveContext_NextDetected(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern int AIS_InteractiveContext_OpenLocalContextA58FCEEB(IntPtr instance, bool UseDisplayedObjects,bool AllowShapeDecomposition,bool AcceptEraseOfObjects,bool BothViewers);
		[DllImport("NaroOccCore.dll")]
		private static extern void AIS_InteractiveContext_CloseLocalContext898DAFFC(IntPtr instance, int Index,bool updateviewer);
		[DllImport("NaroOccCore.dll")]
		private static extern void AIS_InteractiveContext_CloseAllContexts461FC46A(IntPtr instance, bool updateviewer);
		[DllImport("NaroOccCore.dll")]
		private static extern void AIS_InteractiveContext_ResetOriginalState461FC46A(IntPtr instance, bool updateviewer);
		[DllImport("NaroOccCore.dll")]
		private static extern void AIS_InteractiveContext_ClearLocalContext4E21E443(IntPtr instance, int TheMode);
		[DllImport("NaroOccCore.dll")]
		private static extern void AIS_InteractiveContext_UseDisplayedObjects(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void AIS_InteractiveContext_NotUseDisplayedObjects(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool AIS_InteractiveContext_ImmediateAdd4F47E777(IntPtr instance, IntPtr anIObj,int aMode);
		[DllImport("NaroOccCore.dll")]
		private static extern bool AIS_InteractiveContext_ImmediateRemove4F47E777(IntPtr instance, IntPtr anIObj,int aMode);
		[DllImport("NaroOccCore.dll")]
		private static extern bool AIS_InteractiveContext_EndImmediateDraw3F19241F(IntPtr instance, IntPtr aView,bool DoubleBuf);
		[DllImport("NaroOccCore.dll")]
		private static extern bool AIS_InteractiveContext_EndImmediateDraw461FC46A(IntPtr instance, bool DoubleBuf);
		[DllImport("NaroOccCore.dll")]
		private static extern void AIS_InteractiveContext_Drag5E8F49C8(IntPtr instance, IntPtr aView,IntPtr anObject,IntPtr aTranformation,bool postConcatenate,bool update,bool zBuffer);
		[DllImport("NaroOccCore.dll")]
		private static extern void AIS_InteractiveContext_Activate4F47E777(IntPtr instance, IntPtr anIobj,int aMode);
		[DllImport("NaroOccCore.dll")]
		private static extern void AIS_InteractiveContext_Deactivate5DD8A2CA(IntPtr instance, IntPtr anIObj);
		[DllImport("NaroOccCore.dll")]
		private static extern void AIS_InteractiveContext_Deactivate4F47E777(IntPtr instance, IntPtr anIobj,int aMode);
		[DllImport("NaroOccCore.dll")]
		private static extern void AIS_InteractiveContext_SetShapeDecomposition7BDA0103(IntPtr instance, IntPtr anIobj,bool aStatus);
		[DllImport("NaroOccCore.dll")]
		private static extern void AIS_InteractiveContext_SetTemporaryAttributesA5FB0AF4(IntPtr instance, IntPtr anObj,IntPtr aDrawer,bool updateviewer);
		[DllImport("NaroOccCore.dll")]
		private static extern void AIS_InteractiveContext_SubIntensityOn7BDA0103(IntPtr instance, IntPtr aniobj,bool updateviewer);
		[DllImport("NaroOccCore.dll")]
		private static extern void AIS_InteractiveContext_SubIntensityOff7BDA0103(IntPtr instance, IntPtr aniobj,bool updateviewer);
		[DllImport("NaroOccCore.dll")]
		private static extern void AIS_InteractiveContext_SubIntensityOn461FC46A(IntPtr instance, bool updateviewer);
		[DllImport("NaroOccCore.dll")]
		private static extern void AIS_InteractiveContext_SubIntensityOff461FC46A(IntPtr instance, bool updateviewer);
		[DllImport("NaroOccCore.dll")]
		private static extern void AIS_InteractiveContext_AddFilter3C9475B7(IntPtr instance, IntPtr aFilter);
		[DllImport("NaroOccCore.dll")]
		private static extern void AIS_InteractiveContext_RemoveFilter3C9475B7(IntPtr instance, IntPtr aFilter);
		[DllImport("NaroOccCore.dll")]
		private static extern void AIS_InteractiveContext_RemoveFilters(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void AIS_InteractiveContext_ActivateStandardModeC6FD32C4(IntPtr instance, int aStandardActivation);
		[DllImport("NaroOccCore.dll")]
		private static extern void AIS_InteractiveContext_DeactivateStandardModeC6FD32C4(IntPtr instance, int aStandardActivation);
		[DllImport("NaroOccCore.dll")]
		private static extern void AIS_InteractiveContext_DisplayedObjectsFB1E3476(IntPtr instance, IntPtr aListOfIO,bool OnlyFromNeutral);
		[DllImport("NaroOccCore.dll")]
		private static extern void AIS_InteractiveContext_DisplayedObjects552A363C(IntPtr instance, int WhichKind,int WhichSignature,IntPtr aListOfIO,bool OnlyFromNeutral);
		[DllImport("NaroOccCore.dll")]
		private static extern void AIS_InteractiveContext_ObjectsInCollector235DE22E(IntPtr instance, IntPtr aListOfIO);
		[DllImport("NaroOccCore.dll")]
		private static extern void AIS_InteractiveContext_ObjectsInCollectorFB8692A(IntPtr instance, int WhichKind,int WhichSignature,IntPtr aListOfIO);
		[DllImport("NaroOccCore.dll")]
		private static extern void AIS_InteractiveContext_ErasedObjects235DE22E(IntPtr instance, IntPtr theListOfIO);
		[DllImport("NaroOccCore.dll")]
		private static extern void AIS_InteractiveContext_ErasedObjectsFB8692A(IntPtr instance, int WhichKind,int WhichSignature,IntPtr theListOfIO);
		[DllImport("NaroOccCore.dll")]
		private static extern void AIS_InteractiveContext_ObjectsByDisplayStatusF86BDF5C(IntPtr instance, int theStatus,IntPtr theListOfIO);
		[DllImport("NaroOccCore.dll")]
		private static extern void AIS_InteractiveContext_ObjectsByDisplayStatusB048A7AD(IntPtr instance, int WhichKind,int WhichSignature,int theStatus,IntPtr theListOfIO);
		[DllImport("NaroOccCore.dll")]
		private static extern void AIS_InteractiveContext_ObjectsInsideC8729CEC(IntPtr instance, IntPtr aListOfIO,int WhichKind,int WhichSignature);
		[DllImport("NaroOccCore.dll")]
		private static extern int AIS_InteractiveContext_PurgeDisplay461FC46A(IntPtr instance, bool CollectorToo);
		[DllImport("NaroOccCore.dll")]
		private static extern void AIS_InteractiveContext_DisplayActiveAreas36A6FAB7(IntPtr instance, IntPtr aView);
		[DllImport("NaroOccCore.dll")]
		private static extern void AIS_InteractiveContext_ClearActiveAreas36A6FAB7(IntPtr instance, IntPtr aView);
		[DllImport("NaroOccCore.dll")]
		private static extern void AIS_InteractiveContext_DisplayActiveSensitive36A6FAB7(IntPtr instance, IntPtr aView);
		[DllImport("NaroOccCore.dll")]
		private static extern void AIS_InteractiveContext_ClearActiveSensitive36A6FAB7(IntPtr instance, IntPtr aView);
		[DllImport("NaroOccCore.dll")]
		private static extern void AIS_InteractiveContext_DisplayActiveSensitiveC47ED7A2(IntPtr instance, IntPtr anObject,IntPtr aView);
		[DllImport("NaroOccCore.dll")]
		private static extern void AIS_InteractiveContext_DisplayActiveAreasC47ED7A2(IntPtr instance, IntPtr anObject,IntPtr aView);
		[DllImport("NaroOccCore.dll")]
		private static extern bool AIS_InteractiveContext_IsInLocal4F47E777(IntPtr instance, IntPtr anObject,ref int TheIndex);
		[DllImport("NaroOccCore.dll")]
		private static extern bool AIS_InteractiveContext_IsCollectorClosed(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void AIS_InteractiveContext_SetAutoActivateSelection(IntPtr instance, bool value);
		[DllImport("NaroOccCore.dll")]
		private static extern bool AIS_InteractiveContext_GetAutoActivateSelection(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void AIS_InteractiveContext_SetSensitivityMode(IntPtr instance, int value);
		[DllImport("NaroOccCore.dll")]
		private static extern int AIS_InteractiveContext_SensitivityMode(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void AIS_InteractiveContext_SetSensitivity(IntPtr instance, double value);
		[DllImport("NaroOccCore.dll")]
		private static extern double AIS_InteractiveContext_Sensitivity(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void AIS_InteractiveContext_SetPixelTolerance(IntPtr instance, int value);
		[DllImport("NaroOccCore.dll")]
		private static extern int AIS_InteractiveContext_PixelTolerance(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern int AIS_InteractiveContext_PreSelectionColor(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern int AIS_InteractiveContext_DefaultColor(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void AIS_InteractiveContext_SetHilightColor(IntPtr instance, int value);
		[DllImport("NaroOccCore.dll")]
		private static extern int AIS_InteractiveContext_HilightColor(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void AIS_InteractiveContext_SetPreselectionColor(IntPtr instance, int value);
		[DllImport("NaroOccCore.dll")]
		private static extern void AIS_InteractiveContext_SetSubIntensityColor(IntPtr instance, int value);
		[DllImport("NaroOccCore.dll")]
		private static extern int AIS_InteractiveContext_SubIntensityColor(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void AIS_InteractiveContext_SetHLRAngle(IntPtr instance, double value);
		[DllImport("NaroOccCore.dll")]
		private static extern double AIS_InteractiveContext_HLRAngle(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void AIS_InteractiveContext_SetHiddenLineAspect(IntPtr instance, IntPtr value);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr AIS_InteractiveContext_HiddenLineAspect(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool AIS_InteractiveContext_DrawHiddenLine(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool AIS_InteractiveContext_HasNextDetected(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void AIS_InteractiveContext_SetToHilightSelected(IntPtr instance, bool value);
		[DllImport("NaroOccCore.dll")]
		private static extern bool AIS_InteractiveContext_ToHilightSelected(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool AIS_InteractiveContext_WasCurrentTouched(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool AIS_InteractiveContext_MoreCurrent(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr AIS_InteractiveContext_Current(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern int AIS_InteractiveContext_NbCurrents(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr AIS_InteractiveContext_FirstCurrentObject(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool AIS_InteractiveContext_MoreSelected(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern int AIS_InteractiveContext_NbSelected(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool AIS_InteractiveContext_HasSelectedShape(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr AIS_InteractiveContext_SelectedShape(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr AIS_InteractiveContext_SelectedOwner(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr AIS_InteractiveContext_Interactive(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr AIS_InteractiveContext_SelectedInteractive(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool AIS_InteractiveContext_HasApplicative(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr AIS_InteractiveContext_Applicative(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool AIS_InteractiveContext_HasDetected(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool AIS_InteractiveContext_HasDetectedShape(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr AIS_InteractiveContext_DetectedShape(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr AIS_InteractiveContext_DetectedInteractive(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr AIS_InteractiveContext_DetectedOwner(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool AIS_InteractiveContext_MoreDetected(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr AIS_InteractiveContext_DetectedCurrentShape(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr AIS_InteractiveContext_DetectedCurrentObject(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern int AIS_InteractiveContext_IndexOfCurrentLocal(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool AIS_InteractiveContext_BeginImmediateDraw(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool AIS_InteractiveContext_IsImmediateModeOn(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void AIS_InteractiveContext_SetAutomaticHilight(IntPtr instance, bool value);
		[DllImport("NaroOccCore.dll")]
		private static extern bool AIS_InteractiveContext_AutomaticHilight(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void AIS_InteractiveContext_SetZDetection(IntPtr instance, bool value);
		[DllImport("NaroOccCore.dll")]
		private static extern bool AIS_InteractiveContext_ZDetection(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr AIS_InteractiveContext_DefaultDrawer(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr AIS_InteractiveContext_CurrentViewer(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr AIS_InteractiveContext_Collector(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool AIS_InteractiveContext_HasOpenedContext(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr AIS_InteractiveContext_CurrentName(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr AIS_InteractiveContext_SelectionName(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern string AIS_InteractiveContext_DomainOfMainViewer(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr AIS_InteractiveContext_SelectionManager(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr AIS_InteractiveContext_MainPrsMgr(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr AIS_InteractiveContext_CollectorPrsMgr(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr AIS_InteractiveContext_MainSelector(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr AIS_InteractiveContext_LocalSelector(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr AIS_InteractiveContext_CollectorSelector(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern int AIS_InteractiveContext_HighestIndex(IntPtr instance);

		#region NativeInstancePtr Convert constructor

		public AISInteractiveContext() { } 

		public AISInteractiveContext(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{
		    try
		    {
                AISInteractiveContext_Dtor(Instance);
		    }
		    catch (Exception)
		    {
		    }
		   
		}

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void AISInteractiveContext_Dtor(IntPtr instance);
	}
}
