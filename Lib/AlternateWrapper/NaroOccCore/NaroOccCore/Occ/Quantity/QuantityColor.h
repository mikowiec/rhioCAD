#ifndef Quantity_Color_H
#define Quantity_Color_H

#include "../../Export_Import.h"

extern "C" DECL_EXPORT void* Quantity_Color_Ctor();
extern "C" DECL_EXPORT void* Quantity_Color_Ctor48F4F471(
	int AName);
extern "C" DECL_EXPORT void* Quantity_Color_Ctor2BE4ECDC(
	double R1,
	double R2,
	double R3,
	int AType);
extern "C" DECL_EXPORT void* Quantity_Color_Assign8FD7F48(
	void* instance,
	void* Other);
extern "C" DECL_EXPORT void Quantity_Color_ChangeContrastD82819F3(
	void* instance,
	double ADelta);
extern "C" DECL_EXPORT void Quantity_Color_ChangeIntensityD82819F3(
	void* instance,
	double ADelta);
extern "C" DECL_EXPORT void Quantity_Color_SetValues48F4F471(
	void* instance,
	int AName);
extern "C" DECL_EXPORT void Quantity_Color_SetValues2BE4ECDC(
	void* instance,
	double R1,
	double R2,
	double R3,
	int AType);
extern "C" DECL_EXPORT void Quantity_Color_DeltaA6E67349(
	void* instance,
	void* AColor,
	double* DC,
	double* DI);
extern "C" DECL_EXPORT double Quantity_Color_Distance8FD7F48(
	void* instance,
	void* AColor);
extern "C" DECL_EXPORT double Quantity_Color_SquareDistance8FD7F48(
	void* instance,
	void* AColor);
extern "C" DECL_EXPORT bool Quantity_Color_IsDifferent8FD7F48(
	void* instance,
	void* Other);
extern "C" DECL_EXPORT bool Quantity_Color_IsEqual8FD7F48(
	void* instance,
	void* Other);
extern "C" DECL_EXPORT int Quantity_Color_Name(void* instance);
extern "C" DECL_EXPORT void Quantity_Color_Values2BE4ECDC(
	void* instance,
	double* R1,
	double* R2,
	double* R3,
	int AType);
extern "C" DECL_EXPORT int Quantity_Color_Name9282A951(
	double R,
	double G,
	double B);
extern "C" DECL_EXPORT Standard_CString Quantity_Color_StringName48F4F471(
	int AColor);
extern "C" DECL_EXPORT void Quantity_Color_HlsRgbBC7A5786(
	double H,
	double L,
	double S,
	double* R,
	double* G,
	double* B);
extern "C" DECL_EXPORT void Quantity_Color_RgbHlsBC7A5786(
	double R,
	double G,
	double B,
	double* H,
	double* L,
	double* S);
extern "C" DECL_EXPORT void Quantity_Color_Color2argbDE9AF5DE(
	void* theColor,
	int* theARGB);
extern "C" DECL_EXPORT void Quantity_Color_Argb2color8575C8EE(
	int theARGB,
	void* theColor);
extern "C" DECL_EXPORT void Quantity_Color_Test();
extern "C" DECL_EXPORT double Quantity_Color_Blue(void* instance);
extern "C" DECL_EXPORT double Quantity_Color_Green(void* instance);
extern "C" DECL_EXPORT double Quantity_Color_Hue(void* instance);
extern "C" DECL_EXPORT double Quantity_Color_Light(void* instance);
extern "C" DECL_EXPORT double Quantity_Color_Red(void* instance);
extern "C" DECL_EXPORT double Quantity_Color_Saturation(void* instance);
extern "C" DECL_EXPORT void QuantityColor_Dtor(void* instance);

#endif
