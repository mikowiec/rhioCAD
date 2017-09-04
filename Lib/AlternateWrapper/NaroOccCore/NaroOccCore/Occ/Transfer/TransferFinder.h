#ifndef Transfer_Finder_H
#define Transfer_Finder_H

#include "../../Export_Import.h"

extern "C" DECL_EXPORT void Transfer_Finder_SetAttributeD637E227(
	void* instance,
	char* name,
	void* val);
extern "C" DECL_EXPORT bool Transfer_Finder_RemoveAttribute9381D4D(
	void* instance,
	char* name);
extern "C" DECL_EXPORT bool Transfer_Finder_GetAttributeCBA201FA(
	void* instance,
	char* name,
	void* type,
	void* val);
extern "C" DECL_EXPORT void* Transfer_Finder_Attribute9381D4D(
	void* instance,
	char* name);
extern "C" DECL_EXPORT int Transfer_Finder_AttributeType9381D4D(
	void* instance,
	char* name);
extern "C" DECL_EXPORT void Transfer_Finder_SetIntegerAttribute800FADE1(
	void* instance,
	char* name,
	int val);
extern "C" DECL_EXPORT bool Transfer_Finder_GetIntegerAttribute800FADE1(
	void* instance,
	char* name,
	int* val);
extern "C" DECL_EXPORT int Transfer_Finder_IntegerAttribute9381D4D(
	void* instance,
	char* name);
extern "C" DECL_EXPORT void Transfer_Finder_SetRealAttribute28A665C3(
	void* instance,
	char* name,
	double val);
extern "C" DECL_EXPORT bool Transfer_Finder_GetRealAttribute28A665C3(
	void* instance,
	char* name,
	double* val);
extern "C" DECL_EXPORT double Transfer_Finder_RealAttribute9381D4D(
	void* instance,
	char* name);
extern "C" DECL_EXPORT void Transfer_Finder_SetStringAttribute8A1B7C71(
	void* instance,
	char* name,
	char* val);
extern "C" DECL_EXPORT bool Transfer_Finder_GetStringAttribute8A1B7C71(
	void* instance,
	char* name,
	char** val);
extern "C" DECL_EXPORT Standard_CString Transfer_Finder_StringAttribute9381D4D(
	void* instance,
	char* name);
extern "C" DECL_EXPORT void Transfer_Finder_SameAttributes62F97174(
	void* instance,
	void* other);
extern "C" DECL_EXPORT void Transfer_Finder_GetAttributesDA2BDE8C(
	void* instance,
	void* other,
	char* fromname,
	bool copied);
extern "C" DECL_EXPORT int Transfer_Finder_GetHashCode(void* instance);
extern "C" DECL_EXPORT void* Transfer_Finder_ValueType(void* instance);
extern "C" DECL_EXPORT Standard_CString Transfer_Finder_ValueTypeName(void* instance);
extern "C" DECL_EXPORT void* Transfer_Finder_AttrList(void* instance);
extern "C" DECL_EXPORT void TransferFinder_Dtor(void* instance);

#endif
