#include "IntToolsContext.h"
#include <IntTools_Context.hxx>

#include <BRepClass3d_SolidClassifier.hxx>

DECL_EXPORT void* IntTools_Context_Ctor()
{
	return new Handle_IntTools_Context(new IntTools_Context());
}
DECL_EXPORT void* IntTools_Context_SolidClassifier56111E92(
	void* instance,
	void* aSolid)
{
		const TopoDS_Solid &  _aSolid =*(const TopoDS_Solid *)aSolid;
	IntTools_Context* result = (IntTools_Context*)(((Handle_IntTools_Context*)instance)->Access());
	return new BRepClass3d_SolidClassifier( 	result->SolidClassifier(			
_aSolid));
}
DECL_EXPORT int IntTools_Context_ComputeVE644637E6(
	void* instance,
	void* aV,
	void* aE,
	double* aT)
{
		const TopoDS_Vertex &  _aV =*(const TopoDS_Vertex *)aV;
		const TopoDS_Edge &  _aE =*(const TopoDS_Edge *)aE;
	IntTools_Context* result = (IntTools_Context*)(((Handle_IntTools_Context*)instance)->Access());
	return  	result->ComputeVE(			
_aV,			
_aE,			
*aT);
}
DECL_EXPORT int IntTools_Context_ComputeVE14B7C63A(
	void* instance,
	void* aV,
	void* aE,
	double* aT,
	bool* bToUpdateVertex,
	double* aDist)
{
		const TopoDS_Vertex &  _aV =*(const TopoDS_Vertex *)aV;
		const TopoDS_Edge &  _aE =*(const TopoDS_Edge *)aE;
	IntTools_Context* result = (IntTools_Context*)(((Handle_IntTools_Context*)instance)->Access());
	return  	result->ComputeVE(			
_aV,			
_aE,			
*aT,			
(Standard_Boolean&)bToUpdateVertex,			
*aDist);
}
DECL_EXPORT int IntTools_Context_ComputeVS2502EEC5(
	void* instance,
	void* aV,
	void* aF,
	double* U,
	double* V)
{
		const TopoDS_Vertex &  _aV =*(const TopoDS_Vertex *)aV;
		const TopoDS_Face &  _aF =*(const TopoDS_Face *)aF;
	IntTools_Context* result = (IntTools_Context*)(((Handle_IntTools_Context*)instance)->Access());
	return  	result->ComputeVS(			
_aV,			
_aF,			
*U,			
*V);
}
DECL_EXPORT int IntTools_Context_StatePointFace15F1B95A(
	void* instance,
	void* aF,
	void* aP2D)
{
		const TopoDS_Face &  _aF =*(const TopoDS_Face *)aF;
		const gp_Pnt2d &  _aP2D =*(const gp_Pnt2d *)aP2D;
	IntTools_Context* result = (IntTools_Context*)(((Handle_IntTools_Context*)instance)->Access());
	return  	result->StatePointFace(			
_aF,			
_aP2D);
}
DECL_EXPORT bool IntTools_Context_IsPointInFace15F1B95A(
	void* instance,
	void* aF,
	void* aP2D)
{
		const TopoDS_Face &  _aF =*(const TopoDS_Face *)aF;
		const gp_Pnt2d &  _aP2D =*(const gp_Pnt2d *)aP2D;
	IntTools_Context* result = (IntTools_Context*)(((Handle_IntTools_Context*)instance)->Access());
	return  	result->IsPointInFace(			
_aF,			
_aP2D);
}
DECL_EXPORT bool IntTools_Context_IsPointInOnFace15F1B95A(
	void* instance,
	void* aF,
	void* aP2D)
{
		const TopoDS_Face &  _aF =*(const TopoDS_Face *)aF;
		const gp_Pnt2d &  _aP2D =*(const gp_Pnt2d *)aP2D;
	IntTools_Context* result = (IntTools_Context*)(((Handle_IntTools_Context*)instance)->Access());
	return  	result->IsPointInOnFace(			
_aF,			
_aP2D);
}
DECL_EXPORT bool IntTools_Context_IsValidPointForFace51B2A608(
	void* instance,
	void* aP3D,
	void* aF,
	double aTol)
{
		const gp_Pnt &  _aP3D =*(const gp_Pnt *)aP3D;
		const TopoDS_Face &  _aF =*(const TopoDS_Face *)aF;
	IntTools_Context* result = (IntTools_Context*)(((Handle_IntTools_Context*)instance)->Access());
	return  	result->IsValidPointForFace(			
_aP3D,			
_aF,			
aTol);
}
DECL_EXPORT bool IntTools_Context_IsValidPointForFaces53322313(
	void* instance,
	void* aP3D,
	void* aF1,
	void* aF2,
	double aTol)
{
		const gp_Pnt &  _aP3D =*(const gp_Pnt *)aP3D;
		const TopoDS_Face &  _aF1 =*(const TopoDS_Face *)aF1;
		const TopoDS_Face &  _aF2 =*(const TopoDS_Face *)aF2;
	IntTools_Context* result = (IntTools_Context*)(((Handle_IntTools_Context*)instance)->Access());
	return  	result->IsValidPointForFaces(			
_aP3D,			
_aF1,			
_aF2,			
aTol);
}
DECL_EXPORT bool IntTools_Context_IsValidBlockForFace3F82E9C8(
	void* instance,
	double aT1,
	double aT2,
	void* aIC,
	void* aF,
	double aTol)
{
		const IntTools_Curve &  _aIC =*(const IntTools_Curve *)aIC;
		const TopoDS_Face &  _aF =*(const TopoDS_Face *)aF;
	IntTools_Context* result = (IntTools_Context*)(((Handle_IntTools_Context*)instance)->Access());
	return  	result->IsValidBlockForFace(			
aT1,			
aT2,			
_aIC,			
_aF,			
aTol);
}
DECL_EXPORT bool IntTools_Context_IsValidBlockForFacesC37F6D8D(
	void* instance,
	double aT1,
	double aT2,
	void* aIC,
	void* aF1,
	void* aF2,
	double aTol)
{
		const IntTools_Curve &  _aIC =*(const IntTools_Curve *)aIC;
		const TopoDS_Face &  _aF1 =*(const TopoDS_Face *)aF1;
		const TopoDS_Face &  _aF2 =*(const TopoDS_Face *)aF2;
	IntTools_Context* result = (IntTools_Context*)(((Handle_IntTools_Context*)instance)->Access());
	return  	result->IsValidBlockForFaces(			
aT1,			
aT2,			
_aIC,			
_aF1,			
_aF2,			
aTol);
}
DECL_EXPORT bool IntTools_Context_IsVertexOnLineE4D8858(
	void* instance,
	void* aV,
	void* aIC,
	double aTolC,
	double* aT)
{
		const TopoDS_Vertex &  _aV =*(const TopoDS_Vertex *)aV;
		const IntTools_Curve &  _aIC =*(const IntTools_Curve *)aIC;
	IntTools_Context* result = (IntTools_Context*)(((Handle_IntTools_Context*)instance)->Access());
	return  	result->IsVertexOnLine(			
_aV,			
_aIC,			
aTolC,			
*aT);
}
DECL_EXPORT bool IntTools_Context_IsVertexOnLine7D7AFC65(
	void* instance,
	void* aV,
	double aTolV,
	void* aIC,
	double aTolC,
	double* aT)
{
		const TopoDS_Vertex &  _aV =*(const TopoDS_Vertex *)aV;
		const IntTools_Curve &  _aIC =*(const IntTools_Curve *)aIC;
	IntTools_Context* result = (IntTools_Context*)(((Handle_IntTools_Context*)instance)->Access());
	return  	result->IsVertexOnLine(			
_aV,			
aTolV,			
_aIC,			
aTolC,			
*aT);
}
DECL_EXPORT bool IntTools_Context_ProjectPointOnEdge31FF11E7(
	void* instance,
	void* aP,
	void* aE,
	double* aT)
{
		const gp_Pnt &  _aP =*(const gp_Pnt *)aP;
		const TopoDS_Edge &  _aE =*(const TopoDS_Edge *)aE;
	IntTools_Context* result = (IntTools_Context*)(((Handle_IntTools_Context*)instance)->Access());
	return  	result->ProjectPointOnEdge(			
_aP,			
_aE,			
*aT);
}
DECL_EXPORT void IntToolsContext_Dtor(void* instance)
{
	delete (Handle_IntTools_Context*)instance;
}
