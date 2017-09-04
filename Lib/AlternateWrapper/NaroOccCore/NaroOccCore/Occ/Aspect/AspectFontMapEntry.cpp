#include "AspectFontMapEntry.h"
#include <Aspect_FontMapEntry.hxx>

#include <Aspect_FontStyle.hxx>

DECL_EXPORT void* Aspect_FontMapEntry_Ctor()
{
	return new Aspect_FontMapEntry();
}
DECL_EXPORT void* Aspect_FontMapEntry_Ctor387C7A2F(
	int index,
	void* style)
{
		const Aspect_FontStyle &  _style =*(const Aspect_FontStyle *)style;
	return new Aspect_FontMapEntry(			
index,			
_style);
}
DECL_EXPORT void* Aspect_FontMapEntry_CtorF998EDD2(
	void* entry)
{
		const Aspect_FontMapEntry &  _entry =*(const Aspect_FontMapEntry *)entry;
	return new Aspect_FontMapEntry(			
_entry);
}
DECL_EXPORT void Aspect_FontMapEntry_SetValue387C7A2F(
	void* instance,
	int index,
	void* style)
{
		const Aspect_FontStyle &  _style =*(const Aspect_FontStyle *)style;
	Aspect_FontMapEntry* result = (Aspect_FontMapEntry*)instance;
 	result->SetValue(			
index,			
_style);
}
DECL_EXPORT void Aspect_FontMapEntry_SetValueF998EDD2(
	void* instance,
	void* entry)
{
		const Aspect_FontMapEntry &  _entry =*(const Aspect_FontMapEntry *)entry;
	Aspect_FontMapEntry* result = (Aspect_FontMapEntry*)instance;
 	result->SetValue(			
_entry);
}
DECL_EXPORT void Aspect_FontMapEntry_Free(void* instance)
{
	Aspect_FontMapEntry* result = (Aspect_FontMapEntry*)instance;
 	result->Free();
}
DECL_EXPORT void Aspect_FontMapEntry_Dump(void* instance)
{
	Aspect_FontMapEntry* result = (Aspect_FontMapEntry*)instance;
 	result->Dump();
}
DECL_EXPORT void Aspect_FontMapEntry_SetType(void* instance, void* value)
{
	Aspect_FontMapEntry* result = (Aspect_FontMapEntry*)instance;
		result->SetType(*(const Aspect_FontStyle *)value);
}

DECL_EXPORT void* Aspect_FontMapEntry_Type(void* instance)
{
	Aspect_FontMapEntry* result = (Aspect_FontMapEntry*)instance;
	return 	new Aspect_FontStyle(	result->Type());
}

DECL_EXPORT void Aspect_FontMapEntry_SetIndex(void* instance, int value)
{
	Aspect_FontMapEntry* result = (Aspect_FontMapEntry*)instance;
		result->SetIndex(value);
}

DECL_EXPORT int Aspect_FontMapEntry_Index(void* instance)
{
	Aspect_FontMapEntry* result = (Aspect_FontMapEntry*)instance;
	return 	result->Index();
}

DECL_EXPORT bool Aspect_FontMapEntry_IsAllocated(void* instance)
{
	Aspect_FontMapEntry* result = (Aspect_FontMapEntry*)instance;
	return 	result->IsAllocated();
}

DECL_EXPORT void AspectFontMapEntry_Dtor(void* instance)
{
	delete (Aspect_FontMapEntry*)instance;
}
