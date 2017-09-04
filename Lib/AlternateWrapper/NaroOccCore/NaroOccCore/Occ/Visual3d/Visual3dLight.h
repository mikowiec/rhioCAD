#ifndef Visual3d_Light_H
#define Visual3d_Light_H

#include "../../Export_Import.h"

extern "C" DECL_EXPORT void* Visual3d_Light_Ctor();
extern "C" DECL_EXPORT void* Visual3d_Light_Ctor8FD7F48(
	void* Color);
extern "C" DECL_EXPORT void* Visual3d_Light_Ctor37E700E8(
	void* Color,
	void* Direction,
	bool Headlight);
extern "C" DECL_EXPORT void* Visual3d_Light_Ctor75C213E8(
	void* Color,
	void* Position,
	double Fact1,
	double Fact2);
extern "C" DECL_EXPORT void* Visual3d_Light_Ctor3F337B1E(
	void* Color,
	void* Position,
	void* Direction,
	double Concentration,
	double Fact1,
	double Fact2,
	double AngleCone);
extern "C" DECL_EXPORT void Visual3d_Light_Values8FD7F48(
	void* instance,
	void* Color);
extern "C" DECL_EXPORT void Visual3d_Light_Values7778B201(
	void* instance,
	void* Color,
	void* Direction);
extern "C" DECL_EXPORT void Visual3d_Light_Values75C213E8(
	void* instance,
	void* Color,
	void* Position,
	double* Fact1,
	double* Fact2);
extern "C" DECL_EXPORT void Visual3d_Light_Values3F337B1E(
	void* instance,
	void* Color,
	void* Position,
	void* Direction,
	double* Concentration,
	double* Fact1,
	double* Fact2,
	double* AngleCone);
extern "C" DECL_EXPORT void Visual3d_Light_SetAngle(void* instance, double value);
extern "C" DECL_EXPORT void Visual3d_Light_SetAttenuation1(void* instance, double value);
extern "C" DECL_EXPORT void Visual3d_Light_SetAttenuation2(void* instance, double value);
extern "C" DECL_EXPORT void Visual3d_Light_SetConcentration(void* instance, double value);
extern "C" DECL_EXPORT void Visual3d_Light_SetDirection(void* instance, void* value);
extern "C" DECL_EXPORT void Visual3d_Light_SetPosition(void* instance, void* value);
extern "C" DECL_EXPORT bool Visual3d_Light_Headlight(void* instance);
extern "C" DECL_EXPORT void Visual3d_Light_SetColor(void* instance, void* value);
extern "C" DECL_EXPORT void* Visual3d_Light_Color(void* instance);
extern "C" DECL_EXPORT int Visual3d_Light_LightType(void* instance);
extern "C" DECL_EXPORT int Visual3d_Light_Limit();
extern "C" DECL_EXPORT void Visual3dLight_Dtor(void* instance);

#endif
