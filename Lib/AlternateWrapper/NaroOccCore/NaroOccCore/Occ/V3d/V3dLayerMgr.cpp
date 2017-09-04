#include "V3dLayerMgr.h"
#include <V3d_LayerMgr.hxx>

#include <V3d_View.hxx>
#include <Visual3d_Layer.hxx>

DECL_EXPORT void* V3d_LayerMgr_Ctor36A6FAB7(
	void* aView)
{
		const Handle_V3d_View&  _aView =*(const Handle_V3d_View *)aView;
	return new Handle_V3d_LayerMgr(new V3d_LayerMgr(			
_aView));
}
DECL_EXPORT void V3d_LayerMgr_ColorScaleDisplay(void* instance)
{
	V3d_LayerMgr* result = (V3d_LayerMgr*)(((Handle_V3d_LayerMgr*)instance)->Access());
 	result->ColorScaleDisplay();
}
DECL_EXPORT void V3d_LayerMgr_ColorScaleErase(void* instance)
{
	V3d_LayerMgr* result = (V3d_LayerMgr*)(((Handle_V3d_LayerMgr*)instance)->Access());
 	result->ColorScaleErase();
}
DECL_EXPORT void V3d_LayerMgr_Compute(void* instance)
{
	V3d_LayerMgr* result = (V3d_LayerMgr*)(((Handle_V3d_LayerMgr*)instance)->Access());
 	result->Compute();
}
DECL_EXPORT void V3d_LayerMgr_Resized(void* instance)
{
	V3d_LayerMgr* result = (V3d_LayerMgr*)(((Handle_V3d_LayerMgr*)instance)->Access());
 	result->Resized();
}
DECL_EXPORT void* V3d_LayerMgr_Overlay(void* instance)
{
	V3d_LayerMgr* result = (V3d_LayerMgr*)(((Handle_V3d_LayerMgr*)instance)->Access());
	return 	new Handle_Visual3d_Layer(	result->Overlay());
}

DECL_EXPORT void* V3d_LayerMgr_View(void* instance)
{
	V3d_LayerMgr* result = (V3d_LayerMgr*)(((Handle_V3d_LayerMgr*)instance)->Access());
	return 	new Handle_V3d_View(	result->View());
}

DECL_EXPORT bool V3d_LayerMgr_ColorScaleIsDisplayed(void* instance)
{
	V3d_LayerMgr* result = (V3d_LayerMgr*)(((Handle_V3d_LayerMgr*)instance)->Access());
	return 	result->ColorScaleIsDisplayed();
}

DECL_EXPORT void V3dLayerMgr_Dtor(void* instance)
{
	delete (Handle_V3d_LayerMgr*)instance;
}
