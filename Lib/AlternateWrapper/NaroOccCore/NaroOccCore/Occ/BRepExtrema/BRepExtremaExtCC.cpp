#include "BRepExtremaExtCC.h"
#include <BRepExtrema_ExtCC.hxx>

#include <gp_Pnt.hxx>

DECL_EXPORT void* BRepExtrema_ExtCC_Ctor()
{
	return new BRepExtrema_ExtCC();
}
DECL_EXPORT void* BRepExtrema_ExtCC_Ctor4DFF7017(
	void* E1,
	void* E2)
{
		const TopoDS_Edge &  _E1 =*(const TopoDS_Edge *)E1;
		const TopoDS_Edge &  _E2 =*(const TopoDS_Edge *)E2;
	return new BRepExtrema_ExtCC(			
_E1,			
_E2);
}
DECL_EXPORT void BRepExtrema_ExtCC_Initialize24263856(
	void* instance,
	void* E2)
{
		const TopoDS_Edge &  _E2 =*(const TopoDS_Edge *)E2;
	BRepExtrema_ExtCC* result = (BRepExtrema_ExtCC*)instance;
 	result->Initialize(			
_E2);
}
DECL_EXPORT void BRepExtrema_ExtCC_Perform24263856(
	void* instance,
	void* E1)
{
		const TopoDS_Edge &  _E1 =*(const TopoDS_Edge *)E1;
	BRepExtrema_ExtCC* result = (BRepExtrema_ExtCC*)instance;
 	result->Perform(			
_E1);
}
DECL_EXPORT double BRepExtrema_ExtCC_SquareDistanceE8219145(
	void* instance,
	int N)
{
	BRepExtrema_ExtCC* result = (BRepExtrema_ExtCC*)instance;
	return  	result->SquareDistance(			
N);
}
DECL_EXPORT double BRepExtrema_ExtCC_ParameterOnE1E8219145(
	void* instance,
	int N)
{
	BRepExtrema_ExtCC* result = (BRepExtrema_ExtCC*)instance;
	return  	result->ParameterOnE1(			
N);
}
DECL_EXPORT void* BRepExtrema_ExtCC_PointOnE1E8219145(
	void* instance,
	int N)
{
	BRepExtrema_ExtCC* result = (BRepExtrema_ExtCC*)instance;
	return new gp_Pnt( 	result->PointOnE1(			
N));
}
DECL_EXPORT double BRepExtrema_ExtCC_ParameterOnE2E8219145(
	void* instance,
	int N)
{
	BRepExtrema_ExtCC* result = (BRepExtrema_ExtCC*)instance;
	return  	result->ParameterOnE2(			
N);
}
DECL_EXPORT void* BRepExtrema_ExtCC_PointOnE2E8219145(
	void* instance,
	int N)
{
	BRepExtrema_ExtCC* result = (BRepExtrema_ExtCC*)instance;
	return new gp_Pnt( 	result->PointOnE2(			
N));
}
DECL_EXPORT void BRepExtrema_ExtCC_TrimmedDistancesACE69995(
	void* instance,
	double* dist11,
	double* distP12,
	double* distP21,
	double* distP22,
	void* P11,
	void* P12,
	void* P21,
	void* P22)
{
		 gp_Pnt &  _P11 =*( gp_Pnt *)P11;
		 gp_Pnt &  _P12 =*( gp_Pnt *)P12;
		 gp_Pnt &  _P21 =*( gp_Pnt *)P21;
		 gp_Pnt &  _P22 =*( gp_Pnt *)P22;
	BRepExtrema_ExtCC* result = (BRepExtrema_ExtCC*)instance;
 	result->TrimmedSquareDistances(			
*dist11,			
*distP12,			
*distP21,			
*distP22,			
_P11,			
_P12,			
_P21,			
_P22);
}
DECL_EXPORT bool BRepExtrema_ExtCC_IsDone(void* instance)
{
	BRepExtrema_ExtCC* result = (BRepExtrema_ExtCC*)instance;
	return 	result->IsDone();
}

DECL_EXPORT int BRepExtrema_ExtCC_NbExt(void* instance)
{
	BRepExtrema_ExtCC* result = (BRepExtrema_ExtCC*)instance;
	return 	result->NbExt();
}

DECL_EXPORT bool BRepExtrema_ExtCC_IsParallel(void* instance)
{
	BRepExtrema_ExtCC* result = (BRepExtrema_ExtCC*)instance;
	return 	result->IsParallel();
}

DECL_EXPORT void BRepExtremaExtCC_Dtor(void* instance)
{
	delete (BRepExtrema_ExtCC*)instance;
}
