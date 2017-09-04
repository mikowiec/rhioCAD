// File generated by CPPExt (MPV)
//
#ifndef _Visual3d_ListIteratorOfSetListOfSetOfLight_OCWrappers_HeaderFile
#define _Visual3d_ListIteratorOfSetListOfSetOfLight_OCWrappers_HeaderFile

// include native header
#include <Visual3d_ListIteratorOfSetListOfSetOfLight.hxx>
#include "../Converter.h"




namespace OCNaroWrappers
{

ref class OCVisual3d_SetListOfSetOfLight;
ref class OCVisual3d_Light;
ref class OCVisual3d_ListNodeOfSetListOfSetOfLight;



public ref class OCVisual3d_ListIteratorOfSetListOfSetOfLight  {

protected:
  Visual3d_ListIteratorOfSetListOfSetOfLight* nativeHandle;
  OCVisual3d_ListIteratorOfSetListOfSetOfLight(OCDummy^) {};

public:
  property Visual3d_ListIteratorOfSetListOfSetOfLight* Handle
  {
    Visual3d_ListIteratorOfSetListOfSetOfLight* get()
    {
      return nativeHandle;
    }
  }


// constructor from native
OCVisual3d_ListIteratorOfSetListOfSetOfLight(Visual3d_ListIteratorOfSetListOfSetOfLight* nativeHandle);

// Methods PUBLIC


OCVisual3d_ListIteratorOfSetListOfSetOfLight();


OCVisual3d_ListIteratorOfSetListOfSetOfLight(OCNaroWrappers::OCVisual3d_SetListOfSetOfLight^ L);


 /*instead*/  void Initialize(OCNaroWrappers::OCVisual3d_SetListOfSetOfLight^ L) ;


 /*instead*/  System::Boolean More() ;


 /*instead*/  void Next() ;


 /*instead*/  OCVisual3d_Light^ Value() ;

~OCVisual3d_ListIteratorOfSetListOfSetOfLight()
{
  delete nativeHandle;
}

};

}; // OCNaroWrappers

#endif
