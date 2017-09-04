#ifndef TColStd_SequenceOfInteger_H
#define TColStd_SequenceOfInteger_H

#include "../../Export_Import.h"

extern "C" DECL_EXPORT void* TColStd_SequenceOfInteger_Ctor();
extern "C" DECL_EXPORT void* TColStd_SequenceOfInteger_AssignE22FA26(
	void* instance,
	void* Other);
extern "C" DECL_EXPORT void TColStd_SequenceOfInteger_AppendE8219145(
	void* instance,
	int T);
extern "C" DECL_EXPORT void TColStd_SequenceOfInteger_AppendE22FA26(
	void* instance,
	void* S);
extern "C" DECL_EXPORT void TColStd_SequenceOfInteger_PrependE8219145(
	void* instance,
	int T);
extern "C" DECL_EXPORT void TColStd_SequenceOfInteger_PrependE22FA26(
	void* instance,
	void* S);
extern "C" DECL_EXPORT void TColStd_SequenceOfInteger_InsertBefore5107F6FE(
	void* instance,
	int Index,
	int T);
extern "C" DECL_EXPORT void TColStd_SequenceOfInteger_InsertBefore20E7A93A(
	void* instance,
	int Index,
	void* S);
extern "C" DECL_EXPORT void TColStd_SequenceOfInteger_InsertAfter5107F6FE(
	void* instance,
	int Index,
	int T);
extern "C" DECL_EXPORT void TColStd_SequenceOfInteger_InsertAfter20E7A93A(
	void* instance,
	int Index,
	void* S);
extern "C" DECL_EXPORT void TColStd_SequenceOfInteger_Split20E7A93A(
	void* instance,
	int Index,
	void* Sub);
extern "C" DECL_EXPORT int TColStd_SequenceOfInteger_ValueE8219145(
	void* instance,
	int Index);
extern "C" DECL_EXPORT void TColStd_SequenceOfInteger_SetValue5107F6FE(
	void* instance,
	int Index,
	int I);
extern "C" DECL_EXPORT int TColStd_SequenceOfInteger_ChangeValueE8219145(
	void* instance,
	int Index);
extern "C" DECL_EXPORT void TColStd_SequenceOfInteger_RemoveE8219145(
	void* instance,
	int Index);
extern "C" DECL_EXPORT void TColStd_SequenceOfInteger_Remove5107F6FE(
	void* instance,
	int FromIndex,
	int ToIndex);
extern "C" DECL_EXPORT int TColStd_SequenceOfInteger_First(void* instance);
extern "C" DECL_EXPORT int TColStd_SequenceOfInteger_Last(void* instance);
extern "C" DECL_EXPORT void TColStdSequenceOfInteger_Dtor(void* instance);

#endif
