// CLE
//    
// 10/1995
//
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

#include <MS_HSequenceOfMemberMet.hxx>
#include <MS_HSequenceOfExternMet.hxx>
#include <MS_HArray1OfParam.hxx>
#include <MS_HSequenceOfField.hxx>
#include <MS_HSequenceOfGenType.hxx>
#include <TColStd_HSequenceOfHAsciiString.hxx>
#include <TColStd_HSequenceOfInteger.hxx>

#include <TCollection_HAsciiString.hxx>

#include <Standard_NoSuchObject.hxx>

#include <CPPExt_Define.hxx>
#include <WOKTools_Messages.hxx>

static Standard_CString VTICOidpubMet = "%TICOidpubMet",
                        VTICOidproMet = "%TICOidproMet",
                        VTICOidpriMet = "%TICOidpriMet";

Handle(TCollection_HAsciiString) CPP_BuildTypeOBJY(const Handle(MS_MetaSchema)& aMeta,
						   const Handle(TCollection_HAsciiString)& aTypeName);

// create the defines and the undefines that are around the include of
// a generic .lxx
//  ex. :
//    //MDTV#define ItemHArray1 Quantity_Color
//    //MDTV#define ItemHArray1_hxx <Quantity_Color.hxx>
//    //MDTV#define TheArray1 Quantity_Array1OfColor
//    //MDTV#define TheArray1_hxx <Quantity_Array1OfColor.hxx>
//    //MDTV#define TCollection_HArray1 Quantity_HArray1OfColor
//    //MDTV#define TCollection_HArray1_hxx <Quantity_HArray1OfColor.hxx>
//    //MDTV#include <TCollection_HArray1.lxx>
//    //MDTV#undef ItemHArray1
//    //MDTV#undef ItemHArray1_hxx
//    //MDTV#undef TheArray1
//    //MDTV#undef TheArray1_hxx
//    //MDTV#undef TCollection_HArray1
//    //MDTV#undef TCollection_HArray1_hxx
//
void CPP_GenericMDTVDefineOBJY(const Handle(MS_MetaSchema)& aMeta,
			   const Handle(EDL_API)& api,
			   const Handle(MS_InstClass)& aCreator,
			   const Standard_CString VARDefine,
			   const Standard_CString VARUndefine,
//			   const Standard_Boolean handleUsed)
			   const Standard_Boolean )
{
//  Handle(MS_GenClass)                     aGenClass   = Handle(MS_GenClass)::DownCast(aMeta->GetType(aCreator->GenClass()));
//  Handle(TColStd_HSequenceOfHAsciiString) theGenTypes = aCreator->GenTypes();
//  Handle(TCollection_HAsciiString)        publics     = new TCollection_HAsciiString,
//                                          protecteds  = new TCollection_HAsciiString;
//  Standard_Integer                        i;

  
//  for (i = 1; i <= theGenTypes->Length(); i++) {
//    if (!aGenClass->FullName()->IsSameString(theGenTypes->Value(i))) {
//      api->AddVariable(VDName,theGenTypes->Value(i)->ToCString());
//      api->AddVariable(VDValue,CPP_BuildType(aMeta,aCreator->InstTypes()->Value(i))->ToCString());
//      api->Apply(VARDefine,"ItemMDTVDefine");
//      api->Apply(VARUndefine,"ItemMDTVUndefine");
//      publics->AssignCat(api->GetVariableValue(VARDefine));
//      protecteds->AssignCat(api->GetVariableValue(VARUndefine));
//    }
//  }
  
//  api->AddVariable(VDName,aGenClass->FullName()->ToCString());
//  api->AddVariable(VDValue,aCreator->FullName()->ToCString());
//  api->Apply(VARDefine,"ItemMDTVDefine");
//  api->Apply(VARUndefine,"ItemMDTVUndefine");
//  publics->AssignCat(api->GetVariableValue(VARDefine));
//  protecteds->AssignCat(api->GetVariableValue(VARUndefine));
  
  // #define TCollection_HSequence_Type_() TColStd_HSequenceOfTransient_Type_()
  // #define Handle_TCollection_HSequence Handle_TColStd_HSequenceOfTransient
  //
//  if (handleUsed) {
//    api->AddVariable(VDName,aGenClass->FullName()->ToCString());
//    api->AddVariable(VDValue,aCreator->FullName()->ToCString());
//    api->Apply(VARDefine,"ItemHandleMDTVDefine");
//    api->Apply(VARUndefine,"ItemHandleMDTVUndefine");
//    publics->AssignCat(api->GetVariableValue(VARDefine));
//    protecteds->AssignCat(api->GetVariableValue(VARUndefine));
//  }

//  api->AddVariable(VARDefine,publics->ToCString());
//  api->AddVariable(VARUndefine,protecteds->ToCString());
  Handle(MS_GenClass)                     aGenClass   = Handle(MS_GenClass)::DownCast(aMeta->GetType(aCreator->GenClass()));
  Handle(TColStd_HSequenceOfHAsciiString) theGenTypes = aCreator->GenTypes();
  Handle(TCollection_HAsciiString)        publics     = new TCollection_HAsciiString;
  Handle(TCollection_HAsciiString)        protecteds  = new TCollection_HAsciiString;
  Standard_Integer                        i,
                                          itemLength;
  Handle(MS_HSequenceOfGenType)           realGentypes = aGenClass->GenTypes();

  // we need this length because for item we must call 
  // CPP_BuildType and for nested class name we dont need. 
  //
  itemLength = aGenClass->GenTypes()->Length();

  for (i = 1; i <= theGenTypes->Length(); i++) {
    if (!aGenClass->FullName()->IsSameString(theGenTypes->Value(i))) {
      api->AddVariable(VDName,theGenTypes->Value(i)->ToCString());

      // real name or Handle_name
      //
      if (i <= itemLength) { 
	if (!realGentypes->Value(i)->TYpeName().IsNull()) {
	  if (aMeta->IsDefined(realGentypes->Value(i)->TYpeName())) {
	    Handle(MS_Type) t = aMeta->GetType(realGentypes->Value(i)->TYpeName());

	    if (t->IsKind(STANDARD_TYPE(MS_Class))) {
	      Handle(MS_Class) c = *((Handle(MS_Class)*)&t);
	      
	      // if the items constraint is handled, the item is not the handle,
	      // like in other cases, but the type himself.
	      //
	      // ex. : the item : 'i' as transient
	      //    will be defined as #define i class
	      //       the item : 'i' as any
	      //    will be defined as #define i Handle_Class
	      //
	      if (c->IsPersistent() || c->IsTransient()) {
		api->AddVariable(VDValue,aCreator->InstTypes()->Value(i)->ToCString());
		api->Apply(VARDefine,"ItemMDTVConstraintHandle");
		api->Apply(VARUndefine,"ItemMDTVConstraintHandleUndef");
		publics->AssignCat(api->GetVariableValue(VARDefine));
		protecteds->AssignCat(api->GetVariableValue(VARUndefine));
	      }
	      else {
		api->AddVariable(VDValue,CPP_BuildTypeOBJY(aMeta,aCreator->InstTypes()->Value(i))->ToCString());
	      }
	    }
	  }
	}
	else {
	  api->AddVariable(VDValue,CPP_BuildTypeOBJY(aMeta,aCreator->InstTypes()->Value(i))->ToCString());
	}
	api->AddVariable("%DBaseValue",aCreator->InstTypes()->Value(i)->ToCString());
      }
      // real name
      //
      else { 
	api->AddVariable(VDValue,aCreator->InstTypes()->Value(i)->ToCString());
	api->AddVariable("%DBaseValue",aCreator->InstTypes()->Value(i)->ToCString());
      }

      api->Apply(VARDefine,"ItemMDTVDefine");
      api->Apply(VARUndefine,"ItemMDTVUndefine");
      publics->AssignCat(api->GetVariableValue(VARDefine));
      protecteds->AssignCat(api->GetVariableValue(VARUndefine));
    }
  }
  
  for (i = itemLength + 1; i <= theGenTypes->Length(); i++) {
    if (!aGenClass->FullName()->IsSameString(theGenTypes->Value(i))) {
      Handle(TCollection_HAsciiString) realName = CPP_BuildTypeOBJY(aMeta,aCreator->InstTypes()->Value(i));
      
      if (!realName->IsSameString(aCreator->InstTypes()->Value(i))) {
	api->AddVariable(VDName,theGenTypes->Value(i)->ToCString());
	api->AddVariable(VDValue,aCreator->InstTypes()->Value(i)->ToCString());
	api->Apply(VARDefine,"ItemHandleMDTVDefine");
	api->Apply(VARUndefine,"ItemHandleMDTVUndefine");
	publics->AssignCat(api->GetVariableValue(VARDefine));
	protecteds->AssignCat(api->GetVariableValue(VARUndefine));
      }
    }
  }

  api->AddVariable(VDName,aGenClass->FullName()->ToCString());
  api->AddVariable(VDValue,aCreator->FullName()->ToCString());
  api->AddVariable("%DBaseValue",aCreator->FullName()->ToCString());

  api->Apply(VARDefine,"ItemMDTVDefine");
  api->Apply(VARUndefine,"ItemMDTVUndefine");
  publics->AssignCat(api->GetVariableValue(VARDefine));
  protecteds->AssignCat(api->GetVariableValue(VARUndefine));

  // #define TCollection_HSequence_Type_() TColStd_HSequenceOfTransient_Type_()
  // #define Handle_TCollection_HSequence Handle_TColStd_HSequenceOfTransient
  //
  if (aGenClass->IsTransient() || aGenClass->IsPersistent()) {
    api->AddVariable(VDName,aGenClass->FullName()->ToCString());
    api->AddVariable(VDValue,aCreator->FullName()->ToCString());
    api->Apply(VARDefine,"ItemHandleMDTVDefine");
    api->Apply(VARUndefine,"ItemHandleMDTVUndefine");
    publics->AssignCat(api->GetVariableValue(VARDefine));
    protecteds->AssignCat(api->GetVariableValue(VARUndefine));
  }

  api->AddVariable(VARDefine,publics->ToCString());
  api->AddVariable(VARUndefine,protecteds->ToCString());
}

// create a VArray OBJY dependent declaration for DBC instance
//            look EDL template : VArrayFieldOBJY 
//
//void CPP_BuildVArrayDeclarationOBJY(const Handle(MS_MetaSchema)& aMeta, 
//			      const Handle(EDL_API)& api, 
//			      const Handle(MS_StdClass)& aClass,
//			      const Handle(TCollection_HAsciiString)& Result)
void CPP_BuildVArrayDeclarationOBJY(const Handle(MS_MetaSchema)& , 
			      const Handle(EDL_API)& , 
			      const Handle(MS_StdClass)& ,
			      const Handle(TCollection_HAsciiString)& )
{
//  if (!aClass->GetMyCreator().IsNull()) {
//    Handle(MS_InstClass)             anInst = aClass->GetMyCreator();
//    Handle(TCollection_HAsciiString) aGen   = anInst->GenClass();
//
//    if (aGen->IsSameString(MS::GetVArrayRootName())) {
//      api->AddVariable(VDName,aClass->FullName()->ToCString());
//      api->AddVariable(VDValue,anInst->InstTypes()->Value(1)->ToCString());
//      api->Apply(VDValue,"VArrayDeclareOBJY");
//      Result->AssignCat(api->GetVariableValue(VDValue));
//    }
//  }
}

// create a VArray OBJY dependent field for DBC instance
//            look EDL template : VArrayFieldOBJY 
//
//void CPP_BuildVArrayFieldOBJY(const Handle(MS_MetaSchema)& aMeta, 
//			      const Handle(EDL_API)& api, 
//			      const Handle(MS_StdClass)& aClass,
//			      const Handle(TCollection_HAsciiString)& Result)
void CPP_BuildVArrayFieldOBJY(const Handle(MS_MetaSchema)& , 
			      const Handle(EDL_API)& , 
			      const Handle(MS_StdClass)& ,
			      const Handle(TCollection_HAsciiString)& )
{
//  if (!aClass->GetMyCreator().IsNull()) {
//    Handle(MS_InstClass)             anInst = aClass->GetMyCreator();
//    Handle(TCollection_HAsciiString) aGen   = anInst->GenClass();

//    if (aGen->IsSameString(MS::GetVArrayRootName())) {
//      api->AddVariable(VDName,aClass->FullName()->ToCString());
//      api->AddVariable(VDValue,anInst->InstTypes()->Value(1)->ToCString());
//      api->Apply(VDValue,"VArrayFieldOBJY");
//      Result->AssignCat(api->GetVariableValue(VDValue));
//    }
//  }
}

// build a c++ declaration method
// the result is in the EDL variable VMethod
//
//   template used :
//
//         MethodTemplateDef
//         ConstructorTemplateDef
//         MethodTemplateDec
//         ConstructorTemplateDec
//         InlineMethodTemplateDec
//
//   the EDL variables : 
//        VMethodHeader : must contains the name of the template used for 
//                        methods construction
//        VConstructorHeader :  must contains the name of the template used for 
//                              constructors construction
//
void CPP_BuildOidOBJYMethod(const Handle(MS_MetaSchema)& aMeta, 
			    const Handle(EDL_API)& api, 
			    const Handle(MS_Method)& m,
			    const Handle(TCollection_HAsciiString)& methodName,
			    const Standard_Boolean forDeclaration = Standard_True)
{
  Handle(MS_InstMet)  im;
  Handle(MS_ClassMet) cm;
  Handle(MS_Construc) ct;
  Handle(MS_Param)    retType;

  Handle(TCollection_HAsciiString) MetTemplate,
                                   ConTemplate;

  Standard_Boolean InlineMethod;

  MetTemplate = api->GetVariableValue(VMethodHeader);
  ConTemplate = api->GetVariableValue(VConstructorHeader);

  // here we process all the common attributes of methods
  //
  api->AddVariable(VMethodName,methodName->ToCString());
  api->AddVariable(VVirtual,"");
  
  // it s inline method ?
  //
  api->AddVariable(VIsInline,"yes");
  InlineMethod = Standard_True;
    
  api->AddVariable(VRetSpec,"");
  
  // it s returning & ?
  //
  if (m->IsRefReturn()) {
    api->AddVariable(VAnd,"&");
  }
  else {
    api->AddVariable(VAnd,"");
  }
  
  api->AddVariable(VArgument,CPP_BuildParameterList(aMeta,m->Params(),forDeclaration)->ToCString());
  
  // it s returning a type or void
  //
  retType = m->Returns();
  
  if (!retType.IsNull()) {
    api->AddVariable(VReturn,CPP_BuildType(aMeta,retType->TypeName())->ToCString());
  }
  else {
    api->AddVariable(VReturn,"void");
  }
  
  // now the specials attributes
  //
  // instance methods
  //
  if (m->IsKind(STANDARD_TYPE(MS_InstMet))) {
    im = *((Handle(MS_InstMet)*)&m);
    
    api->AddVariable(VIsCreateMethod,"no");
    api->AddVariable(VMetSpec,"");
    api->Apply(VMethod,MetTemplate->ToCString());
    api->Apply(VMethod,"InlineMethodTemplateDec");
  }
}

//Handle(TCollection_HAsciiString) CPP_BuildOidImmTestOBJY(const Handle(MS_MetaSchema)& aMeta,
Handle(TCollection_HAsciiString) CPP_BuildOidImmTestOBJY(const Handle(MS_MetaSchema)& ,
						     const Handle(EDL_API)& api,
						     const Handle(MS_Method)& Method,
						     const Standard_Boolean UseMutability)
{
  Handle(TCollection_HAsciiString) body = new TCollection_HAsciiString;
  Standard_Integer                 i;
  Standard_Boolean                 testResult;
  Handle(MS_HArray1OfParam)      aSeqParam = Method->Params();

  api->AddVariable(VMethodName,Method->Name()->ToCString());

  if(!aSeqParam.IsNull()) {
    for (i = 1; i <= aSeqParam->Length(); i++) {
      if (aSeqParam->Value(i)->Type()->IsKind(STANDARD_TYPE(MS_Class))) {
	Handle(MS_Type) pType = aSeqParam->Value(i)->Type();
	Handle(MS_Class) aPersClass =  *((Handle_MS_Class*)&pType);

	if (UseMutability) {
	  testResult = aSeqParam->Value(i)->IsMutable();
	}
	else {
	  testResult = aSeqParam->Value(i)->IsOut();
	}
	
	if (testResult && aPersClass->IsPersistent()) {
	  api->AddVariable(VDName,aSeqParam->Value(i)->Name()->ToCString());
	  api->Apply(VDName,"ImmutableTestOBJY");
	  body->AssignCat(api->GetVariableValue(VDName));
	}
      }
    }
  }
  return body;
}

// Build the list of call for persistent oid methods and set the result at the end of
// publics
//
Standard_Boolean CPP_BuildOidMethodCallOBJY(const Handle(MS_MetaSchema)& aMeta,
					const Handle(EDL_API)& api,
					const Handle(MS_Method)& Method,
					const Handle(TCollection_HAsciiString)& publics)
{
  if (publics.IsNull()) return Standard_False;

  Handle(MS_InstMet)               method = Handle(MS_InstMet)::DownCast(Method);
  Standard_Integer                 i;
  Standard_Boolean                 result = Standard_True;
  Handle(TCollection_HAsciiString) aname,
                                   oldclass = api->GetVariableValue(VClass),
                                   body,
                                   immTest;
  Handle(MS_HArray1OfParam)      aSeqParam;

  // templates for methods extraction
  //
  api->AddVariable(VMethodHeader,"ExternalMethodHeader");
  api->AddVariable(VConstructorHeader,"ExternalConstructorHeader");
  
  if (!method.IsNull()) {
    body = new TCollection_HAsciiString;

    aSeqParam = method->Params();

    aname = new TCollection_HAsciiString("Oid_");
    aname->AssignCat(method->Class());

    // method header
    //
    api->AddVariable(VClass,aname->ToCString());
    CPP_BuildOidOBJYMethod(aMeta,api,method,method->Name(),Standard_False);

    api->AddVariable(VClass,method->Class()->ToCString());
    api->AddVariable(VMethodName,method->Name()->ToCString());

    // parameters
    //
    aname = new TCollection_HAsciiString(method->Name());
    aname->AssignCat("(");

    immTest = CPP_BuildOidImmTestOBJY(aMeta,api,method,Standard_True);

    body->AssignCat(immTest);

    // method call signature
    //
    
    if (!aSeqParam.IsNull()) {
      aname->AssignCat(aSeqParam->Value(1)->Name());

      for (i = 2; i <= aSeqParam->Length(); i++) {
	aname->AssignCat(",");
	aname->AssignCat(aSeqParam->Value(i)->Name());
      }
    }

    aname->AssignCat(")");

    // method call
    //
    api->AddVariable(VMethodName,aname->ToCString());
    
    if (method->IsConst()) {
      api->Apply(VMethodName,"ReadAccessOBJY");
    }
    else {
      api->Apply(VMethodName,"UpdateAccessOBJY");
    }
  
    // returns value
    //
    if (!method->Returns().IsNull()) {
      body->AssignCat(CPP_BuildType(aMeta,method->Returns()->TypeName()));
      body->AssignCat(" _result = ");
      body->AssignCat(api->GetVariableValue(VMethodName));

      if (method->Returns()->Type()->IsKind(STANDARD_TYPE(MS_Class))) {
	if (method->Returns()->IsMutable()) {
	  api->AddVariable(VDName,"_result");
	  api->AddVariable(VMethodName,method->Name()->ToCString());
	  api->Apply(VDName,"ImmutableTestOBJY");
	  body->AssignCat(api->GetVariableValue(VDName));
	}
      }
    }
    else {
      body->AssignCat(api->GetVariableValue(VMethodName));
    }

    immTest = CPP_BuildOidImmTestOBJY(aMeta,api,method,Standard_False);
    body->AssignCat(immTest);
    body->AssignCat("  EndAccess();\n");

    // return code
    //
    if (!method->Returns().IsNull()) {
      body->AssignCat("  return _result;");
    }

    api->AddVariable(VMBody,body->ToCString());
    api->Apply(VMethod,"MethodTemplateDef");

    publics->AssignCat(api->GetVariableValue(VMethod));
  }
  else {
    result = Standard_False;
  }
  
  // templates for methods extraction
  //
  api->AddVariable(VMethodHeader,"MethodHeader");
  api->AddVariable(VConstructorHeader,"ConstructorHeader");
  api->AddVariable(VClass,oldclass->ToCString());

  return result;
}

// Extraction of a Persistent handle for OBJY
//
void CPP_PersistentHandleOBJY(const Handle(EDL_API)& api,
			 const Handle(TCollection_HAsciiString)& aClass,
			 const Handle(TCollection_HAsciiString)& aMother,
			 const Handle(TCollection_HAsciiString)& aFileName)
{
  // we create the handle...
  //
  api->AddVariable("%HPName",aClass->ToCString());
  api->AddVariable("%HPInherits",aMother->ToCString());
  api->Apply("%HPHandle","HandlePersistentOBJY");

  // ...now we write the result
  //
  api->OpenFile("HTFile",aFileName->ToCString());
  api->WriteFile("HTFile","%HPHandle");
  api->CloseFile("HTFile");
}


// Extraction of a persistent .ixx .jxx and _0.cxx
//   the supplement variable is used for non inline methods generated 
//   by the extractor like destructor (added to .ixx ans _0.cxx
//
void CPP_PersistentDerivatedOBJY(const Handle(MS_MetaSchema)& aMeta,
			    const Handle(EDL_API)& api,
			    const Handle(MS_Class)& aClass,			    
			    const Handle(TColStd_HSequenceOfHAsciiString)& outfile,
			    const Handle(TColStd_HSequenceOfHAsciiString)& inclist,
			    const Handle(TColStd_HSequenceOfHAsciiString)& supplement)
{
  Standard_Integer                        i;
  Handle(TCollection_HAsciiString)        aFileName = new TCollection_HAsciiString;
  Handle(TCollection_HAsciiString)        result    = new TCollection_HAsciiString;
  Handle(MS_StdClass)                     theClass  = Handle(MS_StdClass)::DownCast(aClass);

  // we do this only on standard classes (not on inst classes)
  //
  if (theClass.IsNull()) return;

  api->AddVariable(VClass,aClass->FullName()->ToCString());

  api->AddVariable(VSuffix,"hxx");
  
  for (i = 1; i <= inclist->Length(); i++) {
    api->AddVariable(VIClass,inclist->Value(i)->ToCString());
    api->Apply(VoutClass,"Include");
    result->AssignCat(api->GetVariableValue(VoutClass));
  }

  if (theClass->GetMyCreator().IsNull()) {
    // include the hxx of me
    //
    api->AddVariable(VIClass,aClass->FullName()->ToCString());
    api->Apply(VoutClass,"Include");
    result->AssignCat(api->GetVariableValue(VoutClass));
    
    api->AddVariable(VoutClass,result->ToCString());

    aFileName->AssignCat(api->GetVariableValue(VFullPath));
    aFileName->AssignCat(aClass->FullName());
    aFileName->AssignCat(".jxx");
  
    CPP_WriteFile(api,aFileName,VoutClass);
    result->Clear();
    outfile->Append(aFileName);
  }

  CPP_ClassTypeMgt(aMeta,api,aClass,VTypeMgt);
  
  aFileName = new TCollection_HAsciiString(api->GetVariableValue(VFullPath));
  aFileName->AssignCat(aClass->FullName());

  if (theClass->GetMyCreator().IsNull()) {
    aFileName->AssignCat(".ixx");
  }
  else {
    aFileName->AssignCat("_0.cxx");
  }

  // Supplement
  //
  if (theClass->GetMyCreator().IsNull()) {
    result->Clear();
  }

  for (i = 1; i <= supplement->Length(); i++) {
    result->AssignCat(supplement->Value(i));
  }
  
  api->AddVariable(VSupplement,result->ToCString());
  
  // Methods
  //
  result->Clear();
  
  api->AddVariable(VIClass,MS::GetPersistentRootName()->ToCString());
  api->Apply(VMethods,"DownCast");    
  result->AssignCat(api->GetVariableValue(VMethods));
  
  api->Apply(VMethods,"DynamicType");
  result->AssignCat(api->GetVariableValue(VMethods));
  
  api->AddVariable(VIClass,aClass->GetInheritsNames()->Value(1)->ToCString());
  api->Apply(VMethods,"IsKind");
  result->AssignCat(api->GetVariableValue(VMethods));
  
  api->Apply(VMethods,"FullEmptyHandleDestructorTemplate");
  result->AssignCat(api->GetVariableValue(VMethods));

  if (!theClass->GetMyCreator().IsNull()) {
    CPP_GenericDefine(aMeta,api,theClass->GetMyCreator(),VTICDefines,VTICUndefines,Standard_True);
    result->AssignCat(api->GetVariableValue(VTICDefines));
    api->AddVariable(VSuffix,"gxx");

    if (theClass->GetMother().IsNull()) {
      api->AddVariable(VIClass,theClass->GetMyCreator()->GenClass()->ToCString());
    }
    else {
      api->AddVariable(VIClass,theClass->GetMother()->ToCString());
    }

    api->Apply(VMethods,"IncludeNoSafe");
    result->AssignCat(api->GetVariableValue(VMethods));
  }

  if (theClass->GetMyCreator().IsNull()) {
    api->AddVariable(VSuffix,"jxx");
  }
  else {
    api->AddVariable(VSuffix,"hxx");
  }

  api->AddVariable(VMethods,result->ToCString());
  api->Apply(VoutClass,"PersistentOBJYIxx");
  
  CPP_WriteFile(api,aFileName,VoutClass); 
  
  outfile->Append(aFileName);
}

// build a return, parameter or field type in c++
//  return a <type name> or a Handle_<type name>
//
Handle(TCollection_HAsciiString) CPP_BuildTypeOBJY(const Handle(MS_MetaSchema)& aMeta,
						   const Handle(TCollection_HAsciiString)& aTypeName)
{
  Handle(TCollection_HAsciiString)   result = new TCollection_HAsciiString;
  Handle(MS_Type)                    aType;

  if (aMeta->IsDefined(aTypeName)) {
    aType = aMeta->GetType(aTypeName);

    if (aType->IsKind(STANDARD_TYPE(MS_Alias))) {
      Handle(MS_Alias) analias = *((Handle(MS_Alias)*)&aType);

      aType = aMeta->GetType(analias->DeepType());
    }

    if (aType->IsKind(STANDARD_TYPE(MS_Class))) {
      Handle(MS_Class) aClass;
      
      aClass = *((Handle(MS_Class)*)&aType);
      
      if (aClass->IsPersistent()) {
	result->AssignCat("PHandle_");
	result->AssignCat(aTypeName);
      }
      else if (aClass->IsTransient()) {
	ErrorMsg << "CPPExt" << "type " << aType->FullName()->ToCString() << " is Transient an cannot be a field of a Persistent capable class" << endm;
	Standard_NoSuchObject::Raise();
      }
      else {
	result->AssignCat(aTypeName);
      } 
    }
    else {
      result->AssignCat(aTypeName);
    }
  }
  else {
     ErrorMsg << "CPPExt" << "type " << aType->FullName()->ToCString() << " not defined..." << endm;
     Standard_NoSuchObject::Raise();
  }

  return result;
}

// Build a c++ field 
//
Handle(TCollection_HAsciiString) CPP_BuildFieldOBJY(const Handle(MS_MetaSchema)& aMeta,
						    const Handle(MS_Field)& aField)
{
  Handle(TCollection_HAsciiString)   result = new TCollection_HAsciiString;
  Handle(MS_Type)                    aType;
  Handle(TColStd_HSequenceOfInteger) dim;
  Standard_Integer                   i;

  result->AssignCat(CPP_BuildTypeOBJY(aMeta,aField->TYpe()));
  result->AssignCat(" ");
  result->AssignCat(aField->Name());

  dim = aField->Dimensions();

  for (i = 1; i <= dim->Length(); i++) {
    result->AssignCat("[");
    result->AssignCat(new TCollection_HAsciiString(dim->Value(i)));
    result->AssignCat("]");
  }  

  result->AssignCat(";\n");

  return result;
}

// Extraction of a persistent class (inst or std)
//
void CPP_PersistentClassOBJY(const Handle(MS_MetaSchema)& aMeta,
			const Handle(EDL_API)& api,
			const Handle(MS_Class)& aClass,
			const Handle(TColStd_HSequenceOfHAsciiString)& outfile)
{
  Handle(MS_StdClass) theClass = Handle(MS_StdClass)::DownCast(aClass);

  if (!theClass.IsNull()) {
    Standard_Integer                        i;

    Handle(MS_HSequenceOfMemberMet)         methods    = theClass->GetMethods();
    Handle(MS_Method)                       friendmethod;
    Handle(TCollection_HAsciiString)        publics    = new TCollection_HAsciiString;
    Handle(TCollection_HAsciiString)        protecteds = new TCollection_HAsciiString;
    Handle(TCollection_HAsciiString)        privates   = new TCollection_HAsciiString;
    Handle(TCollection_HAsciiString)        SuppMethod = new TCollection_HAsciiString;
    Handle(TCollection_HAsciiString)        oidpubmethods = new TCollection_HAsciiString;
    Handle(TCollection_HAsciiString)        oidpromethods = new TCollection_HAsciiString;
    Handle(TCollection_HAsciiString)        oidprimethods = new TCollection_HAsciiString;

    Handle(TColStd_HSequenceOfHAsciiString) Supplement = new TColStd_HSequenceOfHAsciiString;
    Standard_Boolean                        HasInlineMethod = Standard_False,
                                            HasDestructor   = Standard_False;

    Handle(TColStd_HSequenceOfHAsciiString) List     = new TColStd_HSequenceOfHAsciiString;
    Handle(TColStd_HSequenceOfHAsciiString) incp     = new TColStd_HSequenceOfHAsciiString;

    api->AddVariable(VTICIncludes,"");
    api->AddVariable(VTICPublicfriends,"");
    api->AddVariable(VTICProtectedfields,"");
    api->AddVariable(VTICPrivatefriends,"");
    api->AddVariable(VTICDefines,"");
    api->AddVariable(VTICInlineIncludes,"");
    api->AddVariable(VTICUndefines,"");
    api->AddVariable(VTICPrivatefriends,"");
    api->AddVariable(VTICPrivatefields,"");
    api->AddVariable(VSuffix,"");
    api->AddVariable(VTICSuppMethod,"");

    api->AddVariable(VClass,theClass->FullName()->ToCString());
    api->AddVariable(VInherits,theClass->GetInheritsNames()->Value(1)->ToCString());

    for (i = 1; i <= theClass->GetFriendsNames()->Length(); i++) {
      publics->AssignCat("friend ");
      api->AddVariable(VIClass,theClass->GetFriendsNames()->Value(i)->ToCString());
      api->Apply(VTICPublicfriends,"ShortDec");
      publics->AssignCat(api->GetVariableValue(VTICPublicfriends));
    }
    
    if (!CPP_SetFriendMethod(aMeta,api,theClass->GetFriendMets(),publics)) {
      ErrorMsg << "CPPExt" << "a friend method was not found..." << endm;
      Standard_NoSuchObject::Raise();
    }

    api->AddVariable(VTICPublicfriends,publics->ToCString());
    
    publics->Clear();

    // extraction of the methods : BEGIN
    //
    Handle(TCollection_HAsciiString) aliasMethod;

    for (i = 1; i <= methods->Length(); i++) {
      aliasMethod.Nullify();

      if (methods->Value(i)->IsInline()) {
	HasInlineMethod = Standard_True;
      }

      // if the class has no destructor, we give it
      //
      if (methods->Value(i)->IsDestructor()) {
	HasDestructor = Standard_True;
      }

      if (!methods->Value(i)->IsKind(STANDARD_TYPE(MS_Construc))) {
	if (!methods->Value(i)->Returns().IsNull()) {
	  MS::DispatchUsedType(aMeta,methods->Value(i)->Returns()->Type(),List,incp,Standard_True);
	}
      }

      if (!methods->Value(i)->IsAlias().IsNull() || methods->Value(i)->IsDestructor()) {
	aliasMethod = CPP_BuildAliasMethod(aMeta,api,methods->Value(i));
      }
      
      // Function Call c++ comment :
      //     it s must be in the _0.cxx or ixx file
      //     so we add it in the supplement sequence
      //
      if (methods->Value(i)->IsFunctionCall()) {
	SuppMethod->AssignCat(CPP_BuildAliasMethod(aMeta,api,methods->Value(i)));
      }

      CPP_BuildMethod(aMeta,api,methods->Value(i),methods->Value(i)->Name());

      api->Apply(VMethod,"MethodTemplateDec");

      if (methods->Value(i)->Private()) {
	privates->AssignCat(api->GetVariableValue(VMethod));

	if (methods->Value(i)->IsKind(STANDARD_TYPE(MS_InstMet))) {
	  CPP_BuildOidOBJYMethod(aMeta,api,methods->Value(i),methods->Value(i)->Name());
	  api->Apply(VMethod,"MethodTemplateDec");
	  oidprimethods->AssignCat(api->GetVariableValue(VMethod));
	  CPP_BuildOidMethodCallOBJY(aMeta,api,methods->Value(i),SuppMethod);
	}

	if (!aliasMethod.IsNull()) {
	  privates->AssignCat(aliasMethod);
	}
      }
      else if ((theClass->Deferred() && methods->Value(i)->IsKind(STANDARD_TYPE(MS_Construc))) || 
	       methods->Value(i)->IsProtected())  {
	protecteds->AssignCat(api->GetVariableValue(VMethod));

	if (methods->Value(i)->IsKind(STANDARD_TYPE(MS_InstMet))) {
	  CPP_BuildOidOBJYMethod(aMeta,api,methods->Value(i),methods->Value(i)->Name());
	  api->Apply(VMethod,"MethodTemplateDec");
	  oidpromethods->AssignCat(api->GetVariableValue(VMethod));
	  CPP_BuildOidMethodCallOBJY(aMeta,api,methods->Value(i),SuppMethod);
	}

	if (!aliasMethod.IsNull()) {
	  protecteds->AssignCat(aliasMethod);
	}
      } 
      else {
	publics->AssignCat(api->GetVariableValue(VMethod));

	if (methods->Value(i)->IsKind(STANDARD_TYPE(MS_InstMet))) {
	  CPP_BuildOidOBJYMethod(aMeta,api,methods->Value(i),methods->Value(i)->Name());
	  api->Apply(VMethod,"MethodTemplateDec");
	  oidpubmethods->AssignCat(api->GetVariableValue(VMethod));
	  CPP_BuildOidMethodCallOBJY(aMeta,api,methods->Value(i),SuppMethod);
	}

	if (!aliasMethod.IsNull()) {
	  publics->AssignCat(aliasMethod);
	}
      }
    }       // methods extraction : END
    
    if (!HasDestructor) {
      api->Apply(VMethod,"EmptyDestructorTemplate");
      publics->AssignCat(api->GetVariableValue(VMethod));
    }

    api->AddVariable(VTICPublicmets,publics->ToCString());
    api->AddVariable(VTICPrivatemets,privates->ToCString());
    api->AddVariable(VTICProtectedmets,protecteds->ToCString());
    api->AddVariable(VTICOidpubMet,oidpubmethods->ToCString());
    api->AddVariable(VTICOidproMet,oidpromethods->ToCString());
    api->AddVariable(VTICOidpriMet,oidprimethods->ToCString());

    publics->Clear();
    privates->Clear();
    protecteds->Clear();
    oidpubmethods->Clear();
    oidpromethods->Clear();
    oidprimethods->Clear();

    // extraction of fields
    //
    Handle(MS_HSequenceOfField) fields =  theClass->GetFields();

    for (i = 1; i <= fields->Length(); i++) {
      if (fields->Value(i)->Protected()) {
	protecteds->AssignCat(CPP_BuildFieldOBJY(aMeta,fields->Value(i)));
      }
      else {
	privates->AssignCat(CPP_BuildFieldOBJY(aMeta,fields->Value(i)));
      }      
    }

    api->AddVariable(VTICPrivatefields,privates->ToCString());
    api->AddVariable(VTICProtectedfields,protecteds->ToCString());

    publics->Clear();
    privates->Clear();
    protecteds->Clear();

    // others inline methods and functions (ex. function call)
    //
    api->AddVariable(VTICSuppMethod,SuppMethod->ToCString());

    // include the lxx if the class have inline methods
    //
    if (HasInlineMethod) {
      Handle(MS_InstClass) aCreator = theClass->GetMyCreator();

      if (aCreator.IsNull()) {
	api->AddVariable(VIClass,theClass->FullName()->ToCString());
	api->AddVariable(VSuffix,"lxx");
	api->Apply(VTICInlineIncludes,"IncludeNoSafe");
      }
      // this part is for class created by instantiations
      //
      else {
	if (theClass->GetMother().IsNull()) {
	  api->AddVariable(VIClass,aCreator->GenClass()->ToCString());
	}
	else {
	  api->AddVariable(VIClass,theClass->GetMother()->ToCString());
	}
	api->AddVariable(VSuffix,"lxx");
	api->Apply(VTICInlineIncludes,"IncludeMDTVNoSafe");
	
	CPP_GenericMDTVDefineOBJY(aMeta,api,aCreator,VTICDefines,VTICUndefines,Standard_True);
      }
    }
        
    CPP_UsedTypes(aMeta,theClass,List,incp);

    publics->Clear();

    api->AddVariable(VSuffix,"hxx");

    for (i = 1; i <= List->Length(); i++) {
      if (!List->Value(i)->IsSameString(theClass->FullName())) {
	api->AddVariable(VIClass,List->Value(i)->ToCString());
	api->Apply(VTICIncludes,"Include");
	publics->AssignCat(api->GetVariableValue(VTICIncludes));
      }
    }


    for (i = 1; i <= incp->Length(); i++) {
      if (!incp->Value(i)->IsSameString(theClass->FullName())) {
	api->AddVariable(VIClass,incp->Value(i)->ToCString());
	api->Apply(VTICIncludes,"ShortDec");
	publics->AssignCat(api->GetVariableValue(VTICIncludes));
      }
    }

    api->AddVariable(VTICIncludes,publics->ToCString());

    api->Apply(VoutClass,"PersistentOBJYInstClass");
    
    // we write the .hxx of this class
    //
    Handle(TCollection_HAsciiString) aFile = new TCollection_HAsciiString(api->GetVariableValue(VFullPath));

    aFile->AssignCat(theClass->FullName());
    aFile->AssignCat("_objy.ddl");

    CPP_WriteFile(api,aFile,VoutClass);
    
    outfile->Append(aFile);

    // .ixx or _0.cxx
    //
    if (!HasDestructor) {
      api->Apply(VMethod,"FullEmptyDestructorTemplate");
      Supplement->Append(new TCollection_HAsciiString(api->GetVariableValue(VMethod)));
    }

    CPP_PersistentDerivatedOBJY(aMeta,api,aClass,outfile,incp,Supplement);
  }
  else {
    ErrorMsg << "CPPExt" << "CPP_PersistentClassOBJY - the class is NULL..." << endm;
    Standard_NoSuchObject::Raise();
  }
}

