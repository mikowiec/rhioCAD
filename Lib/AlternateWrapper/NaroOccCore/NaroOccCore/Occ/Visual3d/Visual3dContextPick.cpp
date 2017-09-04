#include "Visual3dContextPick.h"
#include <Visual3d_ContextPick.hxx>


DECL_EXPORT void* Visual3d_ContextPick_Ctor()
{
	return new Visual3d_ContextPick();
}
DECL_EXPORT void* Visual3d_ContextPick_CtorA3634D78(
	double Aperture,
	int Depth,
	int Order)
{
		const Visual3d_TypeOfOrder _Order =(const Visual3d_TypeOfOrder )Order;
	return new Visual3d_ContextPick(			
Aperture,			
Depth,			
_Order);
}
DECL_EXPORT void Visual3d_ContextPick_SetAperture(void* instance, double value)
{
	Visual3d_ContextPick* result = (Visual3d_ContextPick*)instance;
		result->SetAperture(value);
}

DECL_EXPORT double Visual3d_ContextPick_Aperture(void* instance)
{
	Visual3d_ContextPick* result = (Visual3d_ContextPick*)instance;
	return 	result->Aperture();
}

DECL_EXPORT void Visual3d_ContextPick_SetDepth(void* instance, int value)
{
	Visual3d_ContextPick* result = (Visual3d_ContextPick*)instance;
		result->SetDepth(value);
}

DECL_EXPORT int Visual3d_ContextPick_Depth(void* instance)
{
	Visual3d_ContextPick* result = (Visual3d_ContextPick*)instance;
	return 	result->Depth();
}

DECL_EXPORT void Visual3d_ContextPick_SetOrder(void* instance, int value)
{
	Visual3d_ContextPick* result = (Visual3d_ContextPick*)instance;
		result->SetOrder((const Visual3d_TypeOfOrder)value);
}

DECL_EXPORT int Visual3d_ContextPick_Order(void* instance)
{
	Visual3d_ContextPick* result = (Visual3d_ContextPick*)instance;
	return (int)	result->Order();
}

DECL_EXPORT void Visual3dContextPick_Dtor(void* instance)
{
	delete (Visual3d_ContextPick*)instance;
}
