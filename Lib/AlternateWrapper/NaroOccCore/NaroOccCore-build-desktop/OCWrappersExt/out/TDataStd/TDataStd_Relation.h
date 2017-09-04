// File generated by CPPExt (Transient)
//
#ifndef _TDataStd_Relation_OCWrappers_HeaderFile
#define _TDataStd_Relation_OCWrappers_HeaderFile

// include the wrapped class
#include <TDataStd_Relation.hxx>
#include "../Converter.h"

#include "../TDF/TDF_Attribute.h"

#include "../TCollection/TCollection_ExtendedString.h"
#include "../TDF/TDF_AttributeList.h"


namespace OCNaroWrappers
{

ref class OCStandard_GUID;
ref class OCTDF_Label;
ref class OCTCollection_ExtendedString;
ref class OCTDF_AttributeList;
ref class OCTDF_Attribute;
ref class OCTDF_RelocationTable;


//! Relation attribute. <br>
//!          ================== <br>
public ref class OCTDataStd_Relation : OCTDF_Attribute {

protected:
  // dummy constructor;
  OCTDataStd_Relation(OCDummy^) : OCTDF_Attribute((OCDummy^)nullptr) {};

public:

// constructor from native
OCTDataStd_Relation(Handle(TDataStd_Relation)* nativeHandle);

// Methods PUBLIC

//! class methods <br>
//!          ============= <br>
static /*instead*/  OCStandard_GUID^ GetID() ;

//! Find, or create, an Relation attribute. <br>//! Real methods <br>
//!          ============ <br>
static /*instead*/  OCTDataStd_Relation^ Set(OCNaroWrappers::OCTDF_Label^ label) ;


OCTDataStd_Relation();

//! build and return the relation name <br>
 /*instead*/  OCTCollection_ExtendedString^ Name() ;


 /*instead*/  void SetRelation(OCNaroWrappers::OCTCollection_ExtendedString^ E) ;


 /*instead*/  OCTCollection_ExtendedString^ GetRelation() ;


 /*instead*/  OCTDF_AttributeList^ GetVariables() ;


 /*instead*/  OCStandard_GUID^ ID() ;


 /*instead*/  void Restore(OCNaroWrappers::OCTDF_Attribute^ With) ;


 /*instead*/  OCTDF_Attribute^ NewEmpty() ;


 /*instead*/  void Paste(OCNaroWrappers::OCTDF_Attribute^ Into, OCNaroWrappers::OCTDF_RelocationTable^ RT) ;


virtual /*instead*/  Standard_OStream& Dump(Standard_OStream& anOS) override;

~OCTDataStd_Relation()
{
  nativeHandle->Nullify();
  delete nativeHandle;
}

};

}; // OCNaroWrappers

#endif
