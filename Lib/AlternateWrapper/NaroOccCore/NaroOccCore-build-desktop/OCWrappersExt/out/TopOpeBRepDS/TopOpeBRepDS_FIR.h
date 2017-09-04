// File generated by CPPExt (MPV)
//
#ifndef _TopOpeBRepDS_FIR_OCWrappers_HeaderFile
#define _TopOpeBRepDS_FIR_OCWrappers_HeaderFile

// include native header
#include <TopOpeBRepDS_FIR.hxx>
#include "../Converter.h"




namespace OCNaroWrappers
{

ref class OCTopOpeBRepDS_HDataStructure;
ref class OCTopOpeBRepDS_DataMapOfShapeListOfShapeOn1State;


//! FaceInterferenceReducer <br>
public ref class OCTopOpeBRepDS_FIR  {

protected:
  TopOpeBRepDS_FIR* nativeHandle;
  OCTopOpeBRepDS_FIR(OCDummy^) {};

public:
  property TopOpeBRepDS_FIR* Handle
  {
    TopOpeBRepDS_FIR* get()
    {
      return nativeHandle;
    }
  }


// constructor from native
OCTopOpeBRepDS_FIR(TopOpeBRepDS_FIR* nativeHandle);

// Methods PUBLIC


OCTopOpeBRepDS_FIR(OCNaroWrappers::OCTopOpeBRepDS_HDataStructure^ HDS);


 /*instead*/  void ProcessFaceInterferences(OCNaroWrappers::OCTopOpeBRepDS_DataMapOfShapeListOfShapeOn1State^ M) ;


 /*instead*/  void ProcessFaceInterferences(Standard_Integer I, OCNaroWrappers::OCTopOpeBRepDS_DataMapOfShapeListOfShapeOn1State^ M) ;

~OCTopOpeBRepDS_FIR()
{
  delete nativeHandle;
}

};

}; // OCNaroWrappers

#endif