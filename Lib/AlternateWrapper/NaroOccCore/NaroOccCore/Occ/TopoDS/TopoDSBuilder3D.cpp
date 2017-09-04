#include "TopoDSBuilder3D.h"
#include <TopoDS_Builder3D.hxx>


DECL_EXPORT void TopoDS_Builder3D_MakeShell41B0EE4D(
	void* instance,
	void* S)
{
		 TopoDS_Shell &  _S =*( TopoDS_Shell *)S;
	TopoDS_Builder3D* result = (TopoDS_Builder3D*)instance;
 	result->MakeShell(			
_S);
}
DECL_EXPORT void TopoDS_Builder3D_MakeSolid56111E92(
	void* instance,
	void* S)
{
		 TopoDS_Solid &  _S =*( TopoDS_Solid *)S;
	TopoDS_Builder3D* result = (TopoDS_Builder3D*)instance;
 	result->MakeSolid(			
_S);
}
DECL_EXPORT void TopoDS_Builder3D_MakeCompSolid2CBA9E0B(
	void* instance,
	void* C)
{
		 TopoDS_CompSolid &  _C =*( TopoDS_CompSolid *)C;
	TopoDS_Builder3D* result = (TopoDS_Builder3D*)instance;
 	result->MakeCompSolid(			
_C);
}
DECL_EXPORT void TopoDSBuilder3D_Dtor(void* instance)
{
	delete (TopoDS_Builder3D*)instance;
}
