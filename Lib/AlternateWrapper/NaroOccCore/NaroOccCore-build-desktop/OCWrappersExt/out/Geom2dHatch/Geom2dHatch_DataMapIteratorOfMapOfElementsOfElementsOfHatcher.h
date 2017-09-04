// File generated by CPPExt (MPV)
//
#ifndef _Geom2dHatch_DataMapIteratorOfMapOfElementsOfElementsOfHatcher_OCWrappers_HeaderFile
#define _Geom2dHatch_DataMapIteratorOfMapOfElementsOfElementsOfHatcher_OCWrappers_HeaderFile

// include native header
#include <Geom2dHatch_DataMapIteratorOfMapOfElementsOfElementsOfHatcher.hxx>
#include "../Converter.h"

#include "../TCollection/TCollection_BasicMapIterator.h"

#include "../TCollection/TCollection_BasicMapIterator.h"


namespace OCNaroWrappers
{

ref class OCGeom2dHatch_ElementOfHatcher;
ref class OCTColStd_MapIntegerHasher;
ref class OCGeom2dHatch_MapOfElementsOfElementsOfHatcher;
ref class OCGeom2dHatch_DataMapNodeOfMapOfElementsOfElementsOfHatcher;



public ref class OCGeom2dHatch_DataMapIteratorOfMapOfElementsOfElementsOfHatcher  : public OCTCollection_BasicMapIterator {

protected:
  // dummy constructor;
  OCGeom2dHatch_DataMapIteratorOfMapOfElementsOfElementsOfHatcher(OCDummy^) : OCTCollection_BasicMapIterator((OCDummy^)nullptr) {};

public:

// constructor from native
OCGeom2dHatch_DataMapIteratorOfMapOfElementsOfElementsOfHatcher(Geom2dHatch_DataMapIteratorOfMapOfElementsOfElementsOfHatcher* nativeHandle);

// Methods PUBLIC


OCGeom2dHatch_DataMapIteratorOfMapOfElementsOfElementsOfHatcher();


OCGeom2dHatch_DataMapIteratorOfMapOfElementsOfElementsOfHatcher(OCNaroWrappers::OCGeom2dHatch_MapOfElementsOfElementsOfHatcher^ aMap);


 /*instead*/  void Initialize(OCNaroWrappers::OCGeom2dHatch_MapOfElementsOfElementsOfHatcher^ aMap) ;


 /*instead*/  Standard_Integer Key() ;


 /*instead*/  OCGeom2dHatch_ElementOfHatcher^ Value() ;

~OCGeom2dHatch_DataMapIteratorOfMapOfElementsOfElementsOfHatcher()
{
  delete nativeHandle;
}

};

}; // OCNaroWrappers

#endif
