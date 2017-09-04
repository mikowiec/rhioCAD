#include "IntToolsBaseRangeSample.h"
#include <IntTools_BaseRangeSample.hxx>


DECL_EXPORT void* IntTools_BaseRangeSample_Ctor()
{
	return new IntTools_BaseRangeSample();
}
DECL_EXPORT void* IntTools_BaseRangeSample_CtorE8219145(
	int theDepth)
{
	return new IntTools_BaseRangeSample(			
theDepth);
}
DECL_EXPORT void IntTools_BaseRangeSample_SetDepth(void* instance, int value)
{
	IntTools_BaseRangeSample* result = (IntTools_BaseRangeSample*)instance;
		result->SetDepth(value);
}

DECL_EXPORT int IntTools_BaseRangeSample_GetDepth(void* instance)
{
	IntTools_BaseRangeSample* result = (IntTools_BaseRangeSample*)instance;
	return 	result->GetDepth();
}

DECL_EXPORT void IntToolsBaseRangeSample_Dtor(void* instance)
{
	delete (IntTools_BaseRangeSample*)instance;
}
