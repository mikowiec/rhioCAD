#ifndef IntTools_PntOnFace_H
#define IntTools_PntOnFace_H

#include "../../Export_Import.h"

extern "C" DECL_EXPORT void* IntTools_PntOnFace_Ctor();
extern "C" DECL_EXPORT void IntTools_PntOnFace_InitB2FF1B6E(
	void* instance,
	void* aF,
	void* aP,
	double U,
	double V);
extern "C" DECL_EXPORT void IntTools_PntOnFace_SetParameters9F0E714F(
	void* instance,
	double U,
	double V);
extern "C" DECL_EXPORT void IntTools_PntOnFace_Parameters9F0E714F(
	void* instance,
	double* U,
	double* V);
extern "C" DECL_EXPORT void IntTools_PntOnFace_SetValid(void* instance, bool value);
extern "C" DECL_EXPORT bool IntTools_PntOnFace_Valid(void* instance);
extern "C" DECL_EXPORT void IntTools_PntOnFace_SetFace(void* instance, void* value);
extern "C" DECL_EXPORT void* IntTools_PntOnFace_Face(void* instance);
extern "C" DECL_EXPORT void IntTools_PntOnFace_SetPnt(void* instance, void* value);
extern "C" DECL_EXPORT void* IntTools_PntOnFace_Pnt(void* instance);
extern "C" DECL_EXPORT void IntToolsPntOnFace_Dtor(void* instance);

#endif
