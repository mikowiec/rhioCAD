// File generated by CPPExt (MPV)
//
#ifndef _TopOpeBRepTool_DataMapOfOrientedShapeC2DF_OCWrappers_HeaderFile
#define _TopOpeBRepTool_DataMapOfOrientedShapeC2DF_OCWrappers_HeaderFile

// include native header
#include <TopOpeBRepTool_DataMapOfOrientedShapeC2DF.hxx>
#include "../Converter.h"

#include "../TCollection/TCollection_BasicMap.h"

#include "../TCollection/TCollection_BasicMap.h"


namespace OCNaroWrappers
{

ref class OCTopoDS_Shape;
ref class OCTopOpeBRepTool_C2DF;
ref class OCTopTools_OrientedShapeMapHasher;
ref class OCTopOpeBRepTool_DataMapNodeOfDataMapOfOrientedShapeC2DF;
ref class OCTopOpeBRepTool_DataMapIteratorOfDataMapOfOrientedShapeC2DF;



public ref class OCTopOpeBRepTool_DataMapOfOrientedShapeC2DF  : public OCTCollection_BasicMap {

protected:
  // dummy constructor;
  OCTopOpeBRepTool_DataMapOfOrientedShapeC2DF(OCDummy^) : OCTCollection_BasicMap((OCDummy^)nullptr) {};

public:

// constructor from native
OCTopOpeBRepTool_DataMapOfOrientedShapeC2DF(TopOpeBRepTool_DataMapOfOrientedShapeC2DF* nativeHandle);

// Methods PUBLIC


OCTopOpeBRepTool_DataMapOfOrientedShapeC2DF(Standard_Integer NbBuckets);


 /*instead*/  OCTopOpeBRepTool_DataMapOfOrientedShapeC2DF^ Assign(OCNaroWrappers::OCTopOpeBRepTool_DataMapOfOrientedShapeC2DF^ Other) ;


 /*instead*/  void ReSize(Standard_Integer NbBuckets) ;


 /*instead*/  System::Boolean Bind(OCNaroWrappers::OCTopoDS_Shape^ K, OCNaroWrappers::OCTopOpeBRepTool_C2DF^ I) ;


 /*instead*/  System::Boolean IsBound(OCNaroWrappers::OCTopoDS_Shape^ K) ;


 /*instead*/  System::Boolean UnBind(OCNaroWrappers::OCTopoDS_Shape^ K) ;


 /*instead*/  OCTopOpeBRepTool_C2DF^ Find(OCNaroWrappers::OCTopoDS_Shape^ K) ;


 /*instead*/  OCTopOpeBRepTool_C2DF^ ChangeFind(OCNaroWrappers::OCTopoDS_Shape^ K) ;


 /*instead*/  Standard_Address Find1(OCNaroWrappers::OCTopoDS_Shape^ K) ;


 /*instead*/  Standard_Address ChangeFind1(OCNaroWrappers::OCTopoDS_Shape^ K) ;

~OCTopOpeBRepTool_DataMapOfOrientedShapeC2DF()
{
  delete nativeHandle;
}

};

}; // OCNaroWrappers

#endif
