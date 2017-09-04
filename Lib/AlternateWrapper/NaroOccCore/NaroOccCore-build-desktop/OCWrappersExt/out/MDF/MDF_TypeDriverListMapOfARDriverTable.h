// File generated by CPPExt (MPV)
//
#ifndef _MDF_TypeDriverListMapOfARDriverTable_OCWrappers_HeaderFile
#define _MDF_TypeDriverListMapOfARDriverTable_OCWrappers_HeaderFile

// include native header
#include <MDF_TypeDriverListMapOfARDriverTable.hxx>
#include "../Converter.h"

#include "../TCollection/TCollection_BasicMap.h"

#include "../TCollection/TCollection_BasicMap.h"


namespace OCNaroWrappers
{

ref class OCStandard_Type;
ref class OCMDF_DriverListOfARDriverTable;
ref class OCTColStd_MapTransientHasher;
ref class OCMDF_DataMapNodeOfTypeDriverListMapOfARDriverTable;
ref class OCMDF_DataMapIteratorOfTypeDriverListMapOfARDriverTable;



public ref class OCMDF_TypeDriverListMapOfARDriverTable  : public OCTCollection_BasicMap {

protected:
  // dummy constructor;
  OCMDF_TypeDriverListMapOfARDriverTable(OCDummy^) : OCTCollection_BasicMap((OCDummy^)nullptr) {};

public:

// constructor from native
OCMDF_TypeDriverListMapOfARDriverTable(MDF_TypeDriverListMapOfARDriverTable* nativeHandle);

// Methods PUBLIC


OCMDF_TypeDriverListMapOfARDriverTable(Standard_Integer NbBuckets);


 /*instead*/  OCMDF_TypeDriverListMapOfARDriverTable^ Assign(OCNaroWrappers::OCMDF_TypeDriverListMapOfARDriverTable^ Other) ;


 /*instead*/  void ReSize(Standard_Integer NbBuckets) ;


 /*instead*/  System::Boolean Bind(OCNaroWrappers::OCStandard_Type^ K, OCNaroWrappers::OCMDF_DriverListOfARDriverTable^ I) ;


 /*instead*/  System::Boolean IsBound(OCNaroWrappers::OCStandard_Type^ K) ;


 /*instead*/  System::Boolean UnBind(OCNaroWrappers::OCStandard_Type^ K) ;


 /*instead*/  OCMDF_DriverListOfARDriverTable^ Find(OCNaroWrappers::OCStandard_Type^ K) ;


 /*instead*/  OCMDF_DriverListOfARDriverTable^ ChangeFind(OCNaroWrappers::OCStandard_Type^ K) ;


 /*instead*/  Standard_Address Find1(OCNaroWrappers::OCStandard_Type^ K) ;


 /*instead*/  Standard_Address ChangeFind1(OCNaroWrappers::OCStandard_Type^ K) ;

~OCMDF_TypeDriverListMapOfARDriverTable()
{
  delete nativeHandle;
}

};

}; // OCNaroWrappers

#endif
