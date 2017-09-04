// File generated by CPPExt (MPV)
//
#ifndef _TopOpeBRepDS_DataMapOfShapeState_OCWrappers_HeaderFile
#define _TopOpeBRepDS_DataMapOfShapeState_OCWrappers_HeaderFile

// include native header
#include <TopOpeBRepDS_DataMapOfShapeState.hxx>
#include "../Converter.h"

#include "../TCollection/TCollection_BasicMap.h"

#include "../TCollection/TCollection_BasicMap.h"
#include "../TopAbs/TopAbs_State.h"


namespace OCNaroWrappers
{

ref class OCTopoDS_Shape;
ref class OCTopTools_ShapeMapHasher;
ref class OCTopOpeBRepDS_DataMapNodeOfDataMapOfShapeState;
ref class OCTopOpeBRepDS_DataMapIteratorOfDataMapOfShapeState;



public ref class OCTopOpeBRepDS_DataMapOfShapeState  : public OCTCollection_BasicMap {

protected:
  // dummy constructor;
  OCTopOpeBRepDS_DataMapOfShapeState(OCDummy^) : OCTCollection_BasicMap((OCDummy^)nullptr) {};

public:

// constructor from native
OCTopOpeBRepDS_DataMapOfShapeState(TopOpeBRepDS_DataMapOfShapeState* nativeHandle);

// Methods PUBLIC


OCTopOpeBRepDS_DataMapOfShapeState(Standard_Integer NbBuckets);


 /*instead*/  OCTopOpeBRepDS_DataMapOfShapeState^ Assign(OCNaroWrappers::OCTopOpeBRepDS_DataMapOfShapeState^ Other) ;


 /*instead*/  void ReSize(Standard_Integer NbBuckets) ;


 /*instead*/  System::Boolean Bind(OCNaroWrappers::OCTopoDS_Shape^ K, OCTopAbs_State I) ;


 /*instead*/  System::Boolean IsBound(OCNaroWrappers::OCTopoDS_Shape^ K) ;


 /*instead*/  System::Boolean UnBind(OCNaroWrappers::OCTopoDS_Shape^ K) ;


 /*instead*/  OCTopAbs_State Find(OCNaroWrappers::OCTopoDS_Shape^ K) ;


 /*instead*/  OCTopAbs_State ChangeFind(OCNaroWrappers::OCTopoDS_Shape^ K) ;


 /*instead*/  Standard_Address Find1(OCNaroWrappers::OCTopoDS_Shape^ K) ;


 /*instead*/  Standard_Address ChangeFind1(OCNaroWrappers::OCTopoDS_Shape^ K) ;

~OCTopOpeBRepDS_DataMapOfShapeState()
{
  delete nativeHandle;
}

};

}; // OCNaroWrappers

#endif
