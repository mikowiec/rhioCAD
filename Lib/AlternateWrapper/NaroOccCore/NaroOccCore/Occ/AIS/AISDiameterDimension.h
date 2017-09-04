#ifndef AIS_DiameterDimension_H
#define AIS_DiameterDimension_H

#include "../../Export_Import.h"

extern "C" DECL_EXPORT void* AIS_DiameterDimension_Ctor1C945158(
	void* aShape,
	double aVal,
	void* aText);
extern "C" DECL_EXPORT void* AIS_DiameterDimension_Ctor54910EE4(
	void* aShape,
	double aVal,
	void* aText,
	void* aPosition,
	int aSymbolPrs,
	bool aDiamSymbol,
	double anArrowSize);
extern "C" DECL_EXPORT int AIS_DiameterDimension_KindOfDimension(void* instance);
extern "C" DECL_EXPORT bool AIS_DiameterDimension_IsMovable(void* instance);
extern "C" DECL_EXPORT void AIS_DiameterDimension_SetDiamSymbol(void* instance, bool value);
extern "C" DECL_EXPORT bool AIS_DiameterDimension_DiamSymbol(void* instance);
extern "C" DECL_EXPORT void AISDiameterDimension_Dtor(void* instance);

#endif
