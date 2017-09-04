// File generated by CPPExt (CPP file)
//

#include "GeomFill_Filling.h"
#include "../Converter.h"
#include "../TColgp/TColgp_HArray2OfPnt.h"
#include "../TColStd/TColStd_HArray2OfReal.h"
#include "../TColgp/TColgp_Array2OfPnt.h"
#include "../TColStd/TColStd_Array2OfReal.h"


using namespace OCNaroWrappers;

OCGeomFill_Filling::OCGeomFill_Filling(GeomFill_Filling* nativeHandle) 
{
  this->nativeHandle = nativeHandle;
}

OCGeomFill_Filling::OCGeomFill_Filling() 
{
  nativeHandle = new GeomFill_Filling();
}

 Standard_Integer OCGeomFill_Filling::NbUPoles()
{
  return ((GeomFill_Filling*)nativeHandle)->NbUPoles();
}

 Standard_Integer OCGeomFill_Filling::NbVPoles()
{
  return ((GeomFill_Filling*)nativeHandle)->NbVPoles();
}

 void OCGeomFill_Filling::Poles(OCNaroWrappers::OCTColgp_Array2OfPnt^ Poles)
{
  ((GeomFill_Filling*)nativeHandle)->Poles(*((TColgp_Array2OfPnt*)Poles->Handle));
}

 System::Boolean OCGeomFill_Filling::isRational()
{
  return OCConverter::StandardBooleanToBoolean(((GeomFill_Filling*)nativeHandle)->isRational());
}

 void OCGeomFill_Filling::Weights(OCNaroWrappers::OCTColStd_Array2OfReal^ Weights)
{
  ((GeomFill_Filling*)nativeHandle)->Weights(*((TColStd_Array2OfReal*)Weights->Handle));
}


