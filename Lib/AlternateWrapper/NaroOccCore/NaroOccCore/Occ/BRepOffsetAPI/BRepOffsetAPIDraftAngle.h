#ifndef BRepOffsetAPI_DraftAngle_H
#define BRepOffsetAPI_DraftAngle_H

#include "../../Export_Import.h"

extern "C" DECL_EXPORT void* BRepOffsetAPI_DraftAngle_Ctor();
extern "C" DECL_EXPORT void* BRepOffsetAPI_DraftAngle_Ctor9EBAC0C0(
	void* S);
extern "C" DECL_EXPORT void BRepOffsetAPI_DraftAngle_Clear(void* instance);
extern "C" DECL_EXPORT void BRepOffsetAPI_DraftAngle_Init9EBAC0C0(
	void* instance,
	void* S);
extern "C" DECL_EXPORT void BRepOffsetAPI_DraftAngle_AddABCF3248(
	void* instance,
	void* F,
	void* Direction,
	double Angle,
	void* NeutralPlane,
	bool Flag);
extern "C" DECL_EXPORT void BRepOffsetAPI_DraftAngle_RemoveAEC70AC1(
	void* instance,
	void* F);
extern "C" DECL_EXPORT void BRepOffsetAPI_DraftAngle_Build(void* instance);
extern "C" DECL_EXPORT void BRepOffsetAPI_DraftAngle_CorrectWires(void* instance);
extern "C" DECL_EXPORT bool BRepOffsetAPI_DraftAngle_AddDone(void* instance);
extern "C" DECL_EXPORT void* BRepOffsetAPI_DraftAngle_ProblematicShape(void* instance);
extern "C" DECL_EXPORT int BRepOffsetAPI_DraftAngle_Status(void* instance);
extern "C" DECL_EXPORT void BRepOffsetAPIDraftAngle_Dtor(void* instance);

#endif
