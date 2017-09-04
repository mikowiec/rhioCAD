#ifndef BOP_EdgeInfo_H
#define BOP_EdgeInfo_H

#include "../../Export_Import.h"

extern "C" DECL_EXPORT void* BOP_EdgeInfo_Ctor();
extern "C" DECL_EXPORT void BOP_EdgeInfo_SetInFlag(void* instance, bool value);
extern "C" DECL_EXPORT void BOP_EdgeInfo_SetEdge(void* instance, void* value);
extern "C" DECL_EXPORT void* BOP_EdgeInfo_Edge(void* instance);
extern "C" DECL_EXPORT void BOP_EdgeInfo_SetPassed(void* instance, bool value);
extern "C" DECL_EXPORT bool BOP_EdgeInfo_Passed(void* instance);
extern "C" DECL_EXPORT void BOP_EdgeInfo_SetAngle(void* instance, double value);
extern "C" DECL_EXPORT double BOP_EdgeInfo_Angle(void* instance);
extern "C" DECL_EXPORT bool BOP_EdgeInfo_IsIn(void* instance);
extern "C" DECL_EXPORT void BOPEdgeInfo_Dtor(void* instance);

#endif
