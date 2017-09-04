#include "TopToolsIndexedDataMapOfShapeListOfShape.h"
#include <TopTools_IndexedDataMapOfShapeListOfShape.hxx>

#include <TopoDS_Shape.hxx>
#include <TopTools_ListOfShape.hxx>

DECL_EXPORT void* TopTools_IndexedDataMapOfShapeListOfShape_CtorE8219145(
	int NbBuckets)
{
	return new TopTools_IndexedDataMapOfShapeListOfShape(			
NbBuckets);
}
DECL_EXPORT void TopTools_IndexedDataMapOfShapeListOfShape_ReSizeE8219145(
	void* instance,
	int NbBuckets)
{
	TopTools_IndexedDataMapOfShapeListOfShape* result = (TopTools_IndexedDataMapOfShapeListOfShape*)instance;
 	result->ReSize(			
NbBuckets);
}
DECL_EXPORT int TopTools_IndexedDataMapOfShapeListOfShape_AddA97080D(
	void* instance,
	void* K,
	void* I)
{
		const TopoDS_Shape &  _K =*(const TopoDS_Shape *)K;
		const TopTools_ListOfShape &  _I =*(const TopTools_ListOfShape *)I;
	TopTools_IndexedDataMapOfShapeListOfShape* result = (TopTools_IndexedDataMapOfShapeListOfShape*)instance;
	return  	result->Add(			
_K,			
_I);
}
DECL_EXPORT void TopTools_IndexedDataMapOfShapeListOfShape_SubstituteF0D9ACDA(
	void* instance,
	int I,
	void* K,
	void* T)
{
		const TopoDS_Shape &  _K =*(const TopoDS_Shape *)K;
		const TopTools_ListOfShape &  _T =*(const TopTools_ListOfShape *)T;
	TopTools_IndexedDataMapOfShapeListOfShape* result = (TopTools_IndexedDataMapOfShapeListOfShape*)instance;
 	result->Substitute(			
I,			
_K,			
_T);
}
DECL_EXPORT void TopTools_IndexedDataMapOfShapeListOfShape_RemoveLast(void* instance)
{
	TopTools_IndexedDataMapOfShapeListOfShape* result = (TopTools_IndexedDataMapOfShapeListOfShape*)instance;
 	result->RemoveLast();
}
DECL_EXPORT bool TopTools_IndexedDataMapOfShapeListOfShape_Contains9EBAC0C0(
	void* instance,
	void* K)
{
		const TopoDS_Shape &  _K =*(const TopoDS_Shape *)K;
	TopTools_IndexedDataMapOfShapeListOfShape* result = (TopTools_IndexedDataMapOfShapeListOfShape*)instance;
	return  	result->Contains(			
_K);
}
DECL_EXPORT void* TopTools_IndexedDataMapOfShapeListOfShape_FindKeyE8219145(
	void* instance,
	int I)
{
	TopTools_IndexedDataMapOfShapeListOfShape* result = (TopTools_IndexedDataMapOfShapeListOfShape*)instance;
	return new TopoDS_Shape( 	result->FindKey(			
I));
}
DECL_EXPORT void* TopTools_IndexedDataMapOfShapeListOfShape_FindFromIndexE8219145(
	void* instance,
	int I)
{
	TopTools_ListOfShape* data = new TopTools_ListOfShape();
	TopTools_IndexedDataMapOfShapeListOfShape* result = (TopTools_IndexedDataMapOfShapeListOfShape*)instance;
	*data = result->FindFromIndex(			
I);
	return data;
}
DECL_EXPORT int TopTools_IndexedDataMapOfShapeListOfShape_FindIndex9EBAC0C0(
	void* instance,
	void* K)
{
		const TopoDS_Shape &  _K =*(const TopoDS_Shape *)K;
	TopTools_IndexedDataMapOfShapeListOfShape* result = (TopTools_IndexedDataMapOfShapeListOfShape*)instance;
	return  	result->FindIndex(			
_K);
}
DECL_EXPORT void* TopTools_IndexedDataMapOfShapeListOfShape_FindFromKey19EBAC0C0(
	void* instance,
	void* K)
{
		const TopoDS_Shape &  _K =*(const TopoDS_Shape *)K;
	TopTools_IndexedDataMapOfShapeListOfShape* result = (TopTools_IndexedDataMapOfShapeListOfShape*)instance;
	return  	result->FindFromKey1(			
_K);
}
DECL_EXPORT void* TopTools_IndexedDataMapOfShapeListOfShape_ChangeFromKey19EBAC0C0(
	void* instance,
	void* K)
{
		const TopoDS_Shape &  _K =*(const TopoDS_Shape *)K;
	TopTools_IndexedDataMapOfShapeListOfShape* result = (TopTools_IndexedDataMapOfShapeListOfShape*)instance;
	return  	result->ChangeFromKey1(			
_K);
}
DECL_EXPORT void TopToolsIndexedDataMapOfShapeListOfShape_Dtor(void* instance)
{
	delete (TopTools_IndexedDataMapOfShapeListOfShape*)instance;
}
