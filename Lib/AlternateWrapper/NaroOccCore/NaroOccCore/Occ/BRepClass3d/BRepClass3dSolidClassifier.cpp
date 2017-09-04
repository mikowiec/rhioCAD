#include "BRepClass3dSolidClassifier.h"
#include <BRepClass3d_SolidClassifier.hxx>


DECL_EXPORT void* BRepClass3d_SolidClassifier_Ctor()
{
	return new BRepClass3d_SolidClassifier();
}
DECL_EXPORT void* BRepClass3d_SolidClassifier_Ctor9EBAC0C0(
	void* S)
{
		const TopoDS_Shape &  _S =*(const TopoDS_Shape *)S;
	return new BRepClass3d_SolidClassifier(			
_S);
}
DECL_EXPORT void* BRepClass3d_SolidClassifier_CtorAB62C26C(
	void* S,
	void* P,
	double Tol)
{
		const TopoDS_Shape &  _S =*(const TopoDS_Shape *)S;
		const gp_Pnt &  _P =*(const gp_Pnt *)P;
	return new BRepClass3d_SolidClassifier(			
_S,			
_P,			
Tol);
}
DECL_EXPORT void BRepClass3d_SolidClassifier_Load9EBAC0C0(
	void* instance,
	void* S)
{
		const TopoDS_Shape &  _S =*(const TopoDS_Shape *)S;
	BRepClass3d_SolidClassifier* result = (BRepClass3d_SolidClassifier*)instance;
 	result->Load(			
_S);
}
DECL_EXPORT void BRepClass3d_SolidClassifier_PerformF0D1E3E6(
	void* instance,
	void* P,
	double Tol)
{
		const gp_Pnt &  _P =*(const gp_Pnt *)P;
	BRepClass3d_SolidClassifier* result = (BRepClass3d_SolidClassifier*)instance;
 	result->Perform(			
_P,			
Tol);
}
DECL_EXPORT void BRepClass3d_SolidClassifier_PerformInfinitePointD82819F3(
	void* instance,
	double Tol)
{
	BRepClass3d_SolidClassifier* result = (BRepClass3d_SolidClassifier*)instance;
 	result->PerformInfinitePoint(			
Tol);
}
DECL_EXPORT void BRepClass3dSolidClassifier_Dtor(void* instance)
{
	delete (BRepClass3d_SolidClassifier*)instance;
}
