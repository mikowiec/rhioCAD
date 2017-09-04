#ifndef BOP_ListIteratorOfListOfEdgeInfo_H
#define BOP_ListIteratorOfListOfEdgeInfo_H

#include "../../Export_Import.h"

extern "C" DECL_EXPORT void* BOP_ListIteratorOfListOfEdgeInfo_Ctor();
extern "C" DECL_EXPORT void* BOP_ListIteratorOfListOfEdgeInfo_CtorBB93B226(
	void* L);
extern "C" DECL_EXPORT void BOP_ListIteratorOfListOfEdgeInfo_InitializeBB93B226(
	void* instance,
	void* L);
extern "C" DECL_EXPORT void BOP_ListIteratorOfListOfEdgeInfo_Next(void* instance);
extern "C" DECL_EXPORT bool BOP_ListIteratorOfListOfEdgeInfo_More(void* instance);
extern "C" DECL_EXPORT void* BOP_ListIteratorOfListOfEdgeInfo_Value(void* instance);
extern "C" DECL_EXPORT void BOPListIteratorOfListOfEdgeInfo_Dtor(void* instance);

#endif
