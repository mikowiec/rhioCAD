#include "ViewerView.h"
#include <Viewer_View.hxx>


DECL_EXPORT bool Viewer_View_SetImmediateUpdate461FC46A(
	void* instance,
	bool onoff)
{
	Viewer_View* result = (Viewer_View*)(((Handle_Viewer_View*)instance)->Access());
	return  	result->SetImmediateUpdate(			
onoff);
}
DECL_EXPORT void ViewerView_Dtor(void* instance)
{
	delete (Handle_Viewer_View*)instance;
}
