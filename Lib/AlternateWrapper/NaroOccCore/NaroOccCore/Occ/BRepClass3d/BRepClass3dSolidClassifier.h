#ifndef BRepClass3d_SolidClassifier_H
#define BRepClass3d_SolidClassifier_H

#include "../../Export_Import.h"

extern "C" DECL_EXPORT void* BRepClass3d_SolidClassifier_Ctor();
extern "C" DECL_EXPORT void* BRepClass3d_SolidClassifier_Ctor9EBAC0C0(
	void* S);
extern "C" DECL_EXPORT void* BRepClass3d_SolidClassifier_CtorAB62C26C(
	void* S,
	void* P,
	double Tol);
extern "C" DECL_EXPORT void BRepClass3d_SolidClassifier_Load9EBAC0C0(
	void* instance,
	void* S);
extern "C" DECL_EXPORT void BRepClass3d_SolidClassifier_PerformF0D1E3E6(
	void* instance,
	void* P,
	double Tol);
extern "C" DECL_EXPORT void BRepClass3d_SolidClassifier_PerformInfinitePointD82819F3(
	void* instance,
	double Tol);
extern "C" DECL_EXPORT void BRepClass3dSolidClassifier_Dtor(void* instance);

#endif
