// File generated by CPPExt (CPP file)
//

#include "FEmTool_Curve.h"
#include "../Converter.h"
#include "../PLib/PLib_Base.h"
#include "../TColStd/TColStd_HArray1OfReal.h"
#include "../TColStd/TColStd_Array1OfReal.h"
#include "../TColStd/TColStd_Array2OfReal.h"


using namespace OCNaroWrappers;

OCFEmTool_Curve::OCFEmTool_Curve(Handle(FEmTool_Curve)* nativeHandle) : OCMMgt_TShared((OCDummy^)nullptr)

{
  this->nativeHandle = new Handle_FEmTool_Curve(*nativeHandle);
}

OCFEmTool_Curve::OCFEmTool_Curve(Standard_Integer Dimension, Standard_Integer NbElements, OCNaroWrappers::OCPLib_Base^ TheBase, Standard_Real Tolerance) : OCMMgt_TShared((OCDummy^)nullptr)

{
  nativeHandle = new Handle_FEmTool_Curve(new FEmTool_Curve(Dimension, NbElements, *((Handle_PLib_Base*)TheBase->Handle), Tolerance));
}

OCTColStd_Array1OfReal^ OCFEmTool_Curve::Knots()
{
  TColStd_Array1OfReal* tmp = new TColStd_Array1OfReal(0, 0);
  *tmp = (*((Handle_FEmTool_Curve*)nativeHandle))->Knots();
  return gcnew OCTColStd_Array1OfReal(tmp);
}

 void OCFEmTool_Curve::SetElement(Standard_Integer IndexOfElement, OCNaroWrappers::OCTColStd_Array2OfReal^ Coeffs)
{
  (*((Handle_FEmTool_Curve*)nativeHandle))->SetElement(IndexOfElement, *((TColStd_Array2OfReal*)Coeffs->Handle));
}

 void OCFEmTool_Curve::D0(Standard_Real U, OCNaroWrappers::OCTColStd_Array1OfReal^ Pnt)
{
  (*((Handle_FEmTool_Curve*)nativeHandle))->D0(U, *((TColStd_Array1OfReal*)Pnt->Handle));
}

 void OCFEmTool_Curve::D1(Standard_Real U, OCNaroWrappers::OCTColStd_Array1OfReal^ Vec)
{
  (*((Handle_FEmTool_Curve*)nativeHandle))->D1(U, *((TColStd_Array1OfReal*)Vec->Handle));
}

 void OCFEmTool_Curve::D2(Standard_Real U, OCNaroWrappers::OCTColStd_Array1OfReal^ Vec)
{
  (*((Handle_FEmTool_Curve*)nativeHandle))->D2(U, *((TColStd_Array1OfReal*)Vec->Handle));
}

 void OCFEmTool_Curve::Length(Standard_Real FirstU, Standard_Real LastU, Standard_Real& Length)
{
  (*((Handle_FEmTool_Curve*)nativeHandle))->Length(FirstU, LastU, Length);
}

 void OCFEmTool_Curve::GetElement(Standard_Integer IndexOfElement, OCNaroWrappers::OCTColStd_Array2OfReal^ Coeffs)
{
  (*((Handle_FEmTool_Curve*)nativeHandle))->GetElement(IndexOfElement, *((TColStd_Array2OfReal*)Coeffs->Handle));
}

 void OCFEmTool_Curve::GetPolynom(OCNaroWrappers::OCTColStd_Array1OfReal^ Coeffs)
{
  (*((Handle_FEmTool_Curve*)nativeHandle))->GetPolynom(*((TColStd_Array1OfReal*)Coeffs->Handle));
}

 Standard_Integer OCFEmTool_Curve::NbElements()
{
  return (*((Handle_FEmTool_Curve*)nativeHandle))->NbElements();
}

 Standard_Integer OCFEmTool_Curve::Dimension()
{
  return (*((Handle_FEmTool_Curve*)nativeHandle))->Dimension();
}

OCPLib_Base^ OCFEmTool_Curve::Base()
{
  Handle(PLib_Base) tmp = (*((Handle_FEmTool_Curve*)nativeHandle))->Base();
  return gcnew OCPLib_Base(&tmp);
}

 Standard_Integer OCFEmTool_Curve::Degree(Standard_Integer IndexOfElement)
{
  return (*((Handle_FEmTool_Curve*)nativeHandle))->Degree(IndexOfElement);
}

 void OCFEmTool_Curve::SetDegree(Standard_Integer IndexOfElement, Standard_Integer Degree)
{
  (*((Handle_FEmTool_Curve*)nativeHandle))->SetDegree(IndexOfElement, Degree);
}

 void OCFEmTool_Curve::ReduceDegree(Standard_Integer IndexOfElement, Standard_Real Tol, Standard_Integer& NewDegree, Standard_Real& MaxError)
{
  (*((Handle_FEmTool_Curve*)nativeHandle))->ReduceDegree(IndexOfElement, Tol, NewDegree, MaxError);
}


