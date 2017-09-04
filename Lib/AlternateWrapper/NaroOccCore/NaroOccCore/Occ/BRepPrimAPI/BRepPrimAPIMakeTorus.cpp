#include "BRepPrimAPIMakeTorus.h"
#include <BRepPrimAPI_MakeTorus.hxx>


DECL_EXPORT void* BRepPrimAPI_MakeTorus_Ctor9F0E714F(
	double R1,
	double R2)
{
	return new BRepPrimAPI_MakeTorus(			
R1,			
R2);
}
DECL_EXPORT void* BRepPrimAPI_MakeTorus_Ctor9282A951(
	double R1,
	double R2,
	double angle)
{
	return new BRepPrimAPI_MakeTorus(			
R1,			
R2,			
angle);
}
DECL_EXPORT void* BRepPrimAPI_MakeTorus_CtorC2777E0C(
	double R1,
	double R2,
	double angle1,
	double angle2)
{
	return new BRepPrimAPI_MakeTorus(			
R1,			
R2,			
angle1,			
angle2);
}
DECL_EXPORT void* BRepPrimAPI_MakeTorus_Ctor216AF150(
	double R1,
	double R2,
	double angle1,
	double angle2,
	double angle)
{
	return new BRepPrimAPI_MakeTorus(			
R1,			
R2,			
angle1,			
angle2,			
angle);
}
DECL_EXPORT void* BRepPrimAPI_MakeTorus_CtorB1A3BD2A(
	void* Axes,
	double R1,
	double R2)
{
		const gp_Ax2 &  _Axes =*(const gp_Ax2 *)Axes;
	return new BRepPrimAPI_MakeTorus(			
_Axes,			
R1,			
R2);
}
DECL_EXPORT void* BRepPrimAPI_MakeTorus_CtorF0200AF(
	void* Axes,
	double R1,
	double R2,
	double angle)
{
		const gp_Ax2 &  _Axes =*(const gp_Ax2 *)Axes;
	return new BRepPrimAPI_MakeTorus(			
_Axes,			
R1,			
R2,			
angle);
}
DECL_EXPORT void* BRepPrimAPI_MakeTorus_Ctor77315A3D(
	void* Axes,
	double R1,
	double R2,
	double angle1,
	double angle2)
{
		const gp_Ax2 &  _Axes =*(const gp_Ax2 *)Axes;
	return new BRepPrimAPI_MakeTorus(			
_Axes,			
R1,			
R2,			
angle1,			
angle2);
}
DECL_EXPORT void* BRepPrimAPI_MakeTorus_CtorDC3808AF(
	void* Axes,
	double R1,
	double R2,
	double angle1,
	double angle2,
	double angle)
{
		const gp_Ax2 &  _Axes =*(const gp_Ax2 *)Axes;
	return new BRepPrimAPI_MakeTorus(			
_Axes,			
R1,			
R2,			
angle1,			
angle2,			
angle);
}
DECL_EXPORT void* BRepPrimAPI_MakeTorus_OneAxis(void* instance)
{
	BRepPrimAPI_MakeTorus* result = (BRepPrimAPI_MakeTorus*)instance;
	return 	result->OneAxis();
}

DECL_EXPORT void BRepPrimAPIMakeTorus_Dtor(void* instance)
{
	delete (BRepPrimAPI_MakeTorus*)instance;
}
