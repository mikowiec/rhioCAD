#ifndef HLRAlgo_Intersection_H
#define HLRAlgo_Intersection_H

#include "../../Export_Import.h"

extern "C" DECL_EXPORT void* HLRAlgo_Intersection_Ctor();
extern "C" DECL_EXPORT void* HLRAlgo_Intersection_CtorFF238ADF(
	int Ori,
	int Lev,
	int SegInd,
	int Ind,
	double P,
	double Tol,
	int S);
extern "C" DECL_EXPORT void HLRAlgo_Intersection_Orientation69EAD1AB(
	void* instance,
	int Ori);
extern "C" DECL_EXPORT int HLRAlgo_Intersection_Orientation(void* instance);
extern "C" DECL_EXPORT void HLRAlgo_Intersection_LevelE8219145(
	void* instance,
	int Lev);
extern "C" DECL_EXPORT int HLRAlgo_Intersection_Level(void* instance);
extern "C" DECL_EXPORT void HLRAlgo_Intersection_SegIndexE8219145(
	void* instance,
	int SegInd);
extern "C" DECL_EXPORT int HLRAlgo_Intersection_SegIndex(void* instance);
extern "C" DECL_EXPORT void HLRAlgo_Intersection_IndexE8219145(
	void* instance,
	int Ind);
extern "C" DECL_EXPORT int HLRAlgo_Intersection_Index(void* instance);
extern "C" DECL_EXPORT void HLRAlgo_Intersection_ParameterD82819F3(
	void* instance,
	double P);
extern "C" DECL_EXPORT double HLRAlgo_Intersection_Parameter(void* instance);
extern "C" DECL_EXPORT void HLRAlgo_Intersection_ToleranceD82819F3(
	void* instance,
	double T);
extern "C" DECL_EXPORT double HLRAlgo_Intersection_Tolerance(void* instance);
extern "C" DECL_EXPORT void HLRAlgo_Intersection_StateD70DF52B(
	void* instance,
	int S);
extern "C" DECL_EXPORT int HLRAlgo_Intersection_State(void* instance);
extern "C" DECL_EXPORT void HLRAlgoIntersection_Dtor(void* instance);

#endif
