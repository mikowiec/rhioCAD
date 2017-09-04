// File generated by CPPExt (Transient)
//
#ifndef _CDM_Reference_OCWrappers_HeaderFile
#define _CDM_Reference_OCWrappers_HeaderFile

// include the wrapped class
#include <CDM_Reference.hxx>
#include "../Converter.h"

#include "../Standard/Standard_Transient.h"



namespace OCNaroWrappers
{

ref class OCCDM_Document;
ref class OCCDM_Application;
ref class OCCDM_MetaData;



public ref class OCCDM_Reference : OCStandard_Transient {

protected:
  // dummy constructor;
  OCCDM_Reference(OCDummy^) : OCStandard_Transient((OCDummy^)nullptr) {};

public:

// constructor from native
OCCDM_Reference(Handle(CDM_Reference)* nativeHandle);

// Methods PUBLIC


 /*instead*/  OCCDM_Document^ FromDocument() ;


 /*instead*/  OCCDM_Document^ ToDocument() ;


 /*instead*/  Standard_Integer ReferenceIdentifier() ;


 /*instead*/  Standard_Integer DocumentVersion() ;


 /*instead*/  System::Boolean IsReadOnly() ;

~OCCDM_Reference()
{
  nativeHandle->Nullify();
  delete nativeHandle;
}

};

}; // OCNaroWrappers

#endif
