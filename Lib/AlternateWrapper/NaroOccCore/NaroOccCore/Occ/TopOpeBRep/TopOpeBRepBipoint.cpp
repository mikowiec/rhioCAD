#include "TopOpeBRepBipoint.h"
#include <TopOpeBRep_Bipoint.hxx>


DECL_EXPORT void* TopOpeBRep_Bipoint_Ctor()
{
	return new TopOpeBRep_Bipoint();
}
DECL_EXPORT void* TopOpeBRep_Bipoint_Ctor5107F6FE(
	int I1,
	int I2)
{
	return new TopOpeBRep_Bipoint(			
I1,			
I2);
}
DECL_EXPORT int TopOpeBRep_Bipoint_I1(void* instance)
{
	TopOpeBRep_Bipoint* result = (TopOpeBRep_Bipoint*)instance;
	return 	result->I1();
}

DECL_EXPORT int TopOpeBRep_Bipoint_I2(void* instance)
{
	TopOpeBRep_Bipoint* result = (TopOpeBRep_Bipoint*)instance;
	return 	result->I2();
}

DECL_EXPORT void TopOpeBRepBipoint_Dtor(void* instance)
{
	delete (TopOpeBRep_Bipoint*)instance;
}
