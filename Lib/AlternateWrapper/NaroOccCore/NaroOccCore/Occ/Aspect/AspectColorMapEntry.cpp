#include "AspectColorMapEntry.h"
#include <Aspect_ColorMapEntry.hxx>

#include <Quantity_Color.hxx>

DECL_EXPORT void* Aspect_ColorMapEntry_Ctor()
{
	return new Aspect_ColorMapEntry();
}
DECL_EXPORT void* Aspect_ColorMapEntry_Ctor8575C8EE(
	int index,
	void* rgb)
{
		const Quantity_Color &  _rgb =*(const Quantity_Color *)rgb;
	return new Aspect_ColorMapEntry(			
index,			
_rgb);
}
DECL_EXPORT void* Aspect_ColorMapEntry_CtorE9FD56D3(
	void* entry)
{
		const Aspect_ColorMapEntry &  _entry =*(const Aspect_ColorMapEntry *)entry;
	return new Aspect_ColorMapEntry(			
_entry);
}
DECL_EXPORT void Aspect_ColorMapEntry_SetValue8575C8EE(
	void* instance,
	int index,
	void* rgb)
{
		const Quantity_Color &  _rgb =*(const Quantity_Color *)rgb;
	Aspect_ColorMapEntry* result = (Aspect_ColorMapEntry*)instance;
 	result->SetValue(			
index,			
_rgb);
}
DECL_EXPORT void Aspect_ColorMapEntry_SetValueE9FD56D3(
	void* instance,
	void* entry)
{
		const Aspect_ColorMapEntry &  _entry =*(const Aspect_ColorMapEntry *)entry;
	Aspect_ColorMapEntry* result = (Aspect_ColorMapEntry*)instance;
 	result->SetValue(			
_entry);
}
DECL_EXPORT void Aspect_ColorMapEntry_Free(void* instance)
{
	Aspect_ColorMapEntry* result = (Aspect_ColorMapEntry*)instance;
 	result->Free();
}
DECL_EXPORT void Aspect_ColorMapEntry_Dump(void* instance)
{
	Aspect_ColorMapEntry* result = (Aspect_ColorMapEntry*)instance;
 	result->Dump();
}
DECL_EXPORT void Aspect_ColorMapEntry_SetColor(void* instance, void* value)
{
	Aspect_ColorMapEntry* result = (Aspect_ColorMapEntry*)instance;
		result->SetColor(*(const Quantity_Color *)value);
}

DECL_EXPORT void* Aspect_ColorMapEntry_Color(void* instance)
{
	Aspect_ColorMapEntry* result = (Aspect_ColorMapEntry*)instance;
	return 	new Quantity_Color(	result->Color());
}

DECL_EXPORT void Aspect_ColorMapEntry_SetIndex(void* instance, int value)
{
	Aspect_ColorMapEntry* result = (Aspect_ColorMapEntry*)instance;
		result->SetIndex(value);
}

DECL_EXPORT int Aspect_ColorMapEntry_Index(void* instance)
{
	Aspect_ColorMapEntry* result = (Aspect_ColorMapEntry*)instance;
	return 	result->Index();
}

DECL_EXPORT bool Aspect_ColorMapEntry_IsAllocated(void* instance)
{
	Aspect_ColorMapEntry* result = (Aspect_ColorMapEntry*)instance;
	return 	result->IsAllocated();
}

DECL_EXPORT void AspectColorMapEntry_Dtor(void* instance)
{
	delete (Aspect_ColorMapEntry*)instance;
}
