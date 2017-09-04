#include "AspectWindow.h"
#include <Aspect_Window.hxx>

#include <Aspect_Background.hxx>
#include <Aspect_GraphicDevice.hxx>

DECL_EXPORT void* Aspect_Window_Background(void* instance)
{
	Aspect_Window* result = (Aspect_Window*)(((Handle_Aspect_Window*)instance)->Access());
	return 	new Aspect_Background(	result->Background());
}

DECL_EXPORT Standard_CString Aspect_Window_BackgroundImage(void* instance)
{
	Aspect_Window* result = (Aspect_Window*)(((Handle_Aspect_Window*)instance)->Access());
	return 	result->BackgroundImage();
}

DECL_EXPORT int Aspect_Window_BackgroundFillMethod(void* instance)
{
	Aspect_Window* result = (Aspect_Window*)(((Handle_Aspect_Window*)instance)->Access());
	return (int)	result->BackgroundFillMethod();
}

DECL_EXPORT void* Aspect_Window_HBackground(void* instance)
{
	Aspect_Window* result = (Aspect_Window*)(((Handle_Aspect_Window*)instance)->Access());
	return 	result->HBackground();
}

DECL_EXPORT void* Aspect_Window_GraphicDevice(void* instance)
{
	Aspect_Window* result = (Aspect_Window*)(((Handle_Aspect_Window*)instance)->Access());
	return 	new Handle_Aspect_GraphicDevice(	result->GraphicDevice());
}

DECL_EXPORT bool Aspect_Window_IsVirtual(void* instance)
{
	Aspect_Window* result = (Aspect_Window*)(((Handle_Aspect_Window*)instance)->Access());
	return 	result->IsVirtual();
}

DECL_EXPORT void Aspect_Window_SetVirtual(void* instance, bool value)
{
	Aspect_Window* result = (Aspect_Window*)(((Handle_Aspect_Window*)instance)->Access());
		result->SetVirtual(value);
}

DECL_EXPORT void AspectWindow_Dtor(void* instance)
{
	delete (Handle_Aspect_Window*)instance;
}
