#include "ChFiDSFaceInterference.h"
#include <ChFiDS_FaceInterference.hxx>


DECL_EXPORT void* ChFiDS_FaceInterference_Ctor()
{
	return new ChFiDS_FaceInterference();
}
DECL_EXPORT void ChFiDS_FaceInterference_SetParameterC85E5E0F(
	void* instance,
	double U1,
	bool IsFirst)
{
	ChFiDS_FaceInterference* result = (ChFiDS_FaceInterference*)instance;
 	result->SetParameter(			
U1,			
IsFirst);
}
DECL_EXPORT double ChFiDS_FaceInterference_Parameter461FC46A(
	void* instance,
	bool IsFirst)
{
	ChFiDS_FaceInterference* result = (ChFiDS_FaceInterference*)instance;
	return  	result->Parameter(			
IsFirst);
}
DECL_EXPORT void ChFiDS_FaceInterference_SetLineIndex(void* instance, int value)
{
	ChFiDS_FaceInterference* result = (ChFiDS_FaceInterference*)instance;
		result->SetLineIndex(value);
}

DECL_EXPORT int ChFiDS_FaceInterference_LineIndex(void* instance)
{
	ChFiDS_FaceInterference* result = (ChFiDS_FaceInterference*)instance;
	return 	result->LineIndex();
}

DECL_EXPORT void ChFiDS_FaceInterference_SetTransition(void* instance, int value)
{
	ChFiDS_FaceInterference* result = (ChFiDS_FaceInterference*)instance;
		result->SetTransition((const TopAbs_Orientation)value);
}

DECL_EXPORT int ChFiDS_FaceInterference_Transition(void* instance)
{
	ChFiDS_FaceInterference* result = (ChFiDS_FaceInterference*)instance;
	return (int)	result->Transition();
}

DECL_EXPORT void ChFiDS_FaceInterference_SetFirstParameter(void* instance, double value)
{
	ChFiDS_FaceInterference* result = (ChFiDS_FaceInterference*)instance;
		result->SetFirstParameter(value);
}

DECL_EXPORT double ChFiDS_FaceInterference_FirstParameter(void* instance)
{
	ChFiDS_FaceInterference* result = (ChFiDS_FaceInterference*)instance;
	return 	result->FirstParameter();
}

DECL_EXPORT void ChFiDS_FaceInterference_SetLastParameter(void* instance, double value)
{
	ChFiDS_FaceInterference* result = (ChFiDS_FaceInterference*)instance;
		result->SetLastParameter(value);
}

DECL_EXPORT double ChFiDS_FaceInterference_LastParameter(void* instance)
{
	ChFiDS_FaceInterference* result = (ChFiDS_FaceInterference*)instance;
	return 	result->LastParameter();
}

DECL_EXPORT void ChFiDSFaceInterference_Dtor(void* instance)
{
	delete (ChFiDS_FaceInterference*)instance;
}
