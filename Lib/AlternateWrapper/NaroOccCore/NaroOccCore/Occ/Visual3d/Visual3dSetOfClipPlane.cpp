#include "Visual3dSetOfClipPlane.h"
#include <Visual3d_SetOfClipPlane.hxx>


DECL_EXPORT void* Visual3d_SetOfClipPlane_Ctor()
{
	return new Visual3d_SetOfClipPlane();
}
DECL_EXPORT void Visual3d_SetOfClipPlane_Clear(void* instance)
{
	Visual3d_SetOfClipPlane* result = (Visual3d_SetOfClipPlane*)instance;
 	result->Clear();
}
DECL_EXPORT bool Visual3d_SetOfClipPlane_Add97234D4A(
	void* instance,
	void* T)
{
		const Handle_Visual3d_ClipPlane&  _T =*(const Handle_Visual3d_ClipPlane *)T;
	Visual3d_SetOfClipPlane* result = (Visual3d_SetOfClipPlane*)instance;
	return  	result->Add(			
_T);
}
DECL_EXPORT bool Visual3d_SetOfClipPlane_Remove97234D4A(
	void* instance,
	void* T)
{
		const Handle_Visual3d_ClipPlane&  _T =*(const Handle_Visual3d_ClipPlane *)T;
	Visual3d_SetOfClipPlane* result = (Visual3d_SetOfClipPlane*)instance;
	return  	result->Remove(			
_T);
}
DECL_EXPORT void Visual3d_SetOfClipPlane_Union129D9308(
	void* instance,
	void* B)
{
		const Visual3d_SetOfClipPlane &  _B =*(const Visual3d_SetOfClipPlane *)B;
	Visual3d_SetOfClipPlane* result = (Visual3d_SetOfClipPlane*)instance;
 	result->Union(			
_B);
}
DECL_EXPORT void Visual3d_SetOfClipPlane_Intersection129D9308(
	void* instance,
	void* B)
{
		const Visual3d_SetOfClipPlane &  _B =*(const Visual3d_SetOfClipPlane *)B;
	Visual3d_SetOfClipPlane* result = (Visual3d_SetOfClipPlane*)instance;
 	result->Intersection(			
_B);
}
DECL_EXPORT void Visual3d_SetOfClipPlane_Difference129D9308(
	void* instance,
	void* B)
{
		const Visual3d_SetOfClipPlane &  _B =*(const Visual3d_SetOfClipPlane *)B;
	Visual3d_SetOfClipPlane* result = (Visual3d_SetOfClipPlane*)instance;
 	result->Difference(			
_B);
}
DECL_EXPORT bool Visual3d_SetOfClipPlane_Contains97234D4A(
	void* instance,
	void* T)
{
		const Handle_Visual3d_ClipPlane&  _T =*(const Handle_Visual3d_ClipPlane *)T;
	Visual3d_SetOfClipPlane* result = (Visual3d_SetOfClipPlane*)instance;
	return  	result->Contains(			
_T);
}
DECL_EXPORT bool Visual3d_SetOfClipPlane_IsASubset129D9308(
	void* instance,
	void* S)
{
		const Visual3d_SetOfClipPlane &  _S =*(const Visual3d_SetOfClipPlane *)S;
	Visual3d_SetOfClipPlane* result = (Visual3d_SetOfClipPlane*)instance;
	return  	result->IsASubset(			
_S);
}
DECL_EXPORT bool Visual3d_SetOfClipPlane_IsAProperSubset129D9308(
	void* instance,
	void* S)
{
		const Visual3d_SetOfClipPlane &  _S =*(const Visual3d_SetOfClipPlane *)S;
	Visual3d_SetOfClipPlane* result = (Visual3d_SetOfClipPlane*)instance;
	return  	result->IsAProperSubset(			
_S);
}
DECL_EXPORT int Visual3d_SetOfClipPlane_Extent(void* instance)
{
	Visual3d_SetOfClipPlane* result = (Visual3d_SetOfClipPlane*)instance;
	return 	result->Extent();
}

DECL_EXPORT bool Visual3d_SetOfClipPlane_IsEmpty(void* instance)
{
	Visual3d_SetOfClipPlane* result = (Visual3d_SetOfClipPlane*)instance;
	return 	result->IsEmpty();
}

DECL_EXPORT void Visual3dSetOfClipPlane_Dtor(void* instance)
{
	delete (Visual3d_SetOfClipPlane*)instance;
}
