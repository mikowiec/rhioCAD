#include "BRepTools.h"
#include <BRepTools.hxx>

#include <TopoDS_Shell.hxx>
#include <TopoDS_Wire.hxx>

DECL_EXPORT void BRepTools_UVBounds443C7451(
	void* F,
	double* UMin,
	double* UMax,
	double* VMin,
	double* VMax)
{
		const TopoDS_Face &  _F =*(const TopoDS_Face *)F;
 BRepTools::UVBounds(			
_F,			
*UMin,			
*UMax,			
*VMin,			
*VMax);
}
DECL_EXPORT void BRepTools_UVBoundsEF82485C(
	void* F,
	void* W,
	double* UMin,
	double* UMax,
	double* VMin,
	double* VMax)
{
		const TopoDS_Face &  _F =*(const TopoDS_Face *)F;
		const TopoDS_Wire &  _W =*(const TopoDS_Wire *)W;
 BRepTools::UVBounds(			
_F,			
_W,			
*UMin,			
*UMax,			
*VMin,			
*VMax);
}
DECL_EXPORT void BRepTools_UVBounds5F413ED6(
	void* F,
	void* E,
	double* UMin,
	double* UMax,
	double* VMin,
	double* VMax)
{
		const TopoDS_Face &  _F =*(const TopoDS_Face *)F;
		const TopoDS_Edge &  _E =*(const TopoDS_Edge *)E;
 BRepTools::UVBounds(			
_F,			
_E,			
*UMin,			
*UMax,			
*VMin,			
*VMax);
}
DECL_EXPORT void BRepTools_AddUVBounds38403D27(
	void* F,
	void* B)
{
		const TopoDS_Face &  _F =*(const TopoDS_Face *)F;
		 Bnd_Box2d &  _B =*( Bnd_Box2d *)B;
 BRepTools::AddUVBounds(			
_F,			
_B);
}
DECL_EXPORT void BRepTools_AddUVBounds3ADDD719(
	void* F,
	void* W,
	void* B)
{
		const TopoDS_Face &  _F =*(const TopoDS_Face *)F;
		const TopoDS_Wire &  _W =*(const TopoDS_Wire *)W;
		 Bnd_Box2d &  _B =*( Bnd_Box2d *)B;
 BRepTools::AddUVBounds(			
_F,			
_W,			
_B);
}
DECL_EXPORT void BRepTools_AddUVBounds5756543C(
	void* F,
	void* E,
	void* B)
{
		const TopoDS_Face &  _F =*(const TopoDS_Face *)F;
		const TopoDS_Edge &  _E =*(const TopoDS_Edge *)E;
		 Bnd_Box2d &  _B =*( Bnd_Box2d *)B;
 BRepTools::AddUVBounds(			
_F,			
_E,			
_B);
}
DECL_EXPORT void BRepTools_Update3EF07F6A(
	void* V)
{
		const TopoDS_Vertex &  _V =*(const TopoDS_Vertex *)V;
 BRepTools::Update(			
_V);
}
DECL_EXPORT void BRepTools_Update24263856(
	void* E)
{
		const TopoDS_Edge &  _E =*(const TopoDS_Edge *)E;
 BRepTools::Update(			
_E);
}
DECL_EXPORT void BRepTools_Update368EDFE5(
	void* W)
{
		const TopoDS_Wire &  _W =*(const TopoDS_Wire *)W;
 BRepTools::Update(			
_W);
}
DECL_EXPORT void BRepTools_UpdateAEC70AC1(
	void* F)
{
		const TopoDS_Face &  _F =*(const TopoDS_Face *)F;
 BRepTools::Update(			
_F);
}
DECL_EXPORT void BRepTools_Update41B0EE4D(
	void* S)
{
		const TopoDS_Shell &  _S =*(const TopoDS_Shell *)S;
 BRepTools::Update(			
_S);
}
DECL_EXPORT void BRepTools_Update56111E92(
	void* S)
{
		const TopoDS_Solid &  _S =*(const TopoDS_Solid *)S;
 BRepTools::Update(			
_S);
}
DECL_EXPORT void BRepTools_Update2CBA9E0B(
	void* C)
{
		const TopoDS_CompSolid &  _C =*(const TopoDS_CompSolid *)C;
 BRepTools::Update(			
_C);
}
DECL_EXPORT void BRepTools_UpdateF7963FEC(
	void* C)
{
		const TopoDS_Compound &  _C =*(const TopoDS_Compound *)C;
 BRepTools::Update(			
_C);
}
DECL_EXPORT void BRepTools_Update9EBAC0C0(
	void* S)
{
		const TopoDS_Shape &  _S =*(const TopoDS_Shape *)S;
 BRepTools::Update(			
_S);
}
DECL_EXPORT void BRepTools_UpdateFaceUVPointsAEC70AC1(
	void* F)
{
		const TopoDS_Face &  _F =*(const TopoDS_Face *)F;
 BRepTools::UpdateFaceUVPoints(			
_F);
}
DECL_EXPORT void BRepTools_Clean9EBAC0C0(
	void* S)
{
		const TopoDS_Shape &  _S =*(const TopoDS_Shape *)S;
 BRepTools::Clean(			
_S);
}
DECL_EXPORT void BRepTools_RemoveUnusedPCurves9EBAC0C0(
	void* S)
{
		const TopoDS_Shape &  _S =*(const TopoDS_Shape *)S;
 BRepTools::RemoveUnusedPCurves(			
_S);
}
DECL_EXPORT bool BRepTools_Triangulation92EB56FA(
	void* S,
	double deflec)
{
		const TopoDS_Shape &  _S =*(const TopoDS_Shape *)S;
	return  BRepTools::Triangulation(			
_S,			
deflec);
}
DECL_EXPORT bool BRepTools_Compare17F57B4B(
	void* V1,
	void* V2)
{
		const TopoDS_Vertex &  _V1 =*(const TopoDS_Vertex *)V1;
		const TopoDS_Vertex &  _V2 =*(const TopoDS_Vertex *)V2;
	return  BRepTools::Compare(			
_V1,			
_V2);
}
DECL_EXPORT bool BRepTools_Compare4DFF7017(
	void* E1,
	void* E2)
{
		const TopoDS_Edge &  _E1 =*(const TopoDS_Edge *)E1;
		const TopoDS_Edge &  _E2 =*(const TopoDS_Edge *)E2;
	return  BRepTools::Compare(			
_E1,			
_E2);
}
DECL_EXPORT void* BRepTools_OuterWireAEC70AC1(
	void* F)
{
		const TopoDS_Face &  _F =*(const TopoDS_Face *)F;
	return new TopoDS_Wire( BRepTools::OuterWire(			
_F));
}
DECL_EXPORT void* BRepTools_OuterShell56111E92(
	void* S)
{
		const TopoDS_Solid &  _S =*(const TopoDS_Solid *)S;
	return new TopoDS_Shell( BRepTools::OuterShell(			
_S));
}
DECL_EXPORT void BRepTools_Map3DEdgesBBDCAF89(
	void* S,
	void* M)
{
		const TopoDS_Shape &  _S =*(const TopoDS_Shape *)S;
		 TopTools_IndexedMapOfShape &  _M =*( TopTools_IndexedMapOfShape *)M;
 BRepTools::Map3DEdges(			
_S,			
_M);
}
DECL_EXPORT bool BRepTools_IsReallyClosed65EC701C(
	void* E,
	void* F)
{
		const TopoDS_Edge &  _E =*(const TopoDS_Edge *)E;
		const TopoDS_Face &  _F =*(const TopoDS_Face *)F;
	return  BRepTools::IsReallyClosed(			
_E,			
_F);
}
DECL_EXPORT bool BRepTools_Write4AF8BC88(
	void* Sh,
	char* File,
	void* PR)
{
		const TopoDS_Shape &  _Sh =*(const TopoDS_Shape *)Sh;
		const Handle_Message_ProgressIndicator&  _PR =*(const Handle_Message_ProgressIndicator *)PR;
	return  BRepTools::Write(			
_Sh,			
File,			
_PR);
}
DECL_EXPORT bool BRepTools_ReadEBEE9A3E(
	void* Sh,
	char* File,
	void* B,
	void* PR)
{
		 TopoDS_Shape &  _Sh =*( TopoDS_Shape *)Sh;
		const BRep_Builder &  _B =*(const BRep_Builder *)B;
		const Handle_Message_ProgressIndicator&  _PR =*(const Handle_Message_ProgressIndicator *)PR;
	return  BRepTools::Read(			
_Sh,			
File,			
_B,			
_PR);
}
DECL_EXPORT void BRepTools_Dtor(void* instance)
{
	delete (BRepTools*)instance;
}
