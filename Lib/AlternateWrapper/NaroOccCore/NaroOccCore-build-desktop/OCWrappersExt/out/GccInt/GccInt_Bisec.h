// File generated by CPPExt (Transient)
//
#ifndef _GccInt_Bisec_OCWrappers_HeaderFile
#define _GccInt_Bisec_OCWrappers_HeaderFile

// include the wrapped class
#include <GccInt_Bisec.hxx>
#include "../Converter.h"

#include "../MMgt/MMgt_TShared.h"

#include "GccInt_IType.h"


namespace OCNaroWrappers
{

ref class OCgp_Pnt2d;
ref class OCgp_Lin2d;
ref class OCgp_Circ2d;
ref class OCgp_Hypr2d;
ref class OCgp_Parab2d;
ref class OCgp_Elips2d;


//! The deferred class GccInt_Bisec is the root class for <br>
//! elementary bisecting loci between two simple geometric <br>
//! objects (i.e. circles, lines or points). <br>
//! Bisecting loci between two geometric objects are such <br>
//! that each of their points is at the same distance from the <br>
//! two geometric objects. It is typically a curve, such as a <br>
//! line, circle or conic. <br>
//! Generally there is more than one elementary object <br>
//! which is the solution to a bisecting loci problem: each <br>
//! solution is described with one elementary bisecting <br>
//! locus. For example, the bisectors of two secant straight <br>
//! lines are two perpendicular straight lines. <br>
//! The GccInt package provides concrete implementations <br>
//! of the following elementary derived bisecting loci: <br>
//! -   lines, circles, ellipses, hyperbolas and parabolas, and <br>
//! -   points (not used in this context). <br>
//! The GccAna package provides numerous algorithms for <br>
//! computing the bisecting loci between circles, lines or <br>
//! points, whose solutions are these types of elementary bisecting locus. <br>
public ref class OCGccInt_Bisec : OCMMgt_TShared {

protected:
  // dummy constructor;
  OCGccInt_Bisec(OCDummy^) : OCMMgt_TShared((OCDummy^)nullptr) {};

public:

// constructor from native
OCGccInt_Bisec(Handle(GccInt_Bisec)* nativeHandle);

// Methods PUBLIC

//! Returns the bisecting line when ArcType returns Pnt. <br>
//!          An exception DomainError is raised if ArcType is not a Pnt. <br>
virtual /*instead*/  OCgp_Pnt2d^ Point() ;

//! Returns the bisecting line when ArcType returns Lin. <br>//! An exception DomainError is raised if ArcType is not a Lin. <br>
virtual /*instead*/  OCgp_Lin2d^ Line() ;

//! Returns the bisecting line when ArcType returns Cir. <br>//! An exception DomainError is raised if ArcType is not a Cir. <br>
virtual /*instead*/  OCgp_Circ2d^ Circle() ;

//! Returns the bisecting line when ArcType returns Hpr. <br>//! An exception DomainError is raised if ArcType is not a Hpr. <br>
virtual /*instead*/  OCgp_Hypr2d^ Hyperbola() ;

//! Returns the bisecting line when ArcType returns Par. <br>//! An exception DomainError is raised if ArcType is not a Par. <br>
virtual /*instead*/  OCgp_Parab2d^ Parabola() ;

//! Returns the bisecting line when ArcType returns Ell. <br>//! An exception DomainError is raised if ArcType is not an Ell. <br>
virtual /*instead*/  OCgp_Elips2d^ Ellipse() ;

~OCGccInt_Bisec()
{
  nativeHandle->Nullify();
  delete nativeHandle;
}

};

}; // OCNaroWrappers

#endif
