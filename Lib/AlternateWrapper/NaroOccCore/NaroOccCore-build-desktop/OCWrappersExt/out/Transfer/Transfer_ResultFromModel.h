// File generated by CPPExt (Transient)
//
#ifndef _Transfer_ResultFromModel_OCWrappers_HeaderFile
#define _Transfer_ResultFromModel_OCWrappers_HeaderFile

// include the wrapped class
#include <Transfer_ResultFromModel.hxx>
#include "../Converter.h"

#include "../MMgt/MMgt_TShared.h"

#include "../TCollection/TCollection_AsciiString.h"
#include "../Interface/Interface_CheckStatus.h"


namespace OCNaroWrappers
{

ref class OCInterface_InterfaceModel;
ref class OCTransfer_ResultFromTransient;
ref class OCTransfer_TransientProcess;
ref class OCStandard_Transient;
ref class OCTColStd_HSequenceOfTransient;
ref class OCInterface_CheckIterator;


//! ResultFromModel is used to store a final result stored in a <br>
//!           TransientProcess, respectfully to its structuration in scopes <br>
//!           by using a set of ResultFromTransient <br>
//!           Hence, it can be regarded as a passive equivalent of the <br>
//!           stored data in the TransientProcess, while an Iterator gives <br>
//!           a flat view of it. <br>
//! <br>
//!           A ResultFromModel is intended to be attached to the transfer <br>
//!           of one entity (typically root entity but it is not mandatory) <br>
//! <br>
//!           It is then possible to : <br>
//!           - Create and fill a ResultFromModel from a TransientProcess, <br>
//!             by designating a starting entity <br>
//!           - Fill back the TransientProcess from a ResultFromModel, as it <br>
//!             were filled by the operation which filled it the first time <br>
public ref class OCTransfer_ResultFromModel : OCMMgt_TShared {

protected:
  // dummy constructor;
  OCTransfer_ResultFromModel(OCDummy^) : OCMMgt_TShared((OCDummy^)nullptr) {};

public:

// constructor from native
OCTransfer_ResultFromModel(Handle(Transfer_ResultFromModel)* nativeHandle);

// Methods PUBLIC

//! Creates a ResultFromModel, empty <br>
OCTransfer_ResultFromModel();

//! Sets starting Model <br>
 /*instead*/  void SetModel(OCNaroWrappers::OCInterface_InterfaceModel^ model) ;

//! Sets starting File Name <br>
 /*instead*/  void SetFileName(System::String^ filename) ;

//! Returns starting Model (null if not set) <br>
 /*instead*/  OCInterface_InterfaceModel^ Model() ;

//! Returns starting File Name (empty if not set) <br>
 /*instead*/  System::String^ FileName() ;

//! Fills from a TransientProcess, with the result attached to <br>
//!           a starting entity. Considers its Model if it is set. <br>
//!           This action produces a structured set of ResultFromTransient, <br>
//!           considering scopes, starting by that of <ent>. <br>
//!           If <ent> has no recorded result, it remains empty <br>
//!           Returns True if a result is recorded, False else <br>
 /*instead*/  System::Boolean Fill(OCNaroWrappers::OCTransfer_TransientProcess^ TP, OCNaroWrappers::OCStandard_Transient^ ent) ;

//! Clears some data attached to binders used by TransientProcess, <br>
//!           which become useless once the transfer has been done, <br>
//!           by calling Strip on its ResultFromTransient <br>
//! <br>
//!           mode = 0 : minimum, clears data remaining from TransferProcess <br>
//!           mode = 10 : just keeps file name, label, check status ..., <br>
//!             and MainResult but only the result (Binder) <br>
//!           mode = 11 : also clears MainResult (status and names remain) <br>
 /*instead*/  void Strip(Standard_Integer mode) ;

//! Fills back a TransientProcess from the structured set of <br>
//!           binders. Also sets the Model. <br>
 /*instead*/  void FillBack(OCNaroWrappers::OCTransfer_TransientProcess^ TP) ;

//! Returns True if a Result is recorded <br>
 /*instead*/  System::Boolean HasResult() ;

//! Returns the main recorded ResultFromTransient, or a null <br>
 /*instead*/  OCTransfer_ResultFromTransient^ MainResult() ;

//! Sets a new value for the main recorded ResultFromTransient <br>
 /*instead*/  void SetMainResult(OCNaroWrappers::OCTransfer_ResultFromTransient^ amain) ;

//! Returns the label in starting model attached to main entity <br>
//!           (updated by Fill or SetMainResult, if Model is known) <br>
 /*instead*/  System::String^ MainLabel() ;

//! Returns the label in starting model attached to main entity <br>
 /*instead*/  Standard_Integer MainNumber() ;

//! Searches for a key (starting entity) and returns its result <br>
//!           Returns a null handle if not found <br>
 /*instead*/  OCTransfer_ResultFromTransient^ ResultFromKey(OCNaroWrappers::OCStandard_Transient^ start) ;

//! Internal method which returns the list of ResultFromTransient, <br>
//!           according level (2:complete; 1:sub-level 1; 0:main only) <br>
 /*instead*/  OCTColStd_HSequenceOfTransient^ Results(Standard_Integer level) ;

//! Returns the list of recorded starting entities, ending by the <br>
//!           root. Entities with check but no transfer result are ignored <br>
//!           <level> = 2 (D), considers the complete list <br>
//!           <level> = 1      considers the main result plus immediate subs <br>
//!           <level> = 0      just the main result <br>
 /*instead*/  OCTColStd_HSequenceOfTransient^ TransferredList(Standard_Integer level) ;

//! Returns the list of starting entities to which a check status <br>
//!           is attached. <br>
//!           <check> = -2 , all entities whatever the check (see result) <br>
//!           <check> = -1 , entities with no fail (warning allowed) <br>
//!           <check> =  0 , entities with no check at all <br>
//!           <check> =  1 , entities with warning but no fail <br>
//!           <check> =  2 , entities with fail <br>
//!           <result> : if True, only entities with an attached result <br>
//!           Remark : result True and check=0 will give an empty list <br>
 /*instead*/  OCTColStd_HSequenceOfTransient^ CheckedList(OCInterface_CheckStatus check, System::Boolean result) ;

//! Returns the check-list of this set of results <br>
//!           <erronly> true : only fails are considered <br>
//!           <level> = 0 : considers only main binder <br>
//!           <level> = 1 : considers main binder plus immediate subs <br>
//!           <level> = 2 (D) : considers all checks <br>
 /*instead*/  OCInterface_CheckIterator^ CheckList(System::Boolean erronly, Standard_Integer level) ;

//! Returns the check status with corresponds to the content <br>
//!           of this ResultFromModel; considers all levels of transfer <br>
//!           (worst status). Returns CheckAny if not yet computed <br>
//!           Reads it from recorded status if already computed, else <br>
//!           recomputes one <br>
 /*instead*/  OCInterface_CheckStatus CheckStatus() ;

//! Computes and records check status (see CheckStatus) <br>
//!           Does not computes it if already done and <enforce> False <br>
 /*instead*/  OCInterface_CheckStatus ComputeCheckStatus(System::Boolean enforce) ;

~OCTransfer_ResultFromModel()
{
  nativeHandle->Nullify();
  delete nativeHandle;
}

};

}; // OCNaroWrappers

#endif
