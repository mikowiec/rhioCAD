#include "BRepMeshVertex.h"
#include <BRepMesh_Vertex.hxx>

#include <gp_XY.hxx>

DECL_EXPORT void* BRepMesh_Vertex_Ctor()
{
	return new BRepMesh_Vertex();
}
DECL_EXPORT void* BRepMesh_Vertex_CtorE385E6C0(
	void* UV,
	int Locat3d,
	int Move)
{
		const gp_XY &  _UV =*(const gp_XY *)UV;
		const BRepMesh_DegreeOfFreedom _Move =(const BRepMesh_DegreeOfFreedom )Move;
	return new BRepMesh_Vertex(			
_UV,			
Locat3d,			
_Move);
}
DECL_EXPORT void* BRepMesh_Vertex_Ctor7460CC1A(
	double U,
	double V,
	int Move)
{
		const BRepMesh_DegreeOfFreedom _Move =(const BRepMesh_DegreeOfFreedom )Move;
	return new BRepMesh_Vertex(			
U,			
V,			
_Move);
}
DECL_EXPORT void BRepMesh_Vertex_InitializeE385E6C0(
	void* instance,
	void* UV,
	int Locat3d,
	int Move)
{
		const gp_XY &  _UV =*(const gp_XY *)UV;
		const BRepMesh_DegreeOfFreedom _Move =(const BRepMesh_DegreeOfFreedom )Move;
	BRepMesh_Vertex* result = (BRepMesh_Vertex*)instance;
 	result->Initialize(			
_UV,			
Locat3d,			
_Move);
}
DECL_EXPORT int BRepMesh_Vertex_HashCodeE8219145(
	void* instance,
	int Upper)
{
	BRepMesh_Vertex* result = (BRepMesh_Vertex*)instance;
	return  	result->HashCode(			
Upper);
}
DECL_EXPORT bool BRepMesh_Vertex_IsEqualFA897224(
	void* instance,
	void* Other)
{
		const BRepMesh_Vertex &  _Other =*(const BRepMesh_Vertex *)Other;
	BRepMesh_Vertex* result = (BRepMesh_Vertex*)instance;
	return  	result->IsEqual(			
_Other);
}
DECL_EXPORT void* BRepMesh_Vertex_Coord(void* instance)
{
	BRepMesh_Vertex* result = (BRepMesh_Vertex*)instance;
	return 	new gp_XY(	result->Coord());
}

DECL_EXPORT int BRepMesh_Vertex_Location3d(void* instance)
{
	BRepMesh_Vertex* result = (BRepMesh_Vertex*)instance;
	return 	result->Location3d();
}

DECL_EXPORT void BRepMesh_Vertex_SetMovability(void* instance, int value)
{
	BRepMesh_Vertex* result = (BRepMesh_Vertex*)instance;
		result->SetMovability((const BRepMesh_DegreeOfFreedom)value);
}

DECL_EXPORT int BRepMesh_Vertex_Movability(void* instance)
{
	BRepMesh_Vertex* result = (BRepMesh_Vertex*)instance;
	return (int)	result->Movability();
}

DECL_EXPORT void BRepMeshVertex_Dtor(void* instance)
{
	delete (BRepMesh_Vertex*)instance;
}
