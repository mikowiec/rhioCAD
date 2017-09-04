// File generated by CPPExt (MPV)
//
#ifndef _TColgp_Array2OfDir_OCWrappers_HeaderFile
#define _TColgp_Array2OfDir_OCWrappers_HeaderFile

// include native header
#include <TColgp_Array2OfDir.hxx>
#include "../Converter.h"




namespace OCNaroWrappers
{

ref class OCgp_Dir;



public ref class OCTColgp_Array2OfDir  {

protected:
  TColgp_Array2OfDir* nativeHandle;
  OCTColgp_Array2OfDir(OCDummy^) {};

public:
  property TColgp_Array2OfDir* Handle
  {
    TColgp_Array2OfDir* get()
    {
      return nativeHandle;
    }
  }


// constructor from native
OCTColgp_Array2OfDir(TColgp_Array2OfDir* nativeHandle);

// Methods PUBLIC


OCTColgp_Array2OfDir(Standard_Integer R1, Standard_Integer R2, Standard_Integer C1, Standard_Integer C2);


OCTColgp_Array2OfDir(OCNaroWrappers::OCgp_Dir^ Item, Standard_Integer R1, Standard_Integer R2, Standard_Integer C1, Standard_Integer C2);


 /*instead*/  void Init(OCNaroWrappers::OCgp_Dir^ V) ;


 /*instead*/  OCTColgp_Array2OfDir^ Assign(OCNaroWrappers::OCTColgp_Array2OfDir^ Other) ;


 /*instead*/  Standard_Integer ColLength() ;


 /*instead*/  Standard_Integer RowLength() ;


 /*instead*/  Standard_Integer LowerCol() ;


 /*instead*/  Standard_Integer LowerRow() ;


 /*instead*/  Standard_Integer UpperCol() ;


 /*instead*/  Standard_Integer UpperRow() ;


 /*instead*/  void SetValue(Standard_Integer Row, Standard_Integer Col, OCNaroWrappers::OCgp_Dir^ Value) ;


 /*instead*/  OCgp_Dir^ Value(Standard_Integer Row, Standard_Integer Col) ;


 /*instead*/  OCgp_Dir^ ChangeValue(Standard_Integer Row, Standard_Integer Col) ;

~OCTColgp_Array2OfDir()
{
  delete nativeHandle;
}

};

}; // OCNaroWrappers

#endif
