#ifndef TopoDS_Builder_H
#define TopoDS_Builder_H

#include "../../Export_Import.h"

extern "C" DECL_EXPORT void TopoDS_Builder_MakeWire368EDFE5(
	void* instance,
	void* W);
extern "C" DECL_EXPORT void TopoDS_Builder_MakeShell41B0EE4D(
	void* instance,
	void* S);
extern "C" DECL_EXPORT void TopoDS_Builder_MakeSolid56111E92(
	void* instance,
	void* S);
extern "C" DECL_EXPORT void TopoDS_Builder_MakeCompSolid2CBA9E0B(
	void* instance,
	void* C);
extern "C" DECL_EXPORT void TopoDS_Builder_MakeCompoundF7963FEC(
	void* instance,
	void* C);
extern "C" DECL_EXPORT void TopoDS_Builder_Add877A736F(
	void* instance,
	void* S,
	void* C);
extern "C" DECL_EXPORT void TopoDS_Builder_Remove877A736F(
	void* instance,
	void* S,
	void* C);
extern "C" DECL_EXPORT void TopoDSBuilder_Dtor(void* instance);

#endif
