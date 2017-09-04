#include "V3dPlane.h"
#include <V3d_Plane.hxx>


DECL_EXPORT void* V3d_Plane_CtorC2777E0C(
	double A,
	double B,
	double C,
	double D)
{
	return new Handle_V3d_Plane(new V3d_Plane(			
A,			
B,			
C,			
D));
}
DECL_EXPORT void V3d_Plane_SetPlaneC2777E0C(
	void* instance,
	double A,
	double B,
	double C,
	double D)
{
	V3d_Plane* result = (V3d_Plane*)(((Handle_V3d_Plane*)instance)->Access());
 	result->SetPlane(			
A,			
B,			
C,			
D);
}
DECL_EXPORT void V3d_Plane_Display8A383826(
	void* instance,
	void* aView,
	void* aColor)
{
		const Handle_V3d_View&  _aView =*(const Handle_V3d_View *)aView;
		const Quantity_Color &  _aColor =*(const Quantity_Color *)aColor;
	V3d_Plane* result = (V3d_Plane*)(((Handle_V3d_Plane*)instance)->Access());
 	result->Display(			
_aView,			
_aColor);
}
DECL_EXPORT void V3d_Plane_Erase(void* instance)
{
	V3d_Plane* result = (V3d_Plane*)(((Handle_V3d_Plane*)instance)->Access());
 	result->Erase();
}
DECL_EXPORT void V3d_Plane_PlaneC2777E0C(
	void* instance,
	double* A,
	double* B,
	double* C,
	double* D)
{
	V3d_Plane* result = (V3d_Plane*)(((Handle_V3d_Plane*)instance)->Access());
 	result->Plane(			
*A,			
*B,			
*C,			
*D);
}
DECL_EXPORT bool V3d_Plane_IsDisplayed(void* instance)
{
	V3d_Plane* result = (V3d_Plane*)(((Handle_V3d_Plane*)instance)->Access());
	return 	result->IsDisplayed();
}

DECL_EXPORT void V3dPlane_Dtor(void* instance)
{
	delete (Handle_V3d_Plane*)instance;
}
