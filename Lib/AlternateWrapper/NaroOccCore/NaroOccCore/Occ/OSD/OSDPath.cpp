#include "OSDPath.h"
#include <OSD_Path.hxx>

#include <TCollection_AsciiString.hxx>

DECL_EXPORT void* OSD_Path_Ctor()
{
	return new OSD_Path();
}
DECL_EXPORT void* OSD_Path_Ctor6DB22F5E(
	void* aDependentName,
	int aSysType)
{
		const TCollection_AsciiString &  _aDependentName =*(const TCollection_AsciiString *)aDependentName;
		const OSD_SysType _aSysType =(const OSD_SysType )aSysType;
	return new OSD_Path(			
_aDependentName,			
_aSysType);
}
DECL_EXPORT void* OSD_Path_CtorA8CFE3FC(
	void* aNode,
	void* aUsername,
	void* aPassword,
	void* aDisk,
	void* aTrek,
	void* aName,
	void* anExtension)
{
		const TCollection_AsciiString &  _aNode =*(const TCollection_AsciiString *)aNode;
		const TCollection_AsciiString &  _aUsername =*(const TCollection_AsciiString *)aUsername;
		const TCollection_AsciiString &  _aPassword =*(const TCollection_AsciiString *)aPassword;
		const TCollection_AsciiString &  _aDisk =*(const TCollection_AsciiString *)aDisk;
		const TCollection_AsciiString &  _aTrek =*(const TCollection_AsciiString *)aTrek;
		const TCollection_AsciiString &  _aName =*(const TCollection_AsciiString *)aName;
		const TCollection_AsciiString &  _anExtension =*(const TCollection_AsciiString *)anExtension;
	return new OSD_Path(			
_aNode,			
_aUsername,			
_aPassword,			
_aDisk,			
_aTrek,			
_aName,			
_anExtension);
}
DECL_EXPORT void OSD_Path_ValuesA8CFE3FC(
	void* instance,
	void* aNode,
	void* aUsername,
	void* aPassword,
	void* aDisk,
	void* aTrek,
	void* aName,
	void* anExtension)
{
		 TCollection_AsciiString &  _aNode =*( TCollection_AsciiString *)aNode;
		 TCollection_AsciiString &  _aUsername =*( TCollection_AsciiString *)aUsername;
		 TCollection_AsciiString &  _aPassword =*( TCollection_AsciiString *)aPassword;
		 TCollection_AsciiString &  _aDisk =*( TCollection_AsciiString *)aDisk;
		 TCollection_AsciiString &  _aTrek =*( TCollection_AsciiString *)aTrek;
		 TCollection_AsciiString &  _aName =*( TCollection_AsciiString *)aName;
		 TCollection_AsciiString &  _anExtension =*( TCollection_AsciiString *)anExtension;
	OSD_Path* result = (OSD_Path*)instance;
 	result->Values(			
_aNode,			
_aUsername,			
_aPassword,			
_aDisk,			
_aTrek,			
_aName,			
_anExtension);
}
DECL_EXPORT void OSD_Path_SetValuesA8CFE3FC(
	void* instance,
	void* aNode,
	void* aUsername,
	void* aPassword,
	void* aDisk,
	void* aTrek,
	void* aName,
	void* anExtension)
{
		const TCollection_AsciiString &  _aNode =*(const TCollection_AsciiString *)aNode;
		const TCollection_AsciiString &  _aUsername =*(const TCollection_AsciiString *)aUsername;
		const TCollection_AsciiString &  _aPassword =*(const TCollection_AsciiString *)aPassword;
		const TCollection_AsciiString &  _aDisk =*(const TCollection_AsciiString *)aDisk;
		const TCollection_AsciiString &  _aTrek =*(const TCollection_AsciiString *)aTrek;
		const TCollection_AsciiString &  _aName =*(const TCollection_AsciiString *)aName;
		const TCollection_AsciiString &  _anExtension =*(const TCollection_AsciiString *)anExtension;
	OSD_Path* result = (OSD_Path*)instance;
 	result->SetValues(			
_aNode,			
_aUsername,			
_aPassword,			
_aDisk,			
_aTrek,			
_aName,			
_anExtension);
}
DECL_EXPORT void OSD_Path_SystemName6DB22F5E(
	void* instance,
	void* FullName,
	int aType)
{
		 TCollection_AsciiString &  _FullName =*( TCollection_AsciiString *)FullName;
		const OSD_SysType _aType =(const OSD_SysType )aType;
	OSD_Path* result = (OSD_Path*)instance;
 	result->SystemName(			
_FullName,			
_aType);
}
DECL_EXPORT void OSD_Path_ExpandedName66CFACD0(
	void* instance,
	void* aName)
{
		 TCollection_AsciiString &  _aName =*( TCollection_AsciiString *)aName;
	OSD_Path* result = (OSD_Path*)instance;
 	result->ExpandedName(			
_aName);
}
DECL_EXPORT bool OSD_Path_IsValid6DB22F5E(
	void* instance,
	void* aDependentName,
	int aSysType)
{
		const TCollection_AsciiString &  _aDependentName =*(const TCollection_AsciiString *)aDependentName;
		const OSD_SysType _aSysType =(const OSD_SysType )aSysType;
	OSD_Path* result = (OSD_Path*)instance;
	return  	result->IsValid(			
_aDependentName,			
_aSysType);
}
DECL_EXPORT void OSD_Path_UpTrek(void* instance)
{
	OSD_Path* result = (OSD_Path*)instance;
 	result->UpTrek();
}
DECL_EXPORT void OSD_Path_DownTrek66CFACD0(
	void* instance,
	void* aName)
{
		const TCollection_AsciiString &  _aName =*(const TCollection_AsciiString *)aName;
	OSD_Path* result = (OSD_Path*)instance;
 	result->DownTrek(			
_aName);
}
DECL_EXPORT void OSD_Path_RemoveATrekE8219145(
	void* instance,
	int where)
{
	OSD_Path* result = (OSD_Path*)instance;
 	result->RemoveATrek(			
where);
}
DECL_EXPORT void OSD_Path_RemoveATrek66CFACD0(
	void* instance,
	void* aName)
{
		const TCollection_AsciiString &  _aName =*(const TCollection_AsciiString *)aName;
	OSD_Path* result = (OSD_Path*)instance;
 	result->RemoveATrek(			
_aName);
}
DECL_EXPORT void* OSD_Path_TrekValueE8219145(
	void* instance,
	int where)
{
	OSD_Path* result = (OSD_Path*)instance;
	return new TCollection_AsciiString( 	result->TrekValue(			
where));
}
DECL_EXPORT void OSD_Path_InsertATrekCAFD1949(
	void* instance,
	void* aName,
	int where)
{
		const TCollection_AsciiString &  _aName =*(const TCollection_AsciiString *)aName;
	OSD_Path* result = (OSD_Path*)instance;
 	result->InsertATrek(			
_aName,			
where);
}
DECL_EXPORT void* OSD_Path_RelativePathB82186D3(
	void* DirPath,
	void* AbsFilePath)
{
		const TCollection_AsciiString &  _DirPath =*(const TCollection_AsciiString *)DirPath;
		const TCollection_AsciiString &  _AbsFilePath =*(const TCollection_AsciiString *)AbsFilePath;
	return new TCollection_AsciiString( OSD_Path::RelativePath(			
_DirPath,			
_AbsFilePath));
}
DECL_EXPORT void* OSD_Path_AbsolutePathB82186D3(
	void* DirPath,
	void* RelFilePath)
{
		const TCollection_AsciiString &  _DirPath =*(const TCollection_AsciiString *)DirPath;
		const TCollection_AsciiString &  _RelFilePath =*(const TCollection_AsciiString *)RelFilePath;
	return new TCollection_AsciiString( OSD_Path::AbsolutePath(			
_DirPath,			
_RelFilePath));
}
DECL_EXPORT int OSD_Path_TrekLength(void* instance)
{
	OSD_Path* result = (OSD_Path*)instance;
	return 	result->TrekLength();
}

DECL_EXPORT void OSD_Path_SetNode(void* instance, void* value)
{
	OSD_Path* result = (OSD_Path*)instance;
		result->SetNode(*(const TCollection_AsciiString *)value);
}

DECL_EXPORT void* OSD_Path_Node(void* instance)
{
	OSD_Path* result = (OSD_Path*)instance;
	return 	new TCollection_AsciiString(	result->Node());
}

DECL_EXPORT void OSD_Path_SetUserName(void* instance, void* value)
{
	OSD_Path* result = (OSD_Path*)instance;
		result->SetUserName(*(const TCollection_AsciiString *)value);
}

DECL_EXPORT void* OSD_Path_UserName(void* instance)
{
	OSD_Path* result = (OSD_Path*)instance;
	return 	new TCollection_AsciiString(	result->UserName());
}

DECL_EXPORT void OSD_Path_SetPassword(void* instance, void* value)
{
	OSD_Path* result = (OSD_Path*)instance;
		result->SetPassword(*(const TCollection_AsciiString *)value);
}

DECL_EXPORT void* OSD_Path_Password(void* instance)
{
	OSD_Path* result = (OSD_Path*)instance;
	return 	new TCollection_AsciiString(	result->Password());
}

DECL_EXPORT void OSD_Path_SetDisk(void* instance, void* value)
{
	OSD_Path* result = (OSD_Path*)instance;
		result->SetDisk(*(const TCollection_AsciiString *)value);
}

DECL_EXPORT void* OSD_Path_Disk(void* instance)
{
	OSD_Path* result = (OSD_Path*)instance;
	return 	new TCollection_AsciiString(	result->Disk());
}

DECL_EXPORT void OSD_Path_SetTrek(void* instance, void* value)
{
	OSD_Path* result = (OSD_Path*)instance;
		result->SetTrek(*(const TCollection_AsciiString *)value);
}

DECL_EXPORT void* OSD_Path_Trek(void* instance)
{
	OSD_Path* result = (OSD_Path*)instance;
	return 	new TCollection_AsciiString(	result->Trek());
}

DECL_EXPORT void OSD_Path_SetName(void* instance, void* value)
{
	OSD_Path* result = (OSD_Path*)instance;
		result->SetName(*(const TCollection_AsciiString *)value);
}

DECL_EXPORT void* OSD_Path_Name(void* instance)
{
	OSD_Path* result = (OSD_Path*)instance;
	return 	new TCollection_AsciiString(	result->Name());
}

DECL_EXPORT void OSD_Path_SetExtension(void* instance, void* value)
{
	OSD_Path* result = (OSD_Path*)instance;
		result->SetExtension(*(const TCollection_AsciiString *)value);
}

DECL_EXPORT void* OSD_Path_Extension(void* instance)
{
	OSD_Path* result = (OSD_Path*)instance;
	return 	new TCollection_AsciiString(	result->Extension());
}

DECL_EXPORT void OSDPath_Dtor(void* instance)
{
	delete (OSD_Path*)instance;
}
