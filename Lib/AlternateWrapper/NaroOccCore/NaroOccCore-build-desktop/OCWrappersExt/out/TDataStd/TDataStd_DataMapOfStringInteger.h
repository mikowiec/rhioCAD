// File generated by CPPExt (MPV)
//
#ifndef _TDataStd_DataMapOfStringInteger_OCWrappers_HeaderFile
#define _TDataStd_DataMapOfStringInteger_OCWrappers_HeaderFile

// include native header
#include <TDataStd_DataMapOfStringInteger.hxx>
#include "../Converter.h"

#include "../TCollection/TCollection_BasicMap.h"

#include "../TCollection/TCollection_BasicMap.h"


namespace OCNaroWrappers
{

ref class OCTCollection_ExtendedString;
ref class OCTDataStd_DataMapNodeOfDataMapOfStringInteger;
ref class OCTDataStd_DataMapIteratorOfDataMapOfStringInteger;



public ref class OCTDataStd_DataMapOfStringInteger  : public OCTCollection_BasicMap {

protected:
  // dummy constructor;
  OCTDataStd_DataMapOfStringInteger(OCDummy^) : OCTCollection_BasicMap((OCDummy^)nullptr) {};

public:

// constructor from native
OCTDataStd_DataMapOfStringInteger(TDataStd_DataMapOfStringInteger* nativeHandle);

// Methods PUBLIC


OCTDataStd_DataMapOfStringInteger(Standard_Integer NbBuckets);


 /*instead*/  OCTDataStd_DataMapOfStringInteger^ Assign(OCNaroWrappers::OCTDataStd_DataMapOfStringInteger^ Other) ;


 /*instead*/  void ReSize(Standard_Integer NbBuckets) ;


 /*instead*/  System::Boolean Bind(OCNaroWrappers::OCTCollection_ExtendedString^ K, Standard_Integer I) ;


 /*instead*/  System::Boolean IsBound(OCNaroWrappers::OCTCollection_ExtendedString^ K) ;


 /*instead*/  System::Boolean UnBind(OCNaroWrappers::OCTCollection_ExtendedString^ K) ;


 /*instead*/  Standard_Integer Find(OCNaroWrappers::OCTCollection_ExtendedString^ K) ;


 /*instead*/  Standard_Integer ChangeFind(OCNaroWrappers::OCTCollection_ExtendedString^ K) ;

~OCTDataStd_DataMapOfStringInteger()
{
  delete nativeHandle;
}

};

}; // OCNaroWrappers

#endif
