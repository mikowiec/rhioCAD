#ifndef MAT_Bisector_H
#define MAT_Bisector_H

#include "../../Export_Import.h"

extern "C" DECL_EXPORT void* MAT_Bisector_Ctor();
extern "C" DECL_EXPORT void MAT_Bisector_AddBisector1F24E859(
	void* instance,
	void* abisector);
extern "C" DECL_EXPORT void MAT_Bisector_BisectorNumberE8219145(
	void* instance,
	int anumber);
extern "C" DECL_EXPORT void MAT_Bisector_IndexNumberE8219145(
	void* instance,
	int anumber);
extern "C" DECL_EXPORT void MAT_Bisector_FirstEdge878E0E92(
	void* instance,
	void* anedge);
extern "C" DECL_EXPORT void MAT_Bisector_SecondEdge878E0E92(
	void* instance,
	void* anedge);
extern "C" DECL_EXPORT void MAT_Bisector_IssuePointE8219145(
	void* instance,
	int apoint);
extern "C" DECL_EXPORT void MAT_Bisector_EndPointE8219145(
	void* instance,
	int apoint);
extern "C" DECL_EXPORT void MAT_Bisector_DistIssuePointD82819F3(
	void* instance,
	double areal);
extern "C" DECL_EXPORT void MAT_Bisector_FirstVectorE8219145(
	void* instance,
	int avector);
extern "C" DECL_EXPORT void MAT_Bisector_SecondVectorE8219145(
	void* instance,
	int avector);
extern "C" DECL_EXPORT void MAT_Bisector_SenseD82819F3(
	void* instance,
	double asense);
extern "C" DECL_EXPORT void MAT_Bisector_FirstParameterD82819F3(
	void* instance,
	double aparameter);
extern "C" DECL_EXPORT void MAT_Bisector_SecondParameterD82819F3(
	void* instance,
	double aparameter);
extern "C" DECL_EXPORT int MAT_Bisector_BisectorNumber(void* instance);
extern "C" DECL_EXPORT int MAT_Bisector_IndexNumber(void* instance);
extern "C" DECL_EXPORT void* MAT_Bisector_FirstEdge(void* instance);
extern "C" DECL_EXPORT void* MAT_Bisector_SecondEdge(void* instance);
extern "C" DECL_EXPORT int MAT_Bisector_IssuePoint(void* instance);
extern "C" DECL_EXPORT int MAT_Bisector_EndPoint(void* instance);
extern "C" DECL_EXPORT double MAT_Bisector_DistIssuePoint(void* instance);
extern "C" DECL_EXPORT int MAT_Bisector_FirstVector(void* instance);
extern "C" DECL_EXPORT int MAT_Bisector_SecondVector(void* instance);
extern "C" DECL_EXPORT double MAT_Bisector_Sense(void* instance);
extern "C" DECL_EXPORT double MAT_Bisector_FirstParameter(void* instance);
extern "C" DECL_EXPORT double MAT_Bisector_SecondParameter(void* instance);
extern "C" DECL_EXPORT void MAT_Bisector_Dump5107F6FE(
	void* instance,
	int ashift,
	int alevel);
extern "C" DECL_EXPORT void* MAT_Bisector_List(void* instance);
extern "C" DECL_EXPORT void* MAT_Bisector_FirstBisector(void* instance);
extern "C" DECL_EXPORT void* MAT_Bisector_LastBisector(void* instance);
extern "C" DECL_EXPORT void MATBisector_Dtor(void* instance);

#endif
