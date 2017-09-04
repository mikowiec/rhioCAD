// File generated by CPPExt (CPP file)
//

#include "XSControl_Vars.h"
#include "../Converter.h"
#include "../Dico/Dico_DictionaryOfTransient.h"
#include "../Standard/Standard_Transient.h"
#include "../Geom/Geom_Geometry.h"
#include "../Geom2d/Geom2d_Curve.h"
#include "../Geom/Geom_Curve.h"
#include "../Geom/Geom_Surface.h"
#include "../gp/gp_Pnt.h"
#include "../gp/gp_Pnt2d.h"
#include "../TopoDS/TopoDS_Shape.h"


using namespace OCNaroWrappers;

OCXSControl_Vars::OCXSControl_Vars(Handle(XSControl_Vars)* nativeHandle) : OCMMgt_TShared((OCDummy^)nullptr)

{
  this->nativeHandle = new Handle_XSControl_Vars(*nativeHandle);
}

OCXSControl_Vars::OCXSControl_Vars() : OCMMgt_TShared((OCDummy^)nullptr)

{
  nativeHandle = new Handle_XSControl_Vars(new XSControl_Vars());
}

 void OCXSControl_Vars::Set(System::String^ name, OCNaroWrappers::OCStandard_Transient^ val)
{
  (*((Handle_XSControl_Vars*)nativeHandle))->Set(OCConverter::StringToStandardCString(name), *((Handle_Standard_Transient*)val->Handle));
}

OCStandard_Transient^ OCXSControl_Vars::Get(System::String^& name)
{
  Handle(Standard_Transient) tmp = (*((Handle_XSControl_Vars*)nativeHandle))->Get(OCConverter::StringToStandardCString(name));
  return gcnew OCStandard_Transient(&tmp);
}

OCGeom_Geometry^ OCXSControl_Vars::GetGeom(System::String^& name)
{
  Handle(Geom_Geometry) tmp = (*((Handle_XSControl_Vars*)nativeHandle))->GetGeom(OCConverter::StringToStandardCString(name));
  return gcnew OCGeom_Geometry(&tmp);
}

OCGeom2d_Curve^ OCXSControl_Vars::GetCurve2d(System::String^& name)
{
  Handle(Geom2d_Curve) tmp = (*((Handle_XSControl_Vars*)nativeHandle))->GetCurve2d(OCConverter::StringToStandardCString(name));
  return gcnew OCGeom2d_Curve(&tmp);
}

OCGeom_Curve^ OCXSControl_Vars::GetCurve(System::String^& name)
{
  Handle(Geom_Curve) tmp = (*((Handle_XSControl_Vars*)nativeHandle))->GetCurve(OCConverter::StringToStandardCString(name));
  return gcnew OCGeom_Curve(&tmp);
}

OCGeom_Surface^ OCXSControl_Vars::GetSurface(System::String^& name)
{
  Handle(Geom_Surface) tmp = (*((Handle_XSControl_Vars*)nativeHandle))->GetSurface(OCConverter::StringToStandardCString(name));
  return gcnew OCGeom_Surface(&tmp);
}

 void OCXSControl_Vars::SetPoint(System::String^ name, OCNaroWrappers::OCgp_Pnt^ val)
{
  (*((Handle_XSControl_Vars*)nativeHandle))->SetPoint(OCConverter::StringToStandardCString(name), *((gp_Pnt*)val->Handle));
}

 void OCXSControl_Vars::SetPoint2d(System::String^ name, OCNaroWrappers::OCgp_Pnt2d^ val)
{
  (*((Handle_XSControl_Vars*)nativeHandle))->SetPoint2d(OCConverter::StringToStandardCString(name), *((gp_Pnt2d*)val->Handle));
}

 System::Boolean OCXSControl_Vars::GetPoint(System::String^& name, OCNaroWrappers::OCgp_Pnt^ pnt)
{
  return OCConverter::StandardBooleanToBoolean((*((Handle_XSControl_Vars*)nativeHandle))->GetPoint(OCConverter::StringToStandardCString(name), *((gp_Pnt*)pnt->Handle)));
}

 System::Boolean OCXSControl_Vars::GetPoint2d(System::String^& name, OCNaroWrappers::OCgp_Pnt2d^ pnt)
{
  return OCConverter::StandardBooleanToBoolean((*((Handle_XSControl_Vars*)nativeHandle))->GetPoint2d(OCConverter::StringToStandardCString(name), *((gp_Pnt2d*)pnt->Handle)));
}

 void OCXSControl_Vars::SetShape(System::String^ name, OCNaroWrappers::OCTopoDS_Shape^ val)
{
  (*((Handle_XSControl_Vars*)nativeHandle))->SetShape(OCConverter::StringToStandardCString(name), *((TopoDS_Shape*)val->Handle));
}

OCTopoDS_Shape^ OCXSControl_Vars::GetShape(System::String^& name)
{
  TopoDS_Shape* tmp = new TopoDS_Shape();
  *tmp = (*((Handle_XSControl_Vars*)nativeHandle))->GetShape(OCConverter::StringToStandardCString(name));
  return gcnew OCTopoDS_Shape(tmp);
}


