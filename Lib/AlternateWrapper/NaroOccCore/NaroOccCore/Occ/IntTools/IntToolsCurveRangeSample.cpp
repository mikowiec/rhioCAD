#include "IntToolsCurveRangeSample.h"
#include <IntTools_CurveRangeSample.hxx>

#include <IntTools_Range.hxx>

DECL_EXPORT void* IntTools_CurveRangeSample_Ctor()
{
	return new IntTools_CurveRangeSample();
}
DECL_EXPORT void* IntTools_CurveRangeSample_CtorE8219145(
	int theIndex)
{
	return new IntTools_CurveRangeSample(			
theIndex);
}
DECL_EXPORT bool IntTools_CurveRangeSample_IsEqual6A019644(
	void* instance,
	void* Other)
{
		const IntTools_CurveRangeSample &  _Other =*(const IntTools_CurveRangeSample *)Other;
	IntTools_CurveRangeSample* result = (IntTools_CurveRangeSample*)instance;
	return  	result->IsEqual(			
_Other);
}
DECL_EXPORT void* IntTools_CurveRangeSample_GetRange89C01C9C(
	void* instance,
	double theFirst,
	double theLast,
	int theNbSample)
{
	IntTools_CurveRangeSample* result = (IntTools_CurveRangeSample*)instance;
	return new IntTools_Range( 	result->GetRange(			
theFirst,			
theLast,			
theNbSample));
}
DECL_EXPORT int IntTools_CurveRangeSample_GetRangeIndexDeeperE8219145(
	void* instance,
	int theNbSample)
{
	IntTools_CurveRangeSample* result = (IntTools_CurveRangeSample*)instance;
	return  	result->GetRangeIndexDeeper(			
theNbSample);
}
DECL_EXPORT void IntTools_CurveRangeSample_SetRangeIndex(void* instance, int value)
{
	IntTools_CurveRangeSample* result = (IntTools_CurveRangeSample*)instance;
		result->SetRangeIndex(value);
}

DECL_EXPORT int IntTools_CurveRangeSample_GetRangeIndex(void* instance)
{
	IntTools_CurveRangeSample* result = (IntTools_CurveRangeSample*)instance;
	return 	result->GetRangeIndex();
}

DECL_EXPORT void IntToolsCurveRangeSample_Dtor(void* instance)
{
	delete (IntTools_CurveRangeSample*)instance;
}
