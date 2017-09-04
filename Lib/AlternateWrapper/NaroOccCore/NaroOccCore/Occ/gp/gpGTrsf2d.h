#ifndef gp_GTrsf2d_H
#define gp_GTrsf2d_H

#include "../../Export_Import.h"

extern "C" DECL_EXPORT void* gp_GTrsf2d_Ctor();
extern "C" DECL_EXPORT void* gp_GTrsf2d_Ctor27621DCB(
	void* T);
extern "C" DECL_EXPORT void* gp_GTrsf2d_CtorA0E23F93(
	void* M,
	void* V);
extern "C" DECL_EXPORT void gp_GTrsf2d_SetAffinityF4E58768(
	void* instance,
	void* A,
	double Ratio);
extern "C" DECL_EXPORT void gp_GTrsf2d_SetValue83917674(
	void* instance,
	int Row,
	int Col,
	double Value);
extern "C" DECL_EXPORT double gp_GTrsf2d_Value5107F6FE(
	void* instance,
	int Row,
	int Col);
extern "C" DECL_EXPORT void gp_GTrsf2d_Invert(void* instance);
extern "C" DECL_EXPORT void gp_GTrsf2d_Multiply34614B5D(
	void* instance,
	void* T);
extern "C" DECL_EXPORT void* gp_GTrsf2d_Multiplied34614B5D(
	void* instance,
	void* T);
extern "C" DECL_EXPORT void gp_GTrsf2d_PreMultiply34614B5D(
	void* instance,
	void* T);
extern "C" DECL_EXPORT void gp_GTrsf2d_PowerE8219145(
	void* instance,
	int N);
extern "C" DECL_EXPORT void* gp_GTrsf2d_PoweredE8219145(
	void* instance,
	int N);
extern "C" DECL_EXPORT void gp_GTrsf2d_TransformsE051EF89(
	void* instance,
	void* Coord);
extern "C" DECL_EXPORT void* gp_GTrsf2d_TransformedE051EF89(
	void* instance,
	void* Coord);
extern "C" DECL_EXPORT void gp_GTrsf2d_Transforms9F0E714F(
	void* instance,
	double* X,
	double* Y);
extern "C" DECL_EXPORT bool gp_GTrsf2d_IsNegative(void* instance);
extern "C" DECL_EXPORT bool gp_GTrsf2d_IsSingular(void* instance);
extern "C" DECL_EXPORT int gp_GTrsf2d_Form(void* instance);
extern "C" DECL_EXPORT void gp_GTrsf2d_SetTranslationPart(void* instance, void* value);
extern "C" DECL_EXPORT void* gp_GTrsf2d_TranslationPart(void* instance);
extern "C" DECL_EXPORT void gp_GTrsf2d_SetVectorialPart(void* instance, void* value);
extern "C" DECL_EXPORT void* gp_GTrsf2d_VectorialPart(void* instance);
extern "C" DECL_EXPORT void* gp_GTrsf2d_Inverted(void* instance);
extern "C" DECL_EXPORT void gp_GTrsf2d_SetTrsf2d(void* instance, void* value);
extern "C" DECL_EXPORT void* gp_GTrsf2d_Trsf2d(void* instance);
extern "C" DECL_EXPORT void gpGTrsf2d_Dtor(void* instance);

#endif
