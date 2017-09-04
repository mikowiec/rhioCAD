// File generated by CPPExt (MPV)
//
#ifndef _StepBasic_ProductOrFormationOrDefinition_OCWrappers_HeaderFile
#define _StepBasic_ProductOrFormationOrDefinition_OCWrappers_HeaderFile

// include native header
#include <StepBasic_ProductOrFormationOrDefinition.hxx>
#include "../Converter.h"




namespace OCNaroWrappers
{

ref class OCStandard_Transient;
ref class OCStepBasic_Product;
ref class OCStepBasic_ProductDefinitionFormation;
ref class OCStepBasic_ProductDefinition;


//! Representation of STEP SELECT type ProductOrFormationOrDefinition <br>
public ref class OCStepBasic_ProductOrFormationOrDefinition  {

protected:
  StepBasic_ProductOrFormationOrDefinition* nativeHandle;
  OCStepBasic_ProductOrFormationOrDefinition(OCDummy^) {};

public:
  property StepBasic_ProductOrFormationOrDefinition* Handle
  {
    StepBasic_ProductOrFormationOrDefinition* get()
    {
      return nativeHandle;
    }
  }


// constructor from native
OCStepBasic_ProductOrFormationOrDefinition(StepBasic_ProductOrFormationOrDefinition* nativeHandle);

// Methods PUBLIC

//! Empty constructor <br>
OCStepBasic_ProductOrFormationOrDefinition();

//! Recognizes a kind of ProductOrFormationOrDefinition select type <br>
//!          1 -> Product from StepBasic <br>
//!          2 -> ProductDefinitionFormation from StepBasic <br>
//!          3 -> ProductDefinition from StepBasic <br>
//!          0 else <br>
 /*instead*/  Standard_Integer CaseNum(OCNaroWrappers::OCStandard_Transient^ ent) ;

//! Returns Value as Product (or Null if another type) <br>
 /*instead*/  OCStepBasic_Product^ Product() ;

//! Returns Value as ProductDefinitionFormation (or Null if another type) <br>
 /*instead*/  OCStepBasic_ProductDefinitionFormation^ ProductDefinitionFormation() ;

//! Returns Value as ProductDefinition (or Null if another type) <br>
 /*instead*/  OCStepBasic_ProductDefinition^ ProductDefinition() ;

~OCStepBasic_ProductOrFormationOrDefinition()
{
  delete nativeHandle;
}

};

}; // OCNaroWrappers

#endif
