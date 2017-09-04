#include "gpDir.h"
#include <gp_Dir.hxx>

#include <gp_Dir.hxx>
#include <gp_XYZ.hxx>

DECL_EXPORT void* gp_Dir_Ctor()
{
	return new gp_Dir();
}
DECL_EXPORT void* gp_Dir_Ctor9BD9CFFE(
	void* V)
{
		const gp_Vec &  _V =*(const gp_Vec *)V;
	return new gp_Dir(			
_V);
}
DECL_EXPORT void* gp_Dir_Ctor8EE42329(
	void* Coord)
{
		const gp_XYZ &  _Coord =*(const gp_XYZ *)Coord;
	return new gp_Dir(			
_Coord);
}
DECL_EXPORT void* gp_Dir_Ctor9282A951(
	double Xv,
	double Yv,
	double Zv)
{
	return new gp_Dir(			
Xv,			
Yv,			
Zv);
}
DECL_EXPORT void gp_Dir_SetCoord69F5FCCD(
	void* instance,
	int Index,
	double Xi)
{
	gp_Dir* result = (gp_Dir*)instance;
 	result->SetCoord(			
Index,			
Xi);
}
DECL_EXPORT void gp_Dir_SetCoord9282A951(
	void* instance,
	double Xv,
	double Yv,
	double Zv)
{
	gp_Dir* result = (gp_Dir*)instance;
 	result->SetCoord(			
Xv,			
Yv,			
Zv);
}
DECL_EXPORT double gp_Dir_CoordE8219145(
	void* instance,
	int Index)
{
	gp_Dir* result = (gp_Dir*)instance;
	return  	result->Coord(			
Index);
}
DECL_EXPORT void gp_Dir_Coord9282A951(
	void* instance,
	double* Xv,
	double* Yv,
	double* Zv)
{
	gp_Dir* result = (gp_Dir*)instance;
 	result->Coord(			
*Xv,			
*Yv,			
*Zv);
}
DECL_EXPORT bool gp_Dir_IsEqual1924C304(
	void* instance,
	void* Other,
	double AngularTolerance)
{
		const gp_Dir &  _Other =*(const gp_Dir *)Other;
	gp_Dir* result = (gp_Dir*)instance;
	return  	result->IsEqual(			
_Other,			
AngularTolerance);
}
DECL_EXPORT bool gp_Dir_IsNormal1924C304(
	void* instance,
	void* Other,
	double AngularTolerance)
{
		const gp_Dir &  _Other =*(const gp_Dir *)Other;
	gp_Dir* result = (gp_Dir*)instance;
	return  	result->IsNormal(			
_Other,			
AngularTolerance);
}
DECL_EXPORT bool gp_Dir_IsOpposite1924C304(
	void* instance,
	void* Other,
	double AngularTolerance)
{
		const gp_Dir &  _Other =*(const gp_Dir *)Other;
	gp_Dir* result = (gp_Dir*)instance;
	return  	result->IsOpposite(			
_Other,			
AngularTolerance);
}
DECL_EXPORT bool gp_Dir_IsParallel1924C304(
	void* instance,
	void* Other,
	double AngularTolerance)
{
		const gp_Dir &  _Other =*(const gp_Dir *)Other;
	gp_Dir* result = (gp_Dir*)instance;
	return  	result->IsParallel(			
_Other,			
AngularTolerance);
}
DECL_EXPORT double gp_Dir_AngleCEC711A5(
	void* instance,
	void* Other)
{
		const gp_Dir &  _Other =*(const gp_Dir *)Other;
	gp_Dir* result = (gp_Dir*)instance;
	return  	result->Angle(			
_Other);
}
DECL_EXPORT double gp_Dir_AngleWithRef8BEC0F26(
	void* instance,
	void* Other,
	void* VRef)
{
		const gp_Dir &  _Other =*(const gp_Dir *)Other;
		const gp_Dir &  _VRef =*(const gp_Dir *)VRef;
	gp_Dir* result = (gp_Dir*)instance;
	return  	result->AngleWithRef(			
_Other,			
_VRef);
}
DECL_EXPORT void gp_Dir_CrossCEC711A5(
	void* instance,
	void* Right)
{
		const gp_Dir &  _Right =*(const gp_Dir *)Right;
	gp_Dir* result = (gp_Dir*)instance;
 	result->Cross(			
_Right);
}
DECL_EXPORT void* gp_Dir_CrossedCEC711A5(
	void* instance,
	void* Right)
{
		const gp_Dir &  _Right =*(const gp_Dir *)Right;
	gp_Dir* result = (gp_Dir*)instance;
	return new gp_Dir( 	result->Crossed(			
_Right));
}
DECL_EXPORT void gp_Dir_CrossCross8BEC0F26(
	void* instance,
	void* V1,
	void* V2)
{
		const gp_Dir &  _V1 =*(const gp_Dir *)V1;
		const gp_Dir &  _V2 =*(const gp_Dir *)V2;
	gp_Dir* result = (gp_Dir*)instance;
 	result->CrossCross(			
_V1,			
_V2);
}
DECL_EXPORT void* gp_Dir_CrossCrossed8BEC0F26(
	void* instance,
	void* V1,
	void* V2)
{
		const gp_Dir &  _V1 =*(const gp_Dir *)V1;
		const gp_Dir &  _V2 =*(const gp_Dir *)V2;
	gp_Dir* result = (gp_Dir*)instance;
	return new gp_Dir( 	result->CrossCrossed(			
_V1,			
_V2));
}
DECL_EXPORT double gp_Dir_DotCEC711A5(
	void* instance,
	void* Other)
{
		const gp_Dir &  _Other =*(const gp_Dir *)Other;
	gp_Dir* result = (gp_Dir*)instance;
	return  	result->Dot(			
_Other);
}
DECL_EXPORT double gp_Dir_DotCross8BEC0F26(
	void* instance,
	void* V1,
	void* V2)
{
		const gp_Dir &  _V1 =*(const gp_Dir *)V1;
		const gp_Dir &  _V2 =*(const gp_Dir *)V2;
	gp_Dir* result = (gp_Dir*)instance;
	return  	result->DotCross(			
_V1,			
_V2);
}
DECL_EXPORT void gp_Dir_Reverse(void* instance)
{
	gp_Dir* result = (gp_Dir*)instance;
 	result->Reverse();
}
DECL_EXPORT void gp_Dir_MirrorCEC711A5(
	void* instance,
	void* V)
{
		const gp_Dir &  _V =*(const gp_Dir *)V;
	gp_Dir* result = (gp_Dir*)instance;
 	result->Mirror(			
_V);
}
DECL_EXPORT void* gp_Dir_MirroredCEC711A5(
	void* instance,
	void* V)
{
		const gp_Dir &  _V =*(const gp_Dir *)V;
	gp_Dir* result = (gp_Dir*)instance;
	return new gp_Dir( 	result->Mirrored(			
_V));
}
DECL_EXPORT void gp_Dir_Mirror608B963B(
	void* instance,
	void* A1)
{
		const gp_Ax1 &  _A1 =*(const gp_Ax1 *)A1;
	gp_Dir* result = (gp_Dir*)instance;
 	result->Mirror(			
_A1);
}
DECL_EXPORT void* gp_Dir_Mirrored608B963B(
	void* instance,
	void* A1)
{
		const gp_Ax1 &  _A1 =*(const gp_Ax1 *)A1;
	gp_Dir* result = (gp_Dir*)instance;
	return new gp_Dir( 	result->Mirrored(			
_A1));
}
DECL_EXPORT void gp_Dir_Mirror7895386A(
	void* instance,
	void* A2)
{
		const gp_Ax2 &  _A2 =*(const gp_Ax2 *)A2;
	gp_Dir* result = (gp_Dir*)instance;
 	result->Mirror(			
_A2);
}
DECL_EXPORT void* gp_Dir_Mirrored7895386A(
	void* instance,
	void* A2)
{
		const gp_Ax2 &  _A2 =*(const gp_Ax2 *)A2;
	gp_Dir* result = (gp_Dir*)instance;
	return new gp_Dir( 	result->Mirrored(			
_A2));
}
DECL_EXPORT void gp_Dir_Rotate827CB19A(
	void* instance,
	void* A1,
	double Ang)
{
		const gp_Ax1 &  _A1 =*(const gp_Ax1 *)A1;
	gp_Dir* result = (gp_Dir*)instance;
 	result->Rotate(			
_A1,			
Ang);
}
DECL_EXPORT void* gp_Dir_Rotated827CB19A(
	void* instance,
	void* A1,
	double Ang)
{
		const gp_Ax1 &  _A1 =*(const gp_Ax1 *)A1;
	gp_Dir* result = (gp_Dir*)instance;
	return new gp_Dir( 	result->Rotated(			
_A1,			
Ang));
}
DECL_EXPORT void gp_Dir_Transform72D78650(
	void* instance,
	void* T)
{
		const gp_Trsf &  _T =*(const gp_Trsf *)T;
	gp_Dir* result = (gp_Dir*)instance;
 	result->Transform(			
_T);
}
DECL_EXPORT void* gp_Dir_Transformed72D78650(
	void* instance,
	void* T)
{
		const gp_Trsf &  _T =*(const gp_Trsf *)T;
	gp_Dir* result = (gp_Dir*)instance;
	return new gp_Dir( 	result->Transformed(			
_T));
}
DECL_EXPORT void gp_Dir_SetX(void* instance, double value)
{
	gp_Dir* result = (gp_Dir*)instance;
		result->SetX(value);
}

DECL_EXPORT double gp_Dir_X(void* instance)
{
	gp_Dir* result = (gp_Dir*)instance;
	return 	result->X();
}

DECL_EXPORT void gp_Dir_SetY(void* instance, double value)
{
	gp_Dir* result = (gp_Dir*)instance;
		result->SetY(value);
}

DECL_EXPORT double gp_Dir_Y(void* instance)
{
	gp_Dir* result = (gp_Dir*)instance;
	return 	result->Y();
}

DECL_EXPORT void gp_Dir_SetZ(void* instance, double value)
{
	gp_Dir* result = (gp_Dir*)instance;
		result->SetZ(value);
}

DECL_EXPORT double gp_Dir_Z(void* instance)
{
	gp_Dir* result = (gp_Dir*)instance;
	return 	result->Z();
}

DECL_EXPORT void gp_Dir_SetXYZ(void* instance, void* value)
{
	gp_Dir* result = (gp_Dir*)instance;
		result->SetXYZ(*(const gp_XYZ *)value);
}

DECL_EXPORT void* gp_Dir_XYZ(void* instance)
{
	gp_Dir* result = (gp_Dir*)instance;
	return 	new gp_XYZ(	result->XYZ());
}

DECL_EXPORT void* gp_Dir_Reversed(void* instance)
{
	gp_Dir* result = (gp_Dir*)instance;
	return 	new gp_Dir(	result->Reversed());
}

DECL_EXPORT void gpDir_Dtor(void* instance)
{
	delete (gp_Dir*)instance;
}
