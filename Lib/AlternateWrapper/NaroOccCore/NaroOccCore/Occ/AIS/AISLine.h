#ifndef AIS_Line_H
#define AIS_Line_H

#include "../../Export_Import.h"

extern "C" DECL_EXPORT void* AIS_Line_Ctor7C3C08A3(
	void* aLine);
extern "C" DECL_EXPORT void* AIS_Line_Ctor2A4E6D38(
	void* aStartPoint,
	void* aEndPoint);
extern "C" DECL_EXPORT void AIS_Line_Points2A4E6D38(
	void* instance,
	void* PStart,
	void* PEnd);
extern "C" DECL_EXPORT void AIS_Line_SetPoints2A4E6D38(
	void* instance,
	void* P1,
	void* P2);
extern "C" DECL_EXPORT void AIS_Line_SetColor48F4F471(
	void* instance,
	int aColor);
extern "C" DECL_EXPORT void AIS_Line_SetColor8FD7F48(
	void* instance,
	void* aColor);
extern "C" DECL_EXPORT void AIS_Line_UnsetColor(void* instance);
extern "C" DECL_EXPORT void AIS_Line_UnsetWidth(void* instance);
extern "C" DECL_EXPORT int AIS_Line_Signature(void* instance);
extern "C" DECL_EXPORT int AIS_Line_Type(void* instance);
extern "C" DECL_EXPORT void AIS_Line_SetLine(void* instance, void* value);
extern "C" DECL_EXPORT void* AIS_Line_Line(void* instance);
extern "C" DECL_EXPORT void AIS_Line_SetWidth(void* instance, double value);
extern "C" DECL_EXPORT void AISLine_Dtor(void* instance);

#endif
