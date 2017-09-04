// File generated by CPPExt (Package)
//

#ifndef _TDF_OCWrappers_HeaderFile
#define _TDF_OCWrappers_HeaderFile

// Include the wrapped header
#include <TDF.hxx>

#include "TDF_Data.h"
#include "TDF_Label.h"
#include "TDF_Attribute.h"
#include "TDF_TagSource.h"
#include "TDF_Reference.h"
#include "TDF_ClosureMode.h"
#include "TDF_ClosureTool.h"
#include "TDF_CopyTool.h"
#include "TDF_CopyLabel.h"
#include "TDF_ComparisonTool.h"
#include "TDF_Transaction.h"
#include "TDF_Delta.h"
#include "TDF_AttributeDelta.h"
#include "TDF_DeltaOnAddition.h"
#include "TDF_DeltaOnForget.h"
#include "TDF_DeltaOnResume.h"
#include "TDF_DeltaOnRemoval.h"
#include "TDF_DeltaOnModification.h"
#include "TDF_DefaultDeltaOnRemoval.h"
#include "TDF_DefaultDeltaOnModification.h"
#include "TDF_ChildIterator.h"
#include "TDF_ChildIDIterator.h"
#include "TDF_DataSet.h"
#include "TDF_RelocationTable.h"
#include "TDF_Tool.h"
#include "TDF_LabelMapHasher.h"
#include "TDF_IDFilter.h"
#include "TDF_IDList.h"
#include "TDF_AttributeList.h"
#include "TDF_LabelList.h"
#include "TDF_AttributeDeltaList.h"
#include "TDF_DeltaList.h"
#include "TDF_AttributeSequence.h"
#include "TDF_LabelSequence.h"
#include "TDF_AttributeArray1.h"
#include "TDF_HAttributeArray1.h"
#include "TDF_IDMap.h"
#include "TDF_AttributeMap.h"
#include "TDF_AttributeDataMap.h"
#include "TDF_AttributeDoubleMap.h"
#include "TDF_AttributeIndexedMap.h"
#include "TDF_LabelMap.h"
#include "TDF_LabelDataMap.h"
#include "TDF_LabelDoubleMap.h"
#include "TDF_LabelIndexedMap.h"
#include "TDF_LabelIntegerMap.h"
#include "TDF_LabelLabelMap.h"
#include "TDF_GUIDProgIDMap.h"
#include "TDF_ListNodeOfIDList.h"
#include "TDF_ListIteratorOfIDList.h"
#include "TDF_ListNodeOfAttributeList.h"
#include "TDF_ListIteratorOfAttributeList.h"
#include "TDF_ListNodeOfLabelList.h"
#include "TDF_ListIteratorOfLabelList.h"
#include "TDF_ListNodeOfAttributeDeltaList.h"
#include "TDF_ListIteratorOfAttributeDeltaList.h"
#include "TDF_ListNodeOfDeltaList.h"
#include "TDF_ListIteratorOfDeltaList.h"
#include "TDF_SequenceNodeOfAttributeSequence.h"
#include "TDF_SequenceNodeOfLabelSequence.h"
#include "TDF_StdMapNodeOfIDMap.h"
#include "TDF_MapIteratorOfIDMap.h"
#include "TDF_StdMapNodeOfAttributeMap.h"
#include "TDF_MapIteratorOfAttributeMap.h"
#include "TDF_DataMapNodeOfAttributeDataMap.h"
#include "TDF_DataMapIteratorOfAttributeDataMap.h"
#include "TDF_DoubleMapNodeOfAttributeDoubleMap.h"
#include "TDF_DoubleMapIteratorOfAttributeDoubleMap.h"
#include "TDF_IndexedMapNodeOfAttributeIndexedMap.h"
#include "TDF_StdMapNodeOfLabelMap.h"
#include "TDF_MapIteratorOfLabelMap.h"
#include "TDF_DataMapNodeOfLabelDataMap.h"
#include "TDF_DataMapIteratorOfLabelDataMap.h"
#include "TDF_DoubleMapNodeOfLabelDoubleMap.h"
#include "TDF_DoubleMapIteratorOfLabelDoubleMap.h"
#include "TDF_IndexedMapNodeOfLabelIndexedMap.h"
#include "TDF_DataMapNodeOfLabelIntegerMap.h"
#include "TDF_DataMapIteratorOfLabelIntegerMap.h"
#include "TDF_DataMapNodeOfLabelLabelMap.h"
#include "TDF_DataMapIteratorOfLabelLabelMap.h"
#include "TDF_DoubleMapNodeOfGUIDProgIDMap.h"
#include "TDF_DoubleMapIteratorOfGUIDProgIDMap.h"


namespace OCNaroWrappers
{
//! This package provides data framework for binding <br>
//!          features and data structures. <br>
//! <br>
//!          The feature structure is a tree used to bind <br>
//!          semantic informations about each feature together. <br>
//! <br>
//!          The only one concrete   attribute defined in  this <br>
//!           package is the TagSource attribute.This attribute <br>
//!          is used for  random creation of child labels under <br>
//!          a given label. Tags are randomly delivered. <br>
public ref class OCTDF abstract sealed
{

public:
// Methods

//! Returns ID "00000000-0000-0000-0000-000000000000", <br>
//!          sometimes used as null ID. <br>
//! <br>
static /*instead*/  OCStandard_GUID^ LowestID() ;

//! Returns ID "ffffffff-ffff-ffff-ffff-ffffffffffff". <br>
//! <br>
static /*instead*/  OCStandard_GUID^ UppestID() ;

//! Sets link between GUID and ProgID in hidden DataMap <br>
static /*instead*/  void AddLinkGUIDToProgID(OCNaroWrappers::OCStandard_GUID^ ID, OCNaroWrappers::OCTCollection_ExtendedString^ ProgID) ;

//! Returns True if there is GUID for given <ProgID> then GUID is returned in <ID> <br>
static /*instead*/  System::Boolean GUIDFromProgID(OCNaroWrappers::OCTCollection_ExtendedString^ ProgID, OCNaroWrappers::OCStandard_GUID^ ID) ;

//! Returns True if there is ProgID for given <ID> then ProgID is returned in <ProgID> <br>
static /*instead*/  System::Boolean ProgIDFromGUID(OCNaroWrappers::OCStandard_GUID^ ID, OCNaroWrappers::OCTCollection_ExtendedString^ ProgID) ;


};

}; // OCNaroWrappers

#endif
