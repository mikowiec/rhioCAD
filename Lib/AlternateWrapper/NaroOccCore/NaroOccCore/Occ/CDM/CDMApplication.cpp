#include "CDMApplication.h"
#include <CDM_Application.hxx>

#include <CDM_MessageDriver.hxx>

DECL_EXPORT void CDM_Application_BeginOfUpdate3DDF553A(
	void* instance,
	void* aDocument)
{
		const Handle_CDM_Document&  _aDocument =*(const Handle_CDM_Document *)aDocument;
	CDM_Application* result = (CDM_Application*)(((Handle_CDM_Application*)instance)->Access());
 	result->BeginOfUpdate(			
_aDocument);
}
DECL_EXPORT void CDM_Application_EndOfUpdateE3A9B7F3(
	void* instance,
	void* aDocument,
	bool Status,
	void* ErrorString)
{
		const Handle_CDM_Document&  _aDocument =*(const Handle_CDM_Document *)aDocument;
		const TCollection_ExtendedString &  _ErrorString =*(const TCollection_ExtendedString *)ErrorString;
	CDM_Application* result = (CDM_Application*)(((Handle_CDM_Application*)instance)->Access());
 	result->EndOfUpdate(			
_aDocument,			
Status,			
_ErrorString);
}
DECL_EXPORT void CDM_Application_Write9381D4D(
	void* instance,
	char* aString)
{
	CDM_Application* result = (CDM_Application*)(((Handle_CDM_Application*)instance)->Access());
 	result->Write(			
(short*)aString);
}
DECL_EXPORT void* CDM_Application_MessageDriver(void* instance)
{
	CDM_Application* result = (CDM_Application*)(((Handle_CDM_Application*)instance)->Access());
	return 	new Handle_CDM_MessageDriver(	result->MessageDriver());
}

DECL_EXPORT void CDMApplication_Dtor(void* instance)
{
	delete (Handle_CDM_Application*)instance;
}
