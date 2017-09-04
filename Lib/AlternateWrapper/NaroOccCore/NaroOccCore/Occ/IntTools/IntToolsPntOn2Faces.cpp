#include "IntToolsPntOn2Faces.h"
#include <IntTools_PntOn2Faces.hxx>

#include <IntTools_PntOnFace.hxx>

DECL_EXPORT void* IntTools_PntOn2Faces_Ctor()
{
	return new IntTools_PntOn2Faces();
}
DECL_EXPORT void* IntTools_PntOn2Faces_Ctor85669E67(
	void* aP1,
	void* aP2)
{
		const IntTools_PntOnFace &  _aP1 =*(const IntTools_PntOnFace *)aP1;
		const IntTools_PntOnFace &  _aP2 =*(const IntTools_PntOnFace *)aP2;
	return new IntTools_PntOn2Faces(			
_aP1,			
_aP2);
}
DECL_EXPORT void IntTools_PntOn2Faces_SetValid(void* instance, bool value)
{
	IntTools_PntOn2Faces* result = (IntTools_PntOn2Faces*)instance;
		result->SetValid(value);
}

DECL_EXPORT void IntTools_PntOn2Faces_SetP1(void* instance, void* value)
{
	IntTools_PntOn2Faces* result = (IntTools_PntOn2Faces*)instance;
		result->SetP1(*(const IntTools_PntOnFace *)value);
}

DECL_EXPORT void* IntTools_PntOn2Faces_P1(void* instance)
{
	IntTools_PntOn2Faces* result = (IntTools_PntOn2Faces*)instance;
	return 	new IntTools_PntOnFace(	result->P1());
}

DECL_EXPORT void IntTools_PntOn2Faces_SetP2(void* instance, void* value)
{
	IntTools_PntOn2Faces* result = (IntTools_PntOn2Faces*)instance;
		result->SetP2(*(const IntTools_PntOnFace *)value);
}

DECL_EXPORT void* IntTools_PntOn2Faces_P2(void* instance)
{
	IntTools_PntOn2Faces* result = (IntTools_PntOn2Faces*)instance;
	return 	new IntTools_PntOnFace(	result->P2());
}

DECL_EXPORT bool IntTools_PntOn2Faces_IsValid(void* instance)
{
	IntTools_PntOn2Faces* result = (IntTools_PntOn2Faces*)instance;
	return 	result->IsValid();
}

DECL_EXPORT void IntToolsPntOn2Faces_Dtor(void* instance)
{
	delete (IntTools_PntOn2Faces*)instance;
}
