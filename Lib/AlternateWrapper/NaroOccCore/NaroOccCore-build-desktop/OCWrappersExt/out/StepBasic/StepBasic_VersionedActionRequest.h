// File generated by CPPExt (Transient)
//
#ifndef _StepBasic_VersionedActionRequest_OCWrappers_HeaderFile
#define _StepBasic_VersionedActionRequest_OCWrappers_HeaderFile

// include the wrapped class
#include <StepBasic_VersionedActionRequest.hxx>
#include "../Converter.h"

#include "../MMgt/MMgt_TShared.h"



namespace OCNaroWrappers
{

ref class OCTCollection_HAsciiString;


//! Representation of STEP entity VersionedActionRequest <br>
public ref class OCStepBasic_VersionedActionRequest : OCMMgt_TShared {

protected:
  // dummy constructor;
  OCStepBasic_VersionedActionRequest(OCDummy^) : OCMMgt_TShared((OCDummy^)nullptr) {};

public:

// constructor from native
OCStepBasic_VersionedActionRequest(Handle(StepBasic_VersionedActionRequest)* nativeHandle);

// Methods PUBLIC

//! Empty constructor <br>
OCStepBasic_VersionedActionRequest();

//! Initialize all fields (own and inherited) <br>
 /*instead*/  void Init(OCNaroWrappers::OCTCollection_HAsciiString^ aId, OCNaroWrappers::OCTCollection_HAsciiString^ aVersion, OCNaroWrappers::OCTCollection_HAsciiString^ aPurpose, System::Boolean hasDescription, OCNaroWrappers::OCTCollection_HAsciiString^ aDescription) ;

//! Returns field Id <br>
 /*instead*/  OCTCollection_HAsciiString^ Id() ;

//! Set field Id <br>
 /*instead*/  void SetId(OCNaroWrappers::OCTCollection_HAsciiString^ Id) ;

//! Returns field Version <br>
 /*instead*/  OCTCollection_HAsciiString^ Version() ;

//! Set field Version <br>
 /*instead*/  void SetVersion(OCNaroWrappers::OCTCollection_HAsciiString^ Version) ;

//! Returns field Purpose <br>
 /*instead*/  OCTCollection_HAsciiString^ Purpose() ;

//! Set field Purpose <br>
 /*instead*/  void SetPurpose(OCNaroWrappers::OCTCollection_HAsciiString^ Purpose) ;

//! Returns field Description <br>
 /*instead*/  OCTCollection_HAsciiString^ Description() ;

//! Set field Description <br>
 /*instead*/  void SetDescription(OCNaroWrappers::OCTCollection_HAsciiString^ Description) ;

//! Returns True if optional field Description is defined <br>
 /*instead*/  System::Boolean HasDescription() ;

~OCStepBasic_VersionedActionRequest()
{
  nativeHandle->Nullify();
  delete nativeHandle;
}

};

}; // OCNaroWrappers

#endif