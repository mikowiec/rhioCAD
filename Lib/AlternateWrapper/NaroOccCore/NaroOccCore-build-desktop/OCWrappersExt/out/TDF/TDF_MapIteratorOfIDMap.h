// File generated by CPPExt (MPV)
//
#ifndef _TDF_MapIteratorOfIDMap_OCWrappers_HeaderFile
#define _TDF_MapIteratorOfIDMap_OCWrappers_HeaderFile

// include native header
#include <TDF_MapIteratorOfIDMap.hxx>
#include "../Converter.h"

#include "../TCollection/TCollection_BasicMapIterator.h"

#include "../TCollection/TCollection_BasicMapIterator.h"


namespace OCNaroWrappers
{

ref class OCStandard_GUID;
ref class OCTDF_IDMap;
ref class OCTDF_StdMapNodeOfIDMap;



public ref class OCTDF_MapIteratorOfIDMap  : public OCTCollection_BasicMapIterator {

protected:
  // dummy constructor;
  OCTDF_MapIteratorOfIDMap(OCDummy^) : OCTCollection_BasicMapIterator((OCDummy^)nullptr) {};

public:

// constructor from native
OCTDF_MapIteratorOfIDMap(TDF_MapIteratorOfIDMap* nativeHandle);

// Methods PUBLIC


OCTDF_MapIteratorOfIDMap();


OCTDF_MapIteratorOfIDMap(OCNaroWrappers::OCTDF_IDMap^ aMap);


 /*instead*/  void Initialize(OCNaroWrappers::OCTDF_IDMap^ aMap) ;


 /*instead*/  OCStandard_GUID^ Key() ;

~OCTDF_MapIteratorOfIDMap()
{
  delete nativeHandle;
}

};

}; // OCNaroWrappers

#endif
