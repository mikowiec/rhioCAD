// File generated by CPPExt (Transient)
//
#ifndef _StepBasic_PersonalAddress_OCWrappers_HeaderFile
#define _StepBasic_PersonalAddress_OCWrappers_HeaderFile

// include the wrapped class
#include <StepBasic_PersonalAddress.hxx>
#include "../Converter.h"

#include "StepBasic_Address.h"



namespace OCNaroWrappers
{

ref class OCStepBasic_HArray1OfPerson;
ref class OCTCollection_HAsciiString;
ref class OCStepBasic_Person;



public ref class OCStepBasic_PersonalAddress : OCStepBasic_Address {

protected:
  // dummy constructor;
  OCStepBasic_PersonalAddress(OCDummy^) : OCStepBasic_Address((OCDummy^)nullptr) {};

public:

// constructor from native
OCStepBasic_PersonalAddress(Handle(StepBasic_PersonalAddress)* nativeHandle);

// Methods PUBLIC

//! Returns a PersonalAddress <br>
OCStepBasic_PersonalAddress();


virtual /*instead*/  void Init(System::Boolean hasAinternalLocation, OCNaroWrappers::OCTCollection_HAsciiString^ aInternalLocation, System::Boolean hasAstreetNumber, OCNaroWrappers::OCTCollection_HAsciiString^ aStreetNumber, System::Boolean hasAstreet, OCNaroWrappers::OCTCollection_HAsciiString^ aStreet, System::Boolean hasApostalBox, OCNaroWrappers::OCTCollection_HAsciiString^ aPostalBox, System::Boolean hasAtown, OCNaroWrappers::OCTCollection_HAsciiString^ aTown, System::Boolean hasAregion, OCNaroWrappers::OCTCollection_HAsciiString^ aRegion, System::Boolean hasApostalCode, OCNaroWrappers::OCTCollection_HAsciiString^ aPostalCode, System::Boolean hasAcountry, OCNaroWrappers::OCTCollection_HAsciiString^ aCountry, System::Boolean hasAfacsimileNumber, OCNaroWrappers::OCTCollection_HAsciiString^ aFacsimileNumber, System::Boolean hasAtelephoneNumber, OCNaroWrappers::OCTCollection_HAsciiString^ aTelephoneNumber, System::Boolean hasAelectronicMailAddress, OCNaroWrappers::OCTCollection_HAsciiString^ aElectronicMailAddress, System::Boolean hasAtelexNumber, OCNaroWrappers::OCTCollection_HAsciiString^ aTelexNumber) override;


virtual /*instead*/  void Init(System::Boolean hasAinternalLocation, OCNaroWrappers::OCTCollection_HAsciiString^ aInternalLocation, System::Boolean hasAstreetNumber, OCNaroWrappers::OCTCollection_HAsciiString^ aStreetNumber, System::Boolean hasAstreet, OCNaroWrappers::OCTCollection_HAsciiString^ aStreet, System::Boolean hasApostalBox, OCNaroWrappers::OCTCollection_HAsciiString^ aPostalBox, System::Boolean hasAtown, OCNaroWrappers::OCTCollection_HAsciiString^ aTown, System::Boolean hasAregion, OCNaroWrappers::OCTCollection_HAsciiString^ aRegion, System::Boolean hasApostalCode, OCNaroWrappers::OCTCollection_HAsciiString^ aPostalCode, System::Boolean hasAcountry, OCNaroWrappers::OCTCollection_HAsciiString^ aCountry, System::Boolean hasAfacsimileNumber, OCNaroWrappers::OCTCollection_HAsciiString^ aFacsimileNumber, System::Boolean hasAtelephoneNumber, OCNaroWrappers::OCTCollection_HAsciiString^ aTelephoneNumber, System::Boolean hasAelectronicMailAddress, OCNaroWrappers::OCTCollection_HAsciiString^ aElectronicMailAddress, System::Boolean hasAtelexNumber, OCNaroWrappers::OCTCollection_HAsciiString^ aTelexNumber, OCNaroWrappers::OCStepBasic_HArray1OfPerson^ aPeople, OCNaroWrappers::OCTCollection_HAsciiString^ aDescription) ;


 /*instead*/  void SetPeople(OCNaroWrappers::OCStepBasic_HArray1OfPerson^ aPeople) ;


 /*instead*/  OCStepBasic_HArray1OfPerson^ People() ;


 /*instead*/  OCStepBasic_Person^ PeopleValue(Standard_Integer num) ;


 /*instead*/  Standard_Integer NbPeople() ;


 /*instead*/  void SetDescription(OCNaroWrappers::OCTCollection_HAsciiString^ aDescription) ;


 /*instead*/  OCTCollection_HAsciiString^ Description() ;

~OCStepBasic_PersonalAddress()
{
  nativeHandle->Nullify();
  delete nativeHandle;
}

};

}; // OCNaroWrappers

#endif
