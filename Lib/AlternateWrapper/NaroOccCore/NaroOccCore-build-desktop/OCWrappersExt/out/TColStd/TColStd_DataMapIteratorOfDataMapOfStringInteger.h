// File generated by CPPExt (MPV)
//
#ifndef _TColStd_DataMapIteratorOfDataMapOfStringInteger_OCWrappers_HeaderFile
#define _TColStd_DataMapIteratorOfDataMapOfStringInteger_OCWrappers_HeaderFile

// include native header
#include <TColStd_DataMapIteratorOfDataMapOfStringInteger.hxx>
#include "../Converter.h"

#include "../TCollection/TCollection_BasicMapIterator.h"

#include "../TCollection/TCollection_BasicMapIterator.h"


namespace OCNaroWrappers
{

ref class OCTCollection_ExtendedString;
ref class OCTColStd_DataMapOfStringInteger;
ref class OCTColStd_DataMapNodeOfDataMapOfStringInteger;



public ref class OCTColStd_DataMapIteratorOfDataMapOfStringInteger  : public OCTCollection_BasicMapIterator {

protected:
  // dummy constructor;
  OCTColStd_DataMapIteratorOfDataMapOfStringInteger(OCDummy^) : OCTCollection_BasicMapIterator((OCDummy^)nullptr) {};

public:

// constructor from native
OCTColStd_DataMapIteratorOfDataMapOfStringInteger(TColStd_DataMapIteratorOfDataMapOfStringInteger* nativeHandle);

// Methods PUBLIC


OCTColStd_DataMapIteratorOfDataMapOfStringInteger();


OCTColStd_DataMapIteratorOfDataMapOfStringInteger(OCNaroWrappers::OCTColStd_DataMapOfStringInteger^ aMap);


 /*instead*/  void Initialize(OCNaroWrappers::OCTColStd_DataMapOfStringInteger^ aMap) ;


 /*instead*/  OCTCollection_ExtendedString^ Key() ;


 /*instead*/  Standard_Integer Value() ;

~OCTColStd_DataMapIteratorOfDataMapOfStringInteger()
{
  delete nativeHandle;
}

};

}; // OCNaroWrappers

#endif
