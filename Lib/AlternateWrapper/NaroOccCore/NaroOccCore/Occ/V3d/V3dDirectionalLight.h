#ifndef V3d_DirectionalLight_H
#define V3d_DirectionalLight_H

#include "../../Export_Import.h"

extern "C" DECL_EXPORT void* V3d_DirectionalLight_Ctor83D2E67B(
	void* VM,
	int Direction,
	int Color,
	bool Headlight);
extern "C" DECL_EXPORT void* V3d_DirectionalLight_CtorEB2CC882(
	void* VM,
	double Xt,
	double Yt,
	double Zt,
	double Xp,
	double Yp,
	double Zp,
	int Color,
	bool Headlight);
extern "C" DECL_EXPORT void V3d_DirectionalLight_SetDirection17AA5025(
	void* instance,
	int Direction);
extern "C" DECL_EXPORT void V3d_DirectionalLight_SetDirection9282A951(
	void* instance,
	double Xm,
	double Ym,
	double Zm);
extern "C" DECL_EXPORT void V3d_DirectionalLight_SetDisplayPosition9282A951(
	void* instance,
	double X,
	double Y,
	double Z);
extern "C" DECL_EXPORT void V3d_DirectionalLight_SetPosition9282A951(
	void* instance,
	double Xp,
	double Yp,
	double Zp);
extern "C" DECL_EXPORT void V3d_DirectionalLight_DisplayF5FC77BB(
	void* instance,
	void* aView,
	int Representation);
extern "C" DECL_EXPORT void V3d_DirectionalLight_Position9282A951(
	void* instance,
	double* X,
	double* Y,
	double* Z);
extern "C" DECL_EXPORT void V3d_DirectionalLight_DisplayPosition9282A951(
	void* instance,
	double* X,
	double* Y,
	double* Z);
extern "C" DECL_EXPORT void V3d_DirectionalLight_Direction9282A951(
	void* instance,
	double* Vx,
	double* Vy,
	double* Vz);
extern "C" DECL_EXPORT void V3dDirectionalLight_Dtor(void* instance);

#endif
