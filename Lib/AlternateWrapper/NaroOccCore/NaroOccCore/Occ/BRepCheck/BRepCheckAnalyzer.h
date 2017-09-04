#ifndef BRepCheck_Analyzer_H
#define BRepCheck_Analyzer_H

#include "../../Export_Import.h"

extern "C" DECL_EXPORT void* BRepCheck_Analyzer_Ctor5E7DD5C8(
	void* S,
	bool GeomControls);
extern "C" DECL_EXPORT void BRepCheck_Analyzer_Init5E7DD5C8(
	void* instance,
	void* S,
	bool GeomControls);
extern "C" DECL_EXPORT bool BRepCheck_Analyzer_IsValid9EBAC0C0(
	void* instance,
	void* S);
extern "C" DECL_EXPORT bool BRepCheck_Analyzer_IsValid(void* instance);
extern "C" DECL_EXPORT void BRepCheckAnalyzer_Dtor(void* instance);

#endif
