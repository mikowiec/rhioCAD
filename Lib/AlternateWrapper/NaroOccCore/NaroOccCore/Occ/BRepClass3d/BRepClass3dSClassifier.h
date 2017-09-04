#ifndef BRepClass3d_SClassifier_H
#define BRepClass3d_SClassifier_H

#include "../../Export_Import.h"

extern "C" DECL_EXPORT void* BRepClass3d_SClassifier_Ctor();
extern "C" DECL_EXPORT bool BRepClass3d_SClassifier_Rejected(void* instance);
extern "C" DECL_EXPORT int BRepClass3d_SClassifier_State(void* instance);
extern "C" DECL_EXPORT bool BRepClass3d_SClassifier_IsOnAFace(void* instance);
extern "C" DECL_EXPORT void* BRepClass3d_SClassifier_Face(void* instance);
extern "C" DECL_EXPORT void BRepClass3dSClassifier_Dtor(void* instance);

#endif
