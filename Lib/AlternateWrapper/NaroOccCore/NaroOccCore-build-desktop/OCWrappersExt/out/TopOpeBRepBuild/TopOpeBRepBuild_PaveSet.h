// File generated by CPPExt (MPV)
//
#ifndef _TopOpeBRepBuild_PaveSet_OCWrappers_HeaderFile
#define _TopOpeBRepBuild_PaveSet_OCWrappers_HeaderFile

// include native header
#include <TopOpeBRepBuild_PaveSet.hxx>
#include "../Converter.h"

#include "TopOpeBRepBuild_LoopSet.h"

#include "../TopoDS/TopoDS_Edge.h"
#include "TopOpeBRepBuild_ListOfPave.h"
#include "TopOpeBRepBuild_ListIteratorOfListOfPave.h"
#include "TopOpeBRepBuild_LoopSet.h"


namespace OCNaroWrappers
{

ref class OCTopoDS_Shape;
ref class OCTopOpeBRepBuild_Pave;
ref class OCTopOpeBRepBuild_Loop;
ref class OCTopoDS_Edge;
ref class OCTopOpeBRepBuild_ListOfPave;



//! class providing an exploration of a set of vertices to build edges. <br>
//! It is similar to LoopSet from TopOpeBRepBuild where Loop is Pave. <br>
public ref class OCTopOpeBRepBuild_PaveSet  : public OCTopOpeBRepBuild_LoopSet {

protected:
  // dummy constructor;
  OCTopOpeBRepBuild_PaveSet(OCDummy^) : OCTopOpeBRepBuild_LoopSet((OCDummy^)nullptr) {};

public:

// constructor from native
OCTopOpeBRepBuild_PaveSet(TopOpeBRepBuild_PaveSet* nativeHandle);

// Methods PUBLIC

//! Create a Pave set on edge <E>. It contains <E> vertices. <br>
OCTopOpeBRepBuild_PaveSet(OCNaroWrappers::OCTopoDS_Shape^ E);


 /*instead*/  void RemovePV(System::Boolean B) ;

//! Add <PV> in the Pave set. <br>
 /*instead*/  void Append(OCNaroWrappers::OCTopOpeBRepBuild_Pave^ PV) ;


virtual /*instead*/  void InitLoop() override;


virtual /*instead*/  System::Boolean MoreLoop() override;


virtual /*instead*/  void NextLoop() override;


virtual /*instead*/  OCTopOpeBRepBuild_Loop^ Loop() override;


 /*instead*/  OCTopoDS_Edge^ Edge() ;


 /*instead*/  System::Boolean HasEqualParameters() ;


 /*instead*/  Standard_Real EqualParameters() ;


 /*instead*/  System::Boolean ClosedVertices() ;


static /*instead*/  void SortPave(OCNaroWrappers::OCTopOpeBRepBuild_ListOfPave^ Lin, OCNaroWrappers::OCTopOpeBRepBuild_ListOfPave^ Lout) ;

~OCTopOpeBRepBuild_PaveSet()
{
  delete nativeHandle;
}

};

}; // OCNaroWrappers

#endif
