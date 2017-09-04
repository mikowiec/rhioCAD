// File generated by CPPExt (Transient)
//
#ifndef _SelectMgr_Selection_OCWrappers_HeaderFile
#define _SelectMgr_Selection_OCWrappers_HeaderFile

// include the wrapped class
#include <SelectMgr_Selection.hxx>
#include "../Converter.h"

#include "../MMgt/MMgt_TShared.h"

#include "../SelectBasics/SelectBasics_ListOfSensitive.h"
#include "../SelectBasics/SelectBasics_ListIteratorOfListOfSensitive.h"
#include "SelectMgr_TypeOfUpdate.h"


namespace OCNaroWrappers
{

ref class OCSelectBasics_SensitiveEntity;


//!  Represents the state of a given selection mode for a <br>
//! Selectable Object. Contains all the sensitive entities available for this mode. <br>
//! An interactive object can have an indefinite number of <br>
//! modes of selection, each representing a <br>
//! "decomposition" into sensitive primitives; each <br>
//! primitive has an Owner (SelectMgr_EntityOwner) <br>
//! which allows us to identify the exact entity which has <br>
//! been detected. Each Selection mode is identified by <br>
//! an index. The set of sensitive primitives which <br>
//! correspond to a given mode is stocked in a <br>
//! SelectMgr_Selection object. By Convention, the <br>
//! default selection mode which allows us to grasp the <br>
//! Interactive object in its entirety will be mode 0. <br>
//! AIS_Trihedron : 4 selection modes <br>
//! -   mode 0 : selection of a trihedron <br>
//! -   mode 1 : selection of the origin of the trihedron <br>
//! -   mode 2 : selection of the axes <br>
//! -   mode 3 : selection of the planes XOY, YOZ, XOZ <br>
//! when you activate one of modes 1 2 3 4 , you pick AIS objects of type: <br>
//! -   AIS_Point <br>
//! -   AIS_Axis (and information on the type of axis) <br>
//! -   AIS_Plane (and information on the type of plane). <br>
//!   AIS_PlaneTrihedron offers 3 selection modes: <br>
//! -   mode 0 : selection of the whole trihedron <br>
//! -   mode 1 : selection of the origin of the trihedron <br>
//! -   mode 2 : selection of the axes - same remarks as for the Trihedron. <br>
//! AIS_Shape : 7 maximum selection modes, depending <br>
//! on the complexity of the shape : <br>
//! -   mode 0 : selection of the AIS_Shape <br>
//! -   mode 1 : selection of the vertices <br>
//! -   mode 2 : selection of the edges <br>
//! -   mode 3 : selection of the wires <br>
//! -   mode 4 : selection of the faces <br>
//! -   mode 5 : selection of the shells <br>
//! -   mode 6 :   selection of the constituent solids. <br>
public ref class OCSelectMgr_Selection : OCMMgt_TShared {

protected:
  // dummy constructor;
  OCSelectMgr_Selection(OCDummy^) : OCMMgt_TShared((OCDummy^)nullptr) {};

public:

// constructor from native
OCSelectMgr_Selection(Handle(SelectMgr_Selection)* nativeHandle);

// Methods PUBLIC

//! Constructs a selection object defined by the selection mode IdMode. <br>
//! The default setting 0 is the selection mode for a shape in its entirety. <br>
OCSelectMgr_Selection(Standard_Integer IdMode);

//! Adds the sensitive primitive aprimitive to the list of <br>
//! stored entities in this object. <br>
//! Raises NullObject if the primitive is a null handle. <br>
 /*instead*/  void Add(OCNaroWrappers::OCSelectBasics_SensitiveEntity^ aprimitive) ;

//! empties the selection from all the stored entities <br>
 /*instead*/  void Clear() ;

//! returns true if no sensitive entity is stored. <br>
 /*instead*/  System::Boolean IsEmpty() ;

//! returns the selection mode represented by this selection <br>
 /*instead*/  Standard_Integer Mode() ;

//! Begins an iteration scanning for sensitive primitives. <br>
 /*instead*/  void Init() ;

//! Continues the iteration scanning for sensitive <br>
//! primitives with the mode defined in this framework. <br>
 /*instead*/  System::Boolean More() ;

//! Returns the next sensitive primitive found in the <br>
//! iteration. This is a scan for entities with the mode <br>
//! defined in this framework. <br>
 /*instead*/  void Next() ;

//! Returns any sensitive primitive in this framework. <br>
 /*instead*/  OCSelectBasics_SensitiveEntity^ Sensitive() ;

//! Returns the flag UpdateFlag. <br>
//! This flage gives the update status of this framework <br>
//! in a ViewerSelector object: <br>
//! -   full <br>
//! -   partial, or <br>
//! -   none. <br>
 /*instead*/  OCSelectMgr_TypeOfUpdate UpdateStatus() ;


 /*instead*/  void UpdateStatus(OCSelectMgr_TypeOfUpdate UpdateFlag) ;

~OCSelectMgr_Selection()
{
  nativeHandle->Nullify();
  delete nativeHandle;
}

};

}; // OCNaroWrappers

#endif
