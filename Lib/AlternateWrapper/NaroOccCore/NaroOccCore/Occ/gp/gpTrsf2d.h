#ifndef gp_Trsf2d_H
#define gp_Trsf2d_H

#include "../../Export_Import.h"

extern "C" DECL_EXPORT void* gp_Trsf2d_Ctor();
extern "C" DECL_EXPORT void* gp_Trsf2d_Ctor72D78650(
	void* T);
extern "C" DECL_EXPORT void gp_Trsf2d_SetMirror6203658C(
	void* instance,
	void* P);
extern "C" DECL_EXPORT void gp_Trsf2d_SetMirror90E1386A(
	void* instance,
	void* A);
extern "C" DECL_EXPORT void gp_Trsf2d_SetRotationE3062737(
	void* instance,
	void* P,
	double Ang);
extern "C" DECL_EXPORT void gp_Trsf2d_SetScaleE3062737(
	void* instance,
	void* P,
	double S);
extern "C" DECL_EXPORT void gp_Trsf2d_SetTransformation1A99B821(
	void* instance,
	void* FromSystem1,
	void* ToSystem2);
extern "C" DECL_EXPORT void gp_Trsf2d_SetTransformation90E1386A(
	void* instance,
	void* ToSystem);
extern "C" DECL_EXPORT void gp_Trsf2d_SetTranslation5E4E66E7(
	void* instance,
	void* V);
extern "C" DECL_EXPORT void gp_Trsf2d_SetTranslation5F54ADE3(
	void* instance,
	void* P1,
	void* P2);
extern "C" DECL_EXPORT double gp_Trsf2d_Value5107F6FE(
	void* instance,
	int Row,
	int Col);
extern "C" DECL_EXPORT void gp_Trsf2d_Invert(void* instance);
extern "C" DECL_EXPORT void* gp_Trsf2d_Multiplied27621DCB(
	void* instance,
	void* T);
extern "C" DECL_EXPORT void gp_Trsf2d_Multiply27621DCB(
	void* instance,
	void* T);
extern "C" DECL_EXPORT void gp_Trsf2d_PreMultiply27621DCB(
	void* instance,
	void* T);
extern "C" DECL_EXPORT void gp_Trsf2d_PowerE8219145(
	void* instance,
	int N);
extern "C" DECL_EXPORT void* gp_Trsf2d_PoweredE8219145(
	void* instance,
	int N);
extern "C" DECL_EXPORT void gp_Trsf2d_Transforms9F0E714F(
	void* instance,
	double* X,
	double* Y);
extern "C" DECL_EXPORT void gp_Trsf2d_TransformsE051EF89(
	void* instance,
	void* Coord);
extern "C" DECL_EXPORT bool gp_Trsf2d_IsNegative(void* instance);
extern "C" DECL_EXPORT int gp_Trsf2d_Form(void* instance);
extern "C" DECL_EXPORT void gp_Trsf2d_SetScaleFactor(void* instance, double value);
extern "C" DECL_EXPORT double gp_Trsf2d_ScaleFactor(void* instance);
extern "C" DECL_EXPORT void gp_Trsf2d_SetTranslationPart(void* instance, void* value);
extern "C" DECL_EXPORT void* gp_Trsf2d_TranslationPart(void* instance);
extern "C" DECL_EXPORT void* gp_Trsf2d_VectorialPart(void* instance);
extern "C" DECL_EXPORT void* gp_Trsf2d_HVectorialPart(void* instance);
extern "C" DECL_EXPORT double gp_Trsf2d_RotationPart(void* instance);
extern "C" DECL_EXPORT void* gp_Trsf2d_Inverted(void* instance);
extern "C" DECL_EXPORT void gpTrsf2d_Dtor(void* instance);

#endif
