#include "GCMakePlane.h"
#include <GC_MakePlane.hxx>

#include <Geom_Plane.hxx>

DECL_EXPORT void* GC_MakePlane_Ctor7895386A(
	void* A2)
{
		const gp_Ax2 &  _A2 =*(const gp_Ax2 *)A2;
	return new GC_MakePlane(			
_A2);
}
DECL_EXPORT void* GC_MakePlane_Ctor9914D2AD(
	void* Pl)
{
		const gp_Pln &  _Pl =*(const gp_Pln *)Pl;
	return new GC_MakePlane(			
_Pl);
}
DECL_EXPORT void* GC_MakePlane_CtorE13B639C(
	void* P,
	void* V)
{
		const gp_Pnt &  _P =*(const gp_Pnt *)P;
		const gp_Dir &  _V =*(const gp_Dir *)V;
	return new GC_MakePlane(			
_P,			
_V);
}
DECL_EXPORT void* GC_MakePlane_CtorC2777E0C(
	double A,
	double B,
	double C,
	double D)
{
	return new GC_MakePlane(			
A,			
B,			
C,			
D);
}
DECL_EXPORT void* GC_MakePlane_Ctor10B48A70(
	void* Pln,
	void* Point)
{
		const gp_Pln &  _Pln =*(const gp_Pln *)Pln;
		const gp_Pnt &  _Point =*(const gp_Pnt *)Point;
	return new GC_MakePlane(			
_Pln,			
_Point);
}
DECL_EXPORT void* GC_MakePlane_Ctor6FF7E7CC(
	void* Pln,
	double Dist)
{
		const gp_Pln &  _Pln =*(const gp_Pln *)Pln;
	return new GC_MakePlane(			
_Pln,			
Dist);
}
DECL_EXPORT void* GC_MakePlane_Ctor4B855FC1(
	void* P1,
	void* P2,
	void* P3)
{
		const gp_Pnt &  _P1 =*(const gp_Pnt *)P1;
		const gp_Pnt &  _P2 =*(const gp_Pnt *)P2;
		const gp_Pnt &  _P3 =*(const gp_Pnt *)P3;
	return new GC_MakePlane(			
_P1,			
_P2,			
_P3);
}
DECL_EXPORT void* GC_MakePlane_Ctor608B963B(
	void* Axis)
{
		const gp_Ax1 &  _Axis =*(const gp_Ax1 *)Axis;
	return new GC_MakePlane(			
_Axis);
}
DECL_EXPORT void* GC_MakePlane_Value(void* instance)
{
	GC_MakePlane* result = (GC_MakePlane*)instance;
	return 	new Handle_Geom_Plane(	result->Value());
}

DECL_EXPORT void* GC_MakePlane_Operator(void* instance)
{
	GC_MakePlane* result = (GC_MakePlane*)instance;
	return 	new Handle_Geom_Plane(	result->Operator());
}

DECL_EXPORT void GCMakePlane_Dtor(void* instance)
{
	delete (GC_MakePlane*)instance;
}
