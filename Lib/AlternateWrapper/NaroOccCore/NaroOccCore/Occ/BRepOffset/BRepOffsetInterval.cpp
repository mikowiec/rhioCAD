#include "BRepOffsetInterval.h"
#include <BRepOffset_Interval.hxx>


DECL_EXPORT void* BRepOffset_Interval_Ctor()
{
	return new BRepOffset_Interval();
}
DECL_EXPORT void* BRepOffset_Interval_CtorF3B48FAD(
	double U1,
	double U2,
	int Type)
{
		const BRepOffset_Type _Type =(const BRepOffset_Type )Type;
	return new BRepOffset_Interval(			
U1,			
U2,			
_Type);
}
DECL_EXPORT void BRepOffset_Interval_FirstD82819F3(
	void* instance,
	double U)
{
	BRepOffset_Interval* result = (BRepOffset_Interval*)instance;
 	result->First(			
U);
}
DECL_EXPORT void BRepOffset_Interval_LastD82819F3(
	void* instance,
	double U)
{
	BRepOffset_Interval* result = (BRepOffset_Interval*)instance;
 	result->Last(			
U);
}
DECL_EXPORT void BRepOffset_Interval_TypeFFDE8065(
	void* instance,
	int T)
{
		const BRepOffset_Type _T =(const BRepOffset_Type )T;
	BRepOffset_Interval* result = (BRepOffset_Interval*)instance;
 	result->Type(			
_T);
}
DECL_EXPORT double BRepOffset_Interval_First(void* instance)
{
	BRepOffset_Interval* result = (BRepOffset_Interval*)instance;
	return  	result->First();
}
DECL_EXPORT double BRepOffset_Interval_Last(void* instance)
{
	BRepOffset_Interval* result = (BRepOffset_Interval*)instance;
	return  	result->Last();
}
DECL_EXPORT int BRepOffset_Interval_Type(void* instance)
{
	BRepOffset_Interval* result = (BRepOffset_Interval*)instance;
	return  	result->Type();
}
DECL_EXPORT void BRepOffsetInterval_Dtor(void* instance)
{
	delete (BRepOffset_Interval*)instance;
}
