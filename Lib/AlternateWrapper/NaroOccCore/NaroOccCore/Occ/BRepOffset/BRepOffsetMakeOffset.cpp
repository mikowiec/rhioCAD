#include "BRepOffsetMakeOffset.h"
#include <BRepOffset_MakeOffset.hxx>

#include <TopoDS_Shape.hxx>

DECL_EXPORT void* BRepOffset_MakeOffset_Ctor()
{
	return new BRepOffset_MakeOffset();
}
DECL_EXPORT void BRepOffset_MakeOffset_Initialize72D69762(
	void* instance,
	void* S,
	double Offset,
	double Tol,
	int Mode,
	bool Intersection,
	bool SelfInter,
	int Join)
{
		const TopoDS_Shape &  _S =*(const TopoDS_Shape *)S;
		const BRepOffset_Mode _Mode =(const BRepOffset_Mode )Mode;
		const GeomAbs_JoinType _Join =(const GeomAbs_JoinType )Join;
	BRepOffset_MakeOffset* result = (BRepOffset_MakeOffset*)instance;
 	result->Initialize(			
_S,			
Offset,			
Tol,			
_Mode,			
Intersection,			
SelfInter,			
_Join);
}
DECL_EXPORT void BRepOffset_MakeOffset_MakeThickSolid(void* instance)
{
	BRepOffset_MakeOffset* result = (BRepOffset_MakeOffset*)instance;
 	result->MakeThickSolid();
}
DECL_EXPORT void* BRepOffset_MakeOffset_Shape(void* instance)
{
	BRepOffset_MakeOffset* result = (BRepOffset_MakeOffset*)instance;
	return 	new TopoDS_Shape(	result->Shape());
}

DECL_EXPORT bool BRepOffset_MakeOffset_IsDone(void* instance)
{
	BRepOffset_MakeOffset* result = (BRepOffset_MakeOffset*)instance;
	return 	result->IsDone();
}

DECL_EXPORT void BRepOffsetMakeOffset_Dtor(void* instance)
{
	delete (BRepOffset_MakeOffset*)instance;
}
