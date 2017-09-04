#ifndef TopExp_H
#define TopExp_H

#include "../../Export_Import.h"

extern "C" DECL_EXPORT void TopExp_MapShapes9B2ADE8F(
	void* S,
	int T,
	void* M);
extern "C" DECL_EXPORT void TopExp_MapShapesBBDCAF89(
	void* S,
	void* M);
extern "C" DECL_EXPORT void TopExp_MapShapesAndAncestors1E6131DC(
	void* S,
	int TS,
	int TA,
	void* M);
extern "C" DECL_EXPORT void* TopExp_FirstVertex7F8C607A(
	void* E,
	bool CumOri);
extern "C" DECL_EXPORT void* TopExp_LastVertex7F8C607A(
	void* E,
	bool CumOri);
extern "C" DECL_EXPORT void TopExp_VerticesCB378621(
	void* E,
	void* Vfirst,
	void* Vlast,
	bool CumOri);
extern "C" DECL_EXPORT void TopExp_Vertices1DDDA71C(
	void* W,
	void* Vfirst,
	void* Vlast);
extern "C" DECL_EXPORT bool TopExp_CommonVertexE5EE178A(
	void* E1,
	void* E2,
	void* V);
extern "C" DECL_EXPORT void TopExp_Dtor(void* instance);

#endif
