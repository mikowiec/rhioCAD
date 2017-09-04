#include "gpPln.h"
#include <gp_Pln.hxx>

#include <gp_Ax1.hxx>
#include <gp_Ax3.hxx>
#include <gp_Pln.hxx>
#include <gp_Pnt.hxx>

DECL_EXPORT void* gp_Pln_Ctor()
{
	return new gp_Pln();
}
DECL_EXPORT void* gp_Pln_Ctor1B3CAD05(
	void* A3)
{
		const gp_Ax3 &  _A3 =*(const gp_Ax3 *)A3;
	return new gp_Pln(			
_A3);
}
DECL_EXPORT void* gp_Pln_CtorE13B639C(
	void* P,
	void* V)
{
		const gp_Pnt &  _P =*(const gp_Pnt *)P;
		const gp_Dir &  _V =*(const gp_Dir *)V;
	return new gp_Pln(			
_P,			
_V);
}
DECL_EXPORT void* gp_Pln_CtorC2777E0C(
	double A,
	double B,
	double C,
	double D)
{
	return new gp_Pln(			
A,			
B,			
C,			
D);
}
DECL_EXPORT void gp_Pln_CoefficientsC2777E0C(
	void* instance,
	double* A,
	double* B,
	double* C,
	double* D)
{
	gp_Pln* result = (gp_Pln*)instance;
 	result->Coefficients(			
*A,			
*B,			
*C,			
*D);
}
DECL_EXPORT void gp_Pln_UReverse(void* instance)
{
	gp_Pln* result = (gp_Pln*)instance;
 	result->UReverse();
}
DECL_EXPORT void gp_Pln_VReverse(void* instance)
{
	gp_Pln* result = (gp_Pln*)instance;
 	result->VReverse();
}
DECL_EXPORT double gp_Pln_Distance9EAECD5B(
	void* instance,
	void* P)
{
		const gp_Pnt &  _P =*(const gp_Pnt *)P;
	gp_Pln* result = (gp_Pln*)instance;
	return  	result->Distance(			
_P);
}
DECL_EXPORT double gp_Pln_Distance9917D291(
	void* instance,
	void* L)
{
		const gp_Lin &  _L =*(const gp_Lin *)L;
	gp_Pln* result = (gp_Pln*)instance;
	return  	result->Distance(			
_L);
}
DECL_EXPORT double gp_Pln_Distance9914D2AD(
	void* instance,
	void* Other)
{
		const gp_Pln &  _Other =*(const gp_Pln *)Other;
	gp_Pln* result = (gp_Pln*)instance;
	return  	result->Distance(			
_Other);
}
DECL_EXPORT double gp_Pln_SquareDistance9EAECD5B(
	void* instance,
	void* P)
{
		const gp_Pnt &  _P =*(const gp_Pnt *)P;
	gp_Pln* result = (gp_Pln*)instance;
	return  	result->SquareDistance(			
_P);
}
DECL_EXPORT double gp_Pln_SquareDistance9917D291(
	void* instance,
	void* L)
{
		const gp_Lin &  _L =*(const gp_Lin *)L;
	gp_Pln* result = (gp_Pln*)instance;
	return  	result->SquareDistance(			
_L);
}
DECL_EXPORT double gp_Pln_SquareDistance9914D2AD(
	void* instance,
	void* Other)
{
		const gp_Pln &  _Other =*(const gp_Pln *)Other;
	gp_Pln* result = (gp_Pln*)instance;
	return  	result->SquareDistance(			
_Other);
}
DECL_EXPORT bool gp_Pln_ContainsF0D1E3E6(
	void* instance,
	void* P,
	double LinearTolerance)
{
		const gp_Pnt &  _P =*(const gp_Pnt *)P;
	gp_Pln* result = (gp_Pln*)instance;
	return  	result->Contains(			
_P,			
LinearTolerance);
}
DECL_EXPORT bool gp_Pln_Contains13A123E9(
	void* instance,
	void* L,
	double LinearTolerance,
	double AngularTolerance)
{
		const gp_Lin &  _L =*(const gp_Lin *)L;
	gp_Pln* result = (gp_Pln*)instance;
	return  	result->Contains(			
_L,			
LinearTolerance,			
AngularTolerance);
}
DECL_EXPORT void gp_Pln_Mirror9EAECD5B(
	void* instance,
	void* P)
{
		const gp_Pnt &  _P =*(const gp_Pnt *)P;
	gp_Pln* result = (gp_Pln*)instance;
 	result->Mirror(			
_P);
}
DECL_EXPORT void* gp_Pln_Mirrored9EAECD5B(
	void* instance,
	void* P)
{
		const gp_Pnt &  _P =*(const gp_Pnt *)P;
	gp_Pln* result = (gp_Pln*)instance;
	return new gp_Pln( 	result->Mirrored(			
_P));
}
DECL_EXPORT void gp_Pln_Mirror608B963B(
	void* instance,
	void* A1)
{
		const gp_Ax1 &  _A1 =*(const gp_Ax1 *)A1;
	gp_Pln* result = (gp_Pln*)instance;
 	result->Mirror(			
_A1);
}
DECL_EXPORT void* gp_Pln_Mirrored608B963B(
	void* instance,
	void* A1)
{
		const gp_Ax1 &  _A1 =*(const gp_Ax1 *)A1;
	gp_Pln* result = (gp_Pln*)instance;
	return new gp_Pln( 	result->Mirrored(			
_A1));
}
DECL_EXPORT void gp_Pln_Mirror7895386A(
	void* instance,
	void* A2)
{
		const gp_Ax2 &  _A2 =*(const gp_Ax2 *)A2;
	gp_Pln* result = (gp_Pln*)instance;
 	result->Mirror(			
_A2);
}
DECL_EXPORT void* gp_Pln_Mirrored7895386A(
	void* instance,
	void* A2)
{
		const gp_Ax2 &  _A2 =*(const gp_Ax2 *)A2;
	gp_Pln* result = (gp_Pln*)instance;
	return new gp_Pln( 	result->Mirrored(			
_A2));
}
DECL_EXPORT void gp_Pln_Rotate827CB19A(
	void* instance,
	void* A1,
	double Ang)
{
		const gp_Ax1 &  _A1 =*(const gp_Ax1 *)A1;
	gp_Pln* result = (gp_Pln*)instance;
 	result->Rotate(			
_A1,			
Ang);
}
DECL_EXPORT void* gp_Pln_Rotated827CB19A(
	void* instance,
	void* A1,
	double Ang)
{
		const gp_Ax1 &  _A1 =*(const gp_Ax1 *)A1;
	gp_Pln* result = (gp_Pln*)instance;
	return new gp_Pln( 	result->Rotated(			
_A1,			
Ang));
}
DECL_EXPORT void gp_Pln_ScaleF0D1E3E6(
	void* instance,
	void* P,
	double S)
{
		const gp_Pnt &  _P =*(const gp_Pnt *)P;
	gp_Pln* result = (gp_Pln*)instance;
 	result->Scale(			
_P,			
S);
}
DECL_EXPORT void* gp_Pln_ScaledF0D1E3E6(
	void* instance,
	void* P,
	double S)
{
		const gp_Pnt &  _P =*(const gp_Pnt *)P;
	gp_Pln* result = (gp_Pln*)instance;
	return new gp_Pln( 	result->Scaled(			
_P,			
S));
}
DECL_EXPORT void gp_Pln_Transform72D78650(
	void* instance,
	void* T)
{
		const gp_Trsf &  _T =*(const gp_Trsf *)T;
	gp_Pln* result = (gp_Pln*)instance;
 	result->Transform(			
_T);
}
DECL_EXPORT void* gp_Pln_Transformed72D78650(
	void* instance,
	void* T)
{
		const gp_Trsf &  _T =*(const gp_Trsf *)T;
	gp_Pln* result = (gp_Pln*)instance;
	return new gp_Pln( 	result->Transformed(			
_T));
}
DECL_EXPORT void gp_Pln_Translate9BD9CFFE(
	void* instance,
	void* V)
{
		const gp_Vec &  _V =*(const gp_Vec *)V;
	gp_Pln* result = (gp_Pln*)instance;
 	result->Translate(			
_V);
}
DECL_EXPORT void* gp_Pln_Translated9BD9CFFE(
	void* instance,
	void* V)
{
		const gp_Vec &  _V =*(const gp_Vec *)V;
	gp_Pln* result = (gp_Pln*)instance;
	return new gp_Pln( 	result->Translated(			
_V));
}
DECL_EXPORT void gp_Pln_Translate5C63477E(
	void* instance,
	void* P1,
	void* P2)
{
		const gp_Pnt &  _P1 =*(const gp_Pnt *)P1;
		const gp_Pnt &  _P2 =*(const gp_Pnt *)P2;
	gp_Pln* result = (gp_Pln*)instance;
 	result->Translate(			
_P1,			
_P2);
}
DECL_EXPORT void* gp_Pln_Translated5C63477E(
	void* instance,
	void* P1,
	void* P2)
{
		const gp_Pnt &  _P1 =*(const gp_Pnt *)P1;
		const gp_Pnt &  _P2 =*(const gp_Pnt *)P2;
	gp_Pln* result = (gp_Pln*)instance;
	return new gp_Pln( 	result->Translated(			
_P1,			
_P2));
}
DECL_EXPORT bool gp_Pln_Direct(void* instance)
{
	gp_Pln* result = (gp_Pln*)instance;
	return 	result->Direct();
}

DECL_EXPORT void gp_Pln_SetAxis(void* instance, void* value)
{
	gp_Pln* result = (gp_Pln*)instance;
		result->SetAxis(*(const gp_Ax1 *)value);
}

DECL_EXPORT void* gp_Pln_Axis(void* instance)
{
	gp_Pln* result = (gp_Pln*)instance;
	return 	new gp_Ax1(	result->Axis());
}

DECL_EXPORT void gp_Pln_SetLocation(void* instance, void* value)
{
	gp_Pln* result = (gp_Pln*)instance;
		result->SetLocation(*(const gp_Pnt *)value);
}

DECL_EXPORT void* gp_Pln_Location(void* instance)
{
	gp_Pln* result = (gp_Pln*)instance;
	return 	new gp_Pnt(	result->Location());
}

DECL_EXPORT void gp_Pln_SetPosition(void* instance, void* value)
{
	gp_Pln* result = (gp_Pln*)instance;
		result->SetPosition(*(const gp_Ax3 *)value);
}

DECL_EXPORT void* gp_Pln_Position(void* instance)
{
	gp_Pln* result = (gp_Pln*)instance;
	return 	new gp_Ax3(	result->Position());
}

DECL_EXPORT void* gp_Pln_XAxis(void* instance)
{
	gp_Pln* result = (gp_Pln*)instance;
	return 	new gp_Ax1(	result->XAxis());
}

DECL_EXPORT void* gp_Pln_YAxis(void* instance)
{
	gp_Pln* result = (gp_Pln*)instance;
	return 	new gp_Ax1(	result->YAxis());
}

DECL_EXPORT void gpPln_Dtor(void* instance)
{
	delete (gp_Pln*)instance;
}
