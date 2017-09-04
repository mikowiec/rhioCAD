// File generated by CPPExt (Enum)

#ifndef _ChFiDS_ChamfMethod_OCWrappers_HeaderFile
#define _ChFiDS_ChamfMethod_OCWrappers_HeaderFile

namespace OCNaroWrappers
{

//! This enum describe the  different kinds of extremities <br>
//!          of   a   fillet.   OnSame,   Ondiff and  AllSame   are <br>
//!          particular cases of BreakPoint   for a corner   with 3 <br>
//!          edges and three faces : <br>
//!          - AllSame means that  the three concavities are on the <br>
//!          same side of the Shape, <br>
//!          - OnDiff  means  that the  edge of  the  fillet  has a <br>
//!          concave side different than the two other edges, <br>
//!          - OnSame  means  that the  edge of  the  fillet  has a <br>
//!          concave side different than one of the two other edges <br>
//!          and identical to the third edge. <br>
public enum class OCChFiDS_ChamfMethod
{ 
 ChFiDS_Sym,
ChFiDS_TwoDist,
ChFiDS_DistAngle
};

}; // OCNaroWrappers

#endif
