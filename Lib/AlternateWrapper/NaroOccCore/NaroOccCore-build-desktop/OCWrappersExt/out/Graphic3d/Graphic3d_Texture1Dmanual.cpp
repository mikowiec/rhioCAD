// File generated by CPPExt (CPP file)
//

#include "Graphic3d_Texture1Dmanual.h"
#include "../Converter.h"
#include "Graphic3d_StructureManager.h"


using namespace OCNaroWrappers;

OCGraphic3d_Texture1Dmanual::OCGraphic3d_Texture1Dmanual(Handle(Graphic3d_Texture1Dmanual)* nativeHandle) : OCGraphic3d_Texture1D((OCDummy^)nullptr)

{
  this->nativeHandle = new Handle_Graphic3d_Texture1Dmanual(*nativeHandle);
}

OCGraphic3d_Texture1Dmanual::OCGraphic3d_Texture1Dmanual(OCNaroWrappers::OCGraphic3d_StructureManager^ SM, System::String^ FileName) : OCGraphic3d_Texture1D((OCDummy^)nullptr)

{
  nativeHandle = new Handle_Graphic3d_Texture1Dmanual(new Graphic3d_Texture1Dmanual(*((Handle_Graphic3d_StructureManager*)SM->Handle), OCConverter::StringToStandardCString(FileName)));
}

OCGraphic3d_Texture1Dmanual::OCGraphic3d_Texture1Dmanual(OCNaroWrappers::OCGraphic3d_StructureManager^ SM, OCGraphic3d_NameOfTexture1D NOT) : OCGraphic3d_Texture1D((OCDummy^)nullptr)

{
  nativeHandle = new Handle_Graphic3d_Texture1Dmanual(new Graphic3d_Texture1Dmanual(*((Handle_Graphic3d_StructureManager*)SM->Handle), (Graphic3d_NameOfTexture1D)NOT));
}


