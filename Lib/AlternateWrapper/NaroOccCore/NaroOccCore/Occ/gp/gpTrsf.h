#ifndef gp_Trsf_H
#define gp_Trsf_H

#include "../../Export_Import.h"

extern "C" DECL_EXPORT void* gp_Trsf_Ctor();
extern "C" DECL_EXPORT void* gp_Trsf_Ctor27621DCB(
	void* T);
extern "C" DECL_EXPORT void gp_Trsf_SetMirror9EAECD5B(
	void* instance,
	void* P);
extern "C" DECL_EXPORT void gp_Trsf_SetMirror608B963B(
	void* instance,
	void* A1);
extern "C" DECL_EXPORT void gp_Trsf_SetMirror7895386A(
	void* instance,
	void* A2);
extern "C" DECL_EXPORT void gp_Trsf_SetRotation827CB19A(
	void* instance,
	void* A1,
	double Ang);
extern "C" DECL_EXPORT void gp_Trsf_SetScaleF0D1E3E6(
	void* instance,
	void* P,
	double S);
extern "C" DECL_EXPORT void gp_Trsf_SetDisplacementB5D8FD04(
	void* instance,
	void* FromSystem1,
	void* ToSystem2);
extern "C" DECL_EXPORT void gp_Trsf_SetTransformationB5D8FD04(
	void* instance,
	void* FromSystem1,
	void* ToSystem2);
extern "C" DECL_EXPORT void gp_Trsf_SetTransformation1B3CAD05(
	void* instance,
	void* ToSystem);
extern "C" DECL_EXPORT void gp_Trsf_SetTranslation9BD9CFFE(
	void* instance,
	void* V);
extern "C" DECL_EXPORT void gp_Trsf_SetTranslation5C63477E(
	void* instance,
	void* P1,
	void* P2);
extern "C" DECL_EXPORT void gp_Trsf_SetValues4D4A9FE3(
	void* instance,
	double a11,
	double a12,
	double a13,
	double a14,
	double a21,
	double a22,
	double a23,
	double a24,
	double a31,
	double a32,
	double a33,
	double a34,
	double Tolang,
	double TolDist);
extern "C" DECL_EXPORT bool gp_Trsf_GetRotationAC21764D(
	void* instance,
	void* theAxis,
	double* theAngle);
extern "C" DECL_EXPORT double gp_Trsf_Value5107F6FE(
	void* instance,
	int Row,
	int Col);
extern "C" DECL_EXPORT void gp_Trsf_Invert(void* instance);
extern "C" DECL_EXPORT void* gp_Trsf_Multiplied72D78650(
	void* instance,
	void* T);
extern "C" DECL_EXPORT void gp_Trsf_Multiply72D78650(
	void* instance,
	void* T);
extern "C" DECL_EXPORT void gp_Trsf_PreMultiply72D78650(
	void* instance,
	void* T);
extern "C" DECL_EXPORT void gp_Trsf_PowerE8219145(
	void* instance,
	int N);
extern "C" DECL_EXPORT void* gp_Trsf_PoweredE8219145(
	void* instance,
	int N);
extern "C" DECL_EXPORT void gp_Trsf_Transforms9282A951(
	void* instance,
	double* X,
	double* Y,
	double* Z);
extern "C" DECL_EXPORT void gp_Trsf_Transforms8EE42329(
	void* instance,
	void* Coord);
extern "C" DECL_EXPORT bool gp_Trsf_IsNegative(void* instance);
extern "C" DECL_EXPORT int gp_Trsf_Form(void* instance);
extern "C" DECL_EXPORT void gp_Trsf_SetScaleFactor(void* instance, double value);
extern "C" DECL_EXPORT double gp_Trsf_ScaleFactor(void* instance);
extern "C" DECL_EXPORT void gp_Trsf_SetTranslationPart(void* instance, void* value);
extern "C" DECL_EXPORT void* gp_Trsf_TranslationPart(void* instance);
extern "C" DECL_EXPORT void* gp_Trsf_VectorialPart(void* instance);
extern "C" DECL_EXPORT void* gp_Trsf_HVectorialPart(void* instance);
extern "C" DECL_EXPORT void* gp_Trsf_Inverted(void* instance);
extern "C" DECL_EXPORT void gpTrsf_Dtor(void* instance);

#endif
