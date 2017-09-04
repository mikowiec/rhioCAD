#ifndef BRepOffset_MakeOffset_H
#define BRepOffset_MakeOffset_H

#include "../../Export_Import.h"

extern "C" DECL_EXPORT void* BRepOffset_MakeOffset_Ctor();
extern "C" DECL_EXPORT void BRepOffset_MakeOffset_Initialize72D69762(
	void* instance,
	void* S,
	double Offset,
	double Tol,
	int Mode,
	bool Intersection,
	bool SelfInter,
	int Join);
extern "C" DECL_EXPORT void BRepOffset_MakeOffset_MakeThickSolid(void* instance);
extern "C" DECL_EXPORT void* BRepOffset_MakeOffset_Shape(void* instance);
extern "C" DECL_EXPORT bool BRepOffset_MakeOffset_IsDone(void* instance);
extern "C" DECL_EXPORT void BRepOffsetMakeOffset_Dtor(void* instance);

#endif
