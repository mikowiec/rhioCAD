#include "BndBox.h"
#include <Bnd_Box.hxx>

#include <Bnd_Box.hxx>

DECL_EXPORT void* Bnd_Box_Ctor()
{
	return new Bnd_Box();
}
DECL_EXPORT void Bnd_Box_SetWhole(void* instance)
{
	Bnd_Box* result = (Bnd_Box*)instance;
 	result->SetWhole();
}
DECL_EXPORT void Bnd_Box_SetVoid(void* instance)
{
	Bnd_Box* result = (Bnd_Box*)instance;
 	result->SetVoid();
}
DECL_EXPORT void Bnd_Box_Set9EAECD5B(
	void* instance,
	void* P)
{
		const gp_Pnt &  _P =*(const gp_Pnt *)P;
	Bnd_Box* result = (Bnd_Box*)instance;
 	result->Set(			
_P);
}
DECL_EXPORT void Bnd_Box_SetE13B639C(
	void* instance,
	void* P,
	void* D)
{
		const gp_Pnt &  _P =*(const gp_Pnt *)P;
		const gp_Dir &  _D =*(const gp_Dir *)D;
	Bnd_Box* result = (Bnd_Box*)instance;
 	result->Set(			
_P,			
_D);
}
DECL_EXPORT void Bnd_Box_UpdateBC7A5786(
	void* instance,
	double aXmin,
	double aYmin,
	double aZmin,
	double aXmax,
	double aYmax,
	double aZmax)
{
	Bnd_Box* result = (Bnd_Box*)instance;
 	result->Update(			
aXmin,			
aYmin,			
aZmin,			
aXmax,			
aYmax,			
aZmax);
}
DECL_EXPORT void Bnd_Box_Update9282A951(
	void* instance,
	double X,
	double Y,
	double Z)
{
	Bnd_Box* result = (Bnd_Box*)instance;
 	result->Update(			
X,			
Y,			
Z);
}
DECL_EXPORT void Bnd_Box_EnlargeD82819F3(
	void* instance,
	double Tol)
{
	Bnd_Box* result = (Bnd_Box*)instance;
 	result->Enlarge(			
Tol);
}
DECL_EXPORT void Bnd_Box_GetBC7A5786(
	void* instance,
	double* aXmin,
	double* aYmin,
	double* aZmin,
	double* aXmax,
	double* aYmax,
	double* aZmax)
{
	Bnd_Box* result = (Bnd_Box*)instance;
 	result->Get(			
*aXmin,			
*aYmin,			
*aZmin,			
*aXmax,			
*aYmax,			
*aZmax);
}
DECL_EXPORT void Bnd_Box_OpenXmin(void* instance)
{
	Bnd_Box* result = (Bnd_Box*)instance;
 	result->OpenXmin();
}
DECL_EXPORT void Bnd_Box_OpenXmax(void* instance)
{
	Bnd_Box* result = (Bnd_Box*)instance;
 	result->OpenXmax();
}
DECL_EXPORT void Bnd_Box_OpenYmin(void* instance)
{
	Bnd_Box* result = (Bnd_Box*)instance;
 	result->OpenYmin();
}
DECL_EXPORT void Bnd_Box_OpenYmax(void* instance)
{
	Bnd_Box* result = (Bnd_Box*)instance;
 	result->OpenYmax();
}
DECL_EXPORT void Bnd_Box_OpenZmin(void* instance)
{
	Bnd_Box* result = (Bnd_Box*)instance;
 	result->OpenZmin();
}
DECL_EXPORT void Bnd_Box_OpenZmax(void* instance)
{
	Bnd_Box* result = (Bnd_Box*)instance;
 	result->OpenZmax();
}
DECL_EXPORT bool Bnd_Box_IsXThinD82819F3(
	void* instance,
	double tol)
{
	Bnd_Box* result = (Bnd_Box*)instance;
	return  	result->IsXThin(			
tol);
}
DECL_EXPORT bool Bnd_Box_IsYThinD82819F3(
	void* instance,
	double tol)
{
	Bnd_Box* result = (Bnd_Box*)instance;
	return  	result->IsYThin(			
tol);
}
DECL_EXPORT bool Bnd_Box_IsZThinD82819F3(
	void* instance,
	double tol)
{
	Bnd_Box* result = (Bnd_Box*)instance;
	return  	result->IsZThin(			
tol);
}
DECL_EXPORT bool Bnd_Box_IsThinD82819F3(
	void* instance,
	double tol)
{
	Bnd_Box* result = (Bnd_Box*)instance;
	return  	result->IsThin(			
tol);
}
DECL_EXPORT void* Bnd_Box_Transformed72D78650(
	void* instance,
	void* T)
{
		const gp_Trsf &  _T =*(const gp_Trsf *)T;
	Bnd_Box* result = (Bnd_Box*)instance;
	return new Bnd_Box( 	result->Transformed(			
_T));
}
DECL_EXPORT void Bnd_Box_Add1ADB021(
	void* instance,
	void* Other)
{
		const Bnd_Box &  _Other =*(const Bnd_Box *)Other;
	Bnd_Box* result = (Bnd_Box*)instance;
 	result->Add(			
_Other);
}
DECL_EXPORT void Bnd_Box_Add9EAECD5B(
	void* instance,
	void* P)
{
		const gp_Pnt &  _P =*(const gp_Pnt *)P;
	Bnd_Box* result = (Bnd_Box*)instance;
 	result->Add(			
_P);
}
DECL_EXPORT void Bnd_Box_AddE13B639C(
	void* instance,
	void* P,
	void* D)
{
		const gp_Pnt &  _P =*(const gp_Pnt *)P;
		const gp_Dir &  _D =*(const gp_Dir *)D;
	Bnd_Box* result = (Bnd_Box*)instance;
 	result->Add(			
_P,			
_D);
}
DECL_EXPORT void Bnd_Box_AddCEC711A5(
	void* instance,
	void* D)
{
		const gp_Dir &  _D =*(const gp_Dir *)D;
	Bnd_Box* result = (Bnd_Box*)instance;
 	result->Add(			
_D);
}
DECL_EXPORT bool Bnd_Box_IsOut9EAECD5B(
	void* instance,
	void* P)
{
		const gp_Pnt &  _P =*(const gp_Pnt *)P;
	Bnd_Box* result = (Bnd_Box*)instance;
	return  	result->IsOut(			
_P);
}
DECL_EXPORT bool Bnd_Box_IsOut9917D291(
	void* instance,
	void* L)
{
		const gp_Lin &  _L =*(const gp_Lin *)L;
	Bnd_Box* result = (Bnd_Box*)instance;
	return  	result->IsOut(			
_L);
}
DECL_EXPORT bool Bnd_Box_IsOut9914D2AD(
	void* instance,
	void* P)
{
		const gp_Pln &  _P =*(const gp_Pln *)P;
	Bnd_Box* result = (Bnd_Box*)instance;
	return  	result->IsOut(			
_P);
}
DECL_EXPORT bool Bnd_Box_IsOut1ADB021(
	void* instance,
	void* Other)
{
		const Bnd_Box &  _Other =*(const Bnd_Box *)Other;
	Bnd_Box* result = (Bnd_Box*)instance;
	return  	result->IsOut(			
_Other);
}
DECL_EXPORT bool Bnd_Box_IsOut3A879F89(
	void* instance,
	void* Other,
	void* T)
{
		const Bnd_Box &  _Other =*(const Bnd_Box *)Other;
		const gp_Trsf &  _T =*(const gp_Trsf *)T;
	Bnd_Box* result = (Bnd_Box*)instance;
	return  	result->IsOut(			
_Other,			
_T);
}
DECL_EXPORT bool Bnd_Box_IsOutBCD9C93D(
	void* instance,
	void* T1,
	void* Other,
	void* T2)
{
		const gp_Trsf &  _T1 =*(const gp_Trsf *)T1;
		const Bnd_Box &  _Other =*(const Bnd_Box *)Other;
		const gp_Trsf &  _T2 =*(const gp_Trsf *)T2;
	Bnd_Box* result = (Bnd_Box*)instance;
	return  	result->IsOut(			
_T1,			
_Other,			
_T2);
}
DECL_EXPORT bool Bnd_Box_IsOut637767F(
	void* instance,
	void* P1,
	void* P2,
	void* D)
{
		const gp_Pnt &  _P1 =*(const gp_Pnt *)P1;
		const gp_Pnt &  _P2 =*(const gp_Pnt *)P2;
		const gp_Dir &  _D =*(const gp_Dir *)D;
	Bnd_Box* result = (Bnd_Box*)instance;
	return  	result->IsOut(			
_P1,			
_P2,			
_D);
}
DECL_EXPORT double Bnd_Box_Distance1ADB021(
	void* instance,
	void* Other)
{
		const Bnd_Box &  _Other =*(const Bnd_Box *)Other;
	Bnd_Box* result = (Bnd_Box*)instance;
	return  	result->Distance(			
_Other);
}
DECL_EXPORT void Bnd_Box_Dump(void* instance)
{
	Bnd_Box* result = (Bnd_Box*)instance;
 	result->Dump();
}
DECL_EXPORT double Bnd_Box_GetGap(void* instance)
{
	Bnd_Box* result = (Bnd_Box*)instance;
	return 	result->GetGap();
}

DECL_EXPORT void Bnd_Box_SetGap(void* instance, double value)
{
	Bnd_Box* result = (Bnd_Box*)instance;
		result->SetGap(value);
}

DECL_EXPORT bool Bnd_Box_IsOpenXmin(void* instance)
{
	Bnd_Box* result = (Bnd_Box*)instance;
	return 	result->IsOpenXmin();
}

DECL_EXPORT bool Bnd_Box_IsOpenXmax(void* instance)
{
	Bnd_Box* result = (Bnd_Box*)instance;
	return 	result->IsOpenXmax();
}

DECL_EXPORT bool Bnd_Box_IsOpenYmin(void* instance)
{
	Bnd_Box* result = (Bnd_Box*)instance;
	return 	result->IsOpenYmin();
}

DECL_EXPORT bool Bnd_Box_IsOpenYmax(void* instance)
{
	Bnd_Box* result = (Bnd_Box*)instance;
	return 	result->IsOpenYmax();
}

DECL_EXPORT bool Bnd_Box_IsOpenZmin(void* instance)
{
	Bnd_Box* result = (Bnd_Box*)instance;
	return 	result->IsOpenZmin();
}

DECL_EXPORT bool Bnd_Box_IsOpenZmax(void* instance)
{
	Bnd_Box* result = (Bnd_Box*)instance;
	return 	result->IsOpenZmax();
}

DECL_EXPORT bool Bnd_Box_IsWhole(void* instance)
{
	Bnd_Box* result = (Bnd_Box*)instance;
	return 	result->IsWhole();
}

DECL_EXPORT bool Bnd_Box_IsVoid(void* instance)
{
	Bnd_Box* result = (Bnd_Box*)instance;
	return 	result->IsVoid();
}

DECL_EXPORT double Bnd_Box_SquareExtent(void* instance)
{
	Bnd_Box* result = (Bnd_Box*)instance;
	return 	result->SquareExtent();
}

DECL_EXPORT void BndBox_Dtor(void* instance)
{
	delete (Bnd_Box*)instance;
}
