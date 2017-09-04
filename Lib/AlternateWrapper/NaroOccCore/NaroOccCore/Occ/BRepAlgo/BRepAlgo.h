#ifndef BRepAlgo_H
#define BRepAlgo_H

#include "../../Export_Import.h"

extern "C" DECL_EXPORT void* BRepAlgo_ConcatenateWireB2333A01(
	void* Wire,
	int Option,
	double AngularTolerance);
extern "C" DECL_EXPORT bool BRepAlgo_IsValid9EBAC0C0(
	void* S);
extern "C" DECL_EXPORT bool BRepAlgo_IsValid49B662F1(
	void* theArgs,
	void* theResult,
	bool closedSolid,
	bool GeomCtrl);
extern "C" DECL_EXPORT bool BRepAlgo_IsTopologicallyValid9EBAC0C0(
	void* S);
extern "C" DECL_EXPORT void BRepAlgo_Dtor(void* instance);

#endif
