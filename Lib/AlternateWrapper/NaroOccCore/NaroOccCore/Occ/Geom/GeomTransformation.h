#ifndef Geom_Transformation_H
#define Geom_Transformation_H

#include "../../Export_Import.h"

extern "C" DECL_EXPORT void* Geom_Transformation_Ctor();
extern "C" DECL_EXPORT void* Geom_Transformation_Ctor72D78650(
	void* T);
extern "C" DECL_EXPORT void Geom_Transformation_SetMirror9EAECD5B(
	void* instance,
	void* P);
extern "C" DECL_EXPORT void Geom_Transformation_SetMirror608B963B(
	void* instance,
	void* A1);
extern "C" DECL_EXPORT void Geom_Transformation_SetMirror7895386A(
	void* instance,
	void* A2);
extern "C" DECL_EXPORT void Geom_Transformation_SetRotation827CB19A(
	void* instance,
	void* A1,
	double Ang);
extern "C" DECL_EXPORT void Geom_Transformation_SetScaleF0D1E3E6(
	void* instance,
	void* P,
	double S);
extern "C" DECL_EXPORT void Geom_Transformation_SetTransformationB5D8FD04(
	void* instance,
	void* FromSystem1,
	void* ToSystem2);
extern "C" DECL_EXPORT void Geom_Transformation_SetTransformation1B3CAD05(
	void* instance,
	void* ToSystem);
extern "C" DECL_EXPORT void Geom_Transformation_SetTranslation9BD9CFFE(
	void* instance,
	void* V);
extern "C" DECL_EXPORT void Geom_Transformation_SetTranslation5C63477E(
	void* instance,
	void* P1,
	void* P2);
extern "C" DECL_EXPORT double Geom_Transformation_Value5107F6FE(
	void* instance,
	int Row,
	int Col);
extern "C" DECL_EXPORT void Geom_Transformation_Invert(void* instance);
extern "C" DECL_EXPORT void* Geom_Transformation_Multiplied23447582(
	void* instance,
	void* Other);
extern "C" DECL_EXPORT void Geom_Transformation_Multiply23447582(
	void* instance,
	void* Other);
extern "C" DECL_EXPORT void Geom_Transformation_PowerE8219145(
	void* instance,
	int N);
extern "C" DECL_EXPORT void* Geom_Transformation_PoweredE8219145(
	void* instance,
	int N);
extern "C" DECL_EXPORT void Geom_Transformation_PreMultiply23447582(
	void* instance,
	void* Other);
extern "C" DECL_EXPORT void Geom_Transformation_Transforms9282A951(
	void* instance,
	double* X,
	double* Y,
	double* Z);
extern "C" DECL_EXPORT bool Geom_Transformation_IsNegative(void* instance);
extern "C" DECL_EXPORT int Geom_Transformation_Form(void* instance);
extern "C" DECL_EXPORT double Geom_Transformation_ScaleFactor(void* instance);
extern "C" DECL_EXPORT void Geom_Transformation_SetTrsf(void* instance, void* value);
extern "C" DECL_EXPORT void* Geom_Transformation_Trsf(void* instance);
extern "C" DECL_EXPORT void* Geom_Transformation_Inverted(void* instance);
extern "C" DECL_EXPORT void* Geom_Transformation_Copy(void* instance);
extern "C" DECL_EXPORT void GeomTransformation_Dtor(void* instance);

#endif
