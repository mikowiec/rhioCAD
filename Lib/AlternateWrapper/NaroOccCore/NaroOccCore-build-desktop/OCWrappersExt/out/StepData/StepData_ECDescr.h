// File generated by CPPExt (Transient)
//
#ifndef _StepData_ECDescr_OCWrappers_HeaderFile
#define _StepData_ECDescr_OCWrappers_HeaderFile

// include the wrapped class
#include <StepData_ECDescr.hxx>
#include "../Converter.h"

#include "StepData_EDescr.h"

#include "../TColStd/TColStd_SequenceOfTransient.h"


namespace OCNaroWrappers
{

ref class OCStepData_ESDescr;
ref class OCTColStd_HSequenceOfAsciiString;
ref class OCStepData_Described;


//! Describes a Complex Entity (Plex) as a list of Simple ones <br>
public ref class OCStepData_ECDescr : OCStepData_EDescr {

protected:
  // dummy constructor;
  OCStepData_ECDescr(OCDummy^) : OCStepData_EDescr((OCDummy^)nullptr) {};

public:

// constructor from native
OCStepData_ECDescr(Handle(StepData_ECDescr)* nativeHandle);

// Methods PUBLIC

//! Creates an ECDescr, empty <br>
OCStepData_ECDescr();

//! Adds a member <br>
//!  Warning : members are added in alphabetic order <br>
 /*instead*/  void Add(OCNaroWrappers::OCStepData_ESDescr^ member) ;

//! Returns the count of members <br>
 /*instead*/  Standard_Integer NbMembers() ;

//! Returns a Member from its rank <br>
 /*instead*/  OCStepData_ESDescr^ Member(Standard_Integer num) ;

//! Returns the ordered list of types <br>
 /*instead*/  OCTColStd_HSequenceOfAsciiString^ TypeList() ;

//! Tells if a ESDescr matches a step type : exact or super type <br>
 /*instead*/  System::Boolean Matches(System::String^ steptype) ;

//! Returns True <br>
 /*instead*/  System::Boolean IsComplex() ;

//! Creates a described entity (i.e. a complex one, made of one <br>
//!           simple entity per member) <br>
 /*instead*/  OCStepData_Described^ NewEntity() ;

~OCStepData_ECDescr()
{
  nativeHandle->Nullify();
  delete nativeHandle;
}

};

}; // OCNaroWrappers

#endif