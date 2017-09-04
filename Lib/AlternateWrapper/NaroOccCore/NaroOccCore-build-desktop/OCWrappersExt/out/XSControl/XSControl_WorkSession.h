// File generated by CPPExt (Transient)
//
#ifndef _XSControl_WorkSession_OCWrappers_HeaderFile
#define _XSControl_WorkSession_OCWrappers_HeaderFile

// include the wrapped class
#include <XSControl_WorkSession.hxx>
#include "../Converter.h"

#include "../IFSelect/IFSelect_WorkSession.h"

#include "../IFSelect/IFSelect_ReturnStatus.h"


namespace OCNaroWrappers
{

ref class OCXSControl_Controller;
ref class OCXSControl_TransferReader;
ref class OCXSControl_TransferWriter;
ref class OCDico_DictionaryOfTransient;
ref class OCXSControl_Vars;
ref class OCMessage_Messenger;
ref class OCTransfer_TransientProcess;
ref class OCStandard_Transient;
ref class OCInterface_InterfaceModel;
ref class OCTransfer_FinderProcess;
ref class OCTopoDS_Shape;
ref class OCInterface_CheckIterator;


//! This WorkSession completes the basic one, by adding : <br>
//!           - use of Controller, with norm selection... <br>
//!           - management of transfers (both ways) with auxiliary classes <br>
//!             TransferReader and TransferWriter <br>
//!            -> these transfers may work with a Context List : its items <br>
//!               are given by the user, according to the transfer to be <br>
//!               i.e. it is interpreted by the Actors <br>
//!               Each item is accessed by a Name <br>
public ref class OCXSControl_WorkSession : OCIFSelect_WorkSession {

protected:
  // dummy constructor;
  OCXSControl_WorkSession(OCDummy^) : OCIFSelect_WorkSession((OCDummy^)nullptr) {};

public:

// constructor from native
OCXSControl_WorkSession(Handle(XSControl_WorkSession)* nativeHandle);

// Methods PUBLIC


OCXSControl_WorkSession();

//! In addition to basic ClearData, clears Transfer and Management <br>
//!           for interactive use, for mode = 0,1,2 and over 4 <br>
//!           Plus : mode = 5 to clear Transfers (both ways) only <br>
//!                  mode = 6 to clear enforced results <br>
//!                  mode = 7 to clear transfers, results <br>
virtual /*instead*/  void ClearData(Standard_Integer mode) override;

//! Selects a Norm defined by its name. <br>
//!           A Norm is described and handled by a Controller <br>
//!           Returns True if done, False if <normname> is unknown <br>
//! <br>
//!           A Profile may be set too. If no Profile is provided, the <br>
//!           current Profile for this Norm is taken <br>
//!           If the asked Profile is not defined for this Norm, it remains <br>
//!           in current Profile, returned value is True <br>
 /*instead*/  System::Boolean SelectNorm(System::String^ normname, System::String^ profile) ;

//! Sets a Profile as current for the current Norm <br>
//!           Returns True if done, False if <profile> is unknown for this norm <br>
//! <br>
//!           For more infos on Profile, query the Profile of the Controller <br>
 /*instead*/  System::Boolean SelectProfile(System::String^ profile) ;

//! Selects a Norm defined by its Controller itself <br>
 /*instead*/  void SetController(OCNaroWrappers::OCXSControl_Controller^ ctl) ;

//! This method is called once a new norm has been successfully <br>
//!           selected. It can be redefined, default does nothing <br>
virtual /*instead*/  void AdaptNorm() ;

//! Returns the name of the last Selected Norm. If none is <br>
//!           defined, returns an empty string <br>
//!           By default, returns the complete name of the norm <br>
//!           If <rsc> is True, returns the short name used for resource <br>
 /*instead*/  System::String^ SelectedNorm(System::Boolean rsc) ;

//! Returns the norm controller itself <br>
 /*instead*/  OCXSControl_Controller^ NormAdaptor() ;

//! Returns the current Context List, Null if not defined <br>
//!           The Context is given to the TransientProcess for TransferRead <br>
 /*instead*/  OCDico_DictionaryOfTransient^ Context() ;

//! Sets the current Context List, as a whole <br>
//!           Sets it to the TransferReader <br>
 /*instead*/  void SetAllContext(OCNaroWrappers::OCDico_DictionaryOfTransient^ context) ;

//! Clears the whole current Context (nullifies it) <br>
 /*instead*/  void ClearContext() ;

//! Prints the transfer status of a transferred item, as beeing <br>
//!           the Mapped n0 <num>, from MapWriter if <wri> is True, or <br>
//!           from MapReader if <wri> is False <br>
//!           Returns True when done, False else (i.e. num out of range) <br>
 /*instead*/  System::Boolean PrintTransferStatus(Standard_Integer num, System::Boolean wri, OCNaroWrappers::OCMessage_Messenger^ S) ;

//! Sets a Transfer Reader, by internal ways, according mode : <br>
//!           0 recreates it clear,  1 clears it (does not recreate) <br>
//!           2 aligns Roots of TransientProcess from final Results <br>
//!           3 aligns final Results from Roots of TransientProcess <br>
//!           4 begins a new transfer (by BeginTransfer) <br>
//!           5 recreates TransferReader then begins a new transfer <br>
 /*instead*/  void InitTransferReader(Standard_Integer mode) ;

//! Sets a Transfer Reader, which manages transfers on reading <br>
 /*instead*/  void SetTransferReader(OCNaroWrappers::OCXSControl_TransferReader^ TR) ;

//! Returns the Transfer Reader, Null if not set <br>
 /*instead*/  OCXSControl_TransferReader^ TransferReader() ;

//! Returns the TransientProcess(internal data for TransferReader) <br>
 /*instead*/  OCTransfer_TransientProcess^ MapReader() ;

//! Changes the Map Reader, i.e. considers that the new one <br>
//!           defines the relevant read results (forgets the former ones) <br>
//!           Returns True when done, False in case of bad definition, i.e. <br>
//!           if Model from TP differs from that of Session <br>
 /*instead*/  System::Boolean SetMapReader(OCNaroWrappers::OCTransfer_TransientProcess^ TP) ;

//! Returns the result attached to a starting entity <br>
//!           If <mode> = 0, returns Final Result <br>
//!           If <mode> = 1, considers Last Result <br>
//!           If <mode> = 2, considers Final, else if absent, Last <br>
//!             returns it as Transient, if result is not transient returns <br>
//!             the Binder <br>
//!           <mode> = 10,11,12 idem but returns the Binder itself <br>
//!             (if it is not, e.g. Shape, returns the Binder) <br>
//!           <mode> = 20, returns the ResultFromModel <br>
 /*instead*/  OCStandard_Transient^ Result(OCNaroWrappers::OCStandard_Transient^ ent, Standard_Integer mode) ;

//! Commands the transfer of, either one entity, or a list <br>
//!           I.E. calls the TransferReader after having analysed <ents> <br>
//!           It is cumulated from the last BeginTransfer <br>
//!           <ents> is processed by GiveList, hence : <br>
//!           - <ents> a Selection : its SelectionResult <br>
//!           - <ents> a HSequenceOfTransient : this list <br>
//!           - <ents> the Model : in this specific case, all the roots, <br>
//!             with no cumulation of former transfers (TransferReadRoots) <br>
 /*instead*/  Standard_Integer TransferReadOne(OCNaroWrappers::OCStandard_Transient^ ents) ;

//! Commands the transfer of all the root entities of the model <br>
//!           i.e. calls TransferRoot from the TransferReader with the Graph <br>
//!           No cumulation with former calls to TransferReadOne <br>
 /*instead*/  Standard_Integer TransferReadRoots() ;

//! produces and returns a new Model well conditionned <br>
//!           It is produced by the Norm Controller <br>
//!           It can be Null (if this function is not implemented) <br>
 /*instead*/  OCInterface_InterfaceModel^ NewModel() ;

//! Returns the Transfer Reader, Null if not set <br>
 /*instead*/  OCXSControl_TransferWriter^ TransferWriter() ;

//! Returns the FinderProcess (internal data for TransferWriter) <br>
 /*instead*/  OCTransfer_FinderProcess^ MapWriter() ;

//! Changes the Map Reader, i.e. considers that the new one <br>
//!           defines the relevant read results (forgets the former ones) <br>
//!           Returns True when done, False if <FP> is Null <br>
 /*instead*/  System::Boolean SetMapWriter(OCNaroWrappers::OCTransfer_FinderProcess^ FP) ;

//! Sets a mode to transfer Shapes from CasCade to entities of the <br>
//!           current norm, which interprets it (see various Controllers) <br>
//!           This call form could be later replaced by a more general one <br>
 /*instead*/  void SetModeWriteShape(Standard_Integer mode) ;

//! Records the current Mode to Write Shapes <br>
 /*instead*/  Standard_Integer ModeWriteShape() ;

//! Transfers a Shape from CasCade to a model of current norm, <br>
//!           according to the last call to SetModeWriteShape <br>
//!           Returns status :Done if OK, Fail if error during transfer, <br>
//!             Error if transfer badly initialised <br>
 /*instead*/  OCIFSelect_ReturnStatus TransferWriteShape(OCNaroWrappers::OCTopoDS_Shape^ shape, System::Boolean compgraph) ;

//! Returns the check-list of last transfer (write) <br>
//!           It is recorded in the FinderProcess, but it must be bound with <br>
//!           resulting entities (in the resulting file model) rather than <br>
//!           with original objects (in fact, their mappers) <br>
 /*instead*/  OCInterface_CheckIterator^ TransferWriteCheckList() ;


 /*instead*/  OCXSControl_Vars^ Vars() ;


 /*instead*/  void SetVars(OCNaroWrappers::OCXSControl_Vars^ newvars) ;

//! Clears binders <br>
 /*instead*/  void ClearBinders() ;

~OCXSControl_WorkSession()
{
  nativeHandle->Nullify();
  delete nativeHandle;
}

};

}; // OCNaroWrappers

#endif
