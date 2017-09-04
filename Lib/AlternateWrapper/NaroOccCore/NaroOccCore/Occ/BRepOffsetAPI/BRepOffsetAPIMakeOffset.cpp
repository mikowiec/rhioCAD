#include "BRepOffsetAPIMakeOffset.h"
#include <BRepOffsetAPI_MakeOffset.hxx>


DECL_EXPORT void* BRepOffsetAPI_MakeOffset_Ctor()
{
	return new BRepOffsetAPI_MakeOffset();
}
DECL_EXPORT void* BRepOffsetAPI_MakeOffset_CtorA6167785(
	void* Spine,
	int Join)
{
		const TopoDS_Face &  _Spine =*(const TopoDS_Face *)Spine;
		const GeomAbs_JoinType _Join =(const GeomAbs_JoinType )Join;
	return new BRepOffsetAPI_MakeOffset(			
_Spine,			
_Join);
}
DECL_EXPORT void* BRepOffsetAPI_MakeOffset_Ctor38E1F2B(
	void* Spine,
	int Join)
{
		const TopoDS_Wire &  _Spine =*(const TopoDS_Wire *)Spine;
		const GeomAbs_JoinType _Join =(const GeomAbs_JoinType )Join;
	return new BRepOffsetAPI_MakeOffset(			
_Spine,			
_Join);
}
DECL_EXPORT void BRepOffsetAPI_MakeOffset_InitA6167785(
	void* instance,
	void* Spine,
	int Join)
{
		const TopoDS_Face &  _Spine =*(const TopoDS_Face *)Spine;
		const GeomAbs_JoinType _Join =(const GeomAbs_JoinType )Join;
	BRepOffsetAPI_MakeOffset* result = (BRepOffsetAPI_MakeOffset*)instance;
 	result->Init(			
_Spine,			
_Join);
}
DECL_EXPORT void BRepOffsetAPI_MakeOffset_InitAC370FAD(
	void* instance,
	int Join)
{
		const GeomAbs_JoinType _Join =(const GeomAbs_JoinType )Join;
	BRepOffsetAPI_MakeOffset* result = (BRepOffsetAPI_MakeOffset*)instance;
 	result->Init(			
_Join);
}
DECL_EXPORT void BRepOffsetAPI_MakeOffset_AddWire368EDFE5(
	void* instance,
	void* Spine)
{
		const TopoDS_Wire &  _Spine =*(const TopoDS_Wire *)Spine;
	BRepOffsetAPI_MakeOffset* result = (BRepOffsetAPI_MakeOffset*)instance;
 	result->AddWire(			
_Spine);
}
DECL_EXPORT void BRepOffsetAPI_MakeOffset_Perform9F0E714F(
	void* instance,
	double Offset,
	double Alt)
{
	BRepOffsetAPI_MakeOffset* result = (BRepOffsetAPI_MakeOffset*)instance;
 	result->Perform(			
Offset,			
Alt);
}
DECL_EXPORT void BRepOffsetAPI_MakeOffset_Build(void* instance)
{
	BRepOffsetAPI_MakeOffset* result = (BRepOffsetAPI_MakeOffset*)instance;
 	result->Build();
}
DECL_EXPORT void BRepOffsetAPIMakeOffset_Dtor(void* instance)
{
	delete (BRepOffsetAPI_MakeOffset*)instance;
}
