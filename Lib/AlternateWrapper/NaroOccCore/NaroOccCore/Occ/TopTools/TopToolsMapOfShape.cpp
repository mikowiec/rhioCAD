#include "TopToolsMapOfShape.h"
#include <TopTools_MapOfShape.hxx>

#include <TopTools_MapOfShape.hxx>

DECL_EXPORT void* TopTools_MapOfShape_CtorE8219145(
	int NbBuckets)
{
	return new TopTools_MapOfShape(			
NbBuckets);
}
DECL_EXPORT void* TopTools_MapOfShape_Assign5AADDC61(
	void* instance,
	void* Other)
{
	TopTools_MapOfShape* data = new TopTools_MapOfShape();
		const TopTools_MapOfShape &  _Other =*(const TopTools_MapOfShape *)Other;
	TopTools_MapOfShape* result = (TopTools_MapOfShape*)instance;
	*data = ( 	result->Assign(			
_Other));
	return data;
}
DECL_EXPORT void TopTools_MapOfShape_ReSizeE8219145(
	void* instance,
	int NbBuckets)
{
	TopTools_MapOfShape* result = (TopTools_MapOfShape*)instance;
 	result->ReSize(			
NbBuckets);
}
DECL_EXPORT bool TopTools_MapOfShape_Add9EBAC0C0(
	void* instance,
	void* aKey)
{
		const TopoDS_Shape &  _aKey =*(const TopoDS_Shape *)aKey;
	TopTools_MapOfShape* result = (TopTools_MapOfShape*)instance;
	return  	result->Add(			
_aKey);
}
DECL_EXPORT bool TopTools_MapOfShape_Contains9EBAC0C0(
	void* instance,
	void* aKey)
{
		const TopoDS_Shape &  _aKey =*(const TopoDS_Shape *)aKey;
	TopTools_MapOfShape* result = (TopTools_MapOfShape*)instance;
	return  	result->Contains(			
_aKey);
}
DECL_EXPORT bool TopTools_MapOfShape_Remove9EBAC0C0(
	void* instance,
	void* aKey)
{
		const TopoDS_Shape &  _aKey =*(const TopoDS_Shape *)aKey;
	TopTools_MapOfShape* result = (TopTools_MapOfShape*)instance;
	return  	result->Remove(			
_aKey);
}
DECL_EXPORT void TopToolsMapOfShape_Dtor(void* instance)
{
	delete (TopTools_MapOfShape*)instance;
}
