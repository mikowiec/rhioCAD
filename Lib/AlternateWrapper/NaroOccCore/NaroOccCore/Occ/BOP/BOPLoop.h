#ifndef BOP_Loop_H
#define BOP_Loop_H

#include "../../Export_Import.h"

extern "C" DECL_EXPORT void* BOP_Loop_Ctor9EBAC0C0(
	void* S);
extern "C" DECL_EXPORT void* BOP_Loop_CtorD1FD8153(
	void* BI);
extern "C" DECL_EXPORT bool BOP_Loop_IsShape(void* instance);
extern "C" DECL_EXPORT void* BOP_Loop_Shape(void* instance);
extern "C" DECL_EXPORT void* BOP_Loop_BlockIterator(void* instance);
extern "C" DECL_EXPORT void BOPLoop_Dtor(void* instance);

#endif
