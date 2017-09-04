#include "BndBox2d.h"
#include <Bnd_Box2d.hxx>

#include <Bnd_Box2d.hxx>

DECL_EXPORT void* Bnd_Box2d_Ctor()
{
	return new Bnd_Box2d();
}
DECL_EXPORT void Bnd_Box2d_SetWhole(void* instance)
{
	Bnd_Box2d* result = (Bnd_Box2d*)instance;
 	result->SetWhole();
}
DECL_EXPORT void Bnd_Box2d_SetVoid(void* instance)
{
	Bnd_Box2d* result = (Bnd_Box2d*)instance;
 	result->SetVoid();
}
DECL_EXPORT void Bnd_Box2d_Set6203658C(
	void* instance,
	void* P)
{
		const gp_Pnt2d &  _P =*(const gp_Pnt2d *)P;
	Bnd_Box2d* result = (Bnd_Box2d*)instance;
 	result->Set(			
_P);
}
DECL_EXPORT void Bnd_Box2d_Set2E9C6BD1(
	void* instance,
	void* P,
	void* D)
{
		const gp_Pnt2d &  _P =*(const gp_Pnt2d *)P;
		const gp_Dir2d &  _D =*(const gp_Dir2d *)D;
	Bnd_Box2d* result = (Bnd_Box2d*)instance;
 	result->Set(			
_P,			
_D);
}
DECL_EXPORT void Bnd_Box2d_UpdateC2777E0C(
	void* instance,
	double aXmin,
	double aYmin,
	double aXmax,
	double aYmax)
{
	Bnd_Box2d* result = (Bnd_Box2d*)instance;
 	result->Update(			
aXmin,			
aYmin,			
aXmax,			
aYmax);
}
DECL_EXPORT void Bnd_Box2d_Update9F0E714F(
	void* instance,
	double X,
	double Y)
{
	Bnd_Box2d* result = (Bnd_Box2d*)instance;
 	result->Update(			
X,			
Y);
}
DECL_EXPORT void Bnd_Box2d_EnlargeD82819F3(
	void* instance,
	double Tol)
{
	Bnd_Box2d* result = (Bnd_Box2d*)instance;
 	result->Enlarge(			
Tol);
}
DECL_EXPORT void Bnd_Box2d_GetC2777E0C(
	void* instance,
	double* aXmin,
	double* aYmin,
	double* aXmax,
	double* aYmax)
{
	Bnd_Box2d* result = (Bnd_Box2d*)instance;
 	result->Get(			
*aXmin,			
*aYmin,			
*aXmax,			
*aYmax);
}
DECL_EXPORT void Bnd_Box2d_OpenXmin(void* instance)
{
	Bnd_Box2d* result = (Bnd_Box2d*)instance;
 	result->OpenXmin();
}
DECL_EXPORT void Bnd_Box2d_OpenXmax(void* instance)
{
	Bnd_Box2d* result = (Bnd_Box2d*)instance;
 	result->OpenXmax();
}
DECL_EXPORT void Bnd_Box2d_OpenYmin(void* instance)
{
	Bnd_Box2d* result = (Bnd_Box2d*)instance;
 	result->OpenYmin();
}
DECL_EXPORT void Bnd_Box2d_OpenYmax(void* instance)
{
	Bnd_Box2d* result = (Bnd_Box2d*)instance;
 	result->OpenYmax();
}
DECL_EXPORT void* Bnd_Box2d_Transformed27621DCB(
	void* instance,
	void* T)
{
		const gp_Trsf2d &  _T =*(const gp_Trsf2d *)T;
	Bnd_Box2d* result = (Bnd_Box2d*)instance;
	return new Bnd_Box2d( 	result->Transformed(			
_T));
}
DECL_EXPORT void Bnd_Box2d_Add5D98465D(
	void* instance,
	void* Other)
{
		const Bnd_Box2d &  _Other =*(const Bnd_Box2d *)Other;
	Bnd_Box2d* result = (Bnd_Box2d*)instance;
 	result->Add(			
_Other);
}
DECL_EXPORT void Bnd_Box2d_Add6203658C(
	void* instance,
	void* P)
{
		const gp_Pnt2d &  _P =*(const gp_Pnt2d *)P;
	Bnd_Box2d* result = (Bnd_Box2d*)instance;
 	result->Add(			
_P);
}
DECL_EXPORT void Bnd_Box2d_Add2E9C6BD1(
	void* instance,
	void* P,
	void* D)
{
		const gp_Pnt2d &  _P =*(const gp_Pnt2d *)P;
		const gp_Dir2d &  _D =*(const gp_Dir2d *)D;
	Bnd_Box2d* result = (Bnd_Box2d*)instance;
 	result->Add(			
_P,			
_D);
}
DECL_EXPORT void Bnd_Box2d_Add92BBA68E(
	void* instance,
	void* D)
{
		const gp_Dir2d &  _D =*(const gp_Dir2d *)D;
	Bnd_Box2d* result = (Bnd_Box2d*)instance;
 	result->Add(			
_D);
}
DECL_EXPORT bool Bnd_Box2d_IsOut6203658C(
	void* instance,
	void* P)
{
		const gp_Pnt2d &  _P =*(const gp_Pnt2d *)P;
	Bnd_Box2d* result = (Bnd_Box2d*)instance;
	return  	result->IsOut(			
_P);
}
DECL_EXPORT bool Bnd_Box2d_IsOut5D98465D(
	void* instance,
	void* Other)
{
		const Bnd_Box2d &  _Other =*(const Bnd_Box2d *)Other;
	Bnd_Box2d* result = (Bnd_Box2d*)instance;
	return  	result->IsOut(			
_Other);
}
DECL_EXPORT bool Bnd_Box2d_IsOutD639843B(
	void* instance,
	void* Other,
	void* T)
{
		const Bnd_Box2d &  _Other =*(const Bnd_Box2d *)Other;
		const gp_Trsf2d &  _T =*(const gp_Trsf2d *)T;
	Bnd_Box2d* result = (Bnd_Box2d*)instance;
	return  	result->IsOut(			
_Other,			
_T);
}
DECL_EXPORT bool Bnd_Box2d_IsOutF92CC906(
	void* instance,
	void* T1,
	void* Other,
	void* T2)
{
		const gp_Trsf2d &  _T1 =*(const gp_Trsf2d *)T1;
		const Bnd_Box2d &  _Other =*(const Bnd_Box2d *)Other;
		const gp_Trsf2d &  _T2 =*(const gp_Trsf2d *)T2;
	Bnd_Box2d* result = (Bnd_Box2d*)instance;
	return  	result->IsOut(			
_T1,			
_Other,			
_T2);
}
DECL_EXPORT void Bnd_Box2d_Dump(void* instance)
{
	Bnd_Box2d* result = (Bnd_Box2d*)instance;
 	result->Dump();
}
DECL_EXPORT double Bnd_Box2d_GetGap(void* instance)
{
	Bnd_Box2d* result = (Bnd_Box2d*)instance;
	return 	result->GetGap();
}

DECL_EXPORT void Bnd_Box2d_SetGap(void* instance, double value)
{
	Bnd_Box2d* result = (Bnd_Box2d*)instance;
		result->SetGap(value);
}

DECL_EXPORT bool Bnd_Box2d_IsOpenXmin(void* instance)
{
	Bnd_Box2d* result = (Bnd_Box2d*)instance;
	return 	result->IsOpenXmin();
}

DECL_EXPORT bool Bnd_Box2d_IsOpenXmax(void* instance)
{
	Bnd_Box2d* result = (Bnd_Box2d*)instance;
	return 	result->IsOpenXmax();
}

DECL_EXPORT bool Bnd_Box2d_IsOpenYmin(void* instance)
{
	Bnd_Box2d* result = (Bnd_Box2d*)instance;
	return 	result->IsOpenYmin();
}

DECL_EXPORT bool Bnd_Box2d_IsOpenYmax(void* instance)
{
	Bnd_Box2d* result = (Bnd_Box2d*)instance;
	return 	result->IsOpenYmax();
}

DECL_EXPORT bool Bnd_Box2d_IsWhole(void* instance)
{
	Bnd_Box2d* result = (Bnd_Box2d*)instance;
	return 	result->IsWhole();
}

DECL_EXPORT bool Bnd_Box2d_IsVoid(void* instance)
{
	Bnd_Box2d* result = (Bnd_Box2d*)instance;
	return 	result->IsVoid();
}

DECL_EXPORT void BndBox2d_Dtor(void* instance)
{
	delete (Bnd_Box2d*)instance;
}
