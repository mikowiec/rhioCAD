#ifndef CDM_Reference_H
#define CDM_Reference_H

#include "../../Export_Import.h"

extern "C" DECL_EXPORT void* CDM_Reference_FromDocument(void* instance);
extern "C" DECL_EXPORT void* CDM_Reference_ToDocument(void* instance);
extern "C" DECL_EXPORT int CDM_Reference_ReferenceIdentifier(void* instance);
extern "C" DECL_EXPORT int CDM_Reference_DocumentVersion(void* instance);
extern "C" DECL_EXPORT bool CDM_Reference_IsReadOnly(void* instance);
extern "C" DECL_EXPORT void CDMReference_Dtor(void* instance);

#endif
