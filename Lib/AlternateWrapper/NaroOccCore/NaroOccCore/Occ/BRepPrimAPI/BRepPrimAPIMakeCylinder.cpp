#include "BRepPrimAPIMakeCylinder.h"
#include <BRepPrimAPI_MakeCylinder.hxx>


DECL_EXPORT void* BRepPrimAPI_MakeCylinder_Ctor9F0E714F(
	double R,
	double H)
{
	return new BRepPrimAPI_MakeCylinder(			
R,			
H);
}
DECL_EXPORT void* BRepPrimAPI_MakeCylinder_Ctor9282A951(
	double R,
	double H,
	double Angle)
{
	return new BRepPrimAPI_MakeCylinder(			
R,			
H,			
Angle);
}
DECL_EXPORT void* BRepPrimAPI_MakeCylinder_CtorB1A3BD2A(
	void* Axes,
	double R,
	double H)
{
		const gp_Ax2 &  _Axes =*(const gp_Ax2 *)Axes;
	return new BRepPrimAPI_MakeCylinder(			
_Axes,			
R,			
H);
}
DECL_EXPORT void* BRepPrimAPI_MakeCylinder_CtorF0200AF(
	void* Axes,
	double R,
	double H,
	double Angle)
{
		const gp_Ax2 &  _Axes =*(const gp_Ax2 *)Axes;
	return new BRepPrimAPI_MakeCylinder(			
_Axes,			
R,			
H,			
Angle);
}
DECL_EXPORT void* BRepPrimAPI_MakeCylinder_OneAxis(void* instance)
{
	BRepPrimAPI_MakeCylinder* result = (BRepPrimAPI_MakeCylinder*)instance;
	return 	result->OneAxis();
}

DECL_EXPORT void BRepPrimAPIMakeCylinder_Dtor(void* instance)
{
	delete (BRepPrimAPI_MakeCylinder*)instance;
}
