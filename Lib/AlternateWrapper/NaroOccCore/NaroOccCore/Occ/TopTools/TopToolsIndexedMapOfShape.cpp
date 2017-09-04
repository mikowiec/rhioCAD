#include "TopToolsIndexedMapOfShape.h"
#include <TopTools_IndexedMapOfShape.hxx>

#include <TopoDS_Shape.hxx>

DECL_EXPORT void* TopTools_IndexedMapOfShape_CtorE8219145(
	int NbBuckets)
{
	return new TopTools_IndexedMapOfShape(			
NbBuckets);
}
DECL_EXPORT void TopTools_IndexedMapOfShape_ReSizeE8219145(
	void* instance,
	int NbBuckets)
{
	TopTools_IndexedMapOfShape* result = (TopTools_IndexedMapOfShape*)instance;
 	result->ReSize(			
NbBuckets);
}
DECL_EXPORT int TopTools_IndexedMapOfShape_Add9EBAC0C0(
	void* instance,
	void* K)
{
		const TopoDS_Shape &  _K =*(const TopoDS_Shape *)K;
	TopTools_IndexedMapOfShape* result = (TopTools_IndexedMapOfShape*)instance;
	return  	result->Add(			
_K);
}
DECL_EXPORT void TopTools_IndexedMapOfShape_SubstituteA4F60BB8(
	void* instance,
	int I,
	void* K)
{
		const TopoDS_Shape &  _K =*(const TopoDS_Shape *)K;
	TopTools_IndexedMapOfShape* result = (TopTools_IndexedMapOfShape*)instance;
 	result->Substitute(			
I,			
_K);
}
DECL_EXPORT void TopTools_IndexedMapOfShape_RemoveLast(void* instance)
{
	TopTools_IndexedMapOfShape* result = (TopTools_IndexedMapOfShape*)instance;
 	result->RemoveLast();
}
DECL_EXPORT bool TopTools_IndexedMapOfShape_Contains9EBAC0C0(
	void* instance,
	void* K)
{
		const TopoDS_Shape &  _K =*(const TopoDS_Shape *)K;
	TopTools_IndexedMapOfShape* result = (TopTools_IndexedMapOfShape*)instance;
	return  	result->Contains(			
_K);
}
DECL_EXPORT void* TopTools_IndexedMapOfShape_FindKeyE8219145(
	void* instance,
	int I)
{
	TopTools_IndexedMapOfShape* result = (TopTools_IndexedMapOfShape*)instance;
	return new TopoDS_Shape( 	result->FindKey(			
I));
}
DECL_EXPORT int TopTools_IndexedMapOfShape_FindIndex9EBAC0C0(
	void* instance,
	void* K)
{
		const TopoDS_Shape &  _K =*(const TopoDS_Shape *)K;
	TopTools_IndexedMapOfShape* result = (TopTools_IndexedMapOfShape*)instance;
	return  	result->FindIndex(			
_K);
}
DECL_EXPORT void TopToolsIndexedMapOfShape_Dtor(void* instance)
{
	delete (TopTools_IndexedMapOfShape*)instance;
}
