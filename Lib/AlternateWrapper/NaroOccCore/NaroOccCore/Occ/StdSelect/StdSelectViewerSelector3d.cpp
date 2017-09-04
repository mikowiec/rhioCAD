#include "StdSelectViewerSelector3d.h"
#include <StdSelect_ViewerSelector3d.hxx>


DECL_EXPORT void* StdSelect_ViewerSelector3d_Ctor()
{
	return new Handle_StdSelect_ViewerSelector3d(new StdSelect_ViewerSelector3d());
}
DECL_EXPORT void StdSelect_ViewerSelector3d_ConvertD1B6659F(
	void* instance,
	void* aSelection)
{
		const Handle_SelectMgr_Selection&  _aSelection =*(const Handle_SelectMgr_Selection *)aSelection;
	StdSelect_ViewerSelector3d* result = (StdSelect_ViewerSelector3d*)(((Handle_StdSelect_ViewerSelector3d*)instance)->Access());
 	result->Convert(			
_aSelection);
}
DECL_EXPORT void StdSelect_ViewerSelector3d_Pick556D776C(
	void* instance,
	int XPix,
	int YPix,
	void* aView)
{
		const Handle_V3d_View&  _aView =*(const Handle_V3d_View *)aView;
	StdSelect_ViewerSelector3d* result = (StdSelect_ViewerSelector3d*)(((Handle_StdSelect_ViewerSelector3d*)instance)->Access());
 	result->Pick(			
XPix,			
YPix,			
_aView);
}
DECL_EXPORT void StdSelect_ViewerSelector3d_Pick12E48EEC(
	void* instance,
	int XPMin,
	int YPMin,
	int XPMax,
	int YPMax,
	void* aView)
{
		const Handle_V3d_View&  _aView =*(const Handle_V3d_View *)aView;
	StdSelect_ViewerSelector3d* result = (StdSelect_ViewerSelector3d*)(((Handle_StdSelect_ViewerSelector3d*)instance)->Access());
 	result->Pick(			
XPMin,			
YPMin,			
XPMax,			
YPMax,			
_aView);
}
DECL_EXPORT void StdSelect_ViewerSelector3d_ReactivateProjector(void* instance)
{
	StdSelect_ViewerSelector3d* result = (StdSelect_ViewerSelector3d*)(((Handle_StdSelect_ViewerSelector3d*)instance)->Access());
 	result->ReactivateProjector();
}
DECL_EXPORT void StdSelect_ViewerSelector3d_DisplayAreas36A6FAB7(
	void* instance,
	void* aView)
{
		const Handle_V3d_View&  _aView =*(const Handle_V3d_View *)aView;
	StdSelect_ViewerSelector3d* result = (StdSelect_ViewerSelector3d*)(((Handle_StdSelect_ViewerSelector3d*)instance)->Access());
 	result->DisplayAreas(			
_aView);
}
DECL_EXPORT void StdSelect_ViewerSelector3d_ClearAreas36A6FAB7(
	void* instance,
	void* aView)
{
		const Handle_V3d_View&  _aView =*(const Handle_V3d_View *)aView;
	StdSelect_ViewerSelector3d* result = (StdSelect_ViewerSelector3d*)(((Handle_StdSelect_ViewerSelector3d*)instance)->Access());
 	result->ClearAreas(			
_aView);
}
DECL_EXPORT void StdSelect_ViewerSelector3d_DisplaySensitive36A6FAB7(
	void* instance,
	void* aView)
{
		const Handle_V3d_View&  _aView =*(const Handle_V3d_View *)aView;
	StdSelect_ViewerSelector3d* result = (StdSelect_ViewerSelector3d*)(((Handle_StdSelect_ViewerSelector3d*)instance)->Access());
 	result->DisplaySensitive(			
_aView);
}
DECL_EXPORT void StdSelect_ViewerSelector3d_ClearSensitive36A6FAB7(
	void* instance,
	void* aView)
{
		const Handle_V3d_View&  _aView =*(const Handle_V3d_View *)aView;
	StdSelect_ViewerSelector3d* result = (StdSelect_ViewerSelector3d*)(((Handle_StdSelect_ViewerSelector3d*)instance)->Access());
 	result->ClearSensitive(			
_aView);
}
DECL_EXPORT void StdSelect_ViewerSelector3d_DisplaySensitiveE07C6821(
	void* instance,
	void* aSel,
	void* aView,
	bool ClearOthers)
{
		const Handle_SelectMgr_Selection&  _aSel =*(const Handle_SelectMgr_Selection *)aSel;
		const Handle_V3d_View&  _aView =*(const Handle_V3d_View *)aView;
	StdSelect_ViewerSelector3d* result = (StdSelect_ViewerSelector3d*)(((Handle_StdSelect_ViewerSelector3d*)instance)->Access());
 	result->DisplaySensitive(			
_aSel,			
_aView,			
ClearOthers);
}
DECL_EXPORT void StdSelect_ViewerSelector3d_DisplayAreasE07C6821(
	void* instance,
	void* aSel,
	void* aView,
	bool ClearOthers)
{
		const Handle_SelectMgr_Selection&  _aSel =*(const Handle_SelectMgr_Selection *)aSel;
		const Handle_V3d_View&  _aView =*(const Handle_V3d_View *)aView;
	StdSelect_ViewerSelector3d* result = (StdSelect_ViewerSelector3d*)(((Handle_StdSelect_ViewerSelector3d*)instance)->Access());
 	result->DisplayAreas(			
_aSel,			
_aView,			
ClearOthers);
}
DECL_EXPORT void StdSelect_ViewerSelector3d_SetSensitivityMode(void* instance, int value)
{
	StdSelect_ViewerSelector3d* result = (StdSelect_ViewerSelector3d*)(((Handle_StdSelect_ViewerSelector3d*)instance)->Access());
		result->SetSensitivityMode((const StdSelect_SensitivityMode)value);
}

DECL_EXPORT int StdSelect_ViewerSelector3d_SensitivityMode(void* instance)
{
	StdSelect_ViewerSelector3d* result = (StdSelect_ViewerSelector3d*)(((Handle_StdSelect_ViewerSelector3d*)instance)->Access());
	return (int)	result->SensitivityMode();
}

DECL_EXPORT void StdSelect_ViewerSelector3d_SetPixelTolerance(void* instance, int value)
{
	StdSelect_ViewerSelector3d* result = (StdSelect_ViewerSelector3d*)(((Handle_StdSelect_ViewerSelector3d*)instance)->Access());
		result->SetPixelTolerance(value);
}

DECL_EXPORT int StdSelect_ViewerSelector3d_PixelTolerance(void* instance)
{
	StdSelect_ViewerSelector3d* result = (StdSelect_ViewerSelector3d*)(((Handle_StdSelect_ViewerSelector3d*)instance)->Access());
	return 	result->PixelTolerance();
}

DECL_EXPORT void StdSelectViewerSelector3d_Dtor(void* instance)
{
	delete (Handle_StdSelect_ViewerSelector3d*)instance;
}
