// File generated by CPPExt (Transient)
//
#ifndef _TDocStd_XLink_OCWrappers_HeaderFile
#define _TDocStd_XLink_OCWrappers_HeaderFile

// include the wrapped class
#include <TDocStd_XLink.hxx>
#include "../Converter.h"

#include "../TDF/TDF_Attribute.h"

#include "../TCollection/TCollection_AsciiString.h"


namespace OCNaroWrappers
{

ref class OCTDocStd_XLinkRoot;
ref class OCTDocStd_XLinkIterator;
ref class OCTDF_Label;
ref class OCTDF_Reference;
ref class OCStandard_GUID;
ref class OCTCollection_AsciiString;
ref class OCTDF_AttributeDelta;
ref class OCTDF_Attribute;
ref class OCTDF_RelocationTable;


//! An attribute to store the path and the entry of <br>
//! external links. <br>
//!  These refer from one data structure to a data <br>
//!  structure in another document. <br>
public ref class OCTDocStd_XLink : OCTDF_Attribute {

protected:
  // dummy constructor;
  OCTDocStd_XLink(OCDummy^) : OCTDF_Attribute((OCDummy^)nullptr) {};

public:

// constructor from native
OCTDocStd_XLink(Handle(TDocStd_XLink)* nativeHandle);

// Methods PUBLIC

//! Sets an empty external reference, at the label aLabel. <br>
static /*instead*/  OCTDocStd_XLink^ Set(OCNaroWrappers::OCTDF_Label^ atLabel) ;

//! Initializes fields. <br>
OCTDocStd_XLink();

//!  Updates the data referenced in this external link attribute. <br>
 /*instead*/  OCTDF_Reference^ Update() ;

//! Returns the ID of the attribute. <br>
virtual /*instead*/  OCStandard_GUID^ ID() ;

//! Returns the GUID for external links. <br>
//! <br>
static /*instead*/  OCStandard_GUID^ GetID() ;

//! Sets the name aDocEntry for the external <br>
//! document in this external link attribute. <br>
 /*instead*/  void DocumentEntry(OCNaroWrappers::OCTCollection_AsciiString^ aDocEntry) ;

//! Returns the contents of the document identified by aDocEntry. <br>
//! aDocEntry provides external data to this external link attribute. <br>
 /*instead*/  OCTCollection_AsciiString^ DocumentEntry() ;

//! Sets the label entry for this external link attribute with the label aLabel. <br>
//! aLabel pilots the importation of data from the document entry. <br>
 /*instead*/  void LabelEntry(OCNaroWrappers::OCTDF_Label^ aLabel) ;

//!  Sets the label entry for this external link attribute <br>
//! as a document identified by aLabEntry. <br>
 /*instead*/  void LabelEntry(OCNaroWrappers::OCTCollection_AsciiString^ aLabEntry) ;

//! Returns the contents of the field <myLabelEntry>. <br>
//! <br>
 /*instead*/  OCTCollection_AsciiString^ LabelEntry() ;

//! Updates the XLinkRoot attribute by adding <me> <br>
//!          to its list. <br>
virtual /*instead*/  void AfterAddition() override;

//! Updates the XLinkRoot attribute by removing <me> <br>
//!          from its list. <br>
virtual /*instead*/  void BeforeRemoval() override;

//! Something to do before applying <anAttDelta>. <br>
virtual /*instead*/  System::Boolean BeforeUndo(OCNaroWrappers::OCTDF_AttributeDelta^ anAttDelta, System::Boolean forceIt) override;

//! Something to do after applying <anAttDelta>. <br>
virtual /*instead*/  System::Boolean AfterUndo(OCNaroWrappers::OCTDF_AttributeDelta^ anAttDelta, System::Boolean forceIt) override;

//! Returns a null handle. Raise allways for ,it is <br>
//!          nonsense to use this method. <br>
virtual /*instead*/  OCTDF_Attribute^ BackupCopy() override;

//! Does nothing. <br>
virtual /*instead*/  void Restore(OCNaroWrappers::OCTDF_Attribute^ anAttribute) ;

//! Returns a null handle. <br>
virtual /*instead*/  OCTDF_Attribute^ NewEmpty() ;

//! Does nothing. <br>
virtual /*instead*/  void Paste(OCNaroWrappers::OCTDF_Attribute^ intoAttribute, OCNaroWrappers::OCTDF_RelocationTable^ aRelocationTable) ;

//! Dumps the attribute on <aStream>. <br>
virtual /*instead*/  Standard_OStream& Dump(Standard_OStream& anOS) override;

~OCTDocStd_XLink()
{
  nativeHandle->Nullify();
  delete nativeHandle;
}

};

}; // OCNaroWrappers

#endif
