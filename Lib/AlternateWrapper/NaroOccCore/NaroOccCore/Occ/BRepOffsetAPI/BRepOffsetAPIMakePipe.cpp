#include "BRepOffsetAPIMakePipe.h"
#include <BRepOffsetAPI_MakePipe.hxx>

#include <TopoDS_Shape.hxx>

DECL_EXPORT void* BRepOffsetAPI_MakePipe_Ctor6D9C9186(
	void* Spine,
	void* Profile)
{
		const TopoDS_Wire &  _Spine =*(const TopoDS_Wire *)Spine;
		const TopoDS_Shape &  _Profile =*(const TopoDS_Shape *)Profile;
	return new BRepOffsetAPI_MakePipe(			
_Spine,			
_Profile);
}
DECL_EXPORT void BRepOffsetAPI_MakePipe_Build(void* instance)
{
	BRepOffsetAPI_MakePipe* result = (BRepOffsetAPI_MakePipe*)instance;
 	result->Build();
}
DECL_EXPORT void* BRepOffsetAPI_MakePipe_Generated877A736F(
	void* instance,
	void* SSpine,
	void* SProfile)
{
		const TopoDS_Shape &  _SSpine =*(const TopoDS_Shape *)SSpine;
		const TopoDS_Shape &  _SProfile =*(const TopoDS_Shape *)SProfile;
	BRepOffsetAPI_MakePipe* result = (BRepOffsetAPI_MakePipe*)instance;
	return new TopoDS_Shape( 	result->Generated(			
_SSpine,			
_SProfile));
}
DECL_EXPORT void* BRepOffsetAPI_MakePipe_FirstShape(void* instance)
{
	BRepOffsetAPI_MakePipe* result = (BRepOffsetAPI_MakePipe*)instance;
	return 	new TopoDS_Shape(	result->FirstShape());
}

DECL_EXPORT void* BRepOffsetAPI_MakePipe_LastShape(void* instance)
{
	BRepOffsetAPI_MakePipe* result = (BRepOffsetAPI_MakePipe*)instance;
	return 	new TopoDS_Shape(	result->LastShape());
}

DECL_EXPORT void BRepOffsetAPIMakePipe_Dtor(void* instance)
{
	delete (BRepOffsetAPI_MakePipe*)instance;
}
