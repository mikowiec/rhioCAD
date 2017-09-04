#include "BRepFilletAPIMakeFillet.h"
#include <BRepFilletAPI_MakeFillet.hxx>

#include <Geom_Surface.hxx>
#include <Law_Function.hxx>
#include <TopoDS_Edge.hxx>
#include <TopoDS_Shape.hxx>
#include <TopoDS_Vertex.hxx>

DECL_EXPORT void* BRepFilletAPI_MakeFillet_Ctor64E28302(
	void* S,
	int FShape)
{
		const TopoDS_Shape &  _S =*(const TopoDS_Shape *)S;
		const ChFi3d_FilletShape _FShape =(const ChFi3d_FilletShape )FShape;
	return new BRepFilletAPI_MakeFillet(			
_S,			
_FShape);
}
DECL_EXPORT void BRepFilletAPI_MakeFillet_SetParamsBC7A5786(
	void* instance,
	double Tang,
	double Tesp,
	double T2d,
	double TApp3d,
	double TolApp2d,
	double Fleche)
{
	BRepFilletAPI_MakeFillet* result = (BRepFilletAPI_MakeFillet*)instance;
 	result->SetParams(			
Tang,			
Tesp,			
T2d,			
TApp3d,			
TolApp2d,			
Fleche);
}
DECL_EXPORT void BRepFilletAPI_MakeFillet_SetContinuity25CDA01E(
	void* instance,
	int InternalContinuity,
	double AngularTolerance)
{
		const GeomAbs_Shape _InternalContinuity =(const GeomAbs_Shape )InternalContinuity;
	BRepFilletAPI_MakeFillet* result = (BRepFilletAPI_MakeFillet*)instance;
 	result->SetContinuity(			
_InternalContinuity,			
AngularTolerance);
}
DECL_EXPORT void BRepFilletAPI_MakeFillet_Add24263856(
	void* instance,
	void* E)
{
		const TopoDS_Edge &  _E =*(const TopoDS_Edge *)E;
	BRepFilletAPI_MakeFillet* result = (BRepFilletAPI_MakeFillet*)instance;
 	result->Add(			
_E);
}
DECL_EXPORT void BRepFilletAPI_MakeFillet_Add4236945C(
	void* instance,
	double Radius,
	void* E)
{
		const TopoDS_Edge &  _E =*(const TopoDS_Edge *)E;
	BRepFilletAPI_MakeFillet* result = (BRepFilletAPI_MakeFillet*)instance;
 	result->Add(			
Radius,			
_E);
}
DECL_EXPORT void BRepFilletAPI_MakeFillet_AddA7A851FF(
	void* instance,
	double R1,
	double R2,
	void* E)
{
		const TopoDS_Edge &  _E =*(const TopoDS_Edge *)E;
	BRepFilletAPI_MakeFillet* result = (BRepFilletAPI_MakeFillet*)instance;
 	result->Add(			
R1,			
R2,			
_E);
}
DECL_EXPORT void BRepFilletAPI_MakeFillet_Add1E23979B(
	void* instance,
	void* L,
	void* E)
{
		const Handle_Law_Function&  _L =*(const Handle_Law_Function *)L;
		const TopoDS_Edge &  _E =*(const TopoDS_Edge *)E;
	BRepFilletAPI_MakeFillet* result = (BRepFilletAPI_MakeFillet*)instance;
 	result->Add(			
_L,			
_E);
}
DECL_EXPORT void BRepFilletAPI_MakeFillet_SetRadius6B6E73CA(
	void* instance,
	double Radius,
	int IC,
	int IinC)
{
	BRepFilletAPI_MakeFillet* result = (BRepFilletAPI_MakeFillet*)instance;
 	result->SetRadius(			
Radius,			
IC,			
IinC);
}
DECL_EXPORT void BRepFilletAPI_MakeFillet_SetRadius852507E(
	void* instance,
	double R1,
	double R2,
	int IC,
	int IinC)
{
	BRepFilletAPI_MakeFillet* result = (BRepFilletAPI_MakeFillet*)instance;
 	result->SetRadius(			
R1,			
R2,			
IC,			
IinC);
}
DECL_EXPORT void BRepFilletAPI_MakeFillet_SetRadiusE982E75B(
	void* instance,
	void* L,
	int IC,
	int IinC)
{
		const Handle_Law_Function&  _L =*(const Handle_Law_Function *)L;
	BRepFilletAPI_MakeFillet* result = (BRepFilletAPI_MakeFillet*)instance;
 	result->SetRadius(			
_L,			
IC,			
IinC);
}
DECL_EXPORT void BRepFilletAPI_MakeFillet_ResetContourE8219145(
	void* instance,
	int IC)
{
	BRepFilletAPI_MakeFillet* result = (BRepFilletAPI_MakeFillet*)instance;
 	result->ResetContour(			
IC);
}
DECL_EXPORT bool BRepFilletAPI_MakeFillet_IsConstantE8219145(
	void* instance,
	int IC)
{
	BRepFilletAPI_MakeFillet* result = (BRepFilletAPI_MakeFillet*)instance;
	return  	result->IsConstant(			
IC);
}
DECL_EXPORT double BRepFilletAPI_MakeFillet_RadiusE8219145(
	void* instance,
	int IC)
{
	BRepFilletAPI_MakeFillet* result = (BRepFilletAPI_MakeFillet*)instance;
	return  	result->Radius(			
IC);
}
DECL_EXPORT bool BRepFilletAPI_MakeFillet_IsConstant9ED07AFD(
	void* instance,
	int IC,
	void* E)
{
		const TopoDS_Edge &  _E =*(const TopoDS_Edge *)E;
	BRepFilletAPI_MakeFillet* result = (BRepFilletAPI_MakeFillet*)instance;
	return  	result->IsConstant(			
IC,			
_E);
}
DECL_EXPORT double BRepFilletAPI_MakeFillet_Radius9ED07AFD(
	void* instance,
	int IC,
	void* E)
{
		const TopoDS_Edge &  _E =*(const TopoDS_Edge *)E;
	BRepFilletAPI_MakeFillet* result = (BRepFilletAPI_MakeFillet*)instance;
	return  	result->Radius(			
IC,			
_E);
}
DECL_EXPORT void BRepFilletAPI_MakeFillet_SetRadius3B769637(
	void* instance,
	double Radius,
	int IC,
	void* E)
{
		const TopoDS_Edge &  _E =*(const TopoDS_Edge *)E;
	BRepFilletAPI_MakeFillet* result = (BRepFilletAPI_MakeFillet*)instance;
 	result->SetRadius(			
Radius,			
IC,			
_E);
}
DECL_EXPORT void BRepFilletAPI_MakeFillet_SetRadiusD24B0016(
	void* instance,
	double Radius,
	int IC,
	void* V)
{
		const TopoDS_Vertex &  _V =*(const TopoDS_Vertex *)V;
	BRepFilletAPI_MakeFillet* result = (BRepFilletAPI_MakeFillet*)instance;
 	result->SetRadius(			
Radius,			
IC,			
_V);
}
DECL_EXPORT bool BRepFilletAPI_MakeFillet_GetBoundsD04B1C17(
	void* instance,
	int IC,
	void* E,
	double* F,
	double* L)
{
		const TopoDS_Edge &  _E =*(const TopoDS_Edge *)E;
	BRepFilletAPI_MakeFillet* result = (BRepFilletAPI_MakeFillet*)instance;
	return  	result->GetBounds(			
IC,			
_E,			
*F,			
*L);
}
DECL_EXPORT void* BRepFilletAPI_MakeFillet_GetLaw9ED07AFD(
	void* instance,
	int IC,
	void* E)
{
		const TopoDS_Edge &  _E =*(const TopoDS_Edge *)E;
	BRepFilletAPI_MakeFillet* result = (BRepFilletAPI_MakeFillet*)instance;
	return new Handle_Law_Function( 	result->GetLaw(			
IC,			
_E));
}
DECL_EXPORT void BRepFilletAPI_MakeFillet_SetLawB084795E(
	void* instance,
	int IC,
	void* E,
	void* L)
{
		const TopoDS_Edge &  _E =*(const TopoDS_Edge *)E;
		const Handle_Law_Function&  _L =*(const Handle_Law_Function *)L;
	BRepFilletAPI_MakeFillet* result = (BRepFilletAPI_MakeFillet*)instance;
 	result->SetLaw(			
IC,			
_E,			
_L);
}
DECL_EXPORT int BRepFilletAPI_MakeFillet_Contour24263856(
	void* instance,
	void* E)
{
		const TopoDS_Edge &  _E =*(const TopoDS_Edge *)E;
	BRepFilletAPI_MakeFillet* result = (BRepFilletAPI_MakeFillet*)instance;
	return  	result->Contour(			
_E);
}
DECL_EXPORT int BRepFilletAPI_MakeFillet_NbEdgesE8219145(
	void* instance,
	int I)
{
	BRepFilletAPI_MakeFillet* result = (BRepFilletAPI_MakeFillet*)instance;
	return  	result->NbEdges(			
I);
}
DECL_EXPORT void* BRepFilletAPI_MakeFillet_Edge5107F6FE(
	void* instance,
	int I,
	int J)
{
	BRepFilletAPI_MakeFillet* result = (BRepFilletAPI_MakeFillet*)instance;
	return new TopoDS_Edge( 	result->Edge(			
I,			
J));
}
DECL_EXPORT void BRepFilletAPI_MakeFillet_Remove24263856(
	void* instance,
	void* E)
{
		const TopoDS_Edge &  _E =*(const TopoDS_Edge *)E;
	BRepFilletAPI_MakeFillet* result = (BRepFilletAPI_MakeFillet*)instance;
 	result->Remove(			
_E);
}
DECL_EXPORT double BRepFilletAPI_MakeFillet_LengthE8219145(
	void* instance,
	int IC)
{
	BRepFilletAPI_MakeFillet* result = (BRepFilletAPI_MakeFillet*)instance;
	return  	result->Length(			
IC);
}
DECL_EXPORT void* BRepFilletAPI_MakeFillet_FirstVertexE8219145(
	void* instance,
	int IC)
{
	BRepFilletAPI_MakeFillet* result = (BRepFilletAPI_MakeFillet*)instance;
	return new TopoDS_Vertex( 	result->FirstVertex(			
IC));
}
DECL_EXPORT void* BRepFilletAPI_MakeFillet_LastVertexE8219145(
	void* instance,
	int IC)
{
	BRepFilletAPI_MakeFillet* result = (BRepFilletAPI_MakeFillet*)instance;
	return new TopoDS_Vertex( 	result->LastVertex(			
IC));
}
DECL_EXPORT double BRepFilletAPI_MakeFillet_Abscissa680D393(
	void* instance,
	int IC,
	void* V)
{
		const TopoDS_Vertex &  _V =*(const TopoDS_Vertex *)V;
	BRepFilletAPI_MakeFillet* result = (BRepFilletAPI_MakeFillet*)instance;
	return  	result->Abscissa(			
IC,			
_V);
}
DECL_EXPORT double BRepFilletAPI_MakeFillet_RelativeAbscissa680D393(
	void* instance,
	int IC,
	void* V)
{
		const TopoDS_Vertex &  _V =*(const TopoDS_Vertex *)V;
	BRepFilletAPI_MakeFillet* result = (BRepFilletAPI_MakeFillet*)instance;
	return  	result->RelativeAbscissa(			
IC,			
_V);
}
DECL_EXPORT bool BRepFilletAPI_MakeFillet_ClosedAndTangentE8219145(
	void* instance,
	int IC)
{
	BRepFilletAPI_MakeFillet* result = (BRepFilletAPI_MakeFillet*)instance;
	return  	result->ClosedAndTangent(			
IC);
}
DECL_EXPORT bool BRepFilletAPI_MakeFillet_ClosedE8219145(
	void* instance,
	int IC)
{
	BRepFilletAPI_MakeFillet* result = (BRepFilletAPI_MakeFillet*)instance;
	return  	result->Closed(			
IC);
}
DECL_EXPORT void BRepFilletAPI_MakeFillet_Build(void* instance)
{
	BRepFilletAPI_MakeFillet* result = (BRepFilletAPI_MakeFillet*)instance;
 	result->Build();
}
DECL_EXPORT void BRepFilletAPI_MakeFillet_Reset(void* instance)
{
	BRepFilletAPI_MakeFillet* result = (BRepFilletAPI_MakeFillet*)instance;
 	result->Reset();
}
DECL_EXPORT bool BRepFilletAPI_MakeFillet_IsDeleted9EBAC0C0(
	void* instance,
	void* F)
{
		const TopoDS_Shape &  _F =*(const TopoDS_Shape *)F;
	BRepFilletAPI_MakeFillet* result = (BRepFilletAPI_MakeFillet*)instance;
	return  	result->IsDeleted(			
_F);
}
DECL_EXPORT void BRepFilletAPI_MakeFillet_SimulateE8219145(
	void* instance,
	int IC)
{
	BRepFilletAPI_MakeFillet* result = (BRepFilletAPI_MakeFillet*)instance;
 	result->Simulate(			
IC);
}
DECL_EXPORT int BRepFilletAPI_MakeFillet_NbSurfE8219145(
	void* instance,
	int IC)
{
	BRepFilletAPI_MakeFillet* result = (BRepFilletAPI_MakeFillet*)instance;
	return  	result->NbSurf(			
IC);
}
DECL_EXPORT int BRepFilletAPI_MakeFillet_FaultyContourE8219145(
	void* instance,
	int I)
{
	BRepFilletAPI_MakeFillet* result = (BRepFilletAPI_MakeFillet*)instance;
	return  	result->FaultyContour(			
I);
}
DECL_EXPORT int BRepFilletAPI_MakeFillet_NbComputedSurfacesE8219145(
	void* instance,
	int IC)
{
	BRepFilletAPI_MakeFillet* result = (BRepFilletAPI_MakeFillet*)instance;
	return  	result->NbComputedSurfaces(			
IC);
}
DECL_EXPORT void* BRepFilletAPI_MakeFillet_ComputedSurface5107F6FE(
	void* instance,
	int IC,
	int IS)
{
	BRepFilletAPI_MakeFillet* result = (BRepFilletAPI_MakeFillet*)instance;
	return new Handle_Geom_Surface( 	result->ComputedSurface(			
IC,			
IS));
}
DECL_EXPORT void* BRepFilletAPI_MakeFillet_FaultyVertexE8219145(
	void* instance,
	int IV)
{
	BRepFilletAPI_MakeFillet* result = (BRepFilletAPI_MakeFillet*)instance;
	return new TopoDS_Vertex( 	result->FaultyVertex(			
IV));
}
DECL_EXPORT int BRepFilletAPI_MakeFillet_StripeStatusE8219145(
	void* instance,
	int IC)
{
	BRepFilletAPI_MakeFillet* result = (BRepFilletAPI_MakeFillet*)instance;
	return  	result->StripeStatus(			
IC);
}
DECL_EXPORT void BRepFilletAPI_MakeFillet_SetFilletShape(void* instance, int value)
{
	BRepFilletAPI_MakeFillet* result = (BRepFilletAPI_MakeFillet*)instance;
		result->SetFilletShape((const ChFi3d_FilletShape)value);
}

DECL_EXPORT int BRepFilletAPI_MakeFillet_GetFilletShape(void* instance)
{
	BRepFilletAPI_MakeFillet* result = (BRepFilletAPI_MakeFillet*)instance;
	return (int)	result->GetFilletShape();
}

DECL_EXPORT int BRepFilletAPI_MakeFillet_NbContours(void* instance)
{
	BRepFilletAPI_MakeFillet* result = (BRepFilletAPI_MakeFillet*)instance;
	return 	result->NbContours();
}

DECL_EXPORT int BRepFilletAPI_MakeFillet_NbSurfaces(void* instance)
{
	BRepFilletAPI_MakeFillet* result = (BRepFilletAPI_MakeFillet*)instance;
	return 	result->NbSurfaces();
}

DECL_EXPORT int BRepFilletAPI_MakeFillet_NbFaultyContours(void* instance)
{
	BRepFilletAPI_MakeFillet* result = (BRepFilletAPI_MakeFillet*)instance;
	return 	result->NbFaultyContours();
}

DECL_EXPORT int BRepFilletAPI_MakeFillet_NbFaultyVertices(void* instance)
{
	BRepFilletAPI_MakeFillet* result = (BRepFilletAPI_MakeFillet*)instance;
	return 	result->NbFaultyVertices();
}

DECL_EXPORT bool BRepFilletAPI_MakeFillet_HasResult(void* instance)
{
	BRepFilletAPI_MakeFillet* result = (BRepFilletAPI_MakeFillet*)instance;
	return 	result->HasResult();
}

DECL_EXPORT void* BRepFilletAPI_MakeFillet_BadShape(void* instance)
{
	BRepFilletAPI_MakeFillet* result = (BRepFilletAPI_MakeFillet*)instance;
	return 	new TopoDS_Shape(	result->BadShape());
}

DECL_EXPORT void BRepFilletAPIMakeFillet_Dtor(void* instance)
{
	delete (BRepFilletAPI_MakeFillet*)instance;
}
