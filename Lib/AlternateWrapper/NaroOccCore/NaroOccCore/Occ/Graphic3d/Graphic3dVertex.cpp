#include "Graphic3dVertex.h"
#include <Graphic3d_Vertex.hxx>


DECL_EXPORT void* Graphic3d_Vertex_Ctor()
{
	return new Graphic3d_Vertex();
}
DECL_EXPORT void* Graphic3d_Vertex_CtorC6E2F35B(
	void* APoint)
{
		const Graphic3d_Vertex &  _APoint =*(const Graphic3d_Vertex *)APoint;
	return new Graphic3d_Vertex(			
_APoint);
}
DECL_EXPORT void* Graphic3d_Vertex_Ctor9282A951(
	double AX,
	double AY,
	double AZ)
{
	return new Graphic3d_Vertex(			
AX,			
AY,			
AZ);
}
DECL_EXPORT void Graphic3d_Vertex_SetCoord9282A951(
	void* instance,
	double Xnew,
	double Ynew,
	double Znew)
{
	Graphic3d_Vertex* result = (Graphic3d_Vertex*)instance;
 	result->SetCoord(			
Xnew,			
Ynew,			
Znew);
}
DECL_EXPORT void Graphic3d_Vertex_Coord9282A951(
	void* instance,
	double* AX,
	double* AY,
	double* AZ)
{
	Graphic3d_Vertex* result = (Graphic3d_Vertex*)instance;
 	result->Coord(			
*AX,			
*AY,			
*AZ);
}
DECL_EXPORT double Graphic3d_Vertex_Distance29D8F78D(
	void* AV1,
	void* AV2)
{
		const Graphic3d_Vertex &  _AV1 =*(const Graphic3d_Vertex *)AV1;
		const Graphic3d_Vertex &  _AV2 =*(const Graphic3d_Vertex *)AV2;
	return  Graphic3d_Vertex::Distance(			
_AV1,			
_AV2);
}
DECL_EXPORT void Graphic3d_Vertex_SetXCoord(void* instance, double value)
{
	Graphic3d_Vertex* result = (Graphic3d_Vertex*)instance;
		result->SetXCoord(value);
}

DECL_EXPORT void Graphic3d_Vertex_SetYCoord(void* instance, double value)
{
	Graphic3d_Vertex* result = (Graphic3d_Vertex*)instance;
		result->SetYCoord(value);
}

DECL_EXPORT void Graphic3d_Vertex_SetZCoord(void* instance, double value)
{
	Graphic3d_Vertex* result = (Graphic3d_Vertex*)instance;
		result->SetZCoord(value);
}

DECL_EXPORT double Graphic3d_Vertex_X(void* instance)
{
	Graphic3d_Vertex* result = (Graphic3d_Vertex*)instance;
	return 	result->X();
}

DECL_EXPORT double Graphic3d_Vertex_Y(void* instance)
{
	Graphic3d_Vertex* result = (Graphic3d_Vertex*)instance;
	return 	result->Y();
}

DECL_EXPORT double Graphic3d_Vertex_Z(void* instance)
{
	Graphic3d_Vertex* result = (Graphic3d_Vertex*)instance;
	return 	result->Z();
}

DECL_EXPORT void Graphic3dVertex_Dtor(void* instance)
{
	delete (Graphic3d_Vertex*)instance;
}
