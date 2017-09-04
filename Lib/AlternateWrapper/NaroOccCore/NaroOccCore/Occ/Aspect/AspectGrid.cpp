#include "AspectGrid.h"
#include <Aspect_Grid.hxx>


DECL_EXPORT void Aspect_Grid_RotateD82819F3(
	void* instance,
	double anAngle)
{
	Aspect_Grid* result = (Aspect_Grid*)(((Handle_Aspect_Grid*)instance)->Access());
 	result->Rotate(			
anAngle);
}
DECL_EXPORT void Aspect_Grid_Translate9F0E714F(
	void* instance,
	double aDx,
	double aDy)
{
	Aspect_Grid* result = (Aspect_Grid*)(((Handle_Aspect_Grid*)instance)->Access());
 	result->Translate(			
aDx,			
aDy);
}
DECL_EXPORT void Aspect_Grid_SetColorsCF0F9433(
	void* instance,
	void* aColor,
	void* aTenthColor)
{
		const Quantity_Color &  _aColor =*(const Quantity_Color *)aColor;
		const Quantity_Color &  _aTenthColor =*(const Quantity_Color *)aTenthColor;
	Aspect_Grid* result = (Aspect_Grid*)(((Handle_Aspect_Grid*)instance)->Access());
 	result->SetColors(			
_aColor,			
_aTenthColor);
}
DECL_EXPORT void Aspect_Grid_HitC2777E0C(
	void* instance,
	double X,
	double Y,
	double* gridX,
	double* gridY)
{
	Aspect_Grid* result = (Aspect_Grid*)(((Handle_Aspect_Grid*)instance)->Access());
 	result->Hit(			
X,			
Y,			
*gridX,			
*gridY);
}
DECL_EXPORT void Aspect_Grid_Activate(void* instance)
{
	Aspect_Grid* result = (Aspect_Grid*)(((Handle_Aspect_Grid*)instance)->Access());
 	result->Activate();
}
DECL_EXPORT void Aspect_Grid_Deactivate(void* instance)
{
	Aspect_Grid* result = (Aspect_Grid*)(((Handle_Aspect_Grid*)instance)->Access());
 	result->Deactivate();
}
DECL_EXPORT void Aspect_Grid_ColorsCF0F9433(
	void* instance,
	void* aColor,
	void* aTenthColor)
{
		 Quantity_Color &  _aColor =*( Quantity_Color *)aColor;
		 Quantity_Color &  _aTenthColor =*( Quantity_Color *)aTenthColor;
	Aspect_Grid* result = (Aspect_Grid*)(((Handle_Aspect_Grid*)instance)->Access());
 	result->Colors(			
_aColor,			
_aTenthColor);
}
DECL_EXPORT void Aspect_Grid_Display(void* instance)
{
	Aspect_Grid* result = (Aspect_Grid*)(((Handle_Aspect_Grid*)instance)->Access());
 	result->Display();
}
DECL_EXPORT void Aspect_Grid_Erase(void* instance)
{
	Aspect_Grid* result = (Aspect_Grid*)(((Handle_Aspect_Grid*)instance)->Access());
 	result->Erase();
}
DECL_EXPORT void Aspect_Grid_SetXOrigin(void* instance, double value)
{
	Aspect_Grid* result = (Aspect_Grid*)(((Handle_Aspect_Grid*)instance)->Access());
		result->SetXOrigin(value);
}

DECL_EXPORT double Aspect_Grid_XOrigin(void* instance)
{
	Aspect_Grid* result = (Aspect_Grid*)(((Handle_Aspect_Grid*)instance)->Access());
	return 	result->XOrigin();
}

DECL_EXPORT void Aspect_Grid_SetYOrigin(void* instance, double value)
{
	Aspect_Grid* result = (Aspect_Grid*)(((Handle_Aspect_Grid*)instance)->Access());
		result->SetYOrigin(value);
}

DECL_EXPORT double Aspect_Grid_YOrigin(void* instance)
{
	Aspect_Grid* result = (Aspect_Grid*)(((Handle_Aspect_Grid*)instance)->Access());
	return 	result->YOrigin();
}

DECL_EXPORT void Aspect_Grid_SetRotationAngle(void* instance, double value)
{
	Aspect_Grid* result = (Aspect_Grid*)(((Handle_Aspect_Grid*)instance)->Access());
		result->SetRotationAngle(value);
}

DECL_EXPORT double Aspect_Grid_RotationAngle(void* instance)
{
	Aspect_Grid* result = (Aspect_Grid*)(((Handle_Aspect_Grid*)instance)->Access());
	return 	result->RotationAngle();
}

DECL_EXPORT bool Aspect_Grid_IsActive(void* instance)
{
	Aspect_Grid* result = (Aspect_Grid*)(((Handle_Aspect_Grid*)instance)->Access());
	return 	result->IsActive();
}

DECL_EXPORT void Aspect_Grid_SetDrawMode(void* instance, int value)
{
	Aspect_Grid* result = (Aspect_Grid*)(((Handle_Aspect_Grid*)instance)->Access());
		result->SetDrawMode((const Aspect_GridDrawMode)value);
}

DECL_EXPORT int Aspect_Grid_DrawMode(void* instance)
{
	Aspect_Grid* result = (Aspect_Grid*)(((Handle_Aspect_Grid*)instance)->Access());
	return (int)	result->DrawMode();
}

DECL_EXPORT bool Aspect_Grid_IsDisplayed(void* instance)
{
	Aspect_Grid* result = (Aspect_Grid*)(((Handle_Aspect_Grid*)instance)->Access());
	return 	result->IsDisplayed();
}

DECL_EXPORT void AspectGrid_Dtor(void* instance)
{
	delete (Handle_Aspect_Grid*)instance;
}
