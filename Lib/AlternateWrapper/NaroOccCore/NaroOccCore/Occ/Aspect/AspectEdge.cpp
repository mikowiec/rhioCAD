#include "AspectEdge.h"
#include <Aspect_Edge.hxx>


DECL_EXPORT void* Aspect_Edge_Ctor()
{
	return new Aspect_Edge();
}
DECL_EXPORT void* Aspect_Edge_Ctor7A0E4278(
	int AIndex1,
	int AIndex2,
	int AType)
{
		const Aspect_TypeOfEdge _AType =(const Aspect_TypeOfEdge )AType;
	return new Aspect_Edge(			
AIndex1,			
AIndex2,			
_AType);
}
DECL_EXPORT int Aspect_Edge_FirstIndex(void* instance)
{
	Aspect_Edge* result = (Aspect_Edge*)instance;
	return 	result->FirstIndex();
}

DECL_EXPORT int Aspect_Edge_LastIndex(void* instance)
{
	Aspect_Edge* result = (Aspect_Edge*)instance;
	return 	result->LastIndex();
}

DECL_EXPORT int Aspect_Edge_Type(void* instance)
{
	Aspect_Edge* result = (Aspect_Edge*)instance;
	return (int)	result->Type();
}

DECL_EXPORT void AspectEdge_Dtor(void* instance)
{
	delete (Aspect_Edge*)instance;
}
