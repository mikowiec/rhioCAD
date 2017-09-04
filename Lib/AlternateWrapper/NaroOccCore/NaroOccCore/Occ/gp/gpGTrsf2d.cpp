#include "gpGTrsf2d.h"
#include <gp_GTrsf2d.hxx>

#include <gp_GTrsf2d.hxx>
#include <gp_Mat2d.hxx>
#include <gp_Trsf2d.hxx>
#include <gp_XY.hxx>

DECL_EXPORT void* gp_GTrsf2d_Ctor()
{
	return new gp_GTrsf2d();
}
DECL_EXPORT void* gp_GTrsf2d_Ctor27621DCB(
	void* T)
{
		const gp_Trsf2d &  _T =*(const gp_Trsf2d *)T;
	return new gp_GTrsf2d(			
_T);
}
DECL_EXPORT void* gp_GTrsf2d_CtorA0E23F93(
	void* M,
	void* V)
{
		const gp_Mat2d &  _M =*(const gp_Mat2d *)M;
		const gp_XY &  _V =*(const gp_XY *)V;
	return new gp_GTrsf2d(			
_M,			
_V);
}
DECL_EXPORT void gp_GTrsf2d_SetAffinityF4E58768(
	void* instance,
	void* A,
	double Ratio)
{
		const gp_Ax2d &  _A =*(const gp_Ax2d *)A;
	gp_GTrsf2d* result = (gp_GTrsf2d*)instance;
 	result->SetAffinity(			
_A,			
Ratio);
}
DECL_EXPORT void gp_GTrsf2d_SetValue83917674(
	void* instance,
	int Row,
	int Col,
	double Value)
{
	gp_GTrsf2d* result = (gp_GTrsf2d*)instance;
 	result->SetValue(			
Row,			
Col,			
Value);
}
DECL_EXPORT double gp_GTrsf2d_Value5107F6FE(
	void* instance,
	int Row,
	int Col)
{
	gp_GTrsf2d* result = (gp_GTrsf2d*)instance;
	return  	result->Value(			
Row,			
Col);
}
DECL_EXPORT void gp_GTrsf2d_Invert(void* instance)
{
	gp_GTrsf2d* result = (gp_GTrsf2d*)instance;
 	result->Invert();
}
DECL_EXPORT void gp_GTrsf2d_Multiply34614B5D(
	void* instance,
	void* T)
{
		const gp_GTrsf2d &  _T =*(const gp_GTrsf2d *)T;
	gp_GTrsf2d* result = (gp_GTrsf2d*)instance;
 	result->Multiply(			
_T);
}
DECL_EXPORT void* gp_GTrsf2d_Multiplied34614B5D(
	void* instance,
	void* T)
{
		const gp_GTrsf2d &  _T =*(const gp_GTrsf2d *)T;
	gp_GTrsf2d* result = (gp_GTrsf2d*)instance;
	return new gp_GTrsf2d( 	result->Multiplied(			
_T));
}
DECL_EXPORT void gp_GTrsf2d_PreMultiply34614B5D(
	void* instance,
	void* T)
{
		const gp_GTrsf2d &  _T =*(const gp_GTrsf2d *)T;
	gp_GTrsf2d* result = (gp_GTrsf2d*)instance;
 	result->PreMultiply(			
_T);
}
DECL_EXPORT void gp_GTrsf2d_PowerE8219145(
	void* instance,
	int N)
{
	gp_GTrsf2d* result = (gp_GTrsf2d*)instance;
 	result->Power(			
N);
}
DECL_EXPORT void* gp_GTrsf2d_PoweredE8219145(
	void* instance,
	int N)
{
	gp_GTrsf2d* result = (gp_GTrsf2d*)instance;
	return new gp_GTrsf2d( 	result->Powered(			
N));
}
DECL_EXPORT void gp_GTrsf2d_TransformsE051EF89(
	void* instance,
	void* Coord)
{
		 gp_XY &  _Coord =*( gp_XY *)Coord;
	gp_GTrsf2d* result = (gp_GTrsf2d*)instance;
 	result->Transforms(			
_Coord);
}
DECL_EXPORT void* gp_GTrsf2d_TransformedE051EF89(
	void* instance,
	void* Coord)
{
		const gp_XY &  _Coord =*(const gp_XY *)Coord;
	gp_GTrsf2d* result = (gp_GTrsf2d*)instance;
	return new gp_XY( 	result->Transformed(			
_Coord));
}
DECL_EXPORT void gp_GTrsf2d_Transforms9F0E714F(
	void* instance,
	double* X,
	double* Y)
{
	gp_GTrsf2d* result = (gp_GTrsf2d*)instance;
 	result->Transforms(			
*X,			
*Y);
}
DECL_EXPORT bool gp_GTrsf2d_IsNegative(void* instance)
{
	gp_GTrsf2d* result = (gp_GTrsf2d*)instance;
	return 	result->IsNegative();
}

DECL_EXPORT bool gp_GTrsf2d_IsSingular(void* instance)
{
	gp_GTrsf2d* result = (gp_GTrsf2d*)instance;
	return 	result->IsSingular();
}

DECL_EXPORT int gp_GTrsf2d_Form(void* instance)
{
	gp_GTrsf2d* result = (gp_GTrsf2d*)instance;
	return (int)	result->Form();
}

DECL_EXPORT void gp_GTrsf2d_SetTranslationPart(void* instance, void* value)
{
	gp_GTrsf2d* result = (gp_GTrsf2d*)instance;
		result->SetTranslationPart(*(const gp_XY *)value);
}

DECL_EXPORT void* gp_GTrsf2d_TranslationPart(void* instance)
{
	gp_GTrsf2d* result = (gp_GTrsf2d*)instance;
	return 	new gp_XY(	result->TranslationPart());
}

DECL_EXPORT void gp_GTrsf2d_SetVectorialPart(void* instance, void* value)
{
	gp_GTrsf2d* result = (gp_GTrsf2d*)instance;
		result->SetVectorialPart(*(const gp_Mat2d *)value);
}

DECL_EXPORT void* gp_GTrsf2d_VectorialPart(void* instance)
{
	gp_GTrsf2d* result = (gp_GTrsf2d*)instance;
	return 	new gp_Mat2d(	result->VectorialPart());
}

DECL_EXPORT void* gp_GTrsf2d_Inverted(void* instance)
{
	gp_GTrsf2d* result = (gp_GTrsf2d*)instance;
	return 	new gp_GTrsf2d(	result->Inverted());
}

DECL_EXPORT void gp_GTrsf2d_SetTrsf2d(void* instance, void* value)
{
	gp_GTrsf2d* result = (gp_GTrsf2d*)instance;
		result->SetTrsf2d(*(const gp_Trsf2d *)value);
}

DECL_EXPORT void* gp_GTrsf2d_Trsf2d(void* instance)
{
	gp_GTrsf2d* result = (gp_GTrsf2d*)instance;
	return 	new gp_Trsf2d(	result->Trsf2d());
}

DECL_EXPORT void gpGTrsf2d_Dtor(void* instance)
{
	delete (gp_GTrsf2d*)instance;
}
