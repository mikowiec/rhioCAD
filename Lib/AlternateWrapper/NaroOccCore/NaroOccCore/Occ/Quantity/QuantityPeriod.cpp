#include "QuantityPeriod.h"
#include <Quantity_Period.hxx>

#include <Quantity_Period.hxx>

DECL_EXPORT void* Quantity_Period_Ctor9EE4184A(
	int dd,
	int hh,
	int mn,
	int ss,
	int mis,
	int mics)
{
	return new Quantity_Period(			
dd,			
hh,			
mn,			
ss,			
mis,			
mics);
}
DECL_EXPORT void* Quantity_Period_Ctor5107F6FE(
	int ss,
	int mics)
{
	return new Quantity_Period(			
ss,			
mics);
}
DECL_EXPORT void Quantity_Period_Values9EE4184A(
	void* instance,
	int* dd,
	int* hh,
	int* mn,
	int* ss,
	int* mis,
	int* mics)
{
	Quantity_Period* result = (Quantity_Period*)instance;
 	result->Values(			
*dd,			
*hh,			
*mn,			
*ss,			
*mis,			
*mics);
}
DECL_EXPORT void Quantity_Period_Values5107F6FE(
	void* instance,
	int* ss,
	int* mics)
{
	Quantity_Period* result = (Quantity_Period*)instance;
 	result->Values(			
*ss,			
*mics);
}
DECL_EXPORT void Quantity_Period_SetValues9EE4184A(
	void* instance,
	int dd,
	int hh,
	int mn,
	int ss,
	int mis,
	int mics)
{
	Quantity_Period* result = (Quantity_Period*)instance;
 	result->SetValues(			
dd,			
hh,			
mn,			
ss,			
mis,			
mics);
}
DECL_EXPORT void Quantity_Period_SetValues5107F6FE(
	void* instance,
	int ss,
	int mics)
{
	Quantity_Period* result = (Quantity_Period*)instance;
 	result->SetValues(			
ss,			
mics);
}
DECL_EXPORT void* Quantity_Period_Subtract22BB0292(
	void* instance,
	void* anOther)
{
		const Quantity_Period &  _anOther =*(const Quantity_Period *)anOther;
	Quantity_Period* result = (Quantity_Period*)instance;
	return new Quantity_Period( 	result->Subtract(			
_anOther));
}
DECL_EXPORT void* Quantity_Period_Add22BB0292(
	void* instance,
	void* anOther)
{
		const Quantity_Period &  _anOther =*(const Quantity_Period *)anOther;
	Quantity_Period* result = (Quantity_Period*)instance;
	return new Quantity_Period( 	result->Add(			
_anOther));
}
DECL_EXPORT bool Quantity_Period_IsEqual22BB0292(
	void* instance,
	void* anOther)
{
		const Quantity_Period &  _anOther =*(const Quantity_Period *)anOther;
	Quantity_Period* result = (Quantity_Period*)instance;
	return  	result->IsEqual(			
_anOther);
}
DECL_EXPORT bool Quantity_Period_IsShorter22BB0292(
	void* instance,
	void* anOther)
{
		const Quantity_Period &  _anOther =*(const Quantity_Period *)anOther;
	Quantity_Period* result = (Quantity_Period*)instance;
	return  	result->IsShorter(			
_anOther);
}
DECL_EXPORT bool Quantity_Period_IsLonger22BB0292(
	void* instance,
	void* anOther)
{
		const Quantity_Period &  _anOther =*(const Quantity_Period *)anOther;
	Quantity_Period* result = (Quantity_Period*)instance;
	return  	result->IsLonger(			
_anOther);
}
DECL_EXPORT bool Quantity_Period_IsValid9EE4184A(
	int dd,
	int hh,
	int mn,
	int ss,
	int mis,
	int mics)
{
	return  Quantity_Period::IsValid(			
dd,			
hh,			
mn,			
ss,			
mis,			
mics);
}
DECL_EXPORT bool Quantity_Period_IsValid5107F6FE(
	int ss,
	int mics)
{
	return  Quantity_Period::IsValid(			
ss,			
mics);
}
DECL_EXPORT void QuantityPeriod_Dtor(void* instance)
{
	delete (Quantity_Period*)instance;
}
