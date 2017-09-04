#include "gpTrsf2d.h"
#include <gp_Trsf2d.hxx>

#include <gp_Mat2d.hxx>
#include <gp_Trsf2d.hxx>
#include <gp_Vec2d.hxx>

DECL_EXPORT void* gp_Trsf2d_Ctor()
{
	return new gp_Trsf2d();
}
DECL_EXPORT void* gp_Trsf2d_Ctor72D78650(
	void* T)
{
		const gp_Trsf &  _T =*(const gp_Trsf *)T;
	return new gp_Trsf2d(			
_T);
}
DECL_EXPORT void gp_Trsf2d_SetMirror6203658C(
	void* instance,
	void* P)
{
		const gp_Pnt2d &  _P =*(const gp_Pnt2d *)P;
	gp_Trsf2d* result = (gp_Trsf2d*)instance;
 	result->SetMirror(			
_P);
}
DECL_EXPORT void gp_Trsf2d_SetMirror90E1386A(
	void* instance,
	void* A)
{
		const gp_Ax2d &  _A =*(const gp_Ax2d *)A;
	gp_Trsf2d* result = (gp_Trsf2d*)instance;
 	result->SetMirror(			
_A);
}
DECL_EXPORT void gp_Trsf2d_SetRotationE3062737(
	void* instance,
	void* P,
	double Ang)
{
		const gp_Pnt2d &  _P =*(const gp_Pnt2d *)P;
	gp_Trsf2d* result = (gp_Trsf2d*)instance;
 	result->SetRotation(			
_P,			
Ang);
}
DECL_EXPORT void gp_Trsf2d_SetScaleE3062737(
	void* instance,
	void* P,
	double S)
{
		const gp_Pnt2d &  _P =*(const gp_Pnt2d *)P;
	gp_Trsf2d* result = (gp_Trsf2d*)instance;
 	result->SetScale(			
_P,			
S);
}
DECL_EXPORT void gp_Trsf2d_SetTransformation1A99B821(
	void* instance,
	void* FromSystem1,
	void* ToSystem2)
{
		const gp_Ax2d &  _FromSystem1 =*(const gp_Ax2d *)FromSystem1;
		const gp_Ax2d &  _ToSystem2 =*(const gp_Ax2d *)ToSystem2;
	gp_Trsf2d* result = (gp_Trsf2d*)instance;
 	result->SetTransformation(			
_FromSystem1,			
_ToSystem2);
}
DECL_EXPORT void gp_Trsf2d_SetTransformation90E1386A(
	void* instance,
	void* ToSystem)
{
		const gp_Ax2d &  _ToSystem =*(const gp_Ax2d *)ToSystem;
	gp_Trsf2d* result = (gp_Trsf2d*)instance;
 	result->SetTransformation(			
_ToSystem);
}
DECL_EXPORT void gp_Trsf2d_SetTranslation5E4E66E7(
	void* instance,
	void* V)
{
		const gp_Vec2d &  _V =*(const gp_Vec2d *)V;
	gp_Trsf2d* result = (gp_Trsf2d*)instance;
 	result->SetTranslation(			
_V);
}
DECL_EXPORT void gp_Trsf2d_SetTranslation5F54ADE3(
	void* instance,
	void* P1,
	void* P2)
{
		const gp_Pnt2d &  _P1 =*(const gp_Pnt2d *)P1;
		const gp_Pnt2d &  _P2 =*(const gp_Pnt2d *)P2;
	gp_Trsf2d* result = (gp_Trsf2d*)instance;
 	result->SetTranslation(			
_P1,			
_P2);
}
DECL_EXPORT double gp_Trsf2d_Value5107F6FE(
	void* instance,
	int Row,
	int Col)
{
	gp_Trsf2d* result = (gp_Trsf2d*)instance;
	return  	result->Value(			
Row,			
Col);
}
DECL_EXPORT void gp_Trsf2d_Invert(void* instance)
{
	gp_Trsf2d* result = (gp_Trsf2d*)instance;
 	result->Invert();
}
DECL_EXPORT void* gp_Trsf2d_Multiplied27621DCB(
	void* instance,
	void* T)
{
		const gp_Trsf2d &  _T =*(const gp_Trsf2d *)T;
	gp_Trsf2d* result = (gp_Trsf2d*)instance;
	return new gp_Trsf2d( 	result->Multiplied(			
_T));
}
DECL_EXPORT void gp_Trsf2d_Multiply27621DCB(
	void* instance,
	void* T)
{
		const gp_Trsf2d &  _T =*(const gp_Trsf2d *)T;
	gp_Trsf2d* result = (gp_Trsf2d*)instance;
 	result->Multiply(			
_T);
}
DECL_EXPORT void gp_Trsf2d_PreMultiply27621DCB(
	void* instance,
	void* T)
{
		const gp_Trsf2d &  _T =*(const gp_Trsf2d *)T;
	gp_Trsf2d* result = (gp_Trsf2d*)instance;
 	result->PreMultiply(			
_T);
}
DECL_EXPORT void gp_Trsf2d_PowerE8219145(
	void* instance,
	int N)
{
	gp_Trsf2d* result = (gp_Trsf2d*)instance;
 	result->Power(			
N);
}
DECL_EXPORT void* gp_Trsf2d_PoweredE8219145(
	void* instance,
	int N)
{
	gp_Trsf2d* result = (gp_Trsf2d*)instance;
	return new gp_Trsf2d( 	result->Powered(			
N));
}
DECL_EXPORT void gp_Trsf2d_Transforms9F0E714F(
	void* instance,
	double* X,
	double* Y)
{
	gp_Trsf2d* result = (gp_Trsf2d*)instance;
 	result->Transforms(			
*X,			
*Y);
}
DECL_EXPORT void gp_Trsf2d_TransformsE051EF89(
	void* instance,
	void* Coord)
{
		 gp_XY &  _Coord =*( gp_XY *)Coord;
	gp_Trsf2d* result = (gp_Trsf2d*)instance;
 	result->Transforms(			
_Coord);
}
DECL_EXPORT bool gp_Trsf2d_IsNegative(void* instance)
{
	gp_Trsf2d* result = (gp_Trsf2d*)instance;
	return 	result->IsNegative();
}

DECL_EXPORT int gp_Trsf2d_Form(void* instance)
{
	gp_Trsf2d* result = (gp_Trsf2d*)instance;
	return (int)	result->Form();
}

DECL_EXPORT void gp_Trsf2d_SetScaleFactor(void* instance, double value)
{
	gp_Trsf2d* result = (gp_Trsf2d*)instance;
		result->SetScaleFactor(value);
}

DECL_EXPORT double gp_Trsf2d_ScaleFactor(void* instance)
{
	gp_Trsf2d* result = (gp_Trsf2d*)instance;
	return 	result->ScaleFactor();
}

DECL_EXPORT void gp_Trsf2d_SetTranslationPart(void* instance, void* value)
{
	gp_Trsf2d* result = (gp_Trsf2d*)instance;
		result->SetTranslationPart(*(const gp_Vec2d *)value);
}

DECL_EXPORT void* gp_Trsf2d_TranslationPart(void* instance)
{
	gp_Trsf2d* result = (gp_Trsf2d*)instance;
	return 	new gp_Vec2d(	result->TranslationPart());
}

DECL_EXPORT void* gp_Trsf2d_VectorialPart(void* instance)
{
	gp_Trsf2d* result = (gp_Trsf2d*)instance;
	return 	new gp_Mat2d(	result->VectorialPart());
}

DECL_EXPORT void* gp_Trsf2d_HVectorialPart(void* instance)
{
	gp_Trsf2d* result = (gp_Trsf2d*)instance;
	return 	new gp_Mat2d(	result->HVectorialPart());
}

DECL_EXPORT double gp_Trsf2d_RotationPart(void* instance)
{
	gp_Trsf2d* result = (gp_Trsf2d*)instance;
	return 	result->RotationPart();
}

DECL_EXPORT void* gp_Trsf2d_Inverted(void* instance)
{
	gp_Trsf2d* result = (gp_Trsf2d*)instance;
	return 	new gp_Trsf2d(	result->Inverted());
}

DECL_EXPORT void gpTrsf2d_Dtor(void* instance)
{
	delete (gp_Trsf2d*)instance;
}
