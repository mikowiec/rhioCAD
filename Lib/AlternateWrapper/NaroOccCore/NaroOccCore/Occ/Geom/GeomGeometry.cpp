#include "GeomGeometry.h"
#include <Geom_Geometry.hxx>

#include <Geom_Geometry.hxx>

DECL_EXPORT void Geom_Geometry_Mirror9EAECD5B(
	void* instance,
	void* P)
{
		const gp_Pnt &  _P =*(const gp_Pnt *)P;
	Geom_Geometry* result = (Geom_Geometry*)(((Handle_Geom_Geometry*)instance)->Access());
 	result->Mirror(			
_P);
}
DECL_EXPORT void Geom_Geometry_Mirror608B963B(
	void* instance,
	void* A1)
{
		const gp_Ax1 &  _A1 =*(const gp_Ax1 *)A1;
	Geom_Geometry* result = (Geom_Geometry*)(((Handle_Geom_Geometry*)instance)->Access());
 	result->Mirror(			
_A1);
}
DECL_EXPORT void Geom_Geometry_Mirror7895386A(
	void* instance,
	void* A2)
{
		const gp_Ax2 &  _A2 =*(const gp_Ax2 *)A2;
	Geom_Geometry* result = (Geom_Geometry*)(((Handle_Geom_Geometry*)instance)->Access());
 	result->Mirror(			
_A2);
}
DECL_EXPORT void Geom_Geometry_Rotate827CB19A(
	void* instance,
	void* A1,
	double Ang)
{
		const gp_Ax1 &  _A1 =*(const gp_Ax1 *)A1;
	Geom_Geometry* result = (Geom_Geometry*)(((Handle_Geom_Geometry*)instance)->Access());
 	result->Rotate(			
_A1,			
Ang);
}
DECL_EXPORT void Geom_Geometry_ScaleF0D1E3E6(
	void* instance,
	void* P,
	double S)
{
		const gp_Pnt &  _P =*(const gp_Pnt *)P;
	Geom_Geometry* result = (Geom_Geometry*)(((Handle_Geom_Geometry*)instance)->Access());
 	result->Scale(			
_P,			
S);
}
DECL_EXPORT void Geom_Geometry_Translate9BD9CFFE(
	void* instance,
	void* V)
{
		const gp_Vec &  _V =*(const gp_Vec *)V;
	Geom_Geometry* result = (Geom_Geometry*)(((Handle_Geom_Geometry*)instance)->Access());
 	result->Translate(			
_V);
}
DECL_EXPORT void Geom_Geometry_Translate5C63477E(
	void* instance,
	void* P1,
	void* P2)
{
		const gp_Pnt &  _P1 =*(const gp_Pnt *)P1;
		const gp_Pnt &  _P2 =*(const gp_Pnt *)P2;
	Geom_Geometry* result = (Geom_Geometry*)(((Handle_Geom_Geometry*)instance)->Access());
 	result->Translate(			
_P1,			
_P2);
}
DECL_EXPORT void* Geom_Geometry_Mirrored9EAECD5B(
	void* instance,
	void* P)
{
		const gp_Pnt &  _P =*(const gp_Pnt *)P;
	Geom_Geometry* result = (Geom_Geometry*)(((Handle_Geom_Geometry*)instance)->Access());
	return new Handle_Geom_Geometry( 	result->Mirrored(			
_P));
}
DECL_EXPORT void* Geom_Geometry_Mirrored608B963B(
	void* instance,
	void* A1)
{
		const gp_Ax1 &  _A1 =*(const gp_Ax1 *)A1;
	Geom_Geometry* result = (Geom_Geometry*)(((Handle_Geom_Geometry*)instance)->Access());
	return new Handle_Geom_Geometry( 	result->Mirrored(			
_A1));
}
DECL_EXPORT void* Geom_Geometry_Mirrored7895386A(
	void* instance,
	void* A2)
{
		const gp_Ax2 &  _A2 =*(const gp_Ax2 *)A2;
	Geom_Geometry* result = (Geom_Geometry*)(((Handle_Geom_Geometry*)instance)->Access());
	return new Handle_Geom_Geometry( 	result->Mirrored(			
_A2));
}
DECL_EXPORT void* Geom_Geometry_Rotated827CB19A(
	void* instance,
	void* A1,
	double Ang)
{
		const gp_Ax1 &  _A1 =*(const gp_Ax1 *)A1;
	Geom_Geometry* result = (Geom_Geometry*)(((Handle_Geom_Geometry*)instance)->Access());
	return new Handle_Geom_Geometry( 	result->Rotated(			
_A1,			
Ang));
}
DECL_EXPORT void* Geom_Geometry_ScaledF0D1E3E6(
	void* instance,
	void* P,
	double S)
{
		const gp_Pnt &  _P =*(const gp_Pnt *)P;
	Geom_Geometry* result = (Geom_Geometry*)(((Handle_Geom_Geometry*)instance)->Access());
	return new Handle_Geom_Geometry( 	result->Scaled(			
_P,			
S));
}
DECL_EXPORT void* Geom_Geometry_Transformed72D78650(
	void* instance,
	void* T)
{
		const gp_Trsf &  _T =*(const gp_Trsf *)T;
	Geom_Geometry* result = (Geom_Geometry*)(((Handle_Geom_Geometry*)instance)->Access());
	return new Handle_Geom_Geometry( 	result->Transformed(			
_T));
}
DECL_EXPORT void* Geom_Geometry_Translated9BD9CFFE(
	void* instance,
	void* V)
{
		const gp_Vec &  _V =*(const gp_Vec *)V;
	Geom_Geometry* result = (Geom_Geometry*)(((Handle_Geom_Geometry*)instance)->Access());
	return new Handle_Geom_Geometry( 	result->Translated(			
_V));
}
DECL_EXPORT void* Geom_Geometry_Translated5C63477E(
	void* instance,
	void* P1,
	void* P2)
{
		const gp_Pnt &  _P1 =*(const gp_Pnt *)P1;
		const gp_Pnt &  _P2 =*(const gp_Pnt *)P2;
	Geom_Geometry* result = (Geom_Geometry*)(((Handle_Geom_Geometry*)instance)->Access());
	return new Handle_Geom_Geometry( 	result->Translated(			
_P1,			
_P2));
}
DECL_EXPORT void GeomGeometry_Dtor(void* instance)
{
	delete (Handle_Geom_Geometry*)instance;
}
