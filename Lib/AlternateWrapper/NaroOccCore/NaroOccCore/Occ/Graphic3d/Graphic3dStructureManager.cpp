#include "Graphic3dStructureManager.h"
#include <Graphic3d_StructureManager.hxx>

#include <Aspect_GraphicDevice.hxx>
#include <Graphic3d_AspectFillArea3d.hxx>
#include <Graphic3d_AspectText3d.hxx>

DECL_EXPORT void Graphic3d_StructureManager_MinMaxValuesBC7A5786(
	void* instance,
	double* XMin,
	double* YMin,
	double* ZMin,
	double* XMax,
	double* YMax,
	double* ZMax)
{
	Graphic3d_StructureManager* result = (Graphic3d_StructureManager*)(((Handle_Graphic3d_StructureManager*)instance)->Access());
 	result->MinMaxValues(			
*XMin,			
*YMin,			
*ZMin,			
*XMax,			
*YMax,			
*ZMax);
}
DECL_EXPORT int Graphic3d_StructureManager_Identification(void* instance)
{
	Graphic3d_StructureManager* result = (Graphic3d_StructureManager*)(((Handle_Graphic3d_StructureManager*)instance)->Access());
	return  	result->Identification();
}
DECL_EXPORT void* Graphic3d_StructureManager_FillArea3dAspect(void* instance)
{
	Graphic3d_StructureManager* result = (Graphic3d_StructureManager*)(((Handle_Graphic3d_StructureManager*)instance)->Access());
	return 	new Handle_Graphic3d_AspectFillArea3d(	result->FillArea3dAspect());
}

DECL_EXPORT int Graphic3d_StructureManager_Limit()
{
	return Graphic3d_StructureManager::Limit();
}

DECL_EXPORT void* Graphic3d_StructureManager_Text3dAspect(void* instance)
{
	Graphic3d_StructureManager* result = (Graphic3d_StructureManager*)(((Handle_Graphic3d_StructureManager*)instance)->Access());
	return 	new Handle_Graphic3d_AspectText3d(	result->Text3dAspect());
}

DECL_EXPORT void Graphic3d_StructureManager_SetUpdateMode(void* instance, int value)
{
	Graphic3d_StructureManager* result = (Graphic3d_StructureManager*)(((Handle_Graphic3d_StructureManager*)instance)->Access());
		result->SetUpdateMode((const Aspect_TypeOfUpdate)value);
}

DECL_EXPORT int Graphic3d_StructureManager_UpdateMode(void* instance)
{
	Graphic3d_StructureManager* result = (Graphic3d_StructureManager*)(((Handle_Graphic3d_StructureManager*)instance)->Access());
	return (int)	result->UpdateMode();
}

DECL_EXPORT int Graphic3d_StructureManager_CurrentId()
{
	return Graphic3d_StructureManager::CurrentId();
}

DECL_EXPORT void* Graphic3d_StructureManager_GraphicDevice(void* instance)
{
	Graphic3d_StructureManager* result = (Graphic3d_StructureManager*)(((Handle_Graphic3d_StructureManager*)instance)->Access());
	return 	new Handle_Aspect_GraphicDevice(	result->GraphicDevice());
}

DECL_EXPORT void Graphic3dStructureManager_Dtor(void* instance)
{
	delete (Handle_Graphic3d_StructureManager*)instance;
}
