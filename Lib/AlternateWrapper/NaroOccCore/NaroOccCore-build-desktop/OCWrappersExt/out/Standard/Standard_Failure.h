// File generated by CPPExt (Transient)
//
#ifndef _Standard_Failure_OCWrappers_HeaderFile
#define _Standard_Failure_OCWrappers_HeaderFile

// include the wrapped class
#include <Standard_Failure.hxx>
#include "../Converter.h"

#include "Standard_Transient.h"



namespace OCNaroWrappers
{




//!   Forms the root of the entire exception hierarchy. <br>
public ref class OCStandard_Failure : OCStandard_Transient {

protected:
  // dummy constructor;
  OCStandard_Failure(OCDummy^) : OCStandard_Transient((OCDummy^)nullptr) {};

public:

// constructor from native
OCStandard_Failure(Handle(Standard_Failure)* nativeHandle);

// Methods PUBLIC


//!   Creates a status object of type "Failure". <br>
OCStandard_Failure();


//!   Creates a status object of type "Failure". <br>
OCStandard_Failure(System::String^ aString);


//!   Prints on the stream <s> the exception name followed by <br>
//!   the error message. <br>
//!  Level: Advanced <br>
//!  Warning: <br>
//!   The operator "OStream& operator<< (Standard_OStream&, <br>
//!                                      Handle(Standard_Failure)&)" <br>
//!   is implemented. (This operator uses the method Print) <br>
//! <br>
 /*instead*/  void Print(Standard_OStream& s) ;

//! Returns error message <br>
 /*instead*/  System::String^ GetMessageString() ;

//! Sets error message <br>
 /*instead*/  void SetMessageString(System::String^ aMessage) ;


 /*instead*/  void Reraise() ;


 /*instead*/  void Reraise(System::String^ aMessage) ;

//! Reraises a caught exception and changes its error message. <br>
 /*instead*/  void Reraise(Standard_SStream aReason) ;

//! Raises an exception of type "Failure" and associates <br>
//!          an error message to it. The message can be printed <br>
//!          in an exception handler. <br>
static /*instead*/  void Raise(System::String^ aMessage) ;

//! Raises an exception of type "Failure" and associates <br>
//!          an error message to it. The message can be constructed <br>
//!          at run-time. <br>
static /*instead*/  void Raise(Standard_SStream aReason) ;

//! Used to construct an instance of the exception object <br>
//!          as a handle. Shall be used to protect against possible <br>
//!          construction of exception object in C stack -- that is <br>
//!          dangerous since some of methods require that object <br>
//!          was allocated dynamically. <br>
static /*instead*/  OCStandard_Failure^ NewInstance(System::String^ aMessage) ;

//! Used to throw CASCADE exception from C signal handler. <br>
//!          On platforms that do not allow throwing C++ exceptions <br>
//!          from this handler (e.g. Linux), uses longjump to get to <br>
//!          the current active signal handler, and only then is <br>
//!          converted to C++ exception. <br>
 /*instead*/  void Jump() ;

//! Returns the last caught exception. <br>
//!          Needed when exceptions are emulated by C longjumps, <br>
//!          in other cases is also provided for compatibility. <br>
static /*instead*/  OCStandard_Failure^ Caught() ;

~OCStandard_Failure()
{
  nativeHandle->Nullify();
  delete nativeHandle;
}

};

}; // OCNaroWrappers

#endif
