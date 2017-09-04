#include "Visual3dPickPath.h"
#include <Visual3d_PickPath.hxx>


DECL_EXPORT void* Visual3d_PickPath_Ctor()
{
	return new Visual3d_PickPath();
}
DECL_EXPORT void Visual3d_PickPath_SetElementNumber(void* instance, int value)
{
	Visual3d_PickPath* result = (Visual3d_PickPath*)instance;
		result->SetElementNumber(value);
}

DECL_EXPORT int Visual3d_PickPath_ElementNumber(void* instance)
{
	Visual3d_PickPath* result = (Visual3d_PickPath*)instance;
	return 	result->ElementNumber();
}

DECL_EXPORT void Visual3d_PickPath_SetPickIdentifier(void* instance, int value)
{
	Visual3d_PickPath* result = (Visual3d_PickPath*)instance;
		result->SetPickIdentifier(value);
}

DECL_EXPORT int Visual3d_PickPath_PickIdentifier(void* instance)
{
	Visual3d_PickPath* result = (Visual3d_PickPath*)instance;
	return 	result->PickIdentifier();
}

DECL_EXPORT void Visual3dPickPath_Dtor(void* instance)
{
	delete (Visual3d_PickPath*)instance;
}
