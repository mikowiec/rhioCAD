#include "GeomAxis2Placement.h"
#include <Geom_Axis2Placement.hxx>

#include <Geom_Geometry.hxx>
#include <gp_Ax2.hxx>
#include <gp_Dir.hxx>

DECL_EXPORT void* Geom_Axis2Placement_Ctor7895386A(
	void* A2)
{
		const gp_Ax2 &  _A2 =*(const gp_Ax2 *)A2;
	return new Handle_Geom_Axis2Placement(new Geom_Axis2Placement(			
_A2));
}
DECL_EXPORT void* Geom_Axis2Placement_CtorF36E9D55(
	void* P,
	void* N,
	void* Vx)
{
		const gp_Pnt &  _P =*(const gp_Pnt *)P;
		const gp_Dir &  _N =*(const gp_Dir *)N;
		const gp_Dir &  _Vx =*(const gp_Dir *)Vx;
	return new Handle_Geom_Axis2Placement(new Geom_Axis2Placement(			
_P,			
_N,			
_Vx));
}
DECL_EXPORT void Geom_Axis2Placement_Transform72D78650(
	void* instance,
	void* T)
{
		const gp_Trsf &  _T =*(const gp_Trsf *)T;
	Geom_Axis2Placement* result = (Geom_Axis2Placement*)(((Handle_Geom_Axis2Placement*)instance)->Access());
 	result->Transform(			
_T);
}
DECL_EXPORT void Geom_Axis2Placement_SetDirection(void* instance, void* value)
{
	Geom_Axis2Placement* result = (Geom_Axis2Placement*)(((Handle_Geom_Axis2Placement*)instance)->Access());
		result->SetDirection(*(const gp_Dir *)value);
}

DECL_EXPORT void Geom_Axis2Placement_SetAx2(void* instance, void* value)
{
	Geom_Axis2Placement* result = (Geom_Axis2Placement*)(((Handle_Geom_Axis2Placement*)instance)->Access());
		result->SetAx2(*(const gp_Ax2 *)value);
}

DECL_EXPORT void* Geom_Axis2Placement_Ax2(void* instance)
{
	Geom_Axis2Placement* result = (Geom_Axis2Placement*)(((Handle_Geom_Axis2Placement*)instance)->Access());
	return 	new gp_Ax2(	result->Ax2());
}

DECL_EXPORT void Geom_Axis2Placement_SetXDirection(void* instance, void* value)
{
	Geom_Axis2Placement* result = (Geom_Axis2Placement*)(((Handle_Geom_Axis2Placement*)instance)->Access());
		result->SetXDirection(*(const gp_Dir *)value);
}

DECL_EXPORT void* Geom_Axis2Placement_XDirection(void* instance)
{
	Geom_Axis2Placement* result = (Geom_Axis2Placement*)(((Handle_Geom_Axis2Placement*)instance)->Access());
	return 	new gp_Dir(	result->XDirection());
}

DECL_EXPORT void Geom_Axis2Placement_SetYDirection(void* instance, void* value)
{
	Geom_Axis2Placement* result = (Geom_Axis2Placement*)(((Handle_Geom_Axis2Placement*)instance)->Access());
		result->SetYDirection(*(const gp_Dir *)value);
}

DECL_EXPORT void* Geom_Axis2Placement_YDirection(void* instance)
{
	Geom_Axis2Placement* result = (Geom_Axis2Placement*)(((Handle_Geom_Axis2Placement*)instance)->Access());
	return 	new gp_Dir(	result->YDirection());
}

DECL_EXPORT void* Geom_Axis2Placement_Copy(void* instance)
{
	Geom_Axis2Placement* result = (Geom_Axis2Placement*)(((Handle_Geom_Axis2Placement*)instance)->Access());
	return 	new Handle_Geom_Geometry(	result->Copy());
}

DECL_EXPORT void GeomAxis2Placement_Dtor(void* instance)
{
	delete (Handle_Geom_Axis2Placement*)instance;
}
