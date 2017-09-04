// File generated by CPPExt (MPV)
//
#ifndef _StepShape_Subedge_OCWrappers_HeaderFile
#define _StepShape_Subedge_OCWrappers_HeaderFile

// include native header
#include <StepShape_Subedge.hxx>
#include "../Converter.h"

#include "StepShape_Edge.h"

#include "StepShape_Edge.h"


namespace OCNaroWrappers
{

ref class OCTCollection_HAsciiString;
ref class OCStepShape_Vertex;
ref class OCStepShape_Edge;


//! Representation of STEP entity Subedge <br>
public ref class OCStepShape_Subedge  : public OCStepShape_Edge {

protected:
  // dummy constructor;
  OCStepShape_Subedge(OCDummy^) : OCStepShape_Edge((OCDummy^)nullptr) {};

public:

// constructor from native
OCStepShape_Subedge(StepShape_Subedge* nativeHandle);

// Methods PUBLIC

//! Empty constructor <br>
OCStepShape_Subedge();

//! Initialize all fields (own and inherited) <br>
 /*instead*/  void Init(OCNaroWrappers::OCTCollection_HAsciiString^ aRepresentationItem_Name, OCNaroWrappers::OCStepShape_Vertex^ aEdge_EdgeStart, OCNaroWrappers::OCStepShape_Vertex^ aEdge_EdgeEnd, OCNaroWrappers::OCStepShape_Edge^ aParentEdge) ;

//! Returns field ParentEdge <br>
 /*instead*/  OCStepShape_Edge^ ParentEdge() ;

//! Set field ParentEdge <br>
 /*instead*/  void SetParentEdge(OCNaroWrappers::OCStepShape_Edge^ ParentEdge) ;

~OCStepShape_Subedge()
{
  delete nativeHandle;
}

};

}; // OCNaroWrappers

#endif