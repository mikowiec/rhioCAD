// File generated by CPPExt (MPV)
//
#ifndef _BRepMesh_GeomTool_OCWrappers_HeaderFile
#define _BRepMesh_GeomTool_OCWrappers_HeaderFile

// include native header
#include <BRepMesh_GeomTool.hxx>
#include "../Converter.h"


#include "../GCPnts/GCPnts_TangentialDeflection.h"
#include "../GeomAbs/GeomAbs_IsoType.h"


namespace OCNaroWrappers
{

ref class OCBRepAdaptor_Curve;
ref class OCBRepAdaptor_HSurface;
ref class OCgp_Pnt;
ref class OCgp_Pnt2d;
ref class OCgp_Dir;



public ref class OCBRepMesh_GeomTool  {

protected:
  BRepMesh_GeomTool* nativeHandle;
  OCBRepMesh_GeomTool(OCDummy^) {};

public:
  property BRepMesh_GeomTool* Handle
  {
    BRepMesh_GeomTool* get()
    {
      return nativeHandle;
    }
  }


// constructor from native
OCBRepMesh_GeomTool(BRepMesh_GeomTool* nativeHandle);

// Methods PUBLIC


OCBRepMesh_GeomTool(OCNaroWrappers::OCBRepAdaptor_Curve^ C, Standard_Real Ufirst, Standard_Real Ulast, Standard_Real AngDefl, Standard_Real Deflection, Standard_Integer nbpointsmin);


OCBRepMesh_GeomTool(OCNaroWrappers::OCBRepAdaptor_HSurface^ S, Standard_Real ParamIso, OCGeomAbs_IsoType Type, Standard_Real Ufirst, Standard_Real Ulast, Standard_Real AngDefl, Standard_Real Deflection, Standard_Integer nbpointsmin);

//! Add point to already calculated points (or replace existing) <br>
//!          Returns index of new added point <br>
//!           or founded with parametric tolerance (replaced if theIsReplace is true) <br>
 /*instead*/  Standard_Integer AddPoint(OCNaroWrappers::OCgp_Pnt^ thePnt, Standard_Real theParam, System::Boolean theIsReplace) ;


 /*instead*/  Standard_Integer NbPoints() ;


 /*instead*/  void Value(Standard_Real IsoParam, Standard_Integer Index, Standard_Real& W, OCNaroWrappers::OCgp_Pnt^ P, OCNaroWrappers::OCgp_Pnt2d^ UV) ;


 /*instead*/  void Value(OCNaroWrappers::OCBRepAdaptor_Curve^ C, OCNaroWrappers::OCBRepAdaptor_HSurface^ S, Standard_Integer Index, Standard_Real& W, OCNaroWrappers::OCgp_Pnt^ P, OCNaroWrappers::OCgp_Pnt2d^ UV) ;


static /*instead*/  void D0(OCNaroWrappers::OCBRepAdaptor_HSurface^ F, Standard_Real U, Standard_Real V, OCNaroWrappers::OCgp_Pnt^ P) ;

//! return false if the normal can not be computed <br>
static /*instead*/  System::Boolean Normal(OCNaroWrappers::OCBRepAdaptor_HSurface^ F, Standard_Real U, Standard_Real V, OCNaroWrappers::OCgp_Pnt^ P, OCNaroWrappers::OCgp_Dir^ Nor) ;

~OCBRepMesh_GeomTool()
{
  delete nativeHandle;
}

};

}; // OCNaroWrappers

#endif