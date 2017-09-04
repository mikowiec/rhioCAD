#ifndef ChFiDS_CommonPoint_H
#define ChFiDS_CommonPoint_H

#include "../../Export_Import.h"

extern "C" DECL_EXPORT void* ChFiDS_CommonPoint_Ctor();
extern "C" DECL_EXPORT void ChFiDS_CommonPoint_Reset(void* instance);
extern "C" DECL_EXPORT void ChFiDS_CommonPoint_SetArc65E3D459(
	void* instance,
	double Tol,
	void* A,
	double Param,
	int TArc);
extern "C" DECL_EXPORT void* ChFiDS_CommonPoint_Arc(void* instance);
extern "C" DECL_EXPORT void ChFiDS_CommonPoint_SetTolerance(void* instance, double value);
extern "C" DECL_EXPORT double ChFiDS_CommonPoint_Tolerance(void* instance);
extern "C" DECL_EXPORT bool ChFiDS_CommonPoint_IsVertex(void* instance);
extern "C" DECL_EXPORT void ChFiDS_CommonPoint_SetVertex(void* instance, void* value);
extern "C" DECL_EXPORT void* ChFiDS_CommonPoint_Vertex(void* instance);
extern "C" DECL_EXPORT bool ChFiDS_CommonPoint_IsOnArc(void* instance);
extern "C" DECL_EXPORT int ChFiDS_CommonPoint_TransitionOnArc(void* instance);
extern "C" DECL_EXPORT double ChFiDS_CommonPoint_ParameterOnArc(void* instance);
extern "C" DECL_EXPORT void ChFiDS_CommonPoint_SetParameter(void* instance, double value);
extern "C" DECL_EXPORT double ChFiDS_CommonPoint_Parameter(void* instance);
extern "C" DECL_EXPORT void ChFiDS_CommonPoint_SetPoint(void* instance, void* value);
extern "C" DECL_EXPORT void* ChFiDS_CommonPoint_Point(void* instance);
extern "C" DECL_EXPORT bool ChFiDS_CommonPoint_HasVector(void* instance);
extern "C" DECL_EXPORT void ChFiDS_CommonPoint_SetVector(void* instance, void* value);
extern "C" DECL_EXPORT void* ChFiDS_CommonPoint_Vector(void* instance);
extern "C" DECL_EXPORT void ChFiDSCommonPoint_Dtor(void* instance);

#endif
