#include "AspectFontMap.h"
#include <Aspect_FontMap.hxx>

#include <Aspect_FontMapEntry.hxx>

DECL_EXPORT void* Aspect_FontMap_Ctor()
{
	return new Handle_Aspect_FontMap(new Aspect_FontMap());
}
DECL_EXPORT void Aspect_FontMap_AddEntryF998EDD2(
	void* instance,
	void* AnEntry)
{
		const Aspect_FontMapEntry &  _AnEntry =*(const Aspect_FontMapEntry *)AnEntry;
	Aspect_FontMap* result = (Aspect_FontMap*)(((Handle_Aspect_FontMap*)instance)->Access());
 	result->AddEntry(			
_AnEntry);
}
DECL_EXPORT int Aspect_FontMap_AddEntry8E648131(
	void* instance,
	void* aStyle)
{
		const Aspect_FontStyle &  _aStyle =*(const Aspect_FontStyle *)aStyle;
	Aspect_FontMap* result = (Aspect_FontMap*)(((Handle_Aspect_FontMap*)instance)->Access());
	return  	result->AddEntry(			
_aStyle);
}
DECL_EXPORT int Aspect_FontMap_IndexE8219145(
	void* instance,
	int aFontmapIndex)
{
	Aspect_FontMap* result = (Aspect_FontMap*)(((Handle_Aspect_FontMap*)instance)->Access());
	return  	result->Index(			
aFontmapIndex);
}
DECL_EXPORT void Aspect_FontMap_Dump(void* instance)
{
	Aspect_FontMap* result = (Aspect_FontMap*)(((Handle_Aspect_FontMap*)instance)->Access());
 	result->Dump();
}
DECL_EXPORT void* Aspect_FontMap_EntryE8219145(
	void* instance,
	int AnIndex)
{
	Aspect_FontMap* result = (Aspect_FontMap*)(((Handle_Aspect_FontMap*)instance)->Access());
	return new Aspect_FontMapEntry( 	result->Entry(			
AnIndex));
}
DECL_EXPORT int Aspect_FontMap_Size(void* instance)
{
	Aspect_FontMap* result = (Aspect_FontMap*)(((Handle_Aspect_FontMap*)instance)->Access());
	return 	result->Size();
}

DECL_EXPORT void AspectFontMap_Dtor(void* instance)
{
	delete (Handle_Aspect_FontMap*)instance;
}
