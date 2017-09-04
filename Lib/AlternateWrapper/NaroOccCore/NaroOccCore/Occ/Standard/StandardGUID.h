#ifndef Standard_GUID_H
#define Standard_GUID_H

#include "../../Export_Import.h"

extern "C" DECL_EXPORT void* Standard_GUID_Ctor();
extern "C" DECL_EXPORT void* Standard_GUID_Ctor9381D4D(
	char* aGuid);
extern "C" DECL_EXPORT void* Standard_GUID_Ctor8CF7F0B1(
	int a32b,
	char a16b1,
	char a16b2,
	char a16b3,
	int a8b1,
	int a8b2,
	int a8b3,
	int a8b4,
	int a8b5,
	int a8b6);
extern "C" DECL_EXPORT void* Standard_GUID_CtorD6AA2C7F(
	void* aGuid);
extern "C" DECL_EXPORT bool Standard_GUID_IsSameD6AA2C7F(
	void* instance,
	void* uid);
extern "C" DECL_EXPORT bool Standard_GUID_IsNotSameD6AA2C7F(
	void* instance,
	void* uid);
extern "C" DECL_EXPORT bool Standard_GUID_CheckGUIDFormat9381D4D(
	char* aGuid);
extern "C" DECL_EXPORT int Standard_GUID_HashE8219145(
	void* instance,
	int Upper);
extern "C" DECL_EXPORT int Standard_GUID_HashCode5D88501F(
	void* aguid,
	int Upper);
extern "C" DECL_EXPORT bool Standard_GUID_IsEqualD560E032(
	void* string1,
	void* string2);
extern "C" DECL_EXPORT void StandardGUID_Dtor(void* instance);

#endif
