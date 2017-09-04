#include "Visual3dViewOrientation.h"
#include <Visual3d_ViewOrientation.hxx>

#include <Graphic3d_Vector.hxx>
#include <Graphic3d_Vertex.hxx>

DECL_EXPORT void* Visual3d_ViewOrientation_Ctor()
{
	return new Visual3d_ViewOrientation();
}
DECL_EXPORT void* Visual3d_ViewOrientation_Ctor72AC10FF(
	void* VRP,
	void* VPN,
	void* VUP)
{
		const Graphic3d_Vertex &  _VRP =*(const Graphic3d_Vertex *)VRP;
		const Graphic3d_Vector &  _VPN =*(const Graphic3d_Vector *)VPN;
		const Graphic3d_Vector &  _VUP =*(const Graphic3d_Vector *)VUP;
	return new Visual3d_ViewOrientation(			
_VRP,			
_VPN,			
_VUP);
}
DECL_EXPORT void* Visual3d_ViewOrientation_CtorBF9B1A1D(
	void* VRP,
	void* VPN,
	double Twist)
{
		const Graphic3d_Vertex &  _VRP =*(const Graphic3d_Vertex *)VRP;
		const Graphic3d_Vector &  _VPN =*(const Graphic3d_Vector *)VPN;
	return new Visual3d_ViewOrientation(			
_VRP,			
_VPN,			
Twist);
}
DECL_EXPORT void* Visual3d_ViewOrientation_Ctor346A1607(
	void* VRP,
	double Azim,
	double Inc,
	double Twist)
{
		const Graphic3d_Vertex &  _VRP =*(const Graphic3d_Vertex *)VRP;
	return new Visual3d_ViewOrientation(			
_VRP,			
Azim,			
Inc,			
Twist);
}
DECL_EXPORT void Visual3d_ViewOrientation_SetAxialScale9282A951(
	void* instance,
	double Sx,
	double Sy,
	double Sz)
{
	Visual3d_ViewOrientation* result = (Visual3d_ViewOrientation*)instance;
 	result->SetAxialScale(			
Sx,			
Sy,			
Sz);
}
DECL_EXPORT void Visual3d_ViewOrientation_AxialScale9282A951(
	void* instance,
	double* Sx,
	double* Sy,
	double* Sz)
{
	Visual3d_ViewOrientation* result = (Visual3d_ViewOrientation*)instance;
 	result->AxialScale(			
*Sx,			
*Sy,			
*Sz);
}
DECL_EXPORT double Visual3d_ViewOrientation_Twist(void* instance)
{
	Visual3d_ViewOrientation* result = (Visual3d_ViewOrientation*)instance;
	return 	result->Twist();
}

DECL_EXPORT void Visual3d_ViewOrientation_SetViewReferencePlane(void* instance, void* value)
{
	Visual3d_ViewOrientation* result = (Visual3d_ViewOrientation*)instance;
		result->SetViewReferencePlane(*(const Graphic3d_Vector *)value);
}

DECL_EXPORT void* Visual3d_ViewOrientation_ViewReferencePlane(void* instance)
{
	Visual3d_ViewOrientation* result = (Visual3d_ViewOrientation*)instance;
	return 	new Graphic3d_Vector(	result->ViewReferencePlane());
}

DECL_EXPORT void Visual3d_ViewOrientation_SetViewReferencePoint(void* instance, void* value)
{
	Visual3d_ViewOrientation* result = (Visual3d_ViewOrientation*)instance;
		result->SetViewReferencePoint(*(const Graphic3d_Vertex *)value);
}

DECL_EXPORT void* Visual3d_ViewOrientation_ViewReferencePoint(void* instance)
{
	Visual3d_ViewOrientation* result = (Visual3d_ViewOrientation*)instance;
	return 	new Graphic3d_Vertex(	result->ViewReferencePoint());
}

DECL_EXPORT void Visual3d_ViewOrientation_SetViewReferenceUp(void* instance, void* value)
{
	Visual3d_ViewOrientation* result = (Visual3d_ViewOrientation*)instance;
		result->SetViewReferenceUp(*(const Graphic3d_Vector *)value);
}

DECL_EXPORT void* Visual3d_ViewOrientation_ViewReferenceUp(void* instance)
{
	Visual3d_ViewOrientation* result = (Visual3d_ViewOrientation*)instance;
	return 	new Graphic3d_Vector(	result->ViewReferenceUp());
}

DECL_EXPORT bool Visual3d_ViewOrientation_IsCustomMatrix(void* instance)
{
	Visual3d_ViewOrientation* result = (Visual3d_ViewOrientation*)instance;
	return 	result->IsCustomMatrix();
}

DECL_EXPORT void Visual3dViewOrientation_Dtor(void* instance)
{
	delete (Visual3d_ViewOrientation*)instance;
}
