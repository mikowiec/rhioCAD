#include "BOPEdgeInfo.h"
#include <BOP_EdgeInfo.hxx>

#include <TopoDS_Edge.hxx>

DECL_EXPORT void* BOP_EdgeInfo_Ctor()
{
	return new BOP_EdgeInfo();
}
DECL_EXPORT void BOP_EdgeInfo_SetInFlag(void* instance, bool value)
{
	BOP_EdgeInfo* result = (BOP_EdgeInfo*)instance;
		result->SetInFlag(value);
}

DECL_EXPORT void BOP_EdgeInfo_SetEdge(void* instance, void* value)
{
	BOP_EdgeInfo* result = (BOP_EdgeInfo*)instance;
		result->SetEdge(*(const TopoDS_Edge *)value);
}

DECL_EXPORT void* BOP_EdgeInfo_Edge(void* instance)
{
	BOP_EdgeInfo* result = (BOP_EdgeInfo*)instance;
	return 	new TopoDS_Edge(	result->Edge());
}

DECL_EXPORT void BOP_EdgeInfo_SetPassed(void* instance, bool value)
{
	BOP_EdgeInfo* result = (BOP_EdgeInfo*)instance;
		result->SetPassed(value);
}

DECL_EXPORT bool BOP_EdgeInfo_Passed(void* instance)
{
	BOP_EdgeInfo* result = (BOP_EdgeInfo*)instance;
	return 	result->Passed();
}

DECL_EXPORT void BOP_EdgeInfo_SetAngle(void* instance, double value)
{
	BOP_EdgeInfo* result = (BOP_EdgeInfo*)instance;
		result->SetAngle(value);
}

DECL_EXPORT double BOP_EdgeInfo_Angle(void* instance)
{
	BOP_EdgeInfo* result = (BOP_EdgeInfo*)instance;
	return 	result->Angle();
}

DECL_EXPORT bool BOP_EdgeInfo_IsIn(void* instance)
{
	BOP_EdgeInfo* result = (BOP_EdgeInfo*)instance;
	return 	result->IsIn();
}

DECL_EXPORT void BOPEdgeInfo_Dtor(void* instance)
{
	delete (BOP_EdgeInfo*)instance;
}
