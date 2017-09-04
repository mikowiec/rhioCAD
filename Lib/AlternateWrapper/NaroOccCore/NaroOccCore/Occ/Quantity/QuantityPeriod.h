#ifndef Quantity_Period_H
#define Quantity_Period_H

#include "../../Export_Import.h"

extern "C" DECL_EXPORT void* Quantity_Period_Ctor9EE4184A(
	int dd,
	int hh,
	int mn,
	int ss,
	int mis,
	int mics);
extern "C" DECL_EXPORT void* Quantity_Period_Ctor5107F6FE(
	int ss,
	int mics);
extern "C" DECL_EXPORT void Quantity_Period_Values9EE4184A(
	void* instance,
	int* dd,
	int* hh,
	int* mn,
	int* ss,
	int* mis,
	int* mics);
extern "C" DECL_EXPORT void Quantity_Period_Values5107F6FE(
	void* instance,
	int* ss,
	int* mics);
extern "C" DECL_EXPORT void Quantity_Period_SetValues9EE4184A(
	void* instance,
	int dd,
	int hh,
	int mn,
	int ss,
	int mis,
	int mics);
extern "C" DECL_EXPORT void Quantity_Period_SetValues5107F6FE(
	void* instance,
	int ss,
	int mics);
extern "C" DECL_EXPORT void* Quantity_Period_Subtract22BB0292(
	void* instance,
	void* anOther);
extern "C" DECL_EXPORT void* Quantity_Period_Add22BB0292(
	void* instance,
	void* anOther);
extern "C" DECL_EXPORT bool Quantity_Period_IsEqual22BB0292(
	void* instance,
	void* anOther);
extern "C" DECL_EXPORT bool Quantity_Period_IsShorter22BB0292(
	void* instance,
	void* anOther);
extern "C" DECL_EXPORT bool Quantity_Period_IsLonger22BB0292(
	void* instance,
	void* anOther);
extern "C" DECL_EXPORT bool Quantity_Period_IsValid9EE4184A(
	int dd,
	int hh,
	int mn,
	int ss,
	int mis,
	int mics);
extern "C" DECL_EXPORT bool Quantity_Period_IsValid5107F6FE(
	int ss,
	int mics);
extern "C" DECL_EXPORT void QuantityPeriod_Dtor(void* instance);

#endif
