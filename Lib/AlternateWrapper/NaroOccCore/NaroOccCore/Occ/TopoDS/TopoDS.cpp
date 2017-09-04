#include "TopoDS.h"
#include <TopoDS.hxx>

#include <TopoDS_Compound.hxx>
#include <TopoDS_CompSolid.hxx>
#include <TopoDS_Edge.hxx>
#include <TopoDS_Face.hxx>
#include <TopoDS_Shell.hxx>
#include <TopoDS_Solid.hxx>
#include <TopoDS_Vertex.hxx>
#include <TopoDS_Wire.hxx>

DECL_EXPORT void* TopoDS_Vertex9EBAC0C0(
	void* S)
{
		const TopoDS_Shape &  _S =*(const TopoDS_Shape *)S;
	return new TopoDS_Vertex( TopoDS::Vertex(			
_S));
}
DECL_EXPORT void* TopoDS_Edge9EBAC0C0(
	void* S)
{
		const TopoDS_Shape &  _S =*(const TopoDS_Shape *)S;
	return new TopoDS_Edge( TopoDS::Edge(			
_S));
}
DECL_EXPORT void* TopoDS_Wire9EBAC0C0(
	void* S)
{
		const TopoDS_Shape &  _S =*(const TopoDS_Shape *)S;
	return new TopoDS_Wire( TopoDS::Wire(			
_S));
}
DECL_EXPORT void* TopoDS_Face9EBAC0C0(
	void* S)
{
		const TopoDS_Shape &  _S =*(const TopoDS_Shape *)S;
	return new TopoDS_Face( TopoDS::Face(			
_S));
}
DECL_EXPORT void* TopoDS_Shell9EBAC0C0(
	void* S)
{
		const TopoDS_Shape &  _S =*(const TopoDS_Shape *)S;
	return new TopoDS_Shell( TopoDS::Shell(			
_S));
}
DECL_EXPORT void* TopoDS_Solid9EBAC0C0(
	void* S)
{
		const TopoDS_Shape &  _S =*(const TopoDS_Shape *)S;
	return new TopoDS_Solid( TopoDS::Solid(			
_S));
}
DECL_EXPORT void* TopoDS_CompSolid9EBAC0C0(
	void* S)
{
		const TopoDS_Shape &  _S =*(const TopoDS_Shape *)S;
	return new TopoDS_CompSolid( TopoDS::CompSolid(			
_S));
}
DECL_EXPORT void* TopoDS_Compound9EBAC0C0(
	void* S)
{
		const TopoDS_Shape &  _S =*(const TopoDS_Shape *)S;
	return new TopoDS_Compound( TopoDS::Compound(			
_S));
}
DECL_EXPORT void TopoDS_Dtor(void* instance)
{
	delete (TopoDS*)instance;
}
