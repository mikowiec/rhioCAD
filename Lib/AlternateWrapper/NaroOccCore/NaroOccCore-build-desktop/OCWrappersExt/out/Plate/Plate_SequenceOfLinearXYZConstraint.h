// File generated by CPPExt (MPV)
//
#ifndef _Plate_SequenceOfLinearXYZConstraint_OCWrappers_HeaderFile
#define _Plate_SequenceOfLinearXYZConstraint_OCWrappers_HeaderFile

// include native header
#include <Plate_SequenceOfLinearXYZConstraint.hxx>
#include "../Converter.h"

#include "../TCollection/TCollection_BaseSequence.h"

#include "../TCollection/TCollection_BaseSequence.h"


namespace OCNaroWrappers
{

ref class OCPlate_LinearXYZConstraint;
ref class OCPlate_SequenceNodeOfSequenceOfLinearXYZConstraint;



public ref class OCPlate_SequenceOfLinearXYZConstraint  : public OCTCollection_BaseSequence {

protected:
  // dummy constructor;
  OCPlate_SequenceOfLinearXYZConstraint(OCDummy^) : OCTCollection_BaseSequence((OCDummy^)nullptr) {};

public:

// constructor from native
OCPlate_SequenceOfLinearXYZConstraint(Plate_SequenceOfLinearXYZConstraint* nativeHandle);

// Methods PUBLIC


OCPlate_SequenceOfLinearXYZConstraint();


 /*instead*/  OCPlate_SequenceOfLinearXYZConstraint^ Assign(OCNaroWrappers::OCPlate_SequenceOfLinearXYZConstraint^ Other) ;


 /*instead*/  void Append(OCNaroWrappers::OCPlate_LinearXYZConstraint^ T) ;


 /*instead*/  void Append(OCNaroWrappers::OCPlate_SequenceOfLinearXYZConstraint^ S) ;


 /*instead*/  void Prepend(OCNaroWrappers::OCPlate_LinearXYZConstraint^ T) ;


 /*instead*/  void Prepend(OCNaroWrappers::OCPlate_SequenceOfLinearXYZConstraint^ S) ;


 /*instead*/  void InsertBefore(Standard_Integer Index, OCNaroWrappers::OCPlate_LinearXYZConstraint^ T) ;


 /*instead*/  void InsertBefore(Standard_Integer Index, OCNaroWrappers::OCPlate_SequenceOfLinearXYZConstraint^ S) ;


 /*instead*/  void InsertAfter(Standard_Integer Index, OCNaroWrappers::OCPlate_LinearXYZConstraint^ T) ;


 /*instead*/  void InsertAfter(Standard_Integer Index, OCNaroWrappers::OCPlate_SequenceOfLinearXYZConstraint^ S) ;


 /*instead*/  OCPlate_LinearXYZConstraint^ First() ;


 /*instead*/  OCPlate_LinearXYZConstraint^ Last() ;


 /*instead*/  void Split(Standard_Integer Index, OCNaroWrappers::OCPlate_SequenceOfLinearXYZConstraint^ Sub) ;


 /*instead*/  OCPlate_LinearXYZConstraint^ Value(Standard_Integer Index) ;


 /*instead*/  void SetValue(Standard_Integer Index, OCNaroWrappers::OCPlate_LinearXYZConstraint^ I) ;


 /*instead*/  OCPlate_LinearXYZConstraint^ ChangeValue(Standard_Integer Index) ;


 /*instead*/  void Remove(Standard_Integer Index) ;


 /*instead*/  void Remove(Standard_Integer FromIndex, Standard_Integer ToIndex) ;

~OCPlate_SequenceOfLinearXYZConstraint()
{
  delete nativeHandle;
}

};

}; // OCNaroWrappers

#endif