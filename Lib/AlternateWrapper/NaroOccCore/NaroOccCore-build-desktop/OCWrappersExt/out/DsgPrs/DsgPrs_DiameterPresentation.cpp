// File generated by CPPExt (CPP file)
//

#include "DsgPrs_DiameterPresentation.h"
#include "../Converter.h"
#include "../Prs3d/Prs3d_Presentation.h"
#include "../Prs3d/Prs3d_Drawer.h"
#include "../TCollection/TCollection_ExtendedString.h"
#include "../gp/gp_Pnt.h"
#include "../gp/gp_Circ.h"


using namespace OCNaroWrappers;

OCDsgPrs_DiameterPresentation::OCDsgPrs_DiameterPresentation(DsgPrs_DiameterPresentation* nativeHandle) 
{
  this->nativeHandle = nativeHandle;
}

 void OCDsgPrs_DiameterPresentation::Add(OCNaroWrappers::OCPrs3d_Presentation^ aPresentation, OCNaroWrappers::OCPrs3d_Drawer^ aDrawer, OCNaroWrappers::OCTCollection_ExtendedString^ aText, OCNaroWrappers::OCgp_Pnt^ AttachmentPoint, OCNaroWrappers::OCgp_Circ^ aCircle, OCDsgPrs_ArrowSide ArrowSide, System::Boolean IsDiamSymbol)
{
  DsgPrs_DiameterPresentation::Add(*((Handle_Prs3d_Presentation*)aPresentation->Handle), *((Handle_Prs3d_Drawer*)aDrawer->Handle), *((TCollection_ExtendedString*)aText->Handle), *((gp_Pnt*)AttachmentPoint->Handle), *((gp_Circ*)aCircle->Handle), (DsgPrs_ArrowSide)ArrowSide, OCConverter::BooleanToStandardBoolean(IsDiamSymbol));
}

 void OCDsgPrs_DiameterPresentation::Add(OCNaroWrappers::OCPrs3d_Presentation^ aPresentation, OCNaroWrappers::OCPrs3d_Drawer^ aDrawer, OCNaroWrappers::OCTCollection_ExtendedString^ aText, OCNaroWrappers::OCgp_Pnt^ AttachmentPoint, OCNaroWrappers::OCgp_Circ^ aCircle, Standard_Real uFirst, Standard_Real uLast, OCDsgPrs_ArrowSide ArrowSide, System::Boolean IsDiamSymbol)
{
  DsgPrs_DiameterPresentation::Add(*((Handle_Prs3d_Presentation*)aPresentation->Handle), *((Handle_Prs3d_Drawer*)aDrawer->Handle), *((TCollection_ExtendedString*)aText->Handle), *((gp_Pnt*)AttachmentPoint->Handle), *((gp_Circ*)aCircle->Handle), uFirst, uLast, (DsgPrs_ArrowSide)ArrowSide, OCConverter::BooleanToStandardBoolean(IsDiamSymbol));
}


