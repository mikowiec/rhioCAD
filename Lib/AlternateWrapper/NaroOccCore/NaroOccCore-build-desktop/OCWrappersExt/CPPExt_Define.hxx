#ifndef _CPPExt_Define_HeaderFile
#define _CPPExt_Define_HeaderFile

extern Standard_CString VClass,
                 VClassComment,
                 VTICIncludes,
		 VInherits,
		 VTICPublicmets,
		 VTICPublicfriends,
		 VTICProtectedmets,
		 VTICProtectedfields,
		 VTICPrivatemets,
		 VTICPrivatefriends,
		 VTICDefines,
		 VTICInlineIncludes,
		 VTICUndefines,
		 VTICPrivatefields,
		 VTICSuppMethod,
         VRetSpec,
                 VVirtual,
                 VReturn,
                 VAnd,
                 VMethodComment,
                 VMethodName,
                 VArgument,
                 VMetSpec,
                 VMethod,
		 VMBody,
		 VDName,
		 VDValue,
                 VIsInline,
                 VIsCreateMethod,
		 VIClass,
		 VSuffix,
                 VCxxFile,
                 VLxxFile,
                 VInlineMethod,
		 VoutClass,
		 VNb,
		 VValues,
		 VSupplement,
		 VTypeMgt,
		 VMethods,
		 VAncestors,
		 VFullPath,
		 VMethodHeader,
		 VConstructorHeader;

Standard_Boolean CPP_SetFriendMethod(const Handle(MS_MetaSchema)& aMeta,
				     const Handle(EDL_API)& api,
				     const Handle(TColStd_HSequenceOfHAsciiString)& FriendMets,
				     const Handle(TCollection_HAsciiString)& publics);



void CPP_WriteFile(const Handle(EDL_API)& api,
		   const Handle(TCollection_HAsciiString)& aFileName,
		   const Standard_CString var);

void CPP_UsedTypes(const Handle(MS_MetaSchema)& aMeta,
		   const Handle(MS_Common)& aCommon,
		   const Handle(TColStd_HSequenceOfHAsciiString)& List,
		   const Handle(TColStd_HSequenceOfHAsciiString)& Incp);

Handle(TCollection_HAsciiString) CPP_BuildType(const Handle(MS_MetaSchema)& aMeta,
					       const Handle(TCollection_HAsciiString)& aTypeName);

Handle(TCollection_HAsciiString) CPP_BuildField(const Handle(MS_MetaSchema)& aMeta,
						const Handle(MS_Field)& aField);

class Handle(MS_HArray1OfParam);
Handle(TCollection_HAsciiString) CPP_BuildParameterList(const Handle(MS_MetaSchema)& aMeta, 
							const Handle(MS_HArray1OfParam)& aSeq,
							const Standard_Boolean withDefaultValue);

void CPP_BuildMethod(const Handle(MS_MetaSchema)& aMeta, 
		     const Handle(EDL_API)& api, 
		     const Handle(MS_Method)& m,
		     const Handle(TCollection_HAsciiString)& methodName,
		     const Standard_Boolean forDeclaration = Standard_True);

Handle(TCollection_HAsciiString) CPP_BuildAliasMethod(const Handle(MS_MetaSchema)& aMeta,
						      const Handle(EDL_API)& api,
						      const Handle(MS_MemberMet)& method);

void CPP_GenericDefine(const Handle(MS_MetaSchema)& aMeta,
		       const Handle(EDL_API)& api,
		       const Handle(MS_InstClass)& aCreator,
		       const Standard_CString VARDefine,
		       const Standard_CString VARUndefine,
		       const Standard_Boolean handleUsed);

void CPP_PersistentHandleOBJY(const Handle(EDL_API)& api,
			 const Handle(TCollection_HAsciiString)& aClass,
			 const Handle(TCollection_HAsciiString)& aMother,
			 const Handle(TCollection_HAsciiString)& aFileName);

void CPP_ClassTypeMgt(const Handle(MS_MetaSchema)& aMeta,
		      const Handle(EDL_API)& api,
		      const Handle(MS_Class)& aClass,
		      const Standard_CString var);

#endif
