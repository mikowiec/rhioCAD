#include "BRepAlgo.h"
#include <BRepAlgo.hxx>

#include <TopoDS_Wire.hxx>

DECL_EXPORT void* BRepAlgo_ConcatenateWireB2333A01(
	void* Wire,
	int Option,
	double AngularTolerance)
{
		const TopoDS_Wire &  _Wire =*(const TopoDS_Wire *)Wire;
		const GeomAbs_Shape _Option =(const GeomAbs_Shape )Option;
	return new TopoDS_Wire( BRepAlgo::ConcatenateWire(			
_Wire,			
_Option,			
AngularTolerance));
}
DECL_EXPORT bool BRepAlgo_IsValid9EBAC0C0(
	void* S)
{
		const TopoDS_Shape &  _S =*(const TopoDS_Shape *)S;
	return  BRepAlgo::IsValid(			
_S);
}
DECL_EXPORT bool BRepAlgo_IsValid49B662F1(
	void* theArgs,
	void* theResult,
	bool closedSolid,
	bool GeomCtrl)
{
		const TopTools_ListOfShape &  _theArgs =*(const TopTools_ListOfShape *)theArgs;
		const TopoDS_Shape &  _theResult =*(const TopoDS_Shape *)theResult;
	return  BRepAlgo::IsValid(			
_theArgs,			
_theResult,			
closedSolid,			
GeomCtrl);
}
DECL_EXPORT bool BRepAlgo_IsTopologicallyValid9EBAC0C0(
	void* S)
{
		const TopoDS_Shape &  _S =*(const TopoDS_Shape *)S;
	return  BRepAlgo::IsTopologicallyValid(			
_S);
}
DECL_EXPORT void BRepAlgo_Dtor(void* instance)
{
	delete (BRepAlgo*)instance;
}
