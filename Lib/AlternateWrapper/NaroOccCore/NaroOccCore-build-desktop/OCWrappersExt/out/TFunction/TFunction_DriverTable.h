// File generated by CPPExt (Transient)
//
#ifndef _TFunction_DriverTable_OCWrappers_HeaderFile
#define _TFunction_DriverTable_OCWrappers_HeaderFile

// include the wrapped class
#include <TFunction_DriverTable.hxx>
#include "../Converter.h"

#include "../MMgt/MMgt_TShared.h"

#include "TFunction_DataMapOfGUIDDriver.h"


namespace OCNaroWrappers
{

ref class OCTFunction_HArray1OfDataMapOfGUIDDriver;
ref class OCStandard_GUID;
ref class OCTFunction_Driver;


//! A container for instances of drivers. <br>
//! You create a new instance of TFunction_Driver <br>
//! and use the method AddDriver to load it into the driver table. <br>
public ref class OCTFunction_DriverTable : OCMMgt_TShared {

protected:
  // dummy constructor;
  OCTFunction_DriverTable(OCDummy^) : OCMMgt_TShared((OCDummy^)nullptr) {};

public:

// constructor from native
OCTFunction_DriverTable(Handle(TFunction_DriverTable)* nativeHandle);

// Methods PUBLIC

//! Returns the driver table. If a driver does not exist, creates it. <br>
static /*instead*/  OCTFunction_DriverTable^ Get() ;

//! Default constructor <br>
OCTFunction_DriverTable();

//! Returns true if the driver has been added successfully to the driver table. <br>
 /*instead*/  System::Boolean AddDriver(OCNaroWrappers::OCStandard_GUID^ guid, OCNaroWrappers::OCTFunction_Driver^ driver, Standard_Integer thread) ;

//! Returns true if the driver exists in the driver table. <br>
 /*instead*/  System::Boolean HasDriver(OCNaroWrappers::OCStandard_GUID^ guid, Standard_Integer thread) ;

//! Returns true if the driver was found. <br>
 /*instead*/  System::Boolean FindDriver(OCNaroWrappers::OCStandard_GUID^ guid, OCNaroWrappers::OCTFunction_Driver^ driver, Standard_Integer thread) ;


 /*instead*/  Standard_OStream& Dump(Standard_OStream& anOS) ;

//! Removes a driver with the given GUID. <br>
//!     Returns true if the driver has been removed successfully. <br>
 /*instead*/  System::Boolean RemoveDriver(OCNaroWrappers::OCStandard_GUID^ guid, Standard_Integer thread) ;

//! Removes all drivers. Returns true if the driver has been removed successfully. <br>
 /*instead*/  void Clear() ;

~OCTFunction_DriverTable()
{
  nativeHandle->Nullify();
  delete nativeHandle;
}

};

}; // OCNaroWrappers

#endif
