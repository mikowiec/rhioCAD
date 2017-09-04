#include "TopToolsHSequenceOfShape.h"
#include <TopTools_HSequenceOfShape.hxx>

#include <TopoDS_Shape.hxx>
#include <TopTools_HSequenceOfShape.hxx>

DECL_EXPORT void* TopTools_HSequenceOfShape_Ctor()
{
	return new Handle_TopTools_HSequenceOfShape(new TopTools_HSequenceOfShape());
}
DECL_EXPORT void TopTools_HSequenceOfShape_Clear(void* instance)
{
	TopTools_HSequenceOfShape* result = (TopTools_HSequenceOfShape*)(((Handle_TopTools_HSequenceOfShape*)instance)->Access());
 	result->Clear();
}
DECL_EXPORT void TopTools_HSequenceOfShape_Append9EBAC0C0(
	void* instance,
	void* anItem)
{
		const TopoDS_Shape &  _anItem =*(const TopoDS_Shape *)anItem;
	TopTools_HSequenceOfShape* result = (TopTools_HSequenceOfShape*)(((Handle_TopTools_HSequenceOfShape*)instance)->Access());
 	result->Append(			
_anItem);
}
DECL_EXPORT void TopTools_HSequenceOfShape_AppendE578D17E(
	void* instance,
	void* aSequence)
{
		const Handle_TopTools_HSequenceOfShape&  _aSequence =*(const Handle_TopTools_HSequenceOfShape *)aSequence;
	TopTools_HSequenceOfShape* result = (TopTools_HSequenceOfShape*)(((Handle_TopTools_HSequenceOfShape*)instance)->Access());
 	result->Append(			
_aSequence);
}
DECL_EXPORT void TopTools_HSequenceOfShape_Prepend9EBAC0C0(
	void* instance,
	void* anItem)
{
		const TopoDS_Shape &  _anItem =*(const TopoDS_Shape *)anItem;
	TopTools_HSequenceOfShape* result = (TopTools_HSequenceOfShape*)(((Handle_TopTools_HSequenceOfShape*)instance)->Access());
 	result->Prepend(			
_anItem);
}
DECL_EXPORT void TopTools_HSequenceOfShape_PrependE578D17E(
	void* instance,
	void* aSequence)
{
		const Handle_TopTools_HSequenceOfShape&  _aSequence =*(const Handle_TopTools_HSequenceOfShape *)aSequence;
	TopTools_HSequenceOfShape* result = (TopTools_HSequenceOfShape*)(((Handle_TopTools_HSequenceOfShape*)instance)->Access());
 	result->Prepend(			
_aSequence);
}
DECL_EXPORT void TopTools_HSequenceOfShape_Reverse(void* instance)
{
	TopTools_HSequenceOfShape* result = (TopTools_HSequenceOfShape*)(((Handle_TopTools_HSequenceOfShape*)instance)->Access());
 	result->Reverse();
}
DECL_EXPORT void TopTools_HSequenceOfShape_InsertBeforeA4F60BB8(
	void* instance,
	int anIndex,
	void* anItem)
{
		const TopoDS_Shape &  _anItem =*(const TopoDS_Shape *)anItem;
	TopTools_HSequenceOfShape* result = (TopTools_HSequenceOfShape*)(((Handle_TopTools_HSequenceOfShape*)instance)->Access());
 	result->InsertBefore(			
anIndex,			
_anItem);
}
DECL_EXPORT void TopTools_HSequenceOfShape_InsertBefore9D43C6B8(
	void* instance,
	int anIndex,
	void* aSequence)
{
		const Handle_TopTools_HSequenceOfShape&  _aSequence =*(const Handle_TopTools_HSequenceOfShape *)aSequence;
	TopTools_HSequenceOfShape* result = (TopTools_HSequenceOfShape*)(((Handle_TopTools_HSequenceOfShape*)instance)->Access());
 	result->InsertBefore(			
anIndex,			
_aSequence);
}
DECL_EXPORT void TopTools_HSequenceOfShape_InsertAfterA4F60BB8(
	void* instance,
	int anIndex,
	void* anItem)
{
		const TopoDS_Shape &  _anItem =*(const TopoDS_Shape *)anItem;
	TopTools_HSequenceOfShape* result = (TopTools_HSequenceOfShape*)(((Handle_TopTools_HSequenceOfShape*)instance)->Access());
 	result->InsertAfter(			
anIndex,			
_anItem);
}
DECL_EXPORT void TopTools_HSequenceOfShape_InsertAfter9D43C6B8(
	void* instance,
	int anIndex,
	void* aSequence)
{
		const Handle_TopTools_HSequenceOfShape&  _aSequence =*(const Handle_TopTools_HSequenceOfShape *)aSequence;
	TopTools_HSequenceOfShape* result = (TopTools_HSequenceOfShape*)(((Handle_TopTools_HSequenceOfShape*)instance)->Access());
 	result->InsertAfter(			
anIndex,			
_aSequence);
}
DECL_EXPORT void TopTools_HSequenceOfShape_Exchange5107F6FE(
	void* instance,
	int anIndex,
	int anOtherIndex)
{
	TopTools_HSequenceOfShape* result = (TopTools_HSequenceOfShape*)(((Handle_TopTools_HSequenceOfShape*)instance)->Access());
 	result->Exchange(			
anIndex,			
anOtherIndex);
}
DECL_EXPORT void* TopTools_HSequenceOfShape_SplitE8219145(
	void* instance,
	int anIndex)
{
	TopTools_HSequenceOfShape* result = (TopTools_HSequenceOfShape*)(((Handle_TopTools_HSequenceOfShape*)instance)->Access());
	return new Handle_TopTools_HSequenceOfShape( 	result->Split(			
anIndex));
}
DECL_EXPORT void TopTools_HSequenceOfShape_SetValueA4F60BB8(
	void* instance,
	int anIndex,
	void* anItem)
{
		const TopoDS_Shape &  _anItem =*(const TopoDS_Shape *)anItem;
	TopTools_HSequenceOfShape* result = (TopTools_HSequenceOfShape*)(((Handle_TopTools_HSequenceOfShape*)instance)->Access());
 	result->SetValue(			
anIndex,			
_anItem);
}
DECL_EXPORT void* TopTools_HSequenceOfShape_ValueE8219145(
	void* instance,
	int anIndex)
{
	TopTools_HSequenceOfShape* result = (TopTools_HSequenceOfShape*)(((Handle_TopTools_HSequenceOfShape*)instance)->Access());
	return new TopoDS_Shape( 	result->Value(			
anIndex));
}
DECL_EXPORT void* TopTools_HSequenceOfShape_ChangeValueE8219145(
	void* instance,
	int anIndex)
{
	TopTools_HSequenceOfShape* result = (TopTools_HSequenceOfShape*)(((Handle_TopTools_HSequenceOfShape*)instance)->Access());
	return new TopoDS_Shape( 	result->ChangeValue(			
anIndex));
}
DECL_EXPORT void TopTools_HSequenceOfShape_RemoveE8219145(
	void* instance,
	int anIndex)
{
	TopTools_HSequenceOfShape* result = (TopTools_HSequenceOfShape*)(((Handle_TopTools_HSequenceOfShape*)instance)->Access());
 	result->Remove(			
anIndex);
}
DECL_EXPORT void TopTools_HSequenceOfShape_Remove5107F6FE(
	void* instance,
	int fromIndex,
	int toIndex)
{
	TopTools_HSequenceOfShape* result = (TopTools_HSequenceOfShape*)(((Handle_TopTools_HSequenceOfShape*)instance)->Access());
 	result->Remove(			
fromIndex,			
toIndex);
}
DECL_EXPORT bool TopTools_HSequenceOfShape_IsEmpty(void* instance)
{
	TopTools_HSequenceOfShape* result = (TopTools_HSequenceOfShape*)(((Handle_TopTools_HSequenceOfShape*)instance)->Access());
	return 	result->IsEmpty();
}

DECL_EXPORT int TopTools_HSequenceOfShape_Length(void* instance)
{
	TopTools_HSequenceOfShape* result = (TopTools_HSequenceOfShape*)(((Handle_TopTools_HSequenceOfShape*)instance)->Access());
	return 	result->Length();
}

DECL_EXPORT void* TopTools_HSequenceOfShape_ShallowCopy(void* instance)
{
	TopTools_HSequenceOfShape* result = (TopTools_HSequenceOfShape*)(((Handle_TopTools_HSequenceOfShape*)instance)->Access());
	return 	new Handle_TopTools_HSequenceOfShape(	result->ShallowCopy());
}

DECL_EXPORT void TopToolsHSequenceOfShape_Dtor(void* instance)
{
	delete (Handle_TopTools_HSequenceOfShape*)instance;
}
