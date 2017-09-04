#ifndef BRepFilletAPI_MakeFillet2d_H
#define BRepFilletAPI_MakeFillet2d_H

#include "../../Export_Import.h"

extern "C" DECL_EXPORT void* BRepFilletAPI_MakeFillet2d_Ctor();
extern "C" DECL_EXPORT void* BRepFilletAPI_MakeFillet2d_CtorAEC70AC1(
	void* F);
extern "C" DECL_EXPORT void BRepFilletAPI_MakeFillet2d_InitAEC70AC1(
	void* instance,
	void* F);
extern "C" DECL_EXPORT void BRepFilletAPI_MakeFillet2d_Init9D93DFBA(
	void* instance,
	void* RefFace,
	void* ModFace);
extern "C" DECL_EXPORT void* BRepFilletAPI_MakeFillet2d_AddFillet729B627B(
	void* instance,
	void* V,
	double Radius);
extern "C" DECL_EXPORT void* BRepFilletAPI_MakeFillet2d_ModifyFillet809BA47B(
	void* instance,
	void* Fillet,
	double Radius);
extern "C" DECL_EXPORT void* BRepFilletAPI_MakeFillet2d_RemoveFillet24263856(
	void* instance,
	void* Fillet);
extern "C" DECL_EXPORT void* BRepFilletAPI_MakeFillet2d_AddChamferFF157EBA(
	void* instance,
	void* E1,
	void* E2,
	double D1,
	double D2);
extern "C" DECL_EXPORT void* BRepFilletAPI_MakeFillet2d_AddChamfer619A10E2(
	void* instance,
	void* E,
	void* V,
	double D,
	double Ang);
extern "C" DECL_EXPORT void* BRepFilletAPI_MakeFillet2d_ModifyChamfer9D62DE59(
	void* instance,
	void* Chamfer,
	void* E1,
	void* E2,
	double D1,
	double D2);
extern "C" DECL_EXPORT void* BRepFilletAPI_MakeFillet2d_ModifyChamferFF157EBA(
	void* instance,
	void* Chamfer,
	void* E,
	double D,
	double Ang);
extern "C" DECL_EXPORT void* BRepFilletAPI_MakeFillet2d_RemoveChamfer24263856(
	void* instance,
	void* Chamfer);
extern "C" DECL_EXPORT bool BRepFilletAPI_MakeFillet2d_IsModified24263856(
	void* instance,
	void* E);
extern "C" DECL_EXPORT bool BRepFilletAPI_MakeFillet2d_HasDescendant24263856(
	void* instance,
	void* E);
extern "C" DECL_EXPORT void* BRepFilletAPI_MakeFillet2d_DescendantEdge24263856(
	void* instance,
	void* E);
extern "C" DECL_EXPORT void* BRepFilletAPI_MakeFillet2d_BasisEdge24263856(
	void* instance,
	void* E);
extern "C" DECL_EXPORT void BRepFilletAPI_MakeFillet2d_Build(void* instance);
extern "C" DECL_EXPORT int BRepFilletAPI_MakeFillet2d_NbFillet(void* instance);
extern "C" DECL_EXPORT int BRepFilletAPI_MakeFillet2d_NbChamfer(void* instance);
extern "C" DECL_EXPORT int BRepFilletAPI_MakeFillet2d_NbCurves(void* instance);
extern "C" DECL_EXPORT int BRepFilletAPI_MakeFillet2d_Status(void* instance);
extern "C" DECL_EXPORT void BRepFilletAPIMakeFillet2d_Dtor(void* instance);

#endif
