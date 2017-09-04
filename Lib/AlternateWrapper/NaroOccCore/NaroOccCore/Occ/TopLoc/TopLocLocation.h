#ifndef TopLoc_Location_H
#define TopLoc_Location_H

#include "../../Export_Import.h"

extern "C" DECL_EXPORT void* TopLoc_Location_Ctor();
extern "C" DECL_EXPORT void* TopLoc_Location_Ctor72D78650(
	void* T);
extern "C" DECL_EXPORT void* TopLoc_Location_Ctor2F68E136(
	void* D);
extern "C" DECL_EXPORT void TopLoc_Location_Identity(void* instance);
extern "C" DECL_EXPORT void* TopLoc_Location_Multiplied15DCA881(
	void* instance,
	void* Other);
extern "C" DECL_EXPORT void* TopLoc_Location_Divided15DCA881(
	void* instance,
	void* Other);
extern "C" DECL_EXPORT void* TopLoc_Location_Predivided15DCA881(
	void* instance,
	void* Other);
extern "C" DECL_EXPORT void* TopLoc_Location_PoweredE8219145(
	void* instance,
	int pwr);
extern "C" DECL_EXPORT int TopLoc_Location_HashCodeE8219145(
	void* instance,
	int Upper);
extern "C" DECL_EXPORT bool TopLoc_Location_IsEqual15DCA881(
	void* instance,
	void* Other);
extern "C" DECL_EXPORT bool TopLoc_Location_IsDifferent15DCA881(
	void* instance,
	void* Other);
extern "C" DECL_EXPORT bool TopLoc_Location_IsIdentity(void* instance);
extern "C" DECL_EXPORT void* TopLoc_Location_FirstDatum(void* instance);
extern "C" DECL_EXPORT int TopLoc_Location_FirstPower(void* instance);
extern "C" DECL_EXPORT void* TopLoc_Location_NextLocation(void* instance);
extern "C" DECL_EXPORT void* TopLoc_Location_Transformation(void* instance);
extern "C" DECL_EXPORT void* TopLoc_Location_Inverted(void* instance);
extern "C" DECL_EXPORT void TopLocLocation_Dtor(void* instance);

#endif
