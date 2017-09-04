// File generated by CPPExt (CPP file)
//

#include "PlotMgt_PlotterDriver.h"
#include "../Converter.h"
#include "PlotMgt_Plotter.h"
#include "PlotMgt_HListOfMFTFonts.h"
#include "../TShort/TShort_HArray1OfShortReal.h"
#include "PlotMgt_TextManager.h"
#include "../Aspect/Aspect_ColorMap.h"
#include "../Aspect/Aspect_TypeMap.h"
#include "../Aspect/Aspect_WidthMap.h"
#include "../Aspect/Aspect_MarkMap.h"
#include "../Aspect/Aspect_FontMap.h"
#include "../Standard/Standard_Transient.h"
#include "../TShort/TShort_Array1OfShortReal.h"
#include "../TCollection/TCollection_ExtendedString.h"
#include "../TCollection/TCollection_AsciiString.h"


using namespace OCNaroWrappers;

OCPlotMgt_PlotterDriver::OCPlotMgt_PlotterDriver(Handle(PlotMgt_PlotterDriver)* nativeHandle) : OCAspect_Driver((OCDummy^)nullptr)

{
  this->nativeHandle = new Handle_PlotMgt_PlotterDriver(*nativeHandle);
}

OCPlotMgt_PlotterDriver::OCPlotMgt_PlotterDriver(OCNaroWrappers::OCPlotMgt_Plotter^ aPlotter, System::String^ aFileName, System::Boolean fCreateFile) : OCAspect_Driver((OCDummy^)nullptr)

{}

OCPlotMgt_PlotterDriver::OCPlotMgt_PlotterDriver(System::String^ aFileName, System::Boolean fCreateFile) : OCAspect_Driver((OCDummy^)nullptr)

{}

 System::Boolean OCPlotMgt_PlotterDriver::Spool(OCAspect_PlotMode aPlotMode, System::String^ aReserved1, System::Boolean aReserved2)
{
  return OCConverter::StandardBooleanToBoolean((*((Handle_PlotMgt_PlotterDriver*)nativeHandle))->Spool((Aspect_PlotMode)aPlotMode, OCConverter::StringToStandardCString(aReserved1), OCConverter::BooleanToStandardBoolean(aReserved2)));
}

 void OCPlotMgt_PlotterDriver::SetLineAttrib(Standard_Integer ColorIndex, Standard_Integer TypeIndex, Standard_Integer WidthIndex)
{
  (*((Handle_PlotMgt_PlotterDriver*)nativeHandle))->SetLineAttrib(ColorIndex, TypeIndex, WidthIndex);
}

 void OCPlotMgt_PlotterDriver::SetTextAttrib(Standard_Integer ColorIndex, Standard_Integer FontIndex)
{
  (*((Handle_PlotMgt_PlotterDriver*)nativeHandle))->SetTextAttrib(ColorIndex, FontIndex);
}

 void OCPlotMgt_PlotterDriver::SetTextAttrib(Standard_Integer ColorIndex, Standard_Integer FontIndex, Quantity_PlaneAngle aSlant, Quantity_Factor aHScale, Quantity_Factor aWScale, System::Boolean isUnderlined)
{
  (*((Handle_PlotMgt_PlotterDriver*)nativeHandle))->SetTextAttrib(ColorIndex, FontIndex, aSlant, aHScale, aWScale, OCConverter::BooleanToStandardBoolean(isUnderlined));
}

 void OCPlotMgt_PlotterDriver::SetPolyAttrib(Standard_Integer ColorIndex, Standard_Integer TileIndex, System::Boolean DrawEdge)
{
  (*((Handle_PlotMgt_PlotterDriver*)nativeHandle))->SetPolyAttrib(ColorIndex, TileIndex, OCConverter::BooleanToStandardBoolean(DrawEdge));
}

 void OCPlotMgt_PlotterDriver::SetMarkerAttrib(Standard_Integer ColorIndex, Standard_Integer WidthIndex, System::Boolean FillMarker)
{
  (*((Handle_PlotMgt_PlotterDriver*)nativeHandle))->SetMarkerAttrib(ColorIndex, WidthIndex, OCConverter::BooleanToStandardBoolean(FillMarker));
}

 void OCPlotMgt_PlotterDriver::SetPixelSize(Standard_Real aSize)
{
  (*((Handle_PlotMgt_PlotterDriver*)nativeHandle))->SetPixelSize(aSize);
}

 void OCPlotMgt_PlotterDriver::BeginPolyline(Standard_Integer aNumber)
{
  (*((Handle_PlotMgt_PlotterDriver*)nativeHandle))->BeginPolyline(aNumber);
}

 void OCPlotMgt_PlotterDriver::BeginPolygon(Standard_Integer aNumber)
{
  (*((Handle_PlotMgt_PlotterDriver*)nativeHandle))->BeginPolygon(aNumber);
}

 void OCPlotMgt_PlotterDriver::BeginSegments()
{
  (*((Handle_PlotMgt_PlotterDriver*)nativeHandle))->BeginSegments();
}

 void OCPlotMgt_PlotterDriver::BeginArcs()
{
  (*((Handle_PlotMgt_PlotterDriver*)nativeHandle))->BeginArcs();
}

 void OCPlotMgt_PlotterDriver::BeginPolyArcs()
{
  (*((Handle_PlotMgt_PlotterDriver*)nativeHandle))->BeginPolyArcs();
}

 void OCPlotMgt_PlotterDriver::BeginMarkers()
{
  (*((Handle_PlotMgt_PlotterDriver*)nativeHandle))->BeginMarkers();
}

 void OCPlotMgt_PlotterDriver::BeginPoints()
{
  (*((Handle_PlotMgt_PlotterDriver*)nativeHandle))->BeginPoints();
}

 void OCPlotMgt_PlotterDriver::ClosePrimitive()
{
  (*((Handle_PlotMgt_PlotterDriver*)nativeHandle))->ClosePrimitive();
}

 System::Boolean OCPlotMgt_PlotterDriver::IsKnownImage(OCNaroWrappers::OCStandard_Transient^ anImage)
{
  return OCConverter::StandardBooleanToBoolean((*((Handle_PlotMgt_PlotterDriver*)nativeHandle))->IsKnownImage(*((Handle_Standard_Transient*)anImage->Handle)));
}

 System::Boolean OCPlotMgt_PlotterDriver::SizeOfImageFile(System::String^ anImageFile, Standard_Integer& aWidth, Standard_Integer& aHeight)
{
  return OCConverter::StandardBooleanToBoolean((*((Handle_PlotMgt_PlotterDriver*)nativeHandle))->SizeOfImageFile(OCConverter::StringToStandardCString(anImageFile), aWidth, aHeight));
}

 void OCPlotMgt_PlotterDriver::ClearImage(OCNaroWrappers::OCStandard_Transient^ anImageId)
{
  (*((Handle_PlotMgt_PlotterDriver*)nativeHandle))->ClearImage(*((Handle_Standard_Transient*)anImageId->Handle));
}

 void OCPlotMgt_PlotterDriver::ClearImageFile(System::String^ anImageFile)
{
  (*((Handle_PlotMgt_PlotterDriver*)nativeHandle))->ClearImageFile(OCConverter::StringToStandardCString(anImageFile));
}

 void OCPlotMgt_PlotterDriver::DrawImage(OCNaroWrappers::OCStandard_Transient^ anImageId, Standard_ShortReal aX, Standard_ShortReal aY)
{
  (*((Handle_PlotMgt_PlotterDriver*)nativeHandle))->DrawImage(*((Handle_Standard_Transient*)anImageId->Handle), aX, aY);
}

 void OCPlotMgt_PlotterDriver::DrawImageFile(System::String^ anImageFile, Standard_ShortReal aX, Standard_ShortReal aY, Quantity_Factor aScale)
{
  (*((Handle_PlotMgt_PlotterDriver*)nativeHandle))->DrawImageFile(OCConverter::StringToStandardCString(anImageFile), aX, aY, aScale);
}

 void OCPlotMgt_PlotterDriver::FillAndDrawImage(OCNaroWrappers::OCStandard_Transient^ anImageId, Standard_ShortReal aX, Standard_ShortReal aY, Standard_Integer aWidth, Standard_Integer aHeight, Standard_Address anArrayOfPixels)
{
  (*((Handle_PlotMgt_PlotterDriver*)nativeHandle))->FillAndDrawImage(*((Handle_Standard_Transient*)anImageId->Handle), aX, aY, aWidth, aHeight, anArrayOfPixels);
}

 void OCPlotMgt_PlotterDriver::FillAndDrawImage(OCNaroWrappers::OCStandard_Transient^ anImageId, Standard_ShortReal aX, Standard_ShortReal aY, Standard_Integer anIndexOfLine, Standard_Integer aWidth, Standard_Integer aHeight, Standard_Address anArrayOfPixels)
{
  (*((Handle_PlotMgt_PlotterDriver*)nativeHandle))->FillAndDrawImage(*((Handle_Standard_Transient*)anImageId->Handle), aX, aY, anIndexOfLine, aWidth, aHeight, anArrayOfPixels);
}

 void OCPlotMgt_PlotterDriver::DrawPoint(Standard_ShortReal X, Standard_ShortReal Y)
{
  (*((Handle_PlotMgt_PlotterDriver*)nativeHandle))->DrawPoint(X, Y);
}

 void OCPlotMgt_PlotterDriver::DrawSegment(Standard_ShortReal X1, Standard_ShortReal Y1, Standard_ShortReal X2, Standard_ShortReal Y2)
{
  (*((Handle_PlotMgt_PlotterDriver*)nativeHandle))->DrawSegment(X1, Y1, X2, Y2);
}

 void OCPlotMgt_PlotterDriver::DrawRectangle(Standard_ShortReal aX, Standard_ShortReal aY, Standard_ShortReal aDX, Standard_ShortReal aDY)
{
  (*((Handle_PlotMgt_PlotterDriver*)nativeHandle))->DrawRectangle(aX, aY, aDX, aDY);
}

 void OCPlotMgt_PlotterDriver::DrawPolyline(OCNaroWrappers::OCTShort_Array1OfShortReal^ aListX, OCNaroWrappers::OCTShort_Array1OfShortReal^ aListY)
{
  (*((Handle_PlotMgt_PlotterDriver*)nativeHandle))->DrawPolyline(*((TShort_Array1OfShortReal*)aListX->Handle), *((TShort_Array1OfShortReal*)aListY->Handle));
}

 void OCPlotMgt_PlotterDriver::DrawPolygon(OCNaroWrappers::OCTShort_Array1OfShortReal^ aListX, OCNaroWrappers::OCTShort_Array1OfShortReal^ aListY)
{
  (*((Handle_PlotMgt_PlotterDriver*)nativeHandle))->DrawPolygon(*((TShort_Array1OfShortReal*)aListX->Handle), *((TShort_Array1OfShortReal*)aListY->Handle));
}

 System::Boolean OCPlotMgt_PlotterDriver::DrawArc(Standard_ShortReal X, Standard_ShortReal Y, Standard_ShortReal anXradius, Standard_ShortReal anYradius, Standard_ShortReal aStartAngle, Standard_ShortReal anOpenAngle)
{
  return OCConverter::StandardBooleanToBoolean((*((Handle_PlotMgt_PlotterDriver*)nativeHandle))->DrawArc(X, Y, anXradius, anYradius, aStartAngle, anOpenAngle));
}

 System::Boolean OCPlotMgt_PlotterDriver::DrawPolyArc(Standard_ShortReal X, Standard_ShortReal Y, Standard_ShortReal anXradius, Standard_ShortReal anYradius, Standard_ShortReal aStartAngle, Standard_ShortReal anOpenAngle)
{
  return OCConverter::StandardBooleanToBoolean((*((Handle_PlotMgt_PlotterDriver*)nativeHandle))->DrawPolyArc(X, Y, anXradius, anYradius, aStartAngle, anOpenAngle));
}

 void OCPlotMgt_PlotterDriver::DrawMarker(Standard_Integer aMarker, Standard_ShortReal Xpos, Standard_ShortReal Ypos, Standard_ShortReal Width, Standard_ShortReal Height, Standard_ShortReal Angle)
{
  (*((Handle_PlotMgt_PlotterDriver*)nativeHandle))->DrawMarker(aMarker, Xpos, Ypos, Width, Height, Angle);
}

 void OCPlotMgt_PlotterDriver::DrawText(OCNaroWrappers::OCTCollection_ExtendedString^ aText, Standard_ShortReal Xpos, Standard_ShortReal Ypos, Standard_ShortReal anAngle, OCAspect_TypeOfText aType)
{
  (*((Handle_PlotMgt_PlotterDriver*)nativeHandle))->DrawText(*((TCollection_ExtendedString*)aText->Handle), Xpos, Ypos, anAngle, (Aspect_TypeOfText)aType);
}

 void OCPlotMgt_PlotterDriver::DrawText(System::String^ aText, Standard_ShortReal Xpos, Standard_ShortReal Ypos, Standard_ShortReal anAngle, OCAspect_TypeOfText aType)
{
  (*((Handle_PlotMgt_PlotterDriver*)nativeHandle))->DrawText(OCConverter::StringToStandardCString(aText), Xpos, Ypos, anAngle, (Aspect_TypeOfText)aType);
}

 void OCPlotMgt_PlotterDriver::DrawPolyText(OCNaroWrappers::OCTCollection_ExtendedString^ aText, Standard_ShortReal Xpos, Standard_ShortReal Ypos, Quantity_Ratio aMargin, Standard_ShortReal anAngle, OCAspect_TypeOfText aType)
{
  (*((Handle_PlotMgt_PlotterDriver*)nativeHandle))->DrawPolyText(*((TCollection_ExtendedString*)aText->Handle), Xpos, Ypos, aMargin, anAngle, (Aspect_TypeOfText)aType);
}

 void OCPlotMgt_PlotterDriver::DrawPolyText(System::String^ aText, Standard_ShortReal Xpos, Standard_ShortReal Ypos, Quantity_Ratio aMargin, Standard_ShortReal anAngle, OCAspect_TypeOfText aType)
{
  (*((Handle_PlotMgt_PlotterDriver*)nativeHandle))->DrawPolyText(OCConverter::StringToStandardCString(aText), Xpos, Ypos, aMargin, anAngle, (Aspect_TypeOfText)aType);
}

OCPlotMgt_Plotter^ OCPlotMgt_PlotterDriver::Plotter()
{
  Handle(PlotMgt_Plotter) tmp = (*((Handle_PlotMgt_PlotterDriver*)nativeHandle))->Plotter();
  return gcnew OCPlotMgt_Plotter(&tmp);
}

OCTCollection_AsciiString^ OCPlotMgt_PlotterDriver::PlotFileName()
{
  TCollection_AsciiString* tmp = new TCollection_AsciiString();
  *tmp = (*((Handle_PlotMgt_PlotterDriver*)nativeHandle))->PlotFileName();
  return gcnew OCTCollection_AsciiString(tmp);
}

OCTCollection_AsciiString^ OCPlotMgt_PlotterDriver::DrawingName()
{
  TCollection_AsciiString* tmp = new TCollection_AsciiString();
  *tmp = (*((Handle_PlotMgt_PlotterDriver*)nativeHandle))->DrawingName();
  return gcnew OCTCollection_AsciiString(tmp);
}

OCTCollection_AsciiString^ OCPlotMgt_PlotterDriver::SpoolDirectory()
{
  TCollection_AsciiString* tmp = new TCollection_AsciiString();
  *tmp = (*((Handle_PlotMgt_PlotterDriver*)nativeHandle))->SpoolDirectory();
  return gcnew OCTCollection_AsciiString(tmp);
}

 void OCPlotMgt_PlotterDriver::WorkSpace(Quantity_Length& Width, Quantity_Length& Height)
{
  (*((Handle_PlotMgt_PlotterDriver*)nativeHandle))->WorkSpace(Width, Height);
}

 Quantity_Length OCPlotMgt_PlotterDriver::Convert(Standard_Integer PV)
{
  return (*((Handle_PlotMgt_PlotterDriver*)nativeHandle))->Convert(PV);
}

 Standard_Integer OCPlotMgt_PlotterDriver::Convert(Quantity_Length DV)
{
  return (*((Handle_PlotMgt_PlotterDriver*)nativeHandle))->Convert(DV);
}

 void OCPlotMgt_PlotterDriver::Convert(Standard_Integer PX, Standard_Integer PY, Quantity_Length& DX, Quantity_Length& DY)
{
  (*((Handle_PlotMgt_PlotterDriver*)nativeHandle))->Convert(PX, PY, DX, DY);
}

 void OCPlotMgt_PlotterDriver::Convert(Quantity_Length DX, Quantity_Length DY, Standard_Integer& PX, Standard_Integer& PY)
{
  (*((Handle_PlotMgt_PlotterDriver*)nativeHandle))->Convert(DX, DY, PX, PY);
}

 void OCPlotMgt_PlotterDriver::LineAttrib(Standard_Integer& ColorIndex, Standard_Integer& TypeIndex, Standard_Integer& WidthIndex)
{
  (*((Handle_PlotMgt_PlotterDriver*)nativeHandle))->LineAttrib(ColorIndex, TypeIndex, WidthIndex);
}

 void OCPlotMgt_PlotterDriver::PolyAttrib(Standard_Integer& ColorIndex, Standard_Integer& TileIndex, System::Boolean& EdgeFlag)
{
  (*((Handle_PlotMgt_PlotterDriver*)nativeHandle))->PolyAttrib(ColorIndex, TileIndex, (Standard_Boolean&)(EdgeFlag));
}


