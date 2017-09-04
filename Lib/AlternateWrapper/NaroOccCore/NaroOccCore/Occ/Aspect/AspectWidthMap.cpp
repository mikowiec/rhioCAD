#include "AspectWidthMap.h"
#include <Aspect_WidthMap.hxx>

#include <Aspect_WidthMapEntry.hxx>

DECL_EXPORT void* Aspect_WidthMap_Ctor()
{
	return new Handle_Aspect_WidthMap(new Aspect_WidthMap());
}
DECL_EXPORT void Aspect_WidthMap_AddEntry290679CE(
	void* instance,
	void* AnEntry)
{
		const Aspect_WidthMapEntry &  _AnEntry =*(const Aspect_WidthMapEntry *)AnEntry;
	Aspect_WidthMap* result = (Aspect_WidthMap*)(((Handle_Aspect_WidthMap*)instance)->Access());
 	result->AddEntry(			
_AnEntry);
}
DECL_EXPORT int Aspect_WidthMap_AddEntry82DA6A16(
	void* instance,
	int aStyle)
{
		const Aspect_WidthOfLine _aStyle =(const Aspect_WidthOfLine )aStyle;
	Aspect_WidthMap* result = (Aspect_WidthMap*)(((Handle_Aspect_WidthMap*)instance)->Access());
	return  	result->AddEntry(			
_aStyle);
}
DECL_EXPORT int Aspect_WidthMap_AddEntryD82819F3(
	void* instance,
	double aStyle)
{
	Aspect_WidthMap* result = (Aspect_WidthMap*)(((Handle_Aspect_WidthMap*)instance)->Access());
	return  	result->AddEntry(			
aStyle);
}
DECL_EXPORT int Aspect_WidthMap_IndexE8219145(
	void* instance,
	int aWidthmapIndex)
{
	Aspect_WidthMap* result = (Aspect_WidthMap*)(((Handle_Aspect_WidthMap*)instance)->Access());
	return  	result->Index(			
aWidthmapIndex);
}
DECL_EXPORT void* Aspect_WidthMap_EntryE8219145(
	void* instance,
	int AnIndex)
{
	Aspect_WidthMap* result = (Aspect_WidthMap*)(((Handle_Aspect_WidthMap*)instance)->Access());
	return new Aspect_WidthMapEntry( 	result->Entry(			
AnIndex));
}
DECL_EXPORT void Aspect_WidthMap_Dump(void* instance)
{
	Aspect_WidthMap* result = (Aspect_WidthMap*)(((Handle_Aspect_WidthMap*)instance)->Access());
 	result->Dump();
}
DECL_EXPORT int Aspect_WidthMap_Size(void* instance)
{
	Aspect_WidthMap* result = (Aspect_WidthMap*)(((Handle_Aspect_WidthMap*)instance)->Access());
	return 	result->Size();
}

DECL_EXPORT void AspectWidthMap_Dtor(void* instance)
{
	delete (Handle_Aspect_WidthMap*)instance;
}
