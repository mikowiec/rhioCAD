// File generated by CPPExt (Transient)
//
#ifndef _CDM_Application_OCWrappers_HeaderFile
#define _CDM_Application_OCWrappers_HeaderFile

// include the wrapped class
#include <CDM_Application.hxx>
#include "../Converter.h"

#include "../Standard/Standard_Transient.h"



namespace OCNaroWrappers
{

ref class OCCDM_Reference;
ref class OCCDM_MetaData;
ref class OCCDM_Document;
ref class OCResource_Manager;
ref class OCCDM_MessageDriver;
ref class OCTCollection_ExtendedString;



public ref class OCCDM_Application : OCStandard_Transient {

protected:
  // dummy constructor;
  OCCDM_Application(OCDummy^) : OCStandard_Transient((OCDummy^)nullptr) {};

public:

// constructor from native
OCCDM_Application(Handle(CDM_Application)* nativeHandle);

// Methods PUBLIC

//! By default returns a NullMessageDriver; <br>
virtual /*instead*/  OCCDM_MessageDriver^ MessageDriver() ;

//! this method is called before the update of a document. <br>
//!         By default, writes in MessageDriver(). <br>
virtual /*instead*/  void BeginOfUpdate(OCNaroWrappers::OCCDM_Document^ aDocument) ;

//! this method is called affter the update of a document. <br>
//!         By default, writes in MessageDriver(). <br>
virtual /*instead*/  void EndOfUpdate(OCNaroWrappers::OCCDM_Document^ aDocument, System::Boolean Status, OCNaroWrappers::OCTCollection_ExtendedString^ ErrorString) ;

//! writes the string in the application MessagerDriver. <br>
 /*instead*/  void Write(System::String^ aString) ;

~OCCDM_Application()
{
  nativeHandle->Nullify();
  delete nativeHandle;
}

};

}; // OCNaroWrappers

#endif
