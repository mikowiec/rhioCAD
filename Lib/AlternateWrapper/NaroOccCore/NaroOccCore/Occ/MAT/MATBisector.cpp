#include "MATBisector.h"
#include <MAT_Bisector.hxx>

#include <MAT_Bisector.hxx>
#include <MAT_Edge.hxx>
#include <MAT_ListOfBisector.hxx>

DECL_EXPORT void* MAT_Bisector_Ctor()
{
	return new Handle_MAT_Bisector(new MAT_Bisector());
}
DECL_EXPORT void MAT_Bisector_AddBisector1F24E859(
	void* instance,
	void* abisector)
{
		const Handle_MAT_Bisector&  _abisector =*(const Handle_MAT_Bisector *)abisector;
	MAT_Bisector* result = (MAT_Bisector*)(((Handle_MAT_Bisector*)instance)->Access());
 	result->AddBisector(			
_abisector);
}
DECL_EXPORT void MAT_Bisector_BisectorNumberE8219145(
	void* instance,
	int anumber)
{
	MAT_Bisector* result = (MAT_Bisector*)(((Handle_MAT_Bisector*)instance)->Access());
 	result->BisectorNumber(			
anumber);
}
DECL_EXPORT void MAT_Bisector_IndexNumberE8219145(
	void* instance,
	int anumber)
{
	MAT_Bisector* result = (MAT_Bisector*)(((Handle_MAT_Bisector*)instance)->Access());
 	result->IndexNumber(			
anumber);
}
DECL_EXPORT void MAT_Bisector_FirstEdge878E0E92(
	void* instance,
	void* anedge)
{
		const Handle_MAT_Edge&  _anedge =*(const Handle_MAT_Edge *)anedge;
	MAT_Bisector* result = (MAT_Bisector*)(((Handle_MAT_Bisector*)instance)->Access());
 	result->FirstEdge(			
_anedge);
}
DECL_EXPORT void MAT_Bisector_SecondEdge878E0E92(
	void* instance,
	void* anedge)
{
		const Handle_MAT_Edge&  _anedge =*(const Handle_MAT_Edge *)anedge;
	MAT_Bisector* result = (MAT_Bisector*)(((Handle_MAT_Bisector*)instance)->Access());
 	result->SecondEdge(			
_anedge);
}
DECL_EXPORT void MAT_Bisector_IssuePointE8219145(
	void* instance,
	int apoint)
{
	MAT_Bisector* result = (MAT_Bisector*)(((Handle_MAT_Bisector*)instance)->Access());
 	result->IssuePoint(			
apoint);
}
DECL_EXPORT void MAT_Bisector_EndPointE8219145(
	void* instance,
	int apoint)
{
	MAT_Bisector* result = (MAT_Bisector*)(((Handle_MAT_Bisector*)instance)->Access());
 	result->EndPoint(			
apoint);
}
DECL_EXPORT void MAT_Bisector_DistIssuePointD82819F3(
	void* instance,
	double areal)
{
	MAT_Bisector* result = (MAT_Bisector*)(((Handle_MAT_Bisector*)instance)->Access());
 	result->DistIssuePoint(			
areal);
}
DECL_EXPORT void MAT_Bisector_FirstVectorE8219145(
	void* instance,
	int avector)
{
	MAT_Bisector* result = (MAT_Bisector*)(((Handle_MAT_Bisector*)instance)->Access());
 	result->FirstVector(			
avector);
}
DECL_EXPORT void MAT_Bisector_SecondVectorE8219145(
	void* instance,
	int avector)
{
	MAT_Bisector* result = (MAT_Bisector*)(((Handle_MAT_Bisector*)instance)->Access());
 	result->SecondVector(			
avector);
}
DECL_EXPORT void MAT_Bisector_SenseD82819F3(
	void* instance,
	double asense)
{
	MAT_Bisector* result = (MAT_Bisector*)(((Handle_MAT_Bisector*)instance)->Access());
 	result->Sense(			
asense);
}
DECL_EXPORT void MAT_Bisector_FirstParameterD82819F3(
	void* instance,
	double aparameter)
{
	MAT_Bisector* result = (MAT_Bisector*)(((Handle_MAT_Bisector*)instance)->Access());
 	result->FirstParameter(			
aparameter);
}
DECL_EXPORT void MAT_Bisector_SecondParameterD82819F3(
	void* instance,
	double aparameter)
{
	MAT_Bisector* result = (MAT_Bisector*)(((Handle_MAT_Bisector*)instance)->Access());
 	result->SecondParameter(			
aparameter);
}
DECL_EXPORT int MAT_Bisector_BisectorNumber(void* instance)
{
	MAT_Bisector* result = (MAT_Bisector*)(((Handle_MAT_Bisector*)instance)->Access());
	return  	result->BisectorNumber();
}
DECL_EXPORT int MAT_Bisector_IndexNumber(void* instance)
{
	MAT_Bisector* result = (MAT_Bisector*)(((Handle_MAT_Bisector*)instance)->Access());
	return  	result->IndexNumber();
}
DECL_EXPORT void* MAT_Bisector_FirstEdge(void* instance)
{
	MAT_Bisector* result = (MAT_Bisector*)(((Handle_MAT_Bisector*)instance)->Access());
	return new Handle_MAT_Edge( 	result->FirstEdge());
}
DECL_EXPORT void* MAT_Bisector_SecondEdge(void* instance)
{
	MAT_Bisector* result = (MAT_Bisector*)(((Handle_MAT_Bisector*)instance)->Access());
	return new Handle_MAT_Edge( 	result->SecondEdge());
}
DECL_EXPORT int MAT_Bisector_IssuePoint(void* instance)
{
	MAT_Bisector* result = (MAT_Bisector*)(((Handle_MAT_Bisector*)instance)->Access());
	return  	result->IssuePoint();
}
DECL_EXPORT int MAT_Bisector_EndPoint(void* instance)
{
	MAT_Bisector* result = (MAT_Bisector*)(((Handle_MAT_Bisector*)instance)->Access());
	return  	result->EndPoint();
}
DECL_EXPORT double MAT_Bisector_DistIssuePoint(void* instance)
{
	MAT_Bisector* result = (MAT_Bisector*)(((Handle_MAT_Bisector*)instance)->Access());
	return  	result->DistIssuePoint();
}
DECL_EXPORT int MAT_Bisector_FirstVector(void* instance)
{
	MAT_Bisector* result = (MAT_Bisector*)(((Handle_MAT_Bisector*)instance)->Access());
	return  	result->FirstVector();
}
DECL_EXPORT int MAT_Bisector_SecondVector(void* instance)
{
	MAT_Bisector* result = (MAT_Bisector*)(((Handle_MAT_Bisector*)instance)->Access());
	return  	result->SecondVector();
}
DECL_EXPORT double MAT_Bisector_Sense(void* instance)
{
	MAT_Bisector* result = (MAT_Bisector*)(((Handle_MAT_Bisector*)instance)->Access());
	return  	result->Sense();
}
DECL_EXPORT double MAT_Bisector_FirstParameter(void* instance)
{
	MAT_Bisector* result = (MAT_Bisector*)(((Handle_MAT_Bisector*)instance)->Access());
	return  	result->FirstParameter();
}
DECL_EXPORT double MAT_Bisector_SecondParameter(void* instance)
{
	MAT_Bisector* result = (MAT_Bisector*)(((Handle_MAT_Bisector*)instance)->Access());
	return  	result->SecondParameter();
}
DECL_EXPORT void MAT_Bisector_Dump5107F6FE(
	void* instance,
	int ashift,
	int alevel)
{
	MAT_Bisector* result = (MAT_Bisector*)(((Handle_MAT_Bisector*)instance)->Access());
 	result->Dump(			
ashift,			
alevel);
}
DECL_EXPORT void* MAT_Bisector_List(void* instance)
{
	MAT_Bisector* result = (MAT_Bisector*)(((Handle_MAT_Bisector*)instance)->Access());
	return 	new Handle_MAT_ListOfBisector(	result->List());
}

DECL_EXPORT void* MAT_Bisector_FirstBisector(void* instance)
{
	MAT_Bisector* result = (MAT_Bisector*)(((Handle_MAT_Bisector*)instance)->Access());
	return 	new Handle_MAT_Bisector(	result->FirstBisector());
}

DECL_EXPORT void* MAT_Bisector_LastBisector(void* instance)
{
	MAT_Bisector* result = (MAT_Bisector*)(((Handle_MAT_Bisector*)instance)->Access());
	return 	new Handle_MAT_Bisector(	result->LastBisector());
}

DECL_EXPORT void MATBisector_Dtor(void* instance)
{
	delete (Handle_MAT_Bisector*)instance;
}
