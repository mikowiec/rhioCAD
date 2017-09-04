#ifndef Message_ProgressIndicator_H
#define Message_ProgressIndicator_H

#include "../../Export_Import.h"

extern "C" DECL_EXPORT void Message_ProgressIndicator_Reset(void* instance);
extern "C" DECL_EXPORT void Message_ProgressIndicator_SetName9381D4D(
	void* instance,
	char* name);
extern "C" DECL_EXPORT void Message_ProgressIndicator_SetNameB439B3D5(
	void* instance,
	void* name);
extern "C" DECL_EXPORT void Message_ProgressIndicator_SetRange9F0E714F(
	void* instance,
	double min,
	double max);
extern "C" DECL_EXPORT void Message_ProgressIndicator_SetScale13FE3006(
	void* instance,
	char* name,
	double min,
	double max,
	double step,
	bool isInf);
extern "C" DECL_EXPORT void Message_ProgressIndicator_SetScale1B801FD4(
	void* instance,
	double min,
	double max,
	double step,
	bool isInf);
extern "C" DECL_EXPORT void Message_ProgressIndicator_Increment(void* instance);
extern "C" DECL_EXPORT void Message_ProgressIndicator_IncrementD82819F3(
	void* instance,
	double step);
extern "C" DECL_EXPORT bool Message_ProgressIndicator_NewScope9381D4D(
	void* instance,
	char* name);
extern "C" DECL_EXPORT bool Message_ProgressIndicator_NewScopeB439B3D5(
	void* instance,
	void* name);
extern "C" DECL_EXPORT bool Message_ProgressIndicator_NewScopeFEB27313(
	void* instance,
	double span,
	char* name);
extern "C" DECL_EXPORT bool Message_ProgressIndicator_NewScope9A242015(
	void* instance,
	double span,
	void* name);
extern "C" DECL_EXPORT bool Message_ProgressIndicator_NextScope9381D4D(
	void* instance,
	char* name);
extern "C" DECL_EXPORT bool Message_ProgressIndicator_NextScopeFEB27313(
	void* instance,
	double span,
	char* name);
extern "C" DECL_EXPORT void* Message_ProgressIndicator_GetScopeE8219145(
	void* instance,
	int index);
extern "C" DECL_EXPORT void Message_ProgressIndicator_SetStep(void* instance, double value);
extern "C" DECL_EXPORT void Message_ProgressIndicator_SetInfinite(void* instance, bool value);
extern "C" DECL_EXPORT void Message_ProgressIndicator_SetValue(void* instance, double value);
extern "C" DECL_EXPORT double Message_ProgressIndicator_GetValue(void* instance);
extern "C" DECL_EXPORT bool Message_ProgressIndicator_EndScope(void* instance);
extern "C" DECL_EXPORT bool Message_ProgressIndicator_UserBreak(void* instance);
extern "C" DECL_EXPORT double Message_ProgressIndicator_GetPosition(void* instance);
extern "C" DECL_EXPORT int Message_ProgressIndicator_GetNbScopes(void* instance);
extern "C" DECL_EXPORT void MessageProgressIndicator_Dtor(void* instance);

#endif
