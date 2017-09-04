#include "TopToolsListIteratorOfListOfShape.h"
#include <TopTools_ListIteratorOfListOfShape.hxx>

#include <TopoDS_Shape.hxx>

DECL_EXPORT void* TopTools_ListIteratorOfListOfShape_Ctor()
{
	return new TopTools_ListIteratorOfListOfShape();
}
DECL_EXPORT void* TopTools_ListIteratorOfListOfShape_Ctor49A1D41A(
	void* L)
{
		const TopTools_ListOfShape &  _L =*(const TopTools_ListOfShape *)L;
	return new TopTools_ListIteratorOfListOfShape(			
_L);
}
DECL_EXPORT void TopTools_ListIteratorOfListOfShape_Initialize49A1D41A(
	void* instance,
	void* L)
{
		const TopTools_ListOfShape &  _L =*(const TopTools_ListOfShape *)L;
	TopTools_ListIteratorOfListOfShape* result = (TopTools_ListIteratorOfListOfShape*)instance;
 	result->Initialize(			
_L);
}
DECL_EXPORT void TopTools_ListIteratorOfListOfShape_Next(void* instance)
{
	TopTools_ListIteratorOfListOfShape* result = (TopTools_ListIteratorOfListOfShape*)instance;
 	result->Next();
}
DECL_EXPORT bool TopTools_ListIteratorOfListOfShape_More(void* instance)
{
	TopTools_ListIteratorOfListOfShape* result = (TopTools_ListIteratorOfListOfShape*)instance;
	return 	result->More();
}

DECL_EXPORT void* TopTools_ListIteratorOfListOfShape_Value(void* instance)
{
	TopTools_ListIteratorOfListOfShape* result = (TopTools_ListIteratorOfListOfShape*)instance;
	return 	new TopoDS_Shape(	result->Value());
}

DECL_EXPORT void TopToolsListIteratorOfListOfShape_Dtor(void* instance)
{
	delete (TopTools_ListIteratorOfListOfShape*)instance;
}
