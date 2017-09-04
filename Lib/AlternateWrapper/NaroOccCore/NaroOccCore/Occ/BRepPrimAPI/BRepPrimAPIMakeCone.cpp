#include "BRepPrimAPIMakeCone.h"
#include <BRepPrimAPI_MakeCone.hxx>


DECL_EXPORT void* BRepPrimAPI_MakeCone_Ctor9282A951(
	double R1,
	double R2,
	double H)
{
	return new BRepPrimAPI_MakeCone(			
R1,			
R2,			
H);
}
DECL_EXPORT void* BRepPrimAPI_MakeCone_CtorC2777E0C(
	double R1,
	double R2,
	double H,
	double angle)
{
	return new BRepPrimAPI_MakeCone(			
R1,			
R2,			
H,			
angle);
}
DECL_EXPORT void* BRepPrimAPI_MakeCone_CtorF0200AF(
	void* Axes,
	double R1,
	double R2,
	double H)
{
		const gp_Ax2 &  _Axes =*(const gp_Ax2 *)Axes;
	return new BRepPrimAPI_MakeCone(			
_Axes,			
R1,			
R2,			
H);
}
DECL_EXPORT void* BRepPrimAPI_MakeCone_Ctor77315A3D(
	void* Axes,
	double R1,
	double R2,
	double H,
	double angle)
{
		const gp_Ax2 &  _Axes =*(const gp_Ax2 *)Axes;
	return new BRepPrimAPI_MakeCone(			
_Axes,			
R1,			
R2,			
H,			
angle);
}
DECL_EXPORT void* BRepPrimAPI_MakeCone_OneAxis(void* instance)
{
	BRepPrimAPI_MakeCone* result = (BRepPrimAPI_MakeCone*)instance;
	return 	result->OneAxis();
}

DECL_EXPORT void BRepPrimAPIMakeCone_Dtor(void* instance)
{
	delete (BRepPrimAPI_MakeCone*)instance;
}
