#include "PolyTriangulation.h"
#include <Poly_Triangulation.hxx>

#include <Poly_Array1OfTriangle.hxx>
#include <TColgp_Array1OfPnt.hxx>

DECL_EXPORT void* Poly_Triangulation_Ctor28218E44(
	int nbNodes,
	int nbTriangles,
	bool UVNodes)
{
	return new Handle_Poly_Triangulation(new Poly_Triangulation(			
nbNodes,			
nbTriangles,			
UVNodes));
}
DECL_EXPORT void* Poly_Triangulation_Ctor9EE6697D(
	void* Nodes,
	void* Triangles)
{
		const TColgp_Array1OfPnt &  _Nodes =*(const TColgp_Array1OfPnt *)Nodes;
		const Poly_Array1OfTriangle &  _Triangles =*(const Poly_Array1OfTriangle *)Triangles;
	return new Handle_Poly_Triangulation(new Poly_Triangulation(			
_Nodes,			
_Triangles));
}
DECL_EXPORT double Poly_Triangulation_Deflection(void* instance)
{
	Poly_Triangulation* result = (Poly_Triangulation*)(((Handle_Poly_Triangulation*)instance)->Access());
	return  	result->Deflection();
}
DECL_EXPORT void Poly_Triangulation_DeflectionD82819F3(
	void* instance,
	double D)
{
	Poly_Triangulation* result = (Poly_Triangulation*)(((Handle_Poly_Triangulation*)instance)->Access());
 	result->Deflection(			
D);
}
DECL_EXPORT void Poly_Triangulation_RemoveUVNodes(void* instance)
{
	Poly_Triangulation* result = (Poly_Triangulation*)(((Handle_Poly_Triangulation*)instance)->Access());
 	result->RemoveUVNodes();
}
DECL_EXPORT int Poly_Triangulation_NbNodes(void* instance)
{
	Poly_Triangulation* result = (Poly_Triangulation*)(((Handle_Poly_Triangulation*)instance)->Access());
	return 	result->NbNodes();
}

DECL_EXPORT int Poly_Triangulation_NbTriangles(void* instance)
{
	Poly_Triangulation* result = (Poly_Triangulation*)(((Handle_Poly_Triangulation*)instance)->Access());
	return 	result->NbTriangles();
}

DECL_EXPORT bool Poly_Triangulation_HasUVNodes(void* instance)
{
	Poly_Triangulation* result = (Poly_Triangulation*)(((Handle_Poly_Triangulation*)instance)->Access());
	return 	result->HasUVNodes();
}

DECL_EXPORT void* Poly_Triangulation_Nodes(void* instance)
{
	TColgp_Array1OfPnt* data = new TColgp_Array1OfPnt(0, 10);
	Poly_Triangulation* result = (Poly_Triangulation*)(((Handle_Poly_Triangulation*)instance)->Access());
	*data = result->Nodes();
	return 	data;
}

DECL_EXPORT void* Poly_Triangulation_Triangles(void* instance)
{
	Poly_Array1OfTriangle* data = new Poly_Array1OfTriangle(0, 10);
	Poly_Triangulation* result = (Poly_Triangulation*)(((Handle_Poly_Triangulation*)instance)->Access());
	*data = result->Triangles();
	return data;
}

DECL_EXPORT bool Poly_Triangulation_HasNormals(void* instance)
{
	Poly_Triangulation* result = (Poly_Triangulation*)(((Handle_Poly_Triangulation*)instance)->Access());
	return 	result->HasNormals();
}

DECL_EXPORT void PolyTriangulation_Dtor(void* instance)
{
	delete (Handle_Poly_Triangulation*)instance;
}
