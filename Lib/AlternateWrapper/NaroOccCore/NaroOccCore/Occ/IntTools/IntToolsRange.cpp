#include "IntToolsRange.h"
#include <IntTools_Range.hxx>


DECL_EXPORT void* IntTools_Range_Ctor()
{
	return new IntTools_Range();
}
DECL_EXPORT void* IntTools_Range_Ctor9F0E714F(
	double aFirst,
	double aLast)
{
	return new IntTools_Range(			
aFirst,			
aLast);
}
DECL_EXPORT void IntTools_Range_Range9F0E714F(
	void* instance,
	double* aFirst,
	double* aLast)
{
	IntTools_Range* result = (IntTools_Range*)instance;
 	result->Range(			
*aFirst,			
*aLast);
}
DECL_EXPORT void IntTools_Range_SetFirst(void* instance, double value)
{
	IntTools_Range* result = (IntTools_Range*)instance;
		result->SetFirst(value);
}

DECL_EXPORT double IntTools_Range_First(void* instance)
{
	IntTools_Range* result = (IntTools_Range*)instance;
	return 	result->First();
}

DECL_EXPORT void IntTools_Range_SetLast(void* instance, double value)
{
	IntTools_Range* result = (IntTools_Range*)instance;
		result->SetLast(value);
}

DECL_EXPORT double IntTools_Range_Last(void* instance)
{
	IntTools_Range* result = (IntTools_Range*)instance;
	return 	result->Last();
}

DECL_EXPORT void IntToolsRange_Dtor(void* instance)
{
	delete (IntTools_Range*)instance;
}
