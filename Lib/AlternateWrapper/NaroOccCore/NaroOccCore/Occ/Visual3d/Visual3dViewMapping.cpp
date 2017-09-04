#include "Visual3dViewMapping.h"
#include <Visual3d_ViewMapping.hxx>

#include <Graphic3d_Vertex.hxx>

DECL_EXPORT void* Visual3d_ViewMapping_Ctor()
{
	return new Visual3d_ViewMapping();
}
DECL_EXPORT void* Visual3d_ViewMapping_Ctor65BCDE62(
	int AType,
	void* PRP,
	double BPD,
	double FPD,
	double VPD,
	double WUmin,
	double WVmin,
	double WUmax,
	double WVmax)
{
		const Visual3d_TypeOfProjection _AType =(const Visual3d_TypeOfProjection )AType;
		const Graphic3d_Vertex &  _PRP =*(const Graphic3d_Vertex *)PRP;
	return new Visual3d_ViewMapping(			
_AType,			
_PRP,			
BPD,			
FPD,			
VPD,			
WUmin,			
WVmin,			
WUmax,			
WVmax);
}
DECL_EXPORT void Visual3d_ViewMapping_SetWindowLimitC2777E0C(
	void* instance,
	double Umin,
	double Vmin,
	double Umax,
	double Vmax)
{
	Visual3d_ViewMapping* result = (Visual3d_ViewMapping*)instance;
 	result->SetWindowLimit(			
Umin,			
Vmin,			
Umax,			
Vmax);
}
DECL_EXPORT void Visual3d_ViewMapping_WindowLimitC2777E0C(
	void* instance,
	double* Umin,
	double* Vmin,
	double* Umax,
	double* Vmax)
{
	Visual3d_ViewMapping* result = (Visual3d_ViewMapping*)instance;
 	result->WindowLimit(			
*Umin,			
*Vmin,			
*Umax,			
*Vmax);
}
DECL_EXPORT void Visual3d_ViewMapping_SetBackPlaneDistance(void* instance, double value)
{
	Visual3d_ViewMapping* result = (Visual3d_ViewMapping*)instance;
		result->SetBackPlaneDistance(value);
}

DECL_EXPORT double Visual3d_ViewMapping_BackPlaneDistance(void* instance)
{
	Visual3d_ViewMapping* result = (Visual3d_ViewMapping*)instance;
	return 	result->BackPlaneDistance();
}

DECL_EXPORT void Visual3d_ViewMapping_SetFrontPlaneDistance(void* instance, double value)
{
	Visual3d_ViewMapping* result = (Visual3d_ViewMapping*)instance;
		result->SetFrontPlaneDistance(value);
}

DECL_EXPORT double Visual3d_ViewMapping_FrontPlaneDistance(void* instance)
{
	Visual3d_ViewMapping* result = (Visual3d_ViewMapping*)instance;
	return 	result->FrontPlaneDistance();
}

DECL_EXPORT void Visual3d_ViewMapping_SetProjection(void* instance, int value)
{
	Visual3d_ViewMapping* result = (Visual3d_ViewMapping*)instance;
		result->SetProjection((const Visual3d_TypeOfProjection)value);
}

DECL_EXPORT int Visual3d_ViewMapping_Projection(void* instance)
{
	Visual3d_ViewMapping* result = (Visual3d_ViewMapping*)instance;
	return (int)	result->Projection();
}

DECL_EXPORT void Visual3d_ViewMapping_SetProjectionReferencePoint(void* instance, void* value)
{
	Visual3d_ViewMapping* result = (Visual3d_ViewMapping*)instance;
		result->SetProjectionReferencePoint(*(const Graphic3d_Vertex *)value);
}

DECL_EXPORT void* Visual3d_ViewMapping_ProjectionReferencePoint(void* instance)
{
	Visual3d_ViewMapping* result = (Visual3d_ViewMapping*)instance;
	return 	new Graphic3d_Vertex(	result->ProjectionReferencePoint());
}

DECL_EXPORT void Visual3d_ViewMapping_SetViewPlaneDistance(void* instance, double value)
{
	Visual3d_ViewMapping* result = (Visual3d_ViewMapping*)instance;
		result->SetViewPlaneDistance(value);
}

DECL_EXPORT double Visual3d_ViewMapping_ViewPlaneDistance(void* instance)
{
	Visual3d_ViewMapping* result = (Visual3d_ViewMapping*)instance;
	return 	result->ViewPlaneDistance();
}

DECL_EXPORT bool Visual3d_ViewMapping_IsCustomMatrix(void* instance)
{
	Visual3d_ViewMapping* result = (Visual3d_ViewMapping*)instance;
	return 	result->IsCustomMatrix();
}

DECL_EXPORT void Visual3dViewMapping_Dtor(void* instance)
{
	delete (Visual3d_ViewMapping*)instance;
}
