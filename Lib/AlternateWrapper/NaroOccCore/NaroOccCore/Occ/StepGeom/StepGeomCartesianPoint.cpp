#include "StepGeomCartesianPoint.h"
#include <StepGeom_CartesianPoint.hxx>


DECL_EXPORT void* StepGeom_CartesianPoint_Ctor()
{
	return new StepGeom_CartesianPoint();
}
DECL_EXPORT void StepGeom_CartesianPoint_InitB439B3D5(
	void* instance,
	void* aName)
{
		const Handle_TCollection_HAsciiString&  _aName =*(const Handle_TCollection_HAsciiString *)aName;
	StepGeom_CartesianPoint* result = (StepGeom_CartesianPoint*)instance;
 	result->Init(			
_aName);
}
DECL_EXPORT void StepGeom_CartesianPoint_Init2D3BC3DBE2(
	void* instance,
	void* aName,
	double X,
	double Y)
{
		const Handle_TCollection_HAsciiString&  _aName =*(const Handle_TCollection_HAsciiString *)aName;
	StepGeom_CartesianPoint* result = (StepGeom_CartesianPoint*)instance;
 	result->Init2D(			
_aName,			
X,			
Y);
}
DECL_EXPORT void StepGeom_CartesianPoint_Init3D13512EBE(
	void* instance,
	void* aName,
	double X,
	double Y,
	double Z)
{
		const Handle_TCollection_HAsciiString&  _aName =*(const Handle_TCollection_HAsciiString *)aName;
	StepGeom_CartesianPoint* result = (StepGeom_CartesianPoint*)instance;
 	result->Init3D(			
_aName,			
X,			
Y,			
Z);
}
DECL_EXPORT double StepGeom_CartesianPoint_CoordinatesValueE8219145(
	void* instance,
	int num)
{
	StepGeom_CartesianPoint* result = (StepGeom_CartesianPoint*)instance;
	return  	result->CoordinatesValue(			
num);
}
DECL_EXPORT int StepGeom_CartesianPoint_NbCoordinates(void* instance)
{
	StepGeom_CartesianPoint* result = (StepGeom_CartesianPoint*)instance;
	return 	result->NbCoordinates();
}

DECL_EXPORT void StepGeomCartesianPoint_Dtor(void* instance)
{
	delete (StepGeom_CartesianPoint*)instance;
}
