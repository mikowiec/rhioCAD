#ifndef Message_ProgressScale_H
#define Message_ProgressScale_H

#include "../../Export_Import.h"

extern "C" DECL_EXPORT void* Message_ProgressScale_Ctor();
extern "C" DECL_EXPORT void Message_ProgressScale_SetName9381D4D(
	void* instance,
	char* theName);
extern "C" DECL_EXPORT void Message_ProgressScale_SetNameB439B3D5(
	void* instance,
	void* theName);
extern "C" DECL_EXPORT void Message_ProgressScale_SetRange9F0E714F(
	void* instance,
	double min,
	double max);
extern "C" DECL_EXPORT void Message_ProgressScale_SetScale1B801FD4(
	void* instance,
	double min,
	double max,
	double step,
	bool theInfinite);
extern "C" DECL_EXPORT void Message_ProgressScale_SetSpan9F0E714F(
	void* instance,
	double first,
	double last);
extern "C" DECL_EXPORT double Message_ProgressScale_LocalToBaseD82819F3(
	void* instance,
	double val);
extern "C" DECL_EXPORT double Message_ProgressScale_BaseToLocalD82819F3(
	void* instance,
	double val);
extern "C" DECL_EXPORT void* Message_ProgressScale_GetName(void* instance);
extern "C" DECL_EXPORT void Message_ProgressScale_SetMin(void* instance, double value);
extern "C" DECL_EXPORT double Message_ProgressScale_GetMin(void* instance);
extern "C" DECL_EXPORT void Message_ProgressScale_SetMax(void* instance, double value);
extern "C" DECL_EXPORT double Message_ProgressScale_GetMax(void* instance);
extern "C" DECL_EXPORT void Message_ProgressScale_SetStep(void* instance, double value);
extern "C" DECL_EXPORT double Message_ProgressScale_GetStep(void* instance);
extern "C" DECL_EXPORT void Message_ProgressScale_SetInfinite(void* instance, bool value);
extern "C" DECL_EXPORT bool Message_ProgressScale_GetInfinite(void* instance);
extern "C" DECL_EXPORT double Message_ProgressScale_GetFirst(void* instance);
extern "C" DECL_EXPORT double Message_ProgressScale_GetLast(void* instance);
extern "C" DECL_EXPORT void MessageProgressScale_Dtor(void* instance);

#endif
