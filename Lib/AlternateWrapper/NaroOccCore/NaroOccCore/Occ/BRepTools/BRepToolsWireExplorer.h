#ifndef BRepTools_WireExplorer_H
#define BRepTools_WireExplorer_H

#include "../../Export_Import.h"

extern "C" DECL_EXPORT void* BRepTools_WireExplorer_Ctor();
extern "C" DECL_EXPORT void* BRepTools_WireExplorer_Ctor368EDFE5(
	void* W);
extern "C" DECL_EXPORT void* BRepTools_WireExplorer_Ctor3BE52234(
	void* W,
	void* F);
extern "C" DECL_EXPORT void BRepTools_WireExplorer_Init368EDFE5(
	void* instance,
	void* W);
extern "C" DECL_EXPORT void BRepTools_WireExplorer_Init3BE52234(
	void* instance,
	void* W,
	void* F);
extern "C" DECL_EXPORT void BRepTools_WireExplorer_Next(void* instance);
extern "C" DECL_EXPORT void BRepTools_WireExplorer_Clear(void* instance);
extern "C" DECL_EXPORT bool BRepTools_WireExplorer_More(void* instance);
extern "C" DECL_EXPORT void* BRepTools_WireExplorer_Current(void* instance);
extern "C" DECL_EXPORT int BRepTools_WireExplorer_Orientation(void* instance);
extern "C" DECL_EXPORT void* BRepTools_WireExplorer_CurrentVertex(void* instance);
extern "C" DECL_EXPORT void BRepToolsWireExplorer_Dtor(void* instance);

#endif
