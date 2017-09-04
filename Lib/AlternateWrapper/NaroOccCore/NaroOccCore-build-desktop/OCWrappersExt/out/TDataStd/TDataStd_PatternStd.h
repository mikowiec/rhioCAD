// File generated by CPPExt (Transient)
//
#ifndef _TDataStd_PatternStd_OCWrappers_HeaderFile
#define _TDataStd_PatternStd_OCWrappers_HeaderFile

// include the wrapped class
#include <TDataStd_PatternStd.hxx>
#include "../Converter.h"

#include "TDataStd_Pattern.h"



namespace OCNaroWrappers
{

ref class OCTNaming_NamedShape;
ref class OCTDataStd_Real;
ref class OCTDataStd_Integer;
ref class OCStandard_GUID;
ref class OCTDF_Label;
ref class OCTDataStd_Array1OfTrsf;
ref class OCTDF_Attribute;
ref class OCTDF_RelocationTable;
ref class OCTDF_DataSet;


//! to create a PatternStd <br>
public ref class OCTDataStd_PatternStd : OCTDataStd_Pattern {

protected:
  // dummy constructor;
  OCTDataStd_PatternStd(OCDummy^) : OCTDataStd_Pattern((OCDummy^)nullptr) {};

public:

// constructor from native
OCTDataStd_PatternStd(Handle(TDataStd_PatternStd)* nativeHandle);

// Methods PUBLIC


static /*instead*/  OCStandard_GUID^ GetPatternID() ;

//! Find, or  create,  a PatternStd  attribute <br>
static /*instead*/  OCTDataStd_PatternStd^ Set(OCNaroWrappers::OCTDF_Label^ label) ;


OCTDataStd_PatternStd();


 /*instead*/  void Signature(Standard_Integer signature) ;


 /*instead*/  void Axis1(OCNaroWrappers::OCTNaming_NamedShape^ Axis1) ;


 /*instead*/  void Axis2(OCNaroWrappers::OCTNaming_NamedShape^ Axis2) ;


 /*instead*/  void Axis1Reversed(System::Boolean Axis1Reversed) ;


 /*instead*/  void Axis2Reversed(System::Boolean Axis2Reversed) ;


 /*instead*/  void Value1(OCNaroWrappers::OCTDataStd_Real^ value) ;


 /*instead*/  void Value2(OCNaroWrappers::OCTDataStd_Real^ value) ;


 /*instead*/  void NbInstances1(OCNaroWrappers::OCTDataStd_Integer^ NbInstances1) ;


 /*instead*/  void NbInstances2(OCNaroWrappers::OCTDataStd_Integer^ NbInstances2) ;


 /*instead*/  void Mirror(OCNaroWrappers::OCTNaming_NamedShape^ plane) ;


 /*instead*/  Standard_Integer Signature() ;


 /*instead*/  OCTNaming_NamedShape^ Axis1() ;


 /*instead*/  OCTNaming_NamedShape^ Axis2() ;


 /*instead*/  System::Boolean Axis1Reversed() ;


 /*instead*/  System::Boolean Axis2Reversed() ;


 /*instead*/  OCTDataStd_Real^ Value1() ;


 /*instead*/  OCTDataStd_Real^ Value2() ;


 /*instead*/  OCTDataStd_Integer^ NbInstances1() ;


 /*instead*/  OCTDataStd_Integer^ NbInstances2() ;


 /*instead*/  OCTNaming_NamedShape^ Mirror() ;


 /*instead*/  Standard_Integer NbTrsfs() ;


 /*instead*/  void ComputeTrsfs(OCNaroWrappers::OCTDataStd_Array1OfTrsf^ Trsfs) ;


 /*instead*/  OCStandard_GUID^ PatternID() ;


 /*instead*/  void Restore(OCNaroWrappers::OCTDF_Attribute^ With) ;


 /*instead*/  OCTDF_Attribute^ NewEmpty() ;


 /*instead*/  void Paste(OCNaroWrappers::OCTDF_Attribute^ Into, OCNaroWrappers::OCTDF_RelocationTable^ RT) ;


virtual /*instead*/  void References(OCNaroWrappers::OCTDF_DataSet^ aDataSet) override;


virtual /*instead*/  Standard_OStream& Dump(Standard_OStream& anOS) override;

~OCTDataStd_PatternStd()
{
  nativeHandle->Nullify();
  delete nativeHandle;
}

};

}; // OCNaroWrappers

#endif
