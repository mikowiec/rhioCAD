// File generated by CPPExt (Package)
//

#ifndef _TNaming_OCWrappers_HeaderFile
#define _TNaming_OCWrappers_HeaderFile

// Include the wrapped header
#include <TNaming.hxx>

#include "TNaming_CopyShape.h"
#include "TNaming_TranslateTool.h"
#include "TNaming_Translator.h"
#include "TNaming_NamedShape.h"
#include "TNaming_UsedShapes.h"
#include "TNaming_Builder.h"
#include "TNaming_Tool.h"
#include "TNaming_Iterator.h"
#include "TNaming_NewShapeIterator.h"
#include "TNaming_OldShapeIterator.h"
#include "TNaming_SameShapeIterator.h"
#include "TNaming_NamedShapeHasher.h"
#include "TNaming_MapOfNamedShape.h"
#include "TNaming_ListOfNamedShape.h"
#include "TNaming_Name.h"
#include "TNaming_Naming.h"
#include "TNaming_Selector.h"
#include "TNaming_DeltaOnRemoval.h"
#include "TNaming_DeltaOnModification.h"
#include "TNaming_RefShape.h"
#include "TNaming_DataMapOfShapePtrRefShape.h"
#include "TNaming_Scope.h"
#include "TNaming_Identifier.h"
#include "TNaming_Localizer.h"
#include "TNaming_ShapesSet.h"
#include "TNaming_IteratorOnShapesSet.h"
#include "TNaming_DataMapOfShapeShapesSet.h"
#include "TNaming_ListOfMapOfShape.h"
#include "TNaming_ListOfIndexedDataMapOfShapeListOfShape.h"
#include "TNaming_NamingTool.h"
#include "TNaming_StdMapNodeOfMapOfNamedShape.h"
#include "TNaming_MapIteratorOfMapOfNamedShape.h"
#include "TNaming_ListNodeOfListOfNamedShape.h"
#include "TNaming_ListIteratorOfListOfNamedShape.h"
#include "TNaming_DataMapNodeOfDataMapOfShapePtrRefShape.h"
#include "TNaming_DataMapIteratorOfDataMapOfShapePtrRefShape.h"
#include "TNaming_DataMapNodeOfDataMapOfShapeShapesSet.h"
#include "TNaming_DataMapIteratorOfDataMapOfShapeShapesSet.h"
#include "TNaming_ListNodeOfListOfMapOfShape.h"
#include "TNaming_ListIteratorOfListOfMapOfShape.h"
#include "TNaming_ListNodeOfListOfIndexedDataMapOfShapeListOfShape.h"
#include "TNaming_ListIteratorOfListOfIndexedDataMapOfShapeListOfShape.h"


namespace OCNaroWrappers
{
//! A topological attribute can be seen as a hook <br>
//! into the topological structure. To this hook, <br>
//! data can be attached and references defined. <br>
//!  It is used for keeping and access to <br>
//! topological objects and their evolution. All <br>
//! topological objects are stored in the one <br>
//! user-protected TNaming_UsedShapes <br>
//! attribute at the root label of the data <br>
//! framework. This attribute contains map with all <br>
//! topological shapes, used in this document. <br>
//! To all other labels TNaming_NamedShape <br>
//! attribute can be added. This attribute contains <br>
//! references (hooks) to shapes from the <br>
//! TNaming_UsedShapes attribute and evolution <br>
//! of these shapes. TNaming_NamedShape <br>
//! attribute contains a set of pairs of hooks: old <br>
//! shape and new shape (see the figure below). <br>
//! It allows not only get the topological shapes by <br>
//! the labels, but also trace evolution of the <br>
//! shapes and correctly resolve dependent <br>
//! shapes by the changed one. <br>
//! If shape is just-created, then the old shape for <br>
//! accorded named shape is an empty shape. If <br>
//! a shape is deleted, then the new shape in this named shape is empty. <br>
//! Different algorithms may dispose sub-shapes <br>
//! of the result shape at the individual label depending on necessity: <br>
//!   -  If a sub-shape must have some extra attributes (material of <br>
//!      each face or color of each edge). In this case a specific sub-shape is <br>
//!      placed to the separate label (usually, sub-label of the result shape label) <br>
//!      with all attributes of this sub-shape. <br>
//!   -  If topological naming is needed, a necessary and sufficient <br>
//!      (for selected sub-shapes identification) set of sub-shapes is <br>
//!      placed to the child labels of the result <br>
//!      shape label. As usual, as far as basic solids and closed shells are <br>
//!      concerned, all faces of the shape are disposed. Edges and vertices <br>
//!      sub-shapes can be identified as intersection of contiguous faces. <br>
//!      Modified/generated shapes may be placed to one named shape and <br>
//!      identified as this named shape and source named shape that also can be <br>
//!      identified with used algorithms. <br>
//!   TNaming_NamedShape may contain a few <br>
//! pairs of hooks with the same evolution. In this <br>
//! case topology shape, which belongs to the <br>
//! named shape, is a compound of new shapes. <br>
//!   The data model contains both the topology <br>
//! and the hooks, and functions handle both <br>
//! topological entities and hooks. Consider the <br>
//! case of a box function, which creates a solid <br>
//! with six faces and six hooks. Each hook is <br>
//! attached to a face. If you want, you can also <br>
//! have this function create hooks for edges and <br>
//! vertices as well as for faces. For the sake of <br>
//! simplicity though, let's limit the example. <br>
//!   Not all functions can define explicit hooks for <br>
//! all topological entities they create, but all <br>
//! topological entities can be turned into hooks <br>
//! when necessary. This is where topological naming is necessary. <br>
public ref class OCTNaming abstract sealed
{

public:
// Methods

//! Subtituter les  shapes  sur les structures de   source <br>
//!          vers cible <br>
static /*instead*/  void Substitute(OCNaroWrappers::OCTDF_Label^ labelsource, OCNaroWrappers::OCTDF_Label^ labelcible, OCNaroWrappers::OCTopTools_DataMapOfShapeShape^ mapOldNew) ;

//! Mise a jour des shapes du label  et de ses fils en <br>
//!          tenant compte des  substitutions decrite par <br>
//!          mapOldNew. <br>
//! <br>
//!  Warning: le  remplacement du shape est  fait    dans tous <br>
//!          les    attributs  qui  le contiennent meme si ceux <br>
//!          ci ne sont pas associees a des sous-labels de <Label>. <br>
static /*instead*/  void Update(OCNaroWrappers::OCTDF_Label^ label, OCNaroWrappers::OCTopTools_DataMapOfShapeShape^ mapOldNew) ;

//! Application de la Location sur les shapes du label <br>
//!          et  de   ses   sous   labels. <br>
static /*instead*/  void Displace(OCNaroWrappers::OCTDF_Label^ label, OCNaroWrappers::OCTopLoc_Location^ aLocation, System::Boolean WithOld) ;

//! Remplace  les  shapes du label et  des sous-labels <br>
//!          par des copies. <br>
static /*instead*/  void ChangeShapes(OCNaroWrappers::OCTDF_Label^ label, OCNaroWrappers::OCTopTools_DataMapOfShapeShape^ M) ;

//! Application de la transformation sur les shapes du <br>
//!          label et de ses sous labels. <br>
//!  Warning: le  remplacement du shape est  fait    dans tous <br>
//!          les    attributs  qui  le contiennent meme si ceux <br>
//!          ci ne sont pas associees a des sous-labels de <Label>. <br>
static /*instead*/  void Transform(OCNaroWrappers::OCTDF_Label^ label, OCNaroWrappers::OCgp_Trsf^ aTransformation) ;

//! Replicates the named shape with the transformation <T> <br>
//!          on the label <L> (and sub-labels if necessary) <br>
//!          (TNaming_GENERATED is set) <br>
static /*instead*/  void Replicate(OCNaroWrappers::OCTNaming_NamedShape^ NS, OCNaroWrappers::OCgp_Trsf^ T, OCNaroWrappers::OCTDF_Label^ L) ;

//! Replicates the shape with the transformation <T> <br>
//!          on the label <L> (and sub-labels if necessary) <br>
//!          (TNaming_GENERATED is set) <br>
static /*instead*/  void Replicate(OCNaroWrappers::OCTopoDS_Shape^ SH, OCNaroWrappers::OCgp_Trsf^ T, OCNaroWrappers::OCTDF_Label^ L) ;

//! Builds shape from map content <br>
static /*instead*/  OCTopoDS_Shape^ MakeShape(OCNaroWrappers::OCTopTools_MapOfShape^ MS) ;

//! Find unique context of shape <S> <br>
static /*instead*/  OCTopoDS_Shape^ FindUniqueContext(OCNaroWrappers::OCTopoDS_Shape^ S, OCNaroWrappers::OCTopoDS_Shape^ Context) ;

//! Find unique context of shape <S>,which is pure concatenation <br>
//!          of atomic shapes (Compound). The result is concatenation of <br>
//!          single contexts <br>
static /*instead*/  OCTopoDS_Shape^ FindUniqueContextSet(OCNaroWrappers::OCTopoDS_Shape^ S, OCNaroWrappers::OCTopoDS_Shape^ Context, OCNaroWrappers::OCTopTools_HArray1OfShape^ Arr) ;

//! Subtitutes shape in source structure <br>
static /*instead*/  System::Boolean SubstituteSShape(OCNaroWrappers::OCTDF_Label^ accesslabel, OCNaroWrappers::OCTopoDS_Shape^ From, OCNaroWrappers::OCTopoDS_Shape^ To) ;

//! Returns True if outer wire is found and the found wire in <theWire>. <br>
static /*instead*/  System::Boolean OuterWire(OCNaroWrappers::OCTopoDS_Face^ theFace, OCNaroWrappers::OCTopoDS_Wire^ theWire) ;

//! Returns True if outer Shell is found and the found shell in <theShell>. <br>//! Print of TNaming enumeration <br>
//!          ============================= <br>
static /*instead*/  System::Boolean OuterShell(OCNaroWrappers::OCTopoDS_Solid^ theSolid, OCNaroWrappers::OCTopoDS_Shell^ theShell) ;

//! Appends to <anIDList> the list of the attributes <br>
//!          IDs of this package. CAUTION: <anIDList> is NOT <br>
//!          cleared before use. <br>
static /*instead*/  void IDList(OCNaroWrappers::OCTDF_IDList^ anIDList) ;


static /*instead*/  Standard_OStream& Print(OCTNaming_Evolution EVOL, Standard_OStream& S) ;


static /*instead*/  Standard_OStream& Print(OCTNaming_NameType NAME, Standard_OStream& S) ;


static /*instead*/  Standard_OStream& Print(OCNaroWrappers::OCTDF_Label^ ACCESS, Standard_OStream& S) ;


};

}; // OCNaroWrappers

#endif
