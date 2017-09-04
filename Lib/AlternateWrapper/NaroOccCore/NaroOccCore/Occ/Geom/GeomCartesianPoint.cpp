#include "GeomCartesianPoint.h"
#include <Geom_CartesianPoint.hxx>

#include <Geom_Geometry.hxx>
#include <gp_Pnt.hxx>

DECL_EXPORT void* Geom_CartesianPoint_Ctor9EAECD5B(
	void* P)
{
		const gp_Pnt &  _P =*(const gp_Pnt *)P;
	return new Handle_Geom_CartesianPoint(new Geom_CartesianPoint(			
_P));
}
DECL_EXPORT void* Geom_CartesianPoint_Ctor9282A951(
	double X,
	double Y,
	double Z)
{
	return new Handle_Geom_CartesianPoint(new Geom_CartesianPoint(			
X,			
Y,			
Z));
}
DECL_EXPORT void Geom_CartesianPoint_SetCoord9282A951(
	void* instance,
	double X,
	double Y,
	double Z)
{
	Geom_CartesianPoint* result = (Geom_CartesianPoint*)(((Handle_Geom_CartesianPoint*)instance)->Access());
 	result->SetCoord(			
X,			
Y,			
Z);
}
DECL_EXPORT void Geom_CartesianPoint_Coord9282A951(
	void* instance,
	double* X,
	double* Y,
	double* Z)
{
	Geom_CartesianPoint* result = (Geom_CartesianPoint*)(((Handle_Geom_CartesianPoint*)instance)->Access());
 	result->Coord(			
*X,			
*Y,			
*Z);
}
DECL_EXPORT void Geom_CartesianPoint_Transform72D78650(
	void* instance,
	void* T)
{
		const gp_Trsf &  _T =*(const gp_Trsf *)T;
	Geom_CartesianPoint* result = (Geom_CartesianPoint*)(((Handle_Geom_CartesianPoint*)instance)->Access());
 	result->Transform(			
_T);
}
DECL_EXPORT void Geom_CartesianPoint_SetPnt(void* instance, void* value)
{
	Geom_CartesianPoint* result = (Geom_CartesianPoint*)(((Handle_Geom_CartesianPoint*)instance)->Access());
		result->SetPnt(*(const gp_Pnt *)value);
}

DECL_EXPORT void* Geom_CartesianPoint_Pnt(void* instance)
{
	Geom_CartesianPoint* result = (Geom_CartesianPoint*)(((Handle_Geom_CartesianPoint*)instance)->Access());
	return 	new gp_Pnt(	result->Pnt());
}

DECL_EXPORT void Geom_CartesianPoint_SetX(void* instance, double value)
{
	Geom_CartesianPoint* result = (Geom_CartesianPoint*)(((Handle_Geom_CartesianPoint*)instance)->Access());
		result->SetX(value);
}

DECL_EXPORT double Geom_CartesianPoint_X(void* instance)
{
	Geom_CartesianPoint* result = (Geom_CartesianPoint*)(((Handle_Geom_CartesianPoint*)instance)->Access());
	return 	result->X();
}

DECL_EXPORT void Geom_CartesianPoint_SetY(void* instance, double value)
{
	Geom_CartesianPoint* result = (Geom_CartesianPoint*)(((Handle_Geom_CartesianPoint*)instance)->Access());
		result->SetY(value);
}

DECL_EXPORT double Geom_CartesianPoint_Y(void* instance)
{
	Geom_CartesianPoint* result = (Geom_CartesianPoint*)(((Handle_Geom_CartesianPoint*)instance)->Access());
	return 	result->Y();
}

DECL_EXPORT void Geom_CartesianPoint_SetZ(void* instance, double value)
{
	Geom_CartesianPoint* result = (Geom_CartesianPoint*)(((Handle_Geom_CartesianPoint*)instance)->Access());
		result->SetZ(value);
}

DECL_EXPORT double Geom_CartesianPoint_Z(void* instance)
{
	Geom_CartesianPoint* result = (Geom_CartesianPoint*)(((Handle_Geom_CartesianPoint*)instance)->Access());
	return 	result->Z();
}

DECL_EXPORT void* Geom_CartesianPoint_Copy(void* instance)
{
	Geom_CartesianPoint* result = (Geom_CartesianPoint*)(((Handle_Geom_CartesianPoint*)instance)->Access());
	return 	new Handle_Geom_Geometry(	result->Copy());
}

DECL_EXPORT void GeomCartesianPoint_Dtor(void* instance)
{
	delete (Handle_Geom_CartesianPoint*)instance;
}
