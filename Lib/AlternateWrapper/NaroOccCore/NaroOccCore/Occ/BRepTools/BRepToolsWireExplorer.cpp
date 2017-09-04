#include "BRepToolsWireExplorer.h"
#include <BRepTools_WireExplorer.hxx>

#include <TopoDS_Edge.hxx>
#include <TopoDS_Vertex.hxx>

DECL_EXPORT void* BRepTools_WireExplorer_Ctor()
{
	return new BRepTools_WireExplorer();
}
DECL_EXPORT void* BRepTools_WireExplorer_Ctor368EDFE5(
	void* W)
{
		const TopoDS_Wire &  _W =*(const TopoDS_Wire *)W;
	return new BRepTools_WireExplorer(			
_W);
}
DECL_EXPORT void* BRepTools_WireExplorer_Ctor3BE52234(
	void* W,
	void* F)
{
		const TopoDS_Wire &  _W =*(const TopoDS_Wire *)W;
		const TopoDS_Face &  _F =*(const TopoDS_Face *)F;
	return new BRepTools_WireExplorer(			
_W,			
_F);
}
DECL_EXPORT void BRepTools_WireExplorer_Init368EDFE5(
	void* instance,
	void* W)
{
		const TopoDS_Wire &  _W =*(const TopoDS_Wire *)W;
	BRepTools_WireExplorer* result = (BRepTools_WireExplorer*)instance;
 	result->Init(			
_W);
}
DECL_EXPORT void BRepTools_WireExplorer_Init3BE52234(
	void* instance,
	void* W,
	void* F)
{
		const TopoDS_Wire &  _W =*(const TopoDS_Wire *)W;
		const TopoDS_Face &  _F =*(const TopoDS_Face *)F;
	BRepTools_WireExplorer* result = (BRepTools_WireExplorer*)instance;
 	result->Init(			
_W,			
_F);
}
DECL_EXPORT void BRepTools_WireExplorer_Next(void* instance)
{
	BRepTools_WireExplorer* result = (BRepTools_WireExplorer*)instance;
 	result->Next();
}
DECL_EXPORT void BRepTools_WireExplorer_Clear(void* instance)
{
	BRepTools_WireExplorer* result = (BRepTools_WireExplorer*)instance;
 	result->Clear();
}
DECL_EXPORT bool BRepTools_WireExplorer_More(void* instance)
{
	BRepTools_WireExplorer* result = (BRepTools_WireExplorer*)instance;
	return 	result->More();
}

DECL_EXPORT void* BRepTools_WireExplorer_Current(void* instance)
{
	BRepTools_WireExplorer* result = (BRepTools_WireExplorer*)instance;
	return 	new TopoDS_Edge(	result->Current());
}

DECL_EXPORT int BRepTools_WireExplorer_Orientation(void* instance)
{
	BRepTools_WireExplorer* result = (BRepTools_WireExplorer*)instance;
	return (int)	result->Orientation();
}

DECL_EXPORT void* BRepTools_WireExplorer_CurrentVertex(void* instance)
{
	BRepTools_WireExplorer* result = (BRepTools_WireExplorer*)instance;
	return 	new TopoDS_Vertex(	result->CurrentVertex());
}

DECL_EXPORT void BRepToolsWireExplorer_Dtor(void* instance)
{
	delete (BRepTools_WireExplorer*)instance;
}
