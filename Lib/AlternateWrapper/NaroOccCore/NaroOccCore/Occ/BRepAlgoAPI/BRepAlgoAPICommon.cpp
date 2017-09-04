#include "BRepAlgoAPICommon.h"
#include <BRepAlgoAPI_Common.hxx>


DECL_EXPORT void* BRepAlgoAPI_Common_Ctor877A736F(
	void* S1,
	void* S2)
{
		const TopoDS_Shape &  _S1 =*(const TopoDS_Shape *)S1;
		const TopoDS_Shape &  _S2 =*(const TopoDS_Shape *)S2;
	return new BRepAlgoAPI_Common(			
_S1,			
_S2);
}
DECL_EXPORT void* BRepAlgoAPI_Common_Ctor1641F7D4(
	void* S1,
	void* S2,
	void* aDSF)
{
		const TopoDS_Shape &  _S1 =*(const TopoDS_Shape *)S1;
		const TopoDS_Shape &  _S2 =*(const TopoDS_Shape *)S2;
		const BOPTools_DSFiller &  _aDSF =*(const BOPTools_DSFiller *)aDSF;
	return new BRepAlgoAPI_Common(			
_S1,			
_S2,			
_aDSF);
}
DECL_EXPORT void BRepAlgoAPICommon_Dtor(void* instance)
{
	delete (BRepAlgoAPI_Common*)instance;
}
