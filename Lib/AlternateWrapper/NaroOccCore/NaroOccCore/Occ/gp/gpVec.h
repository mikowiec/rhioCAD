#ifndef gp_Vec_H
#define gp_Vec_H

#include "../../Export_Import.h"

extern "C" DECL_EXPORT void* gp_Vec_Ctor();
extern "C" DECL_EXPORT void* gp_Vec_CtorCEC711A5(
	void* V);
extern "C" DECL_EXPORT void* gp_Vec_Ctor8EE42329(
	void* Coord);
extern "C" DECL_EXPORT void* gp_Vec_Ctor9282A951(
	double Xv,
	double Yv,
	double Zv);
extern "C" DECL_EXPORT void* gp_Vec_Ctor5C63477E(
	void* P1,
	void* P2);
extern "C" DECL_EXPORT void gp_Vec_SetCoord69F5FCCD(
	void* instance,
	int Index,
	double Xi);
extern "C" DECL_EXPORT void gp_Vec_SetCoord9282A951(
	void* instance,
	double Xv,
	double Yv,
	double Zv);
extern "C" DECL_EXPORT double gp_Vec_CoordE8219145(
	void* instance,
	int Index);
extern "C" DECL_EXPORT void gp_Vec_Coord9282A951(
	void* instance,
	double* Xv,
	double* Yv,
	double* Zv);
extern "C" DECL_EXPORT bool gp_Vec_IsEqualB72DB00(
	void* instance,
	void* Other,
	double LinearTolerance,
	double AngularTolerance);
extern "C" DECL_EXPORT bool gp_Vec_IsNormal45D40C1(
	void* instance,
	void* Other,
	double AngularTolerance);
extern "C" DECL_EXPORT bool gp_Vec_IsOpposite45D40C1(
	void* instance,
	void* Other,
	double AngularTolerance);
extern "C" DECL_EXPORT bool gp_Vec_IsParallel45D40C1(
	void* instance,
	void* Other,
	double AngularTolerance);
extern "C" DECL_EXPORT double gp_Vec_Angle9BD9CFFE(
	void* instance,
	void* Other);
extern "C" DECL_EXPORT double gp_Vec_AngleWithRefD5A0F1EC(
	void* instance,
	void* Other,
	void* VRef);
extern "C" DECL_EXPORT void gp_Vec_Add9BD9CFFE(
	void* instance,
	void* Other);
extern "C" DECL_EXPORT void* gp_Vec_Added9BD9CFFE(
	void* instance,
	void* Other);
extern "C" DECL_EXPORT void gp_Vec_Subtract9BD9CFFE(
	void* instance,
	void* Right);
extern "C" DECL_EXPORT void* gp_Vec_Subtracted9BD9CFFE(
	void* instance,
	void* Right);
extern "C" DECL_EXPORT void gp_Vec_MultiplyD82819F3(
	void* instance,
	double Scalar);
extern "C" DECL_EXPORT void* gp_Vec_MultipliedD82819F3(
	void* instance,
	double Scalar);
extern "C" DECL_EXPORT void gp_Vec_DivideD82819F3(
	void* instance,
	double Scalar);
extern "C" DECL_EXPORT void* gp_Vec_DividedD82819F3(
	void* instance,
	double Scalar);
extern "C" DECL_EXPORT void gp_Vec_Cross9BD9CFFE(
	void* instance,
	void* Right);
extern "C" DECL_EXPORT void* gp_Vec_Crossed9BD9CFFE(
	void* instance,
	void* Right);
extern "C" DECL_EXPORT double gp_Vec_CrossMagnitude9BD9CFFE(
	void* instance,
	void* Right);
extern "C" DECL_EXPORT double gp_Vec_CrossSquareMagnitude9BD9CFFE(
	void* instance,
	void* Right);
extern "C" DECL_EXPORT void gp_Vec_CrossCrossD5A0F1EC(
	void* instance,
	void* V1,
	void* V2);
extern "C" DECL_EXPORT void* gp_Vec_CrossCrossedD5A0F1EC(
	void* instance,
	void* V1,
	void* V2);
extern "C" DECL_EXPORT double gp_Vec_Dot9BD9CFFE(
	void* instance,
	void* Other);
extern "C" DECL_EXPORT double gp_Vec_DotCrossD5A0F1EC(
	void* instance,
	void* V1,
	void* V2);
extern "C" DECL_EXPORT void gp_Vec_Normalize(void* instance);
extern "C" DECL_EXPORT void gp_Vec_Reverse(void* instance);
extern "C" DECL_EXPORT void gp_Vec_SetLinearFormC27F2330(
	void* instance,
	double A1,
	void* V1,
	double A2,
	void* V2,
	double A3,
	void* V3,
	void* V4);
extern "C" DECL_EXPORT void gp_Vec_SetLinearForm9A51AB42(
	void* instance,
	double A1,
	void* V1,
	double A2,
	void* V2,
	double A3,
	void* V3);
extern "C" DECL_EXPORT void gp_Vec_SetLinearForm5C2CAE24(
	void* instance,
	double A1,
	void* V1,
	double A2,
	void* V2,
	void* V3);
extern "C" DECL_EXPORT void gp_Vec_SetLinearFormF12FD193(
	void* instance,
	double A1,
	void* V1,
	double A2,
	void* V2);
extern "C" DECL_EXPORT void gp_Vec_SetLinearForm8045255A(
	void* instance,
	double A1,
	void* V1,
	void* V2);
extern "C" DECL_EXPORT void gp_Vec_SetLinearFormD5A0F1EC(
	void* instance,
	void* V1,
	void* V2);
extern "C" DECL_EXPORT void gp_Vec_Mirror9BD9CFFE(
	void* instance,
	void* V);
extern "C" DECL_EXPORT void* gp_Vec_Mirrored9BD9CFFE(
	void* instance,
	void* V);
extern "C" DECL_EXPORT void gp_Vec_Mirror608B963B(
	void* instance,
	void* A1);
extern "C" DECL_EXPORT void* gp_Vec_Mirrored608B963B(
	void* instance,
	void* A1);
extern "C" DECL_EXPORT void gp_Vec_Mirror7895386A(
	void* instance,
	void* A2);
extern "C" DECL_EXPORT void* gp_Vec_Mirrored7895386A(
	void* instance,
	void* A2);
extern "C" DECL_EXPORT void gp_Vec_Rotate827CB19A(
	void* instance,
	void* A1,
	double Ang);
extern "C" DECL_EXPORT void* gp_Vec_Rotated827CB19A(
	void* instance,
	void* A1,
	double Ang);
extern "C" DECL_EXPORT void gp_Vec_ScaleD82819F3(
	void* instance,
	double S);
extern "C" DECL_EXPORT void* gp_Vec_ScaledD82819F3(
	void* instance,
	double S);
extern "C" DECL_EXPORT void gp_Vec_Transform72D78650(
	void* instance,
	void* T);
extern "C" DECL_EXPORT void* gp_Vec_Transformed72D78650(
	void* instance,
	void* T);
extern "C" DECL_EXPORT void gp_Vec_SetX(void* instance, double value);
extern "C" DECL_EXPORT double gp_Vec_X(void* instance);
extern "C" DECL_EXPORT void gp_Vec_SetY(void* instance, double value);
extern "C" DECL_EXPORT double gp_Vec_Y(void* instance);
extern "C" DECL_EXPORT void gp_Vec_SetZ(void* instance, double value);
extern "C" DECL_EXPORT double gp_Vec_Z(void* instance);
extern "C" DECL_EXPORT void gp_Vec_SetXYZ(void* instance, void* value);
extern "C" DECL_EXPORT void* gp_Vec_XYZ(void* instance);
extern "C" DECL_EXPORT double gp_Vec_Magnitude(void* instance);
extern "C" DECL_EXPORT double gp_Vec_SquareMagnitude(void* instance);
extern "C" DECL_EXPORT void* gp_Vec_Normalized(void* instance);
extern "C" DECL_EXPORT void* gp_Vec_Reversed(void* instance);
extern "C" DECL_EXPORT void gpVec_Dtor(void* instance);

#endif
