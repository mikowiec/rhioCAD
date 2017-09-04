#include "Graphic2dViewMapping.h"
#include <Graphic2d_ViewMapping.hxx>


DECL_EXPORT void* Graphic2d_ViewMapping_Ctor()
{
	return new Handle_Graphic2d_ViewMapping(new Graphic2d_ViewMapping());
}
DECL_EXPORT void Graphic2d_ViewMapping_SetViewMapping9282A951(
	void* instance,
	double aXCenter,
	double aYCenter,
	double aSize)
{
	Graphic2d_ViewMapping* result = (Graphic2d_ViewMapping*)(((Handle_Graphic2d_ViewMapping*)instance)->Access());
 	result->SetViewMapping(			
aXCenter,			
aYCenter,			
aSize);
}
DECL_EXPORT void Graphic2d_ViewMapping_SetCenter9F0E714F(
	void* instance,
	double aXCenter,
	double aYCenter)
{
	Graphic2d_ViewMapping* result = (Graphic2d_ViewMapping*)(((Handle_Graphic2d_ViewMapping*)instance)->Access());
 	result->SetCenter(			
aXCenter,			
aYCenter);
}
DECL_EXPORT void Graphic2d_ViewMapping_SetViewMappingDefault(void* instance)
{
	Graphic2d_ViewMapping* result = (Graphic2d_ViewMapping*)(((Handle_Graphic2d_ViewMapping*)instance)->Access());
 	result->SetViewMappingDefault();
}
DECL_EXPORT void Graphic2d_ViewMapping_ViewMappingReset(void* instance)
{
	Graphic2d_ViewMapping* result = (Graphic2d_ViewMapping*)(((Handle_Graphic2d_ViewMapping*)instance)->Access());
 	result->ViewMappingReset();
}
DECL_EXPORT void Graphic2d_ViewMapping_ViewMapping9282A951(
	void* instance,
	double* XCenter,
	double* YCenter,
	double* Size)
{
	Graphic2d_ViewMapping* result = (Graphic2d_ViewMapping*)(((Handle_Graphic2d_ViewMapping*)instance)->Access());
 	result->ViewMapping(			
*XCenter,			
*YCenter,			
*Size);
}
DECL_EXPORT void Graphic2d_ViewMapping_Center9F0E714F(
	void* instance,
	double* XCenter,
	double* YCenter)
{
	Graphic2d_ViewMapping* result = (Graphic2d_ViewMapping*)(((Handle_Graphic2d_ViewMapping*)instance)->Access());
 	result->Center(			
*XCenter,			
*YCenter);
}
DECL_EXPORT void Graphic2d_ViewMapping_ViewMappingDefault9282A951(
	void* instance,
	double* XCenter,
	double* YCenter,
	double* Size)
{
	Graphic2d_ViewMapping* result = (Graphic2d_ViewMapping*)(((Handle_Graphic2d_ViewMapping*)instance)->Access());
 	result->ViewMappingDefault(			
*XCenter,			
*YCenter,			
*Size);
}
DECL_EXPORT void Graphic2d_ViewMapping_SetSize(void* instance, double value)
{
	Graphic2d_ViewMapping* result = (Graphic2d_ViewMapping*)(((Handle_Graphic2d_ViewMapping*)instance)->Access());
		result->SetSize(value);
}

DECL_EXPORT double Graphic2d_ViewMapping_Zoom(void* instance)
{
	Graphic2d_ViewMapping* result = (Graphic2d_ViewMapping*)(((Handle_Graphic2d_ViewMapping*)instance)->Access());
	return 	result->Zoom();
}

DECL_EXPORT void Graphic2dViewMapping_Dtor(void* instance)
{
	delete (Handle_Graphic2d_ViewMapping*)instance;
}
