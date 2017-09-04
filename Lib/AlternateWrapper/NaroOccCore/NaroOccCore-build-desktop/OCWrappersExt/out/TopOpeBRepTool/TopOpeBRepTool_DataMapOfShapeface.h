// File generated by CPPExt (MPV)
//
#ifndef _TopOpeBRepTool_DataMapOfShapeface_OCWrappers_HeaderFile
#define _TopOpeBRepTool_DataMapOfShapeface_OCWrappers_HeaderFile

// include native header
#include <TopOpeBRepTool_DataMapOfShapeface.hxx>
#include "../Converter.h"

#include "../TCollection/TCollection_BasicMap.h"

#include "../TCollection/TCollection_BasicMap.h"


namespace OCNaroWrappers
{

ref class OCTopoDS_Shape;
ref class OCTopOpeBRepTool_face;
ref class OCTopTools_ShapeMapHasher;
ref class OCTopOpeBRepTool_DataMapNodeOfDataMapOfShapeface;
ref class OCTopOpeBRepTool_DataMapIteratorOfDataMapOfShapeface;



public ref class OCTopOpeBRepTool_DataMapOfShapeface  : public OCTCollection_BasicMap {

protected:
  // dummy constructor;
  OCTopOpeBRepTool_DataMapOfShapeface(OCDummy^) : OCTCollection_BasicMap((OCDummy^)nullptr) {};

public:

// constructor from native
OCTopOpeBRepTool_DataMapOfShapeface(TopOpeBRepTool_DataMapOfShapeface* nativeHandle);

// Methods PUBLIC


OCTopOpeBRepTool_DataMapOfShapeface(Standard_Integer NbBuckets);


 /*instead*/  OCTopOpeBRepTool_DataMapOfShapeface^ Assign(OCNaroWrappers::OCTopOpeBRepTool_DataMapOfShapeface^ Other) ;


 /*instead*/  void ReSize(Standard_Integer NbBuckets) ;


 /*instead*/  System::Boolean Bind(OCNaroWrappers::OCTopoDS_Shape^ K, OCNaroWrappers::OCTopOpeBRepTool_face^ I) ;


 /*instead*/  System::Boolean IsBound(OCNaroWrappers::OCTopoDS_Shape^ K) ;


 /*instead*/  System::Boolean UnBind(OCNaroWrappers::OCTopoDS_Shape^ K) ;


 /*instead*/  OCTopOpeBRepTool_face^ Find(OCNaroWrappers::OCTopoDS_Shape^ K) ;


 /*instead*/  OCTopOpeBRepTool_face^ ChangeFind(OCNaroWrappers::OCTopoDS_Shape^ K) ;


 /*instead*/  Standard_Address Find1(OCNaroWrappers::OCTopoDS_Shape^ K) ;


 /*instead*/  Standard_Address ChangeFind1(OCNaroWrappers::OCTopoDS_Shape^ K) ;

~OCTopOpeBRepTool_DataMapOfShapeface()
{
  delete nativeHandle;
}

};

}; // OCNaroWrappers

#endif
