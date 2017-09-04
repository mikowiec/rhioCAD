#include "GeomPoint.h"
#include <Geom_Point.hxx>


DECL_EXPORT double Geom_Point_Distance121385BD(
	void* instance,
	void* Other)
{
		const Handle_Geom_Point&  _Other =*(const Handle_Geom_Point *)Other;
	Geom_Point* result = (Geom_Point*)(((Handle_Geom_Point*)instance)->Access());
	return  	result->Distance(			
_Other);
}
DECL_EXPORT double Geom_Point_SquareDistance121385BD(
	void* instance,
	void* Other)
{
		const Handle_Geom_Point&  _Other =*(const Handle_Geom_Point *)Other;
	Geom_Point* result = (Geom_Point*)(((Handle_Geom_Point*)instance)->Access());
	return  	result->SquareDistance(			
_Other);
}
DECL_EXPORT void GeomPoint_Dtor(void* instance)
{
	delete (Handle_Geom_Point*)instance;
}
