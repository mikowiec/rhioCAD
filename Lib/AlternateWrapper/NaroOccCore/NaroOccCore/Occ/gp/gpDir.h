#ifndef gp_Dir_H
#define gp_Dir_H

#include "../../Export_Import.h"

extern "C" DECL_EXPORT void* gp_Dir_Ctor();
extern "C" DECL_EXPORT void* gp_Dir_Ctor9BD9CFFE(
	void* V);
extern "C" DECL_EXPORT void* gp_Dir_Ctor8EE42329(
	void* Coord);
extern "C" DECL_EXPORT void* gp_Dir_Ctor9282A951(
	double Xv,
	double Yv,
	double Zv);
extern "C" DECL_EXPORT void gp_Dir_SetCoord69F5FCCD(
	void* instance,
	int Index,
	double Xi);
extern "C" DECL_EXPORT void gp_Dir_SetCoord9282A951(
	void* instance,
	double Xv,
	double Yv,
	double Zv);
extern "C" DECL_EXPORT double gp_Dir_CoordE8219145(
	void* instance,
	int Index);
extern "C" DECL_EXPORT void gp_Dir_Coord9282A951(
	void* instance,
	double* Xv,
	double* Yv,
	double* Zv);
extern "C" DECL_EXPORT bool gp_Dir_IsEqual1924C304(
	void* instance,
	void* Other,
	double AngularTolerance);
extern "C" DECL_EXPORT bool gp_Dir_IsNormal1924C304(
	void* instance,
	void* Other,
	double AngularTolerance);
extern "C" DECL_EXPORT bool gp_Dir_IsOpposite1924C304(
	void* instance,
	void* Other,
	double AngularTolerance);
extern "C" DECL_EXPORT bool gp_Dir_IsParallel1924C304(
	void* instance,
	void* Other,
	double AngularTolerance);
extern "C" DECL_EXPORT double gp_Dir_AngleCEC711A5(
	void* instance,
	void* Other);
extern "C" DECL_EXPORT double gp_Dir_AngleWithRef8BEC0F26(
	void* instance,
	void* Other,
	void* VRef);
extern "C" DECL_EXPORT void gp_Dir_CrossCEC711A5(
	void* instance,
	void* Right);
extern "C" DECL_EXPORT void* gp_Dir_CrossedCEC711A5(
	void* instance,
	void* Right);
extern "C" DECL_EXPORT void gp_Dir_CrossCross8BEC0F26(
	void* instance,
	void* V1,
	void* V2);
extern "C" DECL_EXPORT void* gp_Dir_CrossCrossed8BEC0F26(
	void* instance,
	void* V1,
	void* V2);
extern "C" DECL_EXPORT double gp_Dir_DotCEC711A5(
	void* instance,
	void* Other);
extern "C" DECL_EXPORT double gp_Dir_DotCross8BEC0F26(
	void* instance,
	void* V1,
	void* V2);
extern "C" DECL_EXPORT void gp_Dir_Reverse(void* instance);
extern "C" DECL_EXPORT void gp_Dir_MirrorCEC711A5(
	void* instance,
	void* V);
extern "C" DECL_EXPORT void* gp_Dir_MirroredCEC711A5(
	void* instance,
	void* V);
extern "C" DECL_EXPORT void gp_Dir_Mirror608B963B(
	void* instance,
	void* A1);
extern "C" DECL_EXPORT void* gp_Dir_Mirrored608B963B(
	void* instance,
	void* A1);
extern "C" DECL_EXPORT void gp_Dir_Mirror7895386A(
	void* instance,
	void* A2);
extern "C" DECL_EXPORT void* gp_Dir_Mirrored7895386A(
	void* instance,
	void* A2);
extern "C" DECL_EXPORT void gp_Dir_Rotate827CB19A(
	void* instance,
	void* A1,
	double Ang);
extern "C" DECL_EXPORT void* gp_Dir_Rotated827CB19A(
	void* instance,
	void* A1,
	double Ang);
extern "C" DECL_EXPORT void gp_Dir_Transform72D78650(
	void* instance,
	void* T);
extern "C" DECL_EXPORT void* gp_Dir_Transformed72D78650(
	void* instance,
	void* T);
extern "C" DECL_EXPORT void gp_Dir_SetX(void* instance, double value);
extern "C" DECL_EXPORT double gp_Dir_X(void* instance);
extern "C" DECL_EXPORT void gp_Dir_SetY(void* instance, double value);
extern "C" DECL_EXPORT double gp_Dir_Y(void* instance);
extern "C" DECL_EXPORT void gp_Dir_SetZ(void* instance, double value);
extern "C" DECL_EXPORT double gp_Dir_Z(void* instance);
extern "C" DECL_EXPORT void gp_Dir_SetXYZ(void* instance, void* value);
extern "C" DECL_EXPORT void* gp_Dir_XYZ(void* instance);
extern "C" DECL_EXPORT void* gp_Dir_Reversed(void* instance);
extern "C" DECL_EXPORT void gpDir_Dtor(void* instance);

#endif
