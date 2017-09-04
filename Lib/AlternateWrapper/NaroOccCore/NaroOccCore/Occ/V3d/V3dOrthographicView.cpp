#include "V3dOrthographicView.h"
#include <V3d_OrthographicView.hxx>

#include <V3d_OrthographicView.hxx>

DECL_EXPORT void* V3d_OrthographicView_Ctor79560492(
	void* VM)
{
		const Handle_V3d_Viewer&  _VM =*(const Handle_V3d_Viewer *)VM;
	return new Handle_V3d_OrthographicView(new V3d_OrthographicView(			
_VM));
}
DECL_EXPORT void* V3d_OrthographicView_Ctor4B0A5FC8(
	void* VM,
	void* V)
{
		const Handle_V3d_Viewer&  _VM =*(const Handle_V3d_Viewer *)VM;
		const Handle_V3d_PerspectiveView&  _V =*(const Handle_V3d_PerspectiveView *)V;
	return new Handle_V3d_OrthographicView(new V3d_OrthographicView(			
_VM,			
_V));
}
DECL_EXPORT void* V3d_OrthographicView_Ctor4E6B6F5D(
	void* VM,
	void* V)
{
		const Handle_V3d_Viewer&  _VM =*(const Handle_V3d_Viewer *)VM;
		const Handle_V3d_OrthographicView&  _V =*(const Handle_V3d_OrthographicView *)V;
	return new Handle_V3d_OrthographicView(new V3d_OrthographicView(			
_VM,			
_V));
}
DECL_EXPORT void* V3d_OrthographicView_Copy(void* instance)
{
	V3d_OrthographicView* result = (V3d_OrthographicView*)(((Handle_V3d_OrthographicView*)instance)->Access());
	return 	new Handle_V3d_OrthographicView(	result->Copy());
}

DECL_EXPORT void V3dOrthographicView_Dtor(void* instance)
{
	delete (Handle_V3d_OrthographicView*)instance;
}
