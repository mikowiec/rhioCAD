#include "OSDFileNode.h"
#include <OSD_FileNode.hxx>

#include <OSD_Protection.hxx>
#include <Quantity_Date.hxx>

DECL_EXPORT void OSD_FileNode_PathF0BBCC0E(
	void* instance,
	void* Name)
{
		 OSD_Path &  _Name =*( OSD_Path *)Name;
	OSD_FileNode* result = (OSD_FileNode*)instance;
 	result->Path(			
_Name);
}
DECL_EXPORT void OSD_FileNode_SetPathF0BBCC0E(
	void* instance,
	void* Name)
{
		const OSD_Path &  _Name =*(const OSD_Path *)Name;
	OSD_FileNode* result = (OSD_FileNode*)instance;
 	result->SetPath(			
_Name);
}
DECL_EXPORT void OSD_FileNode_Remove(void* instance)
{
	OSD_FileNode* result = (OSD_FileNode*)instance;
 	result->Remove();
}
DECL_EXPORT void OSD_FileNode_MoveF0BBCC0E(
	void* instance,
	void* NewPath)
{
		const OSD_Path &  _NewPath =*(const OSD_Path *)NewPath;
	OSD_FileNode* result = (OSD_FileNode*)instance;
 	result->Move(			
_NewPath);
}
DECL_EXPORT void OSD_FileNode_CopyF0BBCC0E(
	void* instance,
	void* ToPath)
{
		const OSD_Path &  _ToPath =*(const OSD_Path *)ToPath;
	OSD_FileNode* result = (OSD_FileNode*)instance;
 	result->Copy(			
_ToPath);
}
DECL_EXPORT void OSD_FileNode_Reset(void* instance)
{
	OSD_FileNode* result = (OSD_FileNode*)instance;
 	result->Reset();
}
DECL_EXPORT void OSD_FileNode_Perror(void* instance)
{
	OSD_FileNode* result = (OSD_FileNode*)instance;
 	result->Perror();
}
DECL_EXPORT bool OSD_FileNode_Exists(void* instance)
{
	OSD_FileNode* result = (OSD_FileNode*)instance;
	return 	result->Exists();
}

DECL_EXPORT void OSD_FileNode_SetProtection(void* instance, void* value)
{
	OSD_FileNode* result = (OSD_FileNode*)instance;
		result->SetProtection(*(const OSD_Protection *)value);
}

DECL_EXPORT void* OSD_FileNode_Protection(void* instance)
{
	OSD_FileNode* result = (OSD_FileNode*)instance;
	return 	new OSD_Protection(	result->Protection());
}

DECL_EXPORT void* OSD_FileNode_AccessMoment(void* instance)
{
	OSD_FileNode* result = (OSD_FileNode*)instance;
	return 	new Quantity_Date(	result->AccessMoment());
}

DECL_EXPORT void* OSD_FileNode_CreationMoment(void* instance)
{
	OSD_FileNode* result = (OSD_FileNode*)instance;
	return 	new Quantity_Date(	result->CreationMoment());
}

DECL_EXPORT int OSD_FileNode_UserId(void* instance)
{
	OSD_FileNode* result = (OSD_FileNode*)instance;
	return 	result->UserId();
}

DECL_EXPORT int OSD_FileNode_GroupId(void* instance)
{
	OSD_FileNode* result = (OSD_FileNode*)instance;
	return 	result->GroupId();
}

DECL_EXPORT bool OSD_FileNode_Failed(void* instance)
{
	OSD_FileNode* result = (OSD_FileNode*)instance;
	return 	result->Failed();
}

DECL_EXPORT int OSD_FileNode_Error(void* instance)
{
	OSD_FileNode* result = (OSD_FileNode*)instance;
	return 	result->Error();
}

DECL_EXPORT void OSDFileNode_Dtor(void* instance)
{
	delete (OSD_FileNode*)instance;
}
