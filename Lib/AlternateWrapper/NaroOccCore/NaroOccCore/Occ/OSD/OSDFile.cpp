#include "OSDFile.h"
#include <OSD_File.hxx>

#include <OSD_File.hxx>

DECL_EXPORT void* OSD_File_Ctor()
{
	return new OSD_File();
}
DECL_EXPORT void* OSD_File_CtorF0BBCC0E(
	void* Name)
{
		const OSD_Path &  _Name =*(const OSD_Path *)Name;
	return new OSD_File(			
_Name);
}
DECL_EXPORT void OSD_File_Build5E99AF11(
	void* instance,
	int Mode,
	void* Protect)
{
		const OSD_OpenMode _Mode =(const OSD_OpenMode )Mode;
		const OSD_Protection &  _Protect =*(const OSD_Protection *)Protect;
	OSD_File* result = (OSD_File*)instance;
 	result->Build(			
_Mode,			
_Protect);
}
DECL_EXPORT void OSD_File_Open5E99AF11(
	void* instance,
	int Mode,
	void* Protect)
{
		const OSD_OpenMode _Mode =(const OSD_OpenMode )Mode;
		const OSD_Protection &  _Protect =*(const OSD_Protection *)Protect;
	OSD_File* result = (OSD_File*)instance;
 	result->Open(			
_Mode,			
_Protect);
}
DECL_EXPORT void OSD_File_Append5E99AF11(
	void* instance,
	int Mode,
	void* Protect)
{
		const OSD_OpenMode _Mode =(const OSD_OpenMode )Mode;
		const OSD_Protection &  _Protect =*(const OSD_Protection *)Protect;
	OSD_File* result = (OSD_File*)instance;
 	result->Append(			
_Mode,			
_Protect);
}
DECL_EXPORT void OSD_File_ReadLine10E3C1BB(
	void* instance,
	void* Buffer,
	int NByte,
	int* NbyteRead)
{
		 TCollection_AsciiString &  _Buffer =*( TCollection_AsciiString *)Buffer;
	OSD_File* result = (OSD_File*)instance;
 	result->ReadLine(			
_Buffer,			
NByte,			
*NbyteRead);
}
DECL_EXPORT void OSD_File_Seek1868D864(
	void* instance,
	int Offset,
	int Whence)
{
		const OSD_FromWhere _Whence =(const OSD_FromWhere )Whence;
	OSD_File* result = (OSD_File*)instance;
 	result->Seek(			
Offset,			
_Whence);
}
DECL_EXPORT void OSD_File_Close(void* instance)
{
	OSD_File* result = (OSD_File*)instance;
 	result->Close();
}
DECL_EXPORT void OSD_File_UnLock(void* instance)
{
	OSD_File* result = (OSD_File*)instance;
 	result->UnLock();
}
DECL_EXPORT void OSD_File_Print21D3F920(
	void* instance,
	void* WhichPrinter)
{
		const OSD_Printer &  _WhichPrinter =*(const OSD_Printer *)WhichPrinter;
	OSD_File* result = (OSD_File*)instance;
 	result->Print(			
_WhichPrinter);
}
DECL_EXPORT bool OSD_File_ReadLastLine10E3C1BB(
	void* instance,
	void* aLine,
	int aDelay,
	int aNbTries)
{
		 TCollection_AsciiString &  _aLine =*( TCollection_AsciiString *)aLine;
	OSD_File* result = (OSD_File*)instance;
	return  	result->ReadLastLine(			
_aLine,			
aDelay,			
aNbTries);
}
DECL_EXPORT bool OSD_File_IsAtEnd(void* instance)
{
	OSD_File* result = (OSD_File*)instance;
	return 	result->IsAtEnd();
}

DECL_EXPORT int OSD_File_KindOfFile(void* instance)
{
	OSD_File* result = (OSD_File*)instance;
	return (int)	result->KindOfFile();
}

DECL_EXPORT void* OSD_File_BuildTemporary()
{
	return 	new OSD_File(OSD_File::BuildTemporary());
}

DECL_EXPORT void OSD_File_SetLock(void* instance, int value)
{
	OSD_File* result = (OSD_File*)instance;
		result->SetLock((const OSD_LockType)value);
}

DECL_EXPORT int OSD_File_GetLock(void* instance)
{
	OSD_File* result = (OSD_File*)instance;
	return (int)	result->GetLock();
}

DECL_EXPORT bool OSD_File_IsLocked(void* instance)
{
	OSD_File* result = (OSD_File*)instance;
	return 	result->IsLocked();
}

DECL_EXPORT int OSD_File_Size(void* instance)
{
	OSD_File* result = (OSD_File*)instance;
	return 	result->Size();
}

DECL_EXPORT bool OSD_File_IsOpen(void* instance)
{
	OSD_File* result = (OSD_File*)instance;
	return 	result->IsOpen();
}

DECL_EXPORT bool OSD_File_IsReadable(void* instance)
{
	OSD_File* result = (OSD_File*)instance;
	return 	result->IsReadable();
}

DECL_EXPORT bool OSD_File_IsWriteable(void* instance)
{
	OSD_File* result = (OSD_File*)instance;
	return 	result->IsWriteable();
}

DECL_EXPORT bool OSD_File_IsExecutable(void* instance)
{
	OSD_File* result = (OSD_File*)instance;
	return 	result->IsExecutable();
}

DECL_EXPORT bool OSD_File_Edit(void* instance)
{
	OSD_File* result = (OSD_File*)instance;
	return 	result->Edit();
}

DECL_EXPORT void OSDFile_Dtor(void* instance)
{
	delete (OSD_File*)instance;
}
