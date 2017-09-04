#include "Visual3dLayerItem.h"
#include <Visual3d_LayerItem.hxx>


DECL_EXPORT void* Visual3d_LayerItem_Ctor()
{
	return new Handle_Visual3d_LayerItem(new Visual3d_LayerItem());
}
DECL_EXPORT void Visual3d_LayerItem_ComputeLayerPrs(void* instance)
{
	Visual3d_LayerItem* result = (Visual3d_LayerItem*)(((Handle_Visual3d_LayerItem*)instance)->Access());
 	result->ComputeLayerPrs();
}
DECL_EXPORT void Visual3d_LayerItem_RedrawLayerPrs(void* instance)
{
	Visual3d_LayerItem* result = (Visual3d_LayerItem*)(((Handle_Visual3d_LayerItem*)instance)->Access());
 	result->RedrawLayerPrs();
}
DECL_EXPORT bool Visual3d_LayerItem_IsNeedToRecompute(void* instance)
{
	Visual3d_LayerItem* result = (Visual3d_LayerItem*)(((Handle_Visual3d_LayerItem*)instance)->Access());
	return 	result->IsNeedToRecompute();
}

DECL_EXPORT void Visual3d_LayerItem_SetNeedToRecompute(void* instance, bool value)
{
	Visual3d_LayerItem* result = (Visual3d_LayerItem*)(((Handle_Visual3d_LayerItem*)instance)->Access());
		result->SetNeedToRecompute(value);
}

DECL_EXPORT void Visual3dLayerItem_Dtor(void* instance)
{
	delete (Handle_Visual3d_LayerItem*)instance;
}
