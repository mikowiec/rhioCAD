// File generated by CPPExt (MPV)
//
#ifndef _BRepPrimAPI_MakeTorus_OCWrappers_HeaderFile
#define _BRepPrimAPI_MakeTorus_OCWrappers_HeaderFile

// include native header
#include <BRepPrimAPI_MakeTorus.hxx>
#include "../Converter.h"

#include "BRepPrimAPI_MakeOneAxis.h"

#include "../BRepPrim/BRepPrim_Torus.h"
#include "BRepPrimAPI_MakeOneAxis.h"


namespace OCNaroWrappers
{

ref class OCgp_Ax2;
ref class OCBRepPrim_Torus;


//! Describes functions to build tori or portions of tori. <br>
//! A MakeTorus object provides a framework for: <br>
//! -   defining the construction of a torus, <br>
//! -   implementing the construction algorithm, and <br>
//! -   consulting the result. <br>
public ref class OCBRepPrimAPI_MakeTorus  : public OCBRepPrimAPI_MakeOneAxis {

protected:
  // dummy constructor;
  OCBRepPrimAPI_MakeTorus(OCDummy^) : OCBRepPrimAPI_MakeOneAxis((OCDummy^)nullptr) {};

public:

// constructor from native
OCBRepPrimAPI_MakeTorus(BRepPrimAPI_MakeTorus* nativeHandle);

// Methods PUBLIC

//! Make a torus of radii R1 R2. <br>
OCBRepPrimAPI_MakeTorus(Standard_Real R1, Standard_Real R2);

//! Make a section of a torus of radii R1 R2. <br>
OCBRepPrimAPI_MakeTorus(Standard_Real R1, Standard_Real R2, Standard_Real angle);

//! Make  a torus of  radii R2, R2  with angles on the <br>
//!          small circle. <br>
OCBRepPrimAPI_MakeTorus(Standard_Real R1, Standard_Real R2, Standard_Real angle1, Standard_Real angle2);

//! Make  a torus of  radii R2, R2  with angles on the <br>
//!          small circle. <br>
OCBRepPrimAPI_MakeTorus(Standard_Real R1, Standard_Real R2, Standard_Real angle1, Standard_Real angle2, Standard_Real angle);

//! Make a torus of radii R1 R2. <br>
OCBRepPrimAPI_MakeTorus(OCNaroWrappers::OCgp_Ax2^ Axes, Standard_Real R1, Standard_Real R2);

//! Make a section of a torus of radii R1 R2. <br>
OCBRepPrimAPI_MakeTorus(OCNaroWrappers::OCgp_Ax2^ Axes, Standard_Real R1, Standard_Real R2, Standard_Real angle);

//! Make a torus of radii R1 R2. <br>
OCBRepPrimAPI_MakeTorus(OCNaroWrappers::OCgp_Ax2^ Axes, Standard_Real R1, Standard_Real R2, Standard_Real angle1, Standard_Real angle2);

//! Make a section of a torus of radii R1 R2. <br>//! For all algorithms The resulting shape is composed of <br>
//!   -      a lateral toroidal face, <br>
//!   -      two conical faces (defined  by the equation v = angle1 and <br>
//!      v = angle2) if the sphere is truncated in the v parametric <br>
//!      direction (they may be cylindrical faces in some <br>
//!      particular conditions), and in case of a portion <br>
//!      of torus, two planar faces to close the shape.(in the planes <br>
//!      u = 0 and u = angle). <br>
//! Notes: <br>
//!   -      The u parameter corresponds to a rotation angle around the Z axis. <br>
//!   -      The circle whose radius is equal to the minor radius, <br>
//!      located in the plane defined by the X axis and the Z axis, <br>
//!      centered on the X axis, on its positive side, and positioned <br>
//!      at a distance from the origin equal to the major radius, is <br>
//!      the reference circle of the torus. The rotation around an <br>
//!      axis parallel to the Y axis and passing through the center <br>
//!      of the reference circle gives the v parameter on the <br>
//!      reference circle. The X axis gives the origin of the v <br>
//! parameter. Near 0, as v increases, the Z coordinate decreases. <br>
OCBRepPrimAPI_MakeTorus(OCNaroWrappers::OCgp_Ax2^ Axes, Standard_Real R1, Standard_Real R2, Standard_Real angle1, Standard_Real angle2, Standard_Real angle);

//! Returns the algorithm. <br>
 /*instead*/  Standard_Address OneAxis() ;

//! Returns the algorithm. <br>
//! <br>
 /*instead*/  OCBRepPrim_Torus^ Torus() ;

~OCBRepPrimAPI_MakeTorus()
{
  delete nativeHandle;
}

};

}; // OCNaroWrappers

#endif
