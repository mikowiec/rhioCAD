#include "HLRAlgoIntersection.h"
#include <HLRAlgo_Intersection.hxx>


DECL_EXPORT void* HLRAlgo_Intersection_Ctor()
{
	return new HLRAlgo_Intersection();
}
DECL_EXPORT void* HLRAlgo_Intersection_CtorFF238ADF(
	int Ori,
	int Lev,
	int SegInd,
	int Ind,
	double P,
	double Tol,
	int S)
{
		const TopAbs_Orientation _Ori =(const TopAbs_Orientation )Ori;
		const TopAbs_State _S =(const TopAbs_State )S;
	return new HLRAlgo_Intersection(			
_Ori,			
Lev,			
SegInd,			
Ind,			
P,			
Tol,			
_S);
}
DECL_EXPORT void HLRAlgo_Intersection_Orientation69EAD1AB(
	void* instance,
	int Ori)
{
		const TopAbs_Orientation _Ori =(const TopAbs_Orientation )Ori;
	HLRAlgo_Intersection* result = (HLRAlgo_Intersection*)instance;
 	result->Orientation(			
_Ori);
}
DECL_EXPORT int HLRAlgo_Intersection_Orientation(void* instance)
{
	HLRAlgo_Intersection* result = (HLRAlgo_Intersection*)instance;
	return  	result->Orientation();
}
DECL_EXPORT void HLRAlgo_Intersection_LevelE8219145(
	void* instance,
	int Lev)
{
	HLRAlgo_Intersection* result = (HLRAlgo_Intersection*)instance;
 	result->Level(			
Lev);
}
DECL_EXPORT int HLRAlgo_Intersection_Level(void* instance)
{
	HLRAlgo_Intersection* result = (HLRAlgo_Intersection*)instance;
	return  	result->Level();
}
DECL_EXPORT void HLRAlgo_Intersection_SegIndexE8219145(
	void* instance,
	int SegInd)
{
	HLRAlgo_Intersection* result = (HLRAlgo_Intersection*)instance;
 	result->SegIndex(			
SegInd);
}
DECL_EXPORT int HLRAlgo_Intersection_SegIndex(void* instance)
{
	HLRAlgo_Intersection* result = (HLRAlgo_Intersection*)instance;
	return  	result->SegIndex();
}
DECL_EXPORT void HLRAlgo_Intersection_IndexE8219145(
	void* instance,
	int Ind)
{
	HLRAlgo_Intersection* result = (HLRAlgo_Intersection*)instance;
 	result->Index(			
Ind);
}
DECL_EXPORT int HLRAlgo_Intersection_Index(void* instance)
{
	HLRAlgo_Intersection* result = (HLRAlgo_Intersection*)instance;
	return  	result->Index();
}
DECL_EXPORT void HLRAlgo_Intersection_ParameterD82819F3(
	void* instance,
	double P)
{
	HLRAlgo_Intersection* result = (HLRAlgo_Intersection*)instance;
 	result->Parameter(			
P);
}
DECL_EXPORT double HLRAlgo_Intersection_Parameter(void* instance)
{
	HLRAlgo_Intersection* result = (HLRAlgo_Intersection*)instance;
	return  	result->Parameter();
}
DECL_EXPORT void HLRAlgo_Intersection_ToleranceD82819F3(
	void* instance,
	double T)
{
	HLRAlgo_Intersection* result = (HLRAlgo_Intersection*)instance;
 	result->Tolerance(			
T);
}
DECL_EXPORT double HLRAlgo_Intersection_Tolerance(void* instance)
{
	HLRAlgo_Intersection* result = (HLRAlgo_Intersection*)instance;
	return  	result->Tolerance();
}
DECL_EXPORT void HLRAlgo_Intersection_StateD70DF52B(
	void* instance,
	int S)
{
		const TopAbs_State _S =(const TopAbs_State )S;
	HLRAlgo_Intersection* result = (HLRAlgo_Intersection*)instance;
 	result->State(			
_S);
}
DECL_EXPORT int HLRAlgo_Intersection_State(void* instance)
{
	HLRAlgo_Intersection* result = (HLRAlgo_Intersection*)instance;
	return  	result->State();
}
DECL_EXPORT void HLRAlgoIntersection_Dtor(void* instance)
{
	delete (HLRAlgo_Intersection*)instance;
}
