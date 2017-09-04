#ifndef BRepBuilderAPI_Sewing_H
#define BRepBuilderAPI_Sewing_H

#include "../../Export_Import.h"

extern "C" DECL_EXPORT void* BRepBuilderAPI_Sewing_Ctor7CD625AC(
	double tolerance,
	bool option1,
	bool option2,
	bool option3,
	bool option4);
extern "C" DECL_EXPORT void BRepBuilderAPI_Sewing_Init7CD625AC(
	void* instance,
	double tolerance,
	bool option1,
	bool option2,
	bool option3,
	bool option4);
extern "C" DECL_EXPORT void BRepBuilderAPI_Sewing_Load9EBAC0C0(
	void* instance,
	void* shape);
extern "C" DECL_EXPORT void BRepBuilderAPI_Sewing_Add9EBAC0C0(
	void* instance,
	void* shape);
extern "C" DECL_EXPORT void BRepBuilderAPI_Sewing_Perform346F5010(
	void* instance,
	void* thePI);
extern "C" DECL_EXPORT void* BRepBuilderAPI_Sewing_FreeEdgeE8219145(
	void* instance,
	int index);
extern "C" DECL_EXPORT void* BRepBuilderAPI_Sewing_MultipleEdgeE8219145(
	void* instance,
	int index);
extern "C" DECL_EXPORT void* BRepBuilderAPI_Sewing_ContigousEdgeE8219145(
	void* instance,
	int index);
extern "C" DECL_EXPORT bool BRepBuilderAPI_Sewing_IsSectionBound24263856(
	void* instance,
	void* section);
extern "C" DECL_EXPORT void* BRepBuilderAPI_Sewing_SectionToBoundary24263856(
	void* instance,
	void* section);
extern "C" DECL_EXPORT void* BRepBuilderAPI_Sewing_DegeneratedShapeE8219145(
	void* instance,
	int index);
extern "C" DECL_EXPORT bool BRepBuilderAPI_Sewing_IsDegenerated9EBAC0C0(
	void* instance,
	void* shape);
extern "C" DECL_EXPORT bool BRepBuilderAPI_Sewing_IsModified9EBAC0C0(
	void* instance,
	void* shape);
extern "C" DECL_EXPORT void* BRepBuilderAPI_Sewing_Modified9EBAC0C0(
	void* instance,
	void* shape);
extern "C" DECL_EXPORT bool BRepBuilderAPI_Sewing_IsModifiedSubShape9EBAC0C0(
	void* instance,
	void* shape);
extern "C" DECL_EXPORT void* BRepBuilderAPI_Sewing_ModifiedSubShape9EBAC0C0(
	void* instance,
	void* shape);
extern "C" DECL_EXPORT void BRepBuilderAPI_Sewing_Dump(void* instance);
extern "C" DECL_EXPORT void* BRepBuilderAPI_Sewing_DeletedFaceE8219145(
	void* instance,
	int index);
extern "C" DECL_EXPORT void* BRepBuilderAPI_Sewing_WhichFace3274CFB8(
	void* instance,
	void* theEdg,
	int index);
extern "C" DECL_EXPORT void* BRepBuilderAPI_Sewing_SewedShape(void* instance);
extern "C" DECL_EXPORT int BRepBuilderAPI_Sewing_NbFreeEdges(void* instance);
extern "C" DECL_EXPORT int BRepBuilderAPI_Sewing_NbMultipleEdges(void* instance);
extern "C" DECL_EXPORT int BRepBuilderAPI_Sewing_NbContigousEdges(void* instance);
extern "C" DECL_EXPORT int BRepBuilderAPI_Sewing_NbDegeneratedShapes(void* instance);
extern "C" DECL_EXPORT int BRepBuilderAPI_Sewing_NbDeletedFaces(void* instance);
extern "C" DECL_EXPORT void BRepBuilderAPI_Sewing_SetSameParameterMode(void* instance, bool value);
extern "C" DECL_EXPORT bool BRepBuilderAPI_Sewing_SameParameterMode(void* instance);
extern "C" DECL_EXPORT void BRepBuilderAPI_Sewing_SetTolerance(void* instance, double value);
extern "C" DECL_EXPORT double BRepBuilderAPI_Sewing_Tolerance(void* instance);
extern "C" DECL_EXPORT void BRepBuilderAPI_Sewing_SetMinTolerance(void* instance, double value);
extern "C" DECL_EXPORT double BRepBuilderAPI_Sewing_MinTolerance(void* instance);
extern "C" DECL_EXPORT void BRepBuilderAPI_Sewing_SetMaxTolerance(void* instance, double value);
extern "C" DECL_EXPORT double BRepBuilderAPI_Sewing_MaxTolerance(void* instance);
extern "C" DECL_EXPORT void BRepBuilderAPI_Sewing_SetFaceMode(void* instance, bool value);
extern "C" DECL_EXPORT bool BRepBuilderAPI_Sewing_FaceMode(void* instance);
extern "C" DECL_EXPORT void BRepBuilderAPI_Sewing_SetFloatingEdgesMode(void* instance, bool value);
extern "C" DECL_EXPORT bool BRepBuilderAPI_Sewing_FloatingEdgesMode(void* instance);
extern "C" DECL_EXPORT void BRepBuilderAPI_Sewing_SetLocalTolerancesMode(void* instance, bool value);
extern "C" DECL_EXPORT bool BRepBuilderAPI_Sewing_LocalTolerancesMode(void* instance);
extern "C" DECL_EXPORT void BRepBuilderAPI_Sewing_SetNonManifoldMode(void* instance, bool value);
extern "C" DECL_EXPORT bool BRepBuilderAPI_Sewing_NonManifoldMode(void* instance);
extern "C" DECL_EXPORT void BRepBuilderAPISewing_Dtor(void* instance);

#endif
