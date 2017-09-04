#include "CDMReference.h"
#include <CDM_Reference.hxx>

#include <CDM_Document.hxx>

DECL_EXPORT void* CDM_Reference_FromDocument(void* instance)
{
	CDM_Reference* result = (CDM_Reference*)(((Handle_CDM_Reference*)instance)->Access());
	return 	new Handle_CDM_Document(	result->FromDocument());
}

DECL_EXPORT void* CDM_Reference_ToDocument(void* instance)
{
	CDM_Reference* result = (CDM_Reference*)(((Handle_CDM_Reference*)instance)->Access());
	return 	new Handle_CDM_Document(	result->ToDocument());
}

DECL_EXPORT int CDM_Reference_ReferenceIdentifier(void* instance)
{
	CDM_Reference* result = (CDM_Reference*)(((Handle_CDM_Reference*)instance)->Access());
	return 	result->ReferenceIdentifier();
}

DECL_EXPORT int CDM_Reference_DocumentVersion(void* instance)
{
	CDM_Reference* result = (CDM_Reference*)(((Handle_CDM_Reference*)instance)->Access());
	return 	result->DocumentVersion();
}

DECL_EXPORT bool CDM_Reference_IsReadOnly(void* instance)
{
	CDM_Reference* result = (CDM_Reference*)(((Handle_CDM_Reference*)instance)->Access());
	return 	result->IsReadOnly();
}

DECL_EXPORT void CDMReference_Dtor(void* instance)
{
	delete (Handle_CDM_Reference*)instance;
}
