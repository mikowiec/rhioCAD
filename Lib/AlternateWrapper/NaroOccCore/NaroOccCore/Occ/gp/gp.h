#ifndef gp_H
#define gp_H

#include "../../Export_Import.h"

extern "C" DECL_EXPORT double gp_Resolution();
extern "C" DECL_EXPORT void* gp_Origin();
extern "C" DECL_EXPORT void* gp_DX();
extern "C" DECL_EXPORT void* gp_DY();
extern "C" DECL_EXPORT void* gp_DZ();
extern "C" DECL_EXPORT void* gp_OX();
extern "C" DECL_EXPORT void* gp_OY();
extern "C" DECL_EXPORT void* gp_OZ();
extern "C" DECL_EXPORT void* gp_XOY();
extern "C" DECL_EXPORT void* gp_ZOX();
extern "C" DECL_EXPORT void* gp_YOZ();
extern "C" DECL_EXPORT void* gp_Origin2d();
extern "C" DECL_EXPORT void* gp_DX2d();
extern "C" DECL_EXPORT void* gp_DY2d();
extern "C" DECL_EXPORT void* gp_OX2d();
extern "C" DECL_EXPORT void* gp_OY2d();
extern "C" DECL_EXPORT void gp_Dtor(void* instance);

#endif
