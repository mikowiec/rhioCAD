#include "Visual3dSetOfView.h"
#include <Visual3d_SetOfView.hxx>


DECL_EXPORT void* Visual3d_SetOfView_Ctor()
{
	return new Visual3d_SetOfView();
}
DECL_EXPORT void Visual3d_SetOfView_Clear(void* instance)
{
	Visual3d_SetOfView* result = (Visual3d_SetOfView*)instance;
 	result->Clear();
}
DECL_EXPORT bool Visual3d_SetOfView_Add68FD189(
	void* instance,
	void* T)
{
		const Handle_Visual3d_View&  _T =*(const Handle_Visual3d_View *)T;
	Visual3d_SetOfView* result = (Visual3d_SetOfView*)instance;
	return  	result->Add(			
_T);
}
DECL_EXPORT bool Visual3d_SetOfView_Remove68FD189(
	void* instance,
	void* T)
{
		const Handle_Visual3d_View&  _T =*(const Handle_Visual3d_View *)T;
	Visual3d_SetOfView* result = (Visual3d_SetOfView*)instance;
	return  	result->Remove(			
_T);
}
DECL_EXPORT void Visual3d_SetOfView_UnionF34A7047(
	void* instance,
	void* B)
{
		const Visual3d_SetOfView &  _B =*(const Visual3d_SetOfView *)B;
	Visual3d_SetOfView* result = (Visual3d_SetOfView*)instance;
 	result->Union(			
_B);
}
DECL_EXPORT void Visual3d_SetOfView_IntersectionF34A7047(
	void* instance,
	void* B)
{
		const Visual3d_SetOfView &  _B =*(const Visual3d_SetOfView *)B;
	Visual3d_SetOfView* result = (Visual3d_SetOfView*)instance;
 	result->Intersection(			
_B);
}
DECL_EXPORT void Visual3d_SetOfView_DifferenceF34A7047(
	void* instance,
	void* B)
{
		const Visual3d_SetOfView &  _B =*(const Visual3d_SetOfView *)B;
	Visual3d_SetOfView* result = (Visual3d_SetOfView*)instance;
 	result->Difference(			
_B);
}
DECL_EXPORT bool Visual3d_SetOfView_Contains68FD189(
	void* instance,
	void* T)
{
		const Handle_Visual3d_View&  _T =*(const Handle_Visual3d_View *)T;
	Visual3d_SetOfView* result = (Visual3d_SetOfView*)instance;
	return  	result->Contains(			
_T);
}
DECL_EXPORT bool Visual3d_SetOfView_IsASubsetF34A7047(
	void* instance,
	void* S)
{
		const Visual3d_SetOfView &  _S =*(const Visual3d_SetOfView *)S;
	Visual3d_SetOfView* result = (Visual3d_SetOfView*)instance;
	return  	result->IsASubset(			
_S);
}
DECL_EXPORT bool Visual3d_SetOfView_IsAProperSubsetF34A7047(
	void* instance,
	void* S)
{
		const Visual3d_SetOfView &  _S =*(const Visual3d_SetOfView *)S;
	Visual3d_SetOfView* result = (Visual3d_SetOfView*)instance;
	return  	result->IsAProperSubset(			
_S);
}
DECL_EXPORT int Visual3d_SetOfView_Extent(void* instance)
{
	Visual3d_SetOfView* result = (Visual3d_SetOfView*)instance;
	return 	result->Extent();
}

DECL_EXPORT bool Visual3d_SetOfView_IsEmpty(void* instance)
{
	Visual3d_SetOfView* result = (Visual3d_SetOfView*)instance;
	return 	result->IsEmpty();
}

DECL_EXPORT void Visual3dSetOfView_Dtor(void* instance)
{
	delete (Visual3d_SetOfView*)instance;
}
