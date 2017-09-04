#ifndef StepGeom_Direction_H
#define StepGeom_Direction_H

#include "../../Export_Import.h"

extern "C" DECL_EXPORT void* StepGeom_Direction_Ctor();
extern "C" DECL_EXPORT void StepGeom_Direction_InitB439B3D5(
	void* instance,
	void* aName);
extern "C" DECL_EXPORT double StepGeom_Direction_DirectionRatiosValueE8219145(
	void* instance,
	int num);
extern "C" DECL_EXPORT int StepGeom_Direction_NbDirectionRatios(void* instance);
extern "C" DECL_EXPORT void StepGeomDirection_Dtor(void* instance);

#endif
