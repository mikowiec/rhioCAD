#include "QuantityColor.h"
#include <Quantity_Color.hxx>

#include <Quantity_Color.hxx>

DECL_EXPORT void* Quantity_Color_Ctor()
{
	return new Quantity_Color();
}
DECL_EXPORT void* Quantity_Color_Ctor48F4F471(
	int AName)
{
		const Quantity_NameOfColor _AName =(const Quantity_NameOfColor )AName;
	return new Quantity_Color(			
_AName);
}
DECL_EXPORT void* Quantity_Color_Ctor2BE4ECDC(
	double R1,
	double R2,
	double R3,
	int AType)
{
		const Quantity_TypeOfColor _AType =(const Quantity_TypeOfColor )AType;
	return new Quantity_Color(			
R1,			
R2,			
R3,			
_AType);
}
DECL_EXPORT void* Quantity_Color_Assign8FD7F48(
	void* instance,
	void* Other)
{
		const Quantity_Color &  _Other =*(const Quantity_Color *)Other;
	Quantity_Color* result = (Quantity_Color*)instance;
	return new Quantity_Color( 	result->Assign(			
_Other));
}
DECL_EXPORT void Quantity_Color_ChangeContrastD82819F3(
	void* instance,
	double ADelta)
{
	Quantity_Color* result = (Quantity_Color*)instance;
 	result->ChangeContrast(			
ADelta);
}
DECL_EXPORT void Quantity_Color_ChangeIntensityD82819F3(
	void* instance,
	double ADelta)
{
	Quantity_Color* result = (Quantity_Color*)instance;
 	result->ChangeIntensity(			
ADelta);
}
DECL_EXPORT void Quantity_Color_SetValues48F4F471(
	void* instance,
	int AName)
{
		const Quantity_NameOfColor _AName =(const Quantity_NameOfColor )AName;
	Quantity_Color* result = (Quantity_Color*)instance;
 	result->SetValues(			
_AName);
}
DECL_EXPORT void Quantity_Color_SetValues2BE4ECDC(
	void* instance,
	double R1,
	double R2,
	double R3,
	int AType)
{
		const Quantity_TypeOfColor _AType =(const Quantity_TypeOfColor )AType;
	Quantity_Color* result = (Quantity_Color*)instance;
 	result->SetValues(			
R1,			
R2,			
R3,			
_AType);
}
DECL_EXPORT void Quantity_Color_DeltaA6E67349(
	void* instance,
	void* AColor,
	double* DC,
	double* DI)
{
		const Quantity_Color &  _AColor =*(const Quantity_Color *)AColor;
	Quantity_Color* result = (Quantity_Color*)instance;
 	result->Delta(			
_AColor,			
*DC,			
*DI);
}
DECL_EXPORT double Quantity_Color_Distance8FD7F48(
	void* instance,
	void* AColor)
{
		const Quantity_Color &  _AColor =*(const Quantity_Color *)AColor;
	Quantity_Color* result = (Quantity_Color*)instance;
	return  	result->Distance(			
_AColor);
}
DECL_EXPORT double Quantity_Color_SquareDistance8FD7F48(
	void* instance,
	void* AColor)
{
		const Quantity_Color &  _AColor =*(const Quantity_Color *)AColor;
	Quantity_Color* result = (Quantity_Color*)instance;
	return  	result->SquareDistance(			
_AColor);
}
DECL_EXPORT bool Quantity_Color_IsDifferent8FD7F48(
	void* instance,
	void* Other)
{
		const Quantity_Color &  _Other =*(const Quantity_Color *)Other;
	Quantity_Color* result = (Quantity_Color*)instance;
	return  	result->IsDifferent(			
_Other);
}
DECL_EXPORT bool Quantity_Color_IsEqual8FD7F48(
	void* instance,
	void* Other)
{
		const Quantity_Color &  _Other =*(const Quantity_Color *)Other;
	Quantity_Color* result = (Quantity_Color*)instance;
	return  	result->IsEqual(			
_Other);
}
DECL_EXPORT int Quantity_Color_Name(void* instance)
{
	Quantity_Color* result = (Quantity_Color*)instance;
	return  	result->Name();
}
DECL_EXPORT void Quantity_Color_Values2BE4ECDC(
	void* instance,
	double* R1,
	double* R2,
	double* R3,
	int AType)
{
		const Quantity_TypeOfColor _AType =(const Quantity_TypeOfColor )AType;
	Quantity_Color* result = (Quantity_Color*)instance;
 	result->Values(			
*R1,			
*R2,			
*R3,			
_AType);
}
DECL_EXPORT int Quantity_Color_Name9282A951(
	double R,
	double G,
	double B)
{
	return  Quantity_Color::Name(			
R,			
G,			
B);
}
DECL_EXPORT Standard_CString Quantity_Color_StringName48F4F471(
	int AColor)
{
		const Quantity_NameOfColor _AColor =(const Quantity_NameOfColor )AColor;
	return  Quantity_Color::StringName(			
_AColor);
}
DECL_EXPORT void Quantity_Color_HlsRgbBC7A5786(
	double H,
	double L,
	double S,
	double* R,
	double* G,
	double* B)
{
 Quantity_Color::HlsRgb(			
H,			
L,			
S,			
*R,			
*G,			
*B);
}
DECL_EXPORT void Quantity_Color_RgbHlsBC7A5786(
	double R,
	double G,
	double B,
	double* H,
	double* L,
	double* S)
{
 Quantity_Color::RgbHls(			
R,			
G,			
B,			
*H,			
*L,			
*S);
}
DECL_EXPORT void Quantity_Color_Color2argbDE9AF5DE(
	void* theColor,
	int* theARGB)
{
		const Quantity_Color &  _theColor =*(const Quantity_Color *)theColor;
 Quantity_Color::Color2argb(			
_theColor,			
*theARGB);
}
DECL_EXPORT void Quantity_Color_Argb2color8575C8EE(
	int theARGB,
	void* theColor)
{
		 Quantity_Color &  _theColor =*( Quantity_Color *)theColor;
 Quantity_Color::Argb2color(			
theARGB,			
_theColor);
}
DECL_EXPORT void Quantity_Color_Test()
{
 Quantity_Color::Test();
}
DECL_EXPORT double Quantity_Color_Blue(void* instance)
{
	Quantity_Color* result = (Quantity_Color*)instance;
	return 	result->Blue();
}

DECL_EXPORT double Quantity_Color_Green(void* instance)
{
	Quantity_Color* result = (Quantity_Color*)instance;
	return 	result->Green();
}

DECL_EXPORT double Quantity_Color_Hue(void* instance)
{
	Quantity_Color* result = (Quantity_Color*)instance;
	return 	result->Hue();
}

DECL_EXPORT double Quantity_Color_Light(void* instance)
{
	Quantity_Color* result = (Quantity_Color*)instance;
	return 	result->Light();
}

DECL_EXPORT double Quantity_Color_Red(void* instance)
{
	Quantity_Color* result = (Quantity_Color*)instance;
	return 	result->Red();
}

DECL_EXPORT double Quantity_Color_Saturation(void* instance)
{
	Quantity_Color* result = (Quantity_Color*)instance;
	return 	result->Saturation();
}

DECL_EXPORT void QuantityColor_Dtor(void* instance)
{
	delete (Quantity_Color*)instance;
}
