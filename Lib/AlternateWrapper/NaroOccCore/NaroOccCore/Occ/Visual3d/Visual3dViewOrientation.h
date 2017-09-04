#ifndef Visual3d_ViewOrientation_H
#define Visual3d_ViewOrientation_H

#include "../../Export_Import.h"

extern "C" DECL_EXPORT void* Visual3d_ViewOrientation_Ctor();
extern "C" DECL_EXPORT void* Visual3d_ViewOrientation_Ctor72AC10FF(
	void* VRP,
	void* VPN,
	void* VUP);
extern "C" DECL_EXPORT void* Visual3d_ViewOrientation_CtorBF9B1A1D(
	void* VRP,
	void* VPN,
	double Twist);
extern "C" DECL_EXPORT void* Visual3d_ViewOrientation_Ctor346A1607(
	void* VRP,
	double Azim,
	double Inc,
	double Twist);
extern "C" DECL_EXPORT void Visual3d_ViewOrientation_SetAxialScale9282A951(
	void* instance,
	double Sx,
	double Sy,
	double Sz);
extern "C" DECL_EXPORT void Visual3d_ViewOrientation_AxialScale9282A951(
	void* instance,
	double* Sx,
	double* Sy,
	double* Sz);
extern "C" DECL_EXPORT double Visual3d_ViewOrientation_Twist(void* instance);
extern "C" DECL_EXPORT void Visual3d_ViewOrientation_SetViewReferencePlane(void* instance, void* value);
extern "C" DECL_EXPORT void* Visual3d_ViewOrientation_ViewReferencePlane(void* instance);
extern "C" DECL_EXPORT void Visual3d_ViewOrientation_SetViewReferencePoint(void* instance, void* value);
extern "C" DECL_EXPORT void* Visual3d_ViewOrientation_ViewReferencePoint(void* instance);
extern "C" DECL_EXPORT void Visual3d_ViewOrientation_SetViewReferenceUp(void* instance, void* value);
extern "C" DECL_EXPORT void* Visual3d_ViewOrientation_ViewReferenceUp(void* instance);
extern "C" DECL_EXPORT bool Visual3d_ViewOrientation_IsCustomMatrix(void* instance);
extern "C" DECL_EXPORT void Visual3dViewOrientation_Dtor(void* instance);

#endif
