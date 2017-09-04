#include "V3dPerspectiveView.h"
#include <V3d_PerspectiveView.hxx>

#include <V3d_PerspectiveView.hxx>

DECL_EXPORT void* V3d_PerspectiveView_Ctor79560492(
	void* VM)
{
		const Handle_V3d_Viewer&  _VM =*(const Handle_V3d_Viewer *)VM;
	return new Handle_V3d_PerspectiveView(new V3d_PerspectiveView(			
_VM));
}
DECL_EXPORT void* V3d_PerspectiveView_Ctor4E6B6F5D(
	void* VM,
	void* V)
{
		const Handle_V3d_Viewer&  _VM =*(const Handle_V3d_Viewer *)VM;
		const Handle_V3d_OrthographicView&  _V =*(const Handle_V3d_OrthographicView *)V;
	return new Handle_V3d_PerspectiveView(new V3d_PerspectiveView(			
_VM,			
_V));
}
DECL_EXPORT void* V3d_PerspectiveView_Ctor4B0A5FC8(
	void* VM,
	void* V)
{
		const Handle_V3d_Viewer&  _VM =*(const Handle_V3d_Viewer *)VM;
		const Handle_V3d_PerspectiveView&  _V =*(const Handle_V3d_PerspectiveView *)V;
	return new Handle_V3d_PerspectiveView(new V3d_PerspectiveView(			
_VM,			
_V));
}
DECL_EXPORT void V3d_PerspectiveView_SetPerspectiveC2777E0C(
	void* instance,
	double Angle,
	double UVRatio,
	double ZNear,
	double ZFar)
{
	V3d_PerspectiveView* result = (V3d_PerspectiveView*)(((Handle_V3d_PerspectiveView*)instance)->Access());
 	result->SetPerspective(			
Angle,			
UVRatio,			
ZNear,			
ZFar);
}
DECL_EXPORT void* V3d_PerspectiveView_Copy(void* instance)
{
	V3d_PerspectiveView* result = (V3d_PerspectiveView*)(((Handle_V3d_PerspectiveView*)instance)->Access());
	return 	new Handle_V3d_PerspectiveView(	result->Copy());
}

DECL_EXPORT void V3d_PerspectiveView_SetAngle(void* instance, double value)
{
	V3d_PerspectiveView* result = (V3d_PerspectiveView*)(((Handle_V3d_PerspectiveView*)instance)->Access());
		result->SetAngle(value);
}

DECL_EXPORT double V3d_PerspectiveView_Angle(void* instance)
{
	V3d_PerspectiveView* result = (V3d_PerspectiveView*)(((Handle_V3d_PerspectiveView*)instance)->Access());
	return 	result->Angle();
}

DECL_EXPORT void V3dPerspectiveView_Dtor(void* instance)
{
	delete (Handle_V3d_PerspectiveView*)instance;
}
