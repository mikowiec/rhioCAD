#include "BRepPrimAPIMakeRevol.h"
#include <BRepPrimAPI_MakeRevol.hxx>

#include <TopoDS_Shape.hxx>

DECL_EXPORT void* BRepPrimAPI_MakeRevol_CtorFAF6E492(
	void* S,
	void* A,
	double D,
	bool Copy)
{
		const TopoDS_Shape &  _S =*(const TopoDS_Shape *)S;
		const gp_Ax1 &  _A =*(const gp_Ax1 *)A;
	return new BRepPrimAPI_MakeRevol(			
_S,			
_A,			
D,			
Copy);
}
DECL_EXPORT void* BRepPrimAPI_MakeRevol_CtorE3E37232(
	void* S,
	void* A,
	bool Copy)
{
		const TopoDS_Shape &  _S =*(const TopoDS_Shape *)S;
		const gp_Ax1 &  _A =*(const gp_Ax1 *)A;
	return new BRepPrimAPI_MakeRevol(			
_S,			
_A,			
(Standard_Boolean)Copy);
}
DECL_EXPORT void BRepPrimAPI_MakeRevol_Build(void* instance)
{
	BRepPrimAPI_MakeRevol* result = (BRepPrimAPI_MakeRevol*)instance;
 	result->Build();
}
DECL_EXPORT void* BRepPrimAPI_MakeRevol_FirstShape(void* instance)
{
	BRepPrimAPI_MakeRevol* result = (BRepPrimAPI_MakeRevol*)instance;
	return new TopoDS_Shape( 	result->FirstShape());
}
DECL_EXPORT void* BRepPrimAPI_MakeRevol_LastShape(void* instance)
{
	BRepPrimAPI_MakeRevol* result = (BRepPrimAPI_MakeRevol*)instance;
	return new TopoDS_Shape( 	result->LastShape());
}
DECL_EXPORT void* BRepPrimAPI_MakeRevol_FirstShape9EBAC0C0(
	void* instance,
	void* theShape)
{
		const TopoDS_Shape &  _theShape =*(const TopoDS_Shape *)theShape;
	BRepPrimAPI_MakeRevol* result = (BRepPrimAPI_MakeRevol*)instance;
	return new TopoDS_Shape( 	result->FirstShape(			
_theShape));
}
DECL_EXPORT void* BRepPrimAPI_MakeRevol_LastShape9EBAC0C0(
	void* instance,
	void* theShape)
{
		const TopoDS_Shape &  _theShape =*(const TopoDS_Shape *)theShape;
	BRepPrimAPI_MakeRevol* result = (BRepPrimAPI_MakeRevol*)instance;
	return new TopoDS_Shape( 	result->LastShape(			
_theShape));
}
DECL_EXPORT bool BRepPrimAPI_MakeRevol_HasDegenerated(void* instance)
{
	BRepPrimAPI_MakeRevol* result = (BRepPrimAPI_MakeRevol*)instance;
	return 	result->HasDegenerated();
}

DECL_EXPORT void BRepPrimAPIMakeRevol_Dtor(void* instance)
{
	delete (BRepPrimAPI_MakeRevol*)instance;
}
