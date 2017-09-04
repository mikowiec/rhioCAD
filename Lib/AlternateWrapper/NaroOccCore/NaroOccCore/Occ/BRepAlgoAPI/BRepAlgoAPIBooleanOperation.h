#ifndef BRepAlgoAPI_BooleanOperation_H
#define BRepAlgoAPI_BooleanOperation_H

#include "../../Export_Import.h"

extern "C" DECL_EXPORT void BRepAlgoAPI_BooleanOperation_Build(void* instance);
extern "C" DECL_EXPORT void BRepAlgoAPI_BooleanOperation_RefineEdges(void* instance);
extern "C" DECL_EXPORT bool BRepAlgoAPI_BooleanOperation_IsDeleted9EBAC0C0(
	void* instance,
	void* aS);
extern "C" DECL_EXPORT void BRepAlgoAPI_BooleanOperation_Destroy(void* instance);
extern "C" DECL_EXPORT void* BRepAlgoAPI_BooleanOperation_Shape1(void* instance);
extern "C" DECL_EXPORT void* BRepAlgoAPI_BooleanOperation_Shape2(void* instance);
extern "C" DECL_EXPORT void BRepAlgoAPI_BooleanOperation_SetOperation(void* instance, int value);
extern "C" DECL_EXPORT int BRepAlgoAPI_BooleanOperation_Operation(void* instance);
extern "C" DECL_EXPORT bool BRepAlgoAPI_BooleanOperation_FuseEdges(void* instance);
extern "C" DECL_EXPORT bool BRepAlgoAPI_BooleanOperation_BuilderCanWork(void* instance);
extern "C" DECL_EXPORT int BRepAlgoAPI_BooleanOperation_ErrorStatus(void* instance);
extern "C" DECL_EXPORT bool BRepAlgoAPI_BooleanOperation_HasModified(void* instance);
extern "C" DECL_EXPORT bool BRepAlgoAPI_BooleanOperation_HasGenerated(void* instance);
extern "C" DECL_EXPORT bool BRepAlgoAPI_BooleanOperation_HasDeleted(void* instance);
extern "C" DECL_EXPORT void BRepAlgoAPIBooleanOperation_Dtor(void* instance);

#endif
