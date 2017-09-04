#ifndef BRep_PointRepresentation_H
#define BRep_PointRepresentation_H

#include "../../Export_Import.h"

extern "C" DECL_EXPORT bool BRep_PointRepresentation_IsPointOnCurve(void* instance);
extern "C" DECL_EXPORT bool BRep_PointRepresentation_IsPointOnCurveOnSurface(void* instance);
extern "C" DECL_EXPORT bool BRep_PointRepresentation_IsPointOnSurface(void* instance);
extern "C" DECL_EXPORT bool BRep_PointRepresentation_IsPointOnCurveB3769532(
	void* instance,
	void* C,
	void* L);
extern "C" DECL_EXPORT bool BRep_PointRepresentation_IsPointOnSurface7C521807(
	void* instance,
	void* S,
	void* L);
extern "C" DECL_EXPORT void* BRep_PointRepresentation_Location(void* instance);
extern "C" DECL_EXPORT void BRep_PointRepresentation_Location15DCA881(
	void* instance,
	void* L);
extern "C" DECL_EXPORT double BRep_PointRepresentation_Parameter(void* instance);
extern "C" DECL_EXPORT void BRep_PointRepresentation_ParameterD82819F3(
	void* instance,
	double P);
extern "C" DECL_EXPORT double BRep_PointRepresentation_Parameter2(void* instance);
extern "C" DECL_EXPORT void BRep_PointRepresentation_Parameter2D82819F3(
	void* instance,
	double P);
extern "C" DECL_EXPORT void* BRep_PointRepresentation_Curve(void* instance);
extern "C" DECL_EXPORT void BRep_PointRepresentation_CurveFF608AE4(
	void* instance,
	void* C);
extern "C" DECL_EXPORT void* BRep_PointRepresentation_Surface(void* instance);
extern "C" DECL_EXPORT void BRep_PointRepresentation_Surface9001466F(
	void* instance,
	void* S);
extern "C" DECL_EXPORT void BRepPointRepresentation_Dtor(void* instance);

#endif
