// File generated by CPPExt (MPV)
//
#ifndef _Visual3d_ListIteratorOfSetListOfSetOfClipPlane_OCWrappers_HeaderFile
#define _Visual3d_ListIteratorOfSetListOfSetOfClipPlane_OCWrappers_HeaderFile

// include native header
#include <Visual3d_ListIteratorOfSetListOfSetOfClipPlane.hxx>
#include "../Converter.h"




namespace OCNaroWrappers
{

ref class OCVisual3d_SetListOfSetOfClipPlane;
ref class OCVisual3d_ClipPlane;
ref class OCVisual3d_ListNodeOfSetListOfSetOfClipPlane;



public ref class OCVisual3d_ListIteratorOfSetListOfSetOfClipPlane  {

protected:
  Visual3d_ListIteratorOfSetListOfSetOfClipPlane* nativeHandle;
  OCVisual3d_ListIteratorOfSetListOfSetOfClipPlane(OCDummy^) {};

public:
  property Visual3d_ListIteratorOfSetListOfSetOfClipPlane* Handle
  {
    Visual3d_ListIteratorOfSetListOfSetOfClipPlane* get()
    {
      return nativeHandle;
    }
  }


// constructor from native
OCVisual3d_ListIteratorOfSetListOfSetOfClipPlane(Visual3d_ListIteratorOfSetListOfSetOfClipPlane* nativeHandle);

// Methods PUBLIC


OCVisual3d_ListIteratorOfSetListOfSetOfClipPlane();


OCVisual3d_ListIteratorOfSetListOfSetOfClipPlane(OCNaroWrappers::OCVisual3d_SetListOfSetOfClipPlane^ L);


 /*instead*/  void Initialize(OCNaroWrappers::OCVisual3d_SetListOfSetOfClipPlane^ L) ;


 /*instead*/  System::Boolean More() ;


 /*instead*/  void Next() ;


 /*instead*/  OCVisual3d_ClipPlane^ Value() ;

~OCVisual3d_ListIteratorOfSetListOfSetOfClipPlane()
{
  delete nativeHandle;
}

};

}; // OCNaroWrappers

#endif
