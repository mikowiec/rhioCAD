#include "BRepBuilderAPIMakeFace.h"
#include <BRepBuilderAPI_MakeFace.hxx>

#include <TopoDS_Face.hxx>

DECL_EXPORT void* BRepBuilderAPI_MakeFace_Ctor()
{
	return new BRepBuilderAPI_MakeFace();
}
DECL_EXPORT void* BRepBuilderAPI_MakeFace_CtorAEC70AC1(
	void* F)
{
		const TopoDS_Face &  _F =*(const TopoDS_Face *)F;
	return new BRepBuilderAPI_MakeFace(			
_F);
}
DECL_EXPORT void* BRepBuilderAPI_MakeFace_Ctor9914D2AD(
	void* P)
{
		const gp_Pln &  _P =*(const gp_Pln *)P;
	return new BRepBuilderAPI_MakeFace(			
_P);
}
DECL_EXPORT void* BRepBuilderAPI_MakeFace_Ctor67FD6A6(
	void* C)
{
		const gp_Cylinder &  _C =*(const gp_Cylinder *)C;
	return new BRepBuilderAPI_MakeFace(			
_C);
}
DECL_EXPORT void* BRepBuilderAPI_MakeFace_Ctor25F8D29C(
	void* C)
{
		const gp_Cone &  _C =*(const gp_Cone *)C;
	return new BRepBuilderAPI_MakeFace(			
_C);
}
DECL_EXPORT void* BRepBuilderAPI_MakeFace_Ctor95E480D1(
	void* S)
{
		const gp_Sphere &  _S =*(const gp_Sphere *)S;
	return new BRepBuilderAPI_MakeFace(			
_S);
}
DECL_EXPORT void* BRepBuilderAPI_MakeFace_CtorC906A96F(
	void* C)
{
		const gp_Torus &  _C =*(const gp_Torus *)C;
	return new BRepBuilderAPI_MakeFace(			
_C);
}
DECL_EXPORT void* BRepBuilderAPI_MakeFace_Ctor4C43CA45(
	void* S,
	double TolDegen)
{
		const Handle_Geom_Surface&  _S =*(const Handle_Geom_Surface *)S;
	return new BRepBuilderAPI_MakeFace(			
_S,			
TolDegen);
}
DECL_EXPORT void* BRepBuilderAPI_MakeFace_CtorDD072DE5(
	void* P,
	double UMin,
	double UMax,
	double VMin,
	double VMax)
{
		const gp_Pln &  _P =*(const gp_Pln *)P;
	return new BRepBuilderAPI_MakeFace(			
_P,			
UMin,			
UMax,			
VMin,			
VMax);
}
DECL_EXPORT void* BRepBuilderAPI_MakeFace_Ctor1CF3267A(
	void* C,
	double UMin,
	double UMax,
	double VMin,
	double VMax)
{
		const gp_Cylinder &  _C =*(const gp_Cylinder *)C;
	return new BRepBuilderAPI_MakeFace(			
_C,			
UMin,			
UMax,			
VMin,			
VMax);
}
DECL_EXPORT void* BRepBuilderAPI_MakeFace_Ctor90A7A2D3(
	void* C,
	double UMin,
	double UMax,
	double VMin,
	double VMax)
{
		const gp_Cone &  _C =*(const gp_Cone *)C;
	return new BRepBuilderAPI_MakeFace(			
_C,			
UMin,			
UMax,			
VMin,			
VMax);
}
DECL_EXPORT void* BRepBuilderAPI_MakeFace_CtorDF1FCE01(
	void* S,
	double UMin,
	double UMax,
	double VMin,
	double VMax)
{
		const gp_Sphere &  _S =*(const gp_Sphere *)S;
	return new BRepBuilderAPI_MakeFace(			
_S,			
UMin,			
UMax,			
VMin,			
VMax);
}
DECL_EXPORT void* BRepBuilderAPI_MakeFace_Ctor126052F0(
	void* C,
	double UMin,
	double UMax,
	double VMin,
	double VMax)
{
		const gp_Torus &  _C =*(const gp_Torus *)C;
	return new BRepBuilderAPI_MakeFace(			
_C,			
UMin,			
UMax,			
VMin,			
VMax);
}
DECL_EXPORT void* BRepBuilderAPI_MakeFace_Ctor8F43826(
	void* S,
	double UMin,
	double UMax,
	double VMin,
	double VMax,
	double TolDegen)
{
		const Handle_Geom_Surface&  _S =*(const Handle_Geom_Surface *)S;
	return new BRepBuilderAPI_MakeFace(			
_S,			
UMin,			
UMax,			
VMin,			
VMax,			
TolDegen);
}
DECL_EXPORT void* BRepBuilderAPI_MakeFace_CtorF673DC3(
	void* W,
	bool OnlyPlane)
{
		const TopoDS_Wire &  _W =*(const TopoDS_Wire *)W;
	return new BRepBuilderAPI_MakeFace(			
_W,			
OnlyPlane);
}
DECL_EXPORT void* BRepBuilderAPI_MakeFace_CtorF0D4468(
	void* P,
	void* W,
	bool Inside)
{
		const gp_Pln &  _P =*(const gp_Pln *)P;
		const TopoDS_Wire &  _W =*(const TopoDS_Wire *)W;
	return new BRepBuilderAPI_MakeFace(			
_P,			
_W,			
Inside);
}
DECL_EXPORT void* BRepBuilderAPI_MakeFace_Ctor7D92CEE4(
	void* C,
	void* W,
	bool Inside)
{
		const gp_Cylinder &  _C =*(const gp_Cylinder *)C;
		const TopoDS_Wire &  _W =*(const TopoDS_Wire *)W;
	return new BRepBuilderAPI_MakeFace(			
_C,			
_W,			
Inside);
}
DECL_EXPORT void* BRepBuilderAPI_MakeFace_Ctor1AD3E6A2(
	void* C,
	void* W,
	bool Inside)
{
		const gp_Cone &  _C =*(const gp_Cone *)C;
		const TopoDS_Wire &  _W =*(const TopoDS_Wire *)W;
	return new BRepBuilderAPI_MakeFace(			
_C,			
_W,			
Inside);
}
DECL_EXPORT void* BRepBuilderAPI_MakeFace_Ctor9D6BF994(
	void* S,
	void* W,
	bool Inside)
{
		const gp_Sphere &  _S =*(const gp_Sphere *)S;
		const TopoDS_Wire &  _W =*(const TopoDS_Wire *)W;
	return new BRepBuilderAPI_MakeFace(			
_S,			
_W,			
Inside);
}
DECL_EXPORT void* BRepBuilderAPI_MakeFace_Ctor570E9DA5(
	void* C,
	void* W,
	bool Inside)
{
		const gp_Torus &  _C =*(const gp_Torus *)C;
		const TopoDS_Wire &  _W =*(const TopoDS_Wire *)W;
	return new BRepBuilderAPI_MakeFace(			
_C,			
_W,			
Inside);
}
DECL_EXPORT void* BRepBuilderAPI_MakeFace_CtorC9D68572(
	void* S,
	void* W,
	bool Inside)
{
		const Handle_Geom_Surface&  _S =*(const Handle_Geom_Surface *)S;
		const TopoDS_Wire &  _W =*(const TopoDS_Wire *)W;
	return new BRepBuilderAPI_MakeFace(			
_S,			
_W,			
Inside);
}
DECL_EXPORT void* BRepBuilderAPI_MakeFace_Ctor15D7DFC2(
	void* F,
	void* W)
{
		const TopoDS_Face &  _F =*(const TopoDS_Face *)F;
		const TopoDS_Wire &  _W =*(const TopoDS_Wire *)W;
	return new BRepBuilderAPI_MakeFace(			
_F,			
_W);
}
DECL_EXPORT void BRepBuilderAPI_MakeFace_InitAEC70AC1(
	void* instance,
	void* F)
{
		const TopoDS_Face &  _F =*(const TopoDS_Face *)F;
	BRepBuilderAPI_MakeFace* result = (BRepBuilderAPI_MakeFace*)instance;
 	result->Init(			
_F);
}
DECL_EXPORT void BRepBuilderAPI_MakeFace_Init78C1643F(
	void* instance,
	void* S,
	bool Bound,
	double TolDegen)
{
		const Handle_Geom_Surface&  _S =*(const Handle_Geom_Surface *)S;
	BRepBuilderAPI_MakeFace* result = (BRepBuilderAPI_MakeFace*)instance;
 	result->Init(			
_S,			
Bound,			
TolDegen);
}
DECL_EXPORT void BRepBuilderAPI_MakeFace_Init8F43826(
	void* instance,
	void* S,
	double UMin,
	double UMax,
	double VMin,
	double VMax,
	double TolDegen)
{
		const Handle_Geom_Surface&  _S =*(const Handle_Geom_Surface *)S;
	BRepBuilderAPI_MakeFace* result = (BRepBuilderAPI_MakeFace*)instance;
 	result->Init(			
_S,			
UMin,			
UMax,			
VMin,			
VMax,			
TolDegen);
}
DECL_EXPORT void BRepBuilderAPI_MakeFace_Add368EDFE5(
	void* instance,
	void* W)
{
		const TopoDS_Wire &  _W =*(const TopoDS_Wire *)W;
	BRepBuilderAPI_MakeFace* result = (BRepBuilderAPI_MakeFace*)instance;
 	result->Add(			
_W);
}
DECL_EXPORT bool BRepBuilderAPI_MakeFace_IsDone(void* instance)
{
	BRepBuilderAPI_MakeFace* result = (BRepBuilderAPI_MakeFace*)instance;
	return 	result->IsDone();
}

DECL_EXPORT int BRepBuilderAPI_MakeFace_Error(void* instance)
{
	BRepBuilderAPI_MakeFace* result = (BRepBuilderAPI_MakeFace*)instance;
	return (int)	result->Error();
}

DECL_EXPORT void* BRepBuilderAPI_MakeFace_Face(void* instance)
{
	BRepBuilderAPI_MakeFace* result = (BRepBuilderAPI_MakeFace*)instance;
	return 	new TopoDS_Face(	result->Face());
}

DECL_EXPORT void BRepBuilderAPIMakeFace_Dtor(void* instance)
{
	delete (BRepBuilderAPI_MakeFace*)instance;
}
