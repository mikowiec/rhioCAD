#include "StepGeomDirection.h"
#include <StepGeom_Direction.hxx>


DECL_EXPORT void* StepGeom_Direction_Ctor()
{
	return new StepGeom_Direction();
}
DECL_EXPORT void StepGeom_Direction_InitB439B3D5(
	void* instance,
	void* aName)
{
		const Handle_TCollection_HAsciiString&  _aName =*(const Handle_TCollection_HAsciiString *)aName;
	StepGeom_Direction* result = (StepGeom_Direction*)instance;
 	result->Init(			
_aName);
}
DECL_EXPORT double StepGeom_Direction_DirectionRatiosValueE8219145(
	void* instance,
	int num)
{
	StepGeom_Direction* result = (StepGeom_Direction*)instance;
	return  	result->DirectionRatiosValue(			
num);
}
DECL_EXPORT int StepGeom_Direction_NbDirectionRatios(void* instance)
{
	StepGeom_Direction* result = (StepGeom_Direction*)instance;
	return 	result->NbDirectionRatios();
}

DECL_EXPORT void StepGeomDirection_Dtor(void* instance)
{
	delete (StepGeom_Direction*)instance;
}
