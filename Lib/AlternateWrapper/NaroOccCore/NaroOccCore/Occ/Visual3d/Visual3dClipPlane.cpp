#include "Visual3dClipPlane.h"
#include <Visual3d_ClipPlane.hxx>


DECL_EXPORT void* Visual3d_ClipPlane_CtorC2777E0C(
	double ACoefA,
	double ACoefB,
	double ACoefC,
	double ACoefD)
{
	return new Handle_Visual3d_ClipPlane(new Visual3d_ClipPlane(			
ACoefA,			
ACoefB,			
ACoefC,			
ACoefD));
}
DECL_EXPORT void Visual3d_ClipPlane_SetPlaneC2777E0C(
	void* instance,
	double ACoefA,
	double ACoefB,
	double ACoefC,
	double ACoefD)
{
	Visual3d_ClipPlane* result = (Visual3d_ClipPlane*)(((Handle_Visual3d_ClipPlane*)instance)->Access());
 	result->SetPlane(			
ACoefA,			
ACoefB,			
ACoefC,			
ACoefD);
}
DECL_EXPORT void Visual3d_ClipPlane_PlaneC2777E0C(
	void* instance,
	double* ACoefA,
	double* ACoefB,
	double* ACoefC,
	double* ACoefD)
{
	Visual3d_ClipPlane* result = (Visual3d_ClipPlane*)(((Handle_Visual3d_ClipPlane*)instance)->Access());
 	result->Plane(			
*ACoefA,			
*ACoefB,			
*ACoefC,			
*ACoefD);
}
DECL_EXPORT int Visual3d_ClipPlane_Limit()
{
	return Visual3d_ClipPlane::Limit();
}

DECL_EXPORT void Visual3dClipPlane_Dtor(void* instance)
{
	delete (Handle_Visual3d_ClipPlane*)instance;
}
