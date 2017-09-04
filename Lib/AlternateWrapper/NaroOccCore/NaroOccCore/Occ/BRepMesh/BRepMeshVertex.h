#ifndef BRepMesh_Vertex_H
#define BRepMesh_Vertex_H

#include "../../Export_Import.h"

extern "C" DECL_EXPORT void* BRepMesh_Vertex_Ctor();
extern "C" DECL_EXPORT void* BRepMesh_Vertex_CtorE385E6C0(
	void* UV,
	int Locat3d,
	int Move);
extern "C" DECL_EXPORT void* BRepMesh_Vertex_Ctor7460CC1A(
	double U,
	double V,
	int Move);
extern "C" DECL_EXPORT void BRepMesh_Vertex_InitializeE385E6C0(
	void* instance,
	void* UV,
	int Locat3d,
	int Move);
extern "C" DECL_EXPORT int BRepMesh_Vertex_HashCodeE8219145(
	void* instance,
	int Upper);
extern "C" DECL_EXPORT bool BRepMesh_Vertex_IsEqualFA897224(
	void* instance,
	void* Other);
extern "C" DECL_EXPORT void* BRepMesh_Vertex_Coord(void* instance);
extern "C" DECL_EXPORT int BRepMesh_Vertex_Location3d(void* instance);
extern "C" DECL_EXPORT void BRepMesh_Vertex_SetMovability(void* instance, int value);
extern "C" DECL_EXPORT int BRepMesh_Vertex_Movability(void* instance);
extern "C" DECL_EXPORT void BRepMeshVertex_Dtor(void* instance);

#endif
