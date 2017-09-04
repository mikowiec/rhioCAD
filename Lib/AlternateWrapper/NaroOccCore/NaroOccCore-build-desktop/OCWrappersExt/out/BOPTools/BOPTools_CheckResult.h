// File generated by CPPExt (MPV)
//
#ifndef _BOPTools_CheckResult_OCWrappers_HeaderFile
#define _BOPTools_CheckResult_OCWrappers_HeaderFile

// include native header
#include <BOPTools_CheckResult.hxx>
#include "../Converter.h"


#include "BOPTools_CheckStatus.h"
#include "../TopTools/TopTools_ListOfShape.h"


namespace OCNaroWrappers
{

ref class OCGeom_Geometry;
ref class OCTopoDS_Shape;
ref class OCTopTools_ListOfShape;


//! contains information about faulty shapes <br>
//!          and faulty types <br>
public ref class OCBOPTools_CheckResult  {

protected:
  BOPTools_CheckResult* nativeHandle;
  OCBOPTools_CheckResult(OCDummy^) {};

public:
  property BOPTools_CheckResult* Handle
  {
    BOPTools_CheckResult* get()
    {
      return nativeHandle;
    }
  }


// constructor from native
OCBOPTools_CheckResult(BOPTools_CheckResult* nativeHandle);

// Methods PUBLIC

//! empty constructor <br>
OCBOPTools_CheckResult();

//! adds a shape with faulty to a list <br>
 /*instead*/  void AddShape(OCNaroWrappers::OCTopoDS_Shape^ TheShape) ;

//! gets access to faulty shapes in a list const <br>
 /*instead*/  OCTopTools_ListOfShape^ GetShapes() ;

//! sets faulty status for shapes <br>
 /*instead*/  void SetCheckStatus(OCBOPTools_CheckStatus TheStatus) ;

//! gets faulty status for shapes <br>
 /*instead*/  OCBOPTools_CheckStatus GetCheckStatus() ;

//! sets an attached geometry to faulty shapes if any <br>
 /*instead*/  void SetInterferenceGeometry(OCNaroWrappers::OCGeom_Geometry^ TheGeometry) ;

//! gets an attached geometry to shapes if any <br>
 /*instead*/  OCGeom_Geometry^ GetInterferenceGeometry() ;

~OCBOPTools_CheckResult()
{
  delete nativeHandle;
}

};

}; // OCNaroWrappers

#endif
