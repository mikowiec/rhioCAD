#include "OSDPrinter.h"
#include <OSD_Printer.hxx>


DECL_EXPORT void* OSD_Printer_Ctor66CFACD0(
	void* Name)
{
		const TCollection_AsciiString &  _Name =*(const TCollection_AsciiString *)Name;
	return new OSD_Printer(			
_Name);
}
DECL_EXPORT void OSD_Printer_SetName66CFACD0(
	void* instance,
	void* Name)
{
		const TCollection_AsciiString &  _Name =*(const TCollection_AsciiString *)Name;
	OSD_Printer* result = (OSD_Printer*)instance;
 	result->SetName(			
_Name);
}
DECL_EXPORT void OSD_Printer_Name66CFACD0(
	void* instance,
	void* Name)
{
		 TCollection_AsciiString &  _Name =*( TCollection_AsciiString *)Name;
	OSD_Printer* result = (OSD_Printer*)instance;
 	result->Name(			
_Name);
}
DECL_EXPORT void OSD_Printer_Reset(void* instance)
{
	OSD_Printer* result = (OSD_Printer*)instance;
 	result->Reset();
}
DECL_EXPORT void OSD_Printer_Perror(void* instance)
{
	OSD_Printer* result = (OSD_Printer*)instance;
 	result->Perror();
}
DECL_EXPORT bool OSD_Printer_Failed(void* instance)
{
	OSD_Printer* result = (OSD_Printer*)instance;
	return 	result->Failed();
}

DECL_EXPORT int OSD_Printer_Error(void* instance)
{
	OSD_Printer* result = (OSD_Printer*)instance;
	return 	result->Error();
}

DECL_EXPORT void OSDPrinter_Dtor(void* instance)
{
	delete (OSD_Printer*)instance;
}
