#ifndef Quantity_Date_H
#define Quantity_Date_H

#include "../../Export_Import.h"

extern "C" DECL_EXPORT void* Quantity_Date_Ctor();
extern "C" DECL_EXPORT void* Quantity_Date_Ctor24458BB5(
	int mm,
	int dd,
	int yyyy,
	int hh,
	int mn,
	int ss,
	int mis,
	int mics);
extern "C" DECL_EXPORT void Quantity_Date_Values24458BB5(
	void* instance,
	int* mm,
	int* dd,
	int* yy,
	int* hh,
	int* mn,
	int* ss,
	int* mis,
	int* mics);
extern "C" DECL_EXPORT void Quantity_Date_SetValues24458BB5(
	void* instance,
	int mm,
	int dd,
	int yy,
	int hh,
	int mn,
	int ss,
	int mis,
	int mics);
extern "C" DECL_EXPORT void* Quantity_Date_Difference4AE38D5E(
	void* instance,
	void* anOther);
extern "C" DECL_EXPORT void* Quantity_Date_Subtract22BB0292(
	void* instance,
	void* aPeriod);
extern "C" DECL_EXPORT void* Quantity_Date_Add22BB0292(
	void* instance,
	void* aPeriod);
extern "C" DECL_EXPORT bool Quantity_Date_IsEqual4AE38D5E(
	void* instance,
	void* anOther);
extern "C" DECL_EXPORT bool Quantity_Date_IsEarlier4AE38D5E(
	void* instance,
	void* anOther);
extern "C" DECL_EXPORT bool Quantity_Date_IsLater4AE38D5E(
	void* instance,
	void* anOther);
extern "C" DECL_EXPORT bool Quantity_Date_IsValid24458BB5(
	int mm,
	int dd,
	int yy,
	int hh,
	int mn,
	int ss,
	int mis,
	int mics);
extern "C" DECL_EXPORT bool Quantity_Date_IsLeapE8219145(
	int yy);
extern "C" DECL_EXPORT int Quantity_Date_Year(void* instance);
extern "C" DECL_EXPORT int Quantity_Date_Month(void* instance);
extern "C" DECL_EXPORT int Quantity_Date_Day(void* instance);
extern "C" DECL_EXPORT int Quantity_Date_Hour(void* instance);
extern "C" DECL_EXPORT int Quantity_Date_Minute(void* instance);
extern "C" DECL_EXPORT int Quantity_Date_Second(void* instance);
extern "C" DECL_EXPORT int Quantity_Date_MilliSecond(void* instance);
extern "C" DECL_EXPORT int Quantity_Date_MicroSecond(void* instance);
extern "C" DECL_EXPORT void QuantityDate_Dtor(void* instance);

#endif
