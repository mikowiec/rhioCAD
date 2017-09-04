#include "HLRAlgoInterference.h"
#include <HLRAlgo_Interference.hxx>

#include <HLRAlgo_Coincidence.hxx>
#include <HLRAlgo_Intersection.hxx>

DECL_EXPORT void* HLRAlgo_Interference_Ctor()
{
	return new HLRAlgo_Interference();
}
DECL_EXPORT void* HLRAlgo_Interference_Ctor43D8FA96(
	void* Inters,
	void* Bound,
	int Orient,
	int Trans,
	int BTrans)
{
		const HLRAlgo_Intersection &  _Inters =*(const HLRAlgo_Intersection *)Inters;
		const HLRAlgo_Coincidence &  _Bound =*(const HLRAlgo_Coincidence *)Bound;
		const TopAbs_Orientation _Orient =(const TopAbs_Orientation )Orient;
		const TopAbs_Orientation _Trans =(const TopAbs_Orientation )Trans;
		const TopAbs_Orientation _BTrans =(const TopAbs_Orientation )BTrans;
	return new HLRAlgo_Interference(			
_Inters,			
_Bound,			
_Orient,			
_Trans,			
_BTrans);
}
DECL_EXPORT void HLRAlgo_Interference_Intersection2F323D4D(
	void* instance,
	void* I)
{
		const HLRAlgo_Intersection &  _I =*(const HLRAlgo_Intersection *)I;
	HLRAlgo_Interference* result = (HLRAlgo_Interference*)instance;
 	result->Intersection(			
_I);
}
DECL_EXPORT void HLRAlgo_Interference_Boundary358C2A26(
	void* instance,
	void* B)
{
		const HLRAlgo_Coincidence &  _B =*(const HLRAlgo_Coincidence *)B;
	HLRAlgo_Interference* result = (HLRAlgo_Interference*)instance;
 	result->Boundary(			
_B);
}
DECL_EXPORT void HLRAlgo_Interference_Orientation69EAD1AB(
	void* instance,
	int O)
{
		const TopAbs_Orientation _O =(const TopAbs_Orientation )O;
	HLRAlgo_Interference* result = (HLRAlgo_Interference*)instance;
 	result->Orientation(			
_O);
}
DECL_EXPORT void HLRAlgo_Interference_Transition69EAD1AB(
	void* instance,
	int Tr)
{
		const TopAbs_Orientation _Tr =(const TopAbs_Orientation )Tr;
	HLRAlgo_Interference* result = (HLRAlgo_Interference*)instance;
 	result->Transition(			
_Tr);
}
DECL_EXPORT void HLRAlgo_Interference_BoundaryTransition69EAD1AB(
	void* instance,
	int BTr)
{
		const TopAbs_Orientation _BTr =(const TopAbs_Orientation )BTr;
	HLRAlgo_Interference* result = (HLRAlgo_Interference*)instance;
 	result->BoundaryTransition(			
_BTr);
}
DECL_EXPORT void* HLRAlgo_Interference_Intersection(void* instance)
{
	HLRAlgo_Interference* result = (HLRAlgo_Interference*)instance;
	return new HLRAlgo_Intersection( 	result->Intersection());
}
DECL_EXPORT void* HLRAlgo_Interference_Boundary(void* instance)
{
	HLRAlgo_Interference* result = (HLRAlgo_Interference*)instance;
	return new HLRAlgo_Coincidence( 	result->Boundary());
}
DECL_EXPORT int HLRAlgo_Interference_Orientation(void* instance)
{
	HLRAlgo_Interference* result = (HLRAlgo_Interference*)instance;
	return  	result->Orientation();
}
DECL_EXPORT int HLRAlgo_Interference_Transition(void* instance)
{
	HLRAlgo_Interference* result = (HLRAlgo_Interference*)instance;
	return  	result->Transition();
}
DECL_EXPORT int HLRAlgo_Interference_BoundaryTransition(void* instance)
{
	HLRAlgo_Interference* result = (HLRAlgo_Interference*)instance;
	return  	result->BoundaryTransition();
}
DECL_EXPORT void* HLRAlgo_Interference_ChangeIntersection(void* instance)
{
	HLRAlgo_Interference* result = (HLRAlgo_Interference*)instance;
	return 	new HLRAlgo_Intersection(	result->ChangeIntersection());
}

DECL_EXPORT void* HLRAlgo_Interference_ChangeBoundary(void* instance)
{
	HLRAlgo_Interference* result = (HLRAlgo_Interference*)instance;
	return 	new HLRAlgo_Coincidence(	result->ChangeBoundary());
}

DECL_EXPORT void HLRAlgoInterference_Dtor(void* instance)
{
	delete (HLRAlgo_Interference*)instance;
}
