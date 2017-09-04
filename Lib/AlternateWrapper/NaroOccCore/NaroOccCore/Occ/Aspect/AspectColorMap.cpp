#include "AspectColorMap.h"
#include <Aspect_ColorMap.hxx>

#include <Aspect_ColorMapEntry.hxx>

DECL_EXPORT int Aspect_ColorMap_IndexE8219145(
	void* instance,
	int aColormapIndex)
{
	Aspect_ColorMap* result = (Aspect_ColorMap*)(((Handle_Aspect_ColorMap*)instance)->Access());
	return  	result->Index(			
aColormapIndex);
}
DECL_EXPORT void Aspect_ColorMap_Dump(void* instance)
{
	Aspect_ColorMap* result = (Aspect_ColorMap*)(((Handle_Aspect_ColorMap*)instance)->Access());
 	result->Dump();
}
DECL_EXPORT void* Aspect_ColorMap_EntryE8219145(
	void* instance,
	int AColorMapIndex)
{
	Aspect_ColorMap* result = (Aspect_ColorMap*)(((Handle_Aspect_ColorMap*)instance)->Access());
	return new Aspect_ColorMapEntry( 	result->Entry(			
AColorMapIndex));
}
DECL_EXPORT int Aspect_ColorMap_Type(void* instance)
{
	Aspect_ColorMap* result = (Aspect_ColorMap*)(((Handle_Aspect_ColorMap*)instance)->Access());
	return (int)	result->Type();
}

DECL_EXPORT int Aspect_ColorMap_Size(void* instance)
{
	Aspect_ColorMap* result = (Aspect_ColorMap*)(((Handle_Aspect_ColorMap*)instance)->Access());
	return 	result->Size();
}

DECL_EXPORT void AspectColorMap_Dtor(void* instance)
{
	delete (Handle_Aspect_ColorMap*)instance;
}
