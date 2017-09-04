// File generated by CPPExt (CPP file)
//

#include "Graphic3d_AspectText3d.h"
#include "../Converter.h"
#include "../Quantity/Quantity_Color.h"


using namespace OCNaroWrappers;

OCGraphic3d_AspectText3d::OCGraphic3d_AspectText3d(Handle(Graphic3d_AspectText3d)* nativeHandle) : OCMMgt_TShared((OCDummy^)nullptr)

{
  this->nativeHandle = new Handle_Graphic3d_AspectText3d(*nativeHandle);
}

OCGraphic3d_AspectText3d::OCGraphic3d_AspectText3d() : OCMMgt_TShared((OCDummy^)nullptr)

{
  nativeHandle = new Handle_Graphic3d_AspectText3d(new Graphic3d_AspectText3d());
}

OCGraphic3d_AspectText3d::OCGraphic3d_AspectText3d(OCNaroWrappers::OCQuantity_Color^ AColor, System::String^ AFont, Standard_Real AExpansionFactor, Standard_Real ASpace, OCAspect_TypeOfStyleText AStyle, OCAspect_TypeOfDisplayText ADisplayType) : OCMMgt_TShared((OCDummy^)nullptr)

{
  nativeHandle = new Handle_Graphic3d_AspectText3d(new Graphic3d_AspectText3d(*((Quantity_Color*)AColor->Handle), OCConverter::StringToStandardCString(AFont), AExpansionFactor, ASpace, (Aspect_TypeOfStyleText)AStyle, (Aspect_TypeOfDisplayText)ADisplayType));
}

 void OCGraphic3d_AspectText3d::SetColor(OCNaroWrappers::OCQuantity_Color^ AColor)
{
  (*((Handle_Graphic3d_AspectText3d*)nativeHandle))->SetColor(*((Quantity_Color*)AColor->Handle));
}

 void OCGraphic3d_AspectText3d::SetExpansionFactor(Standard_Real AFactor)
{
  (*((Handle_Graphic3d_AspectText3d*)nativeHandle))->SetExpansionFactor(AFactor);
}

 void OCGraphic3d_AspectText3d::SetFont(System::String^ AFont)
{
  (*((Handle_Graphic3d_AspectText3d*)nativeHandle))->SetFont(OCConverter::StringToStandardCString(AFont));
}

 void OCGraphic3d_AspectText3d::SetSpace(Standard_Real ASpace)
{
  (*((Handle_Graphic3d_AspectText3d*)nativeHandle))->SetSpace(ASpace);
}

 void OCGraphic3d_AspectText3d::SetStyle(OCAspect_TypeOfStyleText AStyle)
{
  (*((Handle_Graphic3d_AspectText3d*)nativeHandle))->SetStyle((Aspect_TypeOfStyleText)AStyle);
}

 void OCGraphic3d_AspectText3d::SetDisplayType(OCAspect_TypeOfDisplayText ADisplayType)
{
  (*((Handle_Graphic3d_AspectText3d*)nativeHandle))->SetDisplayType((Aspect_TypeOfDisplayText)ADisplayType);
}

 void OCGraphic3d_AspectText3d::SetColorSubTitle(OCNaroWrappers::OCQuantity_Color^ AColor)
{
  (*((Handle_Graphic3d_AspectText3d*)nativeHandle))->SetColorSubTitle(*((Quantity_Color*)AColor->Handle));
}

 void OCGraphic3d_AspectText3d::SetTextZoomable(System::Boolean AFlag)
{
  (*((Handle_Graphic3d_AspectText3d*)nativeHandle))->SetTextZoomable(OCConverter::BooleanToStandardBoolean(AFlag));
}

 System::Boolean OCGraphic3d_AspectText3d::GetTextZoomable()
{
  return OCConverter::StandardBooleanToBoolean((*((Handle_Graphic3d_AspectText3d*)nativeHandle))->GetTextZoomable());
}

 void OCGraphic3d_AspectText3d::SetTextAngle(Standard_Real AAngle)
{
  (*((Handle_Graphic3d_AspectText3d*)nativeHandle))->SetTextAngle(AAngle);
}

 Standard_Real OCGraphic3d_AspectText3d::GetTextAngle()
{
  return (*((Handle_Graphic3d_AspectText3d*)nativeHandle))->GetTextAngle();
}

 void OCGraphic3d_AspectText3d::SetTextFontAspect(OCFont_FontAspect AFontAspect)
{
  (*((Handle_Graphic3d_AspectText3d*)nativeHandle))->SetTextFontAspect((Font_FontAspect)AFontAspect);
}

 OCFont_FontAspect OCGraphic3d_AspectText3d::GetTextFontAspect()
{
  return (OCFont_FontAspect)((*((Handle_Graphic3d_AspectText3d*)nativeHandle))->GetTextFontAspect());
}

 void OCGraphic3d_AspectText3d::Values(OCNaroWrappers::OCQuantity_Color^ AColor, System::String^& AFont, Standard_Real& AnExpansionFactor, Standard_Real& ASpace)
{
  (*((Handle_Graphic3d_AspectText3d*)nativeHandle))->Values(*((Quantity_Color*)AColor->Handle), OCConverter::StringToStandardCString(AFont), AnExpansionFactor, ASpace);
}

 void OCGraphic3d_AspectText3d::Values(OCNaroWrappers::OCQuantity_Color^ AColor, System::String^& AFont, Standard_Real& AnExpansionFactor, Standard_Real& ASpace, OCAspect_TypeOfStyleText& AStyle, OCAspect_TypeOfDisplayText& ADisplayType, OCNaroWrappers::OCQuantity_Color^ AColorSubTitle)
{
  (*((Handle_Graphic3d_AspectText3d*)nativeHandle))->Values(*((Quantity_Color*)AColor->Handle), OCConverter::StringToStandardCString(AFont), AnExpansionFactor, ASpace, (Aspect_TypeOfStyleText&)AStyle, (Aspect_TypeOfDisplayText&)ADisplayType, *((Quantity_Color*)AColorSubTitle->Handle));
}

 void OCGraphic3d_AspectText3d::Values(OCNaroWrappers::OCQuantity_Color^ AColor, System::String^& AFont, Standard_Real& AnExpansionFactor, Standard_Real& ASpace, OCAspect_TypeOfStyleText& AStyle, OCAspect_TypeOfDisplayText& ADisplayType, OCNaroWrappers::OCQuantity_Color^ AColorSubTitle, System::Boolean& ATextZoomable, Standard_Real& ATextAngle)
{
  (*((Handle_Graphic3d_AspectText3d*)nativeHandle))->Values(*((Quantity_Color*)AColor->Handle), OCConverter::StringToStandardCString(AFont), AnExpansionFactor, ASpace, (Aspect_TypeOfStyleText&)AStyle, (Aspect_TypeOfDisplayText&)ADisplayType, *((Quantity_Color*)AColorSubTitle->Handle), (Standard_Boolean&)(ATextZoomable), ATextAngle);
}

 void OCGraphic3d_AspectText3d::Values(OCNaroWrappers::OCQuantity_Color^ AColor, System::String^& AFont, Standard_Real& AnExpansionFactor, Standard_Real& ASpace, OCAspect_TypeOfStyleText& AStyle, OCAspect_TypeOfDisplayText& ADisplayType, OCNaroWrappers::OCQuantity_Color^ AColorSubTitle, System::Boolean& ATextZoomable, Standard_Real& ATextAngle, OCFont_FontAspect& ATextFontAspect)
{
  (*((Handle_Graphic3d_AspectText3d*)nativeHandle))->Values(*((Quantity_Color*)AColor->Handle), OCConverter::StringToStandardCString(AFont), AnExpansionFactor, ASpace, (Aspect_TypeOfStyleText&)AStyle, (Aspect_TypeOfDisplayText&)ADisplayType, *((Quantity_Color*)AColorSubTitle->Handle), (Standard_Boolean&)(ATextZoomable), ATextAngle, (Font_FontAspect&)ATextFontAspect);
}


