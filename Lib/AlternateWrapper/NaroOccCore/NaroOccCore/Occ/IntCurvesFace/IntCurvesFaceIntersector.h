#ifndef IntCurvesFace_Intersector_H
#define IntCurvesFace_Intersector_H

#include "../../Export_Import.h"

extern "C" DECL_EXPORT void* IntCurvesFace_Intersector_Ctor5D6B238E(
	void* F,
	double aTol);
extern "C" DECL_EXPORT void IntCurvesFace_Intersector_Perform13A123E9(
	void* instance,
	void* L,
	double PInf,
	double PSup);
extern "C" DECL_EXPORT void IntCurvesFace_Intersector_Perform42BE7C73(
	void* instance,
	void* HCu,
	double PInf,
	double PSup);
extern "C" DECL_EXPORT double IntCurvesFace_Intersector_UParameterE8219145(
	void* instance,
	int I);
extern "C" DECL_EXPORT double IntCurvesFace_Intersector_VParameterE8219145(
	void* instance,
	int I);
extern "C" DECL_EXPORT double IntCurvesFace_Intersector_WParameterE8219145(
	void* instance,
	int I);
extern "C" DECL_EXPORT void* IntCurvesFace_Intersector_PntE8219145(
	void* instance,
	int I);
extern "C" DECL_EXPORT int IntCurvesFace_Intersector_TransitionE8219145(
	void* instance,
	int I);
extern "C" DECL_EXPORT int IntCurvesFace_Intersector_StateE8219145(
	void* instance,
	int I);
extern "C" DECL_EXPORT int IntCurvesFace_Intersector_ClassifyUVPoint6203658C(
	void* instance,
	void* Puv);
extern "C" DECL_EXPORT int IntCurvesFace_Intersector_SurfaceType(void* instance);
extern "C" DECL_EXPORT bool IntCurvesFace_Intersector_IsDone(void* instance);
extern "C" DECL_EXPORT int IntCurvesFace_Intersector_NbPnt(void* instance);
extern "C" DECL_EXPORT void* IntCurvesFace_Intersector_Face(void* instance);
extern "C" DECL_EXPORT void* IntCurvesFace_Intersector_Bounding(void* instance);
extern "C" DECL_EXPORT void IntCurvesFaceIntersector_Dtor(void* instance);

#endif
