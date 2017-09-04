#ifndef BRep_Builder_H
#define BRep_Builder_H

#include "../../Export_Import.h"

extern "C" DECL_EXPORT void BRep_Builder_MakeFaceAEC70AC1(
	void* instance,
	void* F);
extern "C" DECL_EXPORT void BRep_Builder_MakeFace7EEC8D91(
	void* instance,
	void* F,
	void* S,
	double Tol);
extern "C" DECL_EXPORT void BRep_Builder_MakeFaceBAA765A3(
	void* instance,
	void* F,
	void* S,
	void* L,
	double Tol);
extern "C" DECL_EXPORT void BRep_Builder_MakeFaceE5A9949B(
	void* instance,
	void* F,
	void* T);
extern "C" DECL_EXPORT void BRep_Builder_UpdateFaceBAA765A3(
	void* instance,
	void* F,
	void* S,
	void* L,
	double Tol);
extern "C" DECL_EXPORT void BRep_Builder_UpdateFaceE5A9949B(
	void* instance,
	void* F,
	void* T);
extern "C" DECL_EXPORT void BRep_Builder_UpdateFace5D6B238E(
	void* instance,
	void* F,
	double Tol);
extern "C" DECL_EXPORT void BRep_Builder_NaturalRestriction4945DBAD(
	void* instance,
	void* F,
	bool N);
extern "C" DECL_EXPORT void BRep_Builder_MakeEdge24263856(
	void* instance,
	void* E);
extern "C" DECL_EXPORT void BRep_Builder_MakeEdgeE5AE3CE7(
	void* instance,
	void* E,
	void* C,
	double Tol);
extern "C" DECL_EXPORT void BRep_Builder_MakeEdge686D1199(
	void* instance,
	void* E,
	void* C,
	void* L,
	double Tol);
extern "C" DECL_EXPORT void BRep_Builder_ContinuityD6A3B177(
	void* instance,
	void* E,
	void* F1,
	void* F2,
	int C);
extern "C" DECL_EXPORT void BRep_Builder_ContinuityBD255723(
	void* instance,
	void* E,
	void* S1,
	void* S2,
	void* L1,
	void* L2,
	int C);
extern "C" DECL_EXPORT void BRep_Builder_SameParameter7F8C607A(
	void* instance,
	void* E,
	bool S);
extern "C" DECL_EXPORT void BRep_Builder_SameRange7F8C607A(
	void* instance,
	void* E,
	bool S);
extern "C" DECL_EXPORT void BRep_Builder_Degenerated7F8C607A(
	void* instance,
	void* E,
	bool D);
extern "C" DECL_EXPORT void BRep_Builder_Range7522FA9B(
	void* instance,
	void* E,
	double First,
	double Last,
	bool Only3d);
extern "C" DECL_EXPORT void BRep_Builder_Range367873C2(
	void* instance,
	void* E,
	void* S,
	void* L,
	double First,
	double Last);
extern "C" DECL_EXPORT void BRep_Builder_RangeF1087A9D(
	void* instance,
	void* E,
	void* F,
	double First,
	double Last);
extern "C" DECL_EXPORT void BRep_Builder_Transfert4DFF7017(
	void* instance,
	void* Ein,
	void* Eout);
extern "C" DECL_EXPORT void BRep_Builder_MakeVertex3EF07F6A(
	void* instance,
	void* V);
extern "C" DECL_EXPORT void BRep_Builder_MakeVertex3B977AAF(
	void* instance,
	void* V,
	void* P,
	double Tol);
extern "C" DECL_EXPORT void BRep_Builder_UpdateVertex3B977AAF(
	void* instance,
	void* V,
	void* P,
	double Tol);
extern "C" DECL_EXPORT void BRep_Builder_UpdateVertex4056A7EF(
	void* instance,
	void* V,
	double P,
	void* E,
	double Tol);
extern "C" DECL_EXPORT void BRep_Builder_UpdateVertex7CBB7775(
	void* instance,
	void* V,
	double P,
	void* E,
	void* F,
	double Tol);
extern "C" DECL_EXPORT void BRep_Builder_UpdateVertex2BB581FE(
	void* instance,
	void* V,
	double P,
	void* E,
	void* S,
	void* L,
	double Tol);
extern "C" DECL_EXPORT void BRep_Builder_UpdateVertex7A0EDB4B(
	void* instance,
	void* Ve,
	double U,
	double V,
	void* F,
	double Tol);
extern "C" DECL_EXPORT void BRep_Builder_UpdateVertex729B627B(
	void* instance,
	void* V,
	double Tol);
extern "C" DECL_EXPORT void BRep_Builder_Transfert41DFC03D(
	void* instance,
	void* Ein,
	void* Eout,
	void* Vin,
	void* Vout);
extern "C" DECL_EXPORT void BRepBuilder_Dtor(void* instance);

#endif
