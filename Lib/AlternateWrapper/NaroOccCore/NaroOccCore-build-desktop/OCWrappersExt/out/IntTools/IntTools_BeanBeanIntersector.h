// File generated by CPPExt (MPV)
//
#ifndef _IntTools_BeanBeanIntersector_OCWrappers_HeaderFile
#define _IntTools_BeanBeanIntersector_OCWrappers_HeaderFile

// include native header
#include <IntTools_BeanBeanIntersector.hxx>
#include "../Converter.h"


#include "../BRepAdaptor/BRepAdaptor_Curve.h"
#include "../GeomAPI/GeomAPI_ProjectPointOnCurve.h"
#include "IntTools_MarkedRangeSet.h"
#include "IntTools_SequenceOfRanges.h"


namespace OCNaroWrappers
{

ref class OCGeom_Curve;
ref class OCTopoDS_Edge;
ref class OCBRepAdaptor_Curve;
ref class OCIntTools_SequenceOfRanges;
ref class OCIntTools_Range;


//! The class BeanBeanIntersector computes ranges of parameters on <br>
//!         the curve of a first bean (part of edge) that bounds the parts of bean which <br>
//!	        are on the other bean according to tolerance of edges. <br>
public ref class OCIntTools_BeanBeanIntersector  {

protected:
  IntTools_BeanBeanIntersector* nativeHandle;
  OCIntTools_BeanBeanIntersector(OCDummy^) {};

public:
  property IntTools_BeanBeanIntersector* Handle
  {
    IntTools_BeanBeanIntersector* get()
    {
      return nativeHandle;
    }
  }


// constructor from native
OCIntTools_BeanBeanIntersector(IntTools_BeanBeanIntersector* nativeHandle);

// Methods PUBLIC


OCIntTools_BeanBeanIntersector();


//! Initializes the algorithm <br>
OCIntTools_BeanBeanIntersector(OCNaroWrappers::OCTopoDS_Edge^ theEdge1, OCNaroWrappers::OCTopoDS_Edge^ theEdge2);


//! Initializes the algorithm <br>
OCIntTools_BeanBeanIntersector(OCNaroWrappers::OCBRepAdaptor_Curve^ theCurve1, OCNaroWrappers::OCBRepAdaptor_Curve^ theCurve2, Standard_Real theBeanTolerance1, Standard_Real theBeanTolerance2);


//! Initializes the algorithm <br>
OCIntTools_BeanBeanIntersector(OCNaroWrappers::OCBRepAdaptor_Curve^ theCurve1, OCNaroWrappers::OCBRepAdaptor_Curve^ theCurve2, Standard_Real theFirstParOnCurve1, Standard_Real theLastParOnCurve1, Standard_Real theFirstParOnCurve2, Standard_Real theLastParOnCurve2, Standard_Real theBeanTolerance1, Standard_Real theBeanTolerance2);


//! Initializes the algorithm <br>
 /*instead*/  void Init(OCNaroWrappers::OCTopoDS_Edge^ theEdge1, OCNaroWrappers::OCTopoDS_Edge^ theEdge2) ;


//! Initializes the algorithm <br>
 /*instead*/  void Init(OCNaroWrappers::OCBRepAdaptor_Curve^ theCurve1, OCNaroWrappers::OCBRepAdaptor_Curve^ theCurve2, Standard_Real theBeanTolerance1, Standard_Real theBeanTolerance2) ;


//! Initializes the algorithm <br>
 /*instead*/  void Init(OCNaroWrappers::OCBRepAdaptor_Curve^ theCurve1, OCNaroWrappers::OCBRepAdaptor_Curve^ theCurve2, Standard_Real theFirstParOnCurve1, Standard_Real theLastParOnCurve1, Standard_Real theFirstParOnCurve2, Standard_Real theLastParOnCurve2, Standard_Real theBeanTolerance1, Standard_Real theBeanTolerance2) ;


//! Sets bounding parameters for first bean if IsFirstBean is true <br>
//! and for second bean if IsFirstBean is false <br>
 /*instead*/  void SetBeanParameters(System::Boolean IsFirstBean, Standard_Real theFirstParOnCurve, Standard_Real theLastParOnCurve) ;


//! Launches the algorithm <br>
//! <br>
 /*instead*/  void Perform() ;


//! Returns true if the computations was successfull <br>
//! otherwise returns false <br>
 /*instead*/  System::Boolean IsDone() ;


 /*instead*/  OCIntTools_SequenceOfRanges^ Result() ;


 /*instead*/  void Result(OCNaroWrappers::OCIntTools_SequenceOfRanges^ theResults) ;

~OCIntTools_BeanBeanIntersector()
{
  delete nativeHandle;
}

};

}; // OCNaroWrappers

#endif
