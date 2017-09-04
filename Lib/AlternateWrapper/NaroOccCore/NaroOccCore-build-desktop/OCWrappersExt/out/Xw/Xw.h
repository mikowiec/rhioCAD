// File generated by CPPExt (Package)
//

#ifndef _Xw_OCWrappers_HeaderFile
#define _Xw_OCWrappers_HeaderFile

// Include the wrapped header
#include <Xw.hxx>

#include "Xw_Driver.h"
#include "Xw_Window.h"
#include "Xw_ColorMap.h"
#include "Xw_TypeMap.h"
#include "Xw_WidthMap.h"
#include "Xw_FontMap.h"
#include "Xw_MarkMap.h"
#include "Xw_GraphicDevice.h"
#include "Xw_IconBox.h"
#include "Xw_TextManager.h"
#include "Xw_ListOfMFTFonts.h"
#include "Xw_HListOfMFTFonts.h"


namespace OCNaroWrappers
{
//! This package contains the common X graphic interface. <br>
//!  Warning: All the interface is described by a set of C routines. <br>
//!          All these C routines are stored in the library <br>
//!          of this package. <br>
public ref class OCXw abstract sealed
{

public:
// Methods

//! Global Trace Level for Maintenance Only <br>
static /*instead*/  void SetTrace(Standard_Integer TraceLevel, Standard_Integer ErrorLevel) ;


};

}; // OCNaroWrappers

#endif