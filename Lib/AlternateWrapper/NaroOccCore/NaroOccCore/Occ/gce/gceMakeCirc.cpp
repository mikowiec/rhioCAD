#include "gceMakeCirc.h"
#include <gce_MakeCirc.hxx>

#include <gp_Circ.hxx>

DECL_EXPORT void* gce_MakeCirc_Ctor673FA07D(
	void* A2,
	double Radius)
{
		const gp_Ax2 &  _A2 =*(const gp_Ax2 *)A2;
	return new gce_MakeCirc(			
_A2,			
Radius);
}
DECL_EXPORT void* gce_MakeCirc_Ctor941DBF06(
	void* Circ,
	double Dist)
{
		const gp_Circ &  _Circ =*(const gp_Circ *)Circ;
	return new gce_MakeCirc(			
_Circ,			
Dist);
}
DECL_EXPORT void* gce_MakeCirc_Ctor89B70D29(
	void* Circ,
	void* Point)
{
		const gp_Circ &  _Circ =*(const gp_Circ *)Circ;
		const gp_Pnt &  _Point =*(const gp_Pnt *)Point;
	return new gce_MakeCirc(			
_Circ,			
_Point);
}
DECL_EXPORT void* gce_MakeCirc_Ctor4B855FC1(
	void* P1,
	void* P2,
	void* P3)
{
		const gp_Pnt &  _P1 =*(const gp_Pnt *)P1;
		const gp_Pnt &  _P2 =*(const gp_Pnt *)P2;
		const gp_Pnt &  _P3 =*(const gp_Pnt *)P3;
	return new gce_MakeCirc(			
_P1,			
_P2,			
_P3);
}
DECL_EXPORT void* gce_MakeCirc_Ctor9327D37B(
	void* Center,
	void* Norm,
	double Radius)
{
		const gp_Pnt &  _Center =*(const gp_Pnt *)Center;
		const gp_Dir &  _Norm =*(const gp_Dir *)Norm;
	return new gce_MakeCirc(			
_Center,			
_Norm,			
Radius);
}
DECL_EXPORT void* gce_MakeCirc_CtorE73602A3(
	void* Center,
	void* Plane,
	double Radius)
{
		const gp_Pnt &  _Center =*(const gp_Pnt *)Center;
		const gp_Pln &  _Plane =*(const gp_Pln *)Plane;
	return new gce_MakeCirc(			
_Center,			
_Plane,			
Radius);
}
DECL_EXPORT void* gce_MakeCirc_CtorB8940259(
	void* Center,
	void* Ptaxis,
	double Radius)
{
		const gp_Pnt &  _Center =*(const gp_Pnt *)Center;
		const gp_Pnt &  _Ptaxis =*(const gp_Pnt *)Ptaxis;
	return new gce_MakeCirc(			
_Center,			
_Ptaxis,			
Radius);
}
DECL_EXPORT void* gce_MakeCirc_Ctor827CB19A(
	void* Axis,
	double Radius)
{
		const gp_Ax1 &  _Axis =*(const gp_Ax1 *)Axis;
	return new gce_MakeCirc(			
_Axis,			
Radius);
}
DECL_EXPORT void* gce_MakeCirc_Value(void* instance)
{
	gce_MakeCirc* result = (gce_MakeCirc*)instance;
	return 	new gp_Circ(	result->Value());
}

DECL_EXPORT void* gce_MakeCirc_Operator(void* instance)
{
	gce_MakeCirc* result = (gce_MakeCirc*)instance;
	return 	new gp_Circ(	result->Operator());
}

DECL_EXPORT void gceMakeCirc_Dtor(void* instance)
{
	delete (gce_MakeCirc*)instance;
}
