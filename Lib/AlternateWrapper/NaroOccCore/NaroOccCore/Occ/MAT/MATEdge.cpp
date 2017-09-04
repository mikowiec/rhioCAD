#include "MATEdge.h"
#include <MAT_Edge.hxx>

#include <MAT_Bisector.hxx>

DECL_EXPORT void* MAT_Edge_Ctor()
{
	return new Handle_MAT_Edge(new MAT_Edge());
}
DECL_EXPORT void MAT_Edge_EdgeNumberE8219145(
	void* instance,
	int anumber)
{
	MAT_Edge* result = (MAT_Edge*)(((Handle_MAT_Edge*)instance)->Access());
 	result->EdgeNumber(			
anumber);
}
DECL_EXPORT void MAT_Edge_FirstBisector1F24E859(
	void* instance,
	void* abisector)
{
		const Handle_MAT_Bisector&  _abisector =*(const Handle_MAT_Bisector *)abisector;
	MAT_Edge* result = (MAT_Edge*)(((Handle_MAT_Edge*)instance)->Access());
 	result->FirstBisector(			
_abisector);
}
DECL_EXPORT void MAT_Edge_SecondBisector1F24E859(
	void* instance,
	void* abisector)
{
		const Handle_MAT_Bisector&  _abisector =*(const Handle_MAT_Bisector *)abisector;
	MAT_Edge* result = (MAT_Edge*)(((Handle_MAT_Edge*)instance)->Access());
 	result->SecondBisector(			
_abisector);
}
DECL_EXPORT void MAT_Edge_DistanceD82819F3(
	void* instance,
	double adistance)
{
	MAT_Edge* result = (MAT_Edge*)(((Handle_MAT_Edge*)instance)->Access());
 	result->Distance(			
adistance);
}
DECL_EXPORT void MAT_Edge_IntersectionPointE8219145(
	void* instance,
	int apoint)
{
	MAT_Edge* result = (MAT_Edge*)(((Handle_MAT_Edge*)instance)->Access());
 	result->IntersectionPoint(			
apoint);
}
DECL_EXPORT int MAT_Edge_EdgeNumber(void* instance)
{
	MAT_Edge* result = (MAT_Edge*)(((Handle_MAT_Edge*)instance)->Access());
	return  	result->EdgeNumber();
}
DECL_EXPORT void* MAT_Edge_FirstBisector(void* instance)
{
	MAT_Edge* result = (MAT_Edge*)(((Handle_MAT_Edge*)instance)->Access());
	return new Handle_MAT_Bisector( 	result->FirstBisector());
}
DECL_EXPORT void* MAT_Edge_SecondBisector(void* instance)
{
	MAT_Edge* result = (MAT_Edge*)(((Handle_MAT_Edge*)instance)->Access());
	return new Handle_MAT_Bisector( 	result->SecondBisector());
}
DECL_EXPORT double MAT_Edge_Distance(void* instance)
{
	MAT_Edge* result = (MAT_Edge*)(((Handle_MAT_Edge*)instance)->Access());
	return  	result->Distance();
}
DECL_EXPORT int MAT_Edge_IntersectionPoint(void* instance)
{
	MAT_Edge* result = (MAT_Edge*)(((Handle_MAT_Edge*)instance)->Access());
	return  	result->IntersectionPoint();
}
DECL_EXPORT void MAT_Edge_Dump5107F6FE(
	void* instance,
	int ashift,
	int alevel)
{
	MAT_Edge* result = (MAT_Edge*)(((Handle_MAT_Edge*)instance)->Access());
 	result->Dump(			
ashift,			
alevel);
}
DECL_EXPORT void MATEdge_Dtor(void* instance)
{
	delete (Handle_MAT_Edge*)instance;
}
