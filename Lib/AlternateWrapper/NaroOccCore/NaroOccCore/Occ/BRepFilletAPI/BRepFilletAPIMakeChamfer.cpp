#include "BRepFilletAPIMakeChamfer.h"
#include <BRepFilletAPI_MakeChamfer.hxx>

#include <TopoDS_Edge.hxx>
#include <TopoDS_Vertex.hxx>

DECL_EXPORT void* BRepFilletAPI_MakeChamfer_Ctor9EBAC0C0(
	void* S)
{
		const TopoDS_Shape &  _S =*(const TopoDS_Shape *)S;
	return new BRepFilletAPI_MakeChamfer(			
_S);
}
DECL_EXPORT void BRepFilletAPI_MakeChamfer_Add24263856(
	void* instance,
	void* E)
{
		const TopoDS_Edge &  _E =*(const TopoDS_Edge *)E;
	BRepFilletAPI_MakeChamfer* result = (BRepFilletAPI_MakeChamfer*)instance;
 	result->Add(			
_E);
}
DECL_EXPORT void BRepFilletAPI_MakeChamfer_Add36F68A5F(
	void* instance,
	double Dis,
	void* E,
	void* F)
{
		const TopoDS_Edge &  _E =*(const TopoDS_Edge *)E;
		const TopoDS_Face &  _F =*(const TopoDS_Face *)F;
	BRepFilletAPI_MakeChamfer* result = (BRepFilletAPI_MakeChamfer*)instance;
 	result->Add(			
Dis,			
_E,			
_F);
}
DECL_EXPORT void BRepFilletAPI_MakeChamfer_SetDist264F3866(
	void* instance,
	double Dis,
	int IC,
	void* F)
{
		const TopoDS_Face &  _F =*(const TopoDS_Face *)F;
	BRepFilletAPI_MakeChamfer* result = (BRepFilletAPI_MakeChamfer*)instance;
 	result->SetDist(			
Dis,			
IC,			
_F);
}
DECL_EXPORT void BRepFilletAPI_MakeChamfer_GetDist69F5FCCD(
	void* instance,
	int IC,
	double* Dis)
{
	BRepFilletAPI_MakeChamfer* result = (BRepFilletAPI_MakeChamfer*)instance;
 	result->GetDist(			
IC,			
*Dis);
}
DECL_EXPORT void BRepFilletAPI_MakeChamfer_Add17BBF1FC(
	void* instance,
	double Dis1,
	double Dis2,
	void* E,
	void* F)
{
		const TopoDS_Edge &  _E =*(const TopoDS_Edge *)E;
		const TopoDS_Face &  _F =*(const TopoDS_Face *)F;
	BRepFilletAPI_MakeChamfer* result = (BRepFilletAPI_MakeChamfer*)instance;
 	result->Add(			
Dis1,			
Dis2,			
_E,			
_F);
}
DECL_EXPORT void BRepFilletAPI_MakeChamfer_SetDists5071FCAE(
	void* instance,
	double Dis1,
	double Dis2,
	int IC,
	void* F)
{
		const TopoDS_Face &  _F =*(const TopoDS_Face *)F;
	BRepFilletAPI_MakeChamfer* result = (BRepFilletAPI_MakeChamfer*)instance;
 	result->SetDists(			
Dis1,			
Dis2,			
IC,			
_F);
}
DECL_EXPORT void BRepFilletAPI_MakeChamfer_Dists306E0DFB(
	void* instance,
	int IC,
	double* Dis1,
	double* Dis2)
{
	BRepFilletAPI_MakeChamfer* result = (BRepFilletAPI_MakeChamfer*)instance;
 	result->Dists(			
IC,			
*Dis1,			
*Dis2);
}
DECL_EXPORT void BRepFilletAPI_MakeChamfer_AddDA17BBF1FC(
	void* instance,
	double Dis,
	double Angle,
	void* E,
	void* F)
{
		const TopoDS_Edge &  _E =*(const TopoDS_Edge *)E;
		const TopoDS_Face &  _F =*(const TopoDS_Face *)F;
	BRepFilletAPI_MakeChamfer* result = (BRepFilletAPI_MakeChamfer*)instance;
 	result->AddDA(			
Dis,			
Angle,			
_E,			
_F);
}
DECL_EXPORT void BRepFilletAPI_MakeChamfer_SetDistAngle5071FCAE(
	void* instance,
	double Dis,
	double Angle,
	int IC,
	void* F)
{
		const TopoDS_Face &  _F =*(const TopoDS_Face *)F;
	BRepFilletAPI_MakeChamfer* result = (BRepFilletAPI_MakeChamfer*)instance;
 	result->SetDistAngle(			
Dis,			
Angle,			
IC,			
_F);
}
DECL_EXPORT bool BRepFilletAPI_MakeChamfer_IsSymetricE8219145(
	void* instance,
	int IC)
{
	BRepFilletAPI_MakeChamfer* result = (BRepFilletAPI_MakeChamfer*)instance;
	return  	result->IsSymetric(			
IC);
}
DECL_EXPORT bool BRepFilletAPI_MakeChamfer_IsTwoDistancesE8219145(
	void* instance,
	int IC)
{
	BRepFilletAPI_MakeChamfer* result = (BRepFilletAPI_MakeChamfer*)instance;
	return  	result->IsTwoDistances(			
IC);
}
DECL_EXPORT bool BRepFilletAPI_MakeChamfer_IsDistanceAngleE8219145(
	void* instance,
	int IC)
{
	BRepFilletAPI_MakeChamfer* result = (BRepFilletAPI_MakeChamfer*)instance;
	return  	result->IsDistanceAngle(			
IC);
}
DECL_EXPORT void BRepFilletAPI_MakeChamfer_ResetContourE8219145(
	void* instance,
	int IC)
{
	BRepFilletAPI_MakeChamfer* result = (BRepFilletAPI_MakeChamfer*)instance;
 	result->ResetContour(			
IC);
}
DECL_EXPORT int BRepFilletAPI_MakeChamfer_Contour24263856(
	void* instance,
	void* E)
{
		const TopoDS_Edge &  _E =*(const TopoDS_Edge *)E;
	BRepFilletAPI_MakeChamfer* result = (BRepFilletAPI_MakeChamfer*)instance;
	return  	result->Contour(			
_E);
}
DECL_EXPORT int BRepFilletAPI_MakeChamfer_NbEdgesE8219145(
	void* instance,
	int I)
{
	BRepFilletAPI_MakeChamfer* result = (BRepFilletAPI_MakeChamfer*)instance;
	return  	result->NbEdges(			
I);
}
DECL_EXPORT void* BRepFilletAPI_MakeChamfer_Edge5107F6FE(
	void* instance,
	int I,
	int J)
{
	BRepFilletAPI_MakeChamfer* result = (BRepFilletAPI_MakeChamfer*)instance;
	return new TopoDS_Edge( 	result->Edge(			
I,			
J));
}
DECL_EXPORT void BRepFilletAPI_MakeChamfer_Remove24263856(
	void* instance,
	void* E)
{
		const TopoDS_Edge &  _E =*(const TopoDS_Edge *)E;
	BRepFilletAPI_MakeChamfer* result = (BRepFilletAPI_MakeChamfer*)instance;
 	result->Remove(			
_E);
}
DECL_EXPORT double BRepFilletAPI_MakeChamfer_LengthE8219145(
	void* instance,
	int IC)
{
	BRepFilletAPI_MakeChamfer* result = (BRepFilletAPI_MakeChamfer*)instance;
	return  	result->Length(			
IC);
}
DECL_EXPORT void* BRepFilletAPI_MakeChamfer_FirstVertexE8219145(
	void* instance,
	int IC)
{
	BRepFilletAPI_MakeChamfer* result = (BRepFilletAPI_MakeChamfer*)instance;
	return new TopoDS_Vertex( 	result->FirstVertex(			
IC));
}
DECL_EXPORT void* BRepFilletAPI_MakeChamfer_LastVertexE8219145(
	void* instance,
	int IC)
{
	BRepFilletAPI_MakeChamfer* result = (BRepFilletAPI_MakeChamfer*)instance;
	return new TopoDS_Vertex( 	result->LastVertex(			
IC));
}
DECL_EXPORT double BRepFilletAPI_MakeChamfer_Abscissa680D393(
	void* instance,
	int IC,
	void* V)
{
		const TopoDS_Vertex &  _V =*(const TopoDS_Vertex *)V;
	BRepFilletAPI_MakeChamfer* result = (BRepFilletAPI_MakeChamfer*)instance;
	return  	result->Abscissa(			
IC,			
_V);
}
DECL_EXPORT double BRepFilletAPI_MakeChamfer_RelativeAbscissa680D393(
	void* instance,
	int IC,
	void* V)
{
		const TopoDS_Vertex &  _V =*(const TopoDS_Vertex *)V;
	BRepFilletAPI_MakeChamfer* result = (BRepFilletAPI_MakeChamfer*)instance;
	return  	result->RelativeAbscissa(			
IC,			
_V);
}
DECL_EXPORT bool BRepFilletAPI_MakeChamfer_ClosedAndTangentE8219145(
	void* instance,
	int IC)
{
	BRepFilletAPI_MakeChamfer* result = (BRepFilletAPI_MakeChamfer*)instance;
	return  	result->ClosedAndTangent(			
IC);
}
DECL_EXPORT bool BRepFilletAPI_MakeChamfer_ClosedE8219145(
	void* instance,
	int IC)
{
	BRepFilletAPI_MakeChamfer* result = (BRepFilletAPI_MakeChamfer*)instance;
	return  	result->Closed(			
IC);
}
DECL_EXPORT void BRepFilletAPI_MakeChamfer_Build(void* instance)
{
	BRepFilletAPI_MakeChamfer* result = (BRepFilletAPI_MakeChamfer*)instance;
 	result->Build();
}
DECL_EXPORT void BRepFilletAPI_MakeChamfer_Reset(void* instance)
{
	BRepFilletAPI_MakeChamfer* result = (BRepFilletAPI_MakeChamfer*)instance;
 	result->Reset();
}
DECL_EXPORT bool BRepFilletAPI_MakeChamfer_IsDeleted9EBAC0C0(
	void* instance,
	void* F)
{
		const TopoDS_Shape &  _F =*(const TopoDS_Shape *)F;
	BRepFilletAPI_MakeChamfer* result = (BRepFilletAPI_MakeChamfer*)instance;
	return  	result->IsDeleted(			
_F);
}
DECL_EXPORT void BRepFilletAPI_MakeChamfer_SimulateE8219145(
	void* instance,
	int IC)
{
	BRepFilletAPI_MakeChamfer* result = (BRepFilletAPI_MakeChamfer*)instance;
 	result->Simulate(			
IC);
}
DECL_EXPORT int BRepFilletAPI_MakeChamfer_NbSurfE8219145(
	void* instance,
	int IC)
{
	BRepFilletAPI_MakeChamfer* result = (BRepFilletAPI_MakeChamfer*)instance;
	return  	result->NbSurf(			
IC);
}
DECL_EXPORT int BRepFilletAPI_MakeChamfer_NbContours(void* instance)
{
	BRepFilletAPI_MakeChamfer* result = (BRepFilletAPI_MakeChamfer*)instance;
	return 	result->NbContours();
}

DECL_EXPORT void BRepFilletAPIMakeChamfer_Dtor(void* instance)
{
	delete (BRepFilletAPI_MakeChamfer*)instance;
}
