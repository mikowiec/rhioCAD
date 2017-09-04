#ifndef StepGeom_CartesianPoint_H
#define StepGeom_CartesianPoint_H

#include "../../Export_Import.h"

extern "C" DECL_EXPORT void* StepGeom_CartesianPoint_Ctor();
extern "C" DECL_EXPORT void StepGeom_CartesianPoint_InitB439B3D5(
	void* instance,
	void* aName);
extern "C" DECL_EXPORT void StepGeom_CartesianPoint_Init2D3BC3DBE2(
	void* instance,
	void* aName,
	double X,
	double Y);
extern "C" DECL_EXPORT void StepGeom_CartesianPoint_Init3D13512EBE(
	void* instance,
	void* aName,
	double X,
	double Y,
	double Z);
extern "C" DECL_EXPORT double StepGeom_CartesianPoint_CoordinatesValueE8219145(
	void* instance,
	int num);
extern "C" DECL_EXPORT int StepGeom_CartesianPoint_NbCoordinates(void* instance);
extern "C" DECL_EXPORT void StepGeomCartesianPoint_Dtor(void* instance);

#endif
