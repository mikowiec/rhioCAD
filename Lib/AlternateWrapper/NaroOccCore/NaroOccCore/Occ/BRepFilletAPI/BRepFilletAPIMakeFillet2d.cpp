#include "BRepFilletAPIMakeFillet2d.h"
#include <BRepFilletAPI_MakeFillet2d.hxx>

#include <TopoDS_Edge.hxx>
#include <TopoDS_Vertex.hxx>

DECL_EXPORT void* BRepFilletAPI_MakeFillet2d_Ctor()
{
	return new BRepFilletAPI_MakeFillet2d();
}
DECL_EXPORT void* BRepFilletAPI_MakeFillet2d_CtorAEC70AC1(
	void* F)
{
		const TopoDS_Face &  _F =*(const TopoDS_Face *)F;
	return new BRepFilletAPI_MakeFillet2d(			
_F);
}
DECL_EXPORT void BRepFilletAPI_MakeFillet2d_InitAEC70AC1(
	void* instance,
	void* F)
{
		const TopoDS_Face &  _F =*(const TopoDS_Face *)F;
	BRepFilletAPI_MakeFillet2d* result = (BRepFilletAPI_MakeFillet2d*)instance;
 	result->Init(			
_F);
}
DECL_EXPORT void BRepFilletAPI_MakeFillet2d_Init9D93DFBA(
	void* instance,
	void* RefFace,
	void* ModFace)
{
		const TopoDS_Face &  _RefFace =*(const TopoDS_Face *)RefFace;
		const TopoDS_Face &  _ModFace =*(const TopoDS_Face *)ModFace;
	BRepFilletAPI_MakeFillet2d* result = (BRepFilletAPI_MakeFillet2d*)instance;
 	result->Init(			
_RefFace,			
_ModFace);
}
DECL_EXPORT void* BRepFilletAPI_MakeFillet2d_AddFillet729B627B(
	void* instance,
	void* V,
	double Radius)
{
		const TopoDS_Vertex &  _V =*(const TopoDS_Vertex *)V;
	BRepFilletAPI_MakeFillet2d* result = (BRepFilletAPI_MakeFillet2d*)instance;
	return new TopoDS_Edge( 	result->AddFillet(			
_V,			
Radius));
}
DECL_EXPORT void* BRepFilletAPI_MakeFillet2d_ModifyFillet809BA47B(
	void* instance,
	void* Fillet,
	double Radius)
{
		const TopoDS_Edge &  _Fillet =*(const TopoDS_Edge *)Fillet;
	BRepFilletAPI_MakeFillet2d* result = (BRepFilletAPI_MakeFillet2d*)instance;
	return new TopoDS_Edge( 	result->ModifyFillet(			
_Fillet,			
Radius));
}
DECL_EXPORT void* BRepFilletAPI_MakeFillet2d_RemoveFillet24263856(
	void* instance,
	void* Fillet)
{
		const TopoDS_Edge &  _Fillet =*(const TopoDS_Edge *)Fillet;
	BRepFilletAPI_MakeFillet2d* result = (BRepFilletAPI_MakeFillet2d*)instance;
	return new TopoDS_Vertex( 	result->RemoveFillet(			
_Fillet));
}
DECL_EXPORT void* BRepFilletAPI_MakeFillet2d_AddChamferFF157EBA(
	void* instance,
	void* E1,
	void* E2,
	double D1,
	double D2)
{
		const TopoDS_Edge &  _E1 =*(const TopoDS_Edge *)E1;
		const TopoDS_Edge &  _E2 =*(const TopoDS_Edge *)E2;
	BRepFilletAPI_MakeFillet2d* result = (BRepFilletAPI_MakeFillet2d*)instance;
	return new TopoDS_Edge( 	result->AddChamfer(			
_E1,			
_E2,			
D1,			
D2));
}
DECL_EXPORT void* BRepFilletAPI_MakeFillet2d_AddChamfer619A10E2(
	void* instance,
	void* E,
	void* V,
	double D,
	double Ang)
{
		const TopoDS_Edge &  _E =*(const TopoDS_Edge *)E;
		const TopoDS_Vertex &  _V =*(const TopoDS_Vertex *)V;
	BRepFilletAPI_MakeFillet2d* result = (BRepFilletAPI_MakeFillet2d*)instance;
	return new TopoDS_Edge( 	result->AddChamfer(			
_E,			
_V,			
D,			
Ang));
}
DECL_EXPORT void* BRepFilletAPI_MakeFillet2d_ModifyChamfer9D62DE59(
	void* instance,
	void* Chamfer,
	void* E1,
	void* E2,
	double D1,
	double D2)
{
		const TopoDS_Edge &  _Chamfer =*(const TopoDS_Edge *)Chamfer;
		const TopoDS_Edge &  _E1 =*(const TopoDS_Edge *)E1;
		const TopoDS_Edge &  _E2 =*(const TopoDS_Edge *)E2;
	BRepFilletAPI_MakeFillet2d* result = (BRepFilletAPI_MakeFillet2d*)instance;
	return new TopoDS_Edge( 	result->ModifyChamfer(			
_Chamfer,			
_E1,			
_E2,			
D1,			
D2));
}
DECL_EXPORT void* BRepFilletAPI_MakeFillet2d_ModifyChamferFF157EBA(
	void* instance,
	void* Chamfer,
	void* E,
	double D,
	double Ang)
{
		const TopoDS_Edge &  _Chamfer =*(const TopoDS_Edge *)Chamfer;
		const TopoDS_Edge &  _E =*(const TopoDS_Edge *)E;
	BRepFilletAPI_MakeFillet2d* result = (BRepFilletAPI_MakeFillet2d*)instance;
	return new TopoDS_Edge( 	result->ModifyChamfer(			
_Chamfer,			
_E,			
D,			
Ang));
}
DECL_EXPORT void* BRepFilletAPI_MakeFillet2d_RemoveChamfer24263856(
	void* instance,
	void* Chamfer)
{
		const TopoDS_Edge &  _Chamfer =*(const TopoDS_Edge *)Chamfer;
	BRepFilletAPI_MakeFillet2d* result = (BRepFilletAPI_MakeFillet2d*)instance;
	return new TopoDS_Vertex( 	result->RemoveChamfer(			
_Chamfer));
}
DECL_EXPORT bool BRepFilletAPI_MakeFillet2d_IsModified24263856(
	void* instance,
	void* E)
{
		const TopoDS_Edge &  _E =*(const TopoDS_Edge *)E;
	BRepFilletAPI_MakeFillet2d* result = (BRepFilletAPI_MakeFillet2d*)instance;
	return  	result->IsModified(			
_E);
}
DECL_EXPORT bool BRepFilletAPI_MakeFillet2d_HasDescendant24263856(
	void* instance,
	void* E)
{
		const TopoDS_Edge &  _E =*(const TopoDS_Edge *)E;
	BRepFilletAPI_MakeFillet2d* result = (BRepFilletAPI_MakeFillet2d*)instance;
	return  	result->HasDescendant(			
_E);
}
DECL_EXPORT void* BRepFilletAPI_MakeFillet2d_DescendantEdge24263856(
	void* instance,
	void* E)
{
		const TopoDS_Edge &  _E =*(const TopoDS_Edge *)E;
	BRepFilletAPI_MakeFillet2d* result = (BRepFilletAPI_MakeFillet2d*)instance;
	return new TopoDS_Edge( 	result->DescendantEdge(			
_E));
}
DECL_EXPORT void* BRepFilletAPI_MakeFillet2d_BasisEdge24263856(
	void* instance,
	void* E)
{
		const TopoDS_Edge &  _E =*(const TopoDS_Edge *)E;
	BRepFilletAPI_MakeFillet2d* result = (BRepFilletAPI_MakeFillet2d*)instance;
	return new TopoDS_Edge( 	result->BasisEdge(			
_E));
}
DECL_EXPORT void BRepFilletAPI_MakeFillet2d_Build(void* instance)
{
	BRepFilletAPI_MakeFillet2d* result = (BRepFilletAPI_MakeFillet2d*)instance;
 	result->Build();
}
DECL_EXPORT int BRepFilletAPI_MakeFillet2d_NbFillet(void* instance)
{
	BRepFilletAPI_MakeFillet2d* result = (BRepFilletAPI_MakeFillet2d*)instance;
	return 	result->NbFillet();
}

DECL_EXPORT int BRepFilletAPI_MakeFillet2d_NbChamfer(void* instance)
{
	BRepFilletAPI_MakeFillet2d* result = (BRepFilletAPI_MakeFillet2d*)instance;
	return 	result->NbChamfer();
}

DECL_EXPORT int BRepFilletAPI_MakeFillet2d_NbCurves(void* instance)
{
	BRepFilletAPI_MakeFillet2d* result = (BRepFilletAPI_MakeFillet2d*)instance;
	return 	result->NbCurves();
}

DECL_EXPORT int BRepFilletAPI_MakeFillet2d_Status(void* instance)
{
	BRepFilletAPI_MakeFillet2d* result = (BRepFilletAPI_MakeFillet2d*)instance;
	return (int)	result->Status();
}

DECL_EXPORT void BRepFilletAPIMakeFillet2d_Dtor(void* instance)
{
	delete (BRepFilletAPI_MakeFillet2d*)instance;
}
