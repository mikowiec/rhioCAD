// File generated by CPPExt (CPP file)
//

#include "TDF_Tool.h"
#include "../Converter.h"
#include "TDF_Label.h"
#include "TDF_IDFilter.h"
#include "TDF_AttributeMap.h"
#include "../TCollection/TCollection_AsciiString.h"
#include "../TColStd/TColStd_ListOfInteger.h"
#include "TDF_Data.h"
#include "TDF_LabelList.h"
#include "TDF_LabelIntegerMap.h"


using namespace OCNaroWrappers;

OCTDF_Tool::OCTDF_Tool(TDF_Tool* nativeHandle) 
{
  this->nativeHandle = nativeHandle;
}

 Standard_Integer OCTDF_Tool::NbLabels(OCNaroWrappers::OCTDF_Label^ aLabel)
{
  return TDF_Tool::NbLabels(*((TDF_Label*)aLabel->Handle));
}

 Standard_Integer OCTDF_Tool::NbAttributes(OCNaroWrappers::OCTDF_Label^ aLabel)
{
  return TDF_Tool::NbAttributes(*((TDF_Label*)aLabel->Handle));
}

 Standard_Integer OCTDF_Tool::NbAttributes(OCNaroWrappers::OCTDF_Label^ aLabel, OCNaroWrappers::OCTDF_IDFilter^ aFilter)
{
  return TDF_Tool::NbAttributes(*((TDF_Label*)aLabel->Handle), *((TDF_IDFilter*)aFilter->Handle));
}

 System::Boolean OCTDF_Tool::IsSelfContained(OCNaroWrappers::OCTDF_Label^ aLabel)
{
  return OCConverter::StandardBooleanToBoolean(TDF_Tool::IsSelfContained(*((TDF_Label*)aLabel->Handle)));
}

 System::Boolean OCTDF_Tool::IsSelfContained(OCNaroWrappers::OCTDF_Label^ aLabel, OCNaroWrappers::OCTDF_IDFilter^ aFilter)
{
  return OCConverter::StandardBooleanToBoolean(TDF_Tool::IsSelfContained(*((TDF_Label*)aLabel->Handle), *((TDF_IDFilter*)aFilter->Handle)));
}

 void OCTDF_Tool::OutReferers(OCNaroWrappers::OCTDF_Label^ theLabel, OCNaroWrappers::OCTDF_AttributeMap^ theAtts)
{
  TDF_Tool::OutReferers(*((TDF_Label*)theLabel->Handle), *((TDF_AttributeMap*)theAtts->Handle));
}

 void OCTDF_Tool::OutReferers(OCNaroWrappers::OCTDF_Label^ aLabel, OCNaroWrappers::OCTDF_IDFilter^ aFilterForReferers, OCNaroWrappers::OCTDF_IDFilter^ aFilterForReferences, OCNaroWrappers::OCTDF_AttributeMap^ atts)
{
  TDF_Tool::OutReferers(*((TDF_Label*)aLabel->Handle), *((TDF_IDFilter*)aFilterForReferers->Handle), *((TDF_IDFilter*)aFilterForReferences->Handle), *((TDF_AttributeMap*)atts->Handle));
}

 void OCTDF_Tool::OutReferences(OCNaroWrappers::OCTDF_Label^ aLabel, OCNaroWrappers::OCTDF_AttributeMap^ atts)
{
  TDF_Tool::OutReferences(*((TDF_Label*)aLabel->Handle), *((TDF_AttributeMap*)atts->Handle));
}

 void OCTDF_Tool::OutReferences(OCNaroWrappers::OCTDF_Label^ aLabel, OCNaroWrappers::OCTDF_IDFilter^ aFilterForReferers, OCNaroWrappers::OCTDF_IDFilter^ aFilterForReferences, OCNaroWrappers::OCTDF_AttributeMap^ atts)
{
  TDF_Tool::OutReferences(*((TDF_Label*)aLabel->Handle), *((TDF_IDFilter*)aFilterForReferers->Handle), *((TDF_IDFilter*)aFilterForReferences->Handle), *((TDF_AttributeMap*)atts->Handle));
}

 void OCTDF_Tool::RelocateLabel(OCNaroWrappers::OCTDF_Label^ aSourceLabel, OCNaroWrappers::OCTDF_Label^ fromRoot, OCNaroWrappers::OCTDF_Label^ toRoot, OCNaroWrappers::OCTDF_Label^ aTargetLabel, System::Boolean create)
{
  TDF_Tool::RelocateLabel(*((TDF_Label*)aSourceLabel->Handle), *((TDF_Label*)fromRoot->Handle), *((TDF_Label*)toRoot->Handle), *((TDF_Label*)aTargetLabel->Handle), OCConverter::BooleanToStandardBoolean(create));
}

 void OCTDF_Tool::Entry(OCNaroWrappers::OCTDF_Label^ aLabel, OCNaroWrappers::OCTCollection_AsciiString^ anEntry)
{
  TDF_Tool::Entry(*((TDF_Label*)aLabel->Handle), *((TCollection_AsciiString*)anEntry->Handle));
}

 void OCTDF_Tool::TagList(OCNaroWrappers::OCTDF_Label^ aLabel, OCNaroWrappers::OCTColStd_ListOfInteger^ aTagList)
{
  TDF_Tool::TagList(*((TDF_Label*)aLabel->Handle), *((TColStd_ListOfInteger*)aTagList->Handle));
}

 void OCTDF_Tool::TagList(OCNaroWrappers::OCTCollection_AsciiString^ anEntry, OCNaroWrappers::OCTColStd_ListOfInteger^ aTagList)
{
  TDF_Tool::TagList(*((TCollection_AsciiString*)anEntry->Handle), *((TColStd_ListOfInteger*)aTagList->Handle));
}

 void OCTDF_Tool::Label(OCNaroWrappers::OCTDF_Data^ aDF, OCNaroWrappers::OCTCollection_AsciiString^ anEntry, OCNaroWrappers::OCTDF_Label^ aLabel, System::Boolean create)
{
  TDF_Tool::Label(*((Handle_TDF_Data*)aDF->Handle), *((TCollection_AsciiString*)anEntry->Handle), *((TDF_Label*)aLabel->Handle), OCConverter::BooleanToStandardBoolean(create));
}

 void OCTDF_Tool::Label(OCNaroWrappers::OCTDF_Data^ aDF, System::String^ anEntry, OCNaroWrappers::OCTDF_Label^ aLabel, System::Boolean create)
{
  TDF_Tool::Label(*((Handle_TDF_Data*)aDF->Handle), OCConverter::StringToStandardCString(anEntry), *((TDF_Label*)aLabel->Handle), OCConverter::BooleanToStandardBoolean(create));
}

 void OCTDF_Tool::Label(OCNaroWrappers::OCTDF_Data^ aDF, OCNaroWrappers::OCTColStd_ListOfInteger^ aTagList, OCNaroWrappers::OCTDF_Label^ aLabel, System::Boolean create)
{
  TDF_Tool::Label(*((Handle_TDF_Data*)aDF->Handle), *((TColStd_ListOfInteger*)aTagList->Handle), *((TDF_Label*)aLabel->Handle), OCConverter::BooleanToStandardBoolean(create));
}

 void OCTDF_Tool::CountLabels(OCNaroWrappers::OCTDF_LabelList^ aLabelList, OCNaroWrappers::OCTDF_LabelIntegerMap^ aLabelMap)
{
  TDF_Tool::CountLabels(*((TDF_LabelList*)aLabelList->Handle), *((TDF_LabelIntegerMap*)aLabelMap->Handle));
}

 void OCTDF_Tool::DeductLabels(OCNaroWrappers::OCTDF_LabelList^ aLabelList, OCNaroWrappers::OCTDF_LabelIntegerMap^ aLabelMap)
{
  TDF_Tool::DeductLabels(*((TDF_LabelList*)aLabelList->Handle), *((TDF_LabelIntegerMap*)aLabelMap->Handle));
}

 void OCTDF_Tool::DeepDump(Standard_OStream& anOS, OCNaroWrappers::OCTDF_Data^ aDF)
{
  TDF_Tool::DeepDump(anOS, *((Handle_TDF_Data*)aDF->Handle));
}

 void OCTDF_Tool::ExtendedDeepDump(Standard_OStream& anOS, OCNaroWrappers::OCTDF_Data^ aDF, OCNaroWrappers::OCTDF_IDFilter^ aFilter)
{
  TDF_Tool::ExtendedDeepDump(anOS, *((Handle_TDF_Data*)aDF->Handle), *((TDF_IDFilter*)aFilter->Handle));
}

 void OCTDF_Tool::DeepDump(Standard_OStream& anOS, OCNaroWrappers::OCTDF_Label^ aLabel)
{
  TDF_Tool::DeepDump(anOS, *((TDF_Label*)aLabel->Handle));
}

 void OCTDF_Tool::ExtendedDeepDump(Standard_OStream& anOS, OCNaroWrappers::OCTDF_Label^ aLabel, OCNaroWrappers::OCTDF_IDFilter^ aFilter)
{
  TDF_Tool::ExtendedDeepDump(anOS, *((TDF_Label*)aLabel->Handle), *((TDF_IDFilter*)aFilter->Handle));
}


