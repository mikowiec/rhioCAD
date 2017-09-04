#include "BRepAdaptorHSurface.h"
#include <BRepAdaptor_HSurface.hxx>

#include <Adaptor3d_Surface.hxx>
#include <BRepAdaptor_Surface.hxx>

DECL_EXPORT void* BRepAdaptor_HSurface_Ctor()
{
	return new Handle_BRepAdaptor_HSurface(new BRepAdaptor_HSurface());
}
DECL_EXPORT void* BRepAdaptor_HSurface_CtorE0C6985A(
	void* S)
{
		const BRepAdaptor_Surface &  _S =*(const BRepAdaptor_Surface *)S;
	return new Handle_BRepAdaptor_HSurface(new BRepAdaptor_HSurface(			
_S));
}
DECL_EXPORT void BRepAdaptor_HSurface_SetE0C6985A(
	void* instance,
	void* S)
{
		const BRepAdaptor_Surface &  _S =*(const BRepAdaptor_Surface *)S;
	BRepAdaptor_HSurface* result = (BRepAdaptor_HSurface*)(((Handle_BRepAdaptor_HSurface*)instance)->Access());
 	result->Set(			
_S);
}
DECL_EXPORT void* BRepAdaptor_HSurface_Surface(void* instance)
{
	BRepAdaptor_HSurface* result = (BRepAdaptor_HSurface*)(((Handle_BRepAdaptor_HSurface*)instance)->Access());
	return 	new Adaptor3d_Surface(	result->Surface());
}

DECL_EXPORT void* BRepAdaptor_HSurface_ChangeSurface(void* instance)
{
	BRepAdaptor_HSurface* result = (BRepAdaptor_HSurface*)(((Handle_BRepAdaptor_HSurface*)instance)->Access());
	return 	new BRepAdaptor_Surface(	result->ChangeSurface());
}

DECL_EXPORT void BRepAdaptorHSurface_Dtor(void* instance)
{
	delete (Handle_BRepAdaptor_HSurface*)instance;
}
