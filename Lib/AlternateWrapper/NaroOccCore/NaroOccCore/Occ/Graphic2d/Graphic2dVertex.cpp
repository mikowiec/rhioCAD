#include "Graphic2dVertex.h"
#include <Graphic2d_Vertex.hxx>


DECL_EXPORT void* Graphic2d_Vertex_Ctor()
{
	return new Graphic2d_Vertex();
}
DECL_EXPORT void* Graphic2d_Vertex_Ctor9F0E714F(
	double AX,
	double AY)
{
	return new Graphic2d_Vertex(			
AX,			
AY);
}
DECL_EXPORT void Graphic2d_Vertex_SetCoord9F0E714F(
	void* instance,
	double Xnew,
	double Ynew)
{
	Graphic2d_Vertex* result = (Graphic2d_Vertex*)instance;
 	result->SetCoord(			
Xnew,			
Ynew);
}
DECL_EXPORT void Graphic2d_Vertex_Coord9F0E714F(
	void* instance,
	double* AX,
	double* AY)
{
	Graphic2d_Vertex* result = (Graphic2d_Vertex*)instance;
 	result->Coord(			
*AX,			
*AY);
}
DECL_EXPORT bool Graphic2d_Vertex_IsEqualC6E2F71C(
	void* instance,
	void* other)
{
		const Graphic2d_Vertex &  _other =*(const Graphic2d_Vertex *)other;
	Graphic2d_Vertex* result = (Graphic2d_Vertex*)instance;
	return  	result->IsEqual(			
_other);
}
DECL_EXPORT double Graphic2d_Vertex_Distance693D9ECB(
	void* AV1,
	void* AV2)
{
		const Graphic2d_Vertex &  _AV1 =*(const Graphic2d_Vertex *)AV1;
		const Graphic2d_Vertex &  _AV2 =*(const Graphic2d_Vertex *)AV2;
	return  Graphic2d_Vertex::Distance(			
_AV1,			
_AV2);
}
DECL_EXPORT void Graphic2d_Vertex_SetXCoord(void* instance, double value)
{
	Graphic2d_Vertex* result = (Graphic2d_Vertex*)instance;
		result->SetXCoord(value);
}

DECL_EXPORT void Graphic2d_Vertex_SetYCoord(void* instance, double value)
{
	Graphic2d_Vertex* result = (Graphic2d_Vertex*)instance;
		result->SetYCoord(value);
}

DECL_EXPORT double Graphic2d_Vertex_X(void* instance)
{
	Graphic2d_Vertex* result = (Graphic2d_Vertex*)instance;
	return 	result->X();
}

DECL_EXPORT double Graphic2d_Vertex_Y(void* instance)
{
	Graphic2d_Vertex* result = (Graphic2d_Vertex*)instance;
	return 	result->Y();
}

DECL_EXPORT void Graphic2dVertex_Dtor(void* instance)
{
	delete (Graphic2d_Vertex*)instance;
}
