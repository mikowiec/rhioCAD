#include "BOPListOfEdgeInfo.h"
#include <BOP_ListOfEdgeInfo.hxx>

#include <BOP_EdgeInfo.hxx>

DECL_EXPORT void* BOP_ListOfEdgeInfo_Ctor()
{
	return new BOP_ListOfEdgeInfo();
}
DECL_EXPORT void BOP_ListOfEdgeInfo_AssignBB93B226(
	void* instance,
	void* Other)
{
		const BOP_ListOfEdgeInfo &  _Other =*(const BOP_ListOfEdgeInfo *)Other;
	BOP_ListOfEdgeInfo* result = (BOP_ListOfEdgeInfo*)instance;
 	result->Assign(			
_Other);
}
DECL_EXPORT void BOP_ListOfEdgeInfo_Prepend6C1C9DDA(
	void* instance,
	void* I)
{
		const BOP_EdgeInfo &  _I =*(const BOP_EdgeInfo *)I;
	BOP_ListOfEdgeInfo* result = (BOP_ListOfEdgeInfo*)instance;
 	result->Prepend(			
_I);
}
DECL_EXPORT void BOP_ListOfEdgeInfo_Prepend7EDD85A0(
	void* instance,
	void* I,
	void* theIt)
{
		const BOP_EdgeInfo &  _I =*(const BOP_EdgeInfo *)I;
		BOP_ListIteratorOfListOfEdgeInfo &  _theIt =*(BOP_ListIteratorOfListOfEdgeInfo *)theIt;
	BOP_ListOfEdgeInfo* result = (BOP_ListOfEdgeInfo*)instance;
 	result->Prepend(			
_I,			
_theIt);
}
DECL_EXPORT void BOP_ListOfEdgeInfo_PrependBB93B226(
	void* instance,
	void* Other)
{
		BOP_ListOfEdgeInfo &  _Other =*(BOP_ListOfEdgeInfo *)Other;
	BOP_ListOfEdgeInfo* result = (BOP_ListOfEdgeInfo*)instance;
 	result->Prepend(			
_Other);
}
DECL_EXPORT void BOP_ListOfEdgeInfo_Append6C1C9DDA(
	void* instance,
	void* I)
{
		const BOP_EdgeInfo &  _I =*(const BOP_EdgeInfo *)I;
	BOP_ListOfEdgeInfo* result = (BOP_ListOfEdgeInfo*)instance;
 	result->Append(			
_I);
}
DECL_EXPORT void BOP_ListOfEdgeInfo_Append7EDD85A0(
	void* instance,
	void* I,
	void* theIt)
{
		const BOP_EdgeInfo &  _I =*(const BOP_EdgeInfo *)I;
		BOP_ListIteratorOfListOfEdgeInfo &  _theIt =*(BOP_ListIteratorOfListOfEdgeInfo *)theIt;
	BOP_ListOfEdgeInfo* result = (BOP_ListOfEdgeInfo*)instance;
 	result->Append(			
_I,			
_theIt);
}
DECL_EXPORT void BOP_ListOfEdgeInfo_AppendBB93B226(
	void* instance,
	void* Other)
{
		BOP_ListOfEdgeInfo &  _Other =*(BOP_ListOfEdgeInfo *)Other;
	BOP_ListOfEdgeInfo* result = (BOP_ListOfEdgeInfo*)instance;
 	result->Append(			
_Other);
}
DECL_EXPORT void BOP_ListOfEdgeInfo_RemoveFirst(void* instance)
{
	BOP_ListOfEdgeInfo* result = (BOP_ListOfEdgeInfo*)instance;
 	result->RemoveFirst();
}
DECL_EXPORT void BOP_ListOfEdgeInfo_RemoveF9227B7D(
	void* instance,
	void* It)
{
		BOP_ListIteratorOfListOfEdgeInfo &  _It =*(BOP_ListIteratorOfListOfEdgeInfo *)It;
	BOP_ListOfEdgeInfo* result = (BOP_ListOfEdgeInfo*)instance;
 	result->Remove(			
_It);
}
DECL_EXPORT void BOP_ListOfEdgeInfo_InsertBefore7EDD85A0(
	void* instance,
	void* I,
	void* It)
{
		const BOP_EdgeInfo &  _I =*(const BOP_EdgeInfo *)I;
		BOP_ListIteratorOfListOfEdgeInfo &  _It =*(BOP_ListIteratorOfListOfEdgeInfo *)It;
	BOP_ListOfEdgeInfo* result = (BOP_ListOfEdgeInfo*)instance;
 	result->InsertBefore(			
_I,			
_It);
}
DECL_EXPORT void BOP_ListOfEdgeInfo_InsertBefore7A35FC8F(
	void* instance,
	void* Other,
	void* It)
{
		BOP_ListOfEdgeInfo &  _Other =*(BOP_ListOfEdgeInfo *)Other;
		BOP_ListIteratorOfListOfEdgeInfo &  _It =*(BOP_ListIteratorOfListOfEdgeInfo *)It;
	BOP_ListOfEdgeInfo* result = (BOP_ListOfEdgeInfo*)instance;
 	result->InsertBefore(			
_Other,			
_It);
}
DECL_EXPORT void BOP_ListOfEdgeInfo_InsertAfter7EDD85A0(
	void* instance,
	void* I,
	void* It)
{
		const BOP_EdgeInfo &  _I =*(const BOP_EdgeInfo *)I;
		BOP_ListIteratorOfListOfEdgeInfo &  _It =*(BOP_ListIteratorOfListOfEdgeInfo *)It;
	BOP_ListOfEdgeInfo* result = (BOP_ListOfEdgeInfo*)instance;
 	result->InsertAfter(			
_I,			
_It);
}
DECL_EXPORT void BOP_ListOfEdgeInfo_InsertAfter7A35FC8F(
	void* instance,
	void* Other,
	void* It)
{
		BOP_ListOfEdgeInfo &  _Other =*(BOP_ListOfEdgeInfo *)Other;
		BOP_ListIteratorOfListOfEdgeInfo &  _It =*(BOP_ListIteratorOfListOfEdgeInfo *)It;
	BOP_ListOfEdgeInfo* result = (BOP_ListOfEdgeInfo*)instance;
 	result->InsertAfter(			
_Other,			
_It);
}
DECL_EXPORT int BOP_ListOfEdgeInfo_Extent(void* instance)
{
	BOP_ListOfEdgeInfo* result = (BOP_ListOfEdgeInfo*)instance;
	return 	result->Extent();
}

DECL_EXPORT bool BOP_ListOfEdgeInfo_IsEmpty(void* instance)
{
	BOP_ListOfEdgeInfo* result = (BOP_ListOfEdgeInfo*)instance;
	return 	result->IsEmpty();
}

DECL_EXPORT void* BOP_ListOfEdgeInfo_First(void* instance)
{
	BOP_ListOfEdgeInfo* result = (BOP_ListOfEdgeInfo*)instance;
	return 	new BOP_EdgeInfo(	result->First());
}

DECL_EXPORT void* BOP_ListOfEdgeInfo_Last(void* instance)
{
	BOP_ListOfEdgeInfo* result = (BOP_ListOfEdgeInfo*)instance;
	return 	new BOP_EdgeInfo(	result->Last());
}

DECL_EXPORT void BOPListOfEdgeInfo_Dtor(void* instance)
{
	delete (BOP_ListOfEdgeInfo*)instance;
}
