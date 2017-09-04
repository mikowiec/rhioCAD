// File generated by CPPExt (Enum)

#ifndef _BRepBuilderAPI_EdgeError_OCWrappers_HeaderFile
#define _BRepBuilderAPI_EdgeError_OCWrappers_HeaderFile

namespace OCNaroWrappers
{

//!  Indicates the outcome of the <br>
//! construction of an edge, i.e. whether it has been successful or <br>
//! not, as explained below: <br>
//! -      BRepBuilderAPI_EdgeDone No    error occurred; The edge is <br>
//!    correctly built. <br>
//! -      BRepBuilderAPI_PointProjectionFailed No parameters were given but <br>
//!    the projection of the 3D points on the curve failed. This <br>
//!    happens when the point distance to the curve is greater than <br>
//!    the precision value. <br>
//! -      BRepBuilderAPI_ParameterOutOfRange <br>
//!    The given parameters are not in the parametric range <br>
//!   C->FirstParameter(), C->LastParameter() <br>
//! -      BRepBuilderAPI_DifferentPointsOnClosedCurve <br>
//!    The two vertices or points are the extremities of a closed <br>
//!    curve but have different locations. <br>
//! -      BRepBuilderAPI_PointWithInfiniteParameter <br>
//!    A finite coordinate point was associated with an infinite <br>
//!    parameter (see the Precision package for a definition of    infinite values). <br>
//! -      BRepBuilderAPI_DifferentsPointAndParameter <br>
//!   The distance between the 3D point and the point evaluated <br>
//!    on the curve with the parameter is greater than the precision. <br>
//! -      BRepBuilderAPI_LineThroughIdenticPoints <br>
//!    Two identical points were given to define a line (construction <br>
//!    of an edge without curve); gp::Resolution is used for the    confusion test. <br>
public enum class OCBRepBuilderAPI_EdgeError
{ 
 BRepBuilderAPI_EdgeDone,
BRepBuilderAPI_PointProjectionFailed,
BRepBuilderAPI_ParameterOutOfRange,
BRepBuilderAPI_DifferentPointsOnClosedCurve,
BRepBuilderAPI_PointWithInfiniteParameter,
BRepBuilderAPI_DifferentsPointAndParameter,
BRepBuilderAPI_LineThroughIdenticPoints
};

}; // OCNaroWrappers

#endif
