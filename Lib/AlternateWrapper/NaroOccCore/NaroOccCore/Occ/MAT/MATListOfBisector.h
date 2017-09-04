#ifndef MAT_ListOfBisector_H
#define MAT_ListOfBisector_H

#include "../../Export_Import.h"

extern "C" DECL_EXPORT void* MAT_ListOfBisector_Ctor();
extern "C" DECL_EXPORT void MAT_ListOfBisector_First(void* instance);
extern "C" DECL_EXPORT void MAT_ListOfBisector_Last(void* instance);
extern "C" DECL_EXPORT void MAT_ListOfBisector_Init1F24E859(
	void* instance,
	void* aniten);
extern "C" DECL_EXPORT void MAT_ListOfBisector_Next(void* instance);
extern "C" DECL_EXPORT void MAT_ListOfBisector_Previous(void* instance);
extern "C" DECL_EXPORT void* MAT_ListOfBisector_Current(void* instance);
extern "C" DECL_EXPORT void MAT_ListOfBisector_Current1F24E859(
	void* instance,
	void* anitem);
extern "C" DECL_EXPORT void* MAT_ListOfBisector_BracketsE8219145(
	void* instance,
	int anindex);
extern "C" DECL_EXPORT void MAT_ListOfBisector_Unlink(void* instance);
extern "C" DECL_EXPORT void MAT_ListOfBisector_LinkBefore1F24E859(
	void* instance,
	void* anitem);
extern "C" DECL_EXPORT void MAT_ListOfBisector_LinkAfter1F24E859(
	void* instance,
	void* anitem);
extern "C" DECL_EXPORT void MAT_ListOfBisector_FrontAdd1F24E859(
	void* instance,
	void* anitem);
extern "C" DECL_EXPORT void MAT_ListOfBisector_BackAdd1F24E859(
	void* instance,
	void* anitem);
extern "C" DECL_EXPORT void MAT_ListOfBisector_Permute(void* instance);
extern "C" DECL_EXPORT void MAT_ListOfBisector_Loop(void* instance);
extern "C" DECL_EXPORT void MAT_ListOfBisector_Dump5107F6FE(
	void* instance,
	int ashift,
	int alevel);
extern "C" DECL_EXPORT bool MAT_ListOfBisector_More(void* instance);
extern "C" DECL_EXPORT void* MAT_ListOfBisector_FirstItem(void* instance);
extern "C" DECL_EXPORT void* MAT_ListOfBisector_LastItem(void* instance);
extern "C" DECL_EXPORT void* MAT_ListOfBisector_PreviousItem(void* instance);
extern "C" DECL_EXPORT void* MAT_ListOfBisector_NextItem(void* instance);
extern "C" DECL_EXPORT int MAT_ListOfBisector_Number(void* instance);
extern "C" DECL_EXPORT int MAT_ListOfBisector_Index(void* instance);
extern "C" DECL_EXPORT bool MAT_ListOfBisector_IsEmpty(void* instance);
extern "C" DECL_EXPORT void MATListOfBisector_Dtor(void* instance);

#endif
