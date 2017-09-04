#ifndef _CPPExt_HeaderFile
#define _CPPExt_HeaderFile
#include <MS.hxx>

#include <EDL_API.hxx>

#include <MS_MetaSchema.hxx>

#include <MS_Class.hxx>
#include <MS_GenClass.hxx>
#include <MS_InstClass.hxx>
#include <MS_Package.hxx>
#include <MS_Error.hxx>
#include <MS_Imported.hxx>

#include <MS_InstMet.hxx>
#include <MS_ClassMet.hxx>
#include <MS_Construc.hxx>
#include <MS_ExternMet.hxx>
 
#include <MS_Param.hxx>
#include <MS_Field.hxx>
#include <MS_GenType.hxx>
#include <MS_Enum.hxx>
#include <MS_PrimType.hxx>
#include <MS_Alias.hxx>
#include <MS_Pointer.hxx>

#include <MS_HSequenceOfMemberMet.hxx>
#include <MS_HSequenceOfExternMet.hxx>
#include <MS_HSequenceOfParam.hxx>
#include <MS_HSequenceOfField.hxx>
#include <MS_HSequenceOfGenType.hxx>
#include <TColStd_HSequenceOfHAsciiString.hxx>
#include <TColStd_HSequenceOfInteger.hxx>

#include <TCollection_HAsciiString.hxx>

#include <Standard_NoSuchObject.hxx>

#ifndef _Standard_Macro_HeaderFile
# include <Standard_Macro.hxx>
#endif

extern "C" {

        Standard_EXPORT Handle(TColStd_HSequenceOfHAsciiString) CPP_TemplatesUsed();

        void Standard_EXPORT CPP_Extract(const Handle(MS_MetaSchema)& ams,
			 const Handle(TCollection_HAsciiString)& aname,
			 const Handle(TColStd_HSequenceOfHAsciiString)& edlsfullpath,
			 const Handle(TCollection_HAsciiString)& outdir,
			 const Handle(TColStd_HSequenceOfHAsciiString)& outfile,
			 const Standard_CString);
	
}

Handle(TCollection_HAsciiString) CPP_BuildType(const Handle(MS_MetaSchema)&,
					       const Handle(TCollection_HAsciiString)&);

void CPP_TransientHandle(const Handle(EDL_API)&,
			 const Handle(TCollection_HAsciiString)&,
			 const Handle(TCollection_HAsciiString)&,
			 const Handle(TCollection_HAsciiString)&);


void CPP_TransientClass(const Handle(MS_MetaSchema)&,
			const Handle(EDL_API)&,
			const Handle(MS_Class)&,
			const Handle(TColStd_HSequenceOfHAsciiString)&);

void CPP_PersistentClass(const Handle(MS_MetaSchema)&,
			const Handle(EDL_API)&,
			const Handle(MS_Class)&,
			const Handle(TColStd_HSequenceOfHAsciiString)&);

void CPP_PersistentClassOBJY(const Handle(MS_MetaSchema)&,
			const Handle(EDL_API)&,
			const Handle(MS_Class)&,
			const Handle(TColStd_HSequenceOfHAsciiString)&);

void CPP_PersistentHandleOBJY(const Handle(EDL_API)&,
			 const Handle(TCollection_HAsciiString)&,
			 const Handle(TCollection_HAsciiString)&,
			 const Handle(TCollection_HAsciiString)&);

void CPP_PersistentClassCSFDB(const Handle(MS_MetaSchema)&,
			const Handle(EDL_API)&,
			const Handle(MS_Class)&,
			const Handle(TColStd_HSequenceOfHAsciiString)&);

void CPP_PersistentHandleCSFDB(const Handle(EDL_API)&,
			 const Handle(TCollection_HAsciiString)&,
			 const Handle(TCollection_HAsciiString)&,
			 const Handle(TCollection_HAsciiString)&);

void CPP_PersistentClassOBJS(const Handle(MS_MetaSchema)&,
			const Handle(EDL_API)&,
			const Handle(MS_Class)&,
			const Handle(TColStd_HSequenceOfHAsciiString)&);

void CPP_PersistentHandleOBJS(const Handle(EDL_API)&,
			 const Handle(TCollection_HAsciiString)&,
			 const Handle(TCollection_HAsciiString)&,
			 const Handle(TCollection_HAsciiString)&);

void CPP_ExceptionClass(const Handle(MS_MetaSchema)&,
			const Handle(EDL_API)&,
			const Handle(MS_Class)&,
			const Handle(TColStd_HSequenceOfHAsciiString)&);

void CPP_MPVClass(const Handle(MS_MetaSchema)&,
			const Handle(EDL_API)&,
			const Handle(MS_Class)&,
			const Handle(TColStd_HSequenceOfHAsciiString)&);

void CPP_StorableClass(const Handle(MS_MetaSchema)&,
			const Handle(EDL_API)&,
			const Handle(MS_Class)&,
			const Handle(TColStd_HSequenceOfHAsciiString)&);

void CPP_Enum(const Handle(MS_MetaSchema)&,
	      const Handle(EDL_API)&,
	      const Handle(MS_Enum)&,
	      const Handle(TColStd_HSequenceOfHAsciiString)&);

void CPP_Alias(const Handle(MS_MetaSchema)&,
	      const Handle(EDL_API)&,
	      const Handle(MS_Alias)&,
	      const Handle(TColStd_HSequenceOfHAsciiString)&);

void CPP_Pointer(const Handle(MS_MetaSchema)&,
		 const Handle(EDL_API)&,
		 const Handle(MS_Pointer)&,
		 const Handle(TColStd_HSequenceOfHAsciiString)&);
		 
void CPP_Package(const Handle(MS_MetaSchema)&,
	      const Handle(EDL_API)&,
	      const Handle(MS_Package)&,
	      const Handle(TColStd_HSequenceOfHAsciiString)&);

void CPP_BuildMethod(const Handle(MS_MetaSchema)& aMeta, 
		     const Handle(EDL_API)& api, 
		     const Handle(MS_Method)& m,
		     const Handle(TCollection_HAsciiString)& methodName,
		     const Standard_Boolean forDeclaration);

// EDL variables
//
Standard_CString VClass              = "%Class",
                 VClassComment       = "%ClassComment", 
                 VTICIncludes        = "%TICIncludes",
				 VInherits           = "%Inherits",
				 VTICPublicmets      = "%TICPublicmets",
				 VTICPublicfriends   = "%TICPublicfriends",
				 VTICProtectedmets   = "%TICProtectedmets",
				 VTICProtectedfields = "%TICProtectedfields",
				 VTICPrivatemets     = "%TICPrivatemets",
				 VTICPrivatefriends  = "%TICPrivatefriends",
				 VTICDefines         = "%TICDefines",
				 VTICInlineIncludes  = "%TICInlineIncludes",
				 VTICUndefines       = "%TICUndefines",
				 VTICPrivatefields   = "%TICPrivatefields",
                 VRetSpec            = "%RetSpec",
                 VVirtual            = "%Virtual",
                 VReturn             = "%Return",
                 VAnd                = "%And",
                 VMethodComment      = "%MethodComment",
                 VMethodName         = "%MethodName",
                 VArgument           = "%Arguments",
                 VCLIArgument        = "%CLIArguments",
				 VAPIArgument        = "%APIArguments",
                 VMetSpec            = "%MetSpec",
                 VMethod             = "%Method",
				 VMBody              = "%MBody",
				 VDName              = "%DName",
				 VDValue             = "%DValue",
                 VIsInline           = "%IsInline",
                 VIsCreateMethod     = "%IsCreateMethod",
				 VIClass             = "%IClass",
				 VSuffix             = "%Suffix",
                 VCxxFile            = "CxxFile",
                 VLxxFile            = "LxxFile",
                 VInlineMethod       = "%InlineMethod",
				 VoutClass           = "%outClass",
				 VNb                 = "%Nb",
				 VValues             = "%Values",
				 VSupplement         = "%Supplement",
				 VTypeMgt            = "%TypeMgt",
				 VMethods            = "%Methods",
				 VAncestors          = "%Ancestors",
				 VFullPath           = "%FullPath",
				 VMethodHeader       = "%MethodHeader",
				 VConstructorHeader  = "%ConstructorHeader",
				 VTICSuppMethod      = "%TICSuppMethod";

#endif
