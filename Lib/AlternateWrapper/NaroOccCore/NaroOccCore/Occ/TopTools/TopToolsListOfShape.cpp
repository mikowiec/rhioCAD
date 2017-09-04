#include "TopToolsListOfShape.h"
#include <TopTools_ListOfShape.hxx>

#include <TopoDS_Shape.hxx>

DECL_EXPORT void* TopTools_ListOfShape_Ctor()
{
	return new TopTools_ListOfShape();
}
DECL_EXPORT void TopTools_ListOfShape_Assign49A1D41A(
	void* instance,
	void* Other)
{
		const TopTools_ListOfShape &  _Other =*(const TopTools_ListOfShape *)Other;
	TopTools_ListOfShape* result = (TopTools_ListOfShape*)instance;
 	result->Assign(			
_Other);
}
DECL_EXPORT void TopTools_ListOfShape_Prepend9EBAC0C0(
	void* instance,
	void* I)
{
		const TopoDS_Shape &  _I =*(const TopoDS_Shape *)I;
	TopTools_ListOfShape* result = (TopTools_ListOfShape*)instance;
 	result->Prepend(			
_I);
}
DECL_EXPORT void TopTools_ListOfShape_Prepend90A9D6CA(
	void* instance,
	void* I,
	void* theIt)
{
		const TopoDS_Shape &  _I =*(const TopoDS_Shape *)I;
		TopTools_ListIteratorOfListOfShape &  _theIt =*(TopTools_ListIteratorOfListOfShape *)theIt;
	TopTools_ListOfShape* result = (TopTools_ListOfShape*)instance;
 	result->Prepend(			
_I,			
_theIt);
}
DECL_EXPORT void TopTools_ListOfShape_Prepend49A1D41A(
	void* instance,
	void* Other)
{
		TopTools_ListOfShape &  _Other =*(TopTools_ListOfShape *)Other;
	TopTools_ListOfShape* result = (TopTools_ListOfShape*)instance;
 	result->Prepend(			
_Other);
}
DECL_EXPORT void TopTools_ListOfShape_Append9EBAC0C0(
	void* instance,
	void* I)
{
		const TopoDS_Shape &  _I =*(const TopoDS_Shape *)I;
	TopTools_ListOfShape* result = (TopTools_ListOfShape*)instance;
 	result->Append(			
_I);
}
DECL_EXPORT void TopTools_ListOfShape_Append90A9D6CA(
	void* instance,
	void* I,
	void* theIt)
{
		const TopoDS_Shape &  _I =*(const TopoDS_Shape *)I;
		TopTools_ListIteratorOfListOfShape &  _theIt =*(TopTools_ListIteratorOfListOfShape *)theIt;
	TopTools_ListOfShape* result = (TopTools_ListOfShape*)instance;
 	result->Append(			
_I,			
_theIt);
}
DECL_EXPORT void TopTools_ListOfShape_Append49A1D41A(
	void* instance,
	void* Other)
{
		TopTools_ListOfShape &  _Other =*(TopTools_ListOfShape *)Other;
	TopTools_ListOfShape* result = (TopTools_ListOfShape*)instance;
 	result->Append(			
_Other);
}
DECL_EXPORT void TopTools_ListOfShape_RemoveFirst(void* instance)
{
	TopTools_ListOfShape* result = (TopTools_ListOfShape*)instance;
 	result->RemoveFirst();
}
DECL_EXPORT void TopTools_ListOfShape_RemoveB4C0FF7F(
	void* instance,
	void* It)
{
		TopTools_ListIteratorOfListOfShape &  _It =*(TopTools_ListIteratorOfListOfShape *)It;
	TopTools_ListOfShape* result = (TopTools_ListOfShape*)instance;
 	result->Remove(			
_It);
}
DECL_EXPORT void TopTools_ListOfShape_InsertBefore90A9D6CA(
	void* instance,
	void* I,
	void* It)
{
		const TopoDS_Shape &  _I =*(const TopoDS_Shape *)I;
		TopTools_ListIteratorOfListOfShape &  _It =*(TopTools_ListIteratorOfListOfShape *)It;
	TopTools_ListOfShape* result = (TopTools_ListOfShape*)instance;
 	result->InsertBefore(			
_I,			
_It);
}
DECL_EXPORT void TopTools_ListOfShape_InsertBefore8F414405(
	void* instance,
	void* Other,
	void* It)
{
		TopTools_ListOfShape &  _Other =*(TopTools_ListOfShape *)Other;
		TopTools_ListIteratorOfListOfShape &  _It =*(TopTools_ListIteratorOfListOfShape *)It;
	TopTools_ListOfShape* result = (TopTools_ListOfShape*)instance;
 	result->InsertBefore(			
_Other,			
_It);
}
DECL_EXPORT void TopTools_ListOfShape_InsertAfter90A9D6CA(
	void* instance,
	void* I,
	void* It)
{
		const TopoDS_Shape &  _I =*(const TopoDS_Shape *)I;
		TopTools_ListIteratorOfListOfShape &  _It =*(TopTools_ListIteratorOfListOfShape *)It;
	TopTools_ListOfShape* result = (TopTools_ListOfShape*)instance;
 	result->InsertAfter(			
_I,			
_It);
}
DECL_EXPORT void TopTools_ListOfShape_InsertAfter8F414405(
	void* instance,
	void* Other,
	void* It)
{
		TopTools_ListOfShape &  _Other =*(TopTools_ListOfShape *)Other;
		TopTools_ListIteratorOfListOfShape &  _It =*(TopTools_ListIteratorOfListOfShape *)It;
	TopTools_ListOfShape* result = (TopTools_ListOfShape*)instance;
 	result->InsertAfter(			
_Other,			
_It);
}
DECL_EXPORT int TopTools_ListOfShape_Extent(void* instance)
{
	TopTools_ListOfShape* result = (TopTools_ListOfShape*)instance;
	return 	result->Extent();
}

DECL_EXPORT bool TopTools_ListOfShape_IsEmpty(void* instance)
{
	TopTools_ListOfShape* result = (TopTools_ListOfShape*)instance;
	return 	result->IsEmpty();
}

DECL_EXPORT void* TopTools_ListOfShape_First(void* instance)
{
	TopTools_ListOfShape* result = (TopTools_ListOfShape*)instance;
	return 	new TopoDS_Shape(	result->First());
}

DECL_EXPORT void* TopTools_ListOfShape_Last(void* instance)
{
	TopTools_ListOfShape* result = (TopTools_ListOfShape*)instance;
	return 	new TopoDS_Shape(	result->Last());
}

DECL_EXPORT void TopToolsListOfShape_Dtor(void* instance)
{
	delete (TopTools_ListOfShape*)instance;
}
