#include "BRepOffsetAPIDraftAngle.h"
#include <BRepOffsetAPI_DraftAngle.hxx>

#include <TopoDS_Shape.hxx>

DECL_EXPORT void* BRepOffsetAPI_DraftAngle_Ctor()
{
	return new BRepOffsetAPI_DraftAngle();
}
DECL_EXPORT void* BRepOffsetAPI_DraftAngle_Ctor9EBAC0C0(
	void* S)
{
		const TopoDS_Shape &  _S =*(const TopoDS_Shape *)S;
	return new BRepOffsetAPI_DraftAngle(			
_S);
}
DECL_EXPORT void BRepOffsetAPI_DraftAngle_Clear(void* instance)
{
	BRepOffsetAPI_DraftAngle* result = (BRepOffsetAPI_DraftAngle*)instance;
 	result->Clear();
}
DECL_EXPORT void BRepOffsetAPI_DraftAngle_Init9EBAC0C0(
	void* instance,
	void* S)
{
		const TopoDS_Shape &  _S =*(const TopoDS_Shape *)S;
	BRepOffsetAPI_DraftAngle* result = (BRepOffsetAPI_DraftAngle*)instance;
 	result->Init(			
_S);
}
DECL_EXPORT void BRepOffsetAPI_DraftAngle_AddABCF3248(
	void* instance,
	void* F,
	void* Direction,
	double Angle,
	void* NeutralPlane,
	bool Flag)
{
		const TopoDS_Face &  _F =*(const TopoDS_Face *)F;
		const gp_Dir &  _Direction =*(const gp_Dir *)Direction;
		const gp_Pln &  _NeutralPlane =*(const gp_Pln *)NeutralPlane;
	BRepOffsetAPI_DraftAngle* result = (BRepOffsetAPI_DraftAngle*)instance;
 	result->Add(			
_F,			
_Direction,			
Angle,			
_NeutralPlane,			
Flag);
}
DECL_EXPORT void BRepOffsetAPI_DraftAngle_RemoveAEC70AC1(
	void* instance,
	void* F)
{
		const TopoDS_Face &  _F =*(const TopoDS_Face *)F;
	BRepOffsetAPI_DraftAngle* result = (BRepOffsetAPI_DraftAngle*)instance;
 	result->Remove(			
_F);
}
DECL_EXPORT void BRepOffsetAPI_DraftAngle_Build(void* instance)
{
	BRepOffsetAPI_DraftAngle* result = (BRepOffsetAPI_DraftAngle*)instance;
 	result->Build();
}
DECL_EXPORT void BRepOffsetAPI_DraftAngle_CorrectWires(void* instance)
{
	BRepOffsetAPI_DraftAngle* result = (BRepOffsetAPI_DraftAngle*)instance;
 	result->CorrectWires();
}
DECL_EXPORT bool BRepOffsetAPI_DraftAngle_AddDone(void* instance)
{
	BRepOffsetAPI_DraftAngle* result = (BRepOffsetAPI_DraftAngle*)instance;
	return 	result->AddDone();
}

DECL_EXPORT void* BRepOffsetAPI_DraftAngle_ProblematicShape(void* instance)
{
	BRepOffsetAPI_DraftAngle* result = (BRepOffsetAPI_DraftAngle*)instance;
	return 	new TopoDS_Shape(	result->ProblematicShape());
}

DECL_EXPORT int BRepOffsetAPI_DraftAngle_Status(void* instance)
{
	BRepOffsetAPI_DraftAngle* result = (BRepOffsetAPI_DraftAngle*)instance;
	return (int)	result->Status();
}

DECL_EXPORT void BRepOffsetAPIDraftAngle_Dtor(void* instance)
{
	delete (BRepOffsetAPI_DraftAngle*)instance;
}
