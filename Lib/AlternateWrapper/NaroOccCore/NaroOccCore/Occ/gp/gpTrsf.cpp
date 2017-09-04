#include "gpTrsf.h"
#include <gp_Trsf.hxx>

#include <gp_Mat.hxx>
#include <gp_Trsf.hxx>
#include <gp_Vec.hxx>

DECL_EXPORT void* gp_Trsf_Ctor()
{
	return new gp_Trsf();
}
DECL_EXPORT void* gp_Trsf_Ctor27621DCB(
	void* T)
{
		const gp_Trsf2d &  _T =*(const gp_Trsf2d *)T;
	return new gp_Trsf(			
_T);
}
DECL_EXPORT void gp_Trsf_SetMirror9EAECD5B(
	void* instance,
	void* P)
{
		const gp_Pnt &  _P =*(const gp_Pnt *)P;
	gp_Trsf* result = (gp_Trsf*)instance;
 	result->SetMirror(			
_P);
}
DECL_EXPORT void gp_Trsf_SetMirror608B963B(
	void* instance,
	void* A1)
{
		const gp_Ax1 &  _A1 =*(const gp_Ax1 *)A1;
	gp_Trsf* result = (gp_Trsf*)instance;
 	result->SetMirror(			
_A1);
}
DECL_EXPORT void gp_Trsf_SetMirror7895386A(
	void* instance,
	void* A2)
{
		const gp_Ax2 &  _A2 =*(const gp_Ax2 *)A2;
	gp_Trsf* result = (gp_Trsf*)instance;
 	result->SetMirror(			
_A2);
}
DECL_EXPORT void gp_Trsf_SetRotation827CB19A(
	void* instance,
	void* A1,
	double Ang)
{
		const gp_Ax1 &  _A1 =*(const gp_Ax1 *)A1;
	gp_Trsf* result = (gp_Trsf*)instance;
 	result->SetRotation(			
_A1,			
Ang);
}
DECL_EXPORT void gp_Trsf_SetScaleF0D1E3E6(
	void* instance,
	void* P,
	double S)
{
		const gp_Pnt &  _P =*(const gp_Pnt *)P;
	gp_Trsf* result = (gp_Trsf*)instance;
 	result->SetScale(			
_P,			
S);
}
DECL_EXPORT void gp_Trsf_SetDisplacementB5D8FD04(
	void* instance,
	void* FromSystem1,
	void* ToSystem2)
{
		const gp_Ax3 &  _FromSystem1 =*(const gp_Ax3 *)FromSystem1;
		const gp_Ax3 &  _ToSystem2 =*(const gp_Ax3 *)ToSystem2;
	gp_Trsf* result = (gp_Trsf*)instance;
 	result->SetDisplacement(			
_FromSystem1,			
_ToSystem2);
}
DECL_EXPORT void gp_Trsf_SetTransformationB5D8FD04(
	void* instance,
	void* FromSystem1,
	void* ToSystem2)
{
		const gp_Ax3 &  _FromSystem1 =*(const gp_Ax3 *)FromSystem1;
		const gp_Ax3 &  _ToSystem2 =*(const gp_Ax3 *)ToSystem2;
	gp_Trsf* result = (gp_Trsf*)instance;
 	result->SetTransformation(			
_FromSystem1,			
_ToSystem2);
}
DECL_EXPORT void gp_Trsf_SetTransformation1B3CAD05(
	void* instance,
	void* ToSystem)
{
		const gp_Ax3 &  _ToSystem =*(const gp_Ax3 *)ToSystem;
	gp_Trsf* result = (gp_Trsf*)instance;
 	result->SetTransformation(			
_ToSystem);
}
DECL_EXPORT void gp_Trsf_SetTranslation9BD9CFFE(
	void* instance,
	void* V)
{
		const gp_Vec &  _V =*(const gp_Vec *)V;
	gp_Trsf* result = (gp_Trsf*)instance;
 	result->SetTranslation(			
_V);
}
DECL_EXPORT void gp_Trsf_SetTranslation5C63477E(
	void* instance,
	void* P1,
	void* P2)
{
		const gp_Pnt &  _P1 =*(const gp_Pnt *)P1;
		const gp_Pnt &  _P2 =*(const gp_Pnt *)P2;
	gp_Trsf* result = (gp_Trsf*)instance;
 	result->SetTranslation(			
_P1,			
_P2);
}
DECL_EXPORT void gp_Trsf_SetValues4D4A9FE3(
	void* instance,
	double a11,
	double a12,
	double a13,
	double a14,
	double a21,
	double a22,
	double a23,
	double a24,
	double a31,
	double a32,
	double a33,
	double a34,
	double Tolang,
	double TolDist)
{
	gp_Trsf* result = (gp_Trsf*)instance;
 	result->SetValues(			
a11,			
a12,			
a13,			
a14,			
a21,			
a22,			
a23,			
a24,			
a31,			
a32,			
a33,			
a34,			
Tolang,			
TolDist);
}
DECL_EXPORT bool gp_Trsf_GetRotationAC21764D(
	void* instance,
	void* theAxis,
	double* theAngle)
{
		 gp_XYZ &  _theAxis =*( gp_XYZ *)theAxis;
	gp_Trsf* result = (gp_Trsf*)instance;
	return  	result->GetRotation(			
_theAxis,			
*theAngle);
}
DECL_EXPORT double gp_Trsf_Value5107F6FE(
	void* instance,
	int Row,
	int Col)
{
	gp_Trsf* result = (gp_Trsf*)instance;
	return  	result->Value(			
Row,			
Col);
}
DECL_EXPORT void gp_Trsf_Invert(void* instance)
{
	gp_Trsf* result = (gp_Trsf*)instance;
 	result->Invert();
}
DECL_EXPORT void* gp_Trsf_Multiplied72D78650(
	void* instance,
	void* T)
{
		const gp_Trsf &  _T =*(const gp_Trsf *)T;
	gp_Trsf* result = (gp_Trsf*)instance;
	return new gp_Trsf( 	result->Multiplied(			
_T));
}
DECL_EXPORT void gp_Trsf_Multiply72D78650(
	void* instance,
	void* T)
{
		const gp_Trsf &  _T =*(const gp_Trsf *)T;
	gp_Trsf* result = (gp_Trsf*)instance;
 	result->Multiply(			
_T);
}
DECL_EXPORT void gp_Trsf_PreMultiply72D78650(
	void* instance,
	void* T)
{
		const gp_Trsf &  _T =*(const gp_Trsf *)T;
	gp_Trsf* result = (gp_Trsf*)instance;
 	result->PreMultiply(			
_T);
}
DECL_EXPORT void gp_Trsf_PowerE8219145(
	void* instance,
	int N)
{
	gp_Trsf* result = (gp_Trsf*)instance;
 	result->Power(			
N);
}
DECL_EXPORT void* gp_Trsf_PoweredE8219145(
	void* instance,
	int N)
{
	gp_Trsf* result = (gp_Trsf*)instance;
	return new gp_Trsf( 	result->Powered(			
N));
}
DECL_EXPORT void gp_Trsf_Transforms9282A951(
	void* instance,
	double* X,
	double* Y,
	double* Z)
{
	gp_Trsf* result = (gp_Trsf*)instance;
 	result->Transforms(			
*X,			
*Y,			
*Z);
}
DECL_EXPORT void gp_Trsf_Transforms8EE42329(
	void* instance,
	void* Coord)
{
		 gp_XYZ &  _Coord =*( gp_XYZ *)Coord;
	gp_Trsf* result = (gp_Trsf*)instance;
 	result->Transforms(			
_Coord);
}
DECL_EXPORT bool gp_Trsf_IsNegative(void* instance)
{
	gp_Trsf* result = (gp_Trsf*)instance;
	return 	result->IsNegative();
}

DECL_EXPORT int gp_Trsf_Form(void* instance)
{
	gp_Trsf* result = (gp_Trsf*)instance;
	return (int)	result->Form();
}

DECL_EXPORT void gp_Trsf_SetScaleFactor(void* instance, double value)
{
	gp_Trsf* result = (gp_Trsf*)instance;
		result->SetScaleFactor(value);
}

DECL_EXPORT double gp_Trsf_ScaleFactor(void* instance)
{
	gp_Trsf* result = (gp_Trsf*)instance;
	return 	result->ScaleFactor();
}

DECL_EXPORT void gp_Trsf_SetTranslationPart(void* instance, void* value)
{
	gp_Trsf* result = (gp_Trsf*)instance;
		result->SetTranslationPart(*(const gp_Vec *)value);
}

DECL_EXPORT void* gp_Trsf_TranslationPart(void* instance)
{
	gp_Trsf* result = (gp_Trsf*)instance;
	return 	new gp_Vec(	result->TranslationPart());
}

DECL_EXPORT void* gp_Trsf_VectorialPart(void* instance)
{
	gp_Trsf* result = (gp_Trsf*)instance;
	return 	new gp_Mat(	result->VectorialPart());
}

DECL_EXPORT void* gp_Trsf_HVectorialPart(void* instance)
{
	gp_Trsf* result = (gp_Trsf*)instance;
	return 	new gp_Mat(	result->HVectorialPart());
}

DECL_EXPORT void* gp_Trsf_Inverted(void* instance)
{
	gp_Trsf* result = (gp_Trsf*)instance;
	return 	new gp_Trsf(	result->Inverted());
}

DECL_EXPORT void gpTrsf_Dtor(void* instance)
{
	delete (gp_Trsf*)instance;
}
