#include "gpGTrsf.h"
#include <gp_GTrsf.hxx>

#include <gp_GTrsf.hxx>
#include <gp_Mat.hxx>
#include <gp_Trsf.hxx>
#include <gp_XYZ.hxx>

DECL_EXPORT void* gp_GTrsf_Ctor()
{
	return new gp_GTrsf();
}
DECL_EXPORT void* gp_GTrsf_Ctor72D78650(
	void* T)
{
		const gp_Trsf &  _T =*(const gp_Trsf *)T;
	return new gp_GTrsf(			
_T);
}
DECL_EXPORT void* gp_GTrsf_CtorD1BD2BB9(
	void* M,
	void* V)
{
		const gp_Mat &  _M =*(const gp_Mat *)M;
		const gp_XYZ &  _V =*(const gp_XYZ *)V;
	return new gp_GTrsf(			
_M,			
_V);
}
DECL_EXPORT void gp_GTrsf_SetAffinity827CB19A(
	void* instance,
	void* A1,
	double Ratio)
{
		const gp_Ax1 &  _A1 =*(const gp_Ax1 *)A1;
	gp_GTrsf* result = (gp_GTrsf*)instance;
 	result->SetAffinity(			
_A1,			
Ratio);
}
DECL_EXPORT void gp_GTrsf_SetAffinity673FA07D(
	void* instance,
	void* A2,
	double Ratio)
{
		const gp_Ax2 &  _A2 =*(const gp_Ax2 *)A2;
	gp_GTrsf* result = (gp_GTrsf*)instance;
 	result->SetAffinity(			
_A2,			
Ratio);
}
DECL_EXPORT void gp_GTrsf_SetValue83917674(
	void* instance,
	int Row,
	int Col,
	double Value)
{
	gp_GTrsf* result = (gp_GTrsf*)instance;
 	result->SetValue(			
Row,			
Col,			
Value);
}
DECL_EXPORT int gp_GTrsf_Form(void* instance)
{
	gp_GTrsf* result = (gp_GTrsf*)instance;
	return  	result->Form();
}
DECL_EXPORT void gp_GTrsf_SetForm(void* instance)
{
	gp_GTrsf* result = (gp_GTrsf*)instance;
 	result->SetForm();
}
DECL_EXPORT double gp_GTrsf_Value5107F6FE(
	void* instance,
	int Row,
	int Col)
{
	gp_GTrsf* result = (gp_GTrsf*)instance;
	return  	result->Value(			
Row,			
Col);
}
DECL_EXPORT void gp_GTrsf_Invert(void* instance)
{
	gp_GTrsf* result = (gp_GTrsf*)instance;
 	result->Invert();
}
DECL_EXPORT void gp_GTrsf_MultiplyD8FBA6AB(
	void* instance,
	void* T)
{
		const gp_GTrsf &  _T =*(const gp_GTrsf *)T;
	gp_GTrsf* result = (gp_GTrsf*)instance;
 	result->Multiply(			
_T);
}
DECL_EXPORT void* gp_GTrsf_MultipliedD8FBA6AB(
	void* instance,
	void* T)
{
		const gp_GTrsf &  _T =*(const gp_GTrsf *)T;
	gp_GTrsf* result = (gp_GTrsf*)instance;
	return new gp_GTrsf( 	result->Multiplied(			
_T));
}
DECL_EXPORT void gp_GTrsf_PreMultiplyD8FBA6AB(
	void* instance,
	void* T)
{
		const gp_GTrsf &  _T =*(const gp_GTrsf *)T;
	gp_GTrsf* result = (gp_GTrsf*)instance;
 	result->PreMultiply(			
_T);
}
DECL_EXPORT void gp_GTrsf_PowerE8219145(
	void* instance,
	int N)
{
	gp_GTrsf* result = (gp_GTrsf*)instance;
 	result->Power(			
N);
}
DECL_EXPORT void* gp_GTrsf_PoweredE8219145(
	void* instance,
	int N)
{
	gp_GTrsf* result = (gp_GTrsf*)instance;
	return new gp_GTrsf( 	result->Powered(			
N));
}
DECL_EXPORT void gp_GTrsf_Transforms8EE42329(
	void* instance,
	void* Coord)
{
		 gp_XYZ &  _Coord =*( gp_XYZ *)Coord;
	gp_GTrsf* result = (gp_GTrsf*)instance;
 	result->Transforms(			
_Coord);
}
DECL_EXPORT void gp_GTrsf_Transforms9282A951(
	void* instance,
	double* X,
	double* Y,
	double* Z)
{
	gp_GTrsf* result = (gp_GTrsf*)instance;
 	result->Transforms(			
*X,			
*Y,			
*Z);
}
DECL_EXPORT bool gp_GTrsf_IsNegative(void* instance)
{
	gp_GTrsf* result = (gp_GTrsf*)instance;
	return 	result->IsNegative();
}

DECL_EXPORT bool gp_GTrsf_IsSingular(void* instance)
{
	gp_GTrsf* result = (gp_GTrsf*)instance;
	return 	result->IsSingular();
}

DECL_EXPORT void gp_GTrsf_SetTranslationPart(void* instance, void* value)
{
	gp_GTrsf* result = (gp_GTrsf*)instance;
		result->SetTranslationPart(*(const gp_XYZ *)value);
}

DECL_EXPORT void* gp_GTrsf_TranslationPart(void* instance)
{
	gp_GTrsf* result = (gp_GTrsf*)instance;
	return 	new gp_XYZ(	result->TranslationPart());
}

DECL_EXPORT void gp_GTrsf_SetVectorialPart(void* instance, void* value)
{
	gp_GTrsf* result = (gp_GTrsf*)instance;
		result->SetVectorialPart(*(const gp_Mat *)value);
}

DECL_EXPORT void* gp_GTrsf_VectorialPart(void* instance)
{
	gp_GTrsf* result = (gp_GTrsf*)instance;
	return 	new gp_Mat(	result->VectorialPart());
}

DECL_EXPORT void* gp_GTrsf_Inverted(void* instance)
{
	gp_GTrsf* result = (gp_GTrsf*)instance;
	return 	new gp_GTrsf(	result->Inverted());
}

DECL_EXPORT void gp_GTrsf_SetTrsf(void* instance, void* value)
{
	gp_GTrsf* result = (gp_GTrsf*)instance;
		result->SetTrsf(*(const gp_Trsf *)value);
}

DECL_EXPORT void* gp_GTrsf_Trsf(void* instance)
{
	gp_GTrsf* result = (gp_GTrsf*)instance;
	return 	new gp_Trsf(	result->Trsf());
}

DECL_EXPORT void gpGTrsf_Dtor(void* instance)
{
	delete (gp_GTrsf*)instance;
}
