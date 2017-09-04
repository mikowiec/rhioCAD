#include "GeomTransformation.h"
#include <Geom_Transformation.hxx>

#include <Geom_Transformation.hxx>
#include <gp_Trsf.hxx>

DECL_EXPORT void* Geom_Transformation_Ctor()
{
	return new Handle_Geom_Transformation(new Geom_Transformation());
}
DECL_EXPORT void* Geom_Transformation_Ctor72D78650(
	void* T)
{
		const gp_Trsf &  _T =*(const gp_Trsf *)T;
	return new Handle_Geom_Transformation(new Geom_Transformation(			
_T));
}
DECL_EXPORT void Geom_Transformation_SetMirror9EAECD5B(
	void* instance,
	void* P)
{
		const gp_Pnt &  _P =*(const gp_Pnt *)P;
	Geom_Transformation* result = (Geom_Transformation*)(((Handle_Geom_Transformation*)instance)->Access());
 	result->SetMirror(			
_P);
}
DECL_EXPORT void Geom_Transformation_SetMirror608B963B(
	void* instance,
	void* A1)
{
		const gp_Ax1 &  _A1 =*(const gp_Ax1 *)A1;
	Geom_Transformation* result = (Geom_Transformation*)(((Handle_Geom_Transformation*)instance)->Access());
 	result->SetMirror(			
_A1);
}
DECL_EXPORT void Geom_Transformation_SetMirror7895386A(
	void* instance,
	void* A2)
{
		const gp_Ax2 &  _A2 =*(const gp_Ax2 *)A2;
	Geom_Transformation* result = (Geom_Transformation*)(((Handle_Geom_Transformation*)instance)->Access());
 	result->SetMirror(			
_A2);
}
DECL_EXPORT void Geom_Transformation_SetRotation827CB19A(
	void* instance,
	void* A1,
	double Ang)
{
		const gp_Ax1 &  _A1 =*(const gp_Ax1 *)A1;
	Geom_Transformation* result = (Geom_Transformation*)(((Handle_Geom_Transformation*)instance)->Access());
 	result->SetRotation(			
_A1,			
Ang);
}
DECL_EXPORT void Geom_Transformation_SetScaleF0D1E3E6(
	void* instance,
	void* P,
	double S)
{
		const gp_Pnt &  _P =*(const gp_Pnt *)P;
	Geom_Transformation* result = (Geom_Transformation*)(((Handle_Geom_Transformation*)instance)->Access());
 	result->SetScale(			
_P,			
S);
}
DECL_EXPORT void Geom_Transformation_SetTransformationB5D8FD04(
	void* instance,
	void* FromSystem1,
	void* ToSystem2)
{
		const gp_Ax3 &  _FromSystem1 =*(const gp_Ax3 *)FromSystem1;
		const gp_Ax3 &  _ToSystem2 =*(const gp_Ax3 *)ToSystem2;
	Geom_Transformation* result = (Geom_Transformation*)(((Handle_Geom_Transformation*)instance)->Access());
 	result->SetTransformation(			
_FromSystem1,			
_ToSystem2);
}
DECL_EXPORT void Geom_Transformation_SetTransformation1B3CAD05(
	void* instance,
	void* ToSystem)
{
		const gp_Ax3 &  _ToSystem =*(const gp_Ax3 *)ToSystem;
	Geom_Transformation* result = (Geom_Transformation*)(((Handle_Geom_Transformation*)instance)->Access());
 	result->SetTransformation(			
_ToSystem);
}
DECL_EXPORT void Geom_Transformation_SetTranslation9BD9CFFE(
	void* instance,
	void* V)
{
		const gp_Vec &  _V =*(const gp_Vec *)V;
	Geom_Transformation* result = (Geom_Transformation*)(((Handle_Geom_Transformation*)instance)->Access());
 	result->SetTranslation(			
_V);
}
DECL_EXPORT void Geom_Transformation_SetTranslation5C63477E(
	void* instance,
	void* P1,
	void* P2)
{
		const gp_Pnt &  _P1 =*(const gp_Pnt *)P1;
		const gp_Pnt &  _P2 =*(const gp_Pnt *)P2;
	Geom_Transformation* result = (Geom_Transformation*)(((Handle_Geom_Transformation*)instance)->Access());
 	result->SetTranslation(			
_P1,			
_P2);
}
DECL_EXPORT double Geom_Transformation_Value5107F6FE(
	void* instance,
	int Row,
	int Col)
{
	Geom_Transformation* result = (Geom_Transformation*)(((Handle_Geom_Transformation*)instance)->Access());
	return  	result->Value(			
Row,			
Col);
}
DECL_EXPORT void Geom_Transformation_Invert(void* instance)
{
	Geom_Transformation* result = (Geom_Transformation*)(((Handle_Geom_Transformation*)instance)->Access());
 	result->Invert();
}
DECL_EXPORT void* Geom_Transformation_Multiplied23447582(
	void* instance,
	void* Other)
{
		const Handle_Geom_Transformation&  _Other =*(const Handle_Geom_Transformation *)Other;
	Geom_Transformation* result = (Geom_Transformation*)(((Handle_Geom_Transformation*)instance)->Access());
	return new Handle_Geom_Transformation( 	result->Multiplied(			
_Other));
}
DECL_EXPORT void Geom_Transformation_Multiply23447582(
	void* instance,
	void* Other)
{
		const Handle_Geom_Transformation&  _Other =*(const Handle_Geom_Transformation *)Other;
	Geom_Transformation* result = (Geom_Transformation*)(((Handle_Geom_Transformation*)instance)->Access());
 	result->Multiply(			
_Other);
}
DECL_EXPORT void Geom_Transformation_PowerE8219145(
	void* instance,
	int N)
{
	Geom_Transformation* result = (Geom_Transformation*)(((Handle_Geom_Transformation*)instance)->Access());
 	result->Power(			
N);
}
DECL_EXPORT void* Geom_Transformation_PoweredE8219145(
	void* instance,
	int N)
{
	Geom_Transformation* result = (Geom_Transformation*)(((Handle_Geom_Transformation*)instance)->Access());
	return new Handle_Geom_Transformation( 	result->Powered(			
N));
}
DECL_EXPORT void Geom_Transformation_PreMultiply23447582(
	void* instance,
	void* Other)
{
		const Handle_Geom_Transformation&  _Other =*(const Handle_Geom_Transformation *)Other;
	Geom_Transformation* result = (Geom_Transformation*)(((Handle_Geom_Transformation*)instance)->Access());
 	result->PreMultiply(			
_Other);
}
DECL_EXPORT void Geom_Transformation_Transforms9282A951(
	void* instance,
	double* X,
	double* Y,
	double* Z)
{
	Geom_Transformation* result = (Geom_Transformation*)(((Handle_Geom_Transformation*)instance)->Access());
 	result->Transforms(			
*X,			
*Y,			
*Z);
}
DECL_EXPORT bool Geom_Transformation_IsNegative(void* instance)
{
	Geom_Transformation* result = (Geom_Transformation*)(((Handle_Geom_Transformation*)instance)->Access());
	return 	result->IsNegative();
}

DECL_EXPORT int Geom_Transformation_Form(void* instance)
{
	Geom_Transformation* result = (Geom_Transformation*)(((Handle_Geom_Transformation*)instance)->Access());
	return (int)	result->Form();
}

DECL_EXPORT double Geom_Transformation_ScaleFactor(void* instance)
{
	Geom_Transformation* result = (Geom_Transformation*)(((Handle_Geom_Transformation*)instance)->Access());
	return 	result->ScaleFactor();
}

DECL_EXPORT void Geom_Transformation_SetTrsf(void* instance, void* value)
{
	Geom_Transformation* result = (Geom_Transformation*)(((Handle_Geom_Transformation*)instance)->Access());
		result->SetTrsf(*(const gp_Trsf *)value);
}

DECL_EXPORT void* Geom_Transformation_Trsf(void* instance)
{
	Geom_Transformation* result = (Geom_Transformation*)(((Handle_Geom_Transformation*)instance)->Access());
	return 	new gp_Trsf(	result->Trsf());
}

DECL_EXPORT void* Geom_Transformation_Inverted(void* instance)
{
	Geom_Transformation* result = (Geom_Transformation*)(((Handle_Geom_Transformation*)instance)->Access());
	return 	new Handle_Geom_Transformation(	result->Inverted());
}

DECL_EXPORT void* Geom_Transformation_Copy(void* instance)
{
	Geom_Transformation* result = (Geom_Transformation*)(((Handle_Geom_Transformation*)instance)->Access());
	return 	new Handle_Geom_Transformation(	result->Copy());
}

DECL_EXPORT void GeomTransformation_Dtor(void* instance)
{
	delete (Handle_Geom_Transformation*)instance;
}
