#include "TopToolsShapeSet.h"
#include <TopTools_ShapeSet.hxx>

#include <Message_ProgressIndicator.hxx>
#include <TopoDS_Shape.hxx>

DECL_EXPORT void* TopTools_ShapeSet_Ctor()
{
	return new TopTools_ShapeSet();
}
DECL_EXPORT void TopTools_ShapeSet_Delete(void* instance)
{
	TopTools_ShapeSet* result = (TopTools_ShapeSet*)instance;
 	result->Delete();
}
DECL_EXPORT void TopTools_ShapeSet_Clear(void* instance)
{
	TopTools_ShapeSet* result = (TopTools_ShapeSet*)instance;
 	result->Clear();
}
DECL_EXPORT int TopTools_ShapeSet_Add9EBAC0C0(
	void* instance,
	void* S)
{
		const TopoDS_Shape &  _S =*(const TopoDS_Shape *)S;
	TopTools_ShapeSet* result = (TopTools_ShapeSet*)instance;
	return  	result->Add(			
_S);
}
DECL_EXPORT void* TopTools_ShapeSet_ShapeE8219145(
	void* instance,
	int I)
{
	TopTools_ShapeSet* result = (TopTools_ShapeSet*)instance;
	return new TopoDS_Shape( 	result->Shape(			
I));
}
DECL_EXPORT int TopTools_ShapeSet_Index9EBAC0C0(
	void* instance,
	void* S)
{
		const TopoDS_Shape &  _S =*(const TopoDS_Shape *)S;
	TopTools_ShapeSet* result = (TopTools_ShapeSet*)instance;
	return  	result->Index(			
_S);
}
DECL_EXPORT void TopTools_ShapeSet_AddGeometry9EBAC0C0(
	void* instance,
	void* S)
{
		const TopoDS_Shape &  _S =*(const TopoDS_Shape *)S;
	TopTools_ShapeSet* result = (TopTools_ShapeSet*)instance;
 	result->AddGeometry(			
_S);
}
DECL_EXPORT void TopTools_ShapeSet_SetFormatNb(void* instance, int value)
{
	TopTools_ShapeSet* result = (TopTools_ShapeSet*)instance;
		result->SetFormatNb(value);
}

DECL_EXPORT int TopTools_ShapeSet_FormatNb(void* instance)
{
	TopTools_ShapeSet* result = (TopTools_ShapeSet*)instance;
	return 	result->FormatNb();
}

DECL_EXPORT int TopTools_ShapeSet_NbShapes(void* instance)
{
	TopTools_ShapeSet* result = (TopTools_ShapeSet*)instance;
	return 	result->NbShapes();
}

DECL_EXPORT void TopTools_ShapeSet_SetProgress(void* instance, void* value)
{
	TopTools_ShapeSet* result = (TopTools_ShapeSet*)instance;
		result->SetProgress(*(const Handle_Message_ProgressIndicator *)value);
}

DECL_EXPORT void* TopTools_ShapeSet_GetProgress(void* instance)
{
	TopTools_ShapeSet* result = (TopTools_ShapeSet*)instance;
	return 	new Handle_Message_ProgressIndicator(	result->GetProgress());
}

DECL_EXPORT void TopToolsShapeSet_Dtor(void* instance)
{
	delete (TopTools_ShapeSet*)instance;
}
