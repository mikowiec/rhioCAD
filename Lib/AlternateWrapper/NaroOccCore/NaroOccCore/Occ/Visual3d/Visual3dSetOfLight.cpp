#include "Visual3dSetOfLight.h"
#include <Visual3d_SetOfLight.hxx>


DECL_EXPORT void* Visual3d_SetOfLight_Ctor()
{
	return new Visual3d_SetOfLight();
}
DECL_EXPORT void Visual3d_SetOfLight_Clear(void* instance)
{
	Visual3d_SetOfLight* result = (Visual3d_SetOfLight*)instance;
 	result->Clear();
}
DECL_EXPORT bool Visual3d_SetOfLight_Add279ABABC(
	void* instance,
	void* T)
{
		const Handle_Visual3d_Light&  _T =*(const Handle_Visual3d_Light *)T;
	Visual3d_SetOfLight* result = (Visual3d_SetOfLight*)instance;
	return  	result->Add(			
_T);
}
DECL_EXPORT bool Visual3d_SetOfLight_Remove279ABABC(
	void* instance,
	void* T)
{
		const Handle_Visual3d_Light&  _T =*(const Handle_Visual3d_Light *)T;
	Visual3d_SetOfLight* result = (Visual3d_SetOfLight*)instance;
	return  	result->Remove(			
_T);
}
DECL_EXPORT void Visual3d_SetOfLight_Union4AF300FE(
	void* instance,
	void* B)
{
		const Visual3d_SetOfLight &  _B =*(const Visual3d_SetOfLight *)B;
	Visual3d_SetOfLight* result = (Visual3d_SetOfLight*)instance;
 	result->Union(			
_B);
}
DECL_EXPORT void Visual3d_SetOfLight_Intersection4AF300FE(
	void* instance,
	void* B)
{
		const Visual3d_SetOfLight &  _B =*(const Visual3d_SetOfLight *)B;
	Visual3d_SetOfLight* result = (Visual3d_SetOfLight*)instance;
 	result->Intersection(			
_B);
}
DECL_EXPORT void Visual3d_SetOfLight_Difference4AF300FE(
	void* instance,
	void* B)
{
		const Visual3d_SetOfLight &  _B =*(const Visual3d_SetOfLight *)B;
	Visual3d_SetOfLight* result = (Visual3d_SetOfLight*)instance;
 	result->Difference(			
_B);
}
DECL_EXPORT bool Visual3d_SetOfLight_Contains279ABABC(
	void* instance,
	void* T)
{
		const Handle_Visual3d_Light&  _T =*(const Handle_Visual3d_Light *)T;
	Visual3d_SetOfLight* result = (Visual3d_SetOfLight*)instance;
	return  	result->Contains(			
_T);
}
DECL_EXPORT bool Visual3d_SetOfLight_IsASubset4AF300FE(
	void* instance,
	void* S)
{
		const Visual3d_SetOfLight &  _S =*(const Visual3d_SetOfLight *)S;
	Visual3d_SetOfLight* result = (Visual3d_SetOfLight*)instance;
	return  	result->IsASubset(			
_S);
}
DECL_EXPORT bool Visual3d_SetOfLight_IsAProperSubset4AF300FE(
	void* instance,
	void* S)
{
		const Visual3d_SetOfLight &  _S =*(const Visual3d_SetOfLight *)S;
	Visual3d_SetOfLight* result = (Visual3d_SetOfLight*)instance;
	return  	result->IsAProperSubset(			
_S);
}
DECL_EXPORT int Visual3d_SetOfLight_Extent(void* instance)
{
	Visual3d_SetOfLight* result = (Visual3d_SetOfLight*)instance;
	return 	result->Extent();
}

DECL_EXPORT bool Visual3d_SetOfLight_IsEmpty(void* instance)
{
	Visual3d_SetOfLight* result = (Visual3d_SetOfLight*)instance;
	return 	result->IsEmpty();
}

DECL_EXPORT void Visual3dSetOfLight_Dtor(void* instance)
{
	delete (Visual3d_SetOfLight*)instance;
}
