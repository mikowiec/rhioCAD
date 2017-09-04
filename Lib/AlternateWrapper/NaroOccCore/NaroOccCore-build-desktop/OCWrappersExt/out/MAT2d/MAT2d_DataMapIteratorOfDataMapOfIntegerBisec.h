// File generated by CPPExt (MPV)
//
#ifndef _MAT2d_DataMapIteratorOfDataMapOfIntegerBisec_OCWrappers_HeaderFile
#define _MAT2d_DataMapIteratorOfDataMapOfIntegerBisec_OCWrappers_HeaderFile

// include native header
#include <MAT2d_DataMapIteratorOfDataMapOfIntegerBisec.hxx>
#include "../Converter.h"

#include "../TCollection/TCollection_BasicMapIterator.h"

#include "../TCollection/TCollection_BasicMapIterator.h"


namespace OCNaroWrappers
{

ref class OCBisector_Bisec;
ref class OCTColStd_MapIntegerHasher;
ref class OCMAT2d_DataMapOfIntegerBisec;
ref class OCMAT2d_DataMapNodeOfDataMapOfIntegerBisec;



public ref class OCMAT2d_DataMapIteratorOfDataMapOfIntegerBisec  : public OCTCollection_BasicMapIterator {

protected:
  // dummy constructor;
  OCMAT2d_DataMapIteratorOfDataMapOfIntegerBisec(OCDummy^) : OCTCollection_BasicMapIterator((OCDummy^)nullptr) {};

public:

// constructor from native
OCMAT2d_DataMapIteratorOfDataMapOfIntegerBisec(MAT2d_DataMapIteratorOfDataMapOfIntegerBisec* nativeHandle);

// Methods PUBLIC


OCMAT2d_DataMapIteratorOfDataMapOfIntegerBisec();


OCMAT2d_DataMapIteratorOfDataMapOfIntegerBisec(OCNaroWrappers::OCMAT2d_DataMapOfIntegerBisec^ aMap);


 /*instead*/  void Initialize(OCNaroWrappers::OCMAT2d_DataMapOfIntegerBisec^ aMap) ;


 /*instead*/  Standard_Integer Key() ;


 /*instead*/  OCBisector_Bisec^ Value() ;

~OCMAT2d_DataMapIteratorOfDataMapOfIntegerBisec()
{
  delete nativeHandle;
}

};

}; // OCNaroWrappers

#endif
