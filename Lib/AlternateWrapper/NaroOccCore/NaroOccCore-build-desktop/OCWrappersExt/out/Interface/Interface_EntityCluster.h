// File generated by CPPExt (Transient)
//
#ifndef _Interface_EntityCluster_OCWrappers_HeaderFile
#define _Interface_EntityCluster_OCWrappers_HeaderFile

// include the wrapped class
#include <Interface_EntityCluster.hxx>
#include "../Converter.h"

#include "../MMgt/MMgt_TShared.h"



namespace OCNaroWrappers
{

ref class OCStandard_Transient;
ref class OCInterface_EntityList;
ref class OCInterface_EntityIterator;


//! Auxiliary class for EntityList. An EntityList designates an <br>
//!           EntityCluster, which brings itself an fixed maximum count of <br>
//!           Entities. If it is full, it gives access to another cluster <br>
//!           ("Next"). This class is intended to give a good compromise <br>
//!           between access time (faster than a Sequence, good for little <br>
//!           count) and memory use (better than a Sequence in any case, <br>
//!           overall for little count, better than an Array for a very <br>
//!           little count. It is designed for a light management. <br>
//!           Remark that a new Item may not be Null, because this is the <br>
//!           criterium used for "End of List" <br>
public ref class OCInterface_EntityCluster : OCMMgt_TShared {

protected:
  // dummy constructor;
  OCInterface_EntityCluster(OCDummy^) : OCMMgt_TShared((OCDummy^)nullptr) {};

public:

// constructor from native
OCInterface_EntityCluster(Handle(Interface_EntityCluster)* nativeHandle);

// Methods PUBLIC

//! Creates an empty, non-chained, EntityCluster <br>
OCInterface_EntityCluster();

//! Creates a non-chained EntityCluster, filled with one Entity <br>
OCInterface_EntityCluster(OCNaroWrappers::OCStandard_Transient^ ent);

//! Creates an empty EntityCluster, chained with another one <br>
//!           (that is, put BEFORE this other one in the list) <br>
OCInterface_EntityCluster(OCNaroWrappers::OCInterface_EntityCluster^ ec);

//! Creates an EntityCluster, filled with a first Entity, and <br>
//!           chained to another EntityCluster (BEFORE it, as above) <br>
OCInterface_EntityCluster(OCNaroWrappers::OCStandard_Transient^ ant, OCNaroWrappers::OCInterface_EntityCluster^ ec);

//! Appends an Entity to the Cluster. If it is not full, adds the <br>
//!           entity directly inside itself. Else, transmits to its Next <br>
//!           and Creates it if it does not yet exist <br>
 /*instead*/  void Append(OCNaroWrappers::OCStandard_Transient^ ent) ;

//! Removes an Entity from the Cluster. If it is not found, calls <br>
//!           its Next one to do so. <br>
//!           Returns True if it becomes itself empty, False else <br>
//!           (thus, a Cluster which becomes empty is deleted from the list) <br>
 /*instead*/  System::Boolean Remove(OCNaroWrappers::OCStandard_Transient^ ent) ;

//! Removes an Entity from the Cluster, given its rank. If <num> <br>
//!           is greater than NbLocal, calls its Next with (num - NbLocal), <br>
//!           Returns True if it becomes itself empty, False else <br>
 /*instead*/  System::Boolean Remove(Standard_Integer num) ;

//! Returns total count of Entities (including Next) <br>
 /*instead*/  Standard_Integer NbEntities() ;

//! Returns the Entity identified by its rank in the list <br>
//!           (including Next) <br>
 /*instead*/  OCStandard_Transient^ Value(Standard_Integer num) ;

//! Changes an Entity given its rank. <br>
 /*instead*/  void SetValue(Standard_Integer num, OCNaroWrappers::OCStandard_Transient^ ent) ;

//! Fills an Iterator with designated Entities (includes Next) <br>
 /*instead*/  void FillIterator(OCNaroWrappers::OCInterface_EntityIterator^ iter) ;

~OCInterface_EntityCluster()
{
  nativeHandle->Nullify();
  delete nativeHandle;
}

};

}; // OCNaroWrappers

#endif
