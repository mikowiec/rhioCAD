// File generated by CPPExt (CPP file)
//

#include "AIS2D_PrimitiveArchit.h"
#include "../Converter.h"
#include "../Graphic2d/Graphic2d_Primitive.h"


using namespace OCNaroWrappers;

OCAIS2D_PrimitiveArchit::OCAIS2D_PrimitiveArchit(Handle(AIS2D_PrimitiveArchit)* nativeHandle) : OCMMgt_TShared((OCDummy^)nullptr)

{
  this->nativeHandle = new Handle_AIS2D_PrimitiveArchit(*nativeHandle);
}

OCAIS2D_PrimitiveArchit::OCAIS2D_PrimitiveArchit(OCNaroWrappers::OCGraphic2d_Primitive^ aPrim, Standard_Integer ind) : OCMMgt_TShared((OCDummy^)nullptr)

{
  nativeHandle = new Handle_AIS2D_PrimitiveArchit(new AIS2D_PrimitiveArchit(*((Handle_Graphic2d_Primitive*)aPrim->Handle), ind));
}

OCGraphic2d_Primitive^ OCAIS2D_PrimitiveArchit::GetPrimitive()
{
  Handle(Graphic2d_Primitive) tmp = (*((Handle_AIS2D_PrimitiveArchit*)nativeHandle))->GetPrimitive();
  return gcnew OCGraphic2d_Primitive(&tmp);
}

 Standard_Integer OCAIS2D_PrimitiveArchit::GetIndex()
{
  return (*((Handle_AIS2D_PrimitiveArchit*)nativeHandle))->GetIndex();
}


