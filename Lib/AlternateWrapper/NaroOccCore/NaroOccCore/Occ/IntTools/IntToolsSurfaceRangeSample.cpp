#include "IntToolsSurfaceRangeSample.h"
#include <IntTools_SurfaceRangeSample.hxx>

#include <IntTools_CurveRangeSample.hxx>
#include <IntTools_Range.hxx>
#include <IntTools_SurfaceRangeSample.hxx>

DECL_EXPORT void* IntTools_SurfaceRangeSample_Ctor()
{
	return new IntTools_SurfaceRangeSample();
}
DECL_EXPORT void* IntTools_SurfaceRangeSample_Ctor8C6D7843(
	int theIndexU,
	int theDepthU,
	int theIndexV,
	int theDepthV)
{
	return new IntTools_SurfaceRangeSample(			
theIndexU,			
theDepthU,			
theIndexV,			
theDepthV);
}
DECL_EXPORT void* IntTools_SurfaceRangeSample_Ctor72DC087B(
	void* theRangeU,
	void* theRangeV)
{
		const IntTools_CurveRangeSample &  _theRangeU =*(const IntTools_CurveRangeSample *)theRangeU;
		const IntTools_CurveRangeSample &  _theRangeV =*(const IntTools_CurveRangeSample *)theRangeV;
	return new IntTools_SurfaceRangeSample(			
_theRangeU,			
_theRangeV);
}
DECL_EXPORT void* IntTools_SurfaceRangeSample_Ctor7CD3FA85(
	void* Other)
{
		const IntTools_SurfaceRangeSample &  _Other =*(const IntTools_SurfaceRangeSample *)Other;
	return new IntTools_SurfaceRangeSample(			
_Other);
}
DECL_EXPORT void* IntTools_SurfaceRangeSample_Assign7CD3FA85(
	void* instance,
	void* Other)
{
		const IntTools_SurfaceRangeSample &  _Other =*(const IntTools_SurfaceRangeSample *)Other;
	IntTools_SurfaceRangeSample* result = (IntTools_SurfaceRangeSample*)instance;
	return new IntTools_SurfaceRangeSample( 	result->Assign(			
_Other));
}
DECL_EXPORT void IntTools_SurfaceRangeSample_SetRanges72DC087B(
	void* instance,
	void* theRangeU,
	void* theRangeV)
{
		const IntTools_CurveRangeSample &  _theRangeU =*(const IntTools_CurveRangeSample *)theRangeU;
		const IntTools_CurveRangeSample &  _theRangeV =*(const IntTools_CurveRangeSample *)theRangeV;
	IntTools_SurfaceRangeSample* result = (IntTools_SurfaceRangeSample*)instance;
 	result->SetRanges(			
_theRangeU,			
_theRangeV);
}
DECL_EXPORT void IntTools_SurfaceRangeSample_GetRanges72DC087B(
	void* instance,
	void* theRangeU,
	void* theRangeV)
{
		 IntTools_CurveRangeSample &  _theRangeU =*( IntTools_CurveRangeSample *)theRangeU;
		 IntTools_CurveRangeSample &  _theRangeV =*( IntTools_CurveRangeSample *)theRangeV;
	IntTools_SurfaceRangeSample* result = (IntTools_SurfaceRangeSample*)instance;
 	result->GetRanges(			
_theRangeU,			
_theRangeV);
}
DECL_EXPORT void IntTools_SurfaceRangeSample_SetIndexes5107F6FE(
	void* instance,
	int theIndexU,
	int theIndexV)
{
	IntTools_SurfaceRangeSample* result = (IntTools_SurfaceRangeSample*)instance;
 	result->SetIndexes(			
theIndexU,			
theIndexV);
}
DECL_EXPORT void IntTools_SurfaceRangeSample_GetIndexes5107F6FE(
	void* instance,
	int* theIndexU,
	int* theIndexV)
{
	IntTools_SurfaceRangeSample* result = (IntTools_SurfaceRangeSample*)instance;
 	result->GetIndexes(			
*theIndexU,			
*theIndexV);
}
DECL_EXPORT void IntTools_SurfaceRangeSample_GetDepths5107F6FE(
	void* instance,
	int* theDepthU,
	int* theDepthV)
{
	IntTools_SurfaceRangeSample* result = (IntTools_SurfaceRangeSample*)instance;
 	result->GetDepths(			
*theDepthU,			
*theDepthV);
}
DECL_EXPORT void* IntTools_SurfaceRangeSample_GetRangeU89C01C9C(
	void* instance,
	double theFirstU,
	double theLastU,
	int theNbSampleU)
{
	IntTools_SurfaceRangeSample* result = (IntTools_SurfaceRangeSample*)instance;
	return new IntTools_Range( 	result->GetRangeU(			
theFirstU,			
theLastU,			
theNbSampleU));
}
DECL_EXPORT void* IntTools_SurfaceRangeSample_GetRangeV89C01C9C(
	void* instance,
	double theFirstV,
	double theLastV,
	int theNbSampleV)
{
	IntTools_SurfaceRangeSample* result = (IntTools_SurfaceRangeSample*)instance;
	return new IntTools_Range( 	result->GetRangeV(			
theFirstV,			
theLastV,			
theNbSampleV));
}
DECL_EXPORT bool IntTools_SurfaceRangeSample_IsEqual7CD3FA85(
	void* instance,
	void* Other)
{
		const IntTools_SurfaceRangeSample &  _Other =*(const IntTools_SurfaceRangeSample *)Other;
	IntTools_SurfaceRangeSample* result = (IntTools_SurfaceRangeSample*)instance;
	return  	result->IsEqual(			
_Other);
}
DECL_EXPORT int IntTools_SurfaceRangeSample_GetRangeIndexUDeeperE8219145(
	void* instance,
	int theNbSampleU)
{
	IntTools_SurfaceRangeSample* result = (IntTools_SurfaceRangeSample*)instance;
	return  	result->GetRangeIndexUDeeper(			
theNbSampleU);
}
DECL_EXPORT int IntTools_SurfaceRangeSample_GetRangeIndexVDeeperE8219145(
	void* instance,
	int theNbSampleV)
{
	IntTools_SurfaceRangeSample* result = (IntTools_SurfaceRangeSample*)instance;
	return  	result->GetRangeIndexVDeeper(			
theNbSampleV);
}
DECL_EXPORT void IntTools_SurfaceRangeSample_SetSampleRangeU(void* instance, void* value)
{
	IntTools_SurfaceRangeSample* result = (IntTools_SurfaceRangeSample*)instance;
		result->SetSampleRangeU(*(const IntTools_CurveRangeSample *)value);
}

DECL_EXPORT void* IntTools_SurfaceRangeSample_GetSampleRangeU(void* instance)
{
	IntTools_SurfaceRangeSample* result = (IntTools_SurfaceRangeSample*)instance;
	return 	new IntTools_CurveRangeSample(	result->GetSampleRangeU());
}

DECL_EXPORT void IntTools_SurfaceRangeSample_SetSampleRangeV(void* instance, void* value)
{
	IntTools_SurfaceRangeSample* result = (IntTools_SurfaceRangeSample*)instance;
		result->SetSampleRangeV(*(const IntTools_CurveRangeSample *)value);
}

DECL_EXPORT void* IntTools_SurfaceRangeSample_GetSampleRangeV(void* instance)
{
	IntTools_SurfaceRangeSample* result = (IntTools_SurfaceRangeSample*)instance;
	return 	new IntTools_CurveRangeSample(	result->GetSampleRangeV());
}

DECL_EXPORT void IntTools_SurfaceRangeSample_SetIndexU(void* instance, int value)
{
	IntTools_SurfaceRangeSample* result = (IntTools_SurfaceRangeSample*)instance;
		result->SetIndexU(value);
}

DECL_EXPORT int IntTools_SurfaceRangeSample_GetIndexU(void* instance)
{
	IntTools_SurfaceRangeSample* result = (IntTools_SurfaceRangeSample*)instance;
	return 	result->GetIndexU();
}

DECL_EXPORT void IntTools_SurfaceRangeSample_SetIndexV(void* instance, int value)
{
	IntTools_SurfaceRangeSample* result = (IntTools_SurfaceRangeSample*)instance;
		result->SetIndexV(value);
}

DECL_EXPORT int IntTools_SurfaceRangeSample_GetIndexV(void* instance)
{
	IntTools_SurfaceRangeSample* result = (IntTools_SurfaceRangeSample*)instance;
	return 	result->GetIndexV();
}

DECL_EXPORT void IntTools_SurfaceRangeSample_SetDepthU(void* instance, int value)
{
	IntTools_SurfaceRangeSample* result = (IntTools_SurfaceRangeSample*)instance;
		result->SetDepthU(value);
}

DECL_EXPORT int IntTools_SurfaceRangeSample_GetDepthU(void* instance)
{
	IntTools_SurfaceRangeSample* result = (IntTools_SurfaceRangeSample*)instance;
	return 	result->GetDepthU();
}

DECL_EXPORT void IntTools_SurfaceRangeSample_SetDepthV(void* instance, int value)
{
	IntTools_SurfaceRangeSample* result = (IntTools_SurfaceRangeSample*)instance;
		result->SetDepthV(value);
}

DECL_EXPORT int IntTools_SurfaceRangeSample_GetDepthV(void* instance)
{
	IntTools_SurfaceRangeSample* result = (IntTools_SurfaceRangeSample*)instance;
	return 	result->GetDepthV();
}

DECL_EXPORT void IntToolsSurfaceRangeSample_Dtor(void* instance)
{
	delete (IntTools_SurfaceRangeSample*)instance;
}
