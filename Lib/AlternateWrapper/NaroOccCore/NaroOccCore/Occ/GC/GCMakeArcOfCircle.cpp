#include "GCMakeArcOfCircle.h"
#include <GC_MakeArcOfCircle.hxx>

#include <Geom_TrimmedCurve.hxx>

DECL_EXPORT void* GC_MakeArcOfCircle_CtorB4ED9646(
	void* Circ,
	double Alpha1,
	double Alpha2,
	bool Sense)
{
		const gp_Circ &  _Circ =*(const gp_Circ *)Circ;
	return new GC_MakeArcOfCircle(			
_Circ,			
Alpha1,			
Alpha2,			
Sense);
}
DECL_EXPORT void* GC_MakeArcOfCircle_CtorF0177DDE(
	void* Circ,
	void* P,
	double Alpha,
	bool Sense)
{
		const gp_Circ &  _Circ =*(const gp_Circ *)Circ;
		const gp_Pnt &  _P =*(const gp_Pnt *)P;
	return new GC_MakeArcOfCircle(			
_Circ,			
_P,			
Alpha,			
Sense);
}
DECL_EXPORT void* GC_MakeArcOfCircle_CtorFA26BC9F(
	void* Circ,
	void* P1,
	void* P2,
	bool Sense)
{
		const gp_Circ &  _Circ =*(const gp_Circ *)Circ;
		const gp_Pnt &  _P1 =*(const gp_Pnt *)P1;
		const gp_Pnt &  _P2 =*(const gp_Pnt *)P2;
	return new GC_MakeArcOfCircle(			
_Circ,			
_P1,			
_P2,			
Sense);
}
DECL_EXPORT void* GC_MakeArcOfCircle_Ctor4B855FC1(
	void* P1,
	void* P2,
	void* P3)
{
		const gp_Pnt &  _P1 =*(const gp_Pnt *)P1;
		const gp_Pnt &  _P2 =*(const gp_Pnt *)P2;
		const gp_Pnt &  _P3 =*(const gp_Pnt *)P3;
	return new GC_MakeArcOfCircle(			
_P1,			
_P2,			
_P3);
}
DECL_EXPORT void* GC_MakeArcOfCircle_Ctor5450E69C(
	void* P1,
	void* V,
	void* P2)
{
		const gp_Pnt &  _P1 =*(const gp_Pnt *)P1;
		const gp_Vec &  _V =*(const gp_Vec *)V;
		const gp_Pnt &  _P2 =*(const gp_Pnt *)P2;
	return new GC_MakeArcOfCircle(			
_P1,			
_V,			
_P2);
}
DECL_EXPORT void* GC_MakeArcOfCircle_Value(void* instance)
{
	GC_MakeArcOfCircle* result = (GC_MakeArcOfCircle*)instance;
	return 	new Handle_Geom_TrimmedCurve(	result->Value());
}

DECL_EXPORT void* GC_MakeArcOfCircle_Operator(void* instance)
{
	GC_MakeArcOfCircle* result = (GC_MakeArcOfCircle*)instance;
	return 	new Handle_Geom_TrimmedCurve(	result->Operator());
}

DECL_EXPORT void GCMakeArcOfCircle_Dtor(void* instance)
{
	delete (GC_MakeArcOfCircle*)instance;
}
