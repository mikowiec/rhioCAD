#ifndef V3d_PositionLight_H
#define V3d_PositionLight_H

#include "../../Export_Import.h"

extern "C" DECL_EXPORT void V3d_PositionLight_SetTarget9282A951(
	void* instance,
	double X,
	double Y,
	double Z);
extern "C" DECL_EXPORT void V3d_PositionLight_OnHideFace36A6FAB7(
	void* instance,
	void* aView);
extern "C" DECL_EXPORT void V3d_PositionLight_OnSeeFace36A6FAB7(
	void* instance,
	void* aView);
extern "C" DECL_EXPORT void V3d_PositionLight_TrackingA941FC63(
	void* instance,
	void* aView,
	int WathPick,
	int Xpix,
	int Ypix);
extern "C" DECL_EXPORT void V3d_PositionLight_DisplayF5FC77BB(
	void* instance,
	void* aView,
	int Representation);
extern "C" DECL_EXPORT void V3d_PositionLight_Erase(void* instance);
extern "C" DECL_EXPORT bool V3d_PositionLight_SeeOrHide36A6FAB7(
	void* instance,
	void* aView);
extern "C" DECL_EXPORT void V3d_PositionLight_Target9282A951(
	void* instance,
	double* X,
	double* Y,
	double* Z);
extern "C" DECL_EXPORT void V3d_PositionLight_SetRadius(void* instance, double value);
extern "C" DECL_EXPORT double V3d_PositionLight_Radius(void* instance);
extern "C" DECL_EXPORT void V3dPositionLight_Dtor(void* instance);

#endif
