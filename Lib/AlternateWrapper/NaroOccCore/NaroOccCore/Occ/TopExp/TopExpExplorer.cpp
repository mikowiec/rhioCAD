#include "TopExpExplorer.h"
#include <TopExp_Explorer.hxx>

#include <TopoDS_Shape.hxx>

DECL_EXPORT void* TopExp_Explorer_Ctor()
{
	return new TopExp_Explorer();
}
DECL_EXPORT void* TopExp_Explorer_CtorBEBE8016(
	void* S,
	int ToFind,
	int ToAvoid)
{
		const TopoDS_Shape &  _S =*(const TopoDS_Shape *)S;
		const TopAbs_ShapeEnum _ToFind =(const TopAbs_ShapeEnum )ToFind;
		const TopAbs_ShapeEnum _ToAvoid =(const TopAbs_ShapeEnum )ToAvoid;
	return new TopExp_Explorer(			
_S,			
_ToFind,			
_ToAvoid);
}
DECL_EXPORT void TopExp_Explorer_InitBEBE8016(
	void* instance,
	void* S,
	int ToFind,
	int ToAvoid)
{
		const TopoDS_Shape &  _S =*(const TopoDS_Shape *)S;
		const TopAbs_ShapeEnum _ToFind =(const TopAbs_ShapeEnum )ToFind;
		const TopAbs_ShapeEnum _ToAvoid =(const TopAbs_ShapeEnum )ToAvoid;
	TopExp_Explorer* result = (TopExp_Explorer*)instance;
 	result->Init(			
_S,			
_ToFind,			
_ToAvoid);
}
DECL_EXPORT void TopExp_Explorer_Next(void* instance)
{
	TopExp_Explorer* result = (TopExp_Explorer*)instance;
 	result->Next();
}
DECL_EXPORT void TopExp_Explorer_ReInit(void* instance)
{
	TopExp_Explorer* result = (TopExp_Explorer*)instance;
 	result->ReInit();
}
DECL_EXPORT void TopExp_Explorer_Clear(void* instance)
{
	TopExp_Explorer* result = (TopExp_Explorer*)instance;
 	result->Clear();
}
DECL_EXPORT bool TopExp_Explorer_More(void* instance)
{
	TopExp_Explorer* result = (TopExp_Explorer*)instance;
	return 	result->More();
}

DECL_EXPORT void* TopExp_Explorer_Current(void* instance)
{
	TopExp_Explorer* result = (TopExp_Explorer*)instance;
	return 	new TopoDS_Shape(	result->Current());
}

DECL_EXPORT int TopExp_Explorer_Depth(void* instance)
{
	TopExp_Explorer* result = (TopExp_Explorer*)instance;
	return 	result->Depth();
}

DECL_EXPORT void TopExpExplorer_Dtor(void* instance)
{
	delete (TopExp_Explorer*)instance;
}
