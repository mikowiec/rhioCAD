#ifndef BOP_ListOfEdgeInfo_H
#define BOP_ListOfEdgeInfo_H

#include "../../Export_Import.h"

extern "C" DECL_EXPORT void* BOP_ListOfEdgeInfo_Ctor();
extern "C" DECL_EXPORT void BOP_ListOfEdgeInfo_AssignBB93B226(
	void* instance,
	void* Other);
extern "C" DECL_EXPORT void BOP_ListOfEdgeInfo_Prepend6C1C9DDA(
	void* instance,
	void* I);
extern "C" DECL_EXPORT void BOP_ListOfEdgeInfo_Prepend7EDD85A0(
	void* instance,
	void* I,
	void* theIt);
extern "C" DECL_EXPORT void BOP_ListOfEdgeInfo_PrependBB93B226(
	void* instance,
	void* Other);
extern "C" DECL_EXPORT void BOP_ListOfEdgeInfo_Append6C1C9DDA(
	void* instance,
	void* I);
extern "C" DECL_EXPORT void BOP_ListOfEdgeInfo_Append7EDD85A0(
	void* instance,
	void* I,
	void* theIt);
extern "C" DECL_EXPORT void BOP_ListOfEdgeInfo_AppendBB93B226(
	void* instance,
	void* Other);
extern "C" DECL_EXPORT void BOP_ListOfEdgeInfo_RemoveFirst(void* instance);
extern "C" DECL_EXPORT void BOP_ListOfEdgeInfo_RemoveF9227B7D(
	void* instance,
	void* It);
extern "C" DECL_EXPORT void BOP_ListOfEdgeInfo_InsertBefore7EDD85A0(
	void* instance,
	void* I,
	void* It);
extern "C" DECL_EXPORT void BOP_ListOfEdgeInfo_InsertBefore7A35FC8F(
	void* instance,
	void* Other,
	void* It);
extern "C" DECL_EXPORT void BOP_ListOfEdgeInfo_InsertAfter7EDD85A0(
	void* instance,
	void* I,
	void* It);
extern "C" DECL_EXPORT void BOP_ListOfEdgeInfo_InsertAfter7A35FC8F(
	void* instance,
	void* Other,
	void* It);
extern "C" DECL_EXPORT int BOP_ListOfEdgeInfo_Extent(void* instance);
extern "C" DECL_EXPORT bool BOP_ListOfEdgeInfo_IsEmpty(void* instance);
extern "C" DECL_EXPORT void* BOP_ListOfEdgeInfo_First(void* instance);
extern "C" DECL_EXPORT void* BOP_ListOfEdgeInfo_Last(void* instance);
extern "C" DECL_EXPORT void BOPListOfEdgeInfo_Dtor(void* instance);

#endif
