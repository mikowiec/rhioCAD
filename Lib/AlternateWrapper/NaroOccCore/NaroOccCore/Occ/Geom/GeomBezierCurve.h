#ifndef Geom_BezierCurve_H
#define Geom_BezierCurve_H

#include "../../Export_Import.h"

extern "C" DECL_EXPORT void* Geom_BezierCurve_CtorFABD0F95(
	void* CurvePoles);
extern "C" DECL_EXPORT void Geom_BezierCurve_IncreaseE8219145(
	void* instance,
	int Degree);
extern "C" DECL_EXPORT void Geom_BezierCurve_InsertPoleAfter7B5D1E58(
	void* instance,
	int Index,
	void* P);
extern "C" DECL_EXPORT void Geom_BezierCurve_InsertPoleAfter7C5189B4(
	void* instance,
	int Index,
	void* P,
	double Weight);
extern "C" DECL_EXPORT void Geom_BezierCurve_InsertPoleBefore7B5D1E58(
	void* instance,
	int Index,
	void* P);
extern "C" DECL_EXPORT void Geom_BezierCurve_InsertPoleBefore7C5189B4(
	void* instance,
	int Index,
	void* P,
	double Weight);
extern "C" DECL_EXPORT void Geom_BezierCurve_RemovePoleE8219145(
	void* instance,
	int Index);
extern "C" DECL_EXPORT void Geom_BezierCurve_Reverse(void* instance);
extern "C" DECL_EXPORT double Geom_BezierCurve_ReversedParameterD82819F3(
	void* instance,
	double U);
extern "C" DECL_EXPORT void Geom_BezierCurve_Segment9F0E714F(
	void* instance,
	double U1,
	double U2);
extern "C" DECL_EXPORT void Geom_BezierCurve_SetPole7B5D1E58(
	void* instance,
	int Index,
	void* P);
extern "C" DECL_EXPORT void Geom_BezierCurve_SetPole7C5189B4(
	void* instance,
	int Index,
	void* P,
	double Weight);
extern "C" DECL_EXPORT void Geom_BezierCurve_SetWeight69F5FCCD(
	void* instance,
	int Index,
	double Weight);
extern "C" DECL_EXPORT bool Geom_BezierCurve_IsCNE8219145(
	void* instance,
	int N);
extern "C" DECL_EXPORT void Geom_BezierCurve_D053A5A2C1(
	void* instance,
	double U,
	void* P);
extern "C" DECL_EXPORT void Geom_BezierCurve_D11387A81(
	void* instance,
	double U,
	void* P,
	void* V1);
extern "C" DECL_EXPORT void Geom_BezierCurve_D227877840(
	void* instance,
	double U,
	void* P,
	void* V1,
	void* V2);
extern "C" DECL_EXPORT void Geom_BezierCurve_D356E36E6F(
	void* instance,
	double U,
	void* P,
	void* V1,
	void* V2,
	void* V3);
extern "C" DECL_EXPORT void* Geom_BezierCurve_DN2935ABDE(
	void* instance,
	double U,
	int N);
extern "C" DECL_EXPORT void* Geom_BezierCurve_PoleE8219145(
	void* instance,
	int Index);
extern "C" DECL_EXPORT void Geom_BezierCurve_PolesFABD0F95(
	void* instance,
	void* P);
extern "C" DECL_EXPORT double Geom_BezierCurve_WeightE8219145(
	void* instance,
	int Index);
extern "C" DECL_EXPORT void Geom_BezierCurve_Transform72D78650(
	void* instance,
	void* T);
extern "C" DECL_EXPORT void Geom_BezierCurve_Resolution9F0E714F(
	void* instance,
	double Tolerance3D,
	double* UTolerance);
extern "C" DECL_EXPORT bool Geom_BezierCurve_IsClosed(void* instance);
extern "C" DECL_EXPORT bool Geom_BezierCurve_IsPeriodic(void* instance);
extern "C" DECL_EXPORT bool Geom_BezierCurve_IsRational(void* instance);
extern "C" DECL_EXPORT int Geom_BezierCurve_Continuity(void* instance);
extern "C" DECL_EXPORT int Geom_BezierCurve_Degree(void* instance);
extern "C" DECL_EXPORT void* Geom_BezierCurve_StartPoint(void* instance);
extern "C" DECL_EXPORT void* Geom_BezierCurve_EndPoint(void* instance);
extern "C" DECL_EXPORT double Geom_BezierCurve_FirstParameter(void* instance);
extern "C" DECL_EXPORT double Geom_BezierCurve_LastParameter(void* instance);
extern "C" DECL_EXPORT int Geom_BezierCurve_NbPoles(void* instance);
extern "C" DECL_EXPORT int Geom_BezierCurve_MaxDegree();
extern "C" DECL_EXPORT void* Geom_BezierCurve_Copy(void* instance);
extern "C" DECL_EXPORT void GeomBezierCurve_Dtor(void* instance);

#endif
