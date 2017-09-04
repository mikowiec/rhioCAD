#include "BOPFaceInfo.h"
#include <BOP_FaceInfo.hxx>

#include <gp_Dir.hxx>
#include <gp_Pnt.hxx>
#include <gp_Pnt2d.hxx>
#include <TopoDS_Face.hxx>

DECL_EXPORT void* BOP_FaceInfo_Ctor()
{
	return new BOP_FaceInfo();
}
DECL_EXPORT void BOP_FaceInfo_SetPassed(void* instance, bool value)
{
	BOP_FaceInfo* result = (BOP_FaceInfo*)instance;
		result->SetPassed(value);
}

DECL_EXPORT void BOP_FaceInfo_SetFace(void* instance, void* value)
{
	BOP_FaceInfo* result = (BOP_FaceInfo*)instance;
		result->SetFace(*(const TopoDS_Face *)value);
}

DECL_EXPORT void* BOP_FaceInfo_Face(void* instance)
{
	BOP_FaceInfo* result = (BOP_FaceInfo*)instance;
	return 	new TopoDS_Face(	result->Face());
}

DECL_EXPORT void BOP_FaceInfo_SetPOnEdge(void* instance, void* value)
{
	BOP_FaceInfo* result = (BOP_FaceInfo*)instance;
		result->SetPOnEdge(*(const gp_Pnt *)value);
}

DECL_EXPORT void* BOP_FaceInfo_POnEdge(void* instance)
{
	BOP_FaceInfo* result = (BOP_FaceInfo*)instance;
	return 	new gp_Pnt(	result->POnEdge());
}

DECL_EXPORT void BOP_FaceInfo_SetPInFace(void* instance, void* value)
{
	BOP_FaceInfo* result = (BOP_FaceInfo*)instance;
		result->SetPInFace(*(const gp_Pnt *)value);
}

DECL_EXPORT void* BOP_FaceInfo_PInFace(void* instance)
{
	BOP_FaceInfo* result = (BOP_FaceInfo*)instance;
	return 	new gp_Pnt(	result->PInFace());
}

DECL_EXPORT void BOP_FaceInfo_SetPInFace2D(void* instance, void* value)
{
	BOP_FaceInfo* result = (BOP_FaceInfo*)instance;
		result->SetPInFace2D(*(const gp_Pnt2d *)value);
}

DECL_EXPORT void* BOP_FaceInfo_PInFace2D(void* instance)
{
	BOP_FaceInfo* result = (BOP_FaceInfo*)instance;
	return 	new gp_Pnt2d(	result->PInFace2D());
}

DECL_EXPORT void BOP_FaceInfo_SetNormal(void* instance, void* value)
{
	BOP_FaceInfo* result = (BOP_FaceInfo*)instance;
		result->SetNormal(*(const gp_Dir *)value);
}

DECL_EXPORT void* BOP_FaceInfo_Normal(void* instance)
{
	BOP_FaceInfo* result = (BOP_FaceInfo*)instance;
	return 	new gp_Dir(	result->Normal());
}

DECL_EXPORT bool BOP_FaceInfo_IsPassed(void* instance)
{
	BOP_FaceInfo* result = (BOP_FaceInfo*)instance;
	return 	result->IsPassed();
}

DECL_EXPORT void BOP_FaceInfo_SetAngle(void* instance, double value)
{
	BOP_FaceInfo* result = (BOP_FaceInfo*)instance;
		result->SetAngle(value);
}

DECL_EXPORT double BOP_FaceInfo_Angle(void* instance)
{
	BOP_FaceInfo* result = (BOP_FaceInfo*)instance;
	return 	result->Angle();
}

DECL_EXPORT void BOPFaceInfo_Dtor(void* instance)
{
	delete (BOP_FaceInfo*)instance;
}
