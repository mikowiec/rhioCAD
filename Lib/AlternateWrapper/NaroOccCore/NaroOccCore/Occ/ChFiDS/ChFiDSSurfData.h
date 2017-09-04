#ifndef ChFiDS_SurfData_H
#define ChFiDS_SurfData_H

#include "../../Export_Import.h"

extern "C" DECL_EXPORT void* ChFiDS_SurfData_Ctor();
extern "C" DECL_EXPORT void ChFiDS_SurfData_CopyB9327F76(
	void* instance,
	void* Other);
extern "C" DECL_EXPORT void ChFiDS_SurfData_ChangeIndexOfS1E8219145(
	void* instance,
	int Index);
extern "C" DECL_EXPORT void ChFiDS_SurfData_ChangeIndexOfS2E8219145(
	void* instance,
	int Index);
extern "C" DECL_EXPORT void ChFiDS_SurfData_ChangeSurfE8219145(
	void* instance,
	int Index);
extern "C" DECL_EXPORT void* ChFiDS_SurfData_InterferenceE8219145(
	void* instance,
	int OnS);
extern "C" DECL_EXPORT void* ChFiDS_SurfData_ChangeInterferenceE8219145(
	void* instance,
	int OnS);
extern "C" DECL_EXPORT int ChFiDS_SurfData_IndexE8219145(
	void* instance,
	int OfS);
extern "C" DECL_EXPORT void* ChFiDS_SurfData_VertexD4631C92(
	void* instance,
	bool First,
	int OnS);
extern "C" DECL_EXPORT void* ChFiDS_SurfData_ChangeVertexD4631C92(
	void* instance,
	bool First,
	int OnS);
extern "C" DECL_EXPORT bool ChFiDS_SurfData_IsOnCurveE8219145(
	void* instance,
	int OnS);
extern "C" DECL_EXPORT int ChFiDS_SurfData_IndexOfCE8219145(
	void* instance,
	int OnS);
extern "C" DECL_EXPORT double ChFiDS_SurfData_FirstSpineParam(void* instance);
extern "C" DECL_EXPORT double ChFiDS_SurfData_LastSpineParam(void* instance);
extern "C" DECL_EXPORT void ChFiDS_SurfData_FirstSpineParamD82819F3(
	void* instance,
	double Par);
extern "C" DECL_EXPORT void ChFiDS_SurfData_LastSpineParamD82819F3(
	void* instance,
	double Par);
extern "C" DECL_EXPORT double ChFiDS_SurfData_FirstExtensionValue(void* instance);
extern "C" DECL_EXPORT double ChFiDS_SurfData_LastExtensionValue(void* instance);
extern "C" DECL_EXPORT void ChFiDS_SurfData_FirstExtensionValueD82819F3(
	void* instance,
	double Extend);
extern "C" DECL_EXPORT void ChFiDS_SurfData_LastExtensionValueD82819F3(
	void* instance,
	double Extend);
extern "C" DECL_EXPORT void ChFiDS_SurfData_ResetSimul(void* instance);
extern "C" DECL_EXPORT void* ChFiDS_SurfData_Get2dPointsD4631C92(
	void* instance,
	bool First,
	int OnS);
extern "C" DECL_EXPORT void ChFiDS_SurfData_Get2dPoints79D6D16B(
	void* instance,
	void* P2df1,
	void* P2dl1,
	void* P2df2,
	void* P2dl2);
extern "C" DECL_EXPORT void ChFiDS_SurfData_Set2dPoints79D6D16B(
	void* instance,
	void* P2df1,
	void* P2dl1,
	void* P2df2,
	void* P2dl2);
extern "C" DECL_EXPORT bool ChFiDS_SurfData_TwistOnS1(void* instance);
extern "C" DECL_EXPORT bool ChFiDS_SurfData_TwistOnS2(void* instance);
extern "C" DECL_EXPORT void ChFiDS_SurfData_TwistOnS1461FC46A(
	void* instance,
	bool T);
extern "C" DECL_EXPORT void ChFiDS_SurfData_TwistOnS2461FC46A(
	void* instance,
	bool T);
extern "C" DECL_EXPORT int ChFiDS_SurfData_IndexOfS1(void* instance);
extern "C" DECL_EXPORT int ChFiDS_SurfData_IndexOfS2(void* instance);
extern "C" DECL_EXPORT bool ChFiDS_SurfData_IsOnCurve1(void* instance);
extern "C" DECL_EXPORT bool ChFiDS_SurfData_IsOnCurve2(void* instance);
extern "C" DECL_EXPORT int ChFiDS_SurfData_Surf(void* instance);
extern "C" DECL_EXPORT int ChFiDS_SurfData_Orientation(void* instance);
extern "C" DECL_EXPORT void* ChFiDS_SurfData_InterferenceOnS1(void* instance);
extern "C" DECL_EXPORT void* ChFiDS_SurfData_InterferenceOnS2(void* instance);
extern "C" DECL_EXPORT void* ChFiDS_SurfData_VertexFirstOnS1(void* instance);
extern "C" DECL_EXPORT void* ChFiDS_SurfData_VertexFirstOnS2(void* instance);
extern "C" DECL_EXPORT void* ChFiDS_SurfData_VertexLastOnS1(void* instance);
extern "C" DECL_EXPORT void* ChFiDS_SurfData_VertexLastOnS2(void* instance);
extern "C" DECL_EXPORT void ChFiDS_SurfData_SetIndexOfC1(void* instance, int value);
extern "C" DECL_EXPORT int ChFiDS_SurfData_IndexOfC1(void* instance);
extern "C" DECL_EXPORT void ChFiDS_SurfData_SetIndexOfC2(void* instance, int value);
extern "C" DECL_EXPORT int ChFiDS_SurfData_IndexOfC2(void* instance);
extern "C" DECL_EXPORT int ChFiDS_SurfData_ChangeOrientation(void* instance);
extern "C" DECL_EXPORT void* ChFiDS_SurfData_ChangeInterferenceOnS1(void* instance);
extern "C" DECL_EXPORT void* ChFiDS_SurfData_ChangeInterferenceOnS2(void* instance);
extern "C" DECL_EXPORT void* ChFiDS_SurfData_ChangeVertexFirstOnS1(void* instance);
extern "C" DECL_EXPORT void* ChFiDS_SurfData_ChangeVertexFirstOnS2(void* instance);
extern "C" DECL_EXPORT void* ChFiDS_SurfData_ChangeVertexLastOnS1(void* instance);
extern "C" DECL_EXPORT void* ChFiDS_SurfData_ChangeVertexLastOnS2(void* instance);
extern "C" DECL_EXPORT void ChFiDS_SurfData_SetSimul(void* instance, void* value);
extern "C" DECL_EXPORT void* ChFiDS_SurfData_Simul(void* instance);
extern "C" DECL_EXPORT void ChFiDSSurfData_Dtor(void* instance);

#endif
