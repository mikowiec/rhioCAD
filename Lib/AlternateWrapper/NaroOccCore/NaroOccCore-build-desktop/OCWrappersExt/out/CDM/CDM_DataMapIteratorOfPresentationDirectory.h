// File generated by CPPExt (MPV)
//
#ifndef _CDM_DataMapIteratorOfPresentationDirectory_OCWrappers_HeaderFile
#define _CDM_DataMapIteratorOfPresentationDirectory_OCWrappers_HeaderFile

// include native header
#include <CDM_DataMapIteratorOfPresentationDirectory.hxx>
#include "../Converter.h"

#include "../TCollection/TCollection_BasicMapIterator.h"

#include "../TCollection/TCollection_BasicMapIterator.h"


namespace OCNaroWrappers
{

ref class OCTCollection_ExtendedString;
ref class OCCDM_Document;
ref class OCCDM_PresentationDirectory;
ref class OCCDM_DataMapNodeOfPresentationDirectory;



public ref class OCCDM_DataMapIteratorOfPresentationDirectory  : public OCTCollection_BasicMapIterator {

protected:
  // dummy constructor;
  OCCDM_DataMapIteratorOfPresentationDirectory(OCDummy^) : OCTCollection_BasicMapIterator((OCDummy^)nullptr) {};

public:

// constructor from native
OCCDM_DataMapIteratorOfPresentationDirectory(CDM_DataMapIteratorOfPresentationDirectory* nativeHandle);

// Methods PUBLIC


OCCDM_DataMapIteratorOfPresentationDirectory();


OCCDM_DataMapIteratorOfPresentationDirectory(OCNaroWrappers::OCCDM_PresentationDirectory^ aMap);


 /*instead*/  void Initialize(OCNaroWrappers::OCCDM_PresentationDirectory^ aMap) ;


 /*instead*/  OCTCollection_ExtendedString^ Key() ;


 /*instead*/  OCCDM_Document^ Value() ;

~OCCDM_DataMapIteratorOfPresentationDirectory()
{
  delete nativeHandle;
}

};

}; // OCNaroWrappers

#endif
