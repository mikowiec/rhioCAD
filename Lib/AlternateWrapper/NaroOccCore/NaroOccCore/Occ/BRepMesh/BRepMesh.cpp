#include "BRepMesh.h"
#include <BRepMesh.hxx>


DECL_EXPORT void BRepMesh_Mesh92EB56FA(
	void* S,
	double d)
{
		const TopoDS_Shape &  _S =*(const TopoDS_Shape *)S;
 BRepMesh::Mesh(			
_S,			
d);
}
DECL_EXPORT void BRepMesh_Dtor(void* instance)
{
	delete (BRepMesh*)instance;
}
