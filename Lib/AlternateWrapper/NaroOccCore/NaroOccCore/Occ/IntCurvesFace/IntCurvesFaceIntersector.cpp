#include "IntCurvesFaceIntersector.h"
#include <IntCurvesFace_Intersector.hxx>

#include <Bnd_Box.hxx>
#include <gp_Pnt.hxx>
#include <TopoDS_Face.hxx>

DECL_EXPORT void* IntCurvesFace_Intersector_Ctor5D6B238E(
	void* F,
	double aTol)
{
		const TopoDS_Face &  _F =*(const TopoDS_Face *)F;
	return new IntCurvesFace_Intersector(			
_F,			
aTol);
}
DECL_EXPORT void IntCurvesFace_Intersector_Perform13A123E9(
	void* instance,
	void* L,
	double PInf,
	double PSup)
{
		const gp_Lin &  _L =*(const gp_Lin *)L;
	IntCurvesFace_Intersector* result = (IntCurvesFace_Intersector*)instance;
 	result->Perform(			
_L,			
PInf,			
PSup);
}
DECL_EXPORT void IntCurvesFace_Intersector_Perform42BE7C73(
	void* instance,
	void* HCu,
	double PInf,
	double PSup)
{
		const Handle_Adaptor3d_HCurve&  _HCu =*(const Handle_Adaptor3d_HCurve *)HCu;
	IntCurvesFace_Intersector* result = (IntCurvesFace_Intersector*)instance;
 	result->Perform(			
_HCu,			
PInf,			
PSup);
}
DECL_EXPORT double IntCurvesFace_Intersector_UParameterE8219145(
	void* instance,
	int I)
{
	IntCurvesFace_Intersector* result = (IntCurvesFace_Intersector*)instance;
	return  	result->UParameter(			
I);
}
DECL_EXPORT double IntCurvesFace_Intersector_VParameterE8219145(
	void* instance,
	int I)
{
	IntCurvesFace_Intersector* result = (IntCurvesFace_Intersector*)instance;
	return  	result->VParameter(			
I);
}
DECL_EXPORT double IntCurvesFace_Intersector_WParameterE8219145(
	void* instance,
	int I)
{
	IntCurvesFace_Intersector* result = (IntCurvesFace_Intersector*)instance;
	return  	result->WParameter(			
I);
}
DECL_EXPORT void* IntCurvesFace_Intersector_PntE8219145(
	void* instance,
	int I)
{
	IntCurvesFace_Intersector* result = (IntCurvesFace_Intersector*)instance;
	return new gp_Pnt( 	result->Pnt(			
I));
}
DECL_EXPORT int IntCurvesFace_Intersector_TransitionE8219145(
	void* instance,
	int I)
{
	IntCurvesFace_Intersector* result = (IntCurvesFace_Intersector*)instance;
	return  	result->Transition(			
I);
}
DECL_EXPORT int IntCurvesFace_Intersector_StateE8219145(
	void* instance,
	int I)
{
	IntCurvesFace_Intersector* result = (IntCurvesFace_Intersector*)instance;
	return  	result->State(			
I);
}
DECL_EXPORT int IntCurvesFace_Intersector_ClassifyUVPoint6203658C(
	void* instance,
	void* Puv)
{
		const gp_Pnt2d &  _Puv =*(const gp_Pnt2d *)Puv;
	IntCurvesFace_Intersector* result = (IntCurvesFace_Intersector*)instance;
	return  	result->ClassifyUVPoint(			
_Puv);
}
DECL_EXPORT int IntCurvesFace_Intersector_SurfaceType(void* instance)
{
	IntCurvesFace_Intersector* result = (IntCurvesFace_Intersector*)instance;
	return (int)	result->SurfaceType();
}

DECL_EXPORT bool IntCurvesFace_Intersector_IsDone(void* instance)
{
	IntCurvesFace_Intersector* result = (IntCurvesFace_Intersector*)instance;
	return 	result->IsDone();
}

DECL_EXPORT int IntCurvesFace_Intersector_NbPnt(void* instance)
{
	IntCurvesFace_Intersector* result = (IntCurvesFace_Intersector*)instance;
	return 	result->NbPnt();
}

DECL_EXPORT void* IntCurvesFace_Intersector_Face(void* instance)
{
	IntCurvesFace_Intersector* result = (IntCurvesFace_Intersector*)instance;
	return 	new TopoDS_Face(	result->Face());
}

DECL_EXPORT void* IntCurvesFace_Intersector_Bounding(void* instance)
{
	IntCurvesFace_Intersector* result = (IntCurvesFace_Intersector*)instance;
	return 	new Bnd_Box(	result->Bounding());
}

DECL_EXPORT void IntCurvesFaceIntersector_Dtor(void* instance)
{
	delete (IntCurvesFace_Intersector*)instance;
}
