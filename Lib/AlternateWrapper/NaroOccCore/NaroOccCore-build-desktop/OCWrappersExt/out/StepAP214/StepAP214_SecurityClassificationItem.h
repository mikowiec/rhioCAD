// File generated by CPPExt (MPV)
//
#ifndef _StepAP214_SecurityClassificationItem_OCWrappers_HeaderFile
#define _StepAP214_SecurityClassificationItem_OCWrappers_HeaderFile

// include native header
#include <StepAP214_SecurityClassificationItem.hxx>
#include "../Converter.h"

#include "StepAP214_ApprovalItem.h"

#include "StepAP214_ApprovalItem.h"


namespace OCNaroWrappers
{




public ref class OCStepAP214_SecurityClassificationItem  : public OCStepAP214_ApprovalItem {

protected:
  // dummy constructor;
  OCStepAP214_SecurityClassificationItem(OCDummy^) : OCStepAP214_ApprovalItem((OCDummy^)nullptr) {};

public:

// constructor from native
OCStepAP214_SecurityClassificationItem(StepAP214_SecurityClassificationItem* nativeHandle);

// Methods PUBLIC

//! Returns a SecurityClassificationItem SelectType <br>
OCStepAP214_SecurityClassificationItem();

~OCStepAP214_SecurityClassificationItem()
{
  delete nativeHandle;
}

};

}; // OCNaroWrappers

#endif
