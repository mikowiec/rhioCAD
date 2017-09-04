#ifndef ChFiDS_FaceInterference_H
#define ChFiDS_FaceInterference_H

#include "../../Export_Import.h"

extern "C" DECL_EXPORT void* ChFiDS_FaceInterference_Ctor();
extern "C" DECL_EXPORT void ChFiDS_FaceInterference_SetParameterC85E5E0F(
	void* instance,
	double U1,
	bool IsFirst);
extern "C" DECL_EXPORT double ChFiDS_FaceInterference_Parameter461FC46A(
	void* instance,
	bool IsFirst);
extern "C" DECL_EXPORT void ChFiDS_FaceInterference_SetLineIndex(void* instance, int value);
extern "C" DECL_EXPORT int ChFiDS_FaceInterference_LineIndex(void* instance);
extern "C" DECL_EXPORT void ChFiDS_FaceInterference_SetTransition(void* instance, int value);
extern "C" DECL_EXPORT int ChFiDS_FaceInterference_Transition(void* instance);
extern "C" DECL_EXPORT void ChFiDS_FaceInterference_SetFirstParameter(void* instance, double value);
extern "C" DECL_EXPORT double ChFiDS_FaceInterference_FirstParameter(void* instance);
extern "C" DECL_EXPORT void ChFiDS_FaceInterference_SetLastParameter(void* instance, double value);
extern "C" DECL_EXPORT double ChFiDS_FaceInterference_LastParameter(void* instance);
extern "C" DECL_EXPORT void ChFiDSFaceInterference_Dtor(void* instance);

#endif
