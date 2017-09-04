#ifndef BOP_FaceInfo_H
#define BOP_FaceInfo_H

#include "../../Export_Import.h"

extern "C" DECL_EXPORT void* BOP_FaceInfo_Ctor();
extern "C" DECL_EXPORT void BOP_FaceInfo_SetPassed(void* instance, bool value);
extern "C" DECL_EXPORT void BOP_FaceInfo_SetFace(void* instance, void* value);
extern "C" DECL_EXPORT void* BOP_FaceInfo_Face(void* instance);
extern "C" DECL_EXPORT void BOP_FaceInfo_SetPOnEdge(void* instance, void* value);
extern "C" DECL_EXPORT void* BOP_FaceInfo_POnEdge(void* instance);
extern "C" DECL_EXPORT void BOP_FaceInfo_SetPInFace(void* instance, void* value);
extern "C" DECL_EXPORT void* BOP_FaceInfo_PInFace(void* instance);
extern "C" DECL_EXPORT void BOP_FaceInfo_SetPInFace2D(void* instance, void* value);
extern "C" DECL_EXPORT void* BOP_FaceInfo_PInFace2D(void* instance);
extern "C" DECL_EXPORT void BOP_FaceInfo_SetNormal(void* instance, void* value);
extern "C" DECL_EXPORT void* BOP_FaceInfo_Normal(void* instance);
extern "C" DECL_EXPORT bool BOP_FaceInfo_IsPassed(void* instance);
extern "C" DECL_EXPORT void BOP_FaceInfo_SetAngle(void* instance, double value);
extern "C" DECL_EXPORT double BOP_FaceInfo_Angle(void* instance);
extern "C" DECL_EXPORT void BOPFaceInfo_Dtor(void* instance);

#endif
