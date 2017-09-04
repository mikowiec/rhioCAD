#include "IntToolsPntOnFace.h"
#include <IntTools_PntOnFace.hxx>

#include <gp_Pnt.hxx>
#include <TopoDS_Face.hxx>

DECL_EXPORT void* IntTools_PntOnFace_Ctor()
{
	return new IntTools_PntOnFace();
}
DECL_EXPORT void IntTools_PntOnFace_InitB2FF1B6E(
	void* instance,
	void* aF,
	void* aP,
	double U,
	double V)
{
		const TopoDS_Face &  _aF =*(const TopoDS_Face *)aF;
		const gp_Pnt &  _aP =*(const gp_Pnt *)aP;
	IntTools_PntOnFace* result = (IntTools_PntOnFace*)instance;
 	result->Init(			
_aF,			
_aP,			
U,			
V);
}
DECL_EXPORT void IntTools_PntOnFace_SetParameters9F0E714F(
	void* instance,
	double U,
	double V)
{
	IntTools_PntOnFace* result = (IntTools_PntOnFace*)instance;
 	result->SetParameters(			
U,			
V);
}
DECL_EXPORT void IntTools_PntOnFace_Parameters9F0E714F(
	void* instance,
	double* U,
	double* V)
{
	IntTools_PntOnFace* result = (IntTools_PntOnFace*)instance;
 	result->Parameters(			
*U,			
*V);
}
DECL_EXPORT void IntTools_PntOnFace_SetValid(void* instance, bool value)
{
	IntTools_PntOnFace* result = (IntTools_PntOnFace*)instance;
		result->SetValid(value);
}

DECL_EXPORT bool IntTools_PntOnFace_Valid(void* instance)
{
	IntTools_PntOnFace* result = (IntTools_PntOnFace*)instance;
	return 	result->Valid();
}

DECL_EXPORT void IntTools_PntOnFace_SetFace(void* instance, void* value)
{
	IntTools_PntOnFace* result = (IntTools_PntOnFace*)instance;
		result->SetFace(*(const TopoDS_Face *)value);
}

DECL_EXPORT void* IntTools_PntOnFace_Face(void* instance)
{
	IntTools_PntOnFace* result = (IntTools_PntOnFace*)instance;
	return 	new TopoDS_Face(	result->Face());
}

DECL_EXPORT void IntTools_PntOnFace_SetPnt(void* instance, void* value)
{
	IntTools_PntOnFace* result = (IntTools_PntOnFace*)instance;
		result->SetPnt(*(const gp_Pnt *)value);
}

DECL_EXPORT void* IntTools_PntOnFace_Pnt(void* instance)
{
	IntTools_PntOnFace* result = (IntTools_PntOnFace*)instance;
	return 	new gp_Pnt(	result->Pnt());
}

DECL_EXPORT void IntToolsPntOnFace_Dtor(void* instance)
{
	delete (IntTools_PntOnFace*)instance;
}
