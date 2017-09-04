// File generated by CPPExt (CPP file)
//

#include "DsgPrs_XYZPlanePresentation.h"
#include "../Converter.h"
#include "../Prs3d/Prs3d_Presentation.h"
#include "../Prs3d/Prs3d_Drawer.h"
#include "../gp/gp_Pnt.h"


using namespace OCNaroWrappers;

OCDsgPrs_XYZPlanePresentation::OCDsgPrs_XYZPlanePresentation(DsgPrs_XYZPlanePresentation* nativeHandle) 
{
  this->nativeHandle = nativeHandle;
}

 void OCDsgPrs_XYZPlanePresentation::Add(OCNaroWrappers::OCPrs3d_Presentation^ aPresentation, OCNaroWrappers::OCPrs3d_Drawer^ aDrawer, OCNaroWrappers::OCgp_Pnt^ aPt1, OCNaroWrappers::OCgp_Pnt^ aPt2, OCNaroWrappers::OCgp_Pnt^ aPt3)
{
  DsgPrs_XYZPlanePresentation::Add(*((Handle_Prs3d_Presentation*)aPresentation->Handle), *((Handle_Prs3d_Drawer*)aDrawer->Handle), *((gp_Pnt*)aPt1->Handle), *((gp_Pnt*)aPt2->Handle), *((gp_Pnt*)aPt3->Handle));
}


