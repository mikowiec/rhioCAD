#ifndef HLRAlgo_Interference_H
#define HLRAlgo_Interference_H

#include "../../Export_Import.h"

extern "C" DECL_EXPORT void* HLRAlgo_Interference_Ctor();
extern "C" DECL_EXPORT void* HLRAlgo_Interference_Ctor43D8FA96(
	void* Inters,
	void* Bound,
	int Orient,
	int Trans,
	int BTrans);
extern "C" DECL_EXPORT void HLRAlgo_Interference_Intersection2F323D4D(
	void* instance,
	void* I);
extern "C" DECL_EXPORT void HLRAlgo_Interference_Boundary358C2A26(
	void* instance,
	void* B);
extern "C" DECL_EXPORT void HLRAlgo_Interference_Orientation69EAD1AB(
	void* instance,
	int O);
extern "C" DECL_EXPORT void HLRAlgo_Interference_Transition69EAD1AB(
	void* instance,
	int Tr);
extern "C" DECL_EXPORT void HLRAlgo_Interference_BoundaryTransition69EAD1AB(
	void* instance,
	int BTr);
extern "C" DECL_EXPORT void* HLRAlgo_Interference_Intersection(void* instance);
extern "C" DECL_EXPORT void* HLRAlgo_Interference_Boundary(void* instance);
extern "C" DECL_EXPORT int HLRAlgo_Interference_Orientation(void* instance);
extern "C" DECL_EXPORT int HLRAlgo_Interference_Transition(void* instance);
extern "C" DECL_EXPORT int HLRAlgo_Interference_BoundaryTransition(void* instance);
extern "C" DECL_EXPORT void* HLRAlgo_Interference_ChangeIntersection(void* instance);
extern "C" DECL_EXPORT void* HLRAlgo_Interference_ChangeBoundary(void* instance);
extern "C" DECL_EXPORT void HLRAlgoInterference_Dtor(void* instance);

#endif
