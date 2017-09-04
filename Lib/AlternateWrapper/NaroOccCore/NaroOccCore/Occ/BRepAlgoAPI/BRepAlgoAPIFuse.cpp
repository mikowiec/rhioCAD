#include "BRepAlgoAPIFuse.h"
#include <BRepAlgoAPI_Fuse.hxx>


DECL_EXPORT void* BRepAlgoAPI_Fuse_Ctor877A736F(
	void* S1,
	void* S2)
{
		const TopoDS_Shape &  _S1 =*(const TopoDS_Shape *)S1;
		const TopoDS_Shape &  _S2 =*(const TopoDS_Shape *)S2;
	return new BRepAlgoAPI_Fuse(			
_S1,			
_S2);
}
DECL_EXPORT void* BRepAlgoAPI_Fuse_Ctor1641F7D4(
	void* S1,
	void* S2,
	void* aDSF)
{
		const TopoDS_Shape &  _S1 =*(const TopoDS_Shape *)S1;
		const TopoDS_Shape &  _S2 =*(const TopoDS_Shape *)S2;
		const BOPTools_DSFiller &  _aDSF =*(const BOPTools_DSFiller *)aDSF;
	return new BRepAlgoAPI_Fuse(			
_S1,			
_S2,			
_aDSF);
}
DECL_EXPORT void BRepAlgoAPIFuse_Dtor(void* instance)
{
	delete (BRepAlgoAPI_Fuse*)instance;
}
