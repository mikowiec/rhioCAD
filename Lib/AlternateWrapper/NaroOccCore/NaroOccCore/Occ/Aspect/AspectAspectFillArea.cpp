#include "AspectAspectFillArea.h"
#include <Aspect_AspectFillArea.hxx>


DECL_EXPORT void Aspect_AspectFillArea_SetEdgeColor(void* instance, void* value)
{
	Aspect_AspectFillArea* result = (Aspect_AspectFillArea*)(((Handle_Aspect_AspectFillArea*)instance)->Access());
		result->SetEdgeColor(*(const Quantity_Color *)value);
}

DECL_EXPORT void Aspect_AspectFillArea_SetEdgeLineType(void* instance, int value)
{
	Aspect_AspectFillArea* result = (Aspect_AspectFillArea*)(((Handle_Aspect_AspectFillArea*)instance)->Access());
		result->SetEdgeLineType((const Aspect_TypeOfLine)value);
}

DECL_EXPORT void Aspect_AspectFillArea_SetEdgeWidth(void* instance, double value)
{
	Aspect_AspectFillArea* result = (Aspect_AspectFillArea*)(((Handle_Aspect_AspectFillArea*)instance)->Access());
		result->SetEdgeWidth(value);
}

DECL_EXPORT void Aspect_AspectFillArea_SetInteriorColor(void* instance, void* value)
{
	Aspect_AspectFillArea* result = (Aspect_AspectFillArea*)(((Handle_Aspect_AspectFillArea*)instance)->Access());
		result->SetInteriorColor(*(const Quantity_Color *)value);
}

DECL_EXPORT void Aspect_AspectFillArea_SetBackInteriorColor(void* instance, void* value)
{
	Aspect_AspectFillArea* result = (Aspect_AspectFillArea*)(((Handle_Aspect_AspectFillArea*)instance)->Access());
		result->SetBackInteriorColor(*(const Quantity_Color *)value);
}

DECL_EXPORT void Aspect_AspectFillArea_SetInteriorStyle(void* instance, int value)
{
	Aspect_AspectFillArea* result = (Aspect_AspectFillArea*)(((Handle_Aspect_AspectFillArea*)instance)->Access());
		result->SetInteriorStyle((const Aspect_InteriorStyle)value);
}

DECL_EXPORT void Aspect_AspectFillArea_SetHatchStyle(void* instance, int value)
{
	Aspect_AspectFillArea* result = (Aspect_AspectFillArea*)(((Handle_Aspect_AspectFillArea*)instance)->Access());
		result->SetHatchStyle((const Aspect_HatchStyle)value);
}

DECL_EXPORT int Aspect_AspectFillArea_HatchStyle(void* instance)
{
	Aspect_AspectFillArea* result = (Aspect_AspectFillArea*)(((Handle_Aspect_AspectFillArea*)instance)->Access());
	return (int)	result->HatchStyle();
}

DECL_EXPORT void AspectAspectFillArea_Dtor(void* instance)
{
	delete (Handle_Aspect_AspectFillArea*)instance;
}
