#include "gpHypr.h"
#include <gp_Hypr.hxx>

#include <gp_Ax1.hxx>
#include <gp_Ax2.hxx>
#include <gp_Hypr.hxx>
#include <gp_Pnt.hxx>

DECL_EXPORT void* gp_Hypr_Ctor()
{
	return new gp_Hypr();
}
DECL_EXPORT void* gp_Hypr_CtorB1A3BD2A(
	void* A2,
	double MajorRadius,
	double MinorRadius)
{
		const gp_Ax2 &  _A2 =*(const gp_Ax2 *)A2;
	return new gp_Hypr(			
_A2,			
MajorRadius,			
MinorRadius);
}
DECL_EXPORT void gp_Hypr_Mirror9EAECD5B(
	void* instance,
	void* P)
{
		const gp_Pnt &  _P =*(const gp_Pnt *)P;
	gp_Hypr* result = (gp_Hypr*)instance;
 	result->Mirror(			
_P);
}
DECL_EXPORT void* gp_Hypr_Mirrored9EAECD5B(
	void* instance,
	void* P)
{
		const gp_Pnt &  _P =*(const gp_Pnt *)P;
	gp_Hypr* result = (gp_Hypr*)instance;
	return new gp_Hypr( 	result->Mirrored(			
_P));
}
DECL_EXPORT void gp_Hypr_Mirror608B963B(
	void* instance,
	void* A1)
{
		const gp_Ax1 &  _A1 =*(const gp_Ax1 *)A1;
	gp_Hypr* result = (gp_Hypr*)instance;
 	result->Mirror(			
_A1);
}
DECL_EXPORT void* gp_Hypr_Mirrored608B963B(
	void* instance,
	void* A1)
{
		const gp_Ax1 &  _A1 =*(const gp_Ax1 *)A1;
	gp_Hypr* result = (gp_Hypr*)instance;
	return new gp_Hypr( 	result->Mirrored(			
_A1));
}
DECL_EXPORT void gp_Hypr_Mirror7895386A(
	void* instance,
	void* A2)
{
		const gp_Ax2 &  _A2 =*(const gp_Ax2 *)A2;
	gp_Hypr* result = (gp_Hypr*)instance;
 	result->Mirror(			
_A2);
}
DECL_EXPORT void* gp_Hypr_Mirrored7895386A(
	void* instance,
	void* A2)
{
		const gp_Ax2 &  _A2 =*(const gp_Ax2 *)A2;
	gp_Hypr* result = (gp_Hypr*)instance;
	return new gp_Hypr( 	result->Mirrored(			
_A2));
}
DECL_EXPORT void gp_Hypr_Rotate827CB19A(
	void* instance,
	void* A1,
	double Ang)
{
		const gp_Ax1 &  _A1 =*(const gp_Ax1 *)A1;
	gp_Hypr* result = (gp_Hypr*)instance;
 	result->Rotate(			
_A1,			
Ang);
}
DECL_EXPORT void* gp_Hypr_Rotated827CB19A(
	void* instance,
	void* A1,
	double Ang)
{
		const gp_Ax1 &  _A1 =*(const gp_Ax1 *)A1;
	gp_Hypr* result = (gp_Hypr*)instance;
	return new gp_Hypr( 	result->Rotated(			
_A1,			
Ang));
}
DECL_EXPORT void gp_Hypr_ScaleF0D1E3E6(
	void* instance,
	void* P,
	double S)
{
		const gp_Pnt &  _P =*(const gp_Pnt *)P;
	gp_Hypr* result = (gp_Hypr*)instance;
 	result->Scale(			
_P,			
S);
}
DECL_EXPORT void* gp_Hypr_ScaledF0D1E3E6(
	void* instance,
	void* P,
	double S)
{
		const gp_Pnt &  _P =*(const gp_Pnt *)P;
	gp_Hypr* result = (gp_Hypr*)instance;
	return new gp_Hypr( 	result->Scaled(			
_P,			
S));
}
DECL_EXPORT void gp_Hypr_Transform72D78650(
	void* instance,
	void* T)
{
		const gp_Trsf &  _T =*(const gp_Trsf *)T;
	gp_Hypr* result = (gp_Hypr*)instance;
 	result->Transform(			
_T);
}
DECL_EXPORT void* gp_Hypr_Transformed72D78650(
	void* instance,
	void* T)
{
		const gp_Trsf &  _T =*(const gp_Trsf *)T;
	gp_Hypr* result = (gp_Hypr*)instance;
	return new gp_Hypr( 	result->Transformed(			
_T));
}
DECL_EXPORT void gp_Hypr_Translate9BD9CFFE(
	void* instance,
	void* V)
{
		const gp_Vec &  _V =*(const gp_Vec *)V;
	gp_Hypr* result = (gp_Hypr*)instance;
 	result->Translate(			
_V);
}
DECL_EXPORT void* gp_Hypr_Translated9BD9CFFE(
	void* instance,
	void* V)
{
		const gp_Vec &  _V =*(const gp_Vec *)V;
	gp_Hypr* result = (gp_Hypr*)instance;
	return new gp_Hypr( 	result->Translated(			
_V));
}
DECL_EXPORT void gp_Hypr_Translate5C63477E(
	void* instance,
	void* P1,
	void* P2)
{
		const gp_Pnt &  _P1 =*(const gp_Pnt *)P1;
		const gp_Pnt &  _P2 =*(const gp_Pnt *)P2;
	gp_Hypr* result = (gp_Hypr*)instance;
 	result->Translate(			
_P1,			
_P2);
}
DECL_EXPORT void* gp_Hypr_Translated5C63477E(
	void* instance,
	void* P1,
	void* P2)
{
		const gp_Pnt &  _P1 =*(const gp_Pnt *)P1;
		const gp_Pnt &  _P2 =*(const gp_Pnt *)P2;
	gp_Hypr* result = (gp_Hypr*)instance;
	return new gp_Hypr( 	result->Translated(			
_P1,			
_P2));
}
DECL_EXPORT void* gp_Hypr_Asymptote1(void* instance)
{
	gp_Hypr* result = (gp_Hypr*)instance;
	return 	new gp_Ax1(	result->Asymptote1());
}

DECL_EXPORT void* gp_Hypr_Asymptote2(void* instance)
{
	gp_Hypr* result = (gp_Hypr*)instance;
	return 	new gp_Ax1(	result->Asymptote2());
}

DECL_EXPORT void gp_Hypr_SetAxis(void* instance, void* value)
{
	gp_Hypr* result = (gp_Hypr*)instance;
		result->SetAxis(*(const gp_Ax1 *)value);
}

DECL_EXPORT void* gp_Hypr_Axis(void* instance)
{
	gp_Hypr* result = (gp_Hypr*)instance;
	return 	new gp_Ax1(	result->Axis());
}

DECL_EXPORT void* gp_Hypr_ConjugateBranch1(void* instance)
{
	gp_Hypr* result = (gp_Hypr*)instance;
	return 	new gp_Hypr(	result->ConjugateBranch1());
}

DECL_EXPORT void* gp_Hypr_ConjugateBranch2(void* instance)
{
	gp_Hypr* result = (gp_Hypr*)instance;
	return 	new gp_Hypr(	result->ConjugateBranch2());
}

DECL_EXPORT void* gp_Hypr_Directrix1(void* instance)
{
	gp_Hypr* result = (gp_Hypr*)instance;
	return 	new gp_Ax1(	result->Directrix1());
}

DECL_EXPORT void* gp_Hypr_Directrix2(void* instance)
{
	gp_Hypr* result = (gp_Hypr*)instance;
	return 	new gp_Ax1(	result->Directrix2());
}

DECL_EXPORT double gp_Hypr_Eccentricity(void* instance)
{
	gp_Hypr* result = (gp_Hypr*)instance;
	return 	result->Eccentricity();
}

DECL_EXPORT double gp_Hypr_Focal(void* instance)
{
	gp_Hypr* result = (gp_Hypr*)instance;
	return 	result->Focal();
}

DECL_EXPORT void* gp_Hypr_Focus1(void* instance)
{
	gp_Hypr* result = (gp_Hypr*)instance;
	return 	new gp_Pnt(	result->Focus1());
}

DECL_EXPORT void* gp_Hypr_Focus2(void* instance)
{
	gp_Hypr* result = (gp_Hypr*)instance;
	return 	new gp_Pnt(	result->Focus2());
}

DECL_EXPORT void gp_Hypr_SetLocation(void* instance, void* value)
{
	gp_Hypr* result = (gp_Hypr*)instance;
		result->SetLocation(*(const gp_Pnt *)value);
}

DECL_EXPORT void* gp_Hypr_Location(void* instance)
{
	gp_Hypr* result = (gp_Hypr*)instance;
	return 	new gp_Pnt(	result->Location());
}

DECL_EXPORT void gp_Hypr_SetMajorRadius(void* instance, double value)
{
	gp_Hypr* result = (gp_Hypr*)instance;
		result->SetMajorRadius(value);
}

DECL_EXPORT double gp_Hypr_MajorRadius(void* instance)
{
	gp_Hypr* result = (gp_Hypr*)instance;
	return 	result->MajorRadius();
}

DECL_EXPORT void gp_Hypr_SetMinorRadius(void* instance, double value)
{
	gp_Hypr* result = (gp_Hypr*)instance;
		result->SetMinorRadius(value);
}

DECL_EXPORT double gp_Hypr_MinorRadius(void* instance)
{
	gp_Hypr* result = (gp_Hypr*)instance;
	return 	result->MinorRadius();
}

DECL_EXPORT void* gp_Hypr_OtherBranch(void* instance)
{
	gp_Hypr* result = (gp_Hypr*)instance;
	return 	new gp_Hypr(	result->OtherBranch());
}

DECL_EXPORT double gp_Hypr_Parameter(void* instance)
{
	gp_Hypr* result = (gp_Hypr*)instance;
	return 	result->Parameter();
}

DECL_EXPORT void gp_Hypr_SetPosition(void* instance, void* value)
{
	gp_Hypr* result = (gp_Hypr*)instance;
		result->SetPosition(*(const gp_Ax2 *)value);
}

DECL_EXPORT void* gp_Hypr_Position(void* instance)
{
	gp_Hypr* result = (gp_Hypr*)instance;
	return 	new gp_Ax2(	result->Position());
}

DECL_EXPORT void* gp_Hypr_XAxis(void* instance)
{
	gp_Hypr* result = (gp_Hypr*)instance;
	return 	new gp_Ax1(	result->XAxis());
}

DECL_EXPORT void* gp_Hypr_YAxis(void* instance)
{
	gp_Hypr* result = (gp_Hypr*)instance;
	return 	new gp_Ax1(	result->YAxis());
}

DECL_EXPORT void gpHypr_Dtor(void* instance)
{
	delete (gp_Hypr*)instance;
}
