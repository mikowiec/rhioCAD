// File generated by CPPExt (CPP file)
//

#include "Interface_SignType.h"
#include "../Converter.h"
#include "../TCollection/TCollection_AsciiString.h"
#include "../Standard/Standard_Transient.h"
#include "Interface_InterfaceModel.h"


using namespace OCNaroWrappers;

OCInterface_SignType::OCInterface_SignType(Handle(Interface_SignType)* nativeHandle) : OCMoniTool_SignText((OCDummy^)nullptr)

{
  this->nativeHandle = new Handle_Interface_SignType(*nativeHandle);
}

OCTCollection_AsciiString^ OCInterface_SignType::Text(OCNaroWrappers::OCStandard_Transient^ ent, OCNaroWrappers::OCStandard_Transient^ context)
{
  TCollection_AsciiString* tmp = new TCollection_AsciiString();
  *tmp = (*((Handle_Interface_SignType*)nativeHandle))->Text(*((Handle_Standard_Transient*)ent->Handle), *((Handle_Standard_Transient*)context->Handle));
  return gcnew OCTCollection_AsciiString(tmp);
}

 System::String^ OCInterface_SignType::ClassName(System::String^ typnam)
{
  return OCConverter::StandardCStringToString(Interface_SignType::ClassName(OCConverter::StringToStandardCString(typnam)));
}


