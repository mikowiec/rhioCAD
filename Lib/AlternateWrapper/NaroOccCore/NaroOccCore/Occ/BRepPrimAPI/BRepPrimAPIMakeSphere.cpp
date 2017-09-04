#include "BRepPrimAPIMakeSphere.h"
#include <BRepPrimAPI_MakeSphere.hxx>


DECL_EXPORT void* BRepPrimAPI_MakeSphere_CtorD82819F3(
	double R)
{
	return new BRepPrimAPI_MakeSphere(			
R);
}
DECL_EXPORT void* BRepPrimAPI_MakeSphere_Ctor9F0E714F(
	double R,
	double angle)
{
	return new BRepPrimAPI_MakeSphere(			
R,			
angle);
}
DECL_EXPORT void* BRepPrimAPI_MakeSphere_Ctor9282A951(
	double R,
	double angle1,
	double angle2)
{
	return new BRepPrimAPI_MakeSphere(			
R,			
angle1,			
angle2);
}
DECL_EXPORT void* BRepPrimAPI_MakeSphere_CtorC2777E0C(
	double R,
	double angle1,
	double angle2,
	double angle3)
{
	return new BRepPrimAPI_MakeSphere(			
R,			
angle1,			
angle2,			
angle3);
}
DECL_EXPORT void* BRepPrimAPI_MakeSphere_CtorF0D1E3E6(
	void* Center,
	double R)
{
		const gp_Pnt &  _Center =*(const gp_Pnt *)Center;
	return new BRepPrimAPI_MakeSphere(			
_Center,			
R);
}
DECL_EXPORT void* BRepPrimAPI_MakeSphere_Ctor9515F856(
	void* Center,
	double R,
	double angle)
{
		const gp_Pnt &  _Center =*(const gp_Pnt *)Center;
	return new BRepPrimAPI_MakeSphere(			
_Center,			
R,			
angle);
}
DECL_EXPORT void* BRepPrimAPI_MakeSphere_Ctor22BACD62(
	void* Center,
	double R,
	double angle1,
	double angle2)
{
		const gp_Pnt &  _Center =*(const gp_Pnt *)Center;
	return new BRepPrimAPI_MakeSphere(			
_Center,			
R,			
angle1,			
angle2);
}
DECL_EXPORT void* BRepPrimAPI_MakeSphere_CtorD969C62A(
	void* Center,
	double R,
	double angle1,
	double angle2,
	double angle3)
{
		const gp_Pnt &  _Center =*(const gp_Pnt *)Center;
	return new BRepPrimAPI_MakeSphere(			
_Center,			
R,			
angle1,			
angle2,			
angle3);
}
DECL_EXPORT void* BRepPrimAPI_MakeSphere_Ctor673FA07D(
	void* Axis,
	double R)
{
		const gp_Ax2 &  _Axis =*(const gp_Ax2 *)Axis;
	return new BRepPrimAPI_MakeSphere(			
_Axis,			
R);
}
DECL_EXPORT void* BRepPrimAPI_MakeSphere_CtorB1A3BD2A(
	void* Axis,
	double R,
	double angle)
{
		const gp_Ax2 &  _Axis =*(const gp_Ax2 *)Axis;
	return new BRepPrimAPI_MakeSphere(			
_Axis,			
R,			
angle);
}
DECL_EXPORT void* BRepPrimAPI_MakeSphere_CtorF0200AF(
	void* Axis,
	double R,
	double angle1,
	double angle2)
{
		const gp_Ax2 &  _Axis =*(const gp_Ax2 *)Axis;
	return new BRepPrimAPI_MakeSphere(			
_Axis,			
R,			
angle1,			
angle2);
}
DECL_EXPORT void* BRepPrimAPI_MakeSphere_Ctor77315A3D(
	void* Axis,
	double R,
	double angle1,
	double angle2,
	double angle3)
{
		const gp_Ax2 &  _Axis =*(const gp_Ax2 *)Axis;
	return new BRepPrimAPI_MakeSphere(			
_Axis,			
R,			
angle1,			
angle2,			
angle3);
}
DECL_EXPORT void* BRepPrimAPI_MakeSphere_OneAxis(void* instance)
{
	BRepPrimAPI_MakeSphere* result = (BRepPrimAPI_MakeSphere*)instance;
	return 	result->OneAxis();
}

DECL_EXPORT void BRepPrimAPIMakeSphere_Dtor(void* instance)
{
	delete (BRepPrimAPI_MakeSphere*)instance;
}
