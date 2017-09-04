#include "BOPListIteratorOfListOfEdgeInfo.h"
#include <BOP_ListIteratorOfListOfEdgeInfo.hxx>

#include <BOP_EdgeInfo.hxx>

DECL_EXPORT void* BOP_ListIteratorOfListOfEdgeInfo_Ctor()
{
	return new BOP_ListIteratorOfListOfEdgeInfo();
}
DECL_EXPORT void* BOP_ListIteratorOfListOfEdgeInfo_CtorBB93B226(
	void* L)
{
		const BOP_ListOfEdgeInfo &  _L =*(const BOP_ListOfEdgeInfo *)L;
	return new BOP_ListIteratorOfListOfEdgeInfo(			
_L);
}
DECL_EXPORT void BOP_ListIteratorOfListOfEdgeInfo_InitializeBB93B226(
	void* instance,
	void* L)
{
		const BOP_ListOfEdgeInfo &  _L =*(const BOP_ListOfEdgeInfo *)L;
	BOP_ListIteratorOfListOfEdgeInfo* result = (BOP_ListIteratorOfListOfEdgeInfo*)instance;
 	result->Initialize(			
_L);
}
DECL_EXPORT void BOP_ListIteratorOfListOfEdgeInfo_Next(void* instance)
{
	BOP_ListIteratorOfListOfEdgeInfo* result = (BOP_ListIteratorOfListOfEdgeInfo*)instance;
 	result->Next();
}
DECL_EXPORT bool BOP_ListIteratorOfListOfEdgeInfo_More(void* instance)
{
	BOP_ListIteratorOfListOfEdgeInfo* result = (BOP_ListIteratorOfListOfEdgeInfo*)instance;
	return 	result->More();
}

DECL_EXPORT void* BOP_ListIteratorOfListOfEdgeInfo_Value(void* instance)
{
	BOP_ListIteratorOfListOfEdgeInfo* result = (BOP_ListIteratorOfListOfEdgeInfo*)instance;
	return 	new BOP_EdgeInfo(	result->Value());
}

DECL_EXPORT void BOPListIteratorOfListOfEdgeInfo_Dtor(void* instance)
{
	delete (BOP_ListIteratorOfListOfEdgeInfo*)instance;
}
