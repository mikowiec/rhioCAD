#include "GeomBezierCurve.h"
#include <Geom_BezierCurve.hxx>

#include <Geom_Geometry.hxx>
#include <gp_Pnt.hxx>
#include <gp_Vec.hxx>

DECL_EXPORT void* Geom_BezierCurve_CtorFABD0F95(
	void* CurvePoles)
{
		const TColgp_Array1OfPnt &  _CurvePoles =*(const TColgp_Array1OfPnt *)CurvePoles;
	return new Handle_Geom_BezierCurve(new Geom_BezierCurve(			
_CurvePoles));
}
DECL_EXPORT void Geom_BezierCurve_IncreaseE8219145(
	void* instance,
	int Degree)
{
	Geom_BezierCurve* result = (Geom_BezierCurve*)(((Handle_Geom_BezierCurve*)instance)->Access());
 	result->Increase(			
Degree);
}
DECL_EXPORT void Geom_BezierCurve_InsertPoleAfter7B5D1E58(
	void* instance,
	int Index,
	void* P)
{
		const gp_Pnt &  _P =*(const gp_Pnt *)P;
	Geom_BezierCurve* result = (Geom_BezierCurve*)(((Handle_Geom_BezierCurve*)instance)->Access());
 	result->InsertPoleAfter(			
Index,			
_P);
}
DECL_EXPORT void Geom_BezierCurve_InsertPoleAfter7C5189B4(
	void* instance,
	int Index,
	void* P,
	double Weight)
{
		const gp_Pnt &  _P =*(const gp_Pnt *)P;
	Geom_BezierCurve* result = (Geom_BezierCurve*)(((Handle_Geom_BezierCurve*)instance)->Access());
 	result->InsertPoleAfter(			
Index,			
_P,			
Weight);
}
DECL_EXPORT void Geom_BezierCurve_InsertPoleBefore7B5D1E58(
	void* instance,
	int Index,
	void* P)
{
		const gp_Pnt &  _P =*(const gp_Pnt *)P;
	Geom_BezierCurve* result = (Geom_BezierCurve*)(((Handle_Geom_BezierCurve*)instance)->Access());
 	result->InsertPoleBefore(			
Index,			
_P);
}
DECL_EXPORT void Geom_BezierCurve_InsertPoleBefore7C5189B4(
	void* instance,
	int Index,
	void* P,
	double Weight)
{
		const gp_Pnt &  _P =*(const gp_Pnt *)P;
	Geom_BezierCurve* result = (Geom_BezierCurve*)(((Handle_Geom_BezierCurve*)instance)->Access());
 	result->InsertPoleBefore(			
Index,			
_P,			
Weight);
}
DECL_EXPORT void Geom_BezierCurve_RemovePoleE8219145(
	void* instance,
	int Index)
{
	Geom_BezierCurve* result = (Geom_BezierCurve*)(((Handle_Geom_BezierCurve*)instance)->Access());
 	result->RemovePole(			
Index);
}
DECL_EXPORT void Geom_BezierCurve_Reverse(void* instance)
{
	Geom_BezierCurve* result = (Geom_BezierCurve*)(((Handle_Geom_BezierCurve*)instance)->Access());
 	result->Reverse();
}
DECL_EXPORT double Geom_BezierCurve_ReversedParameterD82819F3(
	void* instance,
	double U)
{
	Geom_BezierCurve* result = (Geom_BezierCurve*)(((Handle_Geom_BezierCurve*)instance)->Access());
	return  	result->ReversedParameter(			
U);
}
DECL_EXPORT void Geom_BezierCurve_Segment9F0E714F(
	void* instance,
	double U1,
	double U2)
{
	Geom_BezierCurve* result = (Geom_BezierCurve*)(((Handle_Geom_BezierCurve*)instance)->Access());
 	result->Segment(			
U1,			
U2);
}
DECL_EXPORT void Geom_BezierCurve_SetPole7B5D1E58(
	void* instance,
	int Index,
	void* P)
{
		const gp_Pnt &  _P =*(const gp_Pnt *)P;
	Geom_BezierCurve* result = (Geom_BezierCurve*)(((Handle_Geom_BezierCurve*)instance)->Access());
 	result->SetPole(			
Index,			
_P);
}
DECL_EXPORT void Geom_BezierCurve_SetPole7C5189B4(
	void* instance,
	int Index,
	void* P,
	double Weight)
{
		const gp_Pnt &  _P =*(const gp_Pnt *)P;
	Geom_BezierCurve* result = (Geom_BezierCurve*)(((Handle_Geom_BezierCurve*)instance)->Access());
 	result->SetPole(			
Index,			
_P,			
Weight);
}
DECL_EXPORT void Geom_BezierCurve_SetWeight69F5FCCD(
	void* instance,
	int Index,
	double Weight)
{
	Geom_BezierCurve* result = (Geom_BezierCurve*)(((Handle_Geom_BezierCurve*)instance)->Access());
 	result->SetWeight(			
Index,			
Weight);
}
DECL_EXPORT bool Geom_BezierCurve_IsCNE8219145(
	void* instance,
	int N)
{
	Geom_BezierCurve* result = (Geom_BezierCurve*)(((Handle_Geom_BezierCurve*)instance)->Access());
	return  	result->IsCN(			
N);
}
DECL_EXPORT void Geom_BezierCurve_D053A5A2C1(
	void* instance,
	double U,
	void* P)
{
		gp_Pnt &  _P =*(gp_Pnt *)P;
	Geom_BezierCurve* result = (Geom_BezierCurve*)(((Handle_Geom_BezierCurve*)instance)->Access());
 	result->D0(			
U,			
_P);
}
DECL_EXPORT void Geom_BezierCurve_D11387A81(
	void* instance,
	double U,
	void* P,
	void* V1)
{
		gp_Pnt &  _P =*(gp_Pnt *)P;
		gp_Vec &  _V1 =*(gp_Vec *)V1;
	Geom_BezierCurve* result = (Geom_BezierCurve*)(((Handle_Geom_BezierCurve*)instance)->Access());
 	result->D1(			
U,			
_P,			
_V1);
}
DECL_EXPORT void Geom_BezierCurve_D227877840(
	void* instance,
	double U,
	void* P,
	void* V1,
	void* V2)
{
		gp_Pnt &  _P =*(gp_Pnt *)P;
		gp_Vec &  _V1 =*(gp_Vec *)V1;
		gp_Vec &  _V2 =*(gp_Vec *)V2;
	Geom_BezierCurve* result = (Geom_BezierCurve*)(((Handle_Geom_BezierCurve*)instance)->Access());
 	result->D2(			
U,			
_P,			
_V1,			
_V2);
}
DECL_EXPORT void Geom_BezierCurve_D356E36E6F(
	void* instance,
	double U,
	void* P,
	void* V1,
	void* V2,
	void* V3)
{
		gp_Pnt &  _P =*(gp_Pnt *)P;
		gp_Vec &  _V1 =*(gp_Vec *)V1;
		gp_Vec &  _V2 =*(gp_Vec *)V2;
		gp_Vec &  _V3 =*(gp_Vec *)V3;
	Geom_BezierCurve* result = (Geom_BezierCurve*)(((Handle_Geom_BezierCurve*)instance)->Access());
 	result->D3(			
U,			
_P,			
_V1,			
_V2,			
_V3);
}
DECL_EXPORT void* Geom_BezierCurve_DN2935ABDE(
	void* instance,
	double U,
	int N)
{
	Geom_BezierCurve* result = (Geom_BezierCurve*)(((Handle_Geom_BezierCurve*)instance)->Access());
	return new gp_Vec( 	result->DN(			
U,			
N));
}
DECL_EXPORT void* Geom_BezierCurve_PoleE8219145(
	void* instance,
	int Index)
{
	Geom_BezierCurve* result = (Geom_BezierCurve*)(((Handle_Geom_BezierCurve*)instance)->Access());
	return new gp_Pnt( 	result->Pole(			
Index));
}
DECL_EXPORT void Geom_BezierCurve_PolesFABD0F95(
	void* instance,
	void* P)
{
		TColgp_Array1OfPnt &  _P =*(TColgp_Array1OfPnt *)P;
	Geom_BezierCurve* result = (Geom_BezierCurve*)(((Handle_Geom_BezierCurve*)instance)->Access());
 	result->Poles(			
_P);
}
DECL_EXPORT double Geom_BezierCurve_WeightE8219145(
	void* instance,
	int Index)
{
	Geom_BezierCurve* result = (Geom_BezierCurve*)(((Handle_Geom_BezierCurve*)instance)->Access());
	return  	result->Weight(			
Index);
}
DECL_EXPORT void Geom_BezierCurve_Transform72D78650(
	void* instance,
	void* T)
{
		const gp_Trsf &  _T =*(const gp_Trsf *)T;
	Geom_BezierCurve* result = (Geom_BezierCurve*)(((Handle_Geom_BezierCurve*)instance)->Access());
 	result->Transform(			
_T);
}
DECL_EXPORT void Geom_BezierCurve_Resolution9F0E714F(
	void* instance,
	double Tolerance3D,
	double* UTolerance)
{
	Geom_BezierCurve* result = (Geom_BezierCurve*)(((Handle_Geom_BezierCurve*)instance)->Access());
 	result->Resolution(			
Tolerance3D,			
*UTolerance);
}
DECL_EXPORT bool Geom_BezierCurve_IsClosed(void* instance)
{
	Geom_BezierCurve* result = (Geom_BezierCurve*)(((Handle_Geom_BezierCurve*)instance)->Access());
	return 	result->IsClosed();
}

DECL_EXPORT bool Geom_BezierCurve_IsPeriodic(void* instance)
{
	Geom_BezierCurve* result = (Geom_BezierCurve*)(((Handle_Geom_BezierCurve*)instance)->Access());
	return 	result->IsPeriodic();
}

DECL_EXPORT bool Geom_BezierCurve_IsRational(void* instance)
{
	Geom_BezierCurve* result = (Geom_BezierCurve*)(((Handle_Geom_BezierCurve*)instance)->Access());
	return 	result->IsRational();
}

DECL_EXPORT int Geom_BezierCurve_Continuity(void* instance)
{
	Geom_BezierCurve* result = (Geom_BezierCurve*)(((Handle_Geom_BezierCurve*)instance)->Access());
	return (int)	result->Continuity();
}

DECL_EXPORT int Geom_BezierCurve_Degree(void* instance)
{
	Geom_BezierCurve* result = (Geom_BezierCurve*)(((Handle_Geom_BezierCurve*)instance)->Access());
	return 	result->Degree();
}

DECL_EXPORT void* Geom_BezierCurve_StartPoint(void* instance)
{
	Geom_BezierCurve* result = (Geom_BezierCurve*)(((Handle_Geom_BezierCurve*)instance)->Access());
	return 	new gp_Pnt(	result->StartPoint());
}

DECL_EXPORT void* Geom_BezierCurve_EndPoint(void* instance)
{
	Geom_BezierCurve* result = (Geom_BezierCurve*)(((Handle_Geom_BezierCurve*)instance)->Access());
	return 	new gp_Pnt(	result->EndPoint());
}

DECL_EXPORT double Geom_BezierCurve_FirstParameter(void* instance)
{
	Geom_BezierCurve* result = (Geom_BezierCurve*)(((Handle_Geom_BezierCurve*)instance)->Access());
	return 	result->FirstParameter();
}

DECL_EXPORT double Geom_BezierCurve_LastParameter(void* instance)
{
	Geom_BezierCurve* result = (Geom_BezierCurve*)(((Handle_Geom_BezierCurve*)instance)->Access());
	return 	result->LastParameter();
}

DECL_EXPORT int Geom_BezierCurve_NbPoles(void* instance)
{
	Geom_BezierCurve* result = (Geom_BezierCurve*)(((Handle_Geom_BezierCurve*)instance)->Access());
	return 	result->NbPoles();
}

DECL_EXPORT int Geom_BezierCurve_MaxDegree()
{
	return Geom_BezierCurve::MaxDegree();
}

DECL_EXPORT void* Geom_BezierCurve_Copy(void* instance)
{
	Geom_BezierCurve* result = (Geom_BezierCurve*)(((Handle_Geom_BezierCurve*)instance)->Access());
	return 	new Handle_Geom_Geometry(	result->Copy());
}

DECL_EXPORT void GeomBezierCurve_Dtor(void* instance)
{
	delete (Handle_Geom_BezierCurve*)instance;
}
