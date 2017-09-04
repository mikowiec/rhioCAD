#ifndef AIS_InteractiveContext_H
#define AIS_InteractiveContext_H

#include "../../Export_Import.h"

extern "C" DECL_EXPORT void* AIS_InteractiveContext_Ctor79560492(
	void* MainViewer);
extern "C" DECL_EXPORT void* AIS_InteractiveContext_Ctor27F4A3E3(
	void* MainViewer,
	void* Collector);
extern "C" DECL_EXPORT void AIS_InteractiveContext_Delete(void* instance);
extern "C" DECL_EXPORT void AIS_InteractiveContext_CloseCollector(void* instance);
extern "C" DECL_EXPORT void AIS_InteractiveContext_OpenCollector(void* instance);
extern "C" DECL_EXPORT void AIS_InteractiveContext_Display7BDA0103(
	void* instance,
	void* anIobj,
	bool updateviewer);
extern "C" DECL_EXPORT void AIS_InteractiveContext_DisplayBB87E00C(
	void* instance,
	void* anIobj,
	int amode,
	int aSelectionMode,
	bool updateviewer,
	bool allowdecomposition);
extern "C" DECL_EXPORT void AIS_InteractiveContext_LoadFDB02EB(
	void* instance,
	void* aniobj,
	int SelectionMode,
	bool AllowDecomp);
extern "C" DECL_EXPORT void AIS_InteractiveContext_EraseB05E0FC3(
	void* instance,
	void* aniobj,
	bool updateviewer,
	bool PutInCollector);
extern "C" DECL_EXPORT void AIS_InteractiveContext_EraseModeFDB02EB(
	void* instance,
	void* aniobj,
	int aMode,
	bool updateviewer);
extern "C" DECL_EXPORT void AIS_InteractiveContext_EraseAllAE8C3818(
	void* instance,
	bool PutInCollector,
	bool updateviewer);
extern "C" DECL_EXPORT void AIS_InteractiveContext_DisplayAllAE8C3818(
	void* instance,
	bool OnlyFromCollector,
	bool updateviewer);
extern "C" DECL_EXPORT void AIS_InteractiveContext_DisplayFromCollector7BDA0103(
	void* instance,
	void* anIObj,
	bool updateviewer);
extern "C" DECL_EXPORT void AIS_InteractiveContext_EraseSelectedAE8C3818(
	void* instance,
	bool PutInCollector,
	bool updateviewer);
extern "C" DECL_EXPORT void AIS_InteractiveContext_DisplaySelected461FC46A(
	void* instance,
	bool updateviewer);
extern "C" DECL_EXPORT bool AIS_InteractiveContext_KeepTemporary4F47E777(
	void* instance,
	void* anIObj,
	int InWhichLocal);
extern "C" DECL_EXPORT void AIS_InteractiveContext_Clear7BDA0103(
	void* instance,
	void* aniobj,
	bool updateviewer);
extern "C" DECL_EXPORT void AIS_InteractiveContext_ClearPrsFDB02EB(
	void* instance,
	void* aniobj,
	int aMode,
	bool updateviewer);
extern "C" DECL_EXPORT void AIS_InteractiveContext_Remove7BDA0103(
	void* instance,
	void* aniobj,
	bool updateviewer);
extern "C" DECL_EXPORT void AIS_InteractiveContext_RemoveAll461FC46A(
	void* instance,
	bool updateviewer);
extern "C" DECL_EXPORT void AIS_InteractiveContext_Hilight7BDA0103(
	void* instance,
	void* aniobj,
	bool updateviewer);
extern "C" DECL_EXPORT void AIS_InteractiveContext_HilightWithColor80F07260(
	void* instance,
	void* aniobj,
	int aCol,
	bool updateviewer);
extern "C" DECL_EXPORT void AIS_InteractiveContext_Unhilight7BDA0103(
	void* instance,
	void* aniobj,
	bool updateviewer);
extern "C" DECL_EXPORT void AIS_InteractiveContext_SetDisplayPriority4F47E777(
	void* instance,
	void* anIobj,
	int aPriority);
extern "C" DECL_EXPORT void AIS_InteractiveContext_SetZLayer4F47E777(
	void* instance,
	void* theIObj,
	int theLayerId);
extern "C" DECL_EXPORT int AIS_InteractiveContext_GetZLayer5DD8A2CA(
	void* instance,
	void* theIObj);
extern "C" DECL_EXPORT void AIS_InteractiveContext_RedisplayB05E0FC3(
	void* instance,
	void* aniobj,
	bool updateviewer,
	bool allmodes);
extern "C" DECL_EXPORT void AIS_InteractiveContext_Redisplay766D350B(
	void* instance,
	int aTypeOfObject,
	int Signature,
	bool updateviewer);
extern "C" DECL_EXPORT void AIS_InteractiveContext_RecomputePrsOnlyB05E0FC3(
	void* instance,
	void* anIobj,
	bool updateviewer,
	bool allmodes);
extern "C" DECL_EXPORT void AIS_InteractiveContext_RecomputeSelectionOnly5DD8A2CA(
	void* instance,
	void* anIObj);
extern "C" DECL_EXPORT void AIS_InteractiveContext_Update7BDA0103(
	void* instance,
	void* anIobj,
	bool updateviewer);
extern "C" DECL_EXPORT void AIS_InteractiveContext_SetDisplayModeFDB02EB(
	void* instance,
	void* aniobj,
	int aMode,
	bool updateviewer);
extern "C" DECL_EXPORT void AIS_InteractiveContext_UnsetDisplayMode7BDA0103(
	void* instance,
	void* aniobj,
	bool updateviewer);
extern "C" DECL_EXPORT void AIS_InteractiveContext_SetSelectionMode4F47E777(
	void* instance,
	void* aniobj,
	int aMode);
extern "C" DECL_EXPORT void AIS_InteractiveContext_UnsetSelectionMode5DD8A2CA(
	void* instance,
	void* aniobj);
extern "C" DECL_EXPORT void AIS_InteractiveContext_SetLocation852B9922(
	void* instance,
	void* aniobj,
	void* aLocation);
extern "C" DECL_EXPORT void AIS_InteractiveContext_ResetLocation5DD8A2CA(
	void* instance,
	void* aniobj);
extern "C" DECL_EXPORT bool AIS_InteractiveContext_HasLocation5DD8A2CA(
	void* instance,
	void* aniobj);
extern "C" DECL_EXPORT void* AIS_InteractiveContext_Location5DD8A2CA(
	void* instance,
	void* aniobj);
extern "C" DECL_EXPORT void AIS_InteractiveContext_SetCurrentFacingModelCD8717A5(
	void* instance,
	void* aniobj,
	int aModel);
extern "C" DECL_EXPORT void AIS_InteractiveContext_SetColor80F07260(
	void* instance,
	void* aniobj,
	int aColor,
	bool updateviewer);
extern "C" DECL_EXPORT void AIS_InteractiveContext_SetColorCCA19205(
	void* instance,
	void* aniobj,
	void* aColor,
	bool updateviewer);
extern "C" DECL_EXPORT void AIS_InteractiveContext_UnsetColor7BDA0103(
	void* instance,
	void* aniobj,
	bool updateviewer);
extern "C" DECL_EXPORT void AIS_InteractiveContext_SetWidthADEC6198(
	void* instance,
	void* aniobj,
	double aValue,
	bool updateviewer);
extern "C" DECL_EXPORT void AIS_InteractiveContext_UnsetWidth7BDA0103(
	void* instance,
	void* aniobj,
	bool updateviewer);
extern "C" DECL_EXPORT void AIS_InteractiveContext_SetMaterial4D782AAE(
	void* instance,
	void* aniobj,
	int aName,
	bool updateviewer);
extern "C" DECL_EXPORT void AIS_InteractiveContext_UnsetMaterial7BDA0103(
	void* instance,
	void* anObj,
	bool updateviewer);
extern "C" DECL_EXPORT void AIS_InteractiveContext_SetTransparencyADEC6198(
	void* instance,
	void* aniobj,
	double aValue,
	bool updateviewer);
extern "C" DECL_EXPORT void AIS_InteractiveContext_UnsetTransparency7BDA0103(
	void* instance,
	void* aniobj,
	bool updateviewer);
extern "C" DECL_EXPORT void AIS_InteractiveContext_SetDegenerateModel157E506C(
	void* instance,
	void* aniobj,
	int aModel,
	double aRatio);
extern "C" DECL_EXPORT void AIS_InteractiveContext_SetDegenerateModelE6DFDFE0(
	void* instance,
	int aModel,
	double aSkipRatio);
extern "C" DECL_EXPORT void AIS_InteractiveContext_SetLocalAttributes6233D91F(
	void* instance,
	void* aniobj,
	void* aDrawer,
	bool updateviewer);
extern "C" DECL_EXPORT void AIS_InteractiveContext_UnsetLocalAttributes7BDA0103(
	void* instance,
	void* anObj,
	bool updateviewer);
extern "C" DECL_EXPORT void AIS_InteractiveContext_SetPolygonOffsets6907E6A5(
	void* instance,
	void* anObj,
	int aMode,
	double aFactor,
	double aUnits,
	bool updateviewer);
extern "C" DECL_EXPORT bool AIS_InteractiveContext_HasPolygonOffsets5DD8A2CA(
	void* instance,
	void* anObj);
extern "C" DECL_EXPORT void AIS_InteractiveContext_PolygonOffsets330EF62(
	void* instance,
	void* anObj,
	int* aMode,
	double* aFactor,
	double* aUnits);
extern "C" DECL_EXPORT void AIS_InteractiveContext_SetTrihedronSizeC85E5E0F(
	void* instance,
	double aSize,
	bool updateviewer);
extern "C" DECL_EXPORT double AIS_InteractiveContext_TrihedronSize(void* instance);
extern "C" DECL_EXPORT bool AIS_InteractiveContext_PlaneSize9F0E714F(
	void* instance,
	double* XSize,
	double* YSize);
extern "C" DECL_EXPORT int AIS_InteractiveContext_DisplayStatus5DD8A2CA(
	void* instance,
	void* anIobj);
extern "C" DECL_EXPORT bool AIS_InteractiveContext_IsDisplayed5DD8A2CA(
	void* instance,
	void* anIobj);
extern "C" DECL_EXPORT bool AIS_InteractiveContext_IsDisplayed4F47E777(
	void* instance,
	void* aniobj,
	int aMode);
extern "C" DECL_EXPORT bool AIS_InteractiveContext_IsInCollector5DD8A2CA(
	void* instance,
	void* anIObj);
extern "C" DECL_EXPORT int AIS_InteractiveContext_DisplayPriority5DD8A2CA(
	void* instance,
	void* anIobj);
extern "C" DECL_EXPORT bool AIS_InteractiveContext_HasColor5DD8A2CA(
	void* instance,
	void* aniobj);
extern "C" DECL_EXPORT int AIS_InteractiveContext_Color5DD8A2CA(
	void* instance,
	void* aniobj);
extern "C" DECL_EXPORT void AIS_InteractiveContext_ColorE6084039(
	void* instance,
	void* aniobj,
	void* acolor);
extern "C" DECL_EXPORT double AIS_InteractiveContext_Width5DD8A2CA(
	void* instance,
	void* aniobj);
extern "C" DECL_EXPORT void AIS_InteractiveContext_StatusE16287D5(
	void* instance,
	void* anObj,
	void* astatus);
extern "C" DECL_EXPORT void AIS_InteractiveContext_UpdateCurrentViewer(void* instance);
extern "C" DECL_EXPORT void AIS_InteractiveContext_UpdateCollector(void* instance);
extern "C" DECL_EXPORT int AIS_InteractiveContext_DisplayMode(void* instance);
extern "C" DECL_EXPORT int AIS_InteractiveContext_SelectionColor(void* instance);
extern "C" DECL_EXPORT void AIS_InteractiveContext_SelectionColor48F4F471(
	void* instance,
	int aCol);
extern "C" DECL_EXPORT void AIS_InteractiveContext_SetDisplayMode989C8794(
	void* instance,
	int AMode,
	bool updateviewer);
extern "C" DECL_EXPORT void AIS_InteractiveContext_SetDeviationCoefficientADEC6198(
	void* instance,
	void* aniobj,
	double aCoefficient,
	bool updateviewer);
extern "C" DECL_EXPORT void AIS_InteractiveContext_SetDeviationAngleADEC6198(
	void* instance,
	void* aniobj,
	double anAngle,
	bool updateviewer);
extern "C" DECL_EXPORT void AIS_InteractiveContext_SetAngleAndDeviationADEC6198(
	void* instance,
	void* aniobj,
	double anAngle,
	bool updateviewer);
extern "C" DECL_EXPORT void AIS_InteractiveContext_SetHLRDeviationCoefficientADEC6198(
	void* instance,
	void* aniobj,
	double aCoefficient,
	bool updateviewer);
extern "C" DECL_EXPORT void AIS_InteractiveContext_SetHLRDeviationAngleADEC6198(
	void* instance,
	void* aniobj,
	double anAngle,
	bool updateviewer);
extern "C" DECL_EXPORT void AIS_InteractiveContext_SetHLRAngleAndDeviationADEC6198(
	void* instance,
	void* aniobj,
	double anAngle,
	bool updateviewer);
extern "C" DECL_EXPORT void AIS_InteractiveContext_SetDeviationCoefficientD82819F3(
	void* instance,
	double aCoefficient);
extern "C" DECL_EXPORT double AIS_InteractiveContext_DeviationCoefficient(void* instance);
extern "C" DECL_EXPORT void AIS_InteractiveContext_SetDeviationAngleD82819F3(
	void* instance,
	double anAngle);
extern "C" DECL_EXPORT double AIS_InteractiveContext_DeviationAngle(void* instance);
extern "C" DECL_EXPORT void AIS_InteractiveContext_SetHLRDeviationCoefficientD82819F3(
	void* instance,
	double aCoefficient);
extern "C" DECL_EXPORT double AIS_InteractiveContext_HLRDeviationCoefficient(void* instance);
extern "C" DECL_EXPORT void AIS_InteractiveContext_SetHLRAngleAndDeviationD82819F3(
	void* instance,
	double anAngle);
extern "C" DECL_EXPORT void AIS_InteractiveContext_EnableDrawHiddenLine(void* instance);
extern "C" DECL_EXPORT void AIS_InteractiveContext_DisableDrawHiddenLine(void* instance);
extern "C" DECL_EXPORT void AIS_InteractiveContext_SetIsoNumber818B71C9(
	void* instance,
	int NbIsos,
	int WhichIsos);
extern "C" DECL_EXPORT int AIS_InteractiveContext_IsoNumber4113B908(
	void* instance,
	int WhichIsos);
extern "C" DECL_EXPORT void AIS_InteractiveContext_IsoOnPlane461FC46A(
	void* instance,
	bool SwitchOn);
extern "C" DECL_EXPORT bool AIS_InteractiveContext_IsoOnPlane(void* instance);
extern "C" DECL_EXPORT void AIS_InteractiveContext_SetSelectedAspectBD651AAF(
	void* instance,
	void* anAspect,
	bool globalChange,
	bool updateViewer);
extern "C" DECL_EXPORT int AIS_InteractiveContext_MoveTo556D776C(
	void* instance,
	int XPix,
	int YPix,
	void* aView);
extern "C" DECL_EXPORT int AIS_InteractiveContext_HilightNextDetected36A6FAB7(
	void* instance,
	void* aView);
extern "C" DECL_EXPORT int AIS_InteractiveContext_HilightPreviousDetected36A6FAB7(
	void* instance,
	void* aView);
extern "C" DECL_EXPORT int AIS_InteractiveContext_Select92079733(
	void* instance,
	int XPMin,
	int YPMin,
	int XPMax,
	int YPMax,
	void* aView,
	bool updateviewer);
extern "C" DECL_EXPORT int AIS_InteractiveContext_Select461FC46A(
	void* instance,
	bool updateviewer);
extern "C" DECL_EXPORT int AIS_InteractiveContext_ShiftSelect461FC46A(
	void* instance,
	bool updateviewer);
extern "C" DECL_EXPORT int AIS_InteractiveContext_ShiftSelect92079733(
	void* instance,
	int XPMin,
	int YPMin,
	int XPMax,
	int YPMax,
	void* aView,
	bool updateviewer);
extern "C" DECL_EXPORT void AIS_InteractiveContext_SetCurrentObject7BDA0103(
	void* instance,
	void* aniobj,
	bool updateviewer);
extern "C" DECL_EXPORT void AIS_InteractiveContext_AddOrRemoveCurrentObject7BDA0103(
	void* instance,
	void* aniobj,
	bool updateviewer);
extern "C" DECL_EXPORT void AIS_InteractiveContext_UpdateCurrent(void* instance);
extern "C" DECL_EXPORT void AIS_InteractiveContext_SetOkCurrent(void* instance);
extern "C" DECL_EXPORT bool AIS_InteractiveContext_IsCurrent5DD8A2CA(
	void* instance,
	void* aniobj);
extern "C" DECL_EXPORT void AIS_InteractiveContext_InitCurrent(void* instance);
extern "C" DECL_EXPORT void AIS_InteractiveContext_NextCurrent(void* instance);
extern "C" DECL_EXPORT void AIS_InteractiveContext_HilightCurrents461FC46A(
	void* instance,
	bool updateviewer);
extern "C" DECL_EXPORT void AIS_InteractiveContext_UnhilightCurrents461FC46A(
	void* instance,
	bool updateviewer);
extern "C" DECL_EXPORT void AIS_InteractiveContext_ClearCurrents461FC46A(
	void* instance,
	bool updateviewer);
extern "C" DECL_EXPORT void AIS_InteractiveContext_SetSelected7BDA0103(
	void* instance,
	void* aniObj,
	bool updateviewer);
extern "C" DECL_EXPORT void AIS_InteractiveContext_SetSelectedCurrent(void* instance);
extern "C" DECL_EXPORT void AIS_InteractiveContext_UpdateSelected461FC46A(
	void* instance,
	bool updateviewer);
extern "C" DECL_EXPORT void AIS_InteractiveContext_AddOrRemoveSelected7BDA0103(
	void* instance,
	void* aniobj,
	bool updateviewer);
extern "C" DECL_EXPORT void AIS_InteractiveContext_HilightSelected461FC46A(
	void* instance,
	bool updateviewer);
extern "C" DECL_EXPORT void AIS_InteractiveContext_UnhilightSelected461FC46A(
	void* instance,
	bool updateviewer);
extern "C" DECL_EXPORT void AIS_InteractiveContext_ClearSelected461FC46A(
	void* instance,
	bool updateviewer);
extern "C" DECL_EXPORT void AIS_InteractiveContext_AddOrRemoveSelected5E7DD5C8(
	void* instance,
	void* aShape,
	bool updateviewer);
extern "C" DECL_EXPORT void AIS_InteractiveContext_AddOrRemoveSelected26C4ECD2(
	void* instance,
	void* anOwner,
	bool updateviewer);
extern "C" DECL_EXPORT bool AIS_InteractiveContext_IsSelected5DD8A2CA(
	void* instance,
	void* aniobj);
extern "C" DECL_EXPORT void AIS_InteractiveContext_InitSelected(void* instance);
extern "C" DECL_EXPORT void AIS_InteractiveContext_NextSelected(void* instance);
extern "C" DECL_EXPORT void AIS_InteractiveContext_InitDetected(void* instance);
extern "C" DECL_EXPORT void AIS_InteractiveContext_NextDetected(void* instance);
extern "C" DECL_EXPORT int AIS_InteractiveContext_OpenLocalContextA58FCEEB(
	void* instance,
	bool UseDisplayedObjects,
	bool AllowShapeDecomposition,
	bool AcceptEraseOfObjects,
	bool BothViewers);
extern "C" DECL_EXPORT void AIS_InteractiveContext_CloseLocalContext898DAFFC(
	void* instance,
	int Index,
	bool updateviewer);
extern "C" DECL_EXPORT void AIS_InteractiveContext_CloseAllContexts461FC46A(
	void* instance,
	bool updateviewer);
extern "C" DECL_EXPORT void AIS_InteractiveContext_ResetOriginalState461FC46A(
	void* instance,
	bool updateviewer);
extern "C" DECL_EXPORT void AIS_InteractiveContext_ClearLocalContext4E21E443(
	void* instance,
	int TheMode);
extern "C" DECL_EXPORT void AIS_InteractiveContext_UseDisplayedObjects(void* instance);
extern "C" DECL_EXPORT void AIS_InteractiveContext_NotUseDisplayedObjects(void* instance);
extern "C" DECL_EXPORT bool AIS_InteractiveContext_ImmediateAdd4F47E777(
	void* instance,
	void* anIObj,
	int aMode);
extern "C" DECL_EXPORT bool AIS_InteractiveContext_ImmediateRemove4F47E777(
	void* instance,
	void* anIObj,
	int aMode);
extern "C" DECL_EXPORT bool AIS_InteractiveContext_EndImmediateDraw3F19241F(
	void* instance,
	void* aView,
	bool DoubleBuf);
extern "C" DECL_EXPORT bool AIS_InteractiveContext_EndImmediateDraw461FC46A(
	void* instance,
	bool DoubleBuf);
extern "C" DECL_EXPORT void AIS_InteractiveContext_Drag5E8F49C8(
	void* instance,
	void* aView,
	void* anObject,
	void* aTranformation,
	bool postConcatenate,
	bool update,
	bool zBuffer);
extern "C" DECL_EXPORT void AIS_InteractiveContext_Activate4F47E777(
	void* instance,
	void* anIobj,
	int aMode);
extern "C" DECL_EXPORT void AIS_InteractiveContext_Deactivate5DD8A2CA(
	void* instance,
	void* anIObj);
extern "C" DECL_EXPORT void AIS_InteractiveContext_Deactivate4F47E777(
	void* instance,
	void* anIobj,
	int aMode);
extern "C" DECL_EXPORT void AIS_InteractiveContext_SetShapeDecomposition7BDA0103(
	void* instance,
	void* anIobj,
	bool aStatus);
extern "C" DECL_EXPORT void AIS_InteractiveContext_SetTemporaryAttributesA5FB0AF4(
	void* instance,
	void* anObj,
	void* aDrawer,
	bool updateviewer);
extern "C" DECL_EXPORT void AIS_InteractiveContext_SubIntensityOn7BDA0103(
	void* instance,
	void* aniobj,
	bool updateviewer);
extern "C" DECL_EXPORT void AIS_InteractiveContext_SubIntensityOff7BDA0103(
	void* instance,
	void* aniobj,
	bool updateviewer);
extern "C" DECL_EXPORT void AIS_InteractiveContext_SubIntensityOn461FC46A(
	void* instance,
	bool updateviewer);
extern "C" DECL_EXPORT void AIS_InteractiveContext_SubIntensityOff461FC46A(
	void* instance,
	bool updateviewer);
extern "C" DECL_EXPORT void AIS_InteractiveContext_AddFilter3C9475B7(
	void* instance,
	void* aFilter);
extern "C" DECL_EXPORT void AIS_InteractiveContext_RemoveFilter3C9475B7(
	void* instance,
	void* aFilter);
extern "C" DECL_EXPORT void AIS_InteractiveContext_RemoveFilters(void* instance);
extern "C" DECL_EXPORT void AIS_InteractiveContext_ActivateStandardModeC6FD32C4(
	void* instance,
	int aStandardActivation);
extern "C" DECL_EXPORT void AIS_InteractiveContext_DeactivateStandardModeC6FD32C4(
	void* instance,
	int aStandardActivation);
extern "C" DECL_EXPORT void AIS_InteractiveContext_DisplayedObjectsFB1E3476(
	void* instance,
	void* aListOfIO,
	bool OnlyFromNeutral);
extern "C" DECL_EXPORT void AIS_InteractiveContext_DisplayedObjects552A363C(
	void* instance,
	int WhichKind,
	int WhichSignature,
	void* aListOfIO,
	bool OnlyFromNeutral);
extern "C" DECL_EXPORT void AIS_InteractiveContext_ObjectsInCollector235DE22E(
	void* instance,
	void* aListOfIO);
extern "C" DECL_EXPORT void AIS_InteractiveContext_ObjectsInCollectorFB8692A(
	void* instance,
	int WhichKind,
	int WhichSignature,
	void* aListOfIO);
extern "C" DECL_EXPORT void AIS_InteractiveContext_ErasedObjects235DE22E(
	void* instance,
	void* theListOfIO);
extern "C" DECL_EXPORT void AIS_InteractiveContext_ErasedObjectsFB8692A(
	void* instance,
	int WhichKind,
	int WhichSignature,
	void* theListOfIO);
extern "C" DECL_EXPORT void AIS_InteractiveContext_ObjectsByDisplayStatusF86BDF5C(
	void* instance,
	int theStatus,
	void* theListOfIO);
extern "C" DECL_EXPORT void AIS_InteractiveContext_ObjectsByDisplayStatusB048A7AD(
	void* instance,
	int WhichKind,
	int WhichSignature,
	int theStatus,
	void* theListOfIO);
extern "C" DECL_EXPORT void AIS_InteractiveContext_ObjectsInsideC8729CEC(
	void* instance,
	void* aListOfIO,
	int WhichKind,
	int WhichSignature);
extern "C" DECL_EXPORT int AIS_InteractiveContext_PurgeDisplay461FC46A(
	void* instance,
	bool CollectorToo);
extern "C" DECL_EXPORT void AIS_InteractiveContext_DisplayActiveAreas36A6FAB7(
	void* instance,
	void* aView);
extern "C" DECL_EXPORT void AIS_InteractiveContext_ClearActiveAreas36A6FAB7(
	void* instance,
	void* aView);
extern "C" DECL_EXPORT void AIS_InteractiveContext_DisplayActiveSensitive36A6FAB7(
	void* instance,
	void* aView);
extern "C" DECL_EXPORT void AIS_InteractiveContext_ClearActiveSensitive36A6FAB7(
	void* instance,
	void* aView);
extern "C" DECL_EXPORT void AIS_InteractiveContext_DisplayActiveSensitiveC47ED7A2(
	void* instance,
	void* anObject,
	void* aView);
extern "C" DECL_EXPORT void AIS_InteractiveContext_DisplayActiveAreasC47ED7A2(
	void* instance,
	void* anObject,
	void* aView);
extern "C" DECL_EXPORT bool AIS_InteractiveContext_IsInLocal4F47E777(
	void* instance,
	void* anObject,
	int* TheIndex);
extern "C" DECL_EXPORT bool AIS_InteractiveContext_IsCollectorClosed(void* instance);
extern "C" DECL_EXPORT void AIS_InteractiveContext_SetAutoActivateSelection(void* instance, bool value);
extern "C" DECL_EXPORT bool AIS_InteractiveContext_GetAutoActivateSelection(void* instance);
extern "C" DECL_EXPORT void AIS_InteractiveContext_SetSensitivityMode(void* instance, int value);
extern "C" DECL_EXPORT int AIS_InteractiveContext_SensitivityMode(void* instance);
extern "C" DECL_EXPORT void AIS_InteractiveContext_SetSensitivity(void* instance, double value);
extern "C" DECL_EXPORT double AIS_InteractiveContext_Sensitivity(void* instance);
extern "C" DECL_EXPORT void AIS_InteractiveContext_SetPixelTolerance(void* instance, int value);
extern "C" DECL_EXPORT int AIS_InteractiveContext_PixelTolerance(void* instance);
extern "C" DECL_EXPORT int AIS_InteractiveContext_PreSelectionColor(void* instance);
extern "C" DECL_EXPORT int AIS_InteractiveContext_DefaultColor(void* instance);
extern "C" DECL_EXPORT void AIS_InteractiveContext_SetHilightColor(void* instance, int value);
extern "C" DECL_EXPORT int AIS_InteractiveContext_HilightColor(void* instance);
extern "C" DECL_EXPORT void AIS_InteractiveContext_SetPreselectionColor(void* instance, int value);
extern "C" DECL_EXPORT void AIS_InteractiveContext_SetSubIntensityColor(void* instance, int value);
extern "C" DECL_EXPORT int AIS_InteractiveContext_SubIntensityColor(void* instance);
extern "C" DECL_EXPORT void AIS_InteractiveContext_SetHLRAngle(void* instance, double value);
extern "C" DECL_EXPORT double AIS_InteractiveContext_HLRAngle(void* instance);
extern "C" DECL_EXPORT void AIS_InteractiveContext_SetHiddenLineAspect(void* instance, void* value);
extern "C" DECL_EXPORT void* AIS_InteractiveContext_HiddenLineAspect(void* instance);
extern "C" DECL_EXPORT bool AIS_InteractiveContext_DrawHiddenLine(void* instance);
extern "C" DECL_EXPORT bool AIS_InteractiveContext_HasNextDetected(void* instance);
extern "C" DECL_EXPORT void AIS_InteractiveContext_SetToHilightSelected(void* instance, bool value);
extern "C" DECL_EXPORT bool AIS_InteractiveContext_ToHilightSelected(void* instance);
extern "C" DECL_EXPORT bool AIS_InteractiveContext_WasCurrentTouched(void* instance);
extern "C" DECL_EXPORT bool AIS_InteractiveContext_MoreCurrent(void* instance);
extern "C" DECL_EXPORT void* AIS_InteractiveContext_Current(void* instance);
extern "C" DECL_EXPORT int AIS_InteractiveContext_NbCurrents(void* instance);
extern "C" DECL_EXPORT void* AIS_InteractiveContext_FirstCurrentObject(void* instance);
extern "C" DECL_EXPORT bool AIS_InteractiveContext_MoreSelected(void* instance);
extern "C" DECL_EXPORT int AIS_InteractiveContext_NbSelected(void* instance);
extern "C" DECL_EXPORT bool AIS_InteractiveContext_HasSelectedShape(void* instance);
extern "C" DECL_EXPORT void* AIS_InteractiveContext_SelectedShape(void* instance);
extern "C" DECL_EXPORT void* AIS_InteractiveContext_SelectedOwner(void* instance);
extern "C" DECL_EXPORT void* AIS_InteractiveContext_Interactive(void* instance);
extern "C" DECL_EXPORT void* AIS_InteractiveContext_SelectedInteractive(void* instance);
extern "C" DECL_EXPORT bool AIS_InteractiveContext_HasApplicative(void* instance);
extern "C" DECL_EXPORT void* AIS_InteractiveContext_Applicative(void* instance);
extern "C" DECL_EXPORT bool AIS_InteractiveContext_HasDetected(void* instance);
extern "C" DECL_EXPORT bool AIS_InteractiveContext_HasDetectedShape(void* instance);
extern "C" DECL_EXPORT void* AIS_InteractiveContext_DetectedShape(void* instance);
extern "C" DECL_EXPORT void* AIS_InteractiveContext_DetectedInteractive(void* instance);
extern "C" DECL_EXPORT void* AIS_InteractiveContext_DetectedOwner(void* instance);
extern "C" DECL_EXPORT bool AIS_InteractiveContext_MoreDetected(void* instance);
extern "C" DECL_EXPORT void* AIS_InteractiveContext_DetectedCurrentShape(void* instance);
extern "C" DECL_EXPORT void* AIS_InteractiveContext_DetectedCurrentObject(void* instance);
extern "C" DECL_EXPORT int AIS_InteractiveContext_IndexOfCurrentLocal(void* instance);
extern "C" DECL_EXPORT bool AIS_InteractiveContext_BeginImmediateDraw(void* instance);
extern "C" DECL_EXPORT bool AIS_InteractiveContext_IsImmediateModeOn(void* instance);
extern "C" DECL_EXPORT void AIS_InteractiveContext_SetAutomaticHilight(void* instance, bool value);
extern "C" DECL_EXPORT bool AIS_InteractiveContext_AutomaticHilight(void* instance);
extern "C" DECL_EXPORT void AIS_InteractiveContext_SetZDetection(void* instance, bool value);
extern "C" DECL_EXPORT bool AIS_InteractiveContext_ZDetection(void* instance);
extern "C" DECL_EXPORT void* AIS_InteractiveContext_DefaultDrawer(void* instance);
extern "C" DECL_EXPORT void* AIS_InteractiveContext_CurrentViewer(void* instance);
extern "C" DECL_EXPORT void* AIS_InteractiveContext_Collector(void* instance);
extern "C" DECL_EXPORT bool AIS_InteractiveContext_HasOpenedContext(void* instance);
extern "C" DECL_EXPORT void* AIS_InteractiveContext_CurrentName(void* instance);
extern "C" DECL_EXPORT void* AIS_InteractiveContext_SelectionName(void* instance);
extern "C" DECL_EXPORT Standard_CString AIS_InteractiveContext_DomainOfMainViewer(void* instance);
extern "C" DECL_EXPORT void* AIS_InteractiveContext_SelectionManager(void* instance);
extern "C" DECL_EXPORT void* AIS_InteractiveContext_MainPrsMgr(void* instance);
extern "C" DECL_EXPORT void* AIS_InteractiveContext_CollectorPrsMgr(void* instance);
extern "C" DECL_EXPORT void* AIS_InteractiveContext_MainSelector(void* instance);
extern "C" DECL_EXPORT void* AIS_InteractiveContext_LocalSelector(void* instance);
extern "C" DECL_EXPORT void* AIS_InteractiveContext_CollectorSelector(void* instance);
extern "C" DECL_EXPORT int AIS_InteractiveContext_HighestIndex(void* instance);
extern "C" DECL_EXPORT void AISInteractiveContext_Dtor(void* instance);

#endif
