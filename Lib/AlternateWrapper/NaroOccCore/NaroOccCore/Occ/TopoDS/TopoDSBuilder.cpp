#include "TopoDSBuilder.h"
#include <TopoDS_Builder.hxx>


DECL_EXPORT void TopoDS_Builder_MakeWire368EDFE5(
	void* instance,
	void* W)
{
		 TopoDS_Wire &  _W =*( TopoDS_Wire *)W;
	TopoDS_Builder* result = (TopoDS_Builder*)instance;
 	result->MakeWire(			
_W);
}
DECL_EXPORT void TopoDS_Builder_MakeShell41B0EE4D(
	void* instance,
	void* S)
{
		 TopoDS_Shell &  _S =*( TopoDS_Shell *)S;
	TopoDS_Builder* result = (TopoDS_Builder*)instance;
 	result->MakeShell(			
_S);
}
DECL_EXPORT void TopoDS_Builder_MakeSolid56111E92(
	void* instance,
	void* S)
{
		 TopoDS_Solid &  _S =*( TopoDS_Solid *)S;
	TopoDS_Builder* result = (TopoDS_Builder*)instance;
 	result->MakeSolid(			
_S);
}
DECL_EXPORT void TopoDS_Builder_MakeCompSolid2CBA9E0B(
	void* instance,
	void* C)
{
		 TopoDS_CompSolid &  _C =*( TopoDS_CompSolid *)C;
	TopoDS_Builder* result = (TopoDS_Builder*)instance;
 	result->MakeCompSolid(			
_C);
}
DECL_EXPORT void TopoDS_Builder_MakeCompoundF7963FEC(
	void* instance,
	void* C)
{
		 TopoDS_Compound &  _C =*( TopoDS_Compound *)C;
	TopoDS_Builder* result = (TopoDS_Builder*)instance;
 	result->MakeCompound(			
_C);
}
DECL_EXPORT void TopoDS_Builder_Add877A736F(
	void* instance,
	void* S,
	void* C)
{
		 TopoDS_Shape &  _S =*( TopoDS_Shape *)S;
		const TopoDS_Shape &  _C =*(const TopoDS_Shape *)C;
	TopoDS_Builder* result = (TopoDS_Builder*)instance;
 	result->Add(			
_S,			
_C);
}
DECL_EXPORT void TopoDS_Builder_Remove877A736F(
	void* instance,
	void* S,
	void* C)
{
		 TopoDS_Shape &  _S =*( TopoDS_Shape *)S;
		const TopoDS_Shape &  _C =*(const TopoDS_Shape *)C;
	TopoDS_Builder* result = (TopoDS_Builder*)instance;
 	result->Remove(			
_S,			
_C);
}
DECL_EXPORT void TopoDSBuilder_Dtor(void* instance)
{
	delete (TopoDS_Builder*)instance;
}
