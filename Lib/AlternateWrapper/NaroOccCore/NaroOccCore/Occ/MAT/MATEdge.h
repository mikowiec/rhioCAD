#ifndef MAT_Edge_H
#define MAT_Edge_H

#include "../../Export_Import.h"

extern "C" DECL_EXPORT void* MAT_Edge_Ctor();
extern "C" DECL_EXPORT void MAT_Edge_EdgeNumberE8219145(
	void* instance,
	int anumber);
extern "C" DECL_EXPORT void MAT_Edge_FirstBisector1F24E859(
	void* instance,
	void* abisector);
extern "C" DECL_EXPORT void MAT_Edge_SecondBisector1F24E859(
	void* instance,
	void* abisector);
extern "C" DECL_EXPORT void MAT_Edge_DistanceD82819F3(
	void* instance,
	double adistance);
extern "C" DECL_EXPORT void MAT_Edge_IntersectionPointE8219145(
	void* instance,
	int apoint);
extern "C" DECL_EXPORT int MAT_Edge_EdgeNumber(void* instance);
extern "C" DECL_EXPORT void* MAT_Edge_FirstBisector(void* instance);
extern "C" DECL_EXPORT void* MAT_Edge_SecondBisector(void* instance);
extern "C" DECL_EXPORT double MAT_Edge_Distance(void* instance);
extern "C" DECL_EXPORT int MAT_Edge_IntersectionPoint(void* instance);
extern "C" DECL_EXPORT void MAT_Edge_Dump5107F6FE(
	void* instance,
	int ashift,
	int alevel);
extern "C" DECL_EXPORT void MATEdge_Dtor(void* instance);

#endif
