#include "BRepAlgoAPICut.h"
#include <BRepAlgoAPI_Cut.hxx>


DECL_EXPORT void* BRepAlgoAPI_Cut_Ctor877A736F(
	void* S1,
	void* S2)
{
		const TopoDS_Shape &  _S1 =*(const TopoDS_Shape *)S1;
		const TopoDS_Shape &  _S2 =*(const TopoDS_Shape *)S2;
	return new BRepAlgoAPI_Cut(			
_S1,			
_S2);
}
DECL_EXPORT void* BRepAlgoAPI_Cut_Ctor421BE7CD(
	void* S1,
	void* S2,
	void* aDSF,
	bool bFWD)
{
		const TopoDS_Shape &  _S1 =*(const TopoDS_Shape *)S1;
		const TopoDS_Shape &  _S2 =*(const TopoDS_Shape *)S2;
		const BOPTools_DSFiller &  _aDSF =*(const BOPTools_DSFiller *)aDSF;
	return new BRepAlgoAPI_Cut(			
_S1,			
_S2,			
_aDSF,			
bFWD);
}
DECL_EXPORT void BRepAlgoAPICut_Dtor(void* instance)
{
	delete (BRepAlgoAPI_Cut*)instance;
}
