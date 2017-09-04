#include "BRepGProp.h"
#include <BRepGProp.hxx>


DECL_EXPORT void BRepGProp_LinearProperties883E019(
	void* S,
	void* LProps)
{
		const TopoDS_Shape &  _S =*(const TopoDS_Shape *)S;
		GProp_GProps &  _LProps =*(GProp_GProps *)LProps;
 BRepGProp::LinearProperties(			
_S,			
_LProps);
}
DECL_EXPORT void BRepGProp_SurfaceProperties883E019(
	void* S,
	void* SProps)
{
		const TopoDS_Shape &  _S =*(const TopoDS_Shape *)S;
		GProp_GProps &  _SProps =*(GProp_GProps *)SProps;
 BRepGProp::SurfaceProperties(			
_S,			
_SProps);
}
DECL_EXPORT double BRepGProp_SurfacePropertiesCE035849(
	void* S,
	void* SProps,
	double Eps)
{
		const TopoDS_Shape &  _S =*(const TopoDS_Shape *)S;
		GProp_GProps &  _SProps =*(GProp_GProps *)SProps;
	return  BRepGProp::SurfaceProperties(			
_S,			
_SProps,			
Eps);
}
DECL_EXPORT void BRepGProp_VolumeProperties6CC68073(
	void* S,
	void* VProps,
	bool OnlyClosed)
{
		const TopoDS_Shape &  _S =*(const TopoDS_Shape *)S;
		GProp_GProps &  _VProps =*(GProp_GProps *)VProps;
 BRepGProp::VolumeProperties(			
_S,			
_VProps,			
(Standard_Boolean)OnlyClosed);
}
DECL_EXPORT double BRepGProp_VolumeProperties95E7E8(
	void* S,
	void* VProps,
	double Eps,
	bool OnlyClosed)
{
		const TopoDS_Shape &  _S =*(const TopoDS_Shape *)S;
		GProp_GProps &  _VProps =*(GProp_GProps *)VProps;
	return  BRepGProp::VolumeProperties(			
_S,			
_VProps,			
Eps,			
OnlyClosed);
}
DECL_EXPORT double BRepGProp_VolumePropertiesGK7C6171BD(
	void* S,
	void* VProps,
	double Eps,
	bool OnlyClosed,
	bool IsUseSpan,
	bool CGFlag,
	bool IFlag)
{
		const TopoDS_Shape &  _S =*(const TopoDS_Shape *)S;
		GProp_GProps &  _VProps =*(GProp_GProps *)VProps;
	return  BRepGProp::VolumePropertiesGK(			
_S,			
_VProps,			
Eps,			
OnlyClosed,			
IsUseSpan,			
CGFlag,			
IFlag);
}
DECL_EXPORT double BRepGProp_VolumePropertiesGKD4DE636B(
	void* S,
	void* VProps,
	void* thePln,
	double Eps,
	bool OnlyClosed,
	bool IsUseSpan,
	bool CGFlag,
	bool IFlag)
{
		const TopoDS_Shape &  _S =*(const TopoDS_Shape *)S;
		GProp_GProps &  _VProps =*(GProp_GProps *)VProps;
		const gp_Pln &  _thePln =*(const gp_Pln *)thePln;
	return  BRepGProp::VolumePropertiesGK(			
_S,			
_VProps,			
_thePln,			
Eps,			
OnlyClosed,			
IsUseSpan,			
CGFlag,			
IFlag);
}
DECL_EXPORT void BRepGProp_Dtor(void* instance)
{
	delete (BRepGProp*)instance;
}
