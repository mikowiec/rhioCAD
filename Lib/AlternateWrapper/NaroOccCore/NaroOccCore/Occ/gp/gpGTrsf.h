#ifndef gp_GTrsf_H
#define gp_GTrsf_H

#include "../../Export_Import.h"

extern "C" DECL_EXPORT void* gp_GTrsf_Ctor();
extern "C" DECL_EXPORT void* gp_GTrsf_Ctor72D78650(
	void* T);
extern "C" DECL_EXPORT void* gp_GTrsf_CtorD1BD2BB9(
	void* M,
	void* V);
extern "C" DECL_EXPORT void gp_GTrsf_SetAffinity827CB19A(
	void* instance,
	void* A1,
	double Ratio);
extern "C" DECL_EXPORT void gp_GTrsf_SetAffinity673FA07D(
	void* instance,
	void* A2,
	double Ratio);
extern "C" DECL_EXPORT void gp_GTrsf_SetValue83917674(
	void* instance,
	int Row,
	int Col,
	double Value);
extern "C" DECL_EXPORT int gp_GTrsf_Form(void* instance);
extern "C" DECL_EXPORT void gp_GTrsf_SetForm(void* instance);
extern "C" DECL_EXPORT double gp_GTrsf_Value5107F6FE(
	void* instance,
	int Row,
	int Col);
extern "C" DECL_EXPORT void gp_GTrsf_Invert(void* instance);
extern "C" DECL_EXPORT void gp_GTrsf_MultiplyD8FBA6AB(
	void* instance,
	void* T);
extern "C" DECL_EXPORT void* gp_GTrsf_MultipliedD8FBA6AB(
	void* instance,
	void* T);
extern "C" DECL_EXPORT void gp_GTrsf_PreMultiplyD8FBA6AB(
	void* instance,
	void* T);
extern "C" DECL_EXPORT void gp_GTrsf_PowerE8219145(
	void* instance,
	int N);
extern "C" DECL_EXPORT void* gp_GTrsf_PoweredE8219145(
	void* instance,
	int N);
extern "C" DECL_EXPORT void gp_GTrsf_Transforms8EE42329(
	void* instance,
	void* Coord);
extern "C" DECL_EXPORT void gp_GTrsf_Transforms9282A951(
	void* instance,
	double* X,
	double* Y,
	double* Z);
extern "C" DECL_EXPORT bool gp_GTrsf_IsNegative(void* instance);
extern "C" DECL_EXPORT bool gp_GTrsf_IsSingular(void* instance);
extern "C" DECL_EXPORT void gp_GTrsf_SetTranslationPart(void* instance, void* value);
extern "C" DECL_EXPORT void* gp_GTrsf_TranslationPart(void* instance);
extern "C" DECL_EXPORT void gp_GTrsf_SetVectorialPart(void* instance, void* value);
extern "C" DECL_EXPORT void* gp_GTrsf_VectorialPart(void* instance);
extern "C" DECL_EXPORT void* gp_GTrsf_Inverted(void* instance);
extern "C" DECL_EXPORT void gp_GTrsf_SetTrsf(void* instance, void* value);
extern "C" DECL_EXPORT void* gp_GTrsf_Trsf(void* instance);
extern "C" DECL_EXPORT void gpGTrsf_Dtor(void* instance);

#endif
