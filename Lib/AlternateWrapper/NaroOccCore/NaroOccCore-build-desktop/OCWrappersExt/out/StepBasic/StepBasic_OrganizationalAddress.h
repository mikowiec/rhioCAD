// File generated by CPPExt (Transient)
//
#ifndef _StepBasic_OrganizationalAddress_OCWrappers_HeaderFile
#define _StepBasic_OrganizationalAddress_OCWrappers_HeaderFile

// include the wrapped class
#include <StepBasic_OrganizationalAddress.hxx>
#include "../Converter.h"

#include "StepBasic_Address.h"



namespace OCNaroWrappers
{

ref class OCStepBasic_HArray1OfOrganization;
ref class OCTCollection_HAsciiString;
ref class OCStepBasic_Organization;



public ref class OCStepBasic_OrganizationalAddress : OCStepBasic_Address {

protected:
  // dummy constructor;
  OCStepBasic_OrganizationalAddress(OCDummy^) : OCStepBasic_Address((OCDummy^)nullptr) {};

public:

// constructor from native
OCStepBasic_OrganizationalAddress(Handle(StepBasic_OrganizationalAddress)* nativeHandle);

// Methods PUBLIC

//! Returns a OrganizationalAddress <br>
OCStepBasic_OrganizationalAddress();


virtual /*instead*/  void Init(System::Boolean hasAinternalLocation, OCNaroWrappers::OCTCollection_HAsciiString^ aInternalLocation, System::Boolean hasAstreetNumber, OCNaroWrappers::OCTCollection_HAsciiString^ aStreetNumber, System::Boolean hasAstreet, OCNaroWrappers::OCTCollection_HAsciiString^ aStreet, System::Boolean hasApostalBox, OCNaroWrappers::OCTCollection_HAsciiString^ aPostalBox, System::Boolean hasAtown, OCNaroWrappers::OCTCollection_HAsciiString^ aTown, System::Boolean hasAregion, OCNaroWrappers::OCTCollection_HAsciiString^ aRegion, System::Boolean hasApostalCode, OCNaroWrappers::OCTCollection_HAsciiString^ aPostalCode, System::Boolean hasAcountry, OCNaroWrappers::OCTCollection_HAsciiString^ aCountry, System::Boolean hasAfacsimileNumber, OCNaroWrappers::OCTCollection_HAsciiString^ aFacsimileNumber, System::Boolean hasAtelephoneNumber, OCNaroWrappers::OCTCollection_HAsciiString^ aTelephoneNumber, System::Boolean hasAelectronicMailAddress, OCNaroWrappers::OCTCollection_HAsciiString^ aElectronicMailAddress, System::Boolean hasAtelexNumber, OCNaroWrappers::OCTCollection_HAsciiString^ aTelexNumber) override;


virtual /*instead*/  void Init(System::Boolean hasAinternalLocation, OCNaroWrappers::OCTCollection_HAsciiString^ aInternalLocation, System::Boolean hasAstreetNumber, OCNaroWrappers::OCTCollection_HAsciiString^ aStreetNumber, System::Boolean hasAstreet, OCNaroWrappers::OCTCollection_HAsciiString^ aStreet, System::Boolean hasApostalBox, OCNaroWrappers::OCTCollection_HAsciiString^ aPostalBox, System::Boolean hasAtown, OCNaroWrappers::OCTCollection_HAsciiString^ aTown, System::Boolean hasAregion, OCNaroWrappers::OCTCollection_HAsciiString^ aRegion, System::Boolean hasApostalCode, OCNaroWrappers::OCTCollection_HAsciiString^ aPostalCode, System::Boolean hasAcountry, OCNaroWrappers::OCTCollection_HAsciiString^ aCountry, System::Boolean hasAfacsimileNumber, OCNaroWrappers::OCTCollection_HAsciiString^ aFacsimileNumber, System::Boolean hasAtelephoneNumber, OCNaroWrappers::OCTCollection_HAsciiString^ aTelephoneNumber, System::Boolean hasAelectronicMailAddress, OCNaroWrappers::OCTCollection_HAsciiString^ aElectronicMailAddress, System::Boolean hasAtelexNumber, OCNaroWrappers::OCTCollection_HAsciiString^ aTelexNumber, OCNaroWrappers::OCStepBasic_HArray1OfOrganization^ aOrganizations, OCNaroWrappers::OCTCollection_HAsciiString^ aDescription) ;


 /*instead*/  void SetOrganizations(OCNaroWrappers::OCStepBasic_HArray1OfOrganization^ aOrganizations) ;


 /*instead*/  OCStepBasic_HArray1OfOrganization^ Organizations() ;


 /*instead*/  OCStepBasic_Organization^ OrganizationsValue(Standard_Integer num) ;


 /*instead*/  Standard_Integer NbOrganizations() ;


 /*instead*/  void SetDescription(OCNaroWrappers::OCTCollection_HAsciiString^ aDescription) ;


 /*instead*/  OCTCollection_HAsciiString^ Description() ;

~OCStepBasic_OrganizationalAddress()
{
  nativeHandle->Nullify();
  delete nativeHandle;
}

};

}; // OCNaroWrappers

#endif