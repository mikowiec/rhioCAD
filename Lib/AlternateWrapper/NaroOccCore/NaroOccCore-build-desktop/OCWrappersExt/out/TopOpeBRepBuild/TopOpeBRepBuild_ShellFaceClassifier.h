// File generated by CPPExt (MPV)
//
#ifndef _TopOpeBRepBuild_ShellFaceClassifier_OCWrappers_HeaderFile
#define _TopOpeBRepBuild_ShellFaceClassifier_OCWrappers_HeaderFile

// include native header
#include <TopOpeBRepBuild_ShellFaceClassifier.hxx>
#include "../Converter.h"

#include "TopOpeBRepBuild_CompositeClassifier.h"

#include "../gp/gp_Pnt.h"
#include "../TopoDS/TopoDS_Shell.h"
#include "../BRep/BRep_Builder.h"
#include "../TopOpeBRepTool/TopOpeBRepTool_SolidClassifier.h"
#include "../TopTools/TopTools_DataMapOfShapeShape.h"
#include "../TopoDS/TopoDS_Shape.h"
#include "TopOpeBRepBuild_CompositeClassifier.h"
#include "../TopAbs/TopAbs_State.h"


namespace OCNaroWrappers
{

ref class OCTopOpeBRepBuild_BlockBuilder;
ref class OCTopoDS_Shape;



//! Classify faces and shells. <br>
//! shapes are Shells, Elements are Faces. <br>
public ref class OCTopOpeBRepBuild_ShellFaceClassifier  : public OCTopOpeBRepBuild_CompositeClassifier {

protected:
  // dummy constructor;
  OCTopOpeBRepBuild_ShellFaceClassifier(OCDummy^) : OCTopOpeBRepBuild_CompositeClassifier((OCDummy^)nullptr) {};

public:

// constructor from native
OCTopOpeBRepBuild_ShellFaceClassifier(TopOpeBRepBuild_ShellFaceClassifier* nativeHandle);

// Methods PUBLIC

//! Creates a classifier in 3D space, to compare : <br>
//! a face with a set of faces <br>
//! a shell with a set of faces <br>
//! a shell with a shell <br>
OCTopOpeBRepBuild_ShellFaceClassifier(OCNaroWrappers::OCTopOpeBRepBuild_BlockBuilder^ BB);


 /*instead*/  void Clear() ;

//! classify shell <B1> with shell <B2> <br>
 /*instead*/  OCTopAbs_State CompareShapes(OCNaroWrappers::OCTopoDS_Shape^ B1, OCNaroWrappers::OCTopoDS_Shape^ B2) ;

//! classify face <F> with shell <S> <br>
 /*instead*/  OCTopAbs_State CompareElementToShape(OCNaroWrappers::OCTopoDS_Shape^ F, OCNaroWrappers::OCTopoDS_Shape^ S) ;

//! prepare classification involving shell <S> <br>
//! calls ResetElement on first face of <S> <br>
 /*instead*/  void ResetShape(OCNaroWrappers::OCTopoDS_Shape^ S) ;

//! prepare classification involving face <F> <br>
//! define 3D point (later used in Compare()) on first vertex of face <F>. <br>
 /*instead*/  void ResetElement(OCNaroWrappers::OCTopoDS_Shape^ F) ;

//! Add the face <F> in the set of faces used in 3D point <br>
//! classification. Returns FALSE if the face <F> has been already <br>
//! added to the set of faces, otherwise returns TRUE. <br>
 /*instead*/  System::Boolean CompareElement(OCNaroWrappers::OCTopoDS_Shape^ F) ;

//! Returns state of classification of 3D point, defined by <br>
//! ResetElement, with the current set of faces, defined by Compare. <br>
 /*instead*/  OCTopAbs_State State() ;

~OCTopOpeBRepBuild_ShellFaceClassifier()
{
  delete nativeHandle;
}

};

}; // OCNaroWrappers

#endif