// File generated by CPPExt (Transient)
//
#ifndef _Graphic2d_Paragraph_OCWrappers_HeaderFile
#define _Graphic2d_Paragraph_OCWrappers_HeaderFile

// include the wrapped class
#include <Graphic2d_Paragraph.hxx>
#include "../Converter.h"

#include "Graphic2d_Primitive.h"

#include "../Aspect/Aspect_CardinalPoints.h"
#include "Graphic2d_TypeOfAlignment.h"
#include "../TColStd/TColStd_SequenceOfExtendedString.h"
#include "../TColStd/TColStd_SequenceOfInteger.h"
#include "../TShort/TShort_SequenceOfShortReal.h"


namespace OCNaroWrappers
{

ref class OCGraphic2d_GraphicObject;
ref class OCTCollection_ExtendedString;
ref class OCGraphic2d_Drawer;


//! The primitive Paragraph <br>
//!	    contains a row column of editable texts <br>
//!	    each text can have a different color and font index. <br>
public ref class OCGraphic2d_Paragraph : OCGraphic2d_Primitive {

protected:
  // dummy constructor;
  OCGraphic2d_Paragraph(OCDummy^) : OCGraphic2d_Primitive((OCDummy^)nullptr) {};

public:

// constructor from native
OCGraphic2d_Paragraph(Handle(Graphic2d_Paragraph)* nativeHandle);

// Methods PUBLIC

//! Creates a paragraph in a graphic object <aGraphicObject> <br>
//!	    The reference point is <X>, <Y>. <br>
//!	    The orientation angle is <anAngle>. <br>
//!	    The offset position of the reference point is <aPosition> <br>
//!	    depending of the size of paragraph. <br>
//!	    The paragraph scale. <br>
//!	    Angles are measured counterclockwise with 0 radian <br>
//!	    at 3 o'clock. <br>
//!  Warning: a paragraph can be orientable.slantable and zoomable <br>
//! only when this options are enable regardless of the graphic driver. <br>
//! i.e: Xw driver does not,but Xdps or PS driver does. <br>
OCGraphic2d_Paragraph(OCNaroWrappers::OCGraphic2d_GraphicObject^ aGraphicObject, Standard_Real X, Standard_Real Y, Quantity_PlaneAngle anAngle, OCAspect_CardinalPoints anOffset, Quantity_Factor aScale);

//! Sets the slant angle of the paragraph <me>. <br>
 /*instead*/  void SetSlant(Quantity_PlaneAngle aSlant) ;

//! Sets the line spacing ratio for the paragraph <me>. <br>
//!	    the spacing height between two lines depends of <br>
//!	    the spacing factor apply on the height of the line currently	--	    writen. <br>
 /*instead*/  void SetSpacing(Quantity_Ratio aSpacing) ;

//! Sets the fixed margin for the paragraph <me>. <br>
 /*instead*/  void SetMargin(Quantity_Length aMargin) ;

//! The paragraph <me> follows the scale factor of the view <br>
//!          if the flag is Standard_True. <br>
 /*instead*/  void SetZoomable(System::Boolean aFlag) ;

//! Sets the frame color index for the paragraph <me>. <br>
//!  Warning: Note that the paragraph frame is drawn only when index <br>
//!	   is > 0. <br>
 /*instead*/  void SetFrameColorIndex(Standard_Integer anIndex) ;

//! Sets the width index for the frame of the paragraph <me>. <br>
//!          default width is 0 (1 pixel out line frame is drawn). <br>
 /*instead*/  void SetFrameWidthIndex(Standard_Integer anIndex) ;

//! Sets the hiding color index for the paragraph <me>. <br>
//!  Warning: Note that the paragraph background is filled only when index <br>
//!	is >= 0. <br>
//!	 A value of 0 permits to drawn the paragraph background with <br>
//!	the current view background color. <br>
 /*instead*/  void SetHidingColorIndex(Standard_Integer anIndex) ;

//! Sets the current color index for the paragraph <me>. <br>
//!  Warning: Note that the index 0 can be undefined as a ColorMapEntry, <br>
//!        in this case the default color is taken. <br>
 /*instead*/  void SetCurrentColorIndex(Standard_Integer anIndex) ;

//! Sets the current font index and scales for the paragraph <me>. <br>
//!  Warning: Note that the index 0 can be undefined as a FontMapEntry , <br>
//!         in this case the default system text font is taken. <br>
 /*instead*/  void SetCurrentFontIndex(Standard_Integer anIndex, Quantity_Length aHScale, Quantity_Length aWScale) ;

//! Sets the current text alignment for the paragraph <me>. <br>
 /*instead*/  void SetCurrentAlignment(OCGraphic2d_TypeOfAlignment anAlignment) ;

//! Sets the current text underline flag for the paragraph <me>. <br>
 /*instead*/  void SetCurrentUnderline(System::Boolean isUnderlined) ;

//! Adds a text at a row-column position in the paragraph <me> <br>
//! with the current Color,Font,Alignment attributes <br>
//! at the position <aColumn,aRow> if <aColumn> and <aRow> are > 0 <br>
//!  or at the end of the line if <aColumn> is 0, <br>
//!  or at the end of the paragraph if <aRow> is 0. <br>
 /*instead*/  void AddText(OCNaroWrappers::OCTCollection_ExtendedString^ aText, Standard_Integer aRow, Standard_Integer aColumn) ;

//! Changes a text in the paragraph at a row-column position, <br>
//!	    don't change the attributes of the text. <br>
//!  Warning: May do nothing if the row-column don't exist in the <br>
//!	   paragraph. <br>
 /*instead*/  void ChangeText(OCNaroWrappers::OCTCollection_ExtendedString^ aText, Standard_Integer aRow, Standard_Integer aColumn) ;

//! Clear ALL the text in the paragraph <me>. <br>
 /*instead*/  void Clear() ;

//! Returns Standard_True if the Paragraph <me> follows <br>
//!          the scale factor of the view. <br>
 /*instead*/  System::Boolean IsZoomable() ;

//! Returns the size of the paragraph <me> . <br>
 /*instead*/  void Size(Quantity_Length& aWidth, Quantity_Length& aHeight) ;

//! Returns the paragraph position. <br>
 /*instead*/  void Position(Quantity_Length& X, Quantity_Length& Y) ;

//! Returns the paragraph Offset. <br>
 /*instead*/  OCAspect_CardinalPoints Offset(Quantity_Length& Dx, Quantity_Length& Dy) ;

//! Returns the paragraph orientation. <br>
 /*instead*/  Quantity_PlaneAngle Angle() ;

//! Returns the paragraph slant. <br>
 /*instead*/  Quantity_PlaneAngle Slant() ;

//! Returns the paragraph spacing ratio. <br>
 /*instead*/  Quantity_Ratio Spacing() ;

//! Returns the paragraph margin value. <br>
 /*instead*/  Quantity_Length Margin() ;

//! Returns the paragraph hiding color index. <br>
 /*instead*/  Standard_Integer HidingColorIndex() ;

//! Returns the paragraph frame color index. <br>
 /*instead*/  Standard_Integer FrameColorIndex() ;

//! Returns the paragraph frame width index. <br>
 /*instead*/  Standard_Integer FrameWidthIndex() ;

//! Returns the text string and attributes of rank <aRank>. <br>
 /*instead*/  OCTCollection_ExtendedString^ Text(Standard_Integer aRank, Standard_Integer& aRow, Standard_Integer& aColumn, Standard_Integer& aColorIndex, Standard_Integer& aFontIndex, OCGraphic2d_TypeOfAlignment& anAlignment) ;

//! Returns Standard_True if the current Driver used is enabled <br>
//!         to get the right size and offsets in the <br>
//!         world size parameter <aWidth>,<aHeight>,<anXoffset>,<anYoffset> <br>
//!         depending of the attributes of the paragraph text position <br>
//!	    <aRank> and the current scale of the view. <br>
//!          NOTE that the text offsets defines the relative position of the <br>
//!         of the text string origin from the lower left corner of the text <br>
//!         boundary limits. <br>
 /*instead*/  System::Boolean TextSize(Standard_Integer aRank, Quantity_Length& aWidth, Quantity_Length& aHeight, Quantity_Length& anXoffset, Quantity_Length& anYoffset) ;

//! Returns the number of Text of the paragraph <me>. <br>
 /*instead*/  Standard_Integer Length() ;

//! Returns the number of Row of the paragraph <me>. <br>
 /*instead*/  Standard_Integer MaxRow() ;

//! Returns the number of Column of the paragraph <me>. <br>
 /*instead*/  Standard_Integer MaxColumn() ;

//! Computes the MinMax of the paragraph if possible. <br>
virtual /*instead*/  System::Boolean ComputeMinMax() override;


virtual /*instead*/  void Save(Aspect_FStream& aFStream) ;

~OCGraphic2d_Paragraph()
{
  nativeHandle->Nullify();
  delete nativeHandle;
}

};

}; // OCNaroWrappers

#endif
