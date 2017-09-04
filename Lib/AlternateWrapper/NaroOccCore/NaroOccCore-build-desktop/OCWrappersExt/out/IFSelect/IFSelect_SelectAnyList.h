// File generated by CPPExt (Transient)
//
#ifndef _IFSelect_SelectAnyList_OCWrappers_HeaderFile
#define _IFSelect_SelectAnyList_OCWrappers_HeaderFile

// include the wrapped class
#include <IFSelect_SelectAnyList.hxx>
#include "../Converter.h"

#include "IFSelect_SelectDeduct.h"



namespace OCNaroWrappers
{

ref class OCIFSelect_IntParam;
ref class OCInterface_EntityIterator;
ref class OCStandard_Transient;
ref class OCInterface_Graph;
ref class OCTCollection_AsciiString;


//! A SelectAnyList kind Selection selects a List of an Entity, as <br>
//!           well as this Entity contains some. A List contains sub-entities <br>
//!           as one per Item, or several (for instance if an Entity binds <br>
//!           couples of sub-entities, each item is one of these couples). <br>
//!           Remark that only Entities are taken into account (neither <br>
//!           Reals, nor Strings, etc...) <br>
//! <br>
//!           To define the list on which to work, SelectAnyList has two <br>
//!           deferred methods : NbItems (which gives the length of the <br>
//!           list), FillResult (which fills an EntityIterator). They are <br>
//!           intended to get a List in an Entity of the required Type (and <br>
//!           consider that list is empty if Entity has not required Type) <br>
//! <br>
//!           In addition, remark that some types of Entity define more than <br>
//!           one list in each instance : a given sub-class of SelectAnyList <br>
//!           must be attached to one list <br>
//! <br>
//!           SelectAnyList keeps or rejects a sub-set of the list, <br>
//!           that is the Items of which rank in the list is in a given <br>
//!           range (for instance form 2nd to 6th, etc...) <br>
//!           Range is defined by two Integer values. In order to allow <br>
//!           external control of them, these values are not directly <br>
//!           defined as fields, but accessed through IntParams, that is, <br>
//!           referenced as Transient (Handle) objects <br>
public ref class OCIFSelect_SelectAnyList : OCIFSelect_SelectDeduct {

protected:
  // dummy constructor;
  OCIFSelect_SelectAnyList(OCDummy^) : OCIFSelect_SelectDeduct((OCDummy^)nullptr) {};

public:

// constructor from native
OCIFSelect_SelectAnyList(Handle(IFSelect_SelectAnyList)* nativeHandle);

// Methods PUBLIC

//! Sets a Range for numbers, with a lower and a upper limits <br>
 /*instead*/  void SetRange(OCNaroWrappers::OCIFSelect_IntParam^ rankfrom, OCNaroWrappers::OCIFSelect_IntParam^ rankto) ;

//! Sets a unique number (only one Entity will be sorted as True) <br>
 /*instead*/  void SetOne(OCNaroWrappers::OCIFSelect_IntParam^ rank) ;

//! Sets a Lower limit but no upper limit <br>
 /*instead*/  void SetFrom(OCNaroWrappers::OCIFSelect_IntParam^ rankfrom) ;

//! Sets an Upper limit but no lower limit (equivalent to lower 1) <br>
 /*instead*/  void SetUntil(OCNaroWrappers::OCIFSelect_IntParam^ rankto) ;

//! Returns True if a Lower limit is defined <br>
 /*instead*/  System::Boolean HasLower() ;

//! Returns Lower limit (if there is; else, value is senseless) <br>
 /*instead*/  OCIFSelect_IntParam^ Lower() ;

//! Returns Integer Value of Lower Limit (0 if none) <br>
 /*instead*/  Standard_Integer LowerValue() ;

//! Returns True if a Lower limit is defined <br>
 /*instead*/  System::Boolean HasUpper() ;

//! Returns Upper limit (if there is; else, value is senseless) <br>
 /*instead*/  OCIFSelect_IntParam^ Upper() ;

//! Returns Integer Value of Upper Limit (0 if none) <br>
 /*instead*/  Standard_Integer UpperValue() ;

//! Returns the list of selected entities (list of entities <br>
//!           complying with rank criterium) <br>
//!           Error if the input list has more than one Item <br>
 /*instead*/  OCInterface_EntityIterator^ RootResult(OCNaroWrappers::OCInterface_Graph^ G) ;

//! Returns a text defining the criterium : "Componants of List " <br>
//!           then Specific List Label, then, following cases : <br>
//!           " From .. Until .." or "From .." or "Until .." or "Rank no .." <br>
//!           Specific type is given by deferred method ListLabel <br>
 /*instead*/  OCTCollection_AsciiString^ Label() ;

~OCIFSelect_SelectAnyList()
{
  nativeHandle->Nullify();
  delete nativeHandle;
}

};

}; // OCNaroWrappers

#endif
