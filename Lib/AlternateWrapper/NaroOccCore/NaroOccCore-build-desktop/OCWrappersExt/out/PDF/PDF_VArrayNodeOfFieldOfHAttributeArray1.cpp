// File generated by CPPExt (CPP file)
//

#include "PDF_VArrayNodeOfFieldOfHAttributeArray1.h"
#include "../Converter.h"
#include "PDF_Attribute.h"
#include "PDF_FieldOfHAttributeArray1.h"
#include "PDF_VArrayTNodeOfFieldOfHAttributeArray1.h"


using namespace OCNaroWrappers;

OCPDF_VArrayNodeOfFieldOfHAttributeArray1::OCPDF_VArrayNodeOfFieldOfHAttributeArray1(Handle(PDF_VArrayNodeOfFieldOfHAttributeArray1)* nativeHandle) : OCPStandard_ArrayNode((OCDummy^)nullptr)

{
  this->nativeHandle = new Handle_PDF_VArrayNodeOfFieldOfHAttributeArray1(*nativeHandle);
}

OCPDF_VArrayNodeOfFieldOfHAttributeArray1::OCPDF_VArrayNodeOfFieldOfHAttributeArray1() : OCPStandard_ArrayNode((OCDummy^)nullptr)

{
  nativeHandle = new Handle_PDF_VArrayNodeOfFieldOfHAttributeArray1(new PDF_VArrayNodeOfFieldOfHAttributeArray1());
}

OCPDF_VArrayNodeOfFieldOfHAttributeArray1::OCPDF_VArrayNodeOfFieldOfHAttributeArray1(OCNaroWrappers::OCPDF_Attribute^ aValue) : OCPStandard_ArrayNode((OCDummy^)nullptr)

{
  nativeHandle = new Handle_PDF_VArrayNodeOfFieldOfHAttributeArray1(new PDF_VArrayNodeOfFieldOfHAttributeArray1(*((Handle_PDF_Attribute*)aValue->Handle)));
}

 void OCPDF_VArrayNodeOfFieldOfHAttributeArray1::SetValue(OCNaroWrappers::OCPDF_Attribute^ aValue)
{
  (*((Handle_PDF_VArrayNodeOfFieldOfHAttributeArray1*)nativeHandle))->SetValue(*((Handle_PDF_Attribute*)aValue->Handle));
}

 Standard_Address OCPDF_VArrayNodeOfFieldOfHAttributeArray1::Value()
{
  return (*((Handle_PDF_VArrayNodeOfFieldOfHAttributeArray1*)nativeHandle))->Value();
}


