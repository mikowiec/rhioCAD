#ifndef Poly_Triangulation_H
#define Poly_Triangulation_H

#include "../../Export_Import.h"

extern "C" DECL_EXPORT void* Poly_Triangulation_Ctor28218E44(
	int nbNodes,
	int nbTriangles,
	bool UVNodes);
extern "C" DECL_EXPORT void* Poly_Triangulation_Ctor9EE6697D(
	void* Nodes,
	void* Triangles);
extern "C" DECL_EXPORT double Poly_Triangulation_Deflection(void* instance);
extern "C" DECL_EXPORT void Poly_Triangulation_DeflectionD82819F3(
	void* instance,
	double D);
extern "C" DECL_EXPORT void Poly_Triangulation_RemoveUVNodes(void* instance);
extern "C" DECL_EXPORT int Poly_Triangulation_NbNodes(void* instance);
extern "C" DECL_EXPORT int Poly_Triangulation_NbTriangles(void* instance);
extern "C" DECL_EXPORT bool Poly_Triangulation_HasUVNodes(void* instance);
extern "C" DECL_EXPORT void* Poly_Triangulation_Nodes(void* instance);
extern "C" DECL_EXPORT void* Poly_Triangulation_Triangles(void* instance);
extern "C" DECL_EXPORT bool Poly_Triangulation_HasNormals(void* instance);
extern "C" DECL_EXPORT void PolyTriangulation_Dtor(void* instance);

#endif
