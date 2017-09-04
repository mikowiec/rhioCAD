// File generated by CPPExt (MPV)
//
#ifndef _TopLoc_IndexedMapOfLocation_OCWrappers_HeaderFile
#define _TopLoc_IndexedMapOfLocation_OCWrappers_HeaderFile

// include native header
#include <TopLoc_IndexedMapOfLocation.hxx>
#include "../Converter.h"

#include "../TCollection/TCollection_BasicMap.h"

#include "../TCollection/TCollection_BasicMap.h"


namespace OCNaroWrappers
{

ref class OCTopLoc_Location;
ref class OCTopLoc_MapLocationHasher;
ref class OCTopLoc_IndexedMapNodeOfIndexedMapOfLocation;



public ref class OCTopLoc_IndexedMapOfLocation  : public OCTCollection_BasicMap {

protected:
  // dummy constructor;
  OCTopLoc_IndexedMapOfLocation(OCDummy^) : OCTCollection_BasicMap((OCDummy^)nullptr) {};

public:

// constructor from native
OCTopLoc_IndexedMapOfLocation(TopLoc_IndexedMapOfLocation* nativeHandle);

// Methods PUBLIC


OCTopLoc_IndexedMapOfLocation(Standard_Integer NbBuckets);


 /*instead*/  OCTopLoc_IndexedMapOfLocation^ Assign(OCNaroWrappers::OCTopLoc_IndexedMapOfLocation^ Other) ;


 /*instead*/  void ReSize(Standard_Integer NbBuckets) ;


 /*instead*/  Standard_Integer Add(OCNaroWrappers::OCTopLoc_Location^ K) ;


 /*instead*/  void Substitute(Standard_Integer I, OCNaroWrappers::OCTopLoc_Location^ K) ;


 /*instead*/  void RemoveLast() ;


 /*instead*/  System::Boolean Contains(OCNaroWrappers::OCTopLoc_Location^ K) ;


 /*instead*/  OCTopLoc_Location^ FindKey(Standard_Integer I) ;


 /*instead*/  Standard_Integer FindIndex(OCNaroWrappers::OCTopLoc_Location^ K) ;

~OCTopLoc_IndexedMapOfLocation()
{
  delete nativeHandle;
}

};

}; // OCNaroWrappers

#endif
