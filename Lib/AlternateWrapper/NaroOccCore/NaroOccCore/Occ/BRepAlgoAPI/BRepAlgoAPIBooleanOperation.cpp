#include "BRepAlgoAPIBooleanOperation.h"
#include <BRepAlgoAPI_BooleanOperation.hxx>

#include <TopoDS_Shape.hxx>

DECL_EXPORT void BRepAlgoAPI_BooleanOperation_Build(void* instance)
{
	BRepAlgoAPI_BooleanOperation* result = (BRepAlgoAPI_BooleanOperation*)instance;
 	result->Build();
}
DECL_EXPORT void BRepAlgoAPI_BooleanOperation_RefineEdges(void* instance)
{
	BRepAlgoAPI_BooleanOperation* result = (BRepAlgoAPI_BooleanOperation*)instance;
 	result->RefineEdges();
}
DECL_EXPORT bool BRepAlgoAPI_BooleanOperation_IsDeleted9EBAC0C0(
	void* instance,
	void* aS)
{
		const TopoDS_Shape &  _aS =*(const TopoDS_Shape *)aS;
	BRepAlgoAPI_BooleanOperation* result = (BRepAlgoAPI_BooleanOperation*)instance;
	return  	result->IsDeleted(			
_aS);
}
DECL_EXPORT void BRepAlgoAPI_BooleanOperation_Destroy(void* instance)
{
	BRepAlgoAPI_BooleanOperation* result = (BRepAlgoAPI_BooleanOperation*)instance;
 	result->Destroy();
}
DECL_EXPORT void* BRepAlgoAPI_BooleanOperation_Shape1(void* instance)
{
	BRepAlgoAPI_BooleanOperation* result = (BRepAlgoAPI_BooleanOperation*)instance;
	return 	new TopoDS_Shape(	result->Shape1());
}

DECL_EXPORT void* BRepAlgoAPI_BooleanOperation_Shape2(void* instance)
{
	BRepAlgoAPI_BooleanOperation* result = (BRepAlgoAPI_BooleanOperation*)instance;
	return 	new TopoDS_Shape(	result->Shape2());
}

DECL_EXPORT void BRepAlgoAPI_BooleanOperation_SetOperation(void* instance, int value)
{
	BRepAlgoAPI_BooleanOperation* result = (BRepAlgoAPI_BooleanOperation*)instance;
		result->SetOperation((const BOP_Operation)value);
}

DECL_EXPORT int BRepAlgoAPI_BooleanOperation_Operation(void* instance)
{
	BRepAlgoAPI_BooleanOperation* result = (BRepAlgoAPI_BooleanOperation*)instance;
	return (int)	result->Operation();
}

DECL_EXPORT bool BRepAlgoAPI_BooleanOperation_FuseEdges(void* instance)
{
	BRepAlgoAPI_BooleanOperation* result = (BRepAlgoAPI_BooleanOperation*)instance;
	return 	result->FuseEdges();
}

DECL_EXPORT bool BRepAlgoAPI_BooleanOperation_BuilderCanWork(void* instance)
{
	BRepAlgoAPI_BooleanOperation* result = (BRepAlgoAPI_BooleanOperation*)instance;
	return 	result->BuilderCanWork();
}

DECL_EXPORT int BRepAlgoAPI_BooleanOperation_ErrorStatus(void* instance)
{
	BRepAlgoAPI_BooleanOperation* result = (BRepAlgoAPI_BooleanOperation*)instance;
	return 	result->ErrorStatus();
}

DECL_EXPORT bool BRepAlgoAPI_BooleanOperation_HasModified(void* instance)
{
	BRepAlgoAPI_BooleanOperation* result = (BRepAlgoAPI_BooleanOperation*)instance;
	return 	result->HasModified();
}

DECL_EXPORT bool BRepAlgoAPI_BooleanOperation_HasGenerated(void* instance)
{
	BRepAlgoAPI_BooleanOperation* result = (BRepAlgoAPI_BooleanOperation*)instance;
	return 	result->HasGenerated();
}

DECL_EXPORT bool BRepAlgoAPI_BooleanOperation_HasDeleted(void* instance)
{
	BRepAlgoAPI_BooleanOperation* result = (BRepAlgoAPI_BooleanOperation*)instance;
	return 	result->HasDeleted();
}

DECL_EXPORT void BRepAlgoAPIBooleanOperation_Dtor(void* instance)
{
	delete (BRepAlgoAPI_BooleanOperation*)instance;
}
