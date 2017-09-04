// File generated by CPPExt (Transient)
//
#ifndef _TDataStd_RealArray_OCWrappers_HeaderFile
#define _TDataStd_RealArray_OCWrappers_HeaderFile

// include the wrapped class
#include <TDataStd_RealArray.hxx>
#include "../Converter.h"

#include "../TDF/TDF_Attribute.h"



namespace OCNaroWrappers
{

ref class OCTColStd_HArray1OfReal;
ref class OCTDataStd_DeltaOnModificationOfRealArray;
ref class OCStandard_GUID;
ref class OCTDF_Label;
ref class OCTDF_Attribute;
ref class OCTDF_RelocationTable;
ref class OCTDF_DeltaOnModification;


//! A framework for an attribute composed of a real number array. <br>
public ref class OCTDataStd_RealArray : OCTDF_Attribute {

protected:
  // dummy constructor;
  OCTDataStd_RealArray(OCDummy^) : OCTDF_Attribute((OCDummy^)nullptr) {};

public:

// constructor from native
OCTDataStd_RealArray(Handle(TDataStd_RealArray)* nativeHandle);

// Methods PUBLIC

//! class methods <br>
//!          ============= <br>//! Returns the GUID for arrays of reals. <br>
static /*instead*/  OCStandard_GUID^ GetID() ;

//! Finds or creates on the <label> a real array attribute <br>
//! with the specified <lower> and <upper> boundaries. <br>
//! If attribute is already set, all input parameters are refused and the found <br>
//! attribute is returned. <br>
static /*instead*/  OCTDataStd_RealArray^ Set(OCNaroWrappers::OCTDF_Label^ label, Standard_Integer lower, Standard_Integer upper, System::Boolean isDelta) ;

//! Initialize the inner array with bounds from <lower> to <upper> <br>
 /*instead*/  void Init(Standard_Integer lower, Standard_Integer upper) ;

//! Sets  the   <Index>th  element  of   the  array to <Value> <br>
 /*instead*/  void SetValue(Standard_Integer Index, Standard_Real Value) ;

//! Return the value of  the  <Index>th element of the array <br>
 /*instead*/  Standard_Real Value(Standard_Integer Index) ;

//!  Returns the lower boundary of the array. <br>
 /*instead*/  Standard_Integer Lower() ;

//! Returns the upper boundary of the array. <br>
 /*instead*/  Standard_Integer Upper() ;

//! Returns the number of elements of the array of reals <br>
//!    in terms of the number of elements it contains. <br>
 /*instead*/  Standard_Integer Length() ;

//! Sets the inner array <myValue> of the RealArray attribute <br>
//! to <newArray>. If value of <newArray> differs from <myValue>, <br>
//! Backup performed and myValue refers to new instance of HArray1OfReal <br>
//! that holds <newArray> values <br>
//! If <isCheckItems> equal True each item of <newArray> will be checked with each <br>
//! item of <myValue> for coincidence (to avoid backup). <br>
 /*instead*/  void ChangeArray(OCNaroWrappers::OCTColStd_HArray1OfReal^ newArray, System::Boolean isCheckItems) ;

//! Returns the handle of this array of reals. <br>
 /*instead*/  OCTColStd_HArray1OfReal^ Array() ;


 /*instead*/  System::Boolean GetDelta() ;

//! for  internal  use  only! <br>
 /*instead*/  void SetDelta(System::Boolean isDelta) ;


OCTDataStd_RealArray();


 /*instead*/  OCStandard_GUID^ ID() ;


 /*instead*/  void Restore(OCNaroWrappers::OCTDF_Attribute^ With) ;


 /*instead*/  OCTDF_Attribute^ NewEmpty() ;

//! Note. Uses inside ChangeArray() method <br>
 /*instead*/  void Paste(OCNaroWrappers::OCTDF_Attribute^ Into, OCNaroWrappers::OCTDF_RelocationTable^ RT) ;


virtual /*instead*/  Standard_OStream& Dump(Standard_OStream& anOS) override;

//! Makes a DeltaOnModification between <me> and <br>
//!         <anOldAttribute>. <br>
virtual /*instead*/  OCTDF_DeltaOnModification^ DeltaOnModification(OCNaroWrappers::OCTDF_Attribute^ anOldAttribute) override;

~OCTDataStd_RealArray()
{
  nativeHandle->Nullify();
  delete nativeHandle;
}

};

}; // OCNaroWrappers

#endif