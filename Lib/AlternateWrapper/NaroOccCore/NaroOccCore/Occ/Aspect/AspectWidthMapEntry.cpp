#include "AspectWidthMapEntry.h"
#include <Aspect_WidthMapEntry.hxx>


DECL_EXPORT void* Aspect_WidthMapEntry_Ctor()
{
	return new Aspect_WidthMapEntry();
}
DECL_EXPORT void* Aspect_WidthMapEntry_CtorA80F21D5(
	int index,
	int style)
{
		const Aspect_WidthOfLine _style =(const Aspect_WidthOfLine )style;
	return new Aspect_WidthMapEntry(			
index,			
_style);
}
DECL_EXPORT void* Aspect_WidthMapEntry_Ctor69F5FCCD(
	int index,
	double width)
{
	return new Aspect_WidthMapEntry(			
index,			
width);
}
DECL_EXPORT void* Aspect_WidthMapEntry_Ctor290679CE(
	void* entry)
{
		const Aspect_WidthMapEntry &  _entry =*(const Aspect_WidthMapEntry *)entry;
	return new Aspect_WidthMapEntry(			
_entry);
}
DECL_EXPORT void Aspect_WidthMapEntry_SetValueA80F21D5(
	void* instance,
	int index,
	int style)
{
		const Aspect_WidthOfLine _style =(const Aspect_WidthOfLine )style;
	Aspect_WidthMapEntry* result = (Aspect_WidthMapEntry*)instance;
 	result->SetValue(			
index,			
_style);
}
DECL_EXPORT void Aspect_WidthMapEntry_SetValue69F5FCCD(
	void* instance,
	int index,
	double width)
{
	Aspect_WidthMapEntry* result = (Aspect_WidthMapEntry*)instance;
 	result->SetValue(			
index,			
width);
}
DECL_EXPORT void Aspect_WidthMapEntry_SetValue290679CE(
	void* instance,
	void* entry)
{
		const Aspect_WidthMapEntry &  _entry =*(const Aspect_WidthMapEntry *)entry;
	Aspect_WidthMapEntry* result = (Aspect_WidthMapEntry*)instance;
 	result->SetValue(			
_entry);
}
DECL_EXPORT void Aspect_WidthMapEntry_Free(void* instance)
{
	Aspect_WidthMapEntry* result = (Aspect_WidthMapEntry*)instance;
 	result->Free();
}
DECL_EXPORT void Aspect_WidthMapEntry_Dump(void* instance)
{
	Aspect_WidthMapEntry* result = (Aspect_WidthMapEntry*)instance;
 	result->Dump();
}
DECL_EXPORT void Aspect_WidthMapEntry_SetType(void* instance, int value)
{
	Aspect_WidthMapEntry* result = (Aspect_WidthMapEntry*)instance;
		result->SetType((const Aspect_WidthOfLine)value);
}

DECL_EXPORT int Aspect_WidthMapEntry_Type(void* instance)
{
	Aspect_WidthMapEntry* result = (Aspect_WidthMapEntry*)instance;
	return (int)	result->Type();
}

DECL_EXPORT void Aspect_WidthMapEntry_SetWidth(void* instance, double value)
{
	Aspect_WidthMapEntry* result = (Aspect_WidthMapEntry*)instance;
		result->SetWidth(value);
}

DECL_EXPORT double Aspect_WidthMapEntry_Width(void* instance)
{
	Aspect_WidthMapEntry* result = (Aspect_WidthMapEntry*)instance;
	return 	result->Width();
}

DECL_EXPORT void Aspect_WidthMapEntry_SetIndex(void* instance, int value)
{
	Aspect_WidthMapEntry* result = (Aspect_WidthMapEntry*)instance;
		result->SetIndex(value);
}

DECL_EXPORT int Aspect_WidthMapEntry_Index(void* instance)
{
	Aspect_WidthMapEntry* result = (Aspect_WidthMapEntry*)instance;
	return 	result->Index();
}

DECL_EXPORT bool Aspect_WidthMapEntry_IsAllocated(void* instance)
{
	Aspect_WidthMapEntry* result = (Aspect_WidthMapEntry*)instance;
	return 	result->IsAllocated();
}

DECL_EXPORT void AspectWidthMapEntry_Dtor(void* instance)
{
	delete (Aspect_WidthMapEntry*)instance;
}
