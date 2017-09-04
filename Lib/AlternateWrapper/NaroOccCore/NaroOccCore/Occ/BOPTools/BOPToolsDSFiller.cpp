#include "BOPToolsDSFiller.h"
#include <BOPTools_DSFiller.hxx>

#include <TopoDS_Shape.hxx>

DECL_EXPORT void* BOPTools_DSFiller_Ctor()
{
	return new BOPTools_DSFiller();
}
DECL_EXPORT void BOPTools_DSFiller_SetShapes877A736F(
	void* instance,
	void* aS1,
	void* aS2)
{
		const TopoDS_Shape &  _aS1 =*(const TopoDS_Shape *)aS1;
		const TopoDS_Shape &  _aS2 =*(const TopoDS_Shape *)aS2;
	BOPTools_DSFiller* result = (BOPTools_DSFiller*)instance;
 	result->SetShapes(			
_aS1,			
_aS2);
}
DECL_EXPORT void BOPTools_DSFiller_Perform(void* instance)
{
	BOPTools_DSFiller* result = (BOPTools_DSFiller*)instance;
 	result->Perform();
}
DECL_EXPORT void BOPTools_DSFiller_InitFillersAndPools(void* instance)
{
	BOPTools_DSFiller* result = (BOPTools_DSFiller*)instance;
 	result->InitFillersAndPools();
}
DECL_EXPORT void BOPTools_DSFiller_ToCompletePerform(void* instance)
{
	BOPTools_DSFiller* result = (BOPTools_DSFiller*)instance;
 	result->ToCompletePerform();
}
DECL_EXPORT int BOPTools_DSFiller_TreatCompound877A736F(
	void* theShape,
	void* theShapeResult)
{
		const TopoDS_Shape &  _theShape =*(const TopoDS_Shape *)theShape;
		 TopoDS_Shape &  _theShapeResult =*( TopoDS_Shape *)theShapeResult;
	return  BOPTools_DSFiller::TreatCompound(			
_theShape,			
_theShapeResult);
}
DECL_EXPORT void* BOPTools_DSFiller_Shape1(void* instance)
{
	BOPTools_DSFiller* result = (BOPTools_DSFiller*)instance;
	return 	new TopoDS_Shape(	result->Shape1());
}

DECL_EXPORT void* BOPTools_DSFiller_Shape2(void* instance)
{
	BOPTools_DSFiller* result = (BOPTools_DSFiller*)instance;
	return 	new TopoDS_Shape(	result->Shape2());
}

DECL_EXPORT bool BOPTools_DSFiller_IsNewFiller(void* instance)
{
	BOPTools_DSFiller* result = (BOPTools_DSFiller*)instance;
	return 	result->IsNewFiller();
}

DECL_EXPORT void BOPTools_DSFiller_SetNewFiller(void* instance, bool value)
{
	BOPTools_DSFiller* result = (BOPTools_DSFiller*)instance;
		result->SetNewFiller(value);
}

DECL_EXPORT bool BOPTools_DSFiller_IsDone(void* instance)
{
	BOPTools_DSFiller* result = (BOPTools_DSFiller*)instance;
	return 	result->IsDone();
}

DECL_EXPORT void BOPToolsDSFiller_Dtor(void* instance)
{
	delete (BOPTools_DSFiller*)instance;
}
