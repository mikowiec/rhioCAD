#include "GPropGProps.h"
#include <GProp_GProps.hxx>

#include <gp_Mat.hxx>
#include <gp_Pnt.hxx>

DECL_EXPORT void* GProp_GProps_Ctor()
{
	return new GProp_GProps();
}
DECL_EXPORT void* GProp_GProps_Ctor9EAECD5B(
	void* SystemLocation)
{
		const gp_Pnt &  _SystemLocation =*(const gp_Pnt *)SystemLocation;
	return new GProp_GProps(			
_SystemLocation);
}
DECL_EXPORT void GProp_GProps_Add38D0113A(
	void* instance,
	void* Item,
	double Density)
{
		const GProp_GProps &  _Item =*(const GProp_GProps *)Item;
	GProp_GProps* result = (GProp_GProps*)instance;
 	result->Add(			
_Item,			
Density);
}
DECL_EXPORT void GProp_GProps_StaticMoments9282A951(
	void* instance,
	double* Ix,
	double* Iy,
	double* Iz)
{
	GProp_GProps* result = (GProp_GProps*)instance;
 	result->StaticMoments(			
*Ix,			
*Iy,			
*Iz);
}
DECL_EXPORT double GProp_GProps_MomentOfInertia608B963B(
	void* instance,
	void* A)
{
		const gp_Ax1 &  _A =*(const gp_Ax1 *)A;
	GProp_GProps* result = (GProp_GProps*)instance;
	return  	result->MomentOfInertia(			
_A);
}
DECL_EXPORT double GProp_GProps_RadiusOfGyration608B963B(
	void* instance,
	void* A)
{
		const gp_Ax1 &  _A =*(const gp_Ax1 *)A;
	GProp_GProps* result = (GProp_GProps*)instance;
	return  	result->RadiusOfGyration(			
_A);
}
DECL_EXPORT double GProp_GProps_Mass(void* instance)
{
	GProp_GProps* result = (GProp_GProps*)instance;
	return 	result->Mass();
}

DECL_EXPORT void* GProp_GProps_CentreOfMass(void* instance)
{
	GProp_GProps* result = (GProp_GProps*)instance;
	return 	new gp_Pnt(	result->CentreOfMass());
}

DECL_EXPORT void* GProp_GProps_MatrixOfInertia(void* instance)
{
	GProp_GProps* result = (GProp_GProps*)instance;
	return 	new gp_Mat(	result->MatrixOfInertia());
}

DECL_EXPORT void GPropGProps_Dtor(void* instance)
{
	delete (GProp_GProps*)instance;
}
