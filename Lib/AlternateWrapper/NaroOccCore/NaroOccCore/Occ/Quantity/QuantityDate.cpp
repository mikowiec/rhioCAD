#include "QuantityDate.h"
#include <Quantity_Date.hxx>

#include <Quantity_Date.hxx>
#include <Quantity_Period.hxx>

DECL_EXPORT void* Quantity_Date_Ctor()
{
	return new Quantity_Date();
}
DECL_EXPORT void* Quantity_Date_Ctor24458BB5(
	int mm,
	int dd,
	int yyyy,
	int hh,
	int mn,
	int ss,
	int mis,
	int mics)
{
	return new Quantity_Date(			
mm,			
dd,			
yyyy,			
hh,			
mn,			
ss,			
mis,			
mics);
}
DECL_EXPORT void Quantity_Date_Values24458BB5(
	void* instance,
	int* mm,
	int* dd,
	int* yy,
	int* hh,
	int* mn,
	int* ss,
	int* mis,
	int* mics)
{
	Quantity_Date* result = (Quantity_Date*)instance;
 	result->Values(			
*mm,			
*dd,			
*yy,			
*hh,			
*mn,			
*ss,			
*mis,			
*mics);
}
DECL_EXPORT void Quantity_Date_SetValues24458BB5(
	void* instance,
	int mm,
	int dd,
	int yy,
	int hh,
	int mn,
	int ss,
	int mis,
	int mics)
{
	Quantity_Date* result = (Quantity_Date*)instance;
 	result->SetValues(			
mm,			
dd,			
yy,			
hh,			
mn,			
ss,			
mis,			
mics);
}
DECL_EXPORT void* Quantity_Date_Difference4AE38D5E(
	void* instance,
	void* anOther)
{
		const Quantity_Date &  _anOther =*(const Quantity_Date *)anOther;
	Quantity_Date* result = (Quantity_Date*)instance;
	return new Quantity_Period( 	result->Difference(			
_anOther));
}
DECL_EXPORT void* Quantity_Date_Subtract22BB0292(
	void* instance,
	void* aPeriod)
{
		const Quantity_Period &  _aPeriod =*(const Quantity_Period *)aPeriod;
	Quantity_Date* result = (Quantity_Date*)instance;
	return new Quantity_Date( 	result->Subtract(			
_aPeriod));
}
DECL_EXPORT void* Quantity_Date_Add22BB0292(
	void* instance,
	void* aPeriod)
{
		const Quantity_Period &  _aPeriod =*(const Quantity_Period *)aPeriod;
	Quantity_Date* result = (Quantity_Date*)instance;
	return new Quantity_Date( 	result->Add(			
_aPeriod));
}
DECL_EXPORT bool Quantity_Date_IsEqual4AE38D5E(
	void* instance,
	void* anOther)
{
		const Quantity_Date &  _anOther =*(const Quantity_Date *)anOther;
	Quantity_Date* result = (Quantity_Date*)instance;
	return  	result->IsEqual(			
_anOther);
}
DECL_EXPORT bool Quantity_Date_IsEarlier4AE38D5E(
	void* instance,
	void* anOther)
{
		const Quantity_Date &  _anOther =*(const Quantity_Date *)anOther;
	Quantity_Date* result = (Quantity_Date*)instance;
	return  	result->IsEarlier(			
_anOther);
}
DECL_EXPORT bool Quantity_Date_IsLater4AE38D5E(
	void* instance,
	void* anOther)
{
		const Quantity_Date &  _anOther =*(const Quantity_Date *)anOther;
	Quantity_Date* result = (Quantity_Date*)instance;
	return  	result->IsLater(			
_anOther);
}
DECL_EXPORT bool Quantity_Date_IsValid24458BB5(
	int mm,
	int dd,
	int yy,
	int hh,
	int mn,
	int ss,
	int mis,
	int mics)
{
	return  Quantity_Date::IsValid(			
mm,			
dd,			
yy,			
hh,			
mn,			
ss,			
mis,			
mics);
}
DECL_EXPORT bool Quantity_Date_IsLeapE8219145(
	int yy)
{
	return  Quantity_Date::IsLeap(			
yy);
}
DECL_EXPORT int Quantity_Date_Year(void* instance)
{
	Quantity_Date* result = (Quantity_Date*)instance;
	return 	result->Year();
}

DECL_EXPORT int Quantity_Date_Month(void* instance)
{
	Quantity_Date* result = (Quantity_Date*)instance;
	return 	result->Month();
}

DECL_EXPORT int Quantity_Date_Day(void* instance)
{
	Quantity_Date* result = (Quantity_Date*)instance;
	return 	result->Day();
}

DECL_EXPORT int Quantity_Date_Hour(void* instance)
{
	Quantity_Date* result = (Quantity_Date*)instance;
	return 	result->Hour();
}

DECL_EXPORT int Quantity_Date_Minute(void* instance)
{
	Quantity_Date* result = (Quantity_Date*)instance;
	return 	result->Minute();
}

DECL_EXPORT int Quantity_Date_Second(void* instance)
{
	Quantity_Date* result = (Quantity_Date*)instance;
	return 	result->Second();
}

DECL_EXPORT int Quantity_Date_MilliSecond(void* instance)
{
	Quantity_Date* result = (Quantity_Date*)instance;
	return 	result->MilliSecond();
}

DECL_EXPORT int Quantity_Date_MicroSecond(void* instance)
{
	Quantity_Date* result = (Quantity_Date*)instance;
	return 	result->MicroSecond();
}

DECL_EXPORT void QuantityDate_Dtor(void* instance)
{
	delete (Quantity_Date*)instance;
}
