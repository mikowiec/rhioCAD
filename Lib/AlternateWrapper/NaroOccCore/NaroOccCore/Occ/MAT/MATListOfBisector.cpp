#include "MATListOfBisector.h"
#include <MAT_ListOfBisector.hxx>

#include <MAT_Bisector.hxx>

DECL_EXPORT void* MAT_ListOfBisector_Ctor()
{
	return new Handle_MAT_ListOfBisector(new MAT_ListOfBisector());
}
DECL_EXPORT void MAT_ListOfBisector_First(void* instance)
{
	MAT_ListOfBisector* result = (MAT_ListOfBisector*)(((Handle_MAT_ListOfBisector*)instance)->Access());
 	result->First();
}
DECL_EXPORT void MAT_ListOfBisector_Last(void* instance)
{
	MAT_ListOfBisector* result = (MAT_ListOfBisector*)(((Handle_MAT_ListOfBisector*)instance)->Access());
 	result->Last();
}
DECL_EXPORT void MAT_ListOfBisector_Init1F24E859(
	void* instance,
	void* aniten)
{
		const Handle_MAT_Bisector&  _aniten =*(const Handle_MAT_Bisector *)aniten;
	MAT_ListOfBisector* result = (MAT_ListOfBisector*)(((Handle_MAT_ListOfBisector*)instance)->Access());
 	result->Init(			
_aniten);
}
DECL_EXPORT void MAT_ListOfBisector_Next(void* instance)
{
	MAT_ListOfBisector* result = (MAT_ListOfBisector*)(((Handle_MAT_ListOfBisector*)instance)->Access());
 	result->Next();
}
DECL_EXPORT void MAT_ListOfBisector_Previous(void* instance)
{
	MAT_ListOfBisector* result = (MAT_ListOfBisector*)(((Handle_MAT_ListOfBisector*)instance)->Access());
 	result->Previous();
}
DECL_EXPORT void* MAT_ListOfBisector_Current(void* instance)
{
	MAT_ListOfBisector* result = (MAT_ListOfBisector*)(((Handle_MAT_ListOfBisector*)instance)->Access());
	return new Handle_MAT_Bisector( 	result->Current());
}
DECL_EXPORT void MAT_ListOfBisector_Current1F24E859(
	void* instance,
	void* anitem)
{
		const Handle_MAT_Bisector&  _anitem =*(const Handle_MAT_Bisector *)anitem;
	MAT_ListOfBisector* result = (MAT_ListOfBisector*)(((Handle_MAT_ListOfBisector*)instance)->Access());
 	result->Current(			
_anitem);
}
DECL_EXPORT void* MAT_ListOfBisector_BracketsE8219145(
	void* instance,
	int anindex)
{
	MAT_ListOfBisector* result = (MAT_ListOfBisector*)(((Handle_MAT_ListOfBisector*)instance)->Access());
	return new Handle_MAT_Bisector( 	result->Brackets(			
anindex));
}
DECL_EXPORT void MAT_ListOfBisector_Unlink(void* instance)
{
	MAT_ListOfBisector* result = (MAT_ListOfBisector*)(((Handle_MAT_ListOfBisector*)instance)->Access());
 	result->Unlink();
}
DECL_EXPORT void MAT_ListOfBisector_LinkBefore1F24E859(
	void* instance,
	void* anitem)
{
		const Handle_MAT_Bisector&  _anitem =*(const Handle_MAT_Bisector *)anitem;
	MAT_ListOfBisector* result = (MAT_ListOfBisector*)(((Handle_MAT_ListOfBisector*)instance)->Access());
 	result->LinkBefore(			
_anitem);
}
DECL_EXPORT void MAT_ListOfBisector_LinkAfter1F24E859(
	void* instance,
	void* anitem)
{
		const Handle_MAT_Bisector&  _anitem =*(const Handle_MAT_Bisector *)anitem;
	MAT_ListOfBisector* result = (MAT_ListOfBisector*)(((Handle_MAT_ListOfBisector*)instance)->Access());
 	result->LinkAfter(			
_anitem);
}
DECL_EXPORT void MAT_ListOfBisector_FrontAdd1F24E859(
	void* instance,
	void* anitem)
{
		const Handle_MAT_Bisector&  _anitem =*(const Handle_MAT_Bisector *)anitem;
	MAT_ListOfBisector* result = (MAT_ListOfBisector*)(((Handle_MAT_ListOfBisector*)instance)->Access());
 	result->FrontAdd(			
_anitem);
}
DECL_EXPORT void MAT_ListOfBisector_BackAdd1F24E859(
	void* instance,
	void* anitem)
{
		const Handle_MAT_Bisector&  _anitem =*(const Handle_MAT_Bisector *)anitem;
	MAT_ListOfBisector* result = (MAT_ListOfBisector*)(((Handle_MAT_ListOfBisector*)instance)->Access());
 	result->BackAdd(			
_anitem);
}
DECL_EXPORT void MAT_ListOfBisector_Permute(void* instance)
{
	MAT_ListOfBisector* result = (MAT_ListOfBisector*)(((Handle_MAT_ListOfBisector*)instance)->Access());
 	result->Permute();
}
DECL_EXPORT void MAT_ListOfBisector_Loop(void* instance)
{
	MAT_ListOfBisector* result = (MAT_ListOfBisector*)(((Handle_MAT_ListOfBisector*)instance)->Access());
 	result->Loop();
}
DECL_EXPORT void MAT_ListOfBisector_Dump5107F6FE(
	void* instance,
	int ashift,
	int alevel)
{
	MAT_ListOfBisector* result = (MAT_ListOfBisector*)(((Handle_MAT_ListOfBisector*)instance)->Access());
 	result->Dump(			
ashift,			
alevel);
}
DECL_EXPORT bool MAT_ListOfBisector_More(void* instance)
{
	MAT_ListOfBisector* result = (MAT_ListOfBisector*)(((Handle_MAT_ListOfBisector*)instance)->Access());
	return 	result->More();
}

DECL_EXPORT void* MAT_ListOfBisector_FirstItem(void* instance)
{
	MAT_ListOfBisector* result = (MAT_ListOfBisector*)(((Handle_MAT_ListOfBisector*)instance)->Access());
	return 	new Handle_MAT_Bisector(	result->FirstItem());
}

DECL_EXPORT void* MAT_ListOfBisector_LastItem(void* instance)
{
	MAT_ListOfBisector* result = (MAT_ListOfBisector*)(((Handle_MAT_ListOfBisector*)instance)->Access());
	return 	new Handle_MAT_Bisector(	result->LastItem());
}

DECL_EXPORT void* MAT_ListOfBisector_PreviousItem(void* instance)
{
	MAT_ListOfBisector* result = (MAT_ListOfBisector*)(((Handle_MAT_ListOfBisector*)instance)->Access());
	return 	new Handle_MAT_Bisector(	result->PreviousItem());
}

DECL_EXPORT void* MAT_ListOfBisector_NextItem(void* instance)
{
	MAT_ListOfBisector* result = (MAT_ListOfBisector*)(((Handle_MAT_ListOfBisector*)instance)->Access());
	return 	new Handle_MAT_Bisector(	result->NextItem());
}

DECL_EXPORT int MAT_ListOfBisector_Number(void* instance)
{
	MAT_ListOfBisector* result = (MAT_ListOfBisector*)(((Handle_MAT_ListOfBisector*)instance)->Access());
	return 	result->Number();
}

DECL_EXPORT int MAT_ListOfBisector_Index(void* instance)
{
	MAT_ListOfBisector* result = (MAT_ListOfBisector*)(((Handle_MAT_ListOfBisector*)instance)->Access());
	return 	result->Index();
}

DECL_EXPORT bool MAT_ListOfBisector_IsEmpty(void* instance)
{
	MAT_ListOfBisector* result = (MAT_ListOfBisector*)(((Handle_MAT_ListOfBisector*)instance)->Access());
	return 	result->IsEmpty();
}

DECL_EXPORT void MATListOfBisector_Dtor(void* instance)
{
	delete (Handle_MAT_ListOfBisector*)instance;
}
