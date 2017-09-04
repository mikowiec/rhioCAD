#include "gceMakeLin.h"
#include <gce_MakeLin.hxx>

#include <gp_Lin.hxx>

DECL_EXPORT void* gce_MakeLin_Ctor608B963B(
	void* A1)
{
		const gp_Ax1 &  _A1 =*(const gp_Ax1 *)A1;
	return new gce_MakeLin(			
_A1);
}
DECL_EXPORT void* gce_MakeLin_CtorE13B639C(
	void* P,
	void* V)
{
		const gp_Pnt &  _P =*(const gp_Pnt *)P;
		const gp_Dir &  _V =*(const gp_Dir *)V;
	return new gce_MakeLin(			
_P,			
_V);
}
DECL_EXPORT void* gce_MakeLin_Ctor1CB0FB3C(
	void* Lin,
	void* Point)
{
		const gp_Lin &  _Lin =*(const gp_Lin *)Lin;
		const gp_Pnt &  _Point =*(const gp_Pnt *)Point;
	return new gce_MakeLin(			
_Lin,			
_Point);
}
DECL_EXPORT void* gce_MakeLin_Ctor5C63477E(
	void* P1,
	void* P2)
{
		const gp_Pnt &  _P1 =*(const gp_Pnt *)P1;
		const gp_Pnt &  _P2 =*(const gp_Pnt *)P2;
	return new gce_MakeLin(			
_P1,			
_P2);
}
DECL_EXPORT void* gce_MakeLin_Value(void* instance)
{
	gce_MakeLin* result = (gce_MakeLin*)instance;
	return 	new gp_Lin(	result->Value());
}

DECL_EXPORT void* gce_MakeLin_Operator(void* instance)
{
	gce_MakeLin* result = (gce_MakeLin*)instance;
	return 	new gp_Lin(	result->Operator());
}

DECL_EXPORT void gceMakeLin_Dtor(void* instance)
{
	delete (gce_MakeLin*)instance;
}
