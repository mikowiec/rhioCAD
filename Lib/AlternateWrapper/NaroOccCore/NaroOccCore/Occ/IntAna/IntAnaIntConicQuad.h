#ifndef IntAna_IntConicQuad_H
#define IntAna_IntConicQuad_H

#include "../../Export_Import.h"

extern "C" DECL_EXPORT void* IntAna_IntConicQuad_Ctor();
extern "C" DECL_EXPORT void* IntAna_IntConicQuad_Ctor89334BAA(
	void* L,
	void* P,
	double Tolang);
extern "C" DECL_EXPORT void* IntAna_IntConicQuad_Ctor8C72EA96(
	void* C,
	void* P,
	double Tolang,
	double Tol);
extern "C" DECL_EXPORT void* IntAna_IntConicQuad_Ctor9E3F6D56(
	void* E,
	void* P,
	double Tolang,
	double Tol);
extern "C" DECL_EXPORT void* IntAna_IntConicQuad_CtorFF3C8AFC(
	void* Pb,
	void* P,
	double Tolang);
extern "C" DECL_EXPORT void* IntAna_IntConicQuad_Ctor1B97E413(
	void* H,
	void* P,
	double Tolang);
extern "C" DECL_EXPORT void IntAna_IntConicQuad_Perform89334BAA(
	void* instance,
	void* L,
	void* P,
	double Tolang);
extern "C" DECL_EXPORT void IntAna_IntConicQuad_Perform8C72EA96(
	void* instance,
	void* C,
	void* P,
	double Tolang,
	double Tol);
extern "C" DECL_EXPORT void IntAna_IntConicQuad_Perform9E3F6D56(
	void* instance,
	void* E,
	void* P,
	double Tolang,
	double Tol);
extern "C" DECL_EXPORT void IntAna_IntConicQuad_PerformFF3C8AFC(
	void* instance,
	void* Pb,
	void* P,
	double Tolang);
extern "C" DECL_EXPORT void IntAna_IntConicQuad_Perform1B97E413(
	void* instance,
	void* H,
	void* P,
	double Tolang);
extern "C" DECL_EXPORT void* IntAna_IntConicQuad_PointE8219145(
	void* instance,
	int N);
extern "C" DECL_EXPORT double IntAna_IntConicQuad_ParamOnConicE8219145(
	void* instance,
	int N);
extern "C" DECL_EXPORT bool IntAna_IntConicQuad_IsDone(void* instance);
extern "C" DECL_EXPORT bool IntAna_IntConicQuad_IsInQuadric(void* instance);
extern "C" DECL_EXPORT bool IntAna_IntConicQuad_IsParallel(void* instance);
extern "C" DECL_EXPORT int IntAna_IntConicQuad_NbPoints(void* instance);
extern "C" DECL_EXPORT void IntAnaIntConicQuad_Dtor(void* instance);

#endif
