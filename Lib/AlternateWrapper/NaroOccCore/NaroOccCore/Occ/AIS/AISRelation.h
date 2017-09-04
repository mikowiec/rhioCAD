#ifndef AIS_Relation_H
#define AIS_Relation_H

#include "../../Export_Import.h"

extern "C" DECL_EXPORT void AIS_Relation_SetColor48F4F471(
	void* instance,
	int aColor);
extern "C" DECL_EXPORT void AIS_Relation_SetColor8FD7F48(
	void* instance,
	void* aColor);
extern "C" DECL_EXPORT void AIS_Relation_UnsetColor(void* instance);
extern "C" DECL_EXPORT void AIS_Relation_SetBndBoxBC7A5786(
	void* instance,
	double Xmin,
	double Ymin,
	double Zmin,
	double Xmax,
	double Ymax,
	double Zmax);
extern "C" DECL_EXPORT void AIS_Relation_UnsetBndBox(void* instance);
extern "C" DECL_EXPORT bool AIS_Relation_AcceptDisplayModeE8219145(
	void* instance,
	int aMode);
extern "C" DECL_EXPORT int AIS_Relation_Type(void* instance);
extern "C" DECL_EXPORT int AIS_Relation_KindOfDimension(void* instance);
extern "C" DECL_EXPORT bool AIS_Relation_IsMovable(void* instance);
extern "C" DECL_EXPORT void AIS_Relation_SetFirstShape(void* instance, void* value);
extern "C" DECL_EXPORT void* AIS_Relation_FirstShape(void* instance);
extern "C" DECL_EXPORT void AIS_Relation_SetSecondShape(void* instance, void* value);
extern "C" DECL_EXPORT void* AIS_Relation_SecondShape(void* instance);
extern "C" DECL_EXPORT void AIS_Relation_SetPlane(void* instance, void* value);
extern "C" DECL_EXPORT void* AIS_Relation_Plane(void* instance);
extern "C" DECL_EXPORT void AIS_Relation_SetValue(void* instance, double value);
extern "C" DECL_EXPORT double AIS_Relation_Value(void* instance);
extern "C" DECL_EXPORT void AIS_Relation_SetPosition(void* instance, void* value);
extern "C" DECL_EXPORT void* AIS_Relation_Position(void* instance);
extern "C" DECL_EXPORT void AIS_Relation_SetText(void* instance, void* value);
extern "C" DECL_EXPORT void* AIS_Relation_Text(void* instance);
extern "C" DECL_EXPORT void AIS_Relation_SetArrowSize(void* instance, double value);
extern "C" DECL_EXPORT double AIS_Relation_ArrowSize(void* instance);
extern "C" DECL_EXPORT void AIS_Relation_SetSymbolPrs(void* instance, int value);
extern "C" DECL_EXPORT int AIS_Relation_SymbolPrs(void* instance);
extern "C" DECL_EXPORT void AIS_Relation_SetExtShape(void* instance, int value);
extern "C" DECL_EXPORT int AIS_Relation_ExtShape(void* instance);
extern "C" DECL_EXPORT void AIS_Relation_SetAutomaticPosition(void* instance, bool value);
extern "C" DECL_EXPORT bool AIS_Relation_AutomaticPosition(void* instance);
extern "C" DECL_EXPORT void AISRelation_Dtor(void* instance);

#endif
