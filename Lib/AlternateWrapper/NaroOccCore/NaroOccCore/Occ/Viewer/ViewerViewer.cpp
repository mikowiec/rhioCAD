#include "ViewerViewer.h"
#include <Viewer_Viewer.hxx>

#include <Aspect_GraphicDevice.hxx>

DECL_EXPORT void* Viewer_Viewer_Device(void* instance)
{
	Viewer_Viewer* result = (Viewer_Viewer*)(((Handle_Viewer_Viewer*)instance)->Access());
	return 	new Handle_Aspect_GraphicDevice(	result->Device());
}

DECL_EXPORT Standard_CString Viewer_Viewer_Domain(void* instance)
{
	Viewer_Viewer* result = (Viewer_Viewer*)(((Handle_Viewer_Viewer*)instance)->Access());
	return 	result->Domain();
}

DECL_EXPORT void ViewerViewer_Dtor(void* instance)
{
	delete (Handle_Viewer_Viewer*)instance;
}
