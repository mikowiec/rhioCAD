// File generated by CPPExt (Transient)
//
#ifndef _TDataStd_NamedData_OCWrappers_HeaderFile
#define _TDataStd_NamedData_OCWrappers_HeaderFile

// include the wrapped class
#include <TDataStd_NamedData.hxx>
#include "../Converter.h"

#include "../TDF/TDF_Attribute.h"



namespace OCNaroWrappers
{

ref class OCTDataStd_HDataMapOfStringInteger;
ref class OCTDataStd_HDataMapOfStringReal;
ref class OCTDataStd_HDataMapOfStringString;
ref class OCTDataStd_HDataMapOfStringByte;
ref class OCTDataStd_HDataMapOfStringHArray1OfInteger;
ref class OCTDataStd_HDataMapOfStringHArray1OfReal;
ref class OCStandard_GUID;
ref class OCTDF_Label;
ref class OCTCollection_ExtendedString;
ref class OCTColStd_DataMapOfStringInteger;
ref class OCTDataStd_DataMapOfStringReal;
ref class OCTDataStd_DataMapOfStringString;
ref class OCTDataStd_DataMapOfStringByte;
ref class OCTColStd_HArray1OfInteger;
ref class OCTDataStd_DataMapOfStringHArray1OfInteger;
ref class OCTColStd_HArray1OfReal;
ref class OCTDataStd_DataMapOfStringHArray1OfReal;
ref class OCTDF_Attribute;
ref class OCTDF_RelocationTable;


//! Contains a named data. <br>
public ref class OCTDataStd_NamedData : OCTDF_Attribute {

protected:
  // dummy constructor;
  OCTDataStd_NamedData(OCDummy^) : OCTDF_Attribute((OCDummy^)nullptr) {};

public:

// constructor from native
OCTDataStd_NamedData(Handle(TDataStd_NamedData)* nativeHandle);

// Methods PUBLIC

//! Static methods <br>
//!          ============== <br>//! Returns the ID of the named data attribute. <br>
static /*instead*/  OCStandard_GUID^ GetID() ;

//! Finds or creates a named data attribute. <br>
static /*instead*/  OCTDataStd_NamedData^ Set(OCNaroWrappers::OCTDF_Label^ label) ;


OCTDataStd_NamedData();

//! Returns true if at least one named integer value is <br>
//!          kept in the attribute. <br>
 /*instead*/  System::Boolean HasIntegers() ;

//! Returns true if the attribute contains specified by Name <br>
//!          integer value. <br>
 /*instead*/  System::Boolean HasInteger(OCNaroWrappers::OCTCollection_ExtendedString^ theName) ;

//! Returns the integer value specified by the Name. <br>
//!          It returns 0 if internal map doesn't contain the specified <br>
//!          integer (use HasInteger() to check before). <br>
 /*instead*/  Standard_Integer GetInteger(OCNaroWrappers::OCTCollection_ExtendedString^ theName) ;

//! Defines a named integer. <br>
//!          If the integer already exists, it changes its value to <theInteger>. <br>
 /*instead*/  void SetInteger(OCNaroWrappers::OCTCollection_ExtendedString^ theName, Standard_Integer theInteger) ;

//! Returns the internal container of named integers. <br>
 /*instead*/  OCTColStd_DataMapOfStringInteger^ GetIntegersContainer() ;

//! Replace the container content by new content of the <theIntegers>. <br>
 /*instead*/  void ChangeIntegers(OCNaroWrappers::OCTColStd_DataMapOfStringInteger^ theIntegers) ;

//! Returns true if at least one named real value is <br>
//!          kept in the attribute. <br>
 /*instead*/  System::Boolean HasReals() ;

//! Returns true if the attribute contains a real specified by Name. <br>
 /*instead*/  System::Boolean HasReal(OCNaroWrappers::OCTCollection_ExtendedString^ theName) ;

//! Returns the named real. <br>
//!          It returns 0.0 if there is no such a named real <br>
//!          (use HasReal()). <br>
 /*instead*/  Standard_Real GetReal(OCNaroWrappers::OCTCollection_ExtendedString^ theName) ;

//! Defines a named real. <br>
//!          If the real already exists, it changes its value to <theReal>. <br>
 /*instead*/  void SetReal(OCNaroWrappers::OCTCollection_ExtendedString^ theName, Standard_Real theReal) ;

//! Returns the internal container of named reals. <br>
 /*instead*/  OCTDataStd_DataMapOfStringReal^ GetRealsContainer() ;

//! Replace the container content by new content of the <theReals>. <br>
 /*instead*/  void ChangeReals(OCNaroWrappers::OCTDataStd_DataMapOfStringReal^ theReals) ;

//! Returns true if there are some named strings in the attribute. <br>
 /*instead*/  System::Boolean HasStrings() ;

//! Returns true if the attribute contains this named string. <br>
 /*instead*/  System::Boolean HasString(OCNaroWrappers::OCTCollection_ExtendedString^ theName) ;

//! Returns the named string. <br>
//!          It returns an empty string if there is no such a named string <br>
//!          (use HasString()). <br>
 /*instead*/  OCTCollection_ExtendedString^ GetString(OCNaroWrappers::OCTCollection_ExtendedString^ theName) ;

//! Defines a named string. <br>
//!          If the string already exists, it changes its value to <theString>. <br>
 /*instead*/  void SetString(OCNaroWrappers::OCTCollection_ExtendedString^ theName, OCNaroWrappers::OCTCollection_ExtendedString^ theString) ;

//! Returns the internal container of named strings. <br>
 /*instead*/  OCTDataStd_DataMapOfStringString^ GetStringsContainer() ;

//! Replace the container content by new content of the <theStrings>. <br>
 /*instead*/  void ChangeStrings(OCNaroWrappers::OCTDataStd_DataMapOfStringString^ theStrings) ;

//! Returns true if there are some named bytes in the attribute. <br>
 /*instead*/  System::Boolean HasBytes() ;

//! Returns true if the attribute contains this named byte. <br>
 /*instead*/  System::Boolean HasByte(OCNaroWrappers::OCTCollection_ExtendedString^ theName) ;

//! Returns the named byte. <br>
//!          It returns 0 if there is no such a named byte <br>
//!          (use HasByte()). <br>
 /*instead*/  Standard_Byte GetByte(OCNaroWrappers::OCTCollection_ExtendedString^ theName) ;

//! Defines a named byte. <br>
//!          If the byte already exists, it changes its value to <theByte>. <br>
 /*instead*/  void SetByte(OCNaroWrappers::OCTCollection_ExtendedString^ theName, Standard_Byte theByte) ;

//! Returns the internal container of named bytes. <br>
 /*instead*/  OCTDataStd_DataMapOfStringByte^ GetBytesContainer() ;

//! Replace the container content by new content of the <theBytes>. <br>
 /*instead*/  void ChangeBytes(OCNaroWrappers::OCTDataStd_DataMapOfStringByte^ theBytes) ;

//! Returns true if there are some named arrays of integer values in the attribute. <br>
 /*instead*/  System::Boolean HasArraysOfIntegers() ;

//! Returns true if the attribute contains this named array of integer values. <br>
 /*instead*/  System::Boolean HasArrayOfIntegers(OCNaroWrappers::OCTCollection_ExtendedString^ theName) ;

//! Returns the named array of integer values. <br>
//!          It returns a NULL Handle if there is no such a named array of integers <br>
//!          (use HasArrayOfIntegers()). <br>
 /*instead*/  OCTColStd_HArray1OfInteger^ GetArrayOfIntegers(OCNaroWrappers::OCTCollection_ExtendedString^ theName) ;

//! Defines a named array of integer values. <br>
//!          If the array already exists, it changes its value to <theArrayOfIntegers>. <br>
 /*instead*/  void SetArrayOfIntegers(OCNaroWrappers::OCTCollection_ExtendedString^ theName, OCNaroWrappers::OCTColStd_HArray1OfInteger^ theArrayOfIntegers) ;

//! Returns the internal container of named arrays of integer values. <br>
 /*instead*/  OCTDataStd_DataMapOfStringHArray1OfInteger^ GetArraysOfIntegersContainer() ;

//! Replace the container content by new content of the <theArraysOfIntegers>. <br>
 /*instead*/  void ChangeArraysOfIntegers(OCNaroWrappers::OCTDataStd_DataMapOfStringHArray1OfInteger^ theArraysOfIntegers) ;

//! Returns true if there are some named arrays of real values in the attribute. <br>
 /*instead*/  System::Boolean HasArraysOfReals() ;

//! Returns true if the attribute contains this named array of real values. <br>
 /*instead*/  System::Boolean HasArrayOfReals(OCNaroWrappers::OCTCollection_ExtendedString^ theName) ;

//! Returns the named array of real values. <br>
//!          It returns a NULL Handle if there is no such a named array of reals <br>
//!          (use HasArrayOfReals()). <br>
 /*instead*/  OCTColStd_HArray1OfReal^ GetArrayOfReals(OCNaroWrappers::OCTCollection_ExtendedString^ theName) ;

//! Defines a named array of real values. <br>
//!          If the array already exists, it changes its value to <theArrayOfReals>. <br>
 /*instead*/  void SetArrayOfReals(OCNaroWrappers::OCTCollection_ExtendedString^ theName, OCNaroWrappers::OCTColStd_HArray1OfReal^ theArrayOfReals) ;

//! Returns the internal container of named arrays of real values. <br>
 /*instead*/  OCTDataStd_DataMapOfStringHArray1OfReal^ GetArraysOfRealsContainer() ;

//! Replace the container content by new content of the <theArraysOfReals>. <br>
 /*instead*/  void ChangeArraysOfReals(OCNaroWrappers::OCTDataStd_DataMapOfStringHArray1OfReal^ theArraysOfReals) ;


 /*instead*/  OCStandard_GUID^ ID() ;


 /*instead*/  void Restore(OCNaroWrappers::OCTDF_Attribute^ With) ;


 /*instead*/  OCTDF_Attribute^ NewEmpty() ;


 /*instead*/  void Paste(OCNaroWrappers::OCTDF_Attribute^ Into, OCNaroWrappers::OCTDF_RelocationTable^ RT) ;


virtual /*instead*/  Standard_OStream& Dump(Standard_OStream& anOS) override;

~OCTDataStd_NamedData()
{
  nativeHandle->Nullify();
  delete nativeHandle;
}

};

}; // OCNaroWrappers

#endif
