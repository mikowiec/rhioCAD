#ifndef gce_MakeCirc_H
#define gce_MakeCirc_H

#include "../../Export_Import.h"

extern "C" DECL_EXPORT void* gce_MakeCirc_Ctor673FA07D(
	void* A2,
	double Radius);
extern "C" DECL_EXPORT void* gce_MakeCirc_Ctor941DBF06(
	void* Circ,
	double Dist);
extern "C" DECL_EXPORT void* gce_MakeCirc_Ctor89B70D29(
	void* Circ,
	void* Point);
extern "C" DECL_EXPORT void* gce_MakeCirc_Ctor4B855FC1(
	void* P1,
	void* P2,
	void* P3);
extern "C" DECL_EXPORT void* gce_MakeCirc_Ctor9327D37B(
	void* Center,
	void* Norm,
	double Radius);
extern "C" DECL_EXPORT void* gce_MakeCirc_CtorE73602A3(
	void* Center,
	void* Plane,
	double Radius);
extern "C" DECL_EXPORT void* gce_MakeCirc_CtorB8940259(
	void* Center,
	void* Ptaxis,
	double Radius);
extern "C" DECL_EXPORT void* gce_MakeCirc_Ctor827CB19A(
	void* Axis,
	double Radius);
extern "C" DECL_EXPORT void* gce_MakeCirc_Value(void* instance);
extern "C" DECL_EXPORT void* gce_MakeCirc_Operator(void* instance);
extern "C" DECL_EXPORT void gceMakeCirc_Dtor(void* instance);

#endif
