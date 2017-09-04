#ifndef OSD_Path_H
#define OSD_Path_H

#include "../../Export_Import.h"

extern "C" DECL_EXPORT void* OSD_Path_Ctor();
extern "C" DECL_EXPORT void* OSD_Path_Ctor6DB22F5E(
	void* aDependentName,
	int aSysType);
extern "C" DECL_EXPORT void* OSD_Path_CtorA8CFE3FC(
	void* aNode,
	void* aUsername,
	void* aPassword,
	void* aDisk,
	void* aTrek,
	void* aName,
	void* anExtension);
extern "C" DECL_EXPORT void OSD_Path_ValuesA8CFE3FC(
	void* instance,
	void* aNode,
	void* aUsername,
	void* aPassword,
	void* aDisk,
	void* aTrek,
	void* aName,
	void* anExtension);
extern "C" DECL_EXPORT void OSD_Path_SetValuesA8CFE3FC(
	void* instance,
	void* aNode,
	void* aUsername,
	void* aPassword,
	void* aDisk,
	void* aTrek,
	void* aName,
	void* anExtension);
extern "C" DECL_EXPORT void OSD_Path_SystemName6DB22F5E(
	void* instance,
	void* FullName,
	int aType);
extern "C" DECL_EXPORT void OSD_Path_ExpandedName66CFACD0(
	void* instance,
	void* aName);
extern "C" DECL_EXPORT bool OSD_Path_IsValid6DB22F5E(
	void* instance,
	void* aDependentName,
	int aSysType);
extern "C" DECL_EXPORT void OSD_Path_UpTrek(void* instance);
extern "C" DECL_EXPORT void OSD_Path_DownTrek66CFACD0(
	void* instance,
	void* aName);
extern "C" DECL_EXPORT void OSD_Path_RemoveATrekE8219145(
	void* instance,
	int where);
extern "C" DECL_EXPORT void OSD_Path_RemoveATrek66CFACD0(
	void* instance,
	void* aName);
extern "C" DECL_EXPORT void* OSD_Path_TrekValueE8219145(
	void* instance,
	int where);
extern "C" DECL_EXPORT void OSD_Path_InsertATrekCAFD1949(
	void* instance,
	void* aName,
	int where);
extern "C" DECL_EXPORT void* OSD_Path_RelativePathB82186D3(
	void* DirPath,
	void* AbsFilePath);
extern "C" DECL_EXPORT void* OSD_Path_AbsolutePathB82186D3(
	void* DirPath,
	void* RelFilePath);
extern "C" DECL_EXPORT int OSD_Path_TrekLength(void* instance);
extern "C" DECL_EXPORT void OSD_Path_SetNode(void* instance, void* value);
extern "C" DECL_EXPORT void* OSD_Path_Node(void* instance);
extern "C" DECL_EXPORT void OSD_Path_SetUserName(void* instance, void* value);
extern "C" DECL_EXPORT void* OSD_Path_UserName(void* instance);
extern "C" DECL_EXPORT void OSD_Path_SetPassword(void* instance, void* value);
extern "C" DECL_EXPORT void* OSD_Path_Password(void* instance);
extern "C" DECL_EXPORT void OSD_Path_SetDisk(void* instance, void* value);
extern "C" DECL_EXPORT void* OSD_Path_Disk(void* instance);
extern "C" DECL_EXPORT void OSD_Path_SetTrek(void* instance, void* value);
extern "C" DECL_EXPORT void* OSD_Path_Trek(void* instance);
extern "C" DECL_EXPORT void OSD_Path_SetName(void* instance, void* value);
extern "C" DECL_EXPORT void* OSD_Path_Name(void* instance);
extern "C" DECL_EXPORT void OSD_Path_SetExtension(void* instance, void* value);
extern "C" DECL_EXPORT void* OSD_Path_Extension(void* instance);
extern "C" DECL_EXPORT void OSDPath_Dtor(void* instance);

#endif
