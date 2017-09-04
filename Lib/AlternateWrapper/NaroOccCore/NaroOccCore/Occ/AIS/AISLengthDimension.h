#ifndef AIS_LengthDimension_H
#define AIS_LengthDimension_H

#include "../../Export_Import.h"

extern "C" DECL_EXPORT void* AIS_LengthDimension_CtorE30AADB(
	void* aFirstFace,
	void* aSecondFace,
	double aVal,
	void* aText);
extern "C" DECL_EXPORT void* AIS_LengthDimension_Ctor5485084F(
	void* aFirstFace,
	void* aSecondFace,
	double aVal,
	void* aText,
	void* aPosition,
	int aSymbolPrs,
	double anArrowSize);
extern "C" DECL_EXPORT void* AIS_LengthDimension_CtorC2ADA788(
	void* Face,
	void* Edge,
	double Val,
	void* Text);
extern "C" DECL_EXPORT void* AIS_LengthDimension_CtorFBAAB8FA(
	void* aFShape,
	void* aSShape,
	void* aPlane,
	double aVal,
	void* aText);
extern "C" DECL_EXPORT void* AIS_LengthDimension_CtorEA089509(
	void* aFShape,
	void* aSShape,
	void* aPlane,
	double aVal,
	void* aText,
	void* aPosition,
	int aSymbolPrs,
	int aTypeDist,
	double anArrowSize);
extern "C" DECL_EXPORT void AIS_LengthDimension_SetFirstShape(void* instance, void* value);
extern "C" DECL_EXPORT void AIS_LengthDimension_SetSecondShape(void* instance, void* value);
extern "C" DECL_EXPORT int AIS_LengthDimension_KindOfDimension(void* instance);
extern "C" DECL_EXPORT bool AIS_LengthDimension_IsMovable(void* instance);
extern "C" DECL_EXPORT void AIS_LengthDimension_SetTypeOfDist(void* instance, int value);
extern "C" DECL_EXPORT int AIS_LengthDimension_TypeOfDist(void* instance);
extern "C" DECL_EXPORT void AISLengthDimension_Dtor(void* instance);

#endif
