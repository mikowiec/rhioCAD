// File generated by CPPExt (Enum)

#ifndef _BRepBuilderAPI_WireError_OCWrappers_HeaderFile
#define _BRepBuilderAPI_WireError_OCWrappers_HeaderFile

namespace OCNaroWrappers
{

//! Indicates the outcome of wire <br>
//! construction, i.e. whether it is successful or not, as explained below: <br>
//! -      BRepBuilderAPI_WireDone No <br>
//!    error occurred. The wire is correctly built. <br>
//! -      BRepBuilderAPI_EmptyWire No <br>
//! initialization of the algorithm. Only an empty constructor was used. <br>
//! -      BRepBuilderAPI_DisconnectedWire <br>
//! The last edge which you attempted to add was not connected to the wire. <br>
//! -      BRepBuilderAPI_NonManifoldWire <br>
//!    The wire with some singularity. <br>
public enum class OCBRepBuilderAPI_WireError
{ 
 BRepBuilderAPI_WireDone,
BRepBuilderAPI_EmptyWire,
BRepBuilderAPI_DisconnectedWire,
BRepBuilderAPI_NonManifoldWire
};

}; // OCNaroWrappers

#endif
