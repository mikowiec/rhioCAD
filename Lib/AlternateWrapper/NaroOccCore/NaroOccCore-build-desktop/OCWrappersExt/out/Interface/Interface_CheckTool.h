// File generated by CPPExt (MPV)
//
#ifndef _Interface_CheckTool_OCWrappers_HeaderFile
#define _Interface_CheckTool_OCWrappers_HeaderFile

// include native header
#include <Interface_CheckTool.hxx>
#include "../Converter.h"


#include "Interface_ShareTool.h"


namespace OCNaroWrappers
{

ref class OCInterface_GTool;
ref class OCInterface_InterfaceModel;
ref class OCInterface_Protocol;
ref class OCInterface_Graph;
ref class OCInterface_HGraph;
ref class OCStandard_Transient;
ref class OCInterface_ShareTool;
ref class OCInterface_Check;
ref class OCMessage_Messenger;
ref class OCInterface_CheckIterator;
ref class OCInterface_EntityIterator;


//! Performs Checks on Entities, using General Service Library and <br>
//!           Modules to work. Works on one Entity or on a complete Model <br>
public ref class OCInterface_CheckTool  {

protected:
  Interface_CheckTool* nativeHandle;
  OCInterface_CheckTool(OCDummy^) {};

public:
  property Interface_CheckTool* Handle
  {
    Interface_CheckTool* get()
    {
      return nativeHandle;
    }
  }


// constructor from native
OCInterface_CheckTool(Interface_CheckTool* nativeHandle);

// Methods PUBLIC

//! Creates a CheckTool, by calling the General Service Library <br>
//!           and Modules, selected through a Protocol, to work on a Model <br>
//!           Moreover, Protocol recognizes Unknown Entities <br>
OCInterface_CheckTool(OCNaroWrappers::OCInterface_InterfaceModel^ model, OCNaroWrappers::OCInterface_Protocol^ protocol);

//! Creates a CheckTool, by calling the General Service Library <br>
//!           and Modules, selected through a Protocol, to work on a Model <br>
//!           Protocol and so on are taken from the Model (its GTool) <br>
OCInterface_CheckTool(OCNaroWrappers::OCInterface_InterfaceModel^ model);

//! Creates a CheckTool from a Graph. The Graph contains a Model <br>
//!           which designates a Protocol: they are used to create ShareTool <br>
OCInterface_CheckTool(OCNaroWrappers::OCInterface_Graph^ graph);


OCInterface_CheckTool(OCNaroWrappers::OCInterface_HGraph^ hgraph);

//! Fills as required a Check with the Error and Warning messages <br>
//!           produced by Checking a given Entity. <br>
//!           For an Erroneous or Corrected Entity : Check build at Analyse <br>
//!           time; else, Check computed for Entity (Verify integrity), can <br>
//!           use a Graph as required to control context <br>
 /*instead*/  void FillCheck(OCNaroWrappers::OCStandard_Transient^ ent, OCNaroWrappers::OCInterface_ShareTool^ sh, OCNaroWrappers::OCInterface_Check^ ach) ;

//! Utility method which Prints the content of a Check <br>
 /*instead*/  void Print(OCNaroWrappers::OCInterface_Check^ ach, OCNaroWrappers::OCMessage_Messenger^ S) ;

//! Simply Lists all the Checks and the Content (messages) and the <br>
//!           Entity, if there is, of each Check <br>
//!           (if all Checks are OK, nothing is Printed) <br>
 /*instead*/  void Print(OCNaroWrappers::OCInterface_CheckIterator^ list, OCNaroWrappers::OCMessage_Messenger^ S) ;

//! Returns the Check associated to an Entity identified by <br>
//!           its Number in a Model. <br>
 /*instead*/  OCInterface_Check^ Check(Standard_Integer num) ;

//! Checks if any Error has been detected (CheckList not empty) <br>
//!           Returns normally if none, raises exception if some exists. <br>
//!           It reuses the last computations from other checking methods, <br>
//!           unless the argument <resest> is given True <br>
 /*instead*/  void CheckSuccess(System::Boolean reset) ;

//! Returns list of all "remarkable" informations, which include : <br>
//!           - GlobalCheck, if not empty <br>
//!           - Error Checks, for all Errors (Verify + Analyse) <br>
//!           - also Corrected Entities <br>
//!           - and Unknown Entities : for those, each Unknown Entity is <br>
//!             associated to an empty Check (it is neither an Error nor a <br>
//!             Correction, but a remarkable information) <br>
 /*instead*/  OCInterface_CheckIterator^ CompleteCheckList() ;

//! Returns list of all Errors detected <br>
//!           Note that presence of Unknown Entities is not an error <br>
//!           Cumulates : GlobalCheck if error + <br>
//!             AnalyseCheckList + VerifyCheckList <br>
 /*instead*/  OCInterface_CheckIterator^ CheckList() ;

//! Returns list of errors dectected at Analyse time (syntactic) <br>
//!           (note that GlobalCheck is not in this list) <br>
 /*instead*/  OCInterface_CheckIterator^ AnalyseCheckList() ;

//! Returns list of integrity constraints errors (semantic) <br>
//!           (note that GlobalCheck is not in this list) <br>
 /*instead*/  OCInterface_CheckIterator^ VerifyCheckList() ;

//! Returns list of Corrections (includes GlobalCheck if corrected) <br>
 /*instead*/  OCInterface_CheckIterator^ WarningCheckList() ;

//! Returns list of Unknown Entities <br>
//!           Note that Error and Erroneous Entities are not considered <br>
//!           as Unknown <br>
 /*instead*/  OCInterface_EntityIterator^ UnknownEntities() ;

~OCInterface_CheckTool()
{
  delete nativeHandle;
}

};

}; // OCNaroWrappers

#endif
