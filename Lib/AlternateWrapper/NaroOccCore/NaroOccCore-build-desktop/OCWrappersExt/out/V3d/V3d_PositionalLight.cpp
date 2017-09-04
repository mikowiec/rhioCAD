// File generated by CPPExt (CPP file)
//

#include "V3d_PositionalLight.h"
#include "../Converter.h"
#include "V3d_Viewer.h"
#include "V3d_View.h"
#include "../Graphic3d/Graphic3d_Group.h"


using namespace OCNaroWrappers;

OCV3d_PositionalLight::OCV3d_PositionalLight(Handle(V3d_PositionalLight)* nativeHandle) : OCV3d_PositionLight((OCDummy^)nullptr)

{
  this->nativeHandle = new Handle_V3d_PositionalLight(*nativeHandle);
}

OCV3d_PositionalLight::OCV3d_PositionalLight(OCNaroWrappers::OCV3d_Viewer^ VM, V3d_Coordinate X, V3d_Coordinate Y, V3d_Coordinate Z, OCQuantity_NameOfColor Color, Quantity_Coefficient Attenuation1, Quantity_Coefficient Attenuation2) : OCV3d_PositionLight((OCDummy^)nullptr)

{
  nativeHandle = new Handle_V3d_PositionalLight(new V3d_PositionalLight(*((Handle_V3d_Viewer*)VM->Handle), X, Y, Z, (Quantity_NameOfColor)Color, Attenuation1, Attenuation2));
}

OCV3d_PositionalLight::OCV3d_PositionalLight(OCNaroWrappers::OCV3d_Viewer^ VM, V3d_Coordinate Xt, V3d_Coordinate Yt, V3d_Coordinate Zt, V3d_Coordinate Xp, V3d_Coordinate Yp, V3d_Coordinate Zp, OCQuantity_NameOfColor Color, Quantity_Coefficient Attenuation1, Quantity_Coefficient Attenuation2) : OCV3d_PositionLight((OCDummy^)nullptr)

{
  nativeHandle = new Handle_V3d_PositionalLight(new V3d_PositionalLight(*((Handle_V3d_Viewer*)VM->Handle), Xt, Yt, Zt, Xp, Yp, Zp, (Quantity_NameOfColor)Color, Attenuation1, Attenuation2));
}

 void OCV3d_PositionalLight::SetPosition(V3d_Coordinate X, V3d_Coordinate Y, V3d_Coordinate Z)
{
  (*((Handle_V3d_PositionalLight*)nativeHandle))->SetPosition(X, Y, Z);
}

 void OCV3d_PositionalLight::SetAttenuation(Quantity_Coefficient A1, Quantity_Coefficient A2)
{
  (*((Handle_V3d_PositionalLight*)nativeHandle))->SetAttenuation(A1, A2);
}

 void OCV3d_PositionalLight::Display(OCNaroWrappers::OCV3d_View^ aView, OCV3d_TypeOfRepresentation Representation)
{
  (*((Handle_V3d_PositionalLight*)nativeHandle))->Display(*((Handle_V3d_View*)aView->Handle), (V3d_TypeOfRepresentation)Representation);
}

 void OCV3d_PositionalLight::Position(V3d_Coordinate& X, V3d_Coordinate& Y, V3d_Coordinate& Z)
{
  (*((Handle_V3d_PositionalLight*)nativeHandle))->Position(X, Y, Z);
}

 void OCV3d_PositionalLight::Attenuation(Quantity_Coefficient& A1, Quantity_Coefficient& A2)
{
  (*((Handle_V3d_PositionalLight*)nativeHandle))->Attenuation(A1, A2);
}


