#include "BOPLoop.h"
#include <BOP_Loop.hxx>

#include <BOP_BlockIterator.hxx>
#include <TopoDS_Shape.hxx>

DECL_EXPORT void* BOP_Loop_Ctor9EBAC0C0(
	void* S)
{
		const TopoDS_Shape &  _S =*(const TopoDS_Shape *)S;
	return new Handle_BOP_Loop(new BOP_Loop(			
_S));
}
DECL_EXPORT void* BOP_Loop_CtorD1FD8153(
	void* BI)
{
		const BOP_BlockIterator &  _BI =*(const BOP_BlockIterator *)BI;
	return new Handle_BOP_Loop(new BOP_Loop(			
_BI));
}
DECL_EXPORT bool BOP_Loop_IsShape(void* instance)
{
	BOP_Loop* result = (BOP_Loop*)(((Handle_BOP_Loop*)instance)->Access());
	return 	result->IsShape();
}

DECL_EXPORT void* BOP_Loop_Shape(void* instance)
{
	BOP_Loop* result = (BOP_Loop*)(((Handle_BOP_Loop*)instance)->Access());
	return 	new TopoDS_Shape(	result->Shape());
}

DECL_EXPORT void* BOP_Loop_BlockIterator(void* instance)
{
	BOP_Loop* result = (BOP_Loop*)(((Handle_BOP_Loop*)instance)->Access());
	return 	new BOP_BlockIterator(	result->BlockIterator());
}

DECL_EXPORT void BOPLoop_Dtor(void* instance)
{
	delete (Handle_BOP_Loop*)instance;
}
