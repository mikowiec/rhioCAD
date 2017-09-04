// File generated by CPPExt (CPP file)
//

#include "Storage_ArrayOfSchema.h"
#include "../Converter.h"
#include "Storage_Schema.h"


using namespace OCNaroWrappers;

OCStorage_ArrayOfSchema::OCStorage_ArrayOfSchema(Storage_ArrayOfSchema* nativeHandle) 
{
  this->nativeHandle = nativeHandle;
}

OCStorage_ArrayOfSchema::OCStorage_ArrayOfSchema(Standard_Integer Low, Standard_Integer Up) 
{
  nativeHandle = new Storage_ArrayOfSchema(Low, Up);
}

OCStorage_ArrayOfSchema::OCStorage_ArrayOfSchema(OCNaroWrappers::OCStorage_Schema^ Item, Standard_Integer Low, Standard_Integer Up) 
{
  nativeHandle = new Storage_ArrayOfSchema(*((Handle_Storage_Schema*)Item->Handle), Low, Up);
}

 void OCStorage_ArrayOfSchema::Init(OCNaroWrappers::OCStorage_Schema^ V)
{
  ((Storage_ArrayOfSchema*)nativeHandle)->Init(*((Handle_Storage_Schema*)V->Handle));
}

 System::Boolean OCStorage_ArrayOfSchema::IsAllocated()
{
  return OCConverter::StandardBooleanToBoolean(((Storage_ArrayOfSchema*)nativeHandle)->IsAllocated());
}

OCStorage_ArrayOfSchema^ OCStorage_ArrayOfSchema::Assign(OCNaroWrappers::OCStorage_ArrayOfSchema^ Other)
{
  Storage_ArrayOfSchema* tmp = new Storage_ArrayOfSchema(0, 0);
  *tmp = ((Storage_ArrayOfSchema*)nativeHandle)->Assign(*((Storage_ArrayOfSchema*)Other->Handle));
  return gcnew OCStorage_ArrayOfSchema(tmp);
}

 Standard_Integer OCStorage_ArrayOfSchema::Length()
{
  return ((Storage_ArrayOfSchema*)nativeHandle)->Length();
}

 Standard_Integer OCStorage_ArrayOfSchema::Lower()
{
  return ((Storage_ArrayOfSchema*)nativeHandle)->Lower();
}

 Standard_Integer OCStorage_ArrayOfSchema::Upper()
{
  return ((Storage_ArrayOfSchema*)nativeHandle)->Upper();
}

 void OCStorage_ArrayOfSchema::SetValue(Standard_Integer Index, OCNaroWrappers::OCStorage_Schema^ Value)
{
  ((Storage_ArrayOfSchema*)nativeHandle)->SetValue(Index, *((Handle_Storage_Schema*)Value->Handle));
}

OCStorage_Schema^ OCStorage_ArrayOfSchema::Value(Standard_Integer Index)
{
  Handle(Storage_Schema) tmp = ((Storage_ArrayOfSchema*)nativeHandle)->Value(Index);
  return gcnew OCStorage_Schema(&tmp);
}

OCStorage_Schema^ OCStorage_ArrayOfSchema::ChangeValue(Standard_Integer Index)
{
  Handle(Storage_Schema) tmp = ((Storage_ArrayOfSchema*)nativeHandle)->ChangeValue(Index);
  return gcnew OCStorage_Schema(&tmp);
}


